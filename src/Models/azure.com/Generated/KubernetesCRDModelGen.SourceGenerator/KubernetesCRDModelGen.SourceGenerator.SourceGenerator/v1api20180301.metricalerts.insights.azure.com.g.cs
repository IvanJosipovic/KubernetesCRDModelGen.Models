#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2018-03-01/metricAlert_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/metricAlerts/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180301MetricAlertList : IKubernetesObject<V1ListMeta>, IItems<V1api20180301MetricAlert>
{
    public const string KubeApiVersion = "v1api20180301";
    public const string KubeKind = "MetricAlertList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "metricalerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20180301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricAlertList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20180301MetricAlert objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20180301MetricAlert> Items { get; set; }
}

/// <summary>ActionGroupReference: the id of the action group to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecActionsActionGroupReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An alert action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecActions
{
    /// <summary>ActionGroupId: the id of the action group to use.</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>ActionGroupReference: the id of the action group to use.</summary>
    [JsonPropertyName("actionGroupReference")]
    public V1api20180301MetricAlertSpecActionsActionGroupReference? ActionGroupReference { get; set; }

    /// <summary>
    /// WebHookProperties: This field allows specifying custom properties, which would be appended to the alert payload sent as
    /// input to the webhook.
    /// </summary>
    [JsonPropertyName("webHookProperties")]
    public IDictionary<string, string>? WebHookProperties { get; set; }
}

/// <summary>
/// AlertSensitivity: The extent of deviation required to trigger an alert. This will affect how tight the threshold is to
/// the metric series pattern.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionAlertSensitivityEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionAlertSensitivityEnum
{
    [EnumMember(Value = "High"), JsonStringEnumMemberName("High")]
    High,
    [EnumMember(Value = "Low"), JsonStringEnumMemberName("Low")]
    Low,
    [EnumMember(Value = "Medium"), JsonStringEnumMemberName("Medium")]
    Medium
}

/// <summary>CriterionType: Specifies the type of threshold criteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionCriterionTypeEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionCriterionTypeEnum
{
    [EnumMember(Value = "DynamicThresholdCriterion"), JsonStringEnumMemberName("DynamicThresholdCriterion")]
    DynamicThresholdCriterion
}

