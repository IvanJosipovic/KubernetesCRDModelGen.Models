#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backup.aws.upbound.io;
/// <summary>Plan is the Schema for the Plans API. Provides an AWS Backup plan resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PlanList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Plan>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PlanList";
    public const string KubeGroup = "backup.aws.upbound.io";
    public const string KubePluralName = "plans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "backup.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PlanList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Plan objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Plan> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecDeletionPolicyEnum>))]
public enum V1beta2PlanSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderAdvancedBackupSetting
{
    /// <summary>Specifies the backup option for a selected resource. This option is only available for Windows VSS backup jobs. Set to { WindowsVSS = &quot;enabled&quot; } to enable Windows VSS backup option and create a VSS Windows backup.</summary>
    [JsonPropertyName("backupOptions")]
    public IDictionary<string, string>? BackupOptions { get; set; }

    /// <summary>The type of AWS resource to be backed up. For VSS Windows backups, the only supported resource type is Amazon EC2. Valid values: EC2.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderRuleCopyActionLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderRuleCopyAction
{
    /// <summary>An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault for the copied backup.</summary>
    [JsonPropertyName("destinationVaultArn")]
    public string? DestinationVaultArn { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public V1beta2PlanSpecForProviderRuleCopyActionLifecycle? Lifecycle { get; set; }
}

/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderRuleLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderRuleScanAction
{
    /// <summary>Malware scanner to use for the scan action. Currently only GUARDDUTY is supported.</summary>
    [JsonPropertyName("malwareScanner")]
    public string? MalwareScanner { get; set; }

    /// <summary>Scanning mode to use for the scan action. Valid values are FULL_SCAN and INCREMENTAL_SCAN.</summary>
    [JsonPropertyName("scanMode")]
    public string? ScanMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecForProviderRuleTargetVaultNameRefPolicyResolutionEnum>))]
