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
/// Storage version of v1api20250101preview.ScheduledQueryRule
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/preview/2025-01-01-preview/scheduledQueryRule_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250101previewstorageScheduledQueryRuleList : IKubernetesObject<V1ListMeta>, IItems<V1api20250101previewstorageScheduledQueryRule>
{
    public const string KubeApiVersion = "v1api20250101previewstorage";
    public const string KubeKind = "ScheduledQueryRuleList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "scheduledqueryrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20250101previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScheduledQueryRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250101previewstorageScheduledQueryRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250101previewstorageScheduledQueryRule> Items { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecActionsActionGroupsReferences
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
/// Storage version of v1api20250101preview.Actions
/// Actions to invoke when the alert fires.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecActions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionGroupsReferences")]
    public IList<V1api20250101previewstorageScheduledQueryRuleSpecActionsActionGroupsReferences>? ActionGroupsReferences { get; set; }

    [JsonPropertyName("actionProperties")]
    public IDictionary<string, string>? ActionProperties { get; set; }

    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.Dimension
/// Dimension splitting and filtering definition
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecCriteriaAllOfDimensions
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

/// <summary>Storage version of v1api20250101preview.Condition_FailingPeriods</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecCriteriaAllOfFailingPeriods
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("minFailingPeriodsToAlert")]
    public int? MinFailingPeriodsToAlert { get; set; }

    [JsonPropertyName("numberOfEvaluationPeriods")]
    public int? NumberOfEvaluationPeriods { get; set; }
}

