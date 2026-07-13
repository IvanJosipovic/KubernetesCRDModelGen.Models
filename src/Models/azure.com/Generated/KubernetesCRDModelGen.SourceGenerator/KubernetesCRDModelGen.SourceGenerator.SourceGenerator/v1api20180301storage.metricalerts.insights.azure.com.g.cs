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
/// Storage version of v1api20180301.MetricAlert
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2018-03-01/metricAlert_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/metricAlerts/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180301storageMetricAlertList : IKubernetesObject<V1ListMeta>, IItems<V1api20180301storageMetricAlert>
{
    public const string KubeApiVersion = "v1api20180301storage";
    public const string KubeKind = "MetricAlertList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "metricalerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20180301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricAlertList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20180301storageMetricAlert objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20180301storageMetricAlert> Items { get; set; }
}

/// <summary>ActionGroupReference: the id of the action group to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecActionsActionGroupReference
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

/// <summary>
/// Storage version of v1api20180301.MetricAlertAction
/// An alert action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecActions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>ActionGroupReference: the id of the action group to use.</summary>
    [JsonPropertyName("actionGroupReference")]
    public V1api20180301storageMetricAlertSpecActionsActionGroupReference? ActionGroupReference { get; set; }

    [JsonPropertyName("webHookProperties")]
    public IDictionary<string, string>? WebHookProperties { get; set; }
}

/// <summary>
/// Storage version of v1api20180301.MetricDimension
/// Specifies a metric dimension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionDimensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Storage version of v1api20180301.DynamicThresholdFailingPeriods
/// The minimum number of violations required within the selected lookback time window required to raise an alert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionFailingPeriods
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("minFailingPeriodsToAlert")]
    public double? MinFailingPeriodsToAlert { get; set; }

    [JsonPropertyName("numberOfEvaluationPeriods")]
    public double? NumberOfEvaluationPeriods { get; set; }
}

/// <summary>Storage version of v1api20180301.DynamicMetricCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterion
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionDimensions>? Dimensions { get; set; }

    /// <summary>
    /// Storage version of v1api20180301.DynamicThresholdFailingPeriods
    /// The minimum number of violations required within the selected lookback time window required to raise an alert.
    /// </summary>
    [JsonPropertyName("failingPeriods")]
    public V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionFailingPeriods? FailingPeriods { get; set; }

    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>
/// Storage version of v1api20180301.MetricDimension
/// Specifies a metric dimension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionDimensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterion
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionDimensions>? Dimensions { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>Storage version of v1api20180301.MultiMetricCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOf
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20180301.DynamicMetricCriteria</summary>
    [JsonPropertyName("dynamicThresholdCriterion")]
    public V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterion? DynamicThresholdCriterion { get; set; }

    /// <summary>Storage version of v1api20180301.MetricCriteria</summary>
    [JsonPropertyName("staticThresholdCriterion")]
    public V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterion? StaticThresholdCriterion { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricAlertMultipleResourceMultipleMetricCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("allOf")]
    public IList<V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOf>? AllOf { get; set; }

    [JsonPropertyName("odata.type")]
    public string? OdataType { get; set; }
}

/// <summary>
/// Storage version of v1api20180301.MetricDimension
/// Specifies a metric dimension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfDimensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOf
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfDimensions>? Dimensions { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricAlertSingleResourceMultipleMetricCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("allOf")]
    public IList<V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOf>? AllOf { get; set; }

    [JsonPropertyName("odata.type")]
    public string? OdataType { get; set; }
}

/// <summary>ComponentReference: The Application Insights resource Id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteriaComponentReference
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

/// <summary>Storage version of v1api20180301.WebtestLocationAvailabilityCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>ComponentReference: The Application Insights resource Id.</summary>
    [JsonPropertyName("componentReference")]
    public required V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteriaComponentReference ComponentReference { get; set; }

    [JsonPropertyName("failedLocationCount")]
    public double? FailedLocationCount { get; set; }

    [JsonPropertyName("odata.type")]
    public string? OdataType { get; set; }

    [JsonPropertyName("webTestId")]
    public string? WebTestId { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricAlertCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20180301.MetricAlertMultipleResourceMultipleMetricCriteria</summary>
    [JsonPropertyName("microsoftAzureMonitorMultipleResourceMultipleMetricCriteria")]
    public V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria? MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria { get; set; }

    /// <summary>Storage version of v1api20180301.MetricAlertSingleResourceMultipleMetricCriteria</summary>
    [JsonPropertyName("microsoftAzureMonitorSingleResourceMultipleMetricCriteria")]
    public V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteria? MicrosoftAzureMonitorSingleResourceMultipleMetricCriteria { get; set; }

    /// <summary>Storage version of v1api20180301.WebtestLocationAvailabilityCriteria</summary>
    [JsonPropertyName("microsoftAzureMonitorWebtestLocationAvailabilityCriteria")]
    public V1api20180301storageMetricAlertSpecCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteria? MicrosoftAzureMonitorWebtestLocationAvailabilityCriteria { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20180301.MetricAlertOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20180301storageMetricAlertSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20180301storageMetricAlertSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpecScopesReferences
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

/// <summary>Storage version of v1api20180301.MetricAlert_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actions")]
    public IList<V1api20180301storageMetricAlertSpecActions>? Actions { get; set; }

    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20180301.MetricAlertCriteria</summary>
    [JsonPropertyName("criteria")]
    public V1api20180301storageMetricAlertSpecCriteria? Criteria { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20180301.MetricAlertOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20180301storageMetricAlertSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20180301storageMetricAlertSpecOwner Owner { get; set; }

    [JsonPropertyName("scopesReferences")]
    public IList<V1api20180301storageMetricAlertSpecScopesReferences>? ScopesReferences { get; set; }

    [JsonPropertyName("severity")]
    public int? Severity { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("targetResourceRegion")]
    public string? TargetResourceRegion { get; set; }

    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>
/// Storage version of v1api20180301.MetricAlertAction_STATUS
/// An alert action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusActions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    [JsonPropertyName("webHookProperties")]
    public IDictionary<string, string>? WebHookProperties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusConditions
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

/// <summary>
/// Storage version of v1api20180301.MetricDimension_STATUS
/// Specifies a metric dimension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionDimensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Storage version of v1api20180301.DynamicThresholdFailingPeriods_STATUS
/// The minimum number of violations required within the selected lookback time window required to raise an alert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionFailingPeriods
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("minFailingPeriodsToAlert")]
    public double? MinFailingPeriodsToAlert { get; set; }

    [JsonPropertyName("numberOfEvaluationPeriods")]
    public double? NumberOfEvaluationPeriods { get; set; }
}

/// <summary>Storage version of v1api20180301.DynamicMetricCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterion
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionDimensions>? Dimensions { get; set; }

    /// <summary>
    /// Storage version of v1api20180301.DynamicThresholdFailingPeriods_STATUS
    /// The minimum number of violations required within the selected lookback time window required to raise an alert.
    /// </summary>
    [JsonPropertyName("failingPeriods")]
    public V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterionFailingPeriods? FailingPeriods { get; set; }

    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>
/// Storage version of v1api20180301.MetricDimension_STATUS
/// Specifies a metric dimension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionDimensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterion
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterionDimensions>? Dimensions { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>Storage version of v1api20180301.MultiMetricCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOf
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20180301.DynamicMetricCriteria_STATUS</summary>
    [JsonPropertyName("dynamicThresholdCriterion")]
    public V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfDynamicThresholdCriterion? DynamicThresholdCriterion { get; set; }

    /// <summary>Storage version of v1api20180301.MetricCriteria_STATUS</summary>
    [JsonPropertyName("staticThresholdCriterion")]
    public V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOfStaticThresholdCriterion? StaticThresholdCriterion { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricAlertMultipleResourceMultipleMetricCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("allOf")]
    public IList<V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaAllOf>? AllOf { get; set; }

    [JsonPropertyName("odata.type")]
    public string? OdataType { get; set; }
}

/// <summary>
/// Storage version of v1api20180301.MetricDimension_STATUS
/// Specifies a metric dimension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfDimensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOf
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOfDimensions>? Dimensions { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricAlertSingleResourceMultipleMetricCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("allOf")]
    public IList<V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaAllOf>? AllOf { get; set; }

    [JsonPropertyName("odata.type")]
    public string? OdataType { get; set; }
}

/// <summary>Storage version of v1api20180301.WebtestLocationAvailabilityCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }

    [JsonPropertyName("failedLocationCount")]
    public double? FailedLocationCount { get; set; }

    [JsonPropertyName("odata.type")]
    public string? OdataType { get; set; }

    [JsonPropertyName("webTestId")]
    public string? WebTestId { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricAlertCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatusCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20180301.MetricAlertMultipleResourceMultipleMetricCriteria_STATUS</summary>
    [JsonPropertyName("microsoftAzureMonitorMultipleResourceMultipleMetricCriteria")]
    public V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria? MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria { get; set; }

    /// <summary>Storage version of v1api20180301.MetricAlertSingleResourceMultipleMetricCriteria_STATUS</summary>
    [JsonPropertyName("microsoftAzureMonitorSingleResourceMultipleMetricCriteria")]
    public V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorSingleResourceMultipleMetricCriteria? MicrosoftAzureMonitorSingleResourceMultipleMetricCriteria { get; set; }

    /// <summary>Storage version of v1api20180301.WebtestLocationAvailabilityCriteria_STATUS</summary>
    [JsonPropertyName("microsoftAzureMonitorWebtestLocationAvailabilityCriteria")]
    public V1api20180301storageMetricAlertStatusCriteriaMicrosoftAzureMonitorWebtestLocationAvailabilityCriteria? MicrosoftAzureMonitorWebtestLocationAvailabilityCriteria { get; set; }
}

/// <summary>Storage version of v1api20180301.MetricAlert_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180301storageMetricAlertStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actions")]
    public IList<V1api20180301storageMetricAlertStatusActions>? Actions { get; set; }

    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20180301storageMetricAlertStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20180301.MetricAlertCriteria_STATUS</summary>
    [JsonPropertyName("criteria")]
    public V1api20180301storageMetricAlertStatusCriteria? Criteria { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isMigrated")]
    public bool? IsMigrated { get; set; }

    [JsonPropertyName("lastUpdatedTime")]
    public string? LastUpdatedTime { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("severity")]
    public int? Severity { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("targetResourceRegion")]
    public string? TargetResourceRegion { get; set; }

    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>
/// Storage version of v1api20180301.MetricAlert
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2018-03-01/metricAlert_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/metricAlerts/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180301storageMetricAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20180301storageMetricAlertSpec?>, IStatus<V1api20180301storageMetricAlertStatus?>
{
    public const string KubeApiVersion = "v1api20180301storage";
    public const string KubeKind = "MetricAlert";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "metricalerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20180301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricAlert";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20180301.MetricAlert_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20180301storageMetricAlertSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20180301.MetricAlert_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20180301storageMetricAlertStatus? Status { get; set; }
}