public enum V1beta2PlanSpecForProviderRuleTargetVaultNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecForProviderRuleTargetVaultNameRefPolicyResolveEnum>))]
public enum V1beta2PlanSpecForProviderRuleTargetVaultNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderRuleTargetVaultNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PlanSpecForProviderRuleTargetVaultNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PlanSpecForProviderRuleTargetVaultNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderRuleTargetVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PlanSpecForProviderRuleTargetVaultNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolutionEnum>))]
public enum V1beta2PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolveEnum>))]
public enum V1beta2PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderRuleTargetVaultNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderRuleTargetVaultNameSelector
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
    public V1beta2PlanSpecForProviderRuleTargetVaultNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderRule
{
    /// <summary>The amount of time in minutes AWS Backup attempts a backup before canceling the job and returning an error.</summary>
    [JsonPropertyName("completionWindow")]
    public double? CompletionWindow { get; set; }

    /// <summary>Configuration block(s) with copy operation settings. Detailed below.</summary>
    [JsonPropertyName("copyAction")]
    public IList<V1beta2PlanSpecForProviderRuleCopyAction>? CopyAction { get; set; }

    /// <summary>Enable continuous backups for supported resources.</summary>
    [JsonPropertyName("enableContinuousBackup")]
    public bool? EnableContinuousBackup { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public V1beta2PlanSpecForProviderRuleLifecycle? Lifecycle { get; set; }

    /// <summary>Metadata that you can assign to help organize the resources that you create.</summary>
    [JsonPropertyName("recoveryPointTags")]
    public IDictionary<string, string>? RecoveryPointTags { get; set; }

    /// <summary>An display name for a backup rule.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>Block for scanning configuration for the backup rule and includes the malware scanner, and scan mode of either full or incremental.</summary>
    [JsonPropertyName("scanAction")]
    public IList<V1beta2PlanSpecForProviderRuleScanAction>? ScanAction { get; set; }

    /// <summary>A CRON expression specifying when AWS Backup initiates a backup job.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The timezone in which the schedule expression is set. Default value: &quot;Etc/UTC&quot;.</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The amount of time in minutes before beginning a backup.</summary>
    [JsonPropertyName("startWindow")]
    public double? StartWindow { get; set; }

    /// <summary>The ARN of a logically air-gapped vault. ARN must be in the same account and region. If provided, supported fully managed resources back up directly to logically air-gapped vault, while other supported resources create a temporary (billable) snapshot in backup vault, then copy it to logically air-gapped vault. Unsupported resources only back up to the specified backup vault.</summary>
    [JsonPropertyName("targetLogicallyAirGappedBackupVaultArn")]
    public string? TargetLogicallyAirGappedBackupVaultArn { get; set; }

    /// <summary>The name of a logical container where backups are stored.</summary>
    [JsonPropertyName("targetVaultName")]
    public string? TargetVaultName { get; set; }

    /// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
    [JsonPropertyName("targetVaultNameRef")]
    public V1beta2PlanSpecForProviderRuleTargetVaultNameRef? TargetVaultNameRef { get; set; }

    /// <summary>Selector for a Vault in backup to populate targetVaultName.</summary>
    [JsonPropertyName("targetVaultNameSelector")]
    public V1beta2PlanSpecForProviderRuleTargetVaultNameSelector? TargetVaultNameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProviderScanSetting
{
    /// <summary>Malware scanner to use for the scan action. Currently only GUARDDUTY is supported.</summary>
    [JsonPropertyName("malwareScanner")]
    public string? MalwareScanner { get; set; }

    /// <summary>List of resource types to apply the scan setting to. Valid values are EBS, EC2, S3 and ALL.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>ARN of the IAM role that AWS Backup uses to scan resources. See the AWS documentation for details.</summary>
    [JsonPropertyName("scannerRoleArn")]
    public string? ScannerRoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecForProvider
{
    /// <summary>An object that specifies backup options for each resource type.</summary>
    [JsonPropertyName("advancedBackupSetting")]
    public IList<V1beta2PlanSpecForProviderAdvancedBackupSetting>? AdvancedBackupSetting { get; set; }

    /// <summary>The display name of a backup plan.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>A rule object that specifies a scheduled task that is used to back up a selection of resources.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2PlanSpecForProviderRule>? Rule { get; set; }

    /// <summary>Block for scanning configuration for the backup rule and includes the malware scanner, and scan mode of either full or incremental. Detailed below.</summary>
    [JsonPropertyName("scanSetting")]
    public IList<V1beta2PlanSpecForProviderScanSetting>? ScanSetting { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderAdvancedBackupSetting
{
    /// <summary>Specifies the backup option for a selected resource. This option is only available for Windows VSS backup jobs. Set to { WindowsVSS = &quot;enabled&quot; } to enable Windows VSS backup option and create a VSS Windows backup.</summary>
    [JsonPropertyName("backupOptions")]
    public IDictionary<string, string>? BackupOptions { get; set; }

    /// <summary>The type of AWS resource to be backed up. For VSS Windows backups, the only supported resource type is Amazon EC2. Valid values: EC2.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderRuleCopyActionLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderRuleCopyAction
{
    /// <summary>An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault for the copied backup.</summary>
    [JsonPropertyName("destinationVaultArn")]
    public string? DestinationVaultArn { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public V1beta2PlanSpecInitProviderRuleCopyActionLifecycle? Lifecycle { get; set; }
}

/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderRuleLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderRuleScanAction
{
    /// <summary>Malware scanner to use for the scan action. Currently only GUARDDUTY is supported.</summary>
    [JsonPropertyName("malwareScanner")]
    public string? MalwareScanner { get; set; }

    /// <summary>Scanning mode to use for the scan action. Valid values are FULL_SCAN and INCREMENTAL_SCAN.</summary>
    [JsonPropertyName("scanMode")]
    public string? ScanMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolutionEnum>))]
public enum V1beta2PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolveEnum>))]
public enum V1beta2PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderRuleTargetVaultNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderRuleTargetVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PlanSpecInitProviderRuleTargetVaultNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolutionEnum>))]
public enum V1beta2PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolveEnum>))]
public enum V1beta2PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderRuleTargetVaultNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderRuleTargetVaultNameSelector
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
    public V1beta2PlanSpecInitProviderRuleTargetVaultNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderRule
{
    /// <summary>The amount of time in minutes AWS Backup attempts a backup before canceling the job and returning an error.</summary>
    [JsonPropertyName("completionWindow")]
    public double? CompletionWindow { get; set; }

    /// <summary>Configuration block(s) with copy operation settings. Detailed below.</summary>
    [JsonPropertyName("copyAction")]
    public IList<V1beta2PlanSpecInitProviderRuleCopyAction>? CopyAction { get; set; }

    /// <summary>Enable continuous backups for supported resources.</summary>
    [JsonPropertyName("enableContinuousBackup")]
    public bool? EnableContinuousBackup { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public V1beta2PlanSpecInitProviderRuleLifecycle? Lifecycle { get; set; }

    /// <summary>Metadata that you can assign to help organize the resources that you create.</summary>
    [JsonPropertyName("recoveryPointTags")]
    public IDictionary<string, string>? RecoveryPointTags { get; set; }

    /// <summary>An display name for a backup rule.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>Block for scanning configuration for the backup rule and includes the malware scanner, and scan mode of either full or incremental.</summary>
    [JsonPropertyName("scanAction")]
    public IList<V1beta2PlanSpecInitProviderRuleScanAction>? ScanAction { get; set; }

    /// <summary>A CRON expression specifying when AWS Backup initiates a backup job.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The timezone in which the schedule expression is set. Default value: &quot;Etc/UTC&quot;.</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The amount of time in minutes before beginning a backup.</summary>
    [JsonPropertyName("startWindow")]
    public double? StartWindow { get; set; }

    /// <summary>The ARN of a logically air-gapped vault. ARN must be in the same account and region. If provided, supported fully managed resources back up directly to logically air-gapped vault, while other supported resources create a temporary (billable) snapshot in backup vault, then copy it to logically air-gapped vault. Unsupported resources only back up to the specified backup vault.</summary>
    [JsonPropertyName("targetLogicallyAirGappedBackupVaultArn")]
    public string? TargetLogicallyAirGappedBackupVaultArn { get; set; }

    /// <summary>The name of a logical container where backups are stored.</summary>
    [JsonPropertyName("targetVaultName")]
    public string? TargetVaultName { get; set; }

    /// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
    [JsonPropertyName("targetVaultNameRef")]
    public V1beta2PlanSpecInitProviderRuleTargetVaultNameRef? TargetVaultNameRef { get; set; }

    /// <summary>Selector for a Vault in backup to populate targetVaultName.</summary>
    [JsonPropertyName("targetVaultNameSelector")]
    public V1beta2PlanSpecInitProviderRuleTargetVaultNameSelector? TargetVaultNameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecInitProviderScanSetting
{
    /// <summary>Malware scanner to use for the scan action. Currently only GUARDDUTY is supported.</summary>
    [JsonPropertyName("malwareScanner")]
    public string? MalwareScanner { get; set; }

    /// <summary>List of resource types to apply the scan setting to. Valid values are EBS, EC2, S3 and ALL.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>ARN of the IAM role that AWS Backup uses to scan resources. See the AWS documentation for details.</summary>
    [JsonPropertyName("scannerRoleArn")]
    public string? ScannerRoleArn { get; set; }
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
public partial class V1beta2PlanSpecInitProvider
{
    /// <summary>An object that specifies backup options for each resource type.</summary>
    [JsonPropertyName("advancedBackupSetting")]
    public IList<V1beta2PlanSpecInitProviderAdvancedBackupSetting>? AdvancedBackupSetting { get; set; }

    /// <summary>The display name of a backup plan.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A rule object that specifies a scheduled task that is used to back up a selection of resources.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2PlanSpecInitProviderRule>? Rule { get; set; }

    /// <summary>Block for scanning configuration for the backup rule and includes the malware scanner, and scan mode of either full or incremental. Detailed below.</summary>
    [JsonPropertyName("scanSetting")]
    public IList<V1beta2PlanSpecInitProviderScanSetting>? ScanSetting { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecManagementPoliciesEnum>))]
public enum V1beta2PlanSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2PlanSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PlanSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2PlanSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PlanSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PlanSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PlanSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PlanSpec defines the desired state of Plan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanSpec
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
    public V1beta2PlanSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2PlanSpecForProvider ForProvider { get; set; }

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
    public V1beta2PlanSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2PlanSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2PlanSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2PlanSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatusAtProviderAdvancedBackupSetting
{
    /// <summary>Specifies the backup option for a selected resource. This option is only available for Windows VSS backup jobs. Set to { WindowsVSS = &quot;enabled&quot; } to enable Windows VSS backup option and create a VSS Windows backup.</summary>
    [JsonPropertyName("backupOptions")]
    public IDictionary<string, string>? BackupOptions { get; set; }

    /// <summary>The type of AWS resource to be backed up. For VSS Windows backups, the only supported resource type is Amazon EC2. Valid values: EC2.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatusAtProviderRuleCopyActionLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatusAtProviderRuleCopyAction
{
    /// <summary>An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault for the copied backup.</summary>
    [JsonPropertyName("destinationVaultArn")]
    public string? DestinationVaultArn { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public V1beta2PlanStatusAtProviderRuleCopyActionLifecycle? Lifecycle { get; set; }
}

/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatusAtProviderRuleLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatusAtProviderRuleScanAction
{
    /// <summary>Malware scanner to use for the scan action. Currently only GUARDDUTY is supported.</summary>
    [JsonPropertyName("malwareScanner")]
    public string? MalwareScanner { get; set; }

    /// <summary>Scanning mode to use for the scan action. Valid values are FULL_SCAN and INCREMENTAL_SCAN.</summary>
    [JsonPropertyName("scanMode")]
    public string? ScanMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatusAtProviderRule
{
    /// <summary>The amount of time in minutes AWS Backup attempts a backup before canceling the job and returning an error.</summary>
    [JsonPropertyName("completionWindow")]
    public double? CompletionWindow { get; set; }

    /// <summary>Configuration block(s) with copy operation settings. Detailed below.</summary>
    [JsonPropertyName("copyAction")]
    public IList<V1beta2PlanStatusAtProviderRuleCopyAction>? CopyAction { get; set; }

    /// <summary>Enable continuous backups for supported resources.</summary>
    [JsonPropertyName("enableContinuousBackup")]
    public bool? EnableContinuousBackup { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public V1beta2PlanStatusAtProviderRuleLifecycle? Lifecycle { get; set; }

    /// <summary>Metadata that you can assign to help organize the resources that you create.</summary>
    [JsonPropertyName("recoveryPointTags")]
    public IDictionary<string, string>? RecoveryPointTags { get; set; }

    /// <summary>An display name for a backup rule.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>Block for scanning configuration for the backup rule and includes the malware scanner, and scan mode of either full or incremental.</summary>
    [JsonPropertyName("scanAction")]
    public IList<V1beta2PlanStatusAtProviderRuleScanAction>? ScanAction { get; set; }

    /// <summary>A CRON expression specifying when AWS Backup initiates a backup job.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The timezone in which the schedule expression is set. Default value: &quot;Etc/UTC&quot;.</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The amount of time in minutes before beginning a backup.</summary>
    [JsonPropertyName("startWindow")]
    public double? StartWindow { get; set; }

    /// <summary>The ARN of a logically air-gapped vault. ARN must be in the same account and region. If provided, supported fully managed resources back up directly to logically air-gapped vault, while other supported resources create a temporary (billable) snapshot in backup vault, then copy it to logically air-gapped vault. Unsupported resources only back up to the specified backup vault.</summary>
    [JsonPropertyName("targetLogicallyAirGappedBackupVaultArn")]
    public string? TargetLogicallyAirGappedBackupVaultArn { get; set; }

    /// <summary>The name of a logical container where backups are stored.</summary>
    [JsonPropertyName("targetVaultName")]
    public string? TargetVaultName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatusAtProviderScanSetting
{
    /// <summary>Malware scanner to use for the scan action. Currently only GUARDDUTY is supported.</summary>
    [JsonPropertyName("malwareScanner")]
    public string? MalwareScanner { get; set; }

    /// <summary>List of resource types to apply the scan setting to. Valid values are EBS, EC2, S3 and ALL.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>ARN of the IAM role that AWS Backup uses to scan resources. See the AWS documentation for details.</summary>
    [JsonPropertyName("scannerRoleArn")]
    public string? ScannerRoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatusAtProvider
{
    /// <summary>An object that specifies backup options for each resource type.</summary>
    [JsonPropertyName("advancedBackupSetting")]
    public IList<V1beta2PlanStatusAtProviderAdvancedBackupSetting>? AdvancedBackupSetting { get; set; }

    /// <summary>The ARN of the backup plan.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The id of the backup plan.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The display name of a backup plan.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A rule object that specifies a scheduled task that is used to back up a selection of resources.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2PlanStatusAtProviderRule>? Rule { get; set; }

    /// <summary>Block for scanning configuration for the backup rule and includes the malware scanner, and scan mode of either full or incremental. Detailed below.</summary>
    [JsonPropertyName("scanSetting")]
    public IList<V1beta2PlanStatusAtProviderScanSetting>? ScanSetting { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Unique, randomly generated, Unicode, UTF-8 encoded string that serves as the version ID of the backup plan.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatusConditions
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

/// <summary>PlanStatus defines the observed state of Plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PlanStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2PlanStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2PlanStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Plan is the Schema for the Plans API. Provides an AWS Backup plan resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Plan : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2PlanSpec>, IStatus<V1beta2PlanStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Plan";
    public const string KubeGroup = "backup.aws.upbound.io";
    public const string KubePluralName = "plans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "backup.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Plan";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PlanSpec defines the desired state of Plan</summary>
    [JsonPropertyName("spec")]
    public required V1beta2PlanSpec Spec { get; set; }

    /// <summary>PlanStatus defines the observed state of Plan.</summary>
    [JsonPropertyName("status")]
    public V1beta2PlanStatus? Status { get; set; }
}