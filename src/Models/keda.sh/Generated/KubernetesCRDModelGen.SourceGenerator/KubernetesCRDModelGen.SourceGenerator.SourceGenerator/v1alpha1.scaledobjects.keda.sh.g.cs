#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keda.sh;
/// <summary>ScaledObject is a specification for a ScaledObject resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ScaledObjectList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ScaledObject>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ScaledObjectList";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "scaledobjects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keda.sh/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScaledObjectList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ScaledObject objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ScaledObject> Items { get; set; }
}

/// <summary>HPAScalingPolicy is a single policy which must hold true for a specified past interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDownPolicies
{
    /// <summary>
    /// periodSeconds specifies the window of time for which the policy should hold true.
    /// PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public required int PeriodSeconds { get; set; }

    /// <summary>type is used to specify the scaling policy.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// value contains the amount of change which is permitted by the policy.
    /// It must be greater than zero
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

/// <summary>
/// scaleDown is scaling policy for scaling Down.
/// If not set, the default value is to allow to scale down to minReplicas pods, with a
/// 300 second stabilization window (i.e., the highest recommendation for
/// the last 300sec is used).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDown
{
    /// <summary>
    /// policies is a list of potential scaling polices which can be used during scaling.
    /// If not set, use the default values:
    /// - For scale up: allow doubling the number of pods, or an absolute change of 4 pods in a 15s window.
    /// - For scale down: allow all pods to be removed in a 15s window.
    /// </summary>
    [JsonPropertyName("policies")]
    public IList<V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDownPolicies>? Policies { get; set; }

    /// <summary>
    /// selectPolicy is used to specify which policy should be used.
    /// If not set, the default value Max is used.
    /// </summary>
    [JsonPropertyName("selectPolicy")]
    public string? SelectPolicy { get; set; }

    /// <summary>
    /// stabilizationWindowSeconds is the number of seconds for which past recommendations should be
    /// considered while scaling up or scaling down.
    /// StabilizationWindowSeconds must be greater than or equal to zero and less than or equal to 3600 (one hour).
    /// If not set, use the default values:
    /// - For scale up: 0 (i.e. no stabilization is done).
    /// - For scale down: 300 (i.e. the stabilization window is 300 seconds long).
    /// </summary>
    [JsonPropertyName("stabilizationWindowSeconds")]
    public int? StabilizationWindowSeconds { get; set; }

    /// <summary>
    /// tolerance is the tolerance on the ratio between the current and desired
    /// metric value under which no updates are made to the desired number of
    /// replicas (e.g. 0.01 for 1%). Must be greater than or equal to zero. If not
    /// set, the default cluster-wide tolerance is applied (by default 10%).
    /// 
    /// For example, if autoscaling is configured with a memory consumption target of 100Mi,
    /// and scale-down and scale-up tolerances of 5% and 1% respectively, scaling will be
    /// triggered when the actual consumption falls below 95Mi or exceeds 101Mi.
    /// 
    /// This is an beta field and requires the HPAConfigurableTolerance feature
    /// gate to be enabled.
    /// </summary>
    [JsonPropertyName("tolerance")]
    public IntOrString? Tolerance { get; set; }
}

/// <summary>HPAScalingPolicy is a single policy which must hold true for a specified past interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUpPolicies
{
    /// <summary>
    /// periodSeconds specifies the window of time for which the policy should hold true.
    /// PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public required int PeriodSeconds { get; set; }

    /// <summary>type is used to specify the scaling policy.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// value contains the amount of change which is permitted by the policy.
    /// It must be greater than zero
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

/// <summary>
/// scaleUp is scaling policy for scaling Up.
/// If not set, the default value is the higher of:
///   * increase no more than 4 pods per 60 seconds
///   * double the number of pods per 60 seconds
/// No stabilization is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUp
{
    /// <summary>
    /// policies is a list of potential scaling polices which can be used during scaling.
    /// If not set, use the default values:
    /// - For scale up: allow doubling the number of pods, or an absolute change of 4 pods in a 15s window.
    /// - For scale down: allow all pods to be removed in a 15s window.
    /// </summary>
    [JsonPropertyName("policies")]
    public IList<V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUpPolicies>? Policies { get; set; }

    /// <summary>
    /// selectPolicy is used to specify which policy should be used.
    /// If not set, the default value Max is used.
    /// </summary>
    [JsonPropertyName("selectPolicy")]
    public string? SelectPolicy { get; set; }

    /// <summary>
    /// stabilizationWindowSeconds is the number of seconds for which past recommendations should be
    /// considered while scaling up or scaling down.
    /// StabilizationWindowSeconds must be greater than or equal to zero and less than or equal to 3600 (one hour).
    /// If not set, use the default values:
    /// - For scale up: 0 (i.e. no stabilization is done).
    /// - For scale down: 300 (i.e. the stabilization window is 300 seconds long).
    /// </summary>
    [JsonPropertyName("stabilizationWindowSeconds")]
    public int? StabilizationWindowSeconds { get; set; }

    /// <summary>
    /// tolerance is the tolerance on the ratio between the current and desired
    /// metric value under which no updates are made to the desired number of
    /// replicas (e.g. 0.01 for 1%). Must be greater than or equal to zero. If not
    /// set, the default cluster-wide tolerance is applied (by default 10%).
    /// 
    /// For example, if autoscaling is configured with a memory consumption target of 100Mi,
    /// and scale-down and scale-up tolerances of 5% and 1% respectively, scaling will be
    /// triggered when the actual consumption falls below 95Mi or exceeds 101Mi.
    /// 
    /// This is an beta field and requires the HPAConfigurableTolerance feature
    /// gate to be enabled.
    /// </summary>
    [JsonPropertyName("tolerance")]
    public IntOrString? Tolerance { get; set; }
}

/// <summary>
/// HorizontalPodAutoscalerBehavior configures the scaling behavior of the target
/// in both Up and Down directions (scaleUp and scaleDown fields respectively).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehavior
{
    /// <summary>
    /// scaleDown is scaling policy for scaling Down.
    /// If not set, the default value is to allow to scale down to minReplicas pods, with a
    /// 300 second stabilization window (i.e., the highest recommendation for
    /// the last 300sec is used).
    /// </summary>
    [JsonPropertyName("scaleDown")]
    public V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDown? ScaleDown { get; set; }

    /// <summary>
    /// scaleUp is scaling policy for scaling Up.
    /// If not set, the default value is the higher of:
    ///   * increase no more than 4 pods per 60 seconds
    ///   * double the number of pods per 60 seconds
    /// No stabilization is used.
    /// </summary>
    [JsonPropertyName("scaleUp")]
    public V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUp? ScaleUp { get; set; }
}

/// <summary>HorizontalPodAutoscalerConfig specifies horizontal scale config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfig
{
    /// <summary>
    /// HorizontalPodAutoscalerBehavior configures the scaling behavior of the target
    /// in both Up and Down directions (scaleUp and scaleDown fields respectively).
    /// </summary>
    [JsonPropertyName("behavior")]
    public V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehavior? Behavior { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// MetricTargetType specifies the type of metric being targeted, and should be either
/// &quot;Value&quot;, &quot;AverageValue&quot;, or &quot;Utilization&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ScaledObjectSpecAdvancedScalingModifiersMetricTypeEnum>))]
public enum V1alpha1ScaledObjectSpecAdvancedScalingModifiersMetricTypeEnum
{
    [EnumMember(Value = "AverageValue"), JsonStringEnumMemberName("AverageValue")]
    AverageValue,
    [EnumMember(Value = "Value"), JsonStringEnumMemberName("Value")]
    Value
}

/// <summary>ScalingModifiers describes advanced scaling logic options like formula</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedScalingModifiers
{
    [JsonPropertyName("activationTarget")]
    public string? ActivationTarget { get; set; }

    [JsonPropertyName("formula")]
    public string? Formula { get; set; }

    /// <summary>
    /// MetricTargetType specifies the type of metric being targeted, and should be either
    /// &quot;Value&quot;, &quot;AverageValue&quot;, or &quot;Utilization&quot;
    /// </summary>
    [JsonPropertyName("metricType")]
    public V1alpha1ScaledObjectSpecAdvancedScalingModifiersMetricTypeEnum? MetricType { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>AdvancedConfig specifies advance scaling options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvanced
{
    /// <summary>HorizontalPodAutoscalerConfig specifies horizontal scale config</summary>
    [JsonPropertyName("horizontalPodAutoscalerConfig")]
    public V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfig? HorizontalPodAutoscalerConfig { get; set; }

    [JsonPropertyName("restoreToOriginalReplicaCount")]
    public bool? RestoreToOriginalReplicaCount { get; set; }

    /// <summary>ScalingModifiers describes advanced scaling logic options like formula</summary>
    [JsonPropertyName("scalingModifiers")]
    public V1alpha1ScaledObjectSpecAdvancedScalingModifiers? ScalingModifiers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ScaledObjectSpecFallbackBehaviorEnum>))]
public enum V1alpha1ScaledObjectSpecFallbackBehaviorEnum
{
    [EnumMember(Value = "static"), JsonStringEnumMemberName("static")]
    Static,
    [EnumMember(Value = "currentReplicas"), JsonStringEnumMemberName("currentReplicas")]
    CurrentReplicas,
    [EnumMember(Value = "currentReplicasIfHigher"), JsonStringEnumMemberName("currentReplicasIfHigher")]
    CurrentReplicasIfHigher,
    [EnumMember(Value = "currentReplicasIfLower"), JsonStringEnumMemberName("currentReplicasIfLower")]
    CurrentReplicasIfLower,
    [EnumMember(Value = "scalingModifiers"), JsonStringEnumMemberName("scalingModifiers")]
    ScalingModifiers
}

/// <summary>Fallback is the spec for fallback options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecFallback
{
    [JsonPropertyName("behavior")]
    public V1alpha1ScaledObjectSpecFallbackBehaviorEnum? Behavior { get; set; }

    [JsonPropertyName("failureThreshold")]
    public required int FailureThreshold { get; set; }

    [JsonPropertyName("replicas")]
    public required int Replicas { get; set; }
}

/// <summary>ScaleTarget holds the reference to the scale target Object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecScaleTargetRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("envSourceContainerName")]
    public string? EnvSourceContainerName { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Kind of the resource being referred to. Defaults to TriggerAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ScaledObjectSpecTriggersAuthenticationRefKindEnum>))]
public enum V1alpha1ScaledObjectSpecTriggersAuthenticationRefKindEnum
{
    [EnumMember(Value = "TriggerAuthentication"), JsonStringEnumMemberName("TriggerAuthentication")]
    TriggerAuthentication,
    [EnumMember(Value = "ClusterTriggerAuthentication"), JsonStringEnumMemberName("ClusterTriggerAuthentication")]
    ClusterTriggerAuthentication
}

/// <summary>
/// AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that
/// is used to authenticate the scaler with the environment
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecTriggersAuthenticationRef
{
    /// <summary>Kind of the resource being referred to. Defaults to TriggerAuthentication.</summary>
    [JsonPropertyName("kind")]
    public V1alpha1ScaledObjectSpecTriggersAuthenticationRefKindEnum? Kind { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ScaleTriggers reference the scaler that will be used</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecTriggers
{
    /// <summary>
    /// AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that
    /// is used to authenticate the scaler with the environment
    /// </summary>
    [JsonPropertyName("authenticationRef")]
    public V1alpha1ScaledObjectSpecTriggersAuthenticationRef? AuthenticationRef { get; set; }

    [JsonPropertyName("metadata")]
    public required IDictionary<string, string> Metadata { get; set; }

    /// <summary>
    /// MetricTargetType specifies the type of metric being targeted, and should be either
    /// &quot;Value&quot;, &quot;AverageValue&quot;, or &quot;Utilization&quot;
    /// </summary>
    [JsonPropertyName("metricType")]
    public string? MetricType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("useCachedMetrics")]
    public bool? UseCachedMetrics { get; set; }
}

/// <summary>ScaledObjectSpec is the spec for a ScaledObject resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpec
{
    /// <summary>AdvancedConfig specifies advance scaling options</summary>
    [JsonPropertyName("advanced")]
    public V1alpha1ScaledObjectSpecAdvanced? Advanced { get; set; }

    [JsonPropertyName("cooldownPeriod")]
    public int? CooldownPeriod { get; set; }

    /// <summary>Fallback is the spec for fallback options</summary>
    [JsonPropertyName("fallback")]
    public V1alpha1ScaledObjectSpecFallback? Fallback { get; set; }

    [JsonPropertyName("idleReplicaCount")]
    public int? IdleReplicaCount { get; set; }

    [JsonPropertyName("initialCooldownPeriod")]
    public int? InitialCooldownPeriod { get; set; }

    [JsonPropertyName("maxReplicaCount")]
    public int? MaxReplicaCount { get; set; }

    [JsonPropertyName("minReplicaCount")]
    public int? MinReplicaCount { get; set; }

    [JsonPropertyName("pollingInterval")]
    public int? PollingInterval { get; set; }

    /// <summary>ScaleTarget holds the reference to the scale target Object</summary>
    [JsonPropertyName("scaleTargetRef")]
    public required V1alpha1ScaledObjectSpecScaleTargetRef ScaleTargetRef { get; set; }

    [JsonPropertyName("triggers")]
    public required IList<V1alpha1ScaledObjectSpecTriggers> Triggers { get; set; }
}

/// <summary>Condition to store the condition state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectStatusConditions
{
    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>HealthStatus is the status for a ScaledObject&apos;s health</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectStatusHealth
{
    [JsonPropertyName("numberOfFailures")]
    public int? NumberOfFailures { get; set; }

    /// <summary>HealthStatusType is an indication of whether the health status is happy or failing</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>GroupVersionKindResource provides unified structure for schema.GroupVersionKind and Resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectStatusScaleTargetGVKR
{
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>TriggerActivityStatus represents the activity status of an external trigger</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectStatusTriggersActivity
{
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
}

/// <summary>ScaledObjectStatus is the status for a ScaledObject resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectStatus
{
    [JsonPropertyName("authenticationsTypes")]
    public string? AuthenticationsTypes { get; set; }

    [JsonPropertyName("compositeScalerName")]
    public string? CompositeScalerName { get; set; }

    /// <summary>Conditions an array representation to store multiple Conditions</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ScaledObjectStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("externalMetricNames")]
    public IList<string>? ExternalMetricNames { get; set; }

    [JsonPropertyName("health")]
    public IDictionary<string, V1alpha1ScaledObjectStatusHealth>? Health { get; set; }

    [JsonPropertyName("hpaName")]
    public string? HpaName { get; set; }

    [JsonPropertyName("lastActiveTime")]
    public DateTime? LastActiveTime { get; set; }

    [JsonPropertyName("originalReplicaCount")]
    public int? OriginalReplicaCount { get; set; }

    [JsonPropertyName("pausedReplicaCount")]
    public int? PausedReplicaCount { get; set; }

    [JsonPropertyName("resourceMetricNames")]
    public IList<string>? ResourceMetricNames { get; set; }

    /// <summary>GroupVersionKindResource provides unified structure for schema.GroupVersionKind and Resource</summary>
    [JsonPropertyName("scaleTargetGVKR")]
    public V1alpha1ScaledObjectStatusScaleTargetGVKR? ScaleTargetGVKR { get; set; }

    [JsonPropertyName("scaleTargetKind")]
    public string? ScaleTargetKind { get; set; }

    [JsonPropertyName("triggersActivity")]
    public IDictionary<string, V1alpha1ScaledObjectStatusTriggersActivity>? TriggersActivity { get; set; }

    [JsonPropertyName("triggersTypes")]
    public string? TriggersTypes { get; set; }
}

/// <summary>ScaledObject is a specification for a ScaledObject resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ScaledObject : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ScaledObjectSpec>, IStatus<V1alpha1ScaledObjectStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ScaledObject";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "scaledobjects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keda.sh/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScaledObject";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ScaledObjectSpec is the spec for a ScaledObject resource</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ScaledObjectSpec Spec { get; set; }

    /// <summary>ScaledObjectStatus is the status for a ScaledObject resource</summary>
    [JsonPropertyName("status")]
    public V1alpha1ScaledObjectStatus? Status { get; set; }
}