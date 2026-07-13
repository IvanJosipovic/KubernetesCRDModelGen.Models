#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.com;
/// <summary>
/// Storage version of v1api20230101.BackupVaultsBackupPolicy
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-01-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageBackupVaultsBackupPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20230101storageBackupVaultsBackupPolicy>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "BackupVaultsBackupPolicyList";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackuppolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20230101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVaultsBackupPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230101storageBackupVaultsBackupPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230101storageBackupVaultsBackupPolicy> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230101storageBackupVaultsBackupPolicySpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20230101.BackupVaultsBackupPolicyOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230101storageBackupVaultsBackupPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230101storageBackupVaultsBackupPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a dataprotection.azure.com/BackupVault resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230101.AzureBackupParams</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupType")]
    public string? BackupType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.BackupParameters</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AzureBackupParams</summary>
    [JsonPropertyName("azureBackupParams")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams? AzureBackupParams { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.DataStoreInfoBase
/// DataStoreInfo base
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.RetentionTag
/// Retention tag
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.AdhocBasedTaggingCriteria
/// Adhoc backup tagging criteria
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.RetentionTag
    /// Retention tag
    /// </summary>
    [JsonPropertyName("tagInfo")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }
}

/// <summary>Storage version of v1api20230101.AdhocBasedTriggerContext</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.AdhocBasedTaggingCriteria
    /// Adhoc backup tagging criteria
    /// </summary>
    [JsonPropertyName("taggingCriteria")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria? TaggingCriteria { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.BackupSchedule
/// Schedule for backup
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("repeatingTimeIntervals")]
    public IList<string>? RepeatingTimeIntervals { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.Day
/// Day of the week
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("date")]
    public int? Date { get; set; }

    [JsonPropertyName("isLast")]
    public bool? IsLast { get; set; }
}

/// <summary>Storage version of v1api20230101.ScheduleBasedBackupCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("absoluteCriteria")]
    public IList<string>? AbsoluteCriteria { get; set; }

    [JsonPropertyName("daysOfMonth")]
    public IList<V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth>? DaysOfMonth { get; set; }

    [JsonPropertyName("daysOfTheWeek")]
    public IList<string>? DaysOfTheWeek { get; set; }

    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("scheduleTimes")]
    public IList<string>? ScheduleTimes { get; set; }

    [JsonPropertyName("weeksOfTheMonth")]
    public IList<string>? WeeksOfTheMonth { get; set; }
}

/// <summary>Storage version of v1api20230101.BackupCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.ScheduleBasedBackupCriteria</summary>
    [JsonPropertyName("scheduleBasedBackupCriteria")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria? ScheduleBasedBackupCriteria { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.RetentionTag
/// Retention tag
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.TaggingCriteria
/// Tagging criteria
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("criteria")]
    public IList<V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria>? Criteria { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.RetentionTag
    /// Retention tag
    /// </summary>
    [JsonPropertyName("tagInfo")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }

    [JsonPropertyName("taggingPriority")]
    public int? TaggingPriority { get; set; }
}

/// <summary>Storage version of v1api20230101.ScheduleBasedTriggerContext</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.BackupSchedule
    /// Schedule for backup
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule? Schedule { get; set; }

    [JsonPropertyName("taggingCriteria")]
    public IList<V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria>? TaggingCriteria { get; set; }
}