/// <summary>
/// ResourceIdColumnReference: The column containing the resource id. The content of the column must be a uri formatted as
/// resource id. Relevant only for rules of the kind LogAlert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecCriteriaAllOfResourceIdColumnReference
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
/// Storage version of v1api20250101preview.Condition
/// A condition of the scheduled query rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecCriteriaAllOf
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20250101previewstorageScheduledQueryRuleSpecCriteriaAllOfDimensions>? Dimensions { get; set; }

    /// <summary>Storage version of v1api20250101preview.Condition_FailingPeriods</summary>
    [JsonPropertyName("failingPeriods")]
    public V1api20250101previewstorageScheduledQueryRuleSpecCriteriaAllOfFailingPeriods? FailingPeriods { get; set; }

    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    [JsonPropertyName("metricMeasureColumn")]
    public string? MetricMeasureColumn { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("minRecurrenceCount")]
    public int? MinRecurrenceCount { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// ResourceIdColumnReference: The column containing the resource id. The content of the column must be a uri formatted as
    /// resource id. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("resourceIdColumnReference")]
    public V1api20250101previewstorageScheduledQueryRuleSpecCriteriaAllOfResourceIdColumnReference? ResourceIdColumnReference { get; set; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.ScheduledQueryRuleCriteria
/// The rule criteria that defines the conditions of the scheduled query rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allOf")]
    public IList<V1api20250101previewstorageScheduledQueryRuleSpecCriteriaAllOf>? AllOf { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v1api20250101preview.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20250101previewstorageScheduledQueryRuleSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.Identity
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20250101previewstorageScheduledQueryRuleSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20250101previewstorageScheduledQueryRuleSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20250101preview.ScheduledQueryRuleOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250101previewstorageScheduledQueryRuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250101previewstorageScheduledQueryRuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.RuleResolveConfiguration
/// TBD. Relevant only for rules of the kind LogAlert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecResolveConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoResolved")]
    public bool? AutoResolved { get; set; }

    [JsonPropertyName("timeToResolve")]
    public string? TimeToResolve { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpecScopesReferences
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

/// <summary>Storage version of v1api20250101preview.ScheduledQueryRule_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.Actions
    /// Actions to invoke when the alert fires.
    /// </summary>
    [JsonPropertyName("actions")]
    public V1api20250101previewstorageScheduledQueryRuleSpecActions? Actions { get; set; }

    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("checkWorkspaceAlertsStorageConfigured")]
    public bool? CheckWorkspaceAlertsStorageConfigured { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.ScheduledQueryRuleCriteria
    /// The rule criteria that defines the conditions of the scheduled query rule.
    /// </summary>
    [JsonPropertyName("criteria")]
    public V1api20250101previewstorageScheduledQueryRuleSpecCriteria? Criteria { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.Identity
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20250101previewstorageScheduledQueryRuleSpecIdentity? Identity { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("muteActionsDuration")]
    public string? MuteActionsDuration { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.ScheduledQueryRuleOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20250101previewstorageScheduledQueryRuleSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    [JsonPropertyName("overrideQueryTimeRange")]
    public string? OverrideQueryTimeRange { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250101previewstorageScheduledQueryRuleSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.RuleResolveConfiguration
    /// TBD. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("resolveConfiguration")]
    public V1api20250101previewstorageScheduledQueryRuleSpecResolveConfiguration? ResolveConfiguration { get; set; }

    [JsonPropertyName("scopesReferences")]
    public IList<V1api20250101previewstorageScheduledQueryRuleSpecScopesReferences>? ScopesReferences { get; set; }

    [JsonPropertyName("severity")]
    public int? Severity { get; set; }

    [JsonPropertyName("skipQueryValidation")]
    public bool? SkipQueryValidation { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("targetResourceTypes")]
    public IList<string>? TargetResourceTypes { get; set; }

    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.Actions_STATUS
/// Actions to invoke when the alert fires.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusActions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionGroups")]
    public IList<string>? ActionGroups { get; set; }

    [JsonPropertyName("actionProperties")]
    public IDictionary<string, string>? ActionProperties { get; set; }

    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusConditions
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
/// Storage version of v1api20250101preview.Dimension_STATUS
/// Dimension splitting and filtering definition
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusCriteriaAllOfDimensions
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

/// <summary>Storage version of v1api20250101preview.Condition_FailingPeriods_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusCriteriaAllOfFailingPeriods
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("minFailingPeriodsToAlert")]
    public int? MinFailingPeriodsToAlert { get; set; }

    [JsonPropertyName("numberOfEvaluationPeriods")]
    public int? NumberOfEvaluationPeriods { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.Condition_STATUS
/// A condition of the scheduled query rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusCriteriaAllOf
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    [JsonPropertyName("criterionType")]
    public string? CriterionType { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1api20250101previewstorageScheduledQueryRuleStatusCriteriaAllOfDimensions>? Dimensions { get; set; }

    /// <summary>Storage version of v1api20250101preview.Condition_FailingPeriods_STATUS</summary>
    [JsonPropertyName("failingPeriods")]
    public V1api20250101previewstorageScheduledQueryRuleStatusCriteriaAllOfFailingPeriods? FailingPeriods { get; set; }

    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    [JsonPropertyName("metricMeasureColumn")]
    public string? MetricMeasureColumn { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("minRecurrenceCount")]
    public int? MinRecurrenceCount { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("resourceIdColumn")]
    public string? ResourceIdColumn { get; set; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.ScheduledQueryRuleCriteria_STATUS
/// The rule criteria that defines the conditions of the scheduled query rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allOf")]
    public IList<V1api20250101previewstorageScheduledQueryRuleStatusCriteriaAllOf>? AllOf { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.UserIdentityProperties_STATUS
/// User assigned identity properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.Identity_STATUS
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20250101previewstorageScheduledQueryRuleStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.RuleResolveConfiguration_STATUS
/// TBD. Relevant only for rules of the kind LogAlert.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusResolveConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoResolved")]
    public bool? AutoResolved { get; set; }

    [JsonPropertyName("timeToResolve")]
    public string? TimeToResolve { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20250101preview.ScheduledQueryRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250101previewstorageScheduledQueryRuleStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.Actions_STATUS
    /// Actions to invoke when the alert fires.
    /// </summary>
    [JsonPropertyName("actions")]
    public V1api20250101previewstorageScheduledQueryRuleStatusActions? Actions { get; set; }

    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    [JsonPropertyName("checkWorkspaceAlertsStorageConfigured")]
    public bool? CheckWorkspaceAlertsStorageConfigured { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20250101previewstorageScheduledQueryRuleStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("createdWithApiVersion")]
    public string? CreatedWithApiVersion { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.ScheduledQueryRuleCriteria_STATUS
    /// The rule criteria that defines the conditions of the scheduled query rule.
    /// </summary>
    [JsonPropertyName("criteria")]
    public V1api20250101previewstorageScheduledQueryRuleStatusCriteria? Criteria { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.Identity_STATUS
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20250101previewstorageScheduledQueryRuleStatusIdentity? Identity { get; set; }

    [JsonPropertyName("isLegacyLogAnalyticsRule")]
    public bool? IsLegacyLogAnalyticsRule { get; set; }

    [JsonPropertyName("isWorkspaceAlertsStorageConfigured")]
    public bool? IsWorkspaceAlertsStorageConfigured { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("muteActionsDuration")]
    public string? MuteActionsDuration { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("overrideQueryTimeRange")]
    public string? OverrideQueryTimeRange { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.RuleResolveConfiguration_STATUS
    /// TBD. Relevant only for rules of the kind LogAlert.
    /// </summary>
    [JsonPropertyName("resolveConfiguration")]
    public V1api20250101previewstorageScheduledQueryRuleStatusResolveConfiguration? ResolveConfiguration { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("severity")]
    public int? Severity { get; set; }

    [JsonPropertyName("skipQueryValidation")]
    public bool? SkipQueryValidation { get; set; }

    /// <summary>
    /// Storage version of v1api20250101preview.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20250101previewstorageScheduledQueryRuleStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("targetResourceTypes")]
    public IList<string>? TargetResourceTypes { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>
/// Storage version of v1api20250101preview.ScheduledQueryRule
/// Generator information:
/// - Generated from: /monitor/resource-manager/Microsoft.Insights/preview/2025-01-01-preview/scheduledQueryRule_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250101previewstorageScheduledQueryRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250101previewstorageScheduledQueryRuleSpec?>, IStatus<V1api20250101previewstorageScheduledQueryRuleStatus?>
{
    public const string KubeApiVersion = "v1api20250101previewstorage";
    public const string KubeKind = "ScheduledQueryRule";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "scheduledqueryrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20250101previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScheduledQueryRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20250101preview.ScheduledQueryRule_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20250101previewstorageScheduledQueryRuleSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20250101preview.ScheduledQueryRule_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20250101previewstorageScheduledQueryRuleStatus? Status { get; set; }
}