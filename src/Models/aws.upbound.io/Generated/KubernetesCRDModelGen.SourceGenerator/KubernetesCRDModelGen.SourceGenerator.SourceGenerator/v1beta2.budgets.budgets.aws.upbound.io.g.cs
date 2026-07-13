#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.budgets.aws.upbound.io;
/// <summary>Budget is the Schema for the Budgets API. Provides a budgets budget resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BudgetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Budget>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BudgetList";
    public const string KubeGroup = "budgets.aws.upbound.io";
    public const string KubePluralName = "budgets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "budgets.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BudgetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Budget objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Budget> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BudgetSpecDeletionPolicyEnum>))]
public enum V1beta2BudgetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderAutoAdjustDataHistoricalOptions
{
    /// <summary>The number of budget periods included in the moving-average calculation that determines your auto-adjusted budget amount.</summary>
    [JsonPropertyName("budgetAdjustmentPeriod")]
    public double? BudgetAdjustmentPeriod { get; set; }
}

/// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderAutoAdjustData
{
    /// <summary>The string that defines whether your budget auto-adjusts based on historical or forecasted data. Valid values: FORECAST,HISTORICAL</summary>
    [JsonPropertyName("autoAdjustType")]
    public string? AutoAdjustType { get; set; }

    /// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
    [JsonPropertyName("historicalOptions")]
    public V1beta2BudgetSpecForProviderAutoAdjustDataHistoricalOptions? HistoricalOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderCostFilter
{
    /// <summary>The name of a budget. Unique within accounts.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderCostTypes
{
    /// <summary>A boolean value whether to include credits in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeCredit")]
    public bool? IncludeCredit { get; set; }

    /// <summary>Whether a budget includes discounts. Defaults to true</summary>
    [JsonPropertyName("includeDiscount")]
    public bool? IncludeDiscount { get; set; }

    /// <summary>A boolean value whether to include other subscription costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeOtherSubscription")]
    public bool? IncludeOtherSubscription { get; set; }

    /// <summary>A boolean value whether to include recurring costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRecurring")]
    public bool? IncludeRecurring { get; set; }

    /// <summary>A boolean value whether to include refunds in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRefund")]
    public bool? IncludeRefund { get; set; }

    /// <summary>A boolean value whether to include subscriptions in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSubscription")]
    public bool? IncludeSubscription { get; set; }

    /// <summary>A boolean value whether to include support costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSupport")]
    public bool? IncludeSupport { get; set; }

    /// <summary>A boolean value whether to include tax in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeTax")]
    public bool? IncludeTax { get; set; }

    /// <summary>A boolean value whether to include upfront costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeUpfront")]
    public bool? IncludeUpfront { get; set; }

    /// <summary>Whether a budget uses the amortized rate. Defaults to false</summary>
    [JsonPropertyName("useAmortized")]
    public bool? UseAmortized { get; set; }

    /// <summary>A boolean value whether to use blended costs in the cost budget. Defaults to false</summary>
    [JsonPropertyName("useBlended")]
    public bool? UseBlended { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionAnd
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetSpecForProviderFilterExpressionAndAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetSpecForProviderFilterExpressionAndOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionNot
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetSpecForProviderFilterExpressionNotAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetSpecForProviderFilterExpressionNotOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionOr
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetSpecForProviderFilterExpressionOrAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetSpecForProviderFilterExpressionOrOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpressionTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Object containing Filter Expression to apply to budget. Conflicts with cost_filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderFilterExpression
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetSpecForProviderFilterExpressionAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecForProviderFilterExpressionCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecForProviderFilterExpressionDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetSpecForProviderFilterExpressionNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetSpecForProviderFilterExpressionOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecForProviderFilterExpressionTags? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderNotification
{
    /// <summary>Comparison operator to use to evaluate the condition. Can be LESS_THAN, EQUAL_TO or GREATER_THAN.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>What kind of budget value to notify on. Can be ACTUAL or FORECASTED</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>E-Mail addresses to notify. Either this or subscriber_sns_topic_arns is required.</summary>
    [JsonPropertyName("subscriberEmailAddresses")]
    public IList<string>? SubscriberEmailAddresses { get; set; }

    /// <summary>SNS topics to notify. Either this or subscriber_email_addresses is required.</summary>
    [JsonPropertyName("subscriberSnsTopicArns")]
    public IList<string>? SubscriberSnsTopicArns { get; set; }

    /// <summary>Threshold when the notification should be sent.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>What kind of threshold is defined. Can be PERCENTAGE OR ABSOLUTE_VALUE.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProviderPlannedLimit
{
    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <summary>The start time of the budget limit. Format: 2017-01-01_12:00. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecForProvider
{
    /// <summary>The ID of the target account for budget. Will use current user&apos;s account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
    [JsonPropertyName("autoAdjustData")]
    public V1beta2BudgetSpecForProviderAutoAdjustData? AutoAdjustData { get; set; }

    /// <summary>ARN of the billing view.</summary>
    [JsonPropertyName("billingViewArn")]
    public string? BillingViewArn { get; set; }

    /// <summary>Whether this budget tracks monetary cost or usage.</summary>
    [JsonPropertyName("budgetType")]
    public string? BudgetType { get; set; }

    /// <summary>A list of CostFilter name/values pair to apply to budget. Conflicts with filter_expression.</summary>
    [JsonPropertyName("costFilter")]
    public IList<V1beta2BudgetSpecForProviderCostFilter>? CostFilter { get; set; }

    /// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
    [JsonPropertyName("costTypes")]
    public V1beta2BudgetSpecForProviderCostTypes? CostTypes { get; set; }

    /// <summary>Object containing Filter Expression to apply to budget. Conflicts with cost_filter.</summary>
    [JsonPropertyName("filterExpression")]
    public V1beta2BudgetSpecForProviderFilterExpression? FilterExpression { get; set; }

    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("limitAmount")]
    public string? LimitAmount { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("limitUnit")]
    public string? LimitUnit { get; set; }

    /// <summary>Object containing Budget Notifications. Can be used multiple times to define more than one budget notification.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta2BudgetSpecForProviderNotification>? Notification { get; set; }

    /// <summary>Object containing Planned Budget Limits. Can be used multiple times to plan more than one budget limit. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("plannedLimit")]
    public IList<V1beta2BudgetSpecForProviderPlannedLimit>? PlannedLimit { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The end of the time period covered by the budget. There are no restrictions on the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodEnd")]
    public string? TimePeriodEnd { get; set; }

    /// <summary>The start of the time period covered by the budget. If you don&apos;t specify a start date, AWS defaults to the start of your chosen time period. The start date must come before the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodStart")]
    public string? TimePeriodStart { get; set; }

    /// <summary>The length of time until a budget resets the actual and forecasted spend. Valid values: MONTHLY, QUARTERLY, ANNUALLY, and DAILY.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

/// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderAutoAdjustDataHistoricalOptions
{
    /// <summary>The number of budget periods included in the moving-average calculation that determines your auto-adjusted budget amount.</summary>
    [JsonPropertyName("budgetAdjustmentPeriod")]
    public double? BudgetAdjustmentPeriod { get; set; }
}

/// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderAutoAdjustData
{
    /// <summary>The string that defines whether your budget auto-adjusts based on historical or forecasted data. Valid values: FORECAST,HISTORICAL</summary>
    [JsonPropertyName("autoAdjustType")]
    public string? AutoAdjustType { get; set; }

    /// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
    [JsonPropertyName("historicalOptions")]
    public V1beta2BudgetSpecInitProviderAutoAdjustDataHistoricalOptions? HistoricalOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderCostFilter
{
    /// <summary>The name of a budget. Unique within accounts.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderCostTypes
{
    /// <summary>A boolean value whether to include credits in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeCredit")]
    public bool? IncludeCredit { get; set; }

    /// <summary>Whether a budget includes discounts. Defaults to true</summary>
    [JsonPropertyName("includeDiscount")]
    public bool? IncludeDiscount { get; set; }

    /// <summary>A boolean value whether to include other subscription costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeOtherSubscription")]
    public bool? IncludeOtherSubscription { get; set; }

    /// <summary>A boolean value whether to include recurring costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRecurring")]
    public bool? IncludeRecurring { get; set; }

    /// <summary>A boolean value whether to include refunds in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRefund")]
    public bool? IncludeRefund { get; set; }

    /// <summary>A boolean value whether to include subscriptions in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSubscription")]
    public bool? IncludeSubscription { get; set; }

    /// <summary>A boolean value whether to include support costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSupport")]
    public bool? IncludeSupport { get; set; }

    /// <summary>A boolean value whether to include tax in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeTax")]
    public bool? IncludeTax { get; set; }

    /// <summary>A boolean value whether to include upfront costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeUpfront")]
    public bool? IncludeUpfront { get; set; }

    /// <summary>Whether a budget uses the amortized rate. Defaults to false</summary>
    [JsonPropertyName("useAmortized")]
    public bool? UseAmortized { get; set; }

    /// <summary>A boolean value whether to use blended costs in the cost budget. Defaults to false</summary>
    [JsonPropertyName("useBlended")]
    public bool? UseBlended { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionAnd
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetSpecInitProviderFilterExpressionAndAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetSpecInitProviderFilterExpressionAndOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionNot
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetSpecInitProviderFilterExpressionNotAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetSpecInitProviderFilterExpressionNotOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionOr
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetSpecInitProviderFilterExpressionOrAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetSpecInitProviderFilterExpressionOrOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpressionTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Object containing Filter Expression to apply to budget. Conflicts with cost_filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderFilterExpression
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetSpecInitProviderFilterExpressionAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetSpecInitProviderFilterExpressionCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetSpecInitProviderFilterExpressionDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetSpecInitProviderFilterExpressionNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetSpecInitProviderFilterExpressionOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetSpecInitProviderFilterExpressionTags? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderNotification
{
    /// <summary>Comparison operator to use to evaluate the condition. Can be LESS_THAN, EQUAL_TO or GREATER_THAN.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>What kind of budget value to notify on. Can be ACTUAL or FORECASTED</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>E-Mail addresses to notify. Either this or subscriber_sns_topic_arns is required.</summary>
    [JsonPropertyName("subscriberEmailAddresses")]
    public IList<string>? SubscriberEmailAddresses { get; set; }

    /// <summary>SNS topics to notify. Either this or subscriber_email_addresses is required.</summary>
    [JsonPropertyName("subscriberSnsTopicArns")]
    public IList<string>? SubscriberSnsTopicArns { get; set; }

    /// <summary>Threshold when the notification should be sent.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>What kind of threshold is defined. Can be PERCENTAGE OR ABSOLUTE_VALUE.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecInitProviderPlannedLimit
{
    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <summary>The start time of the budget limit. Format: 2017-01-01_12:00. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
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
public partial class V1beta2BudgetSpecInitProvider
{
    /// <summary>The ID of the target account for budget. Will use current user&apos;s account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
    [JsonPropertyName("autoAdjustData")]
    public V1beta2BudgetSpecInitProviderAutoAdjustData? AutoAdjustData { get; set; }

    /// <summary>ARN of the billing view.</summary>
    [JsonPropertyName("billingViewArn")]
    public string? BillingViewArn { get; set; }

    /// <summary>Whether this budget tracks monetary cost or usage.</summary>
    [JsonPropertyName("budgetType")]
    public string? BudgetType { get; set; }

    /// <summary>A list of CostFilter name/values pair to apply to budget. Conflicts with filter_expression.</summary>
    [JsonPropertyName("costFilter")]
    public IList<V1beta2BudgetSpecInitProviderCostFilter>? CostFilter { get; set; }

    /// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
    [JsonPropertyName("costTypes")]
    public V1beta2BudgetSpecInitProviderCostTypes? CostTypes { get; set; }

    /// <summary>Object containing Filter Expression to apply to budget. Conflicts with cost_filter.</summary>
    [JsonPropertyName("filterExpression")]
    public V1beta2BudgetSpecInitProviderFilterExpression? FilterExpression { get; set; }

    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("limitAmount")]
    public string? LimitAmount { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("limitUnit")]
    public string? LimitUnit { get; set; }

    /// <summary>Object containing Budget Notifications. Can be used multiple times to define more than one budget notification.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta2BudgetSpecInitProviderNotification>? Notification { get; set; }

    /// <summary>Object containing Planned Budget Limits. Can be used multiple times to plan more than one budget limit. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("plannedLimit")]
    public IList<V1beta2BudgetSpecInitProviderPlannedLimit>? PlannedLimit { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The end of the time period covered by the budget. There are no restrictions on the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodEnd")]
    public string? TimePeriodEnd { get; set; }

    /// <summary>The start of the time period covered by the budget. If you don&apos;t specify a start date, AWS defaults to the start of your chosen time period. The start date must come before the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodStart")]
    public string? TimePeriodStart { get; set; }

    /// <summary>The length of time until a budget resets the actual and forecasted spend. Valid values: MONTHLY, QUARTERLY, ANNUALLY, and DAILY.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BudgetSpecManagementPoliciesEnum>))]
public enum V1beta2BudgetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BudgetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2BudgetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BudgetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2BudgetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BudgetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BudgetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BudgetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>BudgetSpec defines the desired state of Budget</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetSpec
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
    public V1beta2BudgetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2BudgetSpecForProvider ForProvider { get; set; }

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
    public V1beta2BudgetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2BudgetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2BudgetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2BudgetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderAutoAdjustDataHistoricalOptions
{
    /// <summary>The number of budget periods included in the moving-average calculation that determines your auto-adjusted budget amount.</summary>
    [JsonPropertyName("budgetAdjustmentPeriod")]
    public double? BudgetAdjustmentPeriod { get; set; }

    /// <summary>The integer that describes how many budget periods in your BudgetAdjustmentPeriod are included in the calculation of your current budget limit. If the first budget period in your BudgetAdjustmentPeriod has no cost data, then that budget period isn’t included in the average that determines your budget limit. You can’t set your own LookBackAvailablePeriods. The value is automatically calculated from the budget_adjustment_period and your historical cost data.</summary>
    [JsonPropertyName("lookbackAvailablePeriods")]
    public double? LookbackAvailablePeriods { get; set; }
}

/// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderAutoAdjustData
{
    /// <summary>The string that defines whether your budget auto-adjusts based on historical or forecasted data. Valid values: FORECAST,HISTORICAL</summary>
    [JsonPropertyName("autoAdjustType")]
    public string? AutoAdjustType { get; set; }

    /// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
    [JsonPropertyName("historicalOptions")]
    public V1beta2BudgetStatusAtProviderAutoAdjustDataHistoricalOptions? HistoricalOptions { get; set; }

    /// <summary>The last time that your budget was auto-adjusted.</summary>
    [JsonPropertyName("lastAutoAdjustTime")]
    public string? LastAutoAdjustTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderCostFilter
{
    /// <summary>The name of a budget. Unique within accounts.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderCostTypes
{
    /// <summary>A boolean value whether to include credits in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeCredit")]
    public bool? IncludeCredit { get; set; }

    /// <summary>Whether a budget includes discounts. Defaults to true</summary>
    [JsonPropertyName("includeDiscount")]
    public bool? IncludeDiscount { get; set; }

    /// <summary>A boolean value whether to include other subscription costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeOtherSubscription")]
    public bool? IncludeOtherSubscription { get; set; }

    /// <summary>A boolean value whether to include recurring costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRecurring")]
    public bool? IncludeRecurring { get; set; }

    /// <summary>A boolean value whether to include refunds in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRefund")]
    public bool? IncludeRefund { get; set; }

    /// <summary>A boolean value whether to include subscriptions in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSubscription")]
    public bool? IncludeSubscription { get; set; }

    /// <summary>A boolean value whether to include support costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSupport")]
    public bool? IncludeSupport { get; set; }

    /// <summary>A boolean value whether to include tax in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeTax")]
    public bool? IncludeTax { get; set; }

    /// <summary>A boolean value whether to include upfront costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeUpfront")]
    public bool? IncludeUpfront { get; set; }

    /// <summary>Whether a budget uses the amortized rate. Defaults to false</summary>
    [JsonPropertyName("useAmortized")]
    public bool? UseAmortized { get; set; }

    /// <summary>A boolean value whether to use blended costs in the cost budget. Defaults to false</summary>
    [JsonPropertyName("useBlended")]
    public bool? UseBlended { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionAnd
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetStatusAtProviderFilterExpressionAndAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetStatusAtProviderFilterExpressionAndOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionNot
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetStatusAtProviderFilterExpressionNotAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetStatusAtProviderFilterExpressionNotOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrAndCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrAndDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrAndTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrNotCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrNotDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrNotTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrOrCostCategories
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A Dimension Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrOrDimensions
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOrTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionOr
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetStatusAtProviderFilterExpressionOrAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetStatusAtProviderFilterExpressionOrOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpressionTags
{
    /// <summary>The dimension to filter on. Valid values include AZ, INSTANCE_TYPE, LINKED_ACCOUNT, OPERATION, PURCHASE_TYPE, REGION, SERVICE, USAGE_TYPE, USAGE_TYPE_GROUP, RECORD_TYPE, OPERATING_SYSTEM, TENANCY, SCOPE, PLATFORM, SUBSCRIPTION_ID, LEGAL_ENTITY_NAME, DEPLOYMENT_OPTION, DATABASE_ENGINE, CACHE_ENGINE, INSTANCE_TYPE_FAMILY, BILLING_ENTITY, RESERVATION_ID, RESOURCE_ID, RIGHTSIZING_TYPE, SAVINGS_PLANS_TYPE, SAVINGS_PLAN_ARN, PAYMENT_OPTION, and AGREEMENT_END_DATE_TIME_AFTER, AGREEMENT_END_DATE_TIME_BEFORE.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The match options for the dimension filter. Valid values are EQUALS, STARTS_WITH, ENDS_WITH, CONTAINS, GREATER_THAN_OR_EQUAL, CASE_SENSITIVE, CASE_INSENSITIVE. Note: ABSENT is not supported due to AWS API contradictions (it requires values to be absent but also cannot have values set).</summary>
    [JsonPropertyName("matchOptions")]
    public IList<string>? MatchOptions { get; set; }

    /// <summary>A list of values to match against the dimension. At least one value is required.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Object containing Filter Expression to apply to budget. Conflicts with cost_filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderFilterExpression
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta2BudgetStatusAtProviderFilterExpressionAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta2BudgetStatusAtProviderFilterExpressionCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta2BudgetStatusAtProviderFilterExpressionDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta2BudgetStatusAtProviderFilterExpressionNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta2BudgetStatusAtProviderFilterExpressionOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta2BudgetStatusAtProviderFilterExpressionTags? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderNotification
{
    /// <summary>Comparison operator to use to evaluate the condition. Can be LESS_THAN, EQUAL_TO or GREATER_THAN.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>What kind of budget value to notify on. Can be ACTUAL or FORECASTED</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>E-Mail addresses to notify. Either this or subscriber_sns_topic_arns is required.</summary>
    [JsonPropertyName("subscriberEmailAddresses")]
    public IList<string>? SubscriberEmailAddresses { get; set; }

    /// <summary>SNS topics to notify. Either this or subscriber_email_addresses is required.</summary>
    [JsonPropertyName("subscriberSnsTopicArns")]
    public IList<string>? SubscriberSnsTopicArns { get; set; }

    /// <summary>Threshold when the notification should be sent.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>What kind of threshold is defined. Can be PERCENTAGE OR ABSOLUTE_VALUE.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProviderPlannedLimit
{
    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <summary>The start time of the budget limit. Format: 2017-01-01_12:00. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusAtProvider
{
    /// <summary>The ID of the target account for budget. Will use current user&apos;s account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The ARN of the budget.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
    [JsonPropertyName("autoAdjustData")]
    public V1beta2BudgetStatusAtProviderAutoAdjustData? AutoAdjustData { get; set; }

    /// <summary>ARN of the billing view.</summary>
    [JsonPropertyName("billingViewArn")]
    public string? BillingViewArn { get; set; }

    /// <summary>Whether this budget tracks monetary cost or usage.</summary>
    [JsonPropertyName("budgetType")]
    public string? BudgetType { get; set; }

    /// <summary>A list of CostFilter name/values pair to apply to budget. Conflicts with filter_expression.</summary>
    [JsonPropertyName("costFilter")]
    public IList<V1beta2BudgetStatusAtProviderCostFilter>? CostFilter { get; set; }

    /// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
    [JsonPropertyName("costTypes")]
    public V1beta2BudgetStatusAtProviderCostTypes? CostTypes { get; set; }

    /// <summary>Object containing Filter Expression to apply to budget. Conflicts with cost_filter.</summary>
    [JsonPropertyName("filterExpression")]
    public V1beta2BudgetStatusAtProviderFilterExpression? FilterExpression { get; set; }

    /// <summary>id of resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("limitAmount")]
    public string? LimitAmount { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("limitUnit")]
    public string? LimitUnit { get; set; }

    /// <summary>Object containing Budget Notifications. Can be used multiple times to define more than one budget notification.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta2BudgetStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>Object containing Planned Budget Limits. Can be used multiple times to plan more than one budget limit. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("plannedLimit")]
    public IList<V1beta2BudgetStatusAtProviderPlannedLimit>? PlannedLimit { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The end of the time period covered by the budget. There are no restrictions on the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodEnd")]
    public string? TimePeriodEnd { get; set; }

    /// <summary>The start of the time period covered by the budget. If you don&apos;t specify a start date, AWS defaults to the start of your chosen time period. The start date must come before the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodStart")]
    public string? TimePeriodStart { get; set; }

    /// <summary>The length of time until a budget resets the actual and forecasted spend. Valid values: MONTHLY, QUARTERLY, ANNUALLY, and DAILY.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatusConditions
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

/// <summary>BudgetStatus defines the observed state of Budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BudgetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2BudgetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BudgetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Budget is the Schema for the Budgets API. Provides a budgets budget resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Budget : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BudgetSpec>, IStatus<V1beta2BudgetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Budget";
    public const string KubeGroup = "budgets.aws.upbound.io";
    public const string KubePluralName = "budgets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "budgets.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Budget";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BudgetSpec defines the desired state of Budget</summary>
    [JsonPropertyName("spec")]
    public required V1beta2BudgetSpec Spec { get; set; }

    /// <summary>BudgetStatus defines the observed state of Budget.</summary>
    [JsonPropertyName("status")]
    public V1beta2BudgetStatus? Status { get; set; }
}