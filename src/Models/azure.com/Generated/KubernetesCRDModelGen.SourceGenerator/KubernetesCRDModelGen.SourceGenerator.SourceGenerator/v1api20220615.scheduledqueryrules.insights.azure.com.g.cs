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
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2022-06-15/scheduledQueryRule_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220615ScheduledQueryRuleList : IKubernetesObject<V1ListMeta>, IItems<V1api20220615ScheduledQueryRule>
{
    public const string KubeApiVersion = "v1api20220615";
    public const string KubeKind = "ScheduledQueryRuleList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "scheduledqueryrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20220615";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScheduledQueryRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220615ScheduledQueryRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220615ScheduledQueryRule> Items { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecActionsActionGroupsReferences
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

/// <summary>Actions: Actions to invoke when the alert fires.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecActions
{
    /// <summary>ActionGroupsReferences: Action Group resource Ids to invoke when the alert fires.</summary>
    [JsonPropertyName("actionGroupsReferences")]
    public IList<V1api20220615ScheduledQueryRuleSpecActionsActionGroupsReferences>? ActionGroupsReferences { get; set; }

    /// <summary>CustomProperties: The properties of an alert payload.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }
}

/// <summary>Operator: Operator for dimension values</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220615ScheduledQueryRuleSpecCriteriaAllOfDimensionsOperatorEnum>))]
public enum V1api20220615ScheduledQueryRuleSpecCriteriaAllOfDimensionsOperatorEnum
{
    [EnumMember(Value = "Exclude"), JsonStringEnumMemberName("Exclude")]
    Exclude,
    [EnumMember(Value = "Include"), JsonStringEnumMemberName("Include")]
    Include
}

/// <summary>Dimension splitting and filtering definition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecCriteriaAllOfDimensions
{
    /// <summary>Name: Name of the dimension</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Operator: Operator for dimension values</summary>
    [JsonPropertyName("operator")]
    public required V1api20220615ScheduledQueryRuleSpecCriteriaAllOfDimensionsOperatorEnum Operator { get; set; }

    /// <summary>Values: List of dimension values</summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>
/// FailingPeriods: The minimum number of violations required within the selected lookback time window required to raise an
/// alert. Relevant only for rules of the kind LogAlert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecCriteriaAllOfFailingPeriods
{
    /// <summary>
    /// MinFailingPeriodsToAlert: The number of violations to trigger an alert. Should be smaller or equal to
    /// numberOfEvaluationPeriods. Default value is 1
    /// </summary>
    [JsonPropertyName("minFailingPeriodsToAlert")]
    public int? MinFailingPeriodsToAlert { get; set; }

    /// <summary>
    /// NumberOfEvaluationPeriods: The number of aggregated lookback points. The lookback time window is calculated based on the
    /// aggregation granularity (windowSize) and the selected number of aggregated points. Default value is 1
    /// </summary>
    [JsonPropertyName("numberOfEvaluationPeriods")]
    public int? NumberOfEvaluationPeriods { get; set; }
}

/// <summary>Operator: The criteria operator. Relevant and required only for rules of the kind LogAlert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220615ScheduledQueryRuleSpecCriteriaAllOfOperatorEnum>))]
public enum V1api20220615ScheduledQueryRuleSpecCriteriaAllOfOperatorEnum
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

/// <summary>
/// ResourceIdColumnReference: The column containing the resource id. The content of the column must be a uri formatted as
/// resource id. Relevant only for rules of the kind LogAlert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecCriteriaAllOfResourceIdColumnReference
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

/// <summary>TimeAggregation: Aggregation type. Relevant and required only for rules of the kind LogAlert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220615ScheduledQueryRuleSpecCriteriaAllOfTimeAggregationEnum>))]
public enum V1api20220615ScheduledQueryRuleSpecCriteriaAllOfTimeAggregationEnum
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

/// <summary>A condition of the scheduled query rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecCriteriaAllOf
{
    /// <summary>Dimensions: List of Dimensions conditions</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20220615ScheduledQueryRuleSpecCriteriaAllOfDimensions>? Dimensions { get; set; }

    /// <summary>
    /// FailingPeriods: The minimum number of violations required within the selected lookback time window required to raise an
    /// alert. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("failingPeriods")]
    public V1api20220615ScheduledQueryRuleSpecCriteriaAllOfFailingPeriods? FailingPeriods { get; set; }

    /// <summary>MetricMeasureColumn: The column containing the metric measure number. Relevant only for rules of the kind LogAlert.</summary>
    [JsonPropertyName("metricMeasureColumn")]
    public string? MetricMeasureColumn { get; set; }

    /// <summary>MetricName: The name of the metric to be sent. Relevant and required only for rules of the kind LogToMetric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Operator: The criteria operator. Relevant and required only for rules of the kind LogAlert.</summary>
    [JsonPropertyName("operator")]
    public V1api20220615ScheduledQueryRuleSpecCriteriaAllOfOperatorEnum? Operator { get; set; }

    /// <summary>Query: Log query alert</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// ResourceIdColumnReference: The column containing the resource id. The content of the column must be a uri formatted as
    /// resource id. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("resourceIdColumnReference")]
    public V1api20220615ScheduledQueryRuleSpecCriteriaAllOfResourceIdColumnReference? ResourceIdColumnReference { get; set; }

    /// <summary>
    /// Threshold: the criteria threshold value that activates the alert. Relevant and required only for rules of the kind
    /// LogAlert.
    /// </summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>TimeAggregation: Aggregation type. Relevant and required only for rules of the kind LogAlert.</summary>
    [JsonPropertyName("timeAggregation")]
    public V1api20220615ScheduledQueryRuleSpecCriteriaAllOfTimeAggregationEnum? TimeAggregation { get; set; }
}

/// <summary>Criteria: The rule criteria that defines the conditions of the scheduled query rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecCriteria
{
    /// <summary>AllOf: A list of conditions to evaluate against the specified scopes</summary>
    [JsonPropertyName("allOf")]
    public IList<V1api20220615ScheduledQueryRuleSpecCriteriaAllOf>? AllOf { get; set; }
}

/// <summary>Kind: Indicates the type of scheduled query rule. The default is LogAlert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220615ScheduledQueryRuleSpecKindEnum>))]
public enum V1api20220615ScheduledQueryRuleSpecKindEnum
{
    [EnumMember(Value = "LogAlert"), JsonStringEnumMemberName("LogAlert")]
    LogAlert,
    [EnumMember(Value = "LogToMetric"), JsonStringEnumMemberName("LogToMetric")]
    LogToMetric
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220615ScheduledQueryRuleSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220615ScheduledQueryRuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220615ScheduledQueryRuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpecOwner
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
public partial class V1api20220615ScheduledQueryRuleSpecScopesReferences
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleSpec
{
    /// <summary>Actions: Actions to invoke when the alert fires.</summary>
    [JsonPropertyName("actions")]
    public V1api20220615ScheduledQueryRuleSpecActions? Actions { get; set; }

    /// <summary>
    /// AutoMitigate: The flag that indicates whether the alert should be automatically resolved or not. The default is true.
    /// Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// CheckWorkspaceAlertsStorageConfigured: The flag which indicates whether this scheduled query rule should be stored in
    /// the customer&apos;s storage. The default is false. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("checkWorkspaceAlertsStorageConfigured")]
    public bool? CheckWorkspaceAlertsStorageConfigured { get; set; }

    /// <summary>Criteria: The rule criteria that defines the conditions of the scheduled query rule.</summary>
    [JsonPropertyName("criteria")]
    public V1api20220615ScheduledQueryRuleSpecCriteria? Criteria { get; set; }

    /// <summary>Description: The description of the scheduled query rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: The display name of the alert rule</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Enabled: The flag which indicates whether this scheduled query rule is enabled. Value should be true or false</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// EvaluationFrequency: How often the scheduled query rule is evaluated represented in ISO 8601 duration format. Relevant
    /// and required only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    /// <summary>Kind: Indicates the type of scheduled query rule. The default is LogAlert.</summary>
    [JsonPropertyName("kind")]
    public V1api20220615ScheduledQueryRuleSpecKindEnum? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// MuteActionsDuration: Mute actions for the chosen period of time (in ISO 8601 duration format) after the alert is fired.
    /// Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("muteActionsDuration")]
    public string? MuteActionsDuration { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220615ScheduledQueryRuleSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// OverrideQueryTimeRange: If specified then overrides the query time range (default is
    /// WindowSize*NumberOfEvaluationPeriods). Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("overrideQueryTimeRange")]
    public string? OverrideQueryTimeRange { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220615ScheduledQueryRuleSpecOwner Owner { get; set; }

    /// <summary>ScopesReferences: The list of resource id&apos;s that this scheduled query rule is scoped to.</summary>
    [JsonPropertyName("scopesReferences")]
    public IList<V1api20220615ScheduledQueryRuleSpecScopesReferences>? ScopesReferences { get; set; }

    /// <summary>
    /// Severity: Severity of the alert. Should be an integer between [0-4]. Value of 0 is severest. Relevant and required only
    /// for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("severity")]
    public int? Severity { get; set; }

    /// <summary>
    /// SkipQueryValidation: The flag which indicates whether the provided query should be validated or not. The default is
    /// false. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("skipQueryValidation")]
    public bool? SkipQueryValidation { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// TargetResourceTypes: List of resource type of the target resource(s) on which the alert is created/updated. For example
    /// if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert
    /// will be fired for each virtual machine in the resource group which meet the alert criteria. Relevant only for rules of
    /// the kind LogAlert
    /// </summary>
    [JsonPropertyName("targetResourceTypes")]
    public IList<string>? TargetResourceTypes { get; set; }

    /// <summary>
    /// WindowSize: The period of time (in ISO 8601 duration format) on which the Alert query will be executed (bin size).
    /// Relevant and required only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>Actions: Actions to invoke when the alert fires.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleStatusActions
{
    /// <summary>ActionGroups: Action Group resource Ids to invoke when the alert fires.</summary>
    [JsonPropertyName("actionGroups")]
    public IList<string>? ActionGroups { get; set; }

    /// <summary>CustomProperties: The properties of an alert payload.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleStatusConditions
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

/// <summary>Dimension splitting and filtering definition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleStatusCriteriaAllOfDimensions
{
    /// <summary>Name: Name of the dimension</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator: Operator for dimension values</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Values: List of dimension values</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// FailingPeriods: The minimum number of violations required within the selected lookback time window required to raise an
/// alert. Relevant only for rules of the kind LogAlert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleStatusCriteriaAllOfFailingPeriods
{
    /// <summary>
    /// MinFailingPeriodsToAlert: The number of violations to trigger an alert. Should be smaller or equal to
    /// numberOfEvaluationPeriods. Default value is 1
    /// </summary>
    [JsonPropertyName("minFailingPeriodsToAlert")]
    public int? MinFailingPeriodsToAlert { get; set; }

    /// <summary>
    /// NumberOfEvaluationPeriods: The number of aggregated lookback points. The lookback time window is calculated based on the
    /// aggregation granularity (windowSize) and the selected number of aggregated points. Default value is 1
    /// </summary>
    [JsonPropertyName("numberOfEvaluationPeriods")]
    public int? NumberOfEvaluationPeriods { get; set; }
}

/// <summary>A condition of the scheduled query rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleStatusCriteriaAllOf
{
    /// <summary>Dimensions: List of Dimensions conditions</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20220615ScheduledQueryRuleStatusCriteriaAllOfDimensions>? Dimensions { get; set; }

    /// <summary>
    /// FailingPeriods: The minimum number of violations required within the selected lookback time window required to raise an
    /// alert. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("failingPeriods")]
    public V1api20220615ScheduledQueryRuleStatusCriteriaAllOfFailingPeriods? FailingPeriods { get; set; }

    /// <summary>MetricMeasureColumn: The column containing the metric measure number. Relevant only for rules of the kind LogAlert.</summary>
    [JsonPropertyName("metricMeasureColumn")]
    public string? MetricMeasureColumn { get; set; }

    /// <summary>MetricName: The name of the metric to be sent. Relevant and required only for rules of the kind LogToMetric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Operator: The criteria operator. Relevant and required only for rules of the kind LogAlert.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Query: Log query alert</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// ResourceIdColumn: The column containing the resource id. The content of the column must be a uri formatted as resource
    /// id. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("resourceIdColumn")]
    public string? ResourceIdColumn { get; set; }

    /// <summary>
    /// Threshold: the criteria threshold value that activates the alert. Relevant and required only for rules of the kind
    /// LogAlert.
    /// </summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>TimeAggregation: Aggregation type. Relevant and required only for rules of the kind LogAlert.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>Criteria: The rule criteria that defines the conditions of the scheduled query rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleStatusCriteria
{
    /// <summary>AllOf: A list of conditions to evaluate against the specified scopes</summary>
    [JsonPropertyName("allOf")]
    public IList<V1api20220615ScheduledQueryRuleStatusCriteriaAllOf>? AllOf { get; set; }
}

/// <summary>SystemData: SystemData of ScheduledQueryRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220615ScheduledQueryRuleStatus
{
    /// <summary>Actions: Actions to invoke when the alert fires.</summary>
    [JsonPropertyName("actions")]
    public V1api20220615ScheduledQueryRuleStatusActions? Actions { get; set; }

    /// <summary>
    /// AutoMitigate: The flag that indicates whether the alert should be automatically resolved or not. The default is true.
    /// Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>
    /// CheckWorkspaceAlertsStorageConfigured: The flag which indicates whether this scheduled query rule should be stored in
    /// the customer&apos;s storage. The default is false. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("checkWorkspaceAlertsStorageConfigured")]
    public bool? CheckWorkspaceAlertsStorageConfigured { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220615ScheduledQueryRuleStatusConditions>? Conditions { get; set; }

    /// <summary>CreatedWithApiVersion: The api-version used when creating this alert rule</summary>
    [JsonPropertyName("createdWithApiVersion")]
    public string? CreatedWithApiVersion { get; set; }

    /// <summary>Criteria: The rule criteria that defines the conditions of the scheduled query rule.</summary>
    [JsonPropertyName("criteria")]
    public V1api20220615ScheduledQueryRuleStatusCriteria? Criteria { get; set; }

    /// <summary>Description: The description of the scheduled query rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: The display name of the alert rule</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Enabled: The flag which indicates whether this scheduled query rule is enabled. Value should be true or false</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Etag: The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per
    /// the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource.
    /// HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and
    /// If-Range (section 14.27) header fields.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// EvaluationFrequency: How often the scheduled query rule is evaluated represented in ISO 8601 duration format. Relevant
    /// and required only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsLegacyLogAnalyticsRule: True if alert rule is legacy Log Analytic rule</summary>
    [JsonPropertyName("isLegacyLogAnalyticsRule")]
    public bool? IsLegacyLogAnalyticsRule { get; set; }

    /// <summary>
    /// IsWorkspaceAlertsStorageConfigured: The flag which indicates whether this scheduled query rule has been configured to be
    /// stored in the customer&apos;s storage. The default is false.
    /// </summary>
    [JsonPropertyName("isWorkspaceAlertsStorageConfigured")]
    public bool? IsWorkspaceAlertsStorageConfigured { get; set; }

    /// <summary>Kind: Indicates the type of scheduled query rule. The default is LogAlert.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// MuteActionsDuration: Mute actions for the chosen period of time (in ISO 8601 duration format) after the alert is fired.
    /// Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("muteActionsDuration")]
    public string? MuteActionsDuration { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// OverrideQueryTimeRange: If specified then overrides the query time range (default is
    /// WindowSize*NumberOfEvaluationPeriods). Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("overrideQueryTimeRange")]
    public string? OverrideQueryTimeRange { get; set; }

    /// <summary>Scopes: The list of resource id&apos;s that this scheduled query rule is scoped to.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>
    /// Severity: Severity of the alert. Should be an integer between [0-4]. Value of 0 is severest. Relevant and required only
    /// for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("severity")]
    public int? Severity { get; set; }

    /// <summary>
    /// SkipQueryValidation: The flag which indicates whether the provided query should be validated or not. The default is
    /// false. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("skipQueryValidation")]
    public bool? SkipQueryValidation { get; set; }

    /// <summary>SystemData: SystemData of ScheduledQueryRule.</summary>
    [JsonPropertyName("systemData")]
    public V1api20220615ScheduledQueryRuleStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// TargetResourceTypes: List of resource type of the target resource(s) on which the alert is created/updated. For example
    /// if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert
    /// will be fired for each virtual machine in the resource group which meet the alert criteria. Relevant only for rules of
    /// the kind LogAlert
    /// </summary>
    [JsonPropertyName("targetResourceTypes")]
    public IList<string>? TargetResourceTypes { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// WindowSize: The period of time (in ISO 8601 duration format) on which the Alert query will be executed (bin size).
    /// Relevant and required only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2022-06-15/scheduledQueryRule_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220615ScheduledQueryRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220615ScheduledQueryRuleSpec?>, IStatus<V1api20220615ScheduledQueryRuleStatus?>
{
    public const string KubeApiVersion = "v1api20220615";
    public const string KubeKind = "ScheduledQueryRule";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "scheduledqueryrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20220615";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScheduledQueryRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220615ScheduledQueryRuleSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20220615ScheduledQueryRuleStatus? Status { get; set; }
}