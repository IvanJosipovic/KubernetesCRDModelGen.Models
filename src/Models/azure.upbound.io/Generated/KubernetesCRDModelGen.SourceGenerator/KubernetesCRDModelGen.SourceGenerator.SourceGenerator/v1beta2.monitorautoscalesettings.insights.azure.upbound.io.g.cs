#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
/// <summary>MonitorAutoscaleSetting is the Schema for the MonitorAutoscaleSettings API. Manages an AutoScale Setting which can be applied to Virtual Machine Scale Sets, App Services and other scalable resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorAutoscaleSettingList : IKubernetesObject<V1ListMeta>, IItems<V1beta2MonitorAutoscaleSetting>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorAutoscaleSettingList";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitorautoscalesettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorAutoscaleSettingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2MonitorAutoscaleSetting objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2MonitorAutoscaleSetting> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecDeletionPolicyEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A email block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderNotificationEmail
{
    /// <summary>Specifies a list of custom email addresses to which the email notifications will be sent.</summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary>Should email notifications be sent to the subscription administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary>Should email notifications be sent to the subscription co-administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrator")]
    public bool? SendToSubscriptionCoAdministrator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderNotificationWebhook
{
    /// <summary>A map of settings.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HTTPS URI which should receive scale notifications.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }
}

/// <summary>Specifies a notification block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderNotification
{
    /// <summary>A email block as defined below.</summary>
    [JsonPropertyName("email")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderNotificationEmail? Email { get; set; }

    /// <summary>One or more webhook blocks as defined below.</summary>
    [JsonPropertyName("webhook")]
    public IList<V1beta2MonitorAutoscaleSettingSpecForProviderNotificationWebhook>? Webhook { get; set; }
}

/// <summary>A predictive block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderPredictive
{
    /// <summary>Specifies the amount of time by which instances are launched in advance. It must be between PT1M and PT1H in ISO 8601 format.</summary>
    [JsonPropertyName("lookAheadTime")]
    public string? LookAheadTime { get; set; }

    /// <summary>Specifies the predictive scale mode. Possible values are Enabled or ForecastOnly.</summary>
    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary>A capacity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileCapacity
{
    /// <summary>The number of instances that are available for scaling if metrics are not available for evaluation. The default is only used if the current instance count is lower than the default. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("default")]
    public double? Default { get; set; }

    /// <summary>The maximum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("maximum")]
    public double? Maximum { get; set; }

    /// <summary>The minimum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("minimum")]
    public double? Minimum { get; set; }
}

/// <summary>A fixed_date block as defined below. This cannot be specified if a recurrence block is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileFixedDate
{
    /// <summary>Specifies the end date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>Specifies the start date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A recurrence block as defined below. This cannot be specified if a fixed_date block is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileRecurrence
{
    /// <summary>A list of days that this profile takes effect on. Possible values include Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>A list containing a single item, which specifies the Hour interval at which this recurrence should be triggered (in 24-hour time). Possible values are from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>A list containing a single item which specifies the Minute interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerDimensions
{
    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelector
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
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A metric_trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTrigger
{
    /// <summary>One or more dimensions block as defined below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary>Whether to enable metric divide by instance count.</summary>
    [JsonPropertyName("divideByInstanceCount")]
    public bool? DivideByInstanceCount { get; set; }

    /// <summary>The name of the metric that defines what the rule monitors, such as Percentage CPU for Virtual Machine Scale Sets and CpuPercentage for App Service Plan.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace of the metric that defines what the rule monitors, such as microsoft.compute/virtualmachinescalesets for Virtual Machine Scale Sets.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The ID of the Resource which the Rule monitors.</summary>
    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
    [JsonPropertyName("metricResourceIdRef")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRef? MetricResourceIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
    [JsonPropertyName("metricResourceIdSelector")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelector? MetricResourceIdSelector { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies how the metrics from multiple instances are combined. Possible values are Average, Max, Min and Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Specifies the threshold of the metric that triggers the scale action.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Specifies how the data that&apos;s collected should be combined over time. Possible values include Average, Count, Maximum, Minimum, Last and Total.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    /// <summary>Specifies the granularity of metrics that the rule monitors, which must be one of the pre-defined values returned from the metric definitions for the metric. This value must be between 1 minute and 12 hours an be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>Specifies the time range for which data is collected, which must be greater than the delay in metric collection (which varies from resource to resource). This value must be between 5 minutes and 12 hours and be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary>A scale_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleScaleAction
{
    /// <summary>The amount of time to wait since the last scaling action before this action occurs. Must be between 1 minute and 1 week and formatted as a ISO 8601 string.</summary>
    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    /// <summary>The scale direction. Possible values are Increase and Decrease.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The type of action that should occur. Possible values are ChangeCount, ExactCount, PercentChangeCount and ServiceAllowedNextValue.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The number of instances involved in the scaling action.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfileRule
{
    /// <summary>A metric_trigger block as defined below.</summary>
    [JsonPropertyName("metricTrigger")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTrigger? MetricTrigger { get; set; }

    /// <summary>A scale_action block as defined below.</summary>
    [JsonPropertyName("scaleAction")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRuleScaleAction? ScaleAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderProfile
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileCapacity? Capacity { get; set; }

    /// <summary>A fixed_date block as defined below. This cannot be specified if a recurrence block is specified.</summary>
    [JsonPropertyName("fixedDate")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileFixedDate? FixedDate { get; set; }

    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A recurrence block as defined below. This cannot be specified if a fixed_date block is specified.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderProfileRecurrence? Recurrence { get; set; }

    /// <summary>One or more (up to 10) rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2MonitorAutoscaleSettingSpecForProviderProfileRule>? Rule { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelector
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
    public V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelector
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
    public V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecForProvider
{
    /// <summary>Specifies whether automatic scaling is enabled for the target resource. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the supported Azure location where the AutoScale Setting should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the AutoScale Setting. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a notification block as defined below.</summary>
    [JsonPropertyName("notification")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderNotification? Notification { get; set; }

    /// <summary>A predictive block as defined below.</summary>
    [JsonPropertyName("predictive")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderPredictive? Predictive { get; set; }

    /// <summary>Specifies one or more (up to 20) profile blocks as defined below.</summary>
    [JsonPropertyName("profile")]
    public IList<V1beta2MonitorAutoscaleSettingSpecForProviderProfile>? Profile { get; set; }

    /// <summary>The name of the Resource Group in the AutoScale Setting should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the resource ID of the resource that the autoscale setting should be added to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdRef")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdRef? TargetResourceIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdSelector")]
    public V1beta2MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelector? TargetResourceIdSelector { get; set; }
}

/// <summary>A email block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderNotificationEmail
{
    /// <summary>Specifies a list of custom email addresses to which the email notifications will be sent.</summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary>Should email notifications be sent to the subscription administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary>Should email notifications be sent to the subscription co-administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrator")]
    public bool? SendToSubscriptionCoAdministrator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderNotificationWebhook
{
    /// <summary>A map of settings.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HTTPS URI which should receive scale notifications.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }
}

/// <summary>Specifies a notification block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderNotification
{
    /// <summary>A email block as defined below.</summary>
    [JsonPropertyName("email")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderNotificationEmail? Email { get; set; }

    /// <summary>One or more webhook blocks as defined below.</summary>
    [JsonPropertyName("webhook")]
    public IList<V1beta2MonitorAutoscaleSettingSpecInitProviderNotificationWebhook>? Webhook { get; set; }
}

/// <summary>A predictive block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderPredictive
{
    /// <summary>Specifies the amount of time by which instances are launched in advance. It must be between PT1M and PT1H in ISO 8601 format.</summary>
    [JsonPropertyName("lookAheadTime")]
    public string? LookAheadTime { get; set; }

    /// <summary>Specifies the predictive scale mode. Possible values are Enabled or ForecastOnly.</summary>
    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary>A capacity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileCapacity
{
    /// <summary>The number of instances that are available for scaling if metrics are not available for evaluation. The default is only used if the current instance count is lower than the default. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("default")]
    public double? Default { get; set; }

    /// <summary>The maximum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("maximum")]
    public double? Maximum { get; set; }

    /// <summary>The minimum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("minimum")]
    public double? Minimum { get; set; }
}

/// <summary>A fixed_date block as defined below. This cannot be specified if a recurrence block is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileFixedDate
{
    /// <summary>Specifies the end date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>Specifies the start date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A recurrence block as defined below. This cannot be specified if a fixed_date block is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRecurrence
{
    /// <summary>A list of days that this profile takes effect on. Possible values include Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>A list containing a single item, which specifies the Hour interval at which this recurrence should be triggered (in 24-hour time). Possible values are from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>A list containing a single item which specifies the Minute interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerDimensions
{
    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelector
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
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A metric_trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTrigger
{
    /// <summary>One or more dimensions block as defined below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary>Whether to enable metric divide by instance count.</summary>
    [JsonPropertyName("divideByInstanceCount")]
    public bool? DivideByInstanceCount { get; set; }

    /// <summary>The name of the metric that defines what the rule monitors, such as Percentage CPU for Virtual Machine Scale Sets and CpuPercentage for App Service Plan.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace of the metric that defines what the rule monitors, such as microsoft.compute/virtualmachinescalesets for Virtual Machine Scale Sets.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The ID of the Resource which the Rule monitors.</summary>
    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
    [JsonPropertyName("metricResourceIdRef")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRef? MetricResourceIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
    [JsonPropertyName("metricResourceIdSelector")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelector? MetricResourceIdSelector { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies how the metrics from multiple instances are combined. Possible values are Average, Max, Min and Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Specifies the threshold of the metric that triggers the scale action.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Specifies how the data that&apos;s collected should be combined over time. Possible values include Average, Count, Maximum, Minimum, Last and Total.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    /// <summary>Specifies the granularity of metrics that the rule monitors, which must be one of the pre-defined values returned from the metric definitions for the metric. This value must be between 1 minute and 12 hours an be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>Specifies the time range for which data is collected, which must be greater than the delay in metric collection (which varies from resource to resource). This value must be between 5 minutes and 12 hours and be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary>A scale_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleScaleAction
{
    /// <summary>The amount of time to wait since the last scaling action before this action occurs. Must be between 1 minute and 1 week and formatted as a ISO 8601 string.</summary>
    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    /// <summary>The scale direction. Possible values are Increase and Decrease.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The type of action that should occur. Possible values are ChangeCount, ExactCount, PercentChangeCount and ServiceAllowedNextValue.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The number of instances involved in the scaling action.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRule
{
    /// <summary>A metric_trigger block as defined below.</summary>
    [JsonPropertyName("metricTrigger")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTrigger? MetricTrigger { get; set; }

    /// <summary>A scale_action block as defined below.</summary>
    [JsonPropertyName("scaleAction")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRuleScaleAction? ScaleAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderProfile
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileCapacity? Capacity { get; set; }

    /// <summary>A fixed_date block as defined below. This cannot be specified if a recurrence block is specified.</summary>
    [JsonPropertyName("fixedDate")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileFixedDate? FixedDate { get; set; }

    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A recurrence block as defined below. This cannot be specified if a fixed_date block is specified.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRecurrence? Recurrence { get; set; }

    /// <summary>One or more (up to 10) rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2MonitorAutoscaleSettingSpecInitProviderProfileRule>? Rule { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelector
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
    public V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelector
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
    public V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2MonitorAutoscaleSettingSpecInitProvider
{
    /// <summary>Specifies whether automatic scaling is enabled for the target resource. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the supported Azure location where the AutoScale Setting should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the AutoScale Setting. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a notification block as defined below.</summary>
    [JsonPropertyName("notification")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderNotification? Notification { get; set; }

    /// <summary>A predictive block as defined below.</summary>
    [JsonPropertyName("predictive")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderPredictive? Predictive { get; set; }

    /// <summary>Specifies one or more (up to 20) profile blocks as defined below.</summary>
    [JsonPropertyName("profile")]
    public IList<V1beta2MonitorAutoscaleSettingSpecInitProviderProfile>? Profile { get; set; }

    /// <summary>The name of the Resource Group in the AutoScale Setting should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the resource ID of the resource that the autoscale setting should be added to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdRef")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRef? TargetResourceIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdSelector")]
    public V1beta2MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelector? TargetResourceIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecManagementPoliciesEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAutoscaleSettingSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2MonitorAutoscaleSettingSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAutoscaleSettingSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAutoscaleSettingSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAutoscaleSettingSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MonitorAutoscaleSettingSpec defines the desired state of MonitorAutoscaleSetting</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingSpec
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
    public V1beta2MonitorAutoscaleSettingSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2MonitorAutoscaleSettingSpecForProvider ForProvider { get; set; }

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
    public V1beta2MonitorAutoscaleSettingSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2MonitorAutoscaleSettingSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2MonitorAutoscaleSettingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2MonitorAutoscaleSettingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A email block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderNotificationEmail
{
    /// <summary>Specifies a list of custom email addresses to which the email notifications will be sent.</summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary>Should email notifications be sent to the subscription administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary>Should email notifications be sent to the subscription co-administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrator")]
    public bool? SendToSubscriptionCoAdministrator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderNotificationWebhook
{
    /// <summary>A map of settings.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HTTPS URI which should receive scale notifications.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }
}

/// <summary>Specifies a notification block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderNotification
{
    /// <summary>A email block as defined below.</summary>
    [JsonPropertyName("email")]
    public V1beta2MonitorAutoscaleSettingStatusAtProviderNotificationEmail? Email { get; set; }

    /// <summary>One or more webhook blocks as defined below.</summary>
    [JsonPropertyName("webhook")]
    public IList<V1beta2MonitorAutoscaleSettingStatusAtProviderNotificationWebhook>? Webhook { get; set; }
}

/// <summary>A predictive block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderPredictive
{
    /// <summary>Specifies the amount of time by which instances are launched in advance. It must be between PT1M and PT1H in ISO 8601 format.</summary>
    [JsonPropertyName("lookAheadTime")]
    public string? LookAheadTime { get; set; }

    /// <summary>Specifies the predictive scale mode. Possible values are Enabled or ForecastOnly.</summary>
    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary>A capacity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderProfileCapacity
{
    /// <summary>The number of instances that are available for scaling if metrics are not available for evaluation. The default is only used if the current instance count is lower than the default. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("default")]
    public double? Default { get; set; }

    /// <summary>The maximum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("maximum")]
    public double? Maximum { get; set; }

    /// <summary>The minimum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("minimum")]
    public double? Minimum { get; set; }
}

/// <summary>A fixed_date block as defined below. This cannot be specified if a recurrence block is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderProfileFixedDate
{
    /// <summary>Specifies the end date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>Specifies the start date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A recurrence block as defined below. This cannot be specified if a fixed_date block is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRecurrence
{
    /// <summary>A list of days that this profile takes effect on. Possible values include Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>A list containing a single item, which specifies the Hour interval at which this recurrence should be triggered (in 24-hour time). Possible values are from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>A list containing a single item which specifies the Minute interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRuleMetricTriggerDimensions
{
    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A metric_trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRuleMetricTrigger
{
    /// <summary>One or more dimensions block as defined below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRuleMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary>Whether to enable metric divide by instance count.</summary>
    [JsonPropertyName("divideByInstanceCount")]
    public bool? DivideByInstanceCount { get; set; }

    /// <summary>The name of the metric that defines what the rule monitors, such as Percentage CPU for Virtual Machine Scale Sets and CpuPercentage for App Service Plan.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace of the metric that defines what the rule monitors, such as microsoft.compute/virtualmachinescalesets for Virtual Machine Scale Sets.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The ID of the Resource which the Rule monitors.</summary>
    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies how the metrics from multiple instances are combined. Possible values are Average, Max, Min and Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Specifies the threshold of the metric that triggers the scale action.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Specifies how the data that&apos;s collected should be combined over time. Possible values include Average, Count, Maximum, Minimum, Last and Total.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    /// <summary>Specifies the granularity of metrics that the rule monitors, which must be one of the pre-defined values returned from the metric definitions for the metric. This value must be between 1 minute and 12 hours an be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>Specifies the time range for which data is collected, which must be greater than the delay in metric collection (which varies from resource to resource). This value must be between 5 minutes and 12 hours and be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary>A scale_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRuleScaleAction
{
    /// <summary>The amount of time to wait since the last scaling action before this action occurs. Must be between 1 minute and 1 week and formatted as a ISO 8601 string.</summary>
    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    /// <summary>The scale direction. Possible values are Increase and Decrease.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The type of action that should occur. Possible values are ChangeCount, ExactCount, PercentChangeCount and ServiceAllowedNextValue.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The number of instances involved in the scaling action.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRule
{
    /// <summary>A metric_trigger block as defined below.</summary>
    [JsonPropertyName("metricTrigger")]
    public V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRuleMetricTrigger? MetricTrigger { get; set; }

    /// <summary>A scale_action block as defined below.</summary>
    [JsonPropertyName("scaleAction")]
    public V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRuleScaleAction? ScaleAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProviderProfile
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public V1beta2MonitorAutoscaleSettingStatusAtProviderProfileCapacity? Capacity { get; set; }

    /// <summary>A fixed_date block as defined below. This cannot be specified if a recurrence block is specified.</summary>
    [JsonPropertyName("fixedDate")]
    public V1beta2MonitorAutoscaleSettingStatusAtProviderProfileFixedDate? FixedDate { get; set; }

    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A recurrence block as defined below. This cannot be specified if a fixed_date block is specified.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRecurrence? Recurrence { get; set; }

    /// <summary>One or more (up to 10) rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2MonitorAutoscaleSettingStatusAtProviderProfileRule>? Rule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusAtProvider
{
    /// <summary>Specifies whether automatic scaling is enabled for the target resource. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the AutoScale Setting.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the supported Azure location where the AutoScale Setting should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the AutoScale Setting. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a notification block as defined below.</summary>
    [JsonPropertyName("notification")]
    public V1beta2MonitorAutoscaleSettingStatusAtProviderNotification? Notification { get; set; }

    /// <summary>A predictive block as defined below.</summary>
    [JsonPropertyName("predictive")]
    public V1beta2MonitorAutoscaleSettingStatusAtProviderPredictive? Predictive { get; set; }

    /// <summary>Specifies one or more (up to 20) profile blocks as defined below.</summary>
    [JsonPropertyName("profile")]
    public IList<V1beta2MonitorAutoscaleSettingStatusAtProviderProfile>? Profile { get; set; }

    /// <summary>The name of the Resource Group in the AutoScale Setting should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the resource ID of the resource that the autoscale setting should be added to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatusConditions
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

/// <summary>MonitorAutoscaleSettingStatus defines the observed state of MonitorAutoscaleSetting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAutoscaleSettingStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2MonitorAutoscaleSettingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2MonitorAutoscaleSettingStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorAutoscaleSetting is the Schema for the MonitorAutoscaleSettings API. Manages an AutoScale Setting which can be applied to Virtual Machine Scale Sets, App Services and other scalable resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorAutoscaleSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2MonitorAutoscaleSettingSpec>, IStatus<V1beta2MonitorAutoscaleSettingStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorAutoscaleSetting";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitorautoscalesettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorAutoscaleSetting";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorAutoscaleSettingSpec defines the desired state of MonitorAutoscaleSetting</summary>
    [JsonPropertyName("spec")]
    public required V1beta2MonitorAutoscaleSettingSpec Spec { get; set; }

    /// <summary>MonitorAutoscaleSettingStatus defines the observed state of MonitorAutoscaleSetting.</summary>
    [JsonPropertyName("status")]
    public V1beta2MonitorAutoscaleSettingStatus? Status { get; set; }
}