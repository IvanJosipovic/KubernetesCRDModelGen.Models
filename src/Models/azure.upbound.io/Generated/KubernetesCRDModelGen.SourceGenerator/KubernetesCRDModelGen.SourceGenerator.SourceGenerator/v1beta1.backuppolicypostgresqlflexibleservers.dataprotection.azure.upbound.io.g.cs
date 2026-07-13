#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.upbound.io;
/// <summary>BackupPolicyPostgreSQLFlexibleServer is the Schema for the BackupPolicyPostgreSQLFlexibleServers API. Manages a Backup Policy to back up PostgreSQL Flexible Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BackupPolicyPostgreSQLFlexibleServer>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupPolicyPostgreSQLFlexibleServerList";
    public const string KubeGroup = "dataprotection.azure.upbound.io";
    public const string KubePluralName = "backuppolicypostgresqlflexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupPolicyPostgreSQLFlexibleServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1BackupPolicyPostgreSQLFlexibleServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1BackupPolicyPostgreSQLFlexibleServer> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecDeletionPolicyEnum>))]
public enum V1beta1BackupPolicyPostgreSQLFlexibleServerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderDefaultRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is VaultStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderDefaultRetentionRule
{
    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderDefaultRetentionRuleLifeCycle>? LifeCycle { get; set; }
}

/// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderRetentionRuleCriteria
{
    /// <summary>Possible values are AllBackup, FirstOfDay, FirstOfWeek, FirstOfMonth and FirstOfYear. These values mean the first successful backup of the day/week/month/year. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("absoluteCriteria")]
    public string? AbsoluteCriteria { get; set; }

    /// <summary>Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Possible values are January, February, March, April, May, June, July, August, September, October, November and December. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>Specifies a list of backup times for backup in the RFC3339 format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scheduledBackupTimes")]
    public IList<string>? ScheduledBackupTimes { get; set; }

    /// <summary>Possible values are First, Second, Third, Fourth and Last. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("weeksOfMonth")]
    public IList<string>? WeeksOfMonth { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is VaultStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderRetentionRule
{
    /// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("criteria")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderRetentionRuleCriteria? Criteria { get; set; }

    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderRetentionRuleLifeCycle>? LifeCycle { get; set; }

    /// <summary>Specifies the name of the retention rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The priority number must be unique for each rule. The lower the priority number, the higher the priority of the rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRefPolicyResolutionEnum>))]
public enum V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRefPolicyResolveEnum>))]
public enum V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackupVault in dataprotection to populate vaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelectorPolicyResolutionEnum>))]
public enum V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelectorPolicyResolveEnum>))]
public enum V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackupVault in dataprotection to populate vaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelector
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
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProvider
{
    /// <summary>Specifies a list of repeating time interval. It supports weekly back. It should follow ISO 8601 repeating time interval format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("backupRepeatingTimeIntervals")]
    public IList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultRetentionRule")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderDefaultRetentionRule? DefaultRetentionRule { get; set; }

    /// <summary>One or more retention_rule blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("retentionRule")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderRetentionRule>? RetentionRule { get; set; }

    /// <summary>Specifies the Time Zone which should be used by the backup schedule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>The ID of the Backup Vault where the Backup Policy PostgreSQL Flexible Server should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }

    /// <summary>Reference to a BackupVault in dataprotection to populate vaultId.</summary>
    [JsonPropertyName("vaultIdRef")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdRef? VaultIdRef { get; set; }

    /// <summary>Selector for a BackupVault in dataprotection to populate vaultId.</summary>
    [JsonPropertyName("vaultIdSelector")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProviderVaultIdSelector? VaultIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderDefaultRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is VaultStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderDefaultRetentionRule
{
    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderDefaultRetentionRuleLifeCycle>? LifeCycle { get; set; }
}

/// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderRetentionRuleCriteria
{
    /// <summary>Possible values are AllBackup, FirstOfDay, FirstOfWeek, FirstOfMonth and FirstOfYear. These values mean the first successful backup of the day/week/month/year. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("absoluteCriteria")]
    public string? AbsoluteCriteria { get; set; }

    /// <summary>Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Possible values are January, February, March, April, May, June, July, August, September, October, November and December. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>Specifies a list of backup times for backup in the RFC3339 format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scheduledBackupTimes")]
    public IList<string>? ScheduledBackupTimes { get; set; }

    /// <summary>Possible values are First, Second, Third, Fourth and Last. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("weeksOfMonth")]
    public IList<string>? WeeksOfMonth { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is VaultStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderRetentionRule
{
    /// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("criteria")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderRetentionRuleCriteria? Criteria { get; set; }

    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderRetentionRuleLifeCycle>? LifeCycle { get; set; }

    /// <summary>Specifies the name of the retention rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The priority number must be unique for each rule. The lower the priority number, the higher the priority of the rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
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
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProvider
{
    /// <summary>Specifies a list of repeating time interval. It supports weekly back. It should follow ISO 8601 repeating time interval format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("backupRepeatingTimeIntervals")]
    public IList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultRetentionRule")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderDefaultRetentionRule? DefaultRetentionRule { get; set; }

    /// <summary>One or more retention_rule blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("retentionRule")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProviderRetentionRule>? RetentionRule { get; set; }

    /// <summary>Specifies the Time Zone which should be used by the backup schedule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecManagementPoliciesEnum>))]
public enum V1beta1BackupPolicyPostgreSQLFlexibleServerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>BackupPolicyPostgreSQLFlexibleServerSpec defines the desired state of BackupPolicyPostgreSQLFlexibleServer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerSpec
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
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1BackupPolicyPostgreSQLFlexibleServerSpecForProvider ForProvider { get; set; }

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
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderDefaultRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is VaultStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderDefaultRetentionRule
{
    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderDefaultRetentionRuleLifeCycle>? LifeCycle { get; set; }
}

/// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderRetentionRuleCriteria
{
    /// <summary>Possible values are AllBackup, FirstOfDay, FirstOfWeek, FirstOfMonth and FirstOfYear. These values mean the first successful backup of the day/week/month/year. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("absoluteCriteria")]
    public string? AbsoluteCriteria { get; set; }

    /// <summary>Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Possible values are January, February, March, April, May, June, July, August, September, October, November and December. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>Specifies a list of backup times for backup in the RFC3339 format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scheduledBackupTimes")]
    public IList<string>? ScheduledBackupTimes { get; set; }

    /// <summary>Possible values are First, Second, Third, Fourth and Last. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("weeksOfMonth")]
    public IList<string>? WeeksOfMonth { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is VaultStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderRetentionRule
{
    /// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("criteria")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderRetentionRuleCriteria? Criteria { get; set; }

    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderRetentionRuleLifeCycle>? LifeCycle { get; set; }

    /// <summary>Specifies the name of the retention rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The priority number must be unique for each rule. The lower the priority number, the higher the priority of the rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProvider
{
    /// <summary>Specifies a list of repeating time interval. It supports weekly back. It should follow ISO 8601 repeating time interval format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("backupRepeatingTimeIntervals")]
    public IList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultRetentionRule")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderDefaultRetentionRule? DefaultRetentionRule { get; set; }

    /// <summary>The ID of the Backup Policy PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more retention_rule blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("retentionRule")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProviderRetentionRule>? RetentionRule { get; set; }

    /// <summary>Specifies the Time Zone which should be used by the backup schedule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>The ID of the Backup Vault where the Backup Policy PostgreSQL Flexible Server should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerStatusConditions
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

/// <summary>BackupPolicyPostgreSQLFlexibleServerStatus defines the observed state of BackupPolicyPostgreSQLFlexibleServer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackupPolicyPostgreSQLFlexibleServerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BackupPolicyPostgreSQLFlexibleServer is the Schema for the BackupPolicyPostgreSQLFlexibleServers API. Manages a Backup Policy to back up PostgreSQL Flexible Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupPolicyPostgreSQLFlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackupPolicyPostgreSQLFlexibleServerSpec>, IStatus<V1beta1BackupPolicyPostgreSQLFlexibleServerStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupPolicyPostgreSQLFlexibleServer";
    public const string KubeGroup = "dataprotection.azure.upbound.io";
    public const string KubePluralName = "backuppolicypostgresqlflexibleservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupPolicyPostgreSQLFlexibleServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupPolicyPostgreSQLFlexibleServerSpec defines the desired state of BackupPolicyPostgreSQLFlexibleServer</summary>
    [JsonPropertyName("spec")]
    public required V1beta1BackupPolicyPostgreSQLFlexibleServerSpec Spec { get; set; }

    /// <summary>BackupPolicyPostgreSQLFlexibleServerStatus defines the observed state of BackupPolicyPostgreSQLFlexibleServer.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackupPolicyPostgreSQLFlexibleServerStatus? Status { get; set; }
}