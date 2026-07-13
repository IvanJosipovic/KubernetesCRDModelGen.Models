#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.recoveryservices.azure.upbound.io;
/// <summary>BackupPolicyFileShare is the Schema for the BackupPolicyFileShares API. Manages an Azure File Share Backup Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupPolicyFileShareList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BackupPolicyFileShare>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupPolicyFileShareList";
    public const string KubeGroup = "recoveryservices.azure.upbound.io";
    public const string KubePluralName = "backuppolicyfileshares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "recoveryservices.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupPolicyFileShareList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BackupPolicyFileShare objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BackupPolicyFileShare> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecDeletionPolicyEnum>))]
public enum V1beta2BackupPolicyFileShareSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A hourly block defined as below. This is required when frequency is set to Hourly.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderBackupHourly
{
    /// <summary>Specifies the interval at which backup needs to be triggered. Possible values are 4, 6, 8 and 12.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Specifies the start time of the hourly backup. The time format should be in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Species the duration of the backup window in hours. Details could be found here.</summary>
    [JsonPropertyName("windowDuration")]
    public double? WindowDuration { get; set; }
}

/// <summary>Configures the Policy backup frequency and times as documented in the backup block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderBackup
{
    /// <summary>Sets the backup frequency. Possible values are Daily and Hourly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>A hourly block defined as below. This is required when frequency is set to Hourly.</summary>
    [JsonPropertyName("hourly")]
    public V1beta2BackupPolicyFileShareSpecForProviderBackupHourly? Hourly { get; set; }

    /// <summary>The time of day to perform the backup in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.)</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolveEnum>))]
public enum V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolveEnum>))]
public enum V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelector
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
    public V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelector
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
    public V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configures the policy daily retention as documented in the retention_daily block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderRetentionDaily
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderRetentionMonthly
{
    /// <summary>The number of monthly backups to keep. Must be between 1 and 120</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>Configures the policy weekly retention as documented in the retention_weekly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderRetentionWeekly
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProviderRetentionYearly
{
    /// <summary>The number of yearly backups to keep. Must be between 1 and 10</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The months of the year to retain backups of. Must be one of January, February, March, April, May, June, July, Augest, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecForProvider
{
    /// <summary>Configures the Policy backup frequency and times as documented in the backup block below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2BackupPolicyFileShareSpecForProviderBackup? Backup { get; set; }

    /// <summary>Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameRef")]
    public V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameRef? RecoveryVaultNameRef { get; set; }

    /// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameSelector")]
    public V1beta2BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelector? RecoveryVaultNameSelector { get; set; }

    /// <summary>The name of the resource group in which to create the policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2BackupPolicyFileShareSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Configures the policy daily retention as documented in the retention_daily block below.</summary>
    [JsonPropertyName("retentionDaily")]
    public V1beta2BackupPolicyFileShareSpecForProviderRetentionDaily? RetentionDaily { get; set; }

    /// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public V1beta2BackupPolicyFileShareSpecForProviderRetentionMonthly? RetentionMonthly { get; set; }

    /// <summary>Configures the policy weekly retention as documented in the retention_weekly block below.</summary>
    [JsonPropertyName("retentionWeekly")]
    public V1beta2BackupPolicyFileShareSpecForProviderRetentionWeekly? RetentionWeekly { get; set; }

    /// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
    [JsonPropertyName("retentionYearly")]
    public V1beta2BackupPolicyFileShareSpecForProviderRetentionYearly? RetentionYearly { get; set; }

    /// <summary>Specifies the timezone. the possible values are defined here. Defaults to UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A hourly block defined as below. This is required when frequency is set to Hourly.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecInitProviderBackupHourly
{
    /// <summary>Specifies the interval at which backup needs to be triggered. Possible values are 4, 6, 8 and 12.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Specifies the start time of the hourly backup. The time format should be in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Species the duration of the backup window in hours. Details could be found here.</summary>
    [JsonPropertyName("windowDuration")]
    public double? WindowDuration { get; set; }
}

/// <summary>Configures the Policy backup frequency and times as documented in the backup block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecInitProviderBackup
{
    /// <summary>Sets the backup frequency. Possible values are Daily and Hourly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>A hourly block defined as below. This is required when frequency is set to Hourly.</summary>
    [JsonPropertyName("hourly")]
    public V1beta2BackupPolicyFileShareSpecInitProviderBackupHourly? Hourly { get; set; }

    /// <summary>The time of day to perform the backup in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.)</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Configures the policy daily retention as documented in the retention_daily block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecInitProviderRetentionDaily
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecInitProviderRetentionMonthly
{
    /// <summary>The number of monthly backups to keep. Must be between 1 and 120</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>Configures the policy weekly retention as documented in the retention_weekly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecInitProviderRetentionWeekly
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecInitProviderRetentionYearly
{
    /// <summary>The number of yearly backups to keep. Must be between 1 and 10</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The months of the year to retain backups of. Must be one of January, February, March, April, May, June, July, Augest, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecInitProvider
{
    /// <summary>Configures the Policy backup frequency and times as documented in the backup block below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2BackupPolicyFileShareSpecInitProviderBackup? Backup { get; set; }

    /// <summary>Configures the policy daily retention as documented in the retention_daily block below.</summary>
    [JsonPropertyName("retentionDaily")]
    public V1beta2BackupPolicyFileShareSpecInitProviderRetentionDaily? RetentionDaily { get; set; }

    /// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public V1beta2BackupPolicyFileShareSpecInitProviderRetentionMonthly? RetentionMonthly { get; set; }

    /// <summary>Configures the policy weekly retention as documented in the retention_weekly block below.</summary>
    [JsonPropertyName("retentionWeekly")]
    public V1beta2BackupPolicyFileShareSpecInitProviderRetentionWeekly? RetentionWeekly { get; set; }

    /// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
    [JsonPropertyName("retentionYearly")]
    public V1beta2BackupPolicyFileShareSpecInitProviderRetentionYearly? RetentionYearly { get; set; }

    /// <summary>Specifies the timezone. the possible values are defined here. Defaults to UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecManagementPoliciesEnum>))]
public enum V1beta2BackupPolicyFileShareSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyFileShareSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyFileShareSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2BackupPolicyFileShareSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyFileShareSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyFileShareSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackupPolicyFileShareSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>BackupPolicyFileShareSpec defines the desired state of BackupPolicyFileShare</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareSpec
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
    public V1beta2BackupPolicyFileShareSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2BackupPolicyFileShareSpecForProvider ForProvider { get; set; }

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
    public V1beta2BackupPolicyFileShareSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2BackupPolicyFileShareSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2BackupPolicyFileShareSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2BackupPolicyFileShareSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A hourly block defined as below. This is required when frequency is set to Hourly.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareStatusAtProviderBackupHourly
{
    /// <summary>Specifies the interval at which backup needs to be triggered. Possible values are 4, 6, 8 and 12.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Specifies the start time of the hourly backup. The time format should be in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Species the duration of the backup window in hours. Details could be found here.</summary>
    [JsonPropertyName("windowDuration")]
    public double? WindowDuration { get; set; }
}

/// <summary>Configures the Policy backup frequency and times as documented in the backup block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareStatusAtProviderBackup
{
    /// <summary>Sets the backup frequency. Possible values are Daily and Hourly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>A hourly block defined as below. This is required when frequency is set to Hourly.</summary>
    [JsonPropertyName("hourly")]
    public V1beta2BackupPolicyFileShareStatusAtProviderBackupHourly? Hourly { get; set; }

    /// <summary>The time of day to perform the backup in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.)</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Configures the policy daily retention as documented in the retention_daily block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareStatusAtProviderRetentionDaily
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareStatusAtProviderRetentionMonthly
{
    /// <summary>The number of monthly backups to keep. Must be between 1 and 120</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>Configures the policy weekly retention as documented in the retention_weekly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareStatusAtProviderRetentionWeekly
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareStatusAtProviderRetentionYearly
{
    /// <summary>The number of yearly backups to keep. Must be between 1 and 10</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The months of the year to retain backups of. Must be one of January, February, March, April, May, June, July, Augest, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareStatusAtProvider
{
    /// <summary>Configures the Policy backup frequency and times as documented in the backup block below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2BackupPolicyFileShareStatusAtProviderBackup? Backup { get; set; }

    /// <summary>The ID of the Azure File Share Backup Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>The name of the resource group in which to create the policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Configures the policy daily retention as documented in the retention_daily block below.</summary>
    [JsonPropertyName("retentionDaily")]
    public V1beta2BackupPolicyFileShareStatusAtProviderRetentionDaily? RetentionDaily { get; set; }

    /// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public V1beta2BackupPolicyFileShareStatusAtProviderRetentionMonthly? RetentionMonthly { get; set; }

    /// <summary>Configures the policy weekly retention as documented in the retention_weekly block below.</summary>
    [JsonPropertyName("retentionWeekly")]
    public V1beta2BackupPolicyFileShareStatusAtProviderRetentionWeekly? RetentionWeekly { get; set; }

    /// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
    [JsonPropertyName("retentionYearly")]
    public V1beta2BackupPolicyFileShareStatusAtProviderRetentionYearly? RetentionYearly { get; set; }

    /// <summary>Specifies the timezone. the possible values are defined here. Defaults to UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareStatusConditions
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

/// <summary>BackupPolicyFileShareStatus defines the observed state of BackupPolicyFileShare.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyFileShareStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2BackupPolicyFileShareStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BackupPolicyFileShareStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BackupPolicyFileShare is the Schema for the BackupPolicyFileShares API. Manages an Azure File Share Backup Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupPolicyFileShare : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackupPolicyFileShareSpec>, IStatus<V1beta2BackupPolicyFileShareStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupPolicyFileShare";
    public const string KubeGroup = "recoveryservices.azure.upbound.io";
    public const string KubePluralName = "backuppolicyfileshares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "recoveryservices.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupPolicyFileShare";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupPolicyFileShareSpec defines the desired state of BackupPolicyFileShare</summary>
    [JsonPropertyName("spec")]
    public required V1beta2BackupPolicyFileShareSpec Spec { get; set; }

    /// <summary>BackupPolicyFileShareStatus defines the observed state of BackupPolicyFileShare.</summary>
    [JsonPropertyName("status")]
    public V1beta2BackupPolicyFileShareStatus? Status { get; set; }
}