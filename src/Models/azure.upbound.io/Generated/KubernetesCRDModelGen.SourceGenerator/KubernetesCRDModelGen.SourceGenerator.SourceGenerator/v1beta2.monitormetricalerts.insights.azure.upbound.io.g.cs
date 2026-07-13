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
/// <summary>MonitorMetricAlert is the Schema for the MonitorMetricAlerts API. Manages a Metric Alert within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorMetricAlertList : IKubernetesObject<V1ListMeta>, IItems<V1beta2MonitorMetricAlert>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorMetricAlertList";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitormetricalerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorMetricAlertList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2MonitorMetricAlert objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2MonitorMetricAlert> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecDeletionPolicyEnum>))]
public enum V1beta2MonitorMetricAlertSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelector
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
    public V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderAction
{
    /// <summary>The ID of the Action Group can be sourced from the</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdRef")]
    public V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdRef? ActionGroupIdRef { get; set; }

    /// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdSelector")]
    public V1beta2MonitorMetricAlertSpecForProviderActionActionGroupIdSelector? ActionGroupIdSelector { get; set; }

    /// <summary>The map of custom string properties to include with the post operation. These data are appended to the webhook payload.</summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary>A application_insights_web_test_location_availability_criteria block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderApplicationInsightsWebTestLocationAvailabilityCriteria
{
    /// <summary>The ID of the Application Insights Resource.</summary>
    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }

    /// <summary>The number of failed locations.</summary>
    [JsonPropertyName("failedLocationCount")]
    public double? FailedLocationCount { get; set; }

    /// <summary>The ID of the Application Insights Web Test.</summary>
    [JsonPropertyName("webTestId")]
    public string? WebTestId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2MonitorMetricAlertSpecForProviderCriteriaDimension>? Dimension { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are Equals, GreaterThan, GreaterThanOrEqual, LessThan and LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn&apos;t yet emitted? Defaults to false.</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>The criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderDynamicCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A dynamic_criteria block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderDynamicCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>The extent of deviation required to trigger an alert. Possible values are Low, Medium and High.</summary>
    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2MonitorMetricAlertSpecForProviderDynamicCriteriaDimension>? Dimension { get; set; }

    /// <summary>The number of violations to trigger an alert. Should be smaller or equal to evaluation_total_count. Defaults to 4.</summary>
    [JsonPropertyName("evaluationFailureCount")]
    public double? EvaluationFailureCount { get; set; }

    /// <summary>The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (window_size) and the selected number of aggregated points. Defaults to 4.</summary>
    [JsonPropertyName("evaluationTotalCount")]
    public double? EvaluationTotalCount { get; set; }

    /// <summary>The ISO8601 date from which to start learning the metric historical data and calculate the dynamic thresholds.</summary>
    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn&apos;t yet emitted?</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelector
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
    public V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderScopesRefsPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderScopesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderScopesRefsPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderScopesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderScopesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecForProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecForProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorMetricAlertSpecForProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderScopesSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderScopesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecForProviderScopesSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecForProviderScopesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderScopesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecForProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecForProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Account in storage to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProviderScopesSelector
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
    public V1beta2MonitorMetricAlertSpecForProviderScopesSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecForProvider
{
    /// <summary>One or more action blocks as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2MonitorMetricAlertSpecForProviderAction>? Action { get; set; }

    /// <summary>A application_insights_web_test_location_availability_criteria block as defined below.</summary>
    [JsonPropertyName("applicationInsightsWebTestLocationAvailabilityCriteria")]
    public V1beta2MonitorMetricAlertSpecForProviderApplicationInsightsWebTestLocationAvailabilityCriteria? ApplicationInsightsWebTestLocationAvailabilityCriteria { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to true.</summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>One or more (static) criteria blocks as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta2MonitorMetricAlertSpecForProviderCriteria>? Criteria { get; set; }

    /// <summary>The description of this Metric Alert.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A dynamic_criteria block as defined below.</summary>
    [JsonPropertyName("dynamicCriteria")]
    public V1beta2MonitorMetricAlertSpecForProviderDynamicCriteria? DynamicCriteria { get; set; }

    /// <summary>Should this Metric Alert be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The evaluation frequency of this Metric Alert, represented in ISO 8601 duration format. Possible values are PT1M, PT5M, PT15M, PT30M and PT1H. Defaults to PT1M.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The name of the resource group in which to create the Metric Alert instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2MonitorMetricAlertSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A set of strings of resource IDs at which the metric criteria should be applied.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to Account in storage to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta2MonitorMetricAlertSpecForProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of Account in storage to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta2MonitorMetricAlertSpecForProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>The severity of this Metric Alert. Possible values are 0, 1, 2, 3 and 4. Defaults to 3.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The location of the target resource.
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target resource.
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    /// <summary>The period of time that is used to monitor alert activity, represented in ISO 8601 duration format. This value must be greater than frequency. Possible values are PT1M, PT5M, PT15M, PT30M, PT1H, PT6H, PT12H and P1D. Defaults to PT5M.</summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelector
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
    public V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderAction
{
    /// <summary>The ID of the Action Group can be sourced from the</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdRef")]
    public V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdRef? ActionGroupIdRef { get; set; }

    /// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdSelector")]
    public V1beta2MonitorMetricAlertSpecInitProviderActionActionGroupIdSelector? ActionGroupIdSelector { get; set; }

    /// <summary>The map of custom string properties to include with the post operation. These data are appended to the webhook payload.</summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary>A application_insights_web_test_location_availability_criteria block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderApplicationInsightsWebTestLocationAvailabilityCriteria
{
    /// <summary>The ID of the Application Insights Resource.</summary>
    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }

    /// <summary>The number of failed locations.</summary>
    [JsonPropertyName("failedLocationCount")]
    public double? FailedLocationCount { get; set; }

    /// <summary>The ID of the Application Insights Web Test.</summary>
    [JsonPropertyName("webTestId")]
    public string? WebTestId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2MonitorMetricAlertSpecInitProviderCriteriaDimension>? Dimension { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are Equals, GreaterThan, GreaterThanOrEqual, LessThan and LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn&apos;t yet emitted? Defaults to false.</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>The criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderDynamicCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A dynamic_criteria block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderDynamicCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>The extent of deviation required to trigger an alert. Possible values are Low, Medium and High.</summary>
    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2MonitorMetricAlertSpecInitProviderDynamicCriteriaDimension>? Dimension { get; set; }

    /// <summary>The number of violations to trigger an alert. Should be smaller or equal to evaluation_total_count. Defaults to 4.</summary>
    [JsonPropertyName("evaluationFailureCount")]
    public double? EvaluationFailureCount { get; set; }

    /// <summary>The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (window_size) and the selected number of aggregated points. Defaults to 4.</summary>
    [JsonPropertyName("evaluationTotalCount")]
    public double? EvaluationTotalCount { get; set; }

    /// <summary>The ISO8601 date from which to start learning the metric historical data and calculate the dynamic thresholds.</summary>
    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn&apos;t yet emitted?</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecInitProviderScopesRefsPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecInitProviderScopesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecInitProviderScopesRefsPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecInitProviderScopesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderScopesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecInitProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecInitProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorMetricAlertSpecInitProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecInitProviderScopesSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecInitProviderScopesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecInitProviderScopesSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecInitProviderScopesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderScopesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecInitProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecInitProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Account in storage to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecInitProviderScopesSelector
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
    public V1beta2MonitorMetricAlertSpecInitProviderScopesSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2MonitorMetricAlertSpecInitProvider
{
    /// <summary>One or more action blocks as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2MonitorMetricAlertSpecInitProviderAction>? Action { get; set; }

    /// <summary>A application_insights_web_test_location_availability_criteria block as defined below.</summary>
    [JsonPropertyName("applicationInsightsWebTestLocationAvailabilityCriteria")]
    public V1beta2MonitorMetricAlertSpecInitProviderApplicationInsightsWebTestLocationAvailabilityCriteria? ApplicationInsightsWebTestLocationAvailabilityCriteria { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to true.</summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>One or more (static) criteria blocks as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta2MonitorMetricAlertSpecInitProviderCriteria>? Criteria { get; set; }

    /// <summary>The description of this Metric Alert.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A dynamic_criteria block as defined below.</summary>
    [JsonPropertyName("dynamicCriteria")]
    public V1beta2MonitorMetricAlertSpecInitProviderDynamicCriteria? DynamicCriteria { get; set; }

    /// <summary>Should this Metric Alert be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The evaluation frequency of this Metric Alert, represented in ISO 8601 duration format. Possible values are PT1M, PT5M, PT15M, PT30M and PT1H. Defaults to PT1M.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>A set of strings of resource IDs at which the metric criteria should be applied.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to Account in storage to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta2MonitorMetricAlertSpecInitProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of Account in storage to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta2MonitorMetricAlertSpecInitProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>The severity of this Metric Alert. Possible values are 0, 1, 2, 3 and 4. Defaults to 3.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The location of the target resource.
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target resource.
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    /// <summary>The period of time that is used to monitor alert activity, represented in ISO 8601 duration format. This value must be greater than frequency. Possible values are PT1M, PT5M, PT15M, PT30M, PT1H, PT6H, PT12H and P1D. Defaults to PT5M.</summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecManagementPoliciesEnum>))]
public enum V1beta2MonitorMetricAlertSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2MonitorMetricAlertSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorMetricAlertSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2MonitorMetricAlertSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorMetricAlertSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorMetricAlertSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorMetricAlertSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MonitorMetricAlertSpec defines the desired state of MonitorMetricAlert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertSpec
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
    public V1beta2MonitorMetricAlertSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2MonitorMetricAlertSpecForProvider ForProvider { get; set; }

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
    public V1beta2MonitorMetricAlertSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2MonitorMetricAlertSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2MonitorMetricAlertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2MonitorMetricAlertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertStatusAtProviderAction
{
    /// <summary>The ID of the Action Group can be sourced from the</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>The map of custom string properties to include with the post operation. These data are appended to the webhook payload.</summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary>A application_insights_web_test_location_availability_criteria block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertStatusAtProviderApplicationInsightsWebTestLocationAvailabilityCriteria
{
    /// <summary>The ID of the Application Insights Resource.</summary>
    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }

    /// <summary>The number of failed locations.</summary>
    [JsonPropertyName("failedLocationCount")]
    public double? FailedLocationCount { get; set; }

    /// <summary>The ID of the Application Insights Web Test.</summary>
    [JsonPropertyName("webTestId")]
    public string? WebTestId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertStatusAtProviderCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertStatusAtProviderCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2MonitorMetricAlertStatusAtProviderCriteriaDimension>? Dimension { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are Equals, GreaterThan, GreaterThanOrEqual, LessThan and LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn&apos;t yet emitted? Defaults to false.</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>The criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertStatusAtProviderDynamicCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A dynamic_criteria block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertStatusAtProviderDynamicCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>The extent of deviation required to trigger an alert. Possible values are Low, Medium and High.</summary>
    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2MonitorMetricAlertStatusAtProviderDynamicCriteriaDimension>? Dimension { get; set; }

    /// <summary>The number of violations to trigger an alert. Should be smaller or equal to evaluation_total_count. Defaults to 4.</summary>
    [JsonPropertyName("evaluationFailureCount")]
    public double? EvaluationFailureCount { get; set; }

    /// <summary>The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (window_size) and the selected number of aggregated points. Defaults to 4.</summary>
    [JsonPropertyName("evaluationTotalCount")]
    public double? EvaluationTotalCount { get; set; }

    /// <summary>The ISO8601 date from which to start learning the metric historical data and calculate the dynamic thresholds.</summary>
    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn&apos;t yet emitted?</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertStatusAtProvider
{
    /// <summary>One or more action blocks as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2MonitorMetricAlertStatusAtProviderAction>? Action { get; set; }

    /// <summary>A application_insights_web_test_location_availability_criteria block as defined below.</summary>
    [JsonPropertyName("applicationInsightsWebTestLocationAvailabilityCriteria")]
    public V1beta2MonitorMetricAlertStatusAtProviderApplicationInsightsWebTestLocationAvailabilityCriteria? ApplicationInsightsWebTestLocationAvailabilityCriteria { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to true.</summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>One or more (static) criteria blocks as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta2MonitorMetricAlertStatusAtProviderCriteria>? Criteria { get; set; }

    /// <summary>The description of this Metric Alert.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A dynamic_criteria block as defined below.</summary>
    [JsonPropertyName("dynamicCriteria")]
    public V1beta2MonitorMetricAlertStatusAtProviderDynamicCriteria? DynamicCriteria { get; set; }

    /// <summary>Should this Metric Alert be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The evaluation frequency of this Metric Alert, represented in ISO 8601 duration format. Possible values are PT1M, PT5M, PT15M, PT30M and PT1H. Defaults to PT1M.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The ID of the metric alert.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the resource group in which to create the Metric Alert instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A set of strings of resource IDs at which the metric criteria should be applied.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>The severity of this Metric Alert. Possible values are 0, 1, 2, 3 and 4. Defaults to 3.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The location of the target resource.
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target resource.
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    /// <summary>The period of time that is used to monitor alert activity, represented in ISO 8601 duration format. This value must be greater than frequency. Possible values are PT1M, PT5M, PT15M, PT30M, PT1H, PT6H, PT12H and P1D. Defaults to PT5M.</summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertStatusConditions
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

/// <summary>MonitorMetricAlertStatus defines the observed state of MonitorMetricAlert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorMetricAlertStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2MonitorMetricAlertStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2MonitorMetricAlertStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorMetricAlert is the Schema for the MonitorMetricAlerts API. Manages a Metric Alert within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorMetricAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2MonitorMetricAlertSpec>, IStatus<V1beta2MonitorMetricAlertStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorMetricAlert";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitormetricalerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorMetricAlert";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorMetricAlertSpec defines the desired state of MonitorMetricAlert</summary>
    [JsonPropertyName("spec")]
    public required V1beta2MonitorMetricAlertSpec Spec { get; set; }

    /// <summary>MonitorMetricAlertStatus defines the observed state of MonitorMetricAlert.</summary>
    [JsonPropertyName("status")]
    public V1beta2MonitorMetricAlertStatus? Status { get; set; }
}