/// <summary>Storage version of v1api20230101.TriggerContext</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AdhocBasedTriggerContext</summary>
    [JsonPropertyName("adhocBasedTriggerContext")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext? AdhocBasedTriggerContext { get; set; }

    /// <summary>Storage version of v1api20230101.ScheduleBasedTriggerContext</summary>
    [JsonPropertyName("scheduleBasedTriggerContext")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext? ScheduleBasedTriggerContext { get; set; }
}

/// <summary>Storage version of v1api20230101.AzureBackupRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.BackupParameters</summary>
    [JsonPropertyName("backupParameters")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters? BackupParameters { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.DataStoreInfoBase
    /// DataStoreInfo base
    /// </summary>
    [JsonPropertyName("dataStore")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore? DataStore { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20230101.TriggerContext</summary>
    [JsonPropertyName("trigger")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger? Trigger { get; set; }
}

/// <summary>Storage version of v1api20230101.AbsoluteDeleteOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.DeleteOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AbsoluteDeleteOption</summary>
    [JsonPropertyName("absoluteDeleteOption")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption? AbsoluteDeleteOption { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.DataStoreInfoBase
/// DataStoreInfo base
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.CopyOnExpiryOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.CustomCopyOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.ImmediateCopyOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.CopyOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.CopyOnExpiryOption</summary>
    [JsonPropertyName("copyOnExpiryOption")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption? CopyOnExpiryOption { get; set; }

    /// <summary>Storage version of v1api20230101.CustomCopyOption</summary>
    [JsonPropertyName("customCopyOption")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption? CustomCopyOption { get; set; }

    /// <summary>Storage version of v1api20230101.ImmediateCopyOption</summary>
    [JsonPropertyName("immediateCopyOption")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption? ImmediateCopyOption { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.DataStoreInfoBase
/// DataStoreInfo base
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.TargetCopySetting
/// Target copy settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.CopyOption</summary>
    [JsonPropertyName("copyAfter")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter? CopyAfter { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.DataStoreInfoBase
    /// DataStoreInfo base
    /// </summary>
    [JsonPropertyName("dataStore")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore? DataStore { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.SourceLifeCycle
/// Source LifeCycle
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.DeleteOption</summary>
    [JsonPropertyName("deleteAfter")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter? DeleteAfter { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.DataStoreInfoBase
    /// DataStoreInfo base
    /// </summary>
    [JsonPropertyName("sourceDataStore")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore? SourceDataStore { get; set; }

    [JsonPropertyName("targetDataStoreCopySettings")]
    public IList<V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings>? TargetDataStoreCopySettings { get; set; }
}

/// <summary>Storage version of v1api20230101.AzureRetentionRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("lifecycles")]
    public IList<V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles>? Lifecycles { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.BasePolicyRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AzureBackupRule</summary>
    [JsonPropertyName("azureBackupRule")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRule? AzureBackupRule { get; set; }

    /// <summary>Storage version of v1api20230101.AzureRetentionRule</summary>
    [JsonPropertyName("azureRetentionRule")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRule? AzureRetentionRule { get; set; }
}

/// <summary>Storage version of v1api20230101.BackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("datasourceTypes")]
    public IList<string>? DatasourceTypes { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("policyRules")]
    public IList<V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRules>? PolicyRules { get; set; }
}

/// <summary>Storage version of v1api20230101.BaseBackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpecProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.BackupPolicy</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20230101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicy? BackupPolicy { get; set; }
}

/// <summary>Storage version of v1api20230101.BackupVaultsBackupPolicy_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicySpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.BackupVaultsBackupPolicyOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230101storageBackupVaultsBackupPolicySpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a dataprotection.azure.com/BackupVault resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230101storageBackupVaultsBackupPolicySpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20230101.BaseBackupPolicy</summary>
    [JsonPropertyName("properties")]
    public V1api20230101storageBackupVaultsBackupPolicySpecProperties? Properties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusConditions
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

/// <summary>Storage version of v1api20230101.AzureBackupParams_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupType")]
    public string? BackupType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.BackupParameters_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AzureBackupParams_STATUS</summary>
    [JsonPropertyName("azureBackupParams")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams? AzureBackupParams { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.DataStoreInfoBase_STATUS
/// DataStoreInfo base
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.RetentionTag_STATUS
/// Retention tag
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.AdhocBasedTaggingCriteria_STATUS
/// Adhoc backup tagging criteria
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.RetentionTag_STATUS
    /// Retention tag
    /// </summary>
    [JsonPropertyName("tagInfo")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }
}

/// <summary>Storage version of v1api20230101.AdhocBasedTriggerContext_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.AdhocBasedTaggingCriteria_STATUS
    /// Adhoc backup tagging criteria
    /// </summary>
    [JsonPropertyName("taggingCriteria")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria? TaggingCriteria { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.BackupSchedule_STATUS
/// Schedule for backup
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("repeatingTimeIntervals")]
    public IList<string>? RepeatingTimeIntervals { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.Day_STATUS
/// Day of the week
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("date")]
    public int? Date { get; set; }

    [JsonPropertyName("isLast")]
    public bool? IsLast { get; set; }
}

/// <summary>Storage version of v1api20230101.ScheduleBasedBackupCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("absoluteCriteria")]
    public IList<string>? AbsoluteCriteria { get; set; }

    [JsonPropertyName("daysOfMonth")]
    public IList<V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth>? DaysOfMonth { get; set; }

    [JsonPropertyName("daysOfTheWeek")]
    public IList<string>? DaysOfTheWeek { get; set; }

    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("scheduleTimes")]
    public IList<string>? ScheduleTimes { get; set; }

    [JsonPropertyName("weeksOfTheMonth")]
    public IList<string>? WeeksOfTheMonth { get; set; }
}

/// <summary>Storage version of v1api20230101.BackupCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.ScheduleBasedBackupCriteria_STATUS</summary>
    [JsonPropertyName("scheduleBasedBackupCriteria")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria? ScheduleBasedBackupCriteria { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.RetentionTag_STATUS
/// Retention tag
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.TaggingCriteria_STATUS
/// Tagging criteria
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("criteria")]
    public IList<V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria>? Criteria { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.RetentionTag_STATUS
    /// Retention tag
    /// </summary>
    [JsonPropertyName("tagInfo")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }

    [JsonPropertyName("taggingPriority")]
    public int? TaggingPriority { get; set; }
}

/// <summary>Storage version of v1api20230101.ScheduleBasedTriggerContext_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.BackupSchedule_STATUS
    /// Schedule for backup
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule? Schedule { get; set; }

    [JsonPropertyName("taggingCriteria")]
    public IList<V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria>? TaggingCriteria { get; set; }
}

/// <summary>Storage version of v1api20230101.TriggerContext_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AdhocBasedTriggerContext_STATUS</summary>
    [JsonPropertyName("adhocBasedTriggerContext")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext? AdhocBasedTriggerContext { get; set; }

    /// <summary>Storage version of v1api20230101.ScheduleBasedTriggerContext_STATUS</summary>
    [JsonPropertyName("scheduleBasedTriggerContext")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext? ScheduleBasedTriggerContext { get; set; }
}

/// <summary>Storage version of v1api20230101.AzureBackupRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.BackupParameters_STATUS</summary>
    [JsonPropertyName("backupParameters")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters? BackupParameters { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.DataStoreInfoBase_STATUS
    /// DataStoreInfo base
    /// </summary>
    [JsonPropertyName("dataStore")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore? DataStore { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20230101.TriggerContext_STATUS</summary>
    [JsonPropertyName("trigger")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger? Trigger { get; set; }
}

/// <summary>Storage version of v1api20230101.AbsoluteDeleteOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.DeleteOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AbsoluteDeleteOption_STATUS</summary>
    [JsonPropertyName("absoluteDeleteOption")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption? AbsoluteDeleteOption { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.DataStoreInfoBase_STATUS
/// DataStoreInfo base
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.CopyOnExpiryOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.CustomCopyOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.ImmediateCopyOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.CopyOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.CopyOnExpiryOption_STATUS</summary>
    [JsonPropertyName("copyOnExpiryOption")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption? CopyOnExpiryOption { get; set; }

    /// <summary>Storage version of v1api20230101.CustomCopyOption_STATUS</summary>
    [JsonPropertyName("customCopyOption")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption? CustomCopyOption { get; set; }

    /// <summary>Storage version of v1api20230101.ImmediateCopyOption_STATUS</summary>
    [JsonPropertyName("immediateCopyOption")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption? ImmediateCopyOption { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.DataStoreInfoBase_STATUS
/// DataStoreInfo base
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.TargetCopySetting_STATUS
/// Target copy settings
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.CopyOption_STATUS</summary>
    [JsonPropertyName("copyAfter")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter? CopyAfter { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.DataStoreInfoBase_STATUS
    /// DataStoreInfo base
    /// </summary>
    [JsonPropertyName("dataStore")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore? DataStore { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.SourceLifeCycle_STATUS
/// Source LifeCycle
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.DeleteOption_STATUS</summary>
    [JsonPropertyName("deleteAfter")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter? DeleteAfter { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.DataStoreInfoBase_STATUS
    /// DataStoreInfo base
    /// </summary>
    [JsonPropertyName("sourceDataStore")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore? SourceDataStore { get; set; }

    [JsonPropertyName("targetDataStoreCopySettings")]
    public IList<V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings>? TargetDataStoreCopySettings { get; set; }
}

/// <summary>Storage version of v1api20230101.AzureRetentionRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("lifecycles")]
    public IList<V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles>? Lifecycles { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20230101.BasePolicyRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AzureBackupRule_STATUS</summary>
    [JsonPropertyName("azureBackupRule")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRule? AzureBackupRule { get; set; }

    /// <summary>Storage version of v1api20230101.AzureRetentionRule_STATUS</summary>
    [JsonPropertyName("azureRetentionRule")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRule? AzureRetentionRule { get; set; }
}

/// <summary>Storage version of v1api20230101.BackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("datasourceTypes")]
    public IList<string>? DatasourceTypes { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("policyRules")]
    public IList<V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRules>? PolicyRules { get; set; }
}

/// <summary>Storage version of v1api20230101.BaseBackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.BackupPolicy_STATUS</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicy? BackupPolicy { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatusSystemData
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

/// <summary>Storage version of v1api20230101.BackupVaultsBackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageBackupVaultsBackupPolicyStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20230101storageBackupVaultsBackupPolicyStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230101.BaseBackupPolicy_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusProperties? Properties { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20230101storageBackupVaultsBackupPolicyStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.BackupVaultsBackupPolicy
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-01-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageBackupVaultsBackupPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101storageBackupVaultsBackupPolicySpec?>, IStatus<V1api20230101storageBackupVaultsBackupPolicyStatus?>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "BackupVaultsBackupPolicy";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackuppolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20230101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVaultsBackupPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230101.BackupVaultsBackupPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230101storageBackupVaultsBackupPolicySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230101.BackupVaultsBackupPolicy_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230101storageBackupVaultsBackupPolicyStatus? Status { get; set; }
}