/// <summary>Specifies a metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionDimensions
{
    /// <summary>Name: Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Operator: the dimension operator. Only &apos;Include&apos; and &apos;Exclude&apos; are supported</summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>Values: list of dimension values.</summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>
/// FailingPeriods: The minimum number of violations required within the selected lookback time window required to raise an
/// alert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionFailingPeriods
{
    /// <summary>
    /// MinFailingPeriodsToAlert: The number of violations to trigger an alert. Should be smaller or equal to
    /// numberOfEvaluationPeriods.
    /// </summary>
    [JsonPropertyName("minFailingPeriodsToAlert")]
    public required double MinFailingPeriodsToAlert { get; set; }

    /// <summary>
    /// NumberOfEvaluationPeriods: The number of aggregated lookback points. The lookback time window is calculated based on the
    /// aggregation granularity (windowSize) and the selected number of aggregated points.
    /// </summary>
    [JsonPropertyName("numberOfEvaluationPeriods")]
    public required double NumberOfEvaluationPeriods { get; set; }
}

/// <summary>Operator: The operator used to compare the metric value against the threshold.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionOperatorEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionOperatorEnum
{
    [EnumMember(Value = "GreaterOrLessThan"), JsonStringEnumMemberName("GreaterOrLessThan")]
    GreaterOrLessThan,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan
}

/// <summary>TimeAggregation: the criteria time aggregation types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionTimeAggregationEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionTimeAggregationEnum
{
    [EnumMember(Value = "Average"), JsonStringEnumMemberName("Average")]
    Average,
    [EnumMember(Value = "Count"), JsonStringEnumMemberName("Count")]
    Count,
    [EnumMember(Value = "Maximum"), JsonStringEnumMemberName("Maximum")]
    Maximum,
    [EnumMember(Value = "Minimum"), JsonStringEnumMemberName("Minimum")]
    Minimum,
    [EnumMember(Value = "Total"), JsonStringEnumMemberName("Total")]
    Total
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterion
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>
    /// AlertSensitivity: The extent of deviation required to trigger an alert. This will affect how tight the threshold is to
    /// the metric series pattern.
    /// </summary>
    [JsonPropertyName("alertSensitivity")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionAlertSensitivityEnum AlertSensitivity { get; set; }

    /// <summary>CriterionType: Specifies the type of threshold criteria</summary>
    [JsonPropertyName("criterionType")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionCriterionTypeEnum CriterionType { get; set; }

    /// <summary>Dimensions: List of dimension conditions.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionDimensions>? Dimensions { get; set; }

    /// <summary>
    /// FailingPeriods: The minimum number of violations required within the selected lookback time window required to raise an
    /// alert.
    /// </summary>
    [JsonPropertyName("failingPeriods")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionFailingPeriods FailingPeriods { get; set; }

    /// <summary>
    /// IgnoreDataBefore: Use this option to set the date from which to start learning the metric historical data and calculate
    /// the dynamic thresholds (in ISO8601 format)
    /// </summary>
    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    /// <summary>MetricName: Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public required string MetricName { get; set; }

    /// <summary>MetricNamespace: Namespace of the metric.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>Name: Name of the criteria.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Operator: The operator used to compare the metric value against the threshold.</summary>
    [JsonPropertyName("operator")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionOperatorEnum Operator { get; set; }

    /// <summary>
    /// SkipMetricValidation: Allows creating an alert rule on a custom metric that isn&apos;t yet emitted, by causing the metric
    /// validation to be skipped.
    /// </summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>TimeAggregation: the criteria time aggregation types.</summary>
    [JsonPropertyName("timeAggregation")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionTimeAggregationEnum TimeAggregation { get; set; }
}

/// <summary>CriterionType: Specifies the type of threshold criteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionCriterionTypeEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionCriterionTypeEnum
{
    [EnumMember(Value = "StaticThresholdCriterion"), JsonStringEnumMemberName("StaticThresholdCriterion")]
    StaticThresholdCriterion
}

/// <summary>Specifies a metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionDimensions
{
    /// <summary>Name: Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Operator: the dimension operator. Only &apos;Include&apos; and &apos;Exclude&apos; are supported</summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>Values: list of dimension values.</summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>Operator: the criteria operator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionOperatorEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual
}

/// <summary>TimeAggregation: the criteria time aggregation types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionTimeAggregationEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionTimeAggregationEnum
{
    [EnumMember(Value = "Average"), JsonStringEnumMemberName("Average")]
    Average,
    [EnumMember(Value = "Count"), JsonStringEnumMemberName("Count")]
    Count,
    [EnumMember(Value = "Maximum"), JsonStringEnumMemberName("Maximum")]
    Maximum,
    [EnumMember(Value = "Minimum"), JsonStringEnumMemberName("Minimum")]
    Minimum,
    [EnumMember(Value = "Total"), JsonStringEnumMemberName("Total")]
    Total
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterion
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>CriterionType: Specifies the type of threshold criteria</summary>
    [JsonPropertyName("criterionType")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionCriterionTypeEnum CriterionType { get; set; }

    /// <summary>Dimensions: List of dimension conditions.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionDimensions>? Dimensions { get; set; }

    /// <summary>MetricName: Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public required string MetricName { get; set; }

    /// <summary>MetricNamespace: Namespace of the metric.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>Name: Name of the criteria.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Operator: the criteria operator.</summary>
    [JsonPropertyName("operator")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionOperatorEnum Operator { get; set; }

    /// <summary>
    /// SkipMetricValidation: Allows creating an alert rule on a custom metric that isn&apos;t yet emitted, by causing the metric
    /// validation to be skipped.
    /// </summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>Threshold: the criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public required double Threshold { get; set; }

    /// <summary>TimeAggregation: the criteria time aggregation types.</summary>
    [JsonPropertyName("timeAggregation")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionTimeAggregationEnum TimeAggregation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOf
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamicThresholdCriterion")]
    public V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterion? DynamicThresholdCriterion { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("staticThresholdCriterion")]
    public V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterion? StaticThresholdCriterion { get; set; }
}

/// <summary>OdataType: specifies the type of the alert criteria.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaOdataTypeEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaOdataTypeEnum
{
    [EnumMember(Value = "Microsoft.Azure.Monitor.MultipleResourceMultipleMetricCriteria"), JsonStringEnumMemberName("Microsoft.Azure.Monitor.MultipleResourceMultipleMetricCriteria")]
    MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria
}

/// <summary>MicrosoftAzureMonitorMultipleResourceMultipleMetric: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>AllOf: the list of multiple metric criteria for this &apos;all of&apos; operation.</summary>
    [JsonPropertyName("allOf")]
    public IList<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOf>? AllOf { get; set; }

    /// <summary>OdataType: specifies the type of the alert criteria.</summary>
    [JsonPropertyName("odata.type")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaOdataTypeEnum OdataType { get; set; }
}

/// <summary>CriterionType: Specifies the type of threshold criteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfCriterionTypeEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfCriterionTypeEnum
{
    [EnumMember(Value = "StaticThresholdCriterion"), JsonStringEnumMemberName("StaticThresholdCriterion")]
    StaticThresholdCriterion
}

/// <summary>Specifies a metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfDimensions
{
    /// <summary>Name: Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Operator: the dimension operator. Only &apos;Include&apos; and &apos;Exclude&apos; are supported</summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>Values: list of dimension values.</summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>Operator: the criteria operator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfOperatorEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual
}

/// <summary>TimeAggregation: the criteria time aggregation types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfTimeAggregationEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfTimeAggregationEnum
{
    [EnumMember(Value = "Average"), JsonStringEnumMemberName("Average")]
    Average,
    [EnumMember(Value = "Count"), JsonStringEnumMemberName("Count")]
    Count,
    [EnumMember(Value = "Maximum"), JsonStringEnumMemberName("Maximum")]
    Maximum,
    [EnumMember(Value = "Minimum"), JsonStringEnumMemberName("Minimum")]
    Minimum,
    [EnumMember(Value = "Total"), JsonStringEnumMemberName("Total")]
    Total
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOf
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>CriterionType: Specifies the type of threshold criteria</summary>
    [JsonPropertyName("criterionType")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfCriterionTypeEnum CriterionType { get; set; }

    /// <summary>Dimensions: List of dimension conditions.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfDimensions>? Dimensions { get; set; }

    /// <summary>MetricName: Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public required string MetricName { get; set; }

    /// <summary>MetricNamespace: Namespace of the metric.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>Name: Name of the criteria.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Operator: the criteria operator.</summary>
    [JsonPropertyName("operator")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfOperatorEnum Operator { get; set; }

    /// <summary>
    /// SkipMetricValidation: Allows creating an alert rule on a custom metric that isn&apos;t yet emitted, by causing the metric
    /// validation to be skipped.
    /// </summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>Threshold: the criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public required double Threshold { get; set; }

    /// <summary>TimeAggregation: the criteria time aggregation types.</summary>
    [JsonPropertyName("timeAggregation")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfTimeAggregationEnum TimeAggregation { get; set; }
}

/// <summary>OdataType: specifies the type of the alert criteria.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaOdataTypeEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaOdataTypeEnum
{
    [EnumMember(Value = "Microsoft.Azure.Monitor.SingleResourceMultipleMetricCriteria"), JsonStringEnumMemberName("Microsoft.Azure.Monitor.SingleResourceMultipleMetricCriteria")]
    MicrosoftAzureMonitorSingleResourceMultipleMetricCriteria
}

/// <summary>MicrosoftAzureMonitorSingleResourceMultipleMetric: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteria
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>AllOf: The list of metric criteria for this &apos;all of&apos; operation.</summary>
    [JsonPropertyName("allOf")]
    public IList<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOf>? AllOf { get; set; }

    /// <summary>OdataType: specifies the type of the alert criteria.</summary>
    [JsonPropertyName("odata.type")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaOdataTypeEnum OdataType { get; set; }
}

/// <summary>ComponentReference: The Application Insights resource Id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteriaComponentReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>OdataType: specifies the type of the alert criteria.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteriaOdataTypeEnum>))]
public enum V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteriaOdataTypeEnum
{
    [EnumMember(Value = "Microsoft.Azure.Monitor.WebtestLocationAvailabilityCriteria"), JsonStringEnumMemberName("Microsoft.Azure.Monitor.WebtestLocationAvailabilityCriteria")]
    MicrosoftAzureMonitorWebtestLocationAvailabilityCriteria
}

/// <summary>MicrosoftAzureMonitorWebtestLocationAvailability: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteria
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>ComponentReference: The Application Insights resource Id.</summary>
    [JsonPropertyName("componentReference")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteriaComponentReference ComponentReference { get; set; }

    /// <summary>FailedLocationCount: The number of failed locations.</summary>
    [JsonPropertyName("failedLocationCount")]
    public required double FailedLocationCount { get; set; }

    /// <summary>OdataType: specifies the type of the alert criteria.</summary>
    [JsonPropertyName("odata.type")]
    public required V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteriaOdataTypeEnum OdataType { get; set; }

    /// <summary>WebTestId: The Application Insights web test Id.</summary>
    [JsonPropertyName("webTestId")]
    public required string WebTestId { get; set; }
}

/// <summary>Criteria: defines the specific alert criteria information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecCriteria
{
    /// <summary>MicrosoftAzureMonitorMultipleResourceMultipleMetric: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("microsoftAzureMonitorMultipleResourceMultipleMetricCriteria")]
    public V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria? MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria { get; set; }

    /// <summary>MicrosoftAzureMonitorSingleResourceMultipleMetric: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("microsoftAzureMonitorSingleResourceMultipleMetricCriteria")]
    public V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteria? MicrosoftAzureMonitorSingleResourceMultipleMetricCriteria { get; set; }

    /// <summary>MicrosoftAzureMonitorWebtestLocationAvailability: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("microsoftAzureMonitorWebtestLocationAvailabilityCriteria")]
    public V1api20180301MetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteria? MicrosoftAzureMonitorWebtestLocationAvailabilityCriteria { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20180301MetricAlertSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20180301MetricAlertSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpecScopesReferences
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertSpec
{
    /// <summary>
    /// Actions: the array of actions that are performed when the alert rule becomes active, and when an alert condition is
    /// resolved.
    /// </summary>
    [JsonPropertyName("actions")]
    public IList<V1api20180301MetricAlertSpecActions>? Actions { get; set; }

    /// <summary>AutoMitigate: the flag that indicates whether the alert should be auto resolved or not. The default is true.</summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Criteria: defines the specific alert criteria information.</summary>
    [JsonPropertyName("criteria")]
    public required V1api20180301MetricAlertSpecCriteria Criteria { get; set; }

    /// <summary>Description: the description of the metric alert that will be included in the alert email.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enabled: the flag that indicates whether the metric alert is enabled.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>EvaluationFrequency: how often the metric alert is evaluated represented in ISO 8601 duration format.</summary>
    [JsonPropertyName("evaluationFrequency")]
    public required string EvaluationFrequency { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20180301MetricAlertSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20180301MetricAlertSpecOwner Owner { get; set; }

    /// <summary>
    /// ScopesReferences: the list of resource id&apos;s that this metric alert is scoped to. You cannot change the scope of a metric
    /// rule based on logs.
    /// </summary>
    [JsonPropertyName("scopesReferences")]
    public required IList<V1api20180301MetricAlertSpecScopesReferences> ScopesReferences { get; set; }

    /// <summary>Severity: Alert severity {0, 1, 2, 3, 4}</summary>
    [JsonPropertyName("severity")]
    public required int Severity { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// TargetResourceRegion: the region of the target resource(s) on which the alert is created/updated. Mandatory if the scope
    /// contains a subscription, resource group, or more than one resource.
    /// </summary>
    [JsonPropertyName("targetResourceRegion")]
    public string? TargetResourceRegion { get; set; }

    /// <summary>
    /// TargetResourceType: the resource type of the target resource(s) on which the alert is created/updated. Mandatory if the
    /// scope contains a subscription, resource group, or more than one resource.
    /// </summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    /// <summary>
    /// WindowSize: the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the
    /// threshold.
    /// </summary>
    [JsonPropertyName("windowSize")]
    public required string WindowSize { get; set; }
}

/// <summary>An alert action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusActions
{
    /// <summary>ActionGroupId: the id of the action group to use.</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>
    /// WebHookProperties: This field allows specifying custom properties, which would be appended to the alert payload sent as
    /// input to the webhook.
    /// </summary>
    [JsonPropertyName("webHookProperties")]
    public IDictionary<string, string>? WebHookProperties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Specifies a metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionDimensions
{
    /// <summary>Name: Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator: the dimension operator. Only &apos;Include&apos; and &apos;Exclude&apos; are supported</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Values: list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// FailingPeriods: The minimum number of violations required within the selected lookback time window required to raise an
/// alert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionFailingPeriods
{
    /// <summary>
    /// MinFailingPeriodsToAlert: The number of violations to trigger an alert. Should be smaller or equal to
    /// numberOfEvaluationPeriods.
    /// </summary>
    [JsonPropertyName("minFailingPeriodsToAlert")]
    public double? MinFailingPeriodsToAlert { get; set; }

    /// <summary>
    /// NumberOfEvaluationPeriods: The number of aggregated lookback points. The lookback time window is calculated based on the
    /// aggregation granularity (windowSize) and the selected number of aggregated points.
    /// </summary>
    [JsonPropertyName("numberOfEvaluationPeriods")]
    public double? NumberOfEvaluationPeriods { get; set; }
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterion
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>
    /// AlertSensitivity: The extent of deviation required to trigger an alert. This will affect how tight the threshold is to
    /// the metric series pattern.
    /// </summary>
    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    /// <summary>CriterionType: Specifies the type of threshold criteria</summary>
    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    /// <summary>Dimensions: List of dimension conditions.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionDimensions>? Dimensions { get; set; }

    /// <summary>
    /// FailingPeriods: The minimum number of violations required within the selected lookback time window required to raise an
    /// alert.
    /// </summary>
    [JsonPropertyName("failingPeriods")]
    public V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionFailingPeriods? FailingPeriods { get; set; }

    /// <summary>
    /// IgnoreDataBefore: Use this option to set the date from which to start learning the metric historical data and calculate
    /// the dynamic thresholds (in ISO8601 format)
    /// </summary>
    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    /// <summary>MetricName: Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>MetricNamespace: Namespace of the metric.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>Name: Name of the criteria.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator: The operator used to compare the metric value against the threshold.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// SkipMetricValidation: Allows creating an alert rule on a custom metric that isn&apos;t yet emitted, by causing the metric
    /// validation to be skipped.
    /// </summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>TimeAggregation: the criteria time aggregation types.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>Specifies a metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionDimensions
{
    /// <summary>Name: Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator: the dimension operator. Only &apos;Include&apos; and &apos;Exclude&apos; are supported</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Values: list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterion
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>CriterionType: Specifies the type of threshold criteria</summary>
    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    /// <summary>Dimensions: List of dimension conditions.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionDimensions>? Dimensions { get; set; }

    /// <summary>MetricName: Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>MetricNamespace: Namespace of the metric.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>Name: Name of the criteria.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator: the criteria operator.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// SkipMetricValidation: Allows creating an alert rule on a custom metric that isn&apos;t yet emitted, by causing the metric
    /// validation to be skipped.
    /// </summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>Threshold: the criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>TimeAggregation: the criteria time aggregation types.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOf
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamicThresholdCriterion")]
    public V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterion? DynamicThresholdCriterion { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("staticThresholdCriterion")]
    public V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterion? StaticThresholdCriterion { get; set; }
}

/// <summary>MicrosoftAzureMonitorMultipleResourceMultipleMetric: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>AllOf: the list of multiple metric criteria for this &apos;all of&apos; operation.</summary>
    [JsonPropertyName("allOf")]
    public IList<V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOf>? AllOf { get; set; }

    /// <summary>OdataType: specifies the type of the alert criteria.</summary>
    [JsonPropertyName("odata.type")]
    public string? OdataType { get; set; }
}

/// <summary>Specifies a metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfDimensions
{
    /// <summary>Name: Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator: the dimension operator. Only &apos;Include&apos; and &apos;Exclude&apos; are supported</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Values: list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOf
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>CriterionType: Specifies the type of threshold criteria</summary>
    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    /// <summary>Dimensions: List of dimension conditions.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfDimensions>? Dimensions { get; set; }

    /// <summary>MetricName: Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>MetricNamespace: Namespace of the metric.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>Name: Name of the criteria.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator: the criteria operator.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// SkipMetricValidation: Allows creating an alert rule on a custom metric that isn&apos;t yet emitted, by causing the metric
    /// validation to be skipped.
    /// </summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>Threshold: the criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>TimeAggregation: the criteria time aggregation types.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>MicrosoftAzureMonitorSingleResourceMultipleMetric: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteria
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>AllOf: The list of metric criteria for this &apos;all of&apos; operation.</summary>
    [JsonPropertyName("allOf")]
    public IList<V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOf>? AllOf { get; set; }

    /// <summary>OdataType: specifies the type of the alert criteria.</summary>
    [JsonPropertyName("odata.type")]
    public string? OdataType { get; set; }
}

/// <summary>MicrosoftAzureMonitorWebtestLocationAvailability: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteria
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>ComponentId: The Application Insights resource Id.</summary>
    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }

    /// <summary>FailedLocationCount: The number of failed locations.</summary>
    [JsonPropertyName("failedLocationCount")]
    public double? FailedLocationCount { get; set; }

    /// <summary>OdataType: specifies the type of the alert criteria.</summary>
    [JsonPropertyName("odata.type")]
    public string? OdataType { get; set; }

    /// <summary>WebTestId: The Application Insights web test Id.</summary>
    [JsonPropertyName("webTestId")]
    public string? WebTestId { get; set; }
}

/// <summary>Criteria: defines the specific alert criteria information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatusCriteria
{
    /// <summary>MicrosoftAzureMonitorMultipleResourceMultipleMetric: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("microsoftAzureMonitorMultipleResourceMultipleMetricCriteria")]
    public V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria? MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria { get; set; }

    /// <summary>MicrosoftAzureMonitorSingleResourceMultipleMetric: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("microsoftAzureMonitorSingleResourceMultipleMetricCriteria")]
    public V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteria? MicrosoftAzureMonitorSingleResourceMultipleMetricCriteria { get; set; }

    /// <summary>MicrosoftAzureMonitorWebtestLocationAvailability: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("microsoftAzureMonitorWebtestLocationAvailabilityCriteria")]
    public V1api20180301MetricAlertStatusCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteria? MicrosoftAzureMonitorWebtestLocationAvailabilityCriteria { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301MetricAlertStatus
{
    /// <summary>
    /// Actions: the array of actions that are performed when the alert rule becomes active, and when an alert condition is
    /// resolved.
    /// </summary>
    [JsonPropertyName("actions")]
    public IList<V1api20180301MetricAlertStatusActions>? Actions { get; set; }

    /// <summary>AutoMitigate: the flag that indicates whether the alert should be auto resolved or not. The default is true.</summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20180301MetricAlertStatusConditions>? Conditions { get; set; }

    /// <summary>Criteria: defines the specific alert criteria information.</summary>
    [JsonPropertyName("criteria")]
    public V1api20180301MetricAlertStatusCriteria? Criteria { get; set; }

    /// <summary>Description: the description of the metric alert that will be included in the alert email.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enabled: the flag that indicates whether the metric alert is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>EvaluationFrequency: how often the metric alert is evaluated represented in ISO 8601 duration format.</summary>
    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    /// <summary>Id: Azure resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsMigrated: the value indicating whether this alert rule is migrated.</summary>
    [JsonPropertyName("isMigrated")]
    public bool? IsMigrated { get; set; }

    /// <summary>LastUpdatedTime: Last time the rule was updated in ISO8601 format.</summary>
    [JsonPropertyName("lastUpdatedTime")]
    public string? LastUpdatedTime { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Azure resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Scopes: the list of resource id&apos;s that this metric alert is scoped to. You cannot change the scope of a metric rule
    /// based on logs.
    /// </summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>Severity: Alert severity {0, 1, 2, 3, 4}</summary>
    [JsonPropertyName("severity")]
    public int? Severity { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// TargetResourceRegion: the region of the target resource(s) on which the alert is created/updated. Mandatory if the scope
    /// contains a subscription, resource group, or more than one resource.
    /// </summary>
    [JsonPropertyName("targetResourceRegion")]
    public string? TargetResourceRegion { get; set; }

    /// <summary>
    /// TargetResourceType: the resource type of the target resource(s) on which the alert is created/updated. Mandatory if the
    /// scope contains a subscription, resource group, or more than one resource.
    /// </summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    /// <summary>Type: Azure resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// WindowSize: the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the
    /// threshold.
    /// </summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2018-03-01/metricAlert_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/metricAlerts/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180301MetricAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20180301MetricAlertSpec?>, IStatus<V1api20180301MetricAlertStatus?>
{
    public const string KubeApiVersion = "v1api20180301";
    public const string KubeKind = "MetricAlert";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "metricalerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20180301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricAlert";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20180301MetricAlertSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20180301MetricAlertStatus? Status { get; set; }
}