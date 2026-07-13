#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.finops.databricks.m.crossplane.io;
/// <summary>Budget is the Schema for the Budgets API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BudgetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Budget>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BudgetList";
    public const string KubeGroup = "finops.databricks.m.crossplane.io";
    public const string KubePluralName = "budgets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "finops.databricks.m.crossplane.io/v1beta1";

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderAlertConfigurationsActionConfigurations
{
    [JsonPropertyName("actionConfigurationId")]
    public string? ActionConfigurationId { get; set; }

    /// <summary>The type of action to take when the budget alert is triggered. (Enum: EMAIL_NOTIFICATION)</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The target of the action. For EMAIL_NOTIFICATION, this is the email address to send the notification to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderAlertConfigurations
{
    /// <summary>List of action configurations to take when the budget alert is triggered. Consists of the following fields:</summary>
    [JsonPropertyName("actionConfigurations")]
    public IList<V1beta1BudgetSpecForProviderAlertConfigurationsActionConfigurations>? ActionConfigurations { get; set; }

    [JsonPropertyName("alertConfigurationId")]
    public string? AlertConfigurationId { get; set; }

    /// <summary>The threshold for the budget alert to determine if it is in a triggered state. The number is evaluated based on quantity_type.</summary>
    [JsonPropertyName("quantityThreshold")]
    public string? QuantityThreshold { get; set; }

    /// <summary>The way to calculate cost for this budget alert. This is what quantity_threshold is measured in. (Enum: LIST_PRICE_DOLLARS_USD)</summary>
    [JsonPropertyName("quantityType")]
    public string? QuantityType { get; set; }

    /// <summary>The time window of usage data for the budget. (Enum: MONTH)</summary>
    [JsonPropertyName("timePeriod")]
    public string? TimePeriod { get; set; }

    /// <summary>The evaluation method to determine when this budget alert is in a triggered state. (Enum: CUMULATIVE_SPENDING_EXCEEDED)</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

/// <summary>Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterTagsValue
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterTags
{
    /// <summary>The key of the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Consists of the following fields:</summary>
    [JsonPropertyName("value")]
    public V1beta1BudgetSpecForProviderFilterTagsValue? Value { get; set; }
}

/// <summary>Filter by workspace ID (if empty, include usage all usage for this account). Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilterWorkspaceId
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderFilter
{
    /// <summary>List of tags to filter by. Consists of the following fields:</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1BudgetSpecForProviderFilterTags>? Tags { get; set; }

    /// <summary>Filter by workspace ID (if empty, include usage all usage for this account). Consists of the following fields:</summary>
    [JsonPropertyName("workspaceId")]
    public V1beta1BudgetSpecForProviderFilterWorkspaceId? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProvider
{
    /// <summary>The ID of the Databricks Account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    [JsonPropertyName("alertConfigurations")]
    public IList<V1beta1BudgetSpecForProviderAlertConfigurations>? AlertConfigurations { get; set; }

    /// <summary>The ID of the budget configuration.</summary>
    [JsonPropertyName("budgetConfigurationId")]
    public string? BudgetConfigurationId { get; set; }

    [JsonPropertyName("createTime")]
    public double? CreateTime { get; set; }

    /// <summary>Name of the budget in Databricks Account.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("filter")]
    public V1beta1BudgetSpecForProviderFilter? Filter { get; set; }

    [JsonPropertyName("updateTime")]
    public double? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderAlertConfigurationsActionConfigurations
{
    [JsonPropertyName("actionConfigurationId")]
    public string? ActionConfigurationId { get; set; }

    /// <summary>The type of action to take when the budget alert is triggered. (Enum: EMAIL_NOTIFICATION)</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The target of the action. For EMAIL_NOTIFICATION, this is the email address to send the notification to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderAlertConfigurations
{
    /// <summary>List of action configurations to take when the budget alert is triggered. Consists of the following fields:</summary>
    [JsonPropertyName("actionConfigurations")]
    public IList<V1beta1BudgetSpecInitProviderAlertConfigurationsActionConfigurations>? ActionConfigurations { get; set; }

    [JsonPropertyName("alertConfigurationId")]
    public string? AlertConfigurationId { get; set; }

    /// <summary>The threshold for the budget alert to determine if it is in a triggered state. The number is evaluated based on quantity_type.</summary>
    [JsonPropertyName("quantityThreshold")]
    public string? QuantityThreshold { get; set; }

    /// <summary>The way to calculate cost for this budget alert. This is what quantity_threshold is measured in. (Enum: LIST_PRICE_DOLLARS_USD)</summary>
    [JsonPropertyName("quantityType")]
    public string? QuantityType { get; set; }

    /// <summary>The time window of usage data for the budget. (Enum: MONTH)</summary>
    [JsonPropertyName("timePeriod")]
    public string? TimePeriod { get; set; }

    /// <summary>The evaluation method to determine when this budget alert is in a triggered state. (Enum: CUMULATIVE_SPENDING_EXCEEDED)</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

/// <summary>Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterTagsValue
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterTags
{
    /// <summary>The key of the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Consists of the following fields:</summary>
    [JsonPropertyName("value")]
    public V1beta1BudgetSpecInitProviderFilterTagsValue? Value { get; set; }
}

/// <summary>Filter by workspace ID (if empty, include usage all usage for this account). Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilterWorkspaceId
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderFilter
{
    /// <summary>List of tags to filter by. Consists of the following fields:</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1BudgetSpecInitProviderFilterTags>? Tags { get; set; }

    /// <summary>Filter by workspace ID (if empty, include usage all usage for this account). Consists of the following fields:</summary>
    [JsonPropertyName("workspaceId")]
    public V1beta1BudgetSpecInitProviderFilterWorkspaceId? WorkspaceId { get; set; }
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
    /// <summary>The ID of the Databricks Account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    [JsonPropertyName("alertConfigurations")]
    public IList<V1beta1BudgetSpecInitProviderAlertConfigurations>? AlertConfigurations { get; set; }

    /// <summary>The ID of the budget configuration.</summary>
    [JsonPropertyName("budgetConfigurationId")]
    public string? BudgetConfigurationId { get; set; }

    [JsonPropertyName("createTime")]
    public double? CreateTime { get; set; }

    /// <summary>Name of the budget in Databricks Account.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("filter")]
    public V1beta1BudgetSpecInitProviderFilter? Filter { get; set; }

    [JsonPropertyName("updateTime")]
    public double? UpdateTime { get; set; }
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderAlertConfigurationsActionConfigurations
{
    [JsonPropertyName("actionConfigurationId")]
    public string? ActionConfigurationId { get; set; }

    /// <summary>The type of action to take when the budget alert is triggered. (Enum: EMAIL_NOTIFICATION)</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The target of the action. For EMAIL_NOTIFICATION, this is the email address to send the notification to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderAlertConfigurations
{
    /// <summary>List of action configurations to take when the budget alert is triggered. Consists of the following fields:</summary>
    [JsonPropertyName("actionConfigurations")]
    public IList<V1beta1BudgetStatusAtProviderAlertConfigurationsActionConfigurations>? ActionConfigurations { get; set; }

    [JsonPropertyName("alertConfigurationId")]
    public string? AlertConfigurationId { get; set; }

    /// <summary>The threshold for the budget alert to determine if it is in a triggered state. The number is evaluated based on quantity_type.</summary>
    [JsonPropertyName("quantityThreshold")]
    public string? QuantityThreshold { get; set; }

    /// <summary>The way to calculate cost for this budget alert. This is what quantity_threshold is measured in. (Enum: LIST_PRICE_DOLLARS_USD)</summary>
    [JsonPropertyName("quantityType")]
    public string? QuantityType { get; set; }

    /// <summary>The time window of usage data for the budget. (Enum: MONTH)</summary>
    [JsonPropertyName("timePeriod")]
    public string? TimePeriod { get; set; }

    /// <summary>The evaluation method to determine when this budget alert is in a triggered state. (Enum: CUMULATIVE_SPENDING_EXCEEDED)</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

/// <summary>Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterTagsValue
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterTags
{
    /// <summary>The key of the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Consists of the following fields:</summary>
    [JsonPropertyName("value")]
    public V1beta1BudgetStatusAtProviderFilterTagsValue? Value { get; set; }
}

/// <summary>Filter by workspace ID (if empty, include usage all usage for this account). Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilterWorkspaceId
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderFilter
{
    /// <summary>List of tags to filter by. Consists of the following fields:</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1BudgetStatusAtProviderFilterTags>? Tags { get; set; }

    /// <summary>Filter by workspace ID (if empty, include usage all usage for this account). Consists of the following fields:</summary>
    [JsonPropertyName("workspaceId")]
    public V1beta1BudgetStatusAtProviderFilterWorkspaceId? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProvider
{
    /// <summary>The ID of the Databricks Account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    [JsonPropertyName("alertConfigurations")]
    public IList<V1beta1BudgetStatusAtProviderAlertConfigurations>? AlertConfigurations { get; set; }

    /// <summary>The ID of the budget configuration.</summary>
    [JsonPropertyName("budgetConfigurationId")]
    public string? BudgetConfigurationId { get; set; }

    [JsonPropertyName("createTime")]
    public double? CreateTime { get; set; }

    /// <summary>Name of the budget in Databricks Account.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("filter")]
    public V1beta1BudgetStatusAtProviderFilter? Filter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("updateTime")]
    public double? UpdateTime { get; set; }
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

/// <summary>Budget is the Schema for the Budgets API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Budget : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BudgetSpec>, IStatus<V1beta1BudgetStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Budget";
    public const string KubeGroup = "finops.databricks.m.crossplane.io";
    public const string KubePluralName = "budgets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "finops.databricks.m.crossplane.io/v1beta1";

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