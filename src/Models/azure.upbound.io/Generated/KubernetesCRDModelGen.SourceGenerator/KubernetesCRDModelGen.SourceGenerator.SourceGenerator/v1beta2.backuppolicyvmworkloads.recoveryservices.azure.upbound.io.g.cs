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
/// <summary>BackupPolicyVMWorkload is the Schema for the BackupPolicyVMWorkloads API. Manages an Azure VM Workload Backup Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupPolicyVMWorkloadList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BackupPolicyVMWorkload>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupPolicyVMWorkloadList";
    public const string KubeGroup = "recoveryservices.azure.upbound.io";
    public const string KubePluralName = "backuppolicyvmworkloads";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "recoveryservices.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupPolicyVMWorkloadList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BackupPolicyVMWorkload objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BackupPolicyVMWorkload> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecDeletionPolicyEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A backup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyBackup
{
    /// <summary>The backup frequency for the VM Workload Backup Policy. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The backup frequency in minutes for the VM Workload Backup Policy. Possible values are 15, 30, 60, 120, 240, 480, 720 and 1440.</summary>
    [JsonPropertyName("frequencyInMinutes")]
    public double? FrequencyInMinutes { get; set; }

    /// <summary>The time of day to perform the backup in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>A retention_daily block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyRetentionDaily
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>A retention_monthly block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyRetentionMonthly
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The retention schedule format type for yearly retention policy. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("formatType")]
    public string? FormatType { get; set; }

    /// <summary>The monthday backups to retain. Possible values are between 0 and 28.</summary>
    [JsonPropertyName("monthdays")]
    public IList<double>? Monthdays { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Possible values are First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>A retention_weekly block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyRetentionWeekly
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>A retention_yearly block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyRetentionYearly
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The retention schedule format type for yearly retention policy. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("formatType")]
    public string? FormatType { get; set; }

    /// <summary>The monthday backups to retain. Possible values are between 0 and 28.</summary>
    [JsonPropertyName("monthdays")]
    public IList<double>? Monthdays { get; set; }

    /// <summary>The months of the year to retain backups of. Possible values are January, February, March, April, May, June, July, August, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Possible values are First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>A simple_retention block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicySimpleRetention
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicy
{
    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyBackup? Backup { get; set; }

    /// <summary>The type of the VM Workload Backup Policy. Possible values are Differential, Full, Incremental and Log.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>A retention_daily block as defined below.</summary>
    [JsonPropertyName("retentionDaily")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyRetentionDaily? RetentionDaily { get; set; }

    /// <summary>A retention_monthly block as defined below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyRetentionMonthly? RetentionMonthly { get; set; }

    /// <summary>A retention_weekly block as defined below.</summary>
    [JsonPropertyName("retentionWeekly")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyRetentionWeekly? RetentionWeekly { get; set; }

    /// <summary>A retention_yearly block as defined below.</summary>
    [JsonPropertyName("retentionYearly")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicyRetentionYearly? RetentionYearly { get; set; }

    /// <summary>A simple_retention block as defined below.</summary>
    [JsonPropertyName("simpleRetention")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicySimpleRetention? SimpleRetention { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRefPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRefPolicyResolveEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelectorPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelectorPolicyResolveEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelector
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
    public V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelector
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
    public V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProviderSettings
{
    /// <summary>The compression setting for the VM Workload Backup Policy. Defaults to false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>The timezone for the VM Workload Backup Policy. The possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecForProvider
{
    /// <summary>One or more protection_policy blocks as defined below.</summary>
    [JsonPropertyName("protectionPolicy")]
    public IList<V1beta2BackupPolicyVMWorkloadSpecForProviderProtectionPolicy>? ProtectionPolicy { get; set; }

    /// <summary>The name of the Recovery Services Vault to use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameRef")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameRef? RecoveryVaultNameRef { get; set; }

    /// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameSelector")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderRecoveryVaultNameSelector? RecoveryVaultNameSelector { get; set; }

    /// <summary>The name of the resource group in which to create the VM Workload Backup Policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A settings block as defined below.</summary>
    [JsonPropertyName("settings")]
    public V1beta2BackupPolicyVMWorkloadSpecForProviderSettings? Settings { get; set; }

    /// <summary>The VM Workload type for the Backup Policy. Possible values are SQLDataBase and SAPHanaDatabase. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary>A backup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyBackup
{
    /// <summary>The backup frequency for the VM Workload Backup Policy. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The backup frequency in minutes for the VM Workload Backup Policy. Possible values are 15, 30, 60, 120, 240, 480, 720 and 1440.</summary>
    [JsonPropertyName("frequencyInMinutes")]
    public double? FrequencyInMinutes { get; set; }

    /// <summary>The time of day to perform the backup in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>A retention_daily block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyRetentionDaily
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>A retention_monthly block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyRetentionMonthly
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The retention schedule format type for yearly retention policy. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("formatType")]
    public string? FormatType { get; set; }

    /// <summary>The monthday backups to retain. Possible values are between 0 and 28.</summary>
    [JsonPropertyName("monthdays")]
    public IList<double>? Monthdays { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Possible values are First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>A retention_weekly block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyRetentionWeekly
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>A retention_yearly block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyRetentionYearly
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The retention schedule format type for yearly retention policy. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("formatType")]
    public string? FormatType { get; set; }

    /// <summary>The monthday backups to retain. Possible values are between 0 and 28.</summary>
    [JsonPropertyName("monthdays")]
    public IList<double>? Monthdays { get; set; }

    /// <summary>The months of the year to retain backups of. Possible values are January, February, March, April, May, June, July, August, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Possible values are First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>A simple_retention block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicySimpleRetention
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicy
{
    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyBackup? Backup { get; set; }

    /// <summary>The type of the VM Workload Backup Policy. Possible values are Differential, Full, Incremental and Log.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>A retention_daily block as defined below.</summary>
    [JsonPropertyName("retentionDaily")]
    public V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyRetentionDaily? RetentionDaily { get; set; }

    /// <summary>A retention_monthly block as defined below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyRetentionMonthly? RetentionMonthly { get; set; }

    /// <summary>A retention_weekly block as defined below.</summary>
    [JsonPropertyName("retentionWeekly")]
    public V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyRetentionWeekly? RetentionWeekly { get; set; }

    /// <summary>A retention_yearly block as defined below.</summary>
    [JsonPropertyName("retentionYearly")]
    public V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicyRetentionYearly? RetentionYearly { get; set; }

    /// <summary>A simple_retention block as defined below.</summary>
    [JsonPropertyName("simpleRetention")]
    public V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicySimpleRetention? SimpleRetention { get; set; }
}

/// <summary>A settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecInitProviderSettings
{
    /// <summary>The compression setting for the VM Workload Backup Policy. Defaults to false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>The timezone for the VM Workload Backup Policy. The possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
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
public partial class V1beta2BackupPolicyVMWorkloadSpecInitProvider
{
    /// <summary>One or more protection_policy blocks as defined below.</summary>
    [JsonPropertyName("protectionPolicy")]
    public IList<V1beta2BackupPolicyVMWorkloadSpecInitProviderProtectionPolicy>? ProtectionPolicy { get; set; }

    /// <summary>A settings block as defined below.</summary>
    [JsonPropertyName("settings")]
    public V1beta2BackupPolicyVMWorkloadSpecInitProviderSettings? Settings { get; set; }

    /// <summary>The VM Workload type for the Backup Policy. Possible values are SQLDataBase and SAPHanaDatabase. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecManagementPoliciesEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupPolicyVMWorkloadSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2BackupPolicyVMWorkloadSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackupPolicyVMWorkloadSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackupPolicyVMWorkloadSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackupPolicyVMWorkloadSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>BackupPolicyVMWorkloadSpec defines the desired state of BackupPolicyVMWorkload</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadSpec
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
    public V1beta2BackupPolicyVMWorkloadSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2BackupPolicyVMWorkloadSpecForProvider ForProvider { get; set; }

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
    public V1beta2BackupPolicyVMWorkloadSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2BackupPolicyVMWorkloadSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2BackupPolicyVMWorkloadSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2BackupPolicyVMWorkloadSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A backup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyBackup
{
    /// <summary>The backup frequency for the VM Workload Backup Policy. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The backup frequency in minutes for the VM Workload Backup Policy. Possible values are 15, 30, 60, 120, 240, 480, 720 and 1440.</summary>
    [JsonPropertyName("frequencyInMinutes")]
    public double? FrequencyInMinutes { get; set; }

    /// <summary>The time of day to perform the backup in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>A retention_daily block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyRetentionDaily
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>A retention_monthly block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyRetentionMonthly
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The retention schedule format type for yearly retention policy. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("formatType")]
    public string? FormatType { get; set; }

    /// <summary>The monthday backups to retain. Possible values are between 0 and 28.</summary>
    [JsonPropertyName("monthdays")]
    public IList<double>? Monthdays { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Possible values are First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>A retention_weekly block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyRetentionWeekly
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>A retention_yearly block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyRetentionYearly
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The retention schedule format type for yearly retention policy. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("formatType")]
    public string? FormatType { get; set; }

    /// <summary>The monthday backups to retain. Possible values are between 0 and 28.</summary>
    [JsonPropertyName("monthdays")]
    public IList<double>? Monthdays { get; set; }

    /// <summary>The months of the year to retain backups of. Possible values are January, February, March, April, May, June, July, August, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Possible values are First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>A simple_retention block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicySimpleRetention
{
    /// <summary>The count that is used to count retention duration with duration type Days. Possible values are between 7 and 35.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicy
{
    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyBackup? Backup { get; set; }

    /// <summary>The type of the VM Workload Backup Policy. Possible values are Differential, Full, Incremental and Log.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>A retention_daily block as defined below.</summary>
    [JsonPropertyName("retentionDaily")]
    public V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyRetentionDaily? RetentionDaily { get; set; }

    /// <summary>A retention_monthly block as defined below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyRetentionMonthly? RetentionMonthly { get; set; }

    /// <summary>A retention_weekly block as defined below.</summary>
    [JsonPropertyName("retentionWeekly")]
    public V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyRetentionWeekly? RetentionWeekly { get; set; }

    /// <summary>A retention_yearly block as defined below.</summary>
    [JsonPropertyName("retentionYearly")]
    public V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicyRetentionYearly? RetentionYearly { get; set; }

    /// <summary>A simple_retention block as defined below.</summary>
    [JsonPropertyName("simpleRetention")]
    public V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicySimpleRetention? SimpleRetention { get; set; }
}

/// <summary>A settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusAtProviderSettings
{
    /// <summary>The compression setting for the VM Workload Backup Policy. Defaults to false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>The timezone for the VM Workload Backup Policy. The possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusAtProvider
{
    /// <summary>The ID of the Azure VM Workload Backup Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more protection_policy blocks as defined below.</summary>
    [JsonPropertyName("protectionPolicy")]
    public IList<V1beta2BackupPolicyVMWorkloadStatusAtProviderProtectionPolicy>? ProtectionPolicy { get; set; }

    /// <summary>The name of the Recovery Services Vault to use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>The name of the resource group in which to create the VM Workload Backup Policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A settings block as defined below.</summary>
    [JsonPropertyName("settings")]
    public V1beta2BackupPolicyVMWorkloadStatusAtProviderSettings? Settings { get; set; }

    /// <summary>The VM Workload type for the Backup Policy. Possible values are SQLDataBase and SAPHanaDatabase. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatusConditions
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

/// <summary>BackupPolicyVMWorkloadStatus defines the observed state of BackupPolicyVMWorkload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupPolicyVMWorkloadStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2BackupPolicyVMWorkloadStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BackupPolicyVMWorkloadStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BackupPolicyVMWorkload is the Schema for the BackupPolicyVMWorkloads API. Manages an Azure VM Workload Backup Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupPolicyVMWorkload : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackupPolicyVMWorkloadSpec>, IStatus<V1beta2BackupPolicyVMWorkloadStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupPolicyVMWorkload";
    public const string KubeGroup = "recoveryservices.azure.upbound.io";
    public const string KubePluralName = "backuppolicyvmworkloads";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "recoveryservices.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupPolicyVMWorkload";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupPolicyVMWorkloadSpec defines the desired state of BackupPolicyVMWorkload</summary>
    [JsonPropertyName("spec")]
    public required V1beta2BackupPolicyVMWorkloadSpec Spec { get; set; }

    /// <summary>BackupPolicyVMWorkloadStatus defines the observed state of BackupPolicyVMWorkload.</summary>
    [JsonPropertyName("status")]
    public V1beta2BackupPolicyVMWorkloadStatus? Status { get; set; }
}