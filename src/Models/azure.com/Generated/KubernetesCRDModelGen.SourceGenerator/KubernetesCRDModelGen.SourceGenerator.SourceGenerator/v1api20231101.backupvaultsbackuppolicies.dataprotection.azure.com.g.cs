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
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-11-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101BackupVaultsBackupPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20231101BackupVaultsBackupPolicy>
{
    public const string KubeApiVersion = "v1api20231101";
    public const string KubeKind = "BackupVaultsBackupPolicyList";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackuppolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20231101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVaultsBackupPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231101BackupVaultsBackupPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231101BackupVaultsBackupPolicy> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20231101BackupVaultsBackupPolicySpecOperatorSpecSecretExpressions
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
public partial class V1api20231101BackupVaultsBackupPolicySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231101BackupVaultsBackupPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231101BackupVaultsBackupPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a dataprotection.azure.com/BackupVault resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyObjectTypeEnum
{
    [EnumMember(Value = "BackupPolicy"), JsonStringEnumMemberName("BackupPolicy")]
    BackupPolicy
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParamsObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParamsObjectTypeEnum
{
    [EnumMember(Value = "AzureBackupParams"), JsonStringEnumMemberName("AzureBackupParams")]
    AzureBackupParams
}

/// <summary>AzureBackupParams: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams
{
    /// <summary>BackupType: BackupType ; Full/Incremental etc</summary>
    [JsonPropertyName("backupType")]
    public required string BackupType { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParamsObjectTypeEnum ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters
{
    /// <summary>AzureBackupParams: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureBackupParams")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams? AzureBackupParams { get; set; }
}

/// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStoreDataStoreTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStoreDataStoreTypeEnum
{
    [EnumMember(Value = "ArchiveStore"), JsonStringEnumMemberName("ArchiveStore")]
    ArchiveStore,
    [EnumMember(Value = "OperationalStore"), JsonStringEnumMemberName("OperationalStore")]
    OperationalStore,
    [EnumMember(Value = "VaultStore"), JsonStringEnumMemberName("VaultStore")]
    VaultStore
}

/// <summary>DataStore: DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore
{
    /// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
    [JsonPropertyName("dataStoreType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStoreDataStoreTypeEnum DataStoreType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public required string ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleObjectTypeEnum
{
    [EnumMember(Value = "AzureBackupRule"), JsonStringEnumMemberName("AzureBackupRule")]
    AzureBackupRule
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextObjectTypeEnum
{
    [EnumMember(Value = "AdhocBasedTriggerContext"), JsonStringEnumMemberName("AdhocBasedTriggerContext")]
    AdhocBasedTriggerContext
}

/// <summary>TagInfo: Retention tag information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>TagName: Retention Tag Name to relate it to retention rule.</summary>
    [JsonPropertyName("tagName")]
    public required string TagName { get; set; }
}

/// <summary>TaggingCriteria: Tagging Criteria containing retention tag for adhoc backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria
{
    /// <summary>TagInfo: Retention tag information</summary>
    [JsonPropertyName("tagInfo")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }
}

/// <summary>Adhoc: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextObjectTypeEnum ObjectType { get; set; }

    /// <summary>TaggingCriteria: Tagging Criteria containing retention tag for adhoc backup.</summary>
    [JsonPropertyName("taggingCriteria")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria TaggingCriteria { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextObjectTypeEnum
{
    [EnumMember(Value = "ScheduleBasedTriggerContext"), JsonStringEnumMemberName("ScheduleBasedTriggerContext")]
    ScheduleBasedTriggerContext
}

/// <summary>Schedule: Schedule for this backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule
{
    /// <summary>
    /// RepeatingTimeIntervals: Repeating time interval which supports the ISO 8601 format and unsupported or partially
    /// supported formats.
    /// Supported ISO 8601 Time Formats
    /// The following time formats were verified to be successfully parsed and supported:
    /// - T14:30:45.123 → Thh:mm:ss.sss (with milliseconds)
    /// - T14:30:45 → Thh:mm:ss (standard time format)
    /// - T14:30 → Thh:mm (hour and minute only)
    /// All of the above may include time zone indicators like &apos;Z&apos;, &apos;+05:30&apos;, &apos;-08:00&apos;.
    /// Examples of supported timestamps:
    /// - 2023-10-15T14:30:45Z
    /// - 2023-10-15T14:30:45.123+05:30
    /// - 2023-10-15T14:30Z
    /// Unsupported or partially supported formats:
    /// - T143045.123 or T143045 (no colons)
    /// - T14.500 (decimal hours)
    /// - T14 (hour only)
    /// - T14:30.500 (minute fractions)
    /// - T24:00:00 (invalid)
    /// - T23:59:60 (leap second)
    /// </summary>
    [JsonPropertyName("repeatingTimeIntervals")]
    public required IList<string> RepeatingTimeIntervals { get; set; }

    /// <summary>
    /// TimeZone: Time Zone for a schedule.
    /// Supported timezone indicators include:
    /// - &apos;Z&apos; for UTC
    /// - &apos;+00:00&apos;
    /// - &apos;+05:30&apos;
    /// - &apos;-08:00&apos;
    /// Examples:
    /// - 2023-10-15T14:30:45Z
    /// - 2023-10-15T14:30:45.123+05:30
    /// - 2023-10-15T14:30-08:00
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaAbsoluteCriteriaEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaAbsoluteCriteriaEnum
{
    [EnumMember(Value = "AllBackup"), JsonStringEnumMemberName("AllBackup")]
    AllBackup,
    [EnumMember(Value = "FirstOfDay"), JsonStringEnumMemberName("FirstOfDay")]
    FirstOfDay,
    [EnumMember(Value = "FirstOfMonth"), JsonStringEnumMemberName("FirstOfMonth")]
    FirstOfMonth,
    [EnumMember(Value = "FirstOfWeek"), JsonStringEnumMemberName("FirstOfWeek")]
    FirstOfWeek,
    [EnumMember(Value = "FirstOfYear"), JsonStringEnumMemberName("FirstOfYear")]
    FirstOfYear
}

/// <summary>Day of the week</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth
{
    /// <summary>Date: Date of the month</summary>
    [JsonPropertyName("date")]
    public int? Date { get; set; }

    /// <summary>IsLast: Whether Date is last date of month</summary>
    [JsonPropertyName("isLast")]
    public bool? IsLast { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfTheWeekEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfTheWeekEnum
{
    [EnumMember(Value = "Friday"), JsonStringEnumMemberName("Friday")]
    Friday,
    [EnumMember(Value = "Monday"), JsonStringEnumMemberName("Monday")]
    Monday,
    [EnumMember(Value = "Saturday"), JsonStringEnumMemberName("Saturday")]
    Saturday,
    [EnumMember(Value = "Sunday"), JsonStringEnumMemberName("Sunday")]
    Sunday,
    [EnumMember(Value = "Thursday"), JsonStringEnumMemberName("Thursday")]
    Thursday,
    [EnumMember(Value = "Tuesday"), JsonStringEnumMemberName("Tuesday")]
    Tuesday,
    [EnumMember(Value = "Wednesday"), JsonStringEnumMemberName("Wednesday")]
    Wednesday
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaMonthsOfYearEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaMonthsOfYearEnum
{
    [EnumMember(Value = "April"), JsonStringEnumMemberName("April")]
    April,
    [EnumMember(Value = "August"), JsonStringEnumMemberName("August")]
    August,
    [EnumMember(Value = "December"), JsonStringEnumMemberName("December")]
    December,
    [EnumMember(Value = "February"), JsonStringEnumMemberName("February")]
    February,
    [EnumMember(Value = "January"), JsonStringEnumMemberName("January")]
    January,
    [EnumMember(Value = "July"), JsonStringEnumMemberName("July")]
    July,
    [EnumMember(Value = "June"), JsonStringEnumMemberName("June")]
    June,
    [EnumMember(Value = "March"), JsonStringEnumMemberName("March")]
    March,
    [EnumMember(Value = "May"), JsonStringEnumMemberName("May")]
    May,
    [EnumMember(Value = "November"), JsonStringEnumMemberName("November")]
    November,
    [EnumMember(Value = "October"), JsonStringEnumMemberName("October")]
    October,
    [EnumMember(Value = "September"), JsonStringEnumMemberName("September")]
    September
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaObjectTypeEnum
{
    [EnumMember(Value = "ScheduleBasedBackupCriteria"), JsonStringEnumMemberName("ScheduleBasedBackupCriteria")]
    ScheduleBasedBackupCriteria
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaWeeksOfTheMonthEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaWeeksOfTheMonthEnum
{
    [EnumMember(Value = "First"), JsonStringEnumMemberName("First")]
    First,
    [EnumMember(Value = "Fourth"), JsonStringEnumMemberName("Fourth")]
    Fourth,
    [EnumMember(Value = "Last"), JsonStringEnumMemberName("Last")]
    Last,
    [EnumMember(Value = "Second"), JsonStringEnumMemberName("Second")]
    Second,
    [EnumMember(Value = "Third"), JsonStringEnumMemberName("Third")]
    Third
}

/// <summary>ScheduleBasedBackupCriteria: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria
{
    /// <summary>
    /// AbsoluteCriteria: it contains absolute values like &quot;AllBackup&quot; / &quot;FirstOfDay&quot; / &quot;FirstOfWeek&quot; / &quot;FirstOfMonth&quot;
    /// and should be part of AbsoluteMarker enum
    /// </summary>
    [JsonPropertyName("absoluteCriteria")]
    public IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaAbsoluteCriteriaEnum>? AbsoluteCriteria { get; set; }

    /// <summary>DaysOfMonth: This is day of the month from 1 to 28 other wise last of month</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth>? DaysOfMonth { get; set; }

    /// <summary>DaysOfTheWeek: It should be Sunday/Monday/T..../Saturday</summary>
    [JsonPropertyName("daysOfTheWeek")]
    public IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfTheWeekEnum>? DaysOfTheWeek { get; set; }

    /// <summary>MonthsOfYear: It should be January/February/....../December</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaMonthsOfYearEnum>? MonthsOfYear { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaObjectTypeEnum ObjectType { get; set; }

    /// <summary>ScheduleTimes: List of schedule times for backup</summary>
    [JsonPropertyName("scheduleTimes")]
    public IList<string>? ScheduleTimes { get; set; }

    /// <summary>WeeksOfTheMonth: It should be First/Second/Third/Fourth/Last</summary>
    [JsonPropertyName("weeksOfTheMonth")]
    public IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaWeeksOfTheMonthEnum>? WeeksOfTheMonth { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria
{
    /// <summary>ScheduleBasedBackupCriteria: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("scheduleBasedBackupCriteria")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria? ScheduleBasedBackupCriteria { get; set; }
}

/// <summary>TagInfo: Retention tag information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>TagName: Retention Tag Name to relate it to retention rule.</summary>
    [JsonPropertyName("tagName")]
    public required string TagName { get; set; }
}

/// <summary>Tagging criteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria
{
    /// <summary>Criteria: Criteria which decides whether the tag can be applied to a triggered backup.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria>? Criteria { get; set; }

    /// <summary>IsDefault: Specifies if tag is default.</summary>
    [JsonPropertyName("isDefault")]
    public required bool IsDefault { get; set; }

    /// <summary>TagInfo: Retention tag information</summary>
    [JsonPropertyName("tagInfo")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo TagInfo { get; set; }

    /// <summary>TaggingPriority: Retention Tag priority.</summary>
    [JsonPropertyName("taggingPriority")]
    public required int TaggingPriority { get; set; }
}

/// <summary>Schedule: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextObjectTypeEnum ObjectType { get; set; }

    /// <summary>Schedule: Schedule for this backup</summary>
    [JsonPropertyName("schedule")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule Schedule { get; set; }

    /// <summary>TaggingCriteria: List of tags that can be applicable for given schedule.</summary>
    [JsonPropertyName("taggingCriteria")]
    public required IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria> TaggingCriteria { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger
{
    /// <summary>Adhoc: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("adhocBasedTriggerContext")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext? AdhocBasedTriggerContext { get; set; }

    /// <summary>Schedule: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("scheduleBasedTriggerContext")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext? ScheduleBasedTriggerContext { get; set; }
}

/// <summary>AzureBackup: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRule
{
    [JsonPropertyName("backupParameters")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters? BackupParameters { get; set; }

    /// <summary>DataStore: DataStoreInfo base</summary>
    [JsonPropertyName("dataStore")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore DataStore { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleObjectTypeEnum ObjectType { get; set; }

    [JsonPropertyName("trigger")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger Trigger { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOptionObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOptionObjectTypeEnum
{
    [EnumMember(Value = "AbsoluteDeleteOption"), JsonStringEnumMemberName("AbsoluteDeleteOption")]
    AbsoluteDeleteOption
}

/// <summary>AbsoluteDeleteOption: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption
{
    /// <summary>Duration: Duration of deletion after given timespan</summary>
    [JsonPropertyName("duration")]
    public required string Duration { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOptionObjectTypeEnum ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter
{
    /// <summary>AbsoluteDeleteOption: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("absoluteDeleteOption")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption? AbsoluteDeleteOption { get; set; }
}

/// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStoreDataStoreTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStoreDataStoreTypeEnum
{
    [EnumMember(Value = "ArchiveStore"), JsonStringEnumMemberName("ArchiveStore")]
    ArchiveStore,
    [EnumMember(Value = "OperationalStore"), JsonStringEnumMemberName("OperationalStore")]
    OperationalStore,
    [EnumMember(Value = "VaultStore"), JsonStringEnumMemberName("VaultStore")]
    VaultStore
}

/// <summary>SourceDataStore: DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore
{
    /// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
    [JsonPropertyName("dataStoreType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStoreDataStoreTypeEnum DataStoreType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public required string ObjectType { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOptionObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOptionObjectTypeEnum
{
    [EnumMember(Value = "CopyOnExpiryOption"), JsonStringEnumMemberName("CopyOnExpiryOption")]
    CopyOnExpiryOption
}

/// <summary>CopyOnExpiry: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOptionObjectTypeEnum ObjectType { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOptionObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOptionObjectTypeEnum
{
    [EnumMember(Value = "CustomCopyOption"), JsonStringEnumMemberName("CustomCopyOption")]
    CustomCopyOption
}

/// <summary>CustomCopy: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption
{
    /// <summary>Duration: Data copied after given timespan</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOptionObjectTypeEnum ObjectType { get; set; }
}

/// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOptionObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOptionObjectTypeEnum
{
    [EnumMember(Value = "ImmediateCopyOption"), JsonStringEnumMemberName("ImmediateCopyOption")]
    ImmediateCopyOption
}

/// <summary>ImmediateCopy: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOptionObjectTypeEnum ObjectType { get; set; }
}

/// <summary>CopyAfter: It can be CustomCopyOption or ImmediateCopyOption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter
{
    /// <summary>CopyOnExpiry: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("copyOnExpiryOption")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption? CopyOnExpiryOption { get; set; }

    /// <summary>CustomCopy: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("customCopyOption")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption? CustomCopyOption { get; set; }

    /// <summary>ImmediateCopy: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("immediateCopyOption")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption? ImmediateCopyOption { get; set; }
}

/// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStoreDataStoreTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStoreDataStoreTypeEnum
{
    [EnumMember(Value = "ArchiveStore"), JsonStringEnumMemberName("ArchiveStore")]
    ArchiveStore,
    [EnumMember(Value = "OperationalStore"), JsonStringEnumMemberName("OperationalStore")]
    OperationalStore,
    [EnumMember(Value = "VaultStore"), JsonStringEnumMemberName("VaultStore")]
    VaultStore
}

/// <summary>DataStore: Info of target datastore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore
{
    /// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
    [JsonPropertyName("dataStoreType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStoreDataStoreTypeEnum DataStoreType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public required string ObjectType { get; set; }
}

/// <summary>Target copy settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings
{
    /// <summary>CopyAfter: It can be CustomCopyOption or ImmediateCopyOption.</summary>
    [JsonPropertyName("copyAfter")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter CopyAfter { get; set; }

    /// <summary>DataStore: Info of target datastore</summary>
    [JsonPropertyName("dataStore")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore DataStore { get; set; }
}

/// <summary>Source LifeCycle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles
{
    [JsonPropertyName("deleteAfter")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter DeleteAfter { get; set; }

    /// <summary>SourceDataStore: DataStoreInfo base</summary>
    [JsonPropertyName("sourceDataStore")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore SourceDataStore { get; set; }

    [JsonPropertyName("targetDataStoreCopySettings")]
    public IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings>? TargetDataStoreCopySettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleObjectTypeEnum>))]
public enum V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleObjectTypeEnum
{
    [EnumMember(Value = "AzureRetentionRule"), JsonStringEnumMemberName("AzureRetentionRule")]
    AzureRetentionRule
}

/// <summary>AzureRetention: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRule
{
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("lifecycles")]
    public required IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles> Lifecycles { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleObjectTypeEnum ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRules
{
    /// <summary>AzureBackup: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureBackupRule")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRule? AzureBackupRule { get; set; }

    /// <summary>AzureRetention: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureRetentionRule")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRule? AzureRetentionRule { get; set; }
}

/// <summary>BackupPolicy: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicy
{
    /// <summary>DatasourceTypes: Type of datasource for the backup management</summary>
    [JsonPropertyName("datasourceTypes")]
    public required IList<string> DatasourceTypes { get; set; }

    [JsonPropertyName("objectType")]
    public required V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyObjectTypeEnum ObjectType { get; set; }

    /// <summary>PolicyRules: Policy rule dictionary that contains rules for each backuptype i.e Full/Incremental/Logs etc</summary>
    [JsonPropertyName("policyRules")]
    public required IList<V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRules> PolicyRules { get; set; }
}

/// <summary>Properties: BaseBackupPolicyResource properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpecProperties
{
    /// <summary>BackupPolicy: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20231101BackupVaultsBackupPolicySpecPropertiesBackupPolicy? BackupPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicySpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231101BackupVaultsBackupPolicySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a dataprotection.azure.com/BackupVault resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231101BackupVaultsBackupPolicySpecOwner Owner { get; set; }

    /// <summary>Properties: BaseBackupPolicyResource properties</summary>
    [JsonPropertyName("properties")]
    public V1api20231101BackupVaultsBackupPolicySpecProperties? Properties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusConditions
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

/// <summary>AzureBackupParams: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams
{
    /// <summary>BackupType: BackupType ; Full/Incremental etc</summary>
    [JsonPropertyName("backupType")]
    public string? BackupType { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters
{
    /// <summary>AzureBackupParams: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureBackupParams")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams? AzureBackupParams { get; set; }
}

/// <summary>DataStore: DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore
{
    /// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>TagInfo: Retention tag information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>ETag: Retention Tag version.</summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>Id: Retention Tag version.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>TagName: Retention Tag Name to relate it to retention rule.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>TaggingCriteria: Tagging Criteria containing retention tag for adhoc backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria
{
    /// <summary>TagInfo: Retention tag information</summary>
    [JsonPropertyName("tagInfo")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }
}

/// <summary>Adhoc: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>TaggingCriteria: Tagging Criteria containing retention tag for adhoc backup.</summary>
    [JsonPropertyName("taggingCriteria")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria? TaggingCriteria { get; set; }
}

/// <summary>Schedule: Schedule for this backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule
{
    /// <summary>
    /// RepeatingTimeIntervals: Repeating time interval which supports the ISO 8601 format and unsupported or partially
    /// supported formats.
    /// Supported ISO 8601 Time Formats
    /// The following time formats were verified to be successfully parsed and supported:
    /// - T14:30:45.123 → Thh:mm:ss.sss (with milliseconds)
    /// - T14:30:45 → Thh:mm:ss (standard time format)
    /// - T14:30 → Thh:mm (hour and minute only)
    /// All of the above may include time zone indicators like &apos;Z&apos;, &apos;+05:30&apos;, &apos;-08:00&apos;.
    /// Examples of supported timestamps:
    /// - 2023-10-15T14:30:45Z
    /// - 2023-10-15T14:30:45.123+05:30
    /// - 2023-10-15T14:30Z
    /// Unsupported or partially supported formats:
    /// - T143045.123 or T143045 (no colons)
    /// - T14.500 (decimal hours)
    /// - T14 (hour only)
    /// - T14:30.500 (minute fractions)
    /// - T24:00:00 (invalid)
    /// - T23:59:60 (leap second)
    /// </summary>
    [JsonPropertyName("repeatingTimeIntervals")]
    public IList<string>? RepeatingTimeIntervals { get; set; }

    /// <summary>
    /// TimeZone: Time Zone for a schedule.
    /// Supported timezone indicators include:
    /// - &apos;Z&apos; for UTC
    /// - &apos;+00:00&apos;
    /// - &apos;+05:30&apos;
    /// - &apos;-08:00&apos;
    /// Examples:
    /// - 2023-10-15T14:30:45Z
    /// - 2023-10-15T14:30:45.123+05:30
    /// - 2023-10-15T14:30-08:00
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Day of the week</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth
{
    /// <summary>Date: Date of the month</summary>
    [JsonPropertyName("date")]
    public int? Date { get; set; }

    /// <summary>IsLast: Whether Date is last date of month</summary>
    [JsonPropertyName("isLast")]
    public bool? IsLast { get; set; }
}

/// <summary>ScheduleBasedBackupCriteria: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria
{
    /// <summary>
    /// AbsoluteCriteria: it contains absolute values like &quot;AllBackup&quot; / &quot;FirstOfDay&quot; / &quot;FirstOfWeek&quot; / &quot;FirstOfMonth&quot;
    /// and should be part of AbsoluteMarker enum
    /// </summary>
    [JsonPropertyName("absoluteCriteria")]
    public IList<string>? AbsoluteCriteria { get; set; }

    /// <summary>DaysOfMonth: This is day of the month from 1 to 28 other wise last of month</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth>? DaysOfMonth { get; set; }

    /// <summary>DaysOfTheWeek: It should be Sunday/Monday/T..../Saturday</summary>
    [JsonPropertyName("daysOfTheWeek")]
    public IList<string>? DaysOfTheWeek { get; set; }

    /// <summary>MonthsOfYear: It should be January/February/....../December</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>ScheduleTimes: List of schedule times for backup</summary>
    [JsonPropertyName("scheduleTimes")]
    public IList<string>? ScheduleTimes { get; set; }

    /// <summary>WeeksOfTheMonth: It should be First/Second/Third/Fourth/Last</summary>
    [JsonPropertyName("weeksOfTheMonth")]
    public IList<string>? WeeksOfTheMonth { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria
{
    /// <summary>ScheduleBasedBackupCriteria: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("scheduleBasedBackupCriteria")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria? ScheduleBasedBackupCriteria { get; set; }
}

/// <summary>TagInfo: Retention tag information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>ETag: Retention Tag version.</summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>Id: Retention Tag version.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>TagName: Retention Tag Name to relate it to retention rule.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>Tagging criteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria
{
    /// <summary>Criteria: Criteria which decides whether the tag can be applied to a triggered backup.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria>? Criteria { get; set; }

    /// <summary>IsDefault: Specifies if tag is default.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>TagInfo: Retention tag information</summary>
    [JsonPropertyName("tagInfo")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }

    /// <summary>TaggingPriority: Retention Tag priority.</summary>
    [JsonPropertyName("taggingPriority")]
    public int? TaggingPriority { get; set; }
}

/// <summary>Schedule: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Schedule: Schedule for this backup</summary>
    [JsonPropertyName("schedule")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule? Schedule { get; set; }

    /// <summary>TaggingCriteria: List of tags that can be applicable for given schedule.</summary>
    [JsonPropertyName("taggingCriteria")]
    public IList<V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria>? TaggingCriteria { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger
{
    /// <summary>Adhoc: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("adhocBasedTriggerContext")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext? AdhocBasedTriggerContext { get; set; }

    /// <summary>Schedule: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("scheduleBasedTriggerContext")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext? ScheduleBasedTriggerContext { get; set; }
}

/// <summary>AzureBackup: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRule
{
    [JsonPropertyName("backupParameters")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters? BackupParameters { get; set; }

    /// <summary>DataStore: DataStoreInfo base</summary>
    [JsonPropertyName("dataStore")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore? DataStore { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("trigger")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger? Trigger { get; set; }
}

/// <summary>AbsoluteDeleteOption: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption
{
    /// <summary>Duration: Duration of deletion after given timespan</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter
{
    /// <summary>AbsoluteDeleteOption: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("absoluteDeleteOption")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption? AbsoluteDeleteOption { get; set; }
}

/// <summary>SourceDataStore: DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore
{
    /// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>CopyOnExpiry: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>CustomCopy: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption
{
    /// <summary>Duration: Data copied after given timespan</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>ImmediateCopy: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption
{
    /// <summary>ObjectType: Type of the specific object - used for deserializing</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>CopyAfter: It can be CustomCopyOption or ImmediateCopyOption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter
{
    /// <summary>CopyOnExpiry: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("copyOnExpiryOption")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption? CopyOnExpiryOption { get; set; }

    /// <summary>CustomCopy: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("customCopyOption")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption? CustomCopyOption { get; set; }

    /// <summary>ImmediateCopy: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("immediateCopyOption")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption? ImmediateCopyOption { get; set; }
}

/// <summary>DataStore: Info of target datastore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore
{
    /// <summary>DataStoreType: type of datastore; Operational/Vault/Archive</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>ObjectType: Type of Datasource object, used to initialize the right inherited type</summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Target copy settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings
{
    /// <summary>CopyAfter: It can be CustomCopyOption or ImmediateCopyOption.</summary>
    [JsonPropertyName("copyAfter")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter? CopyAfter { get; set; }

    /// <summary>DataStore: Info of target datastore</summary>
    [JsonPropertyName("dataStore")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore? DataStore { get; set; }
}

/// <summary>Source LifeCycle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles
{
    [JsonPropertyName("deleteAfter")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter? DeleteAfter { get; set; }

    /// <summary>SourceDataStore: DataStoreInfo base</summary>
    [JsonPropertyName("sourceDataStore")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore? SourceDataStore { get; set; }

    [JsonPropertyName("targetDataStoreCopySettings")]
    public IList<V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings>? TargetDataStoreCopySettings { get; set; }
}

/// <summary>AzureRetention: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRule
{
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("lifecycles")]
    public IList<V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles>? Lifecycles { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRules
{
    /// <summary>AzureBackup: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureBackupRule")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRule? AzureBackupRule { get; set; }

    /// <summary>AzureRetention: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureRetentionRule")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRule? AzureRetentionRule { get; set; }
}

/// <summary>BackupPolicy: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicy
{
    /// <summary>DatasourceTypes: Type of datasource for the backup management</summary>
    [JsonPropertyName("datasourceTypes")]
    public IList<string>? DatasourceTypes { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>PolicyRules: Policy rule dictionary that contains rules for each backuptype i.e Full/Incremental/Logs etc</summary>
    [JsonPropertyName("policyRules")]
    public IList<V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRules>? PolicyRules { get; set; }
}

/// <summary>Properties: BaseBackupPolicyResource properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusProperties
{
    /// <summary>BackupPolicy: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20231101BackupVaultsBackupPolicyStatusPropertiesBackupPolicy? BackupPolicy { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101BackupVaultsBackupPolicyStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231101BackupVaultsBackupPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Id: Resource Id represents the complete path to the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Resource name associated with the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: BaseBackupPolicyResource properties</summary>
    [JsonPropertyName("properties")]
    public V1api20231101BackupVaultsBackupPolicyStatusProperties? Properties { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231101BackupVaultsBackupPolicyStatusSystemData? SystemData { get; set; }

    /// <summary>Type: Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-11-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101BackupVaultsBackupPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231101BackupVaultsBackupPolicySpec?>, IStatus<V1api20231101BackupVaultsBackupPolicyStatus?>
{
    public const string KubeApiVersion = "v1api20231101";
    public const string KubeKind = "BackupVaultsBackupPolicy";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackuppolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20231101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVaultsBackupPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20231101BackupVaultsBackupPolicySpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20231101BackupVaultsBackupPolicyStatus? Status { get; set; }
}