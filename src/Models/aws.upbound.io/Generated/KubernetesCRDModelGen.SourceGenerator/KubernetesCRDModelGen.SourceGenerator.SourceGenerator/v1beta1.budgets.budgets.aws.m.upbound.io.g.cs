#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.budgets.aws.m.upbound.io;
/// <summary>Budget is the Schema for the Budgets API. Provides a budgets budget resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BudgetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Budget>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BudgetList";
    public const string KubeGroup = "budgets.aws.m.upbound.io";
    public const string KubePluralName = "budgets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "budgets.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BudgetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Budget objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Budget> Items { get; set; }
}

/// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderAutoAdjustDataHistoricalOptions
{
    /// <summary>The number of budget periods included in the moving-average calculation that determines your auto-adjusted budget amount.</summary>
    [JsonPropertyName("budgetAdjustmentPeriod")]
    public double? BudgetAdjustmentPeriod { get; set; }
}

/// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderAutoAdjustData
{
    /// <summary>The string that defines whether your budget auto-adjusts based on historical or forecasted data. Valid values: FORECAST,HISTORICAL</summary>
    [JsonPropertyName("autoAdjustType")]
    public string? AutoAdjustType { get; set; }

    /// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
    [JsonPropertyName("historicalOptions")]
    public V1beta1BudgetSpecForProviderAutoAdjustDataHistoricalOptions? HistoricalOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderCostFilter
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
public partial class V1beta1BudgetSpecForProviderCostTypes
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndAndCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndAndDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndAndTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndNotCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndNotDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndNotTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndOrCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndOrDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndOrTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionAndTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionAnd
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetSpecForProviderFilterExpressionAndAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetSpecForProviderFilterExpressionAndOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotAndCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotAndDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotAndTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotNotCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotNotDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotNotTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotOrCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotOrDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotOrTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionNotTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionNot
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetSpecForProviderFilterExpressionNotAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetSpecForProviderFilterExpressionNotOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrAndCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrAndDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrAndTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrNotCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrNotDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrNotTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrOrCostCategories
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrOrDimensions
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrOrTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionOrTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpressionOr
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetSpecForProviderFilterExpressionOrAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetSpecForProviderFilterExpressionOrOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterExpressionTags
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
public partial class V1beta1BudgetSpecForProviderFilterExpression
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetSpecForProviderFilterExpressionAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecForProviderFilterExpressionCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecForProviderFilterExpressionDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetSpecForProviderFilterExpressionNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetSpecForProviderFilterExpressionOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecForProviderFilterExpressionTags? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderNotification
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
public partial class V1beta1BudgetSpecForProviderPlannedLimit
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
public partial class V1beta1BudgetSpecForProvider
{
    /// <summary>The ID of the target account for budget. Will use current user&apos;s account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
    [JsonPropertyName("autoAdjustData")]
    public V1beta1BudgetSpecForProviderAutoAdjustData? AutoAdjustData { get; set; }

    /// <summary>ARN of the billing view.</summary>
    [JsonPropertyName("billingViewArn")]
    public string? BillingViewArn { get; set; }

    /// <summary>Whether this budget tracks monetary cost or usage.</summary>
    [JsonPropertyName("budgetType")]
    public string? BudgetType { get; set; }

    /// <summary>A list of CostFilter name/values pair to apply to budget. Conflicts with filter_expression.</summary>
    [JsonPropertyName("costFilter")]
    public IList<V1beta1BudgetSpecForProviderCostFilter>? CostFilter { get; set; }

    /// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
    [JsonPropertyName("costTypes")]
    public V1beta1BudgetSpecForProviderCostTypes? CostTypes { get; set; }

    /// <summary>Object containing Filter Expression to apply to budget. Conflicts with cost_filter.</summary>
    [JsonPropertyName("filterExpression")]
    public V1beta1BudgetSpecForProviderFilterExpression? FilterExpression { get; set; }

    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("limitAmount")]
    public string? LimitAmount { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("limitUnit")]
    public string? LimitUnit { get; set; }

    /// <summary>Object containing Budget Notifications. Can be used multiple times to define more than one budget notification.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetSpecForProviderNotification>? Notification { get; set; }

    /// <summary>Object containing Planned Budget Limits. Can be used multiple times to plan more than one budget limit. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("plannedLimit")]
    public IList<V1beta1BudgetSpecForProviderPlannedLimit>? PlannedLimit { get; set; }

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
public partial class V1beta1BudgetSpecInitProviderAutoAdjustDataHistoricalOptions
{
    /// <summary>The number of budget periods included in the moving-average calculation that determines your auto-adjusted budget amount.</summary>
    [JsonPropertyName("budgetAdjustmentPeriod")]
    public double? BudgetAdjustmentPeriod { get; set; }
}

/// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderAutoAdjustData
{
    /// <summary>The string that defines whether your budget auto-adjusts based on historical or forecasted data. Valid values: FORECAST,HISTORICAL</summary>
    [JsonPropertyName("autoAdjustType")]
    public string? AutoAdjustType { get; set; }

    /// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
    [JsonPropertyName("historicalOptions")]
    public V1beta1BudgetSpecInitProviderAutoAdjustDataHistoricalOptions? HistoricalOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderCostFilter
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
public partial class V1beta1BudgetSpecInitProviderCostTypes
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndAndCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndAndDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndAndTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndNotCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndNotDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndNotTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndOrCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndOrDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndOrTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAndTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionAnd
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetSpecInitProviderFilterExpressionAndAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetSpecInitProviderFilterExpressionAndOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotAndCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotAndDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotAndTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotNotCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotNotDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotNotTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotOrCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotOrDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotOrTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNotTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionNot
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetSpecInitProviderFilterExpressionNotAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetSpecInitProviderFilterExpressionNotOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrAndCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrAndDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrAndTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrNotCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrNotDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrNotTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrOrCostCategories
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrOrDimensions
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrOrTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOrTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpressionOr
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetSpecInitProviderFilterExpressionOrAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetSpecInitProviderFilterExpressionOrOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterExpressionTags
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
public partial class V1beta1BudgetSpecInitProviderFilterExpression
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetSpecInitProviderFilterExpressionAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetSpecInitProviderFilterExpressionCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetSpecInitProviderFilterExpressionDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetSpecInitProviderFilterExpressionNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetSpecInitProviderFilterExpressionOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetSpecInitProviderFilterExpressionTags? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderNotification
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
public partial class V1beta1BudgetSpecInitProviderPlannedLimit
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
public partial class V1beta1BudgetSpecInitProvider
{
    /// <summary>The ID of the target account for budget. Will use current user&apos;s account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
    [JsonPropertyName("autoAdjustData")]
    public V1beta1BudgetSpecInitProviderAutoAdjustData? AutoAdjustData { get; set; }

    /// <summary>ARN of the billing view.</summary>
    [JsonPropertyName("billingViewArn")]
    public string? BillingViewArn { get; set; }

    /// <summary>Whether this budget tracks monetary cost or usage.</summary>
    [JsonPropertyName("budgetType")]
    public string? BudgetType { get; set; }

    /// <summary>A list of CostFilter name/values pair to apply to budget. Conflicts with filter_expression.</summary>
    [JsonPropertyName("costFilter")]
    public IList<V1beta1BudgetSpecInitProviderCostFilter>? CostFilter { get; set; }

    /// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
    [JsonPropertyName("costTypes")]
    public V1beta1BudgetSpecInitProviderCostTypes? CostTypes { get; set; }

    /// <summary>Object containing Filter Expression to apply to budget. Conflicts with cost_filter.</summary>
    [JsonPropertyName("filterExpression")]
    public V1beta1BudgetSpecInitProviderFilterExpression? FilterExpression { get; set; }

    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("limitAmount")]
    public string? LimitAmount { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("limitUnit")]
    public string? LimitUnit { get; set; }

    /// <summary>Object containing Budget Notifications. Can be used multiple times to define more than one budget notification.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetSpecInitProviderNotification>? Notification { get; set; }

    /// <summary>Object containing Planned Budget Limits. Can be used multiple times to plan more than one budget limit. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("plannedLimit")]
    public IList<V1beta1BudgetSpecInitProviderPlannedLimit>? PlannedLimit { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetSpecManagementPoliciesEnum>))]
public enum V1beta1BudgetSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>BudgetSpec defines the desired state of Budget</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1BudgetSpecForProvider ForProvider { get; set; }

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
    public V1beta1BudgetSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BudgetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BudgetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BudgetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderAutoAdjustDataHistoricalOptions
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
public partial class V1beta1BudgetStatusAtProviderAutoAdjustData
{
    /// <summary>The string that defines whether your budget auto-adjusts based on historical or forecasted data. Valid values: FORECAST,HISTORICAL</summary>
    [JsonPropertyName("autoAdjustType")]
    public string? AutoAdjustType { get; set; }

    /// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
    [JsonPropertyName("historicalOptions")]
    public V1beta1BudgetStatusAtProviderAutoAdjustDataHistoricalOptions? HistoricalOptions { get; set; }

    /// <summary>The last time that your budget was auto-adjusted.</summary>
    [JsonPropertyName("lastAutoAdjustTime")]
    public string? LastAutoAdjustTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderCostFilter
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
public partial class V1beta1BudgetStatusAtProviderCostTypes
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndAndCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndAndDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndAndTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndNotCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndNotDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndNotTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndOrCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndOrDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndOrTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAndTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionAnd
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetStatusAtProviderFilterExpressionAndAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetStatusAtProviderFilterExpressionAndOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotAndCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotAndDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotAndTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotNotCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotNotDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotNotTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotOrCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotOrDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotOrTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNotTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionNot
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetStatusAtProviderFilterExpressionNotAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetStatusAtProviderFilterExpressionNotOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrAndCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrAndDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrAndTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrAnd
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrAndCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrAndDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrAndTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrNotCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrNotDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrNotTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrNot
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrNotCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrNotDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrNotTags? Tags { get; set; }
}

/// <summary>A Cost Category Filter block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrOrCostCategories
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrOrDimensions
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrOrTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrOr
{
    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrOrDimensions? Dimensions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOrTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpressionOr
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetStatusAtProviderFilterExpressionOrAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetStatusAtProviderFilterExpressionOrOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionOrTags? Tags { get; set; }
}

/// <summary>Key-value map of resource tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterExpressionTags
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
public partial class V1beta1BudgetStatusAtProviderFilterExpression
{
    /// <summary>A list of filter expressions to combine with AND logic. Each and block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BudgetStatusAtProviderFilterExpressionAnd>? And { get; set; }

    /// <summary>A Cost Category Filter block.</summary>
    [JsonPropertyName("costCategories")]
    public V1beta1BudgetStatusAtProviderFilterExpressionCostCategories? CostCategories { get; set; }

    /// <summary>A Dimension Filter block.</summary>
    [JsonPropertyName("dimensions")]
    public V1beta1BudgetStatusAtProviderFilterExpressionDimensions? Dimensions { get; set; }

    /// <summary>A single filter expression to negate. Must contain exactly one root.</summary>
    [JsonPropertyName("not")]
    public V1beta1BudgetStatusAtProviderFilterExpressionNot? Not { get; set; }

    /// <summary>A list of filter expressions to combine with OR logic. Each or block is one operand and must itself contain exactly one root.</summary>
    [JsonPropertyName("or")]
    public IList<V1beta1BudgetStatusAtProviderFilterExpressionOr>? Or { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1BudgetStatusAtProviderFilterExpressionTags? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderNotification
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
public partial class V1beta1BudgetStatusAtProviderPlannedLimit
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
public partial class V1beta1BudgetStatusAtProvider
{
    /// <summary>The ID of the target account for budget. Will use current user&apos;s account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The ARN of the budget.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
    [JsonPropertyName("autoAdjustData")]
    public V1beta1BudgetStatusAtProviderAutoAdjustData? AutoAdjustData { get; set; }

    /// <summary>ARN of the billing view.</summary>
    [JsonPropertyName("billingViewArn")]
    public string? BillingViewArn { get; set; }

    /// <summary>Whether this budget tracks monetary cost or usage.</summary>
    [JsonPropertyName("budgetType")]
    public string? BudgetType { get; set; }

    /// <summary>A list of CostFilter name/values pair to apply to budget. Conflicts with filter_expression.</summary>
    [JsonPropertyName("costFilter")]
    public IList<V1beta1BudgetStatusAtProviderCostFilter>? CostFilter { get; set; }

    /// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
    [JsonPropertyName("costTypes")]
    public V1beta1BudgetStatusAtProviderCostTypes? CostTypes { get; set; }

    /// <summary>Object containing Filter Expression to apply to budget. Conflicts with cost_filter.</summary>
    [JsonPropertyName("filterExpression")]
    public V1beta1BudgetStatusAtProviderFilterExpression? FilterExpression { get; set; }

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
    public IList<V1beta1BudgetStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>Object containing Planned Budget Limits. Can be used multiple times to plan more than one budget limit. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("plannedLimit")]
    public IList<V1beta1BudgetStatusAtProviderPlannedLimit>? PlannedLimit { get; set; }

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
public partial class V1beta1BudgetStatusConditions
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
public partial class V1beta1BudgetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1BudgetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BudgetStatusConditions>? Conditions { get; set; }

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
public partial class V1beta1Budget : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BudgetSpec>, IStatus<V1beta1BudgetStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Budget";
    public const string KubeGroup = "budgets.aws.m.upbound.io";
    public const string KubePluralName = "budgets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "budgets.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Budget";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BudgetSpec defines the desired state of Budget</summary>
    [JsonPropertyName("spec")]
    public required V1beta1BudgetSpec Spec { get; set; }

    /// <summary>BudgetStatus defines the observed state of Budget.</summary>
    [JsonPropertyName("status")]
    public V1beta1BudgetStatus? Status { get; set; }
}