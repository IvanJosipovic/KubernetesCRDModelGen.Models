#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dlm.aws.upbound.io;
/// <summary>LifecyclePolicy is the Schema for the LifecyclePolicys API. Provides a Data Lifecycle Manager (DLM) lifecycle policy for managing snapshots.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LifecyclePolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2LifecyclePolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LifecyclePolicyList";
    public const string KubeGroup = "dlm.aws.upbound.io";
    public const string KubePluralName = "lifecyclepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dlm.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LifecyclePolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2LifecyclePolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2LifecyclePolicy> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecDeletionPolicyEnum>))]
public enum V1beta2LifecyclePolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelector
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
    public V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The encryption settings for the copied snapshot. See the encryption_configuration block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }
}

/// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopyRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopy
{
    /// <summary>The encryption settings for the copied snapshot. See the encryption_configuration block. Max of 1 per action.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopyRetainRule? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>The actions to be performed when the event-based policy is triggered. You can specify only one action per policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the action configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsAction
{
    /// <summary>The rule for copying shared snapshots across Regions. See the cross_region_copy configuration block.</summary>
    [JsonPropertyName("crossRegionCopy")]
    public IList<V1beta2LifecyclePolicySpecForProviderPolicyDetailsActionCrossRegionCopy>? CrossRegionCopy { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsEventSourceParameters
{
    /// <summary>The snapshot description that can trigger the policy. The description pattern is specified using a regular expression. The policy runs only if a snapshot with a description that matches the specified pattern is shared with your account.</summary>
    [JsonPropertyName("descriptionRegex")]
    public string? DescriptionRegex { get; set; }

    /// <summary>The type of event. Currently, only shareSnapshot events are supported.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>The IDs of the AWS accounts that can trigger policy by sharing snapshots with your account. The policy only runs if one of the specified AWS accounts shares a snapshot with your account.</summary>
    [JsonPropertyName("snapshotOwner")]
    public IList<string>? SnapshotOwner { get; set; }
}

/// <summary>The event that triggers the event-based policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the event_source configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsEventSource
{
    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsEventSourceParameters? Parameters { get; set; }

    /// <summary>The source of the event. Currently only managed CloudWatch Events rules are supported. Valid values are MANAGED_CWE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Specifies exclusion parameters for volumes or instances for which you do not want to create snapshots or AMIs.  See the exclusions configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsExclusions
{
    /// <summary>Indicates whether to exclude volumes that are attached to instances as the boot volume. To exclude boot volumes, specify true.</summary>
    [JsonPropertyName("excludeBootVolumes")]
    public bool? ExcludeBootVolumes { get; set; }

    /// <summary>Map specifies whether to exclude volumes that have specific tags.</summary>
    [JsonPropertyName("excludeTags")]
    public IDictionary<string, string>? ExcludeTags { get; set; }

    /// <summary>List specifies the volume types to exclude.</summary>
    [JsonPropertyName("excludeVolumeTypes")]
    public IList<string>? ExcludeVolumeTypes { get; set; }
}

/// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsParameters
{
    /// <summary>Indicates whether to exclude the root volume from snapshots created using CreateSnapshots. The default is false.</summary>
    [JsonPropertyName("excludeBootVolume")]
    public bool? ExcludeBootVolume { get; set; }

    /// <summary>Applies to AMI lifecycle policies only. Indicates whether targeted instances are rebooted when the lifecycle policy runs. true indicates that targeted instances are not rebooted when the policy runs. false indicates that target instances are rebooted when the policy runs. The default is true (instances are not rebooted).</summary>
    [JsonPropertyName("noReboot")]
    public bool? NoReboot { get; set; }
}

/// <summary>Information about retention period in the Amazon EBS Snapshots Archive. See the retention_archive_tier block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>Information about the retention period for the snapshot archiving rule. See the archive_retain_rule block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRule
{
    /// <summary>Information about retention period in the Amazon EBS Snapshots Archive. See the retention_archive_tier block.</summary>
    [JsonPropertyName("retentionArchiveTier")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier? RetentionArchiveTier { get; set; }
}

/// <summary>Specifies a snapshot archiving rule for a schedule. See archive_rule block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleArchiveRule
{
    /// <summary>Information about the retention period for the snapshot archiving rule. See the archive_retain_rule block.</summary>
    [JsonPropertyName("archiveRetainRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRule? ArchiveRetainRule { get; set; }
}

/// <summary>Specifies pre and/or post scripts for a snapshot lifecycle policy that targets instances. Valid only when resource_type is INSTANCE. See the scripts configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCreateRuleScripts
{
    /// <summary>Indicates whether Amazon Data Lifecycle Manager should default to crash-consistent snapshots if the pre script fails. The default is true.</summary>
    [JsonPropertyName("executeOperationOnScriptFailure")]
    public bool? ExecuteOperationOnScriptFailure { get; set; }

    /// <summary>The SSM document that includes the pre and/or post scripts to run. In case automating VSS backups, specify AWS_VSS_BACKUP. In case automating application-consistent snapshots for SAP HANA workloads, specify AWSSystemsManagerSAP-CreateDLMSnapshotForSAPHANA. If you are using a custom SSM document that you own, specify either the name or ARN of the SSM document.</summary>
    [JsonPropertyName("executionHandler")]
    public string? ExecutionHandler { get; set; }

    /// <summary>Indicates the service used to execute the pre and/or post scripts. If using custom SSM documents or automating application-consistent snapshots of SAP HANA workloads, specify AWS_SYSTEMS_MANAGER. In case automating VSS Backups, omit this parameter. The default is AWS_SYSTEMS_MANAGER.</summary>
    [JsonPropertyName("executionHandlerService")]
    public string? ExecutionHandlerService { get; set; }

    /// <summary>Specifies a timeout period, in seconds, after which Amazon Data Lifecycle Manager fails the script run attempt if it has not completed. In case automating VSS Backups, omit this parameter. The default is 10.</summary>
    [JsonPropertyName("executionTimeout")]
    public double? ExecutionTimeout { get; set; }

    /// <summary>Specifies the number of times Amazon Data Lifecycle Manager should retry scripts that fail. Must be an integer between 0 and 3. The default is 0.</summary>
    [JsonPropertyName("maximumRetryCount")]
    public double? MaximumRetryCount { get; set; }

    /// <summary>List to indicate which scripts Amazon Data Lifecycle Manager should run on target instances. Pre scripts run before Amazon Data Lifecycle Manager initiates snapshot creation. Post scripts run after Amazon Data Lifecycle Manager initiates snapshot creation. Valid values: PRE and POST. The default is PRE and POST</summary>
    [JsonPropertyName("stages")]
    public IList<string>? Stages { get; set; }
}

/// <summary>See the create_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCreateRule
{
    /// <summary>The schedule, as a Cron expression. The schedule interval must be between 1 hour and 1 year. Conflicts with interval, interval_unit, and times. For details on valid Cron expressions, see here.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }

    /// <summary>Specifies the destination for snapshots created by the policy. To create snapshots in the same Region as the source resource, specify CLOUD. To create snapshots on the same Outpost as the source resource, specify OUTPOST_LOCAL. If you omit this parameter, CLOUD is used by default. If the policy targets resources in an AWS Region, then you must create snapshots in the same Region as the source resource. If the policy targets resources on an Outpost, then you can create snapshots on the same Outpost as the source resource, or in the Region of that Outpost. Valid values are CLOUD and OUTPOST_LOCAL.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies pre and/or post scripts for a snapshot lifecycle policy that targets instances. Valid only when resource_type is INSTANCE. See the scripts configuration block.</summary>
    [JsonPropertyName("scripts")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCreateRuleScripts? Scripts { get; set; }

    /// <summary>A list of times in 24 hour clock format that sets when the lifecycle policy should be evaluated. Max of 1. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("times")]
    public IList<string>? Times { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolutionEnum>))]
public enum V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolveEnum>))]
public enum V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate cmkArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolveEnum>))]
public enum V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate cmkArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelector
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
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicy? Policy { get; set; }
}

/// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRule
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>Reference to a Key in kms to populate cmkArn.</summary>
    [JsonPropertyName("cmkArnRef")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRef? CmkArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate cmkArn.</summary>
    [JsonPropertyName("cmkArnSelector")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelector? CmkArnSelector { get; set; }

    /// <summary>Indicates whether the policy should copy tags from the source resource to the snapshot or AMI. Default value is false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule? DeprecateRule { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Use only for DLM policies of policy_type=IMAGE_MANAGEMENT. The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("targetRegion")]
    public string? TargetRegion { get; set; }
}

/// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleDeprecateRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>See the fast_restore_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleFastRestoreRule
{
    /// <summary>The Availability Zones in which to enable fast snapshot restore.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleRetainRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>See the share_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleShareRule
{
    /// <summary>The IDs of the AWS accounts with which to share the snapshots.</summary>
    [JsonPropertyName("targetAccounts")]
    public IList<string>? TargetAccounts { get; set; }

    /// <summary>The period after which snapshots that are shared with other AWS accounts are automatically unshared.</summary>
    [JsonPropertyName("unshareInterval")]
    public double? UnshareInterval { get; set; }

    /// <summary>The unit of time for the automatic unsharing interval. Valid values are DAYS, WEEKS, MONTHS, YEARS.</summary>
    [JsonPropertyName("unshareIntervalUnit")]
    public string? UnshareIntervalUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetailsSchedule
{
    /// <summary>Specifies a snapshot archiving rule for a schedule. See archive_rule block.</summary>
    [JsonPropertyName("archiveRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleArchiveRule? ArchiveRule { get; set; }

    /// <summary>Indicates whether the policy should copy tags from the source resource to the snapshot or AMI. Default value is false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the create_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("createRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCreateRule? CreateRule { get; set; }

    /// <summary>See the cross_region_copy_rule block. Max of 3 per schedule.</summary>
    [JsonPropertyName("crossRegionCopyRule")]
    public IList<V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleCrossRegionCopyRule>? CrossRegionCopyRule { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleDeprecateRule? DeprecateRule { get; set; }

    /// <summary>See the fast_restore_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("fastRestoreRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleFastRestoreRule? FastRestoreRule { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleRetainRule? RetainRule { get; set; }

    /// <summary>See the share_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("shareRule")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsScheduleShareRule? ShareRule { get; set; }

    /// <summary>A map of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.</summary>
    [JsonPropertyName("tagsToAdd")]
    public IDictionary<string, string>? TagsToAdd { get; set; }

    /// <summary>A map of tag keys and variable values, where the values are determined when the policy is executed. Only $(instance-id) or $(timestamp) are valid values. Can only be used when resource_types is INSTANCE.</summary>
    [JsonPropertyName("variableTags")]
    public IDictionary<string, string>? VariableTags { get; set; }
}

/// <summary>See the policy_details configuration block. Max of 1.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProviderPolicyDetails
{
    /// <summary>The actions to be performed when the event-based policy is triggered. You can specify only one action per policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the action configuration block.</summary>
    [JsonPropertyName("action")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsAction? Action { get; set; }

    /// <summary>Indicates whether the policy should copy tags from the source resource to the snapshot or AMI. Default value is false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>How often the policy should run and create snapshots or AMIs. valid values range from 1 to 7. Default value is 1.</summary>
    [JsonPropertyName("createInterval")]
    public double? CreateInterval { get; set; }

    /// <summary>The event that triggers the event-based policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the event_source configuration block.</summary>
    [JsonPropertyName("eventSource")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsEventSource? EventSource { get; set; }

    /// <summary>Specifies exclusion parameters for volumes or instances for which you do not want to create snapshots or AMIs.  See the exclusions configuration block.</summary>
    [JsonPropertyName("exclusions")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsExclusions? Exclusions { get; set; }

    /// <summary>snapshot or AMI retention behavior for the policy if the source volume or instance is deleted, or if the policy enters the error, disabled, or deleted state. Default value is false.</summary>
    [JsonPropertyName("extendDeletion")]
    public bool? ExtendDeletion { get; set; }

    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetailsParameters? Parameters { get; set; }

    /// <summary>Type of policy to create. SIMPLIFIED To create a default policy. STANDARD To create a custom policy.</summary>
    [JsonPropertyName("policyLanguage")]
    public string? PolicyLanguage { get; set; }

    /// <summary>The valid target resource types and actions a policy can manage. Specify EBS_SNAPSHOT_MANAGEMENT to create a lifecycle policy that manages the lifecycle of Amazon EBS snapshots. Specify IMAGE_MANAGEMENT to create a lifecycle policy that manages the lifecycle of EBS-backed AMIs. Specify EVENT_BASED_POLICY to create an event-based policy that performs specific actions when a defined event occurs in your AWS account. Default value is EBS_SNAPSHOT_MANAGEMENT.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>The location of the resources to backup. If the source resources are located in an AWS Region, specify CLOUD. If the source resources are located on an Outpost in your account, specify OUTPOST. If the source resources are located in a Local Zone, specify LOCAL_ZONE. Valid values are CLOUD, LOCAL_ZONE, and OUTPOST.</summary>
    [JsonPropertyName("resourceLocations")]
    public IList<string>? ResourceLocations { get; set; }

    /// <summary>Type of default policy to create. Valid values are VOLUME and INSTANCE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A list of resource types that should be targeted by the lifecycle policy. Valid values are VOLUME and INSTANCE.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>Specifies how long the policy should retain snapshots or AMIs before deleting them. valid values range from 2 to 14. Default value is 7.</summary>
    [JsonPropertyName("retainInterval")]
    public double? RetainInterval { get; set; }

    /// <summary>See the schedule configuration block.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta2LifecyclePolicySpecForProviderPolicyDetailsSchedule>? Schedule { get; set; }

    /// <summary>A map of tag keys and their values. Any resources that match the resource_types and are tagged with any of these tags will be targeted. Required when policy_type is EBS_SNAPSHOT_MANAGEMENT or IMAGE_MANAGEMENT. Must not be specified when policy_type is EVENT_BASED_POLICY.</summary>
    [JsonPropertyName("targetTags")]
    public IDictionary<string, string>? TargetTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecForProvider
{
    /// <summary>Specify the type of default policy to create. valid values are VOLUME or INSTANCE.</summary>
    [JsonPropertyName("defaultPolicy")]
    public string? DefaultPolicy { get; set; }

    /// <summary>A description for the DLM lifecycle policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ARN of an IAM role that is able to be assumed by the DLM service.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta2LifecyclePolicySpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta2LifecyclePolicySpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>See the policy_details configuration block. Max of 1.</summary>
    [JsonPropertyName("policyDetails")]
    public V1beta2LifecyclePolicySpecForProviderPolicyDetails? PolicyDetails { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Whether the lifecycle policy should be enabled or disabled. ENABLED or DISABLED are valid values. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelector
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
    public V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The encryption settings for the copied snapshot. See the encryption_configuration block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }
}

/// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopyRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopy
{
    /// <summary>The encryption settings for the copied snapshot. See the encryption_configuration block. Max of 1 per action.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopyRetainRule? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>The actions to be performed when the event-based policy is triggered. You can specify only one action per policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the action configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsAction
{
    /// <summary>The rule for copying shared snapshots across Regions. See the cross_region_copy configuration block.</summary>
    [JsonPropertyName("crossRegionCopy")]
    public IList<V1beta2LifecyclePolicySpecInitProviderPolicyDetailsActionCrossRegionCopy>? CrossRegionCopy { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsEventSourceParameters
{
    /// <summary>The snapshot description that can trigger the policy. The description pattern is specified using a regular expression. The policy runs only if a snapshot with a description that matches the specified pattern is shared with your account.</summary>
    [JsonPropertyName("descriptionRegex")]
    public string? DescriptionRegex { get; set; }

    /// <summary>The type of event. Currently, only shareSnapshot events are supported.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>The IDs of the AWS accounts that can trigger policy by sharing snapshots with your account. The policy only runs if one of the specified AWS accounts shares a snapshot with your account.</summary>
    [JsonPropertyName("snapshotOwner")]
    public IList<string>? SnapshotOwner { get; set; }
}

/// <summary>The event that triggers the event-based policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the event_source configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsEventSource
{
    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsEventSourceParameters? Parameters { get; set; }

    /// <summary>The source of the event. Currently only managed CloudWatch Events rules are supported. Valid values are MANAGED_CWE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Specifies exclusion parameters for volumes or instances for which you do not want to create snapshots or AMIs.  See the exclusions configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsExclusions
{
    /// <summary>Indicates whether to exclude volumes that are attached to instances as the boot volume. To exclude boot volumes, specify true.</summary>
    [JsonPropertyName("excludeBootVolumes")]
    public bool? ExcludeBootVolumes { get; set; }

    /// <summary>Map specifies whether to exclude volumes that have specific tags.</summary>
    [JsonPropertyName("excludeTags")]
    public IDictionary<string, string>? ExcludeTags { get; set; }

    /// <summary>List specifies the volume types to exclude.</summary>
    [JsonPropertyName("excludeVolumeTypes")]
    public IList<string>? ExcludeVolumeTypes { get; set; }
}

/// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsParameters
{
    /// <summary>Indicates whether to exclude the root volume from snapshots created using CreateSnapshots. The default is false.</summary>
    [JsonPropertyName("excludeBootVolume")]
    public bool? ExcludeBootVolume { get; set; }

    /// <summary>Applies to AMI lifecycle policies only. Indicates whether targeted instances are rebooted when the lifecycle policy runs. true indicates that targeted instances are not rebooted when the policy runs. false indicates that target instances are rebooted when the policy runs. The default is true (instances are not rebooted).</summary>
    [JsonPropertyName("noReboot")]
    public bool? NoReboot { get; set; }
}

/// <summary>Information about retention period in the Amazon EBS Snapshots Archive. See the retention_archive_tier block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>Information about the retention period for the snapshot archiving rule. See the archive_retain_rule block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRule
{
    /// <summary>Information about retention period in the Amazon EBS Snapshots Archive. See the retention_archive_tier block.</summary>
    [JsonPropertyName("retentionArchiveTier")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier? RetentionArchiveTier { get; set; }
}

/// <summary>Specifies a snapshot archiving rule for a schedule. See archive_rule block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleArchiveRule
{
    /// <summary>Information about the retention period for the snapshot archiving rule. See the archive_retain_rule block.</summary>
    [JsonPropertyName("archiveRetainRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRule? ArchiveRetainRule { get; set; }
}

/// <summary>Specifies pre and/or post scripts for a snapshot lifecycle policy that targets instances. Valid only when resource_type is INSTANCE. See the scripts configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCreateRuleScripts
{
    /// <summary>Indicates whether Amazon Data Lifecycle Manager should default to crash-consistent snapshots if the pre script fails. The default is true.</summary>
    [JsonPropertyName("executeOperationOnScriptFailure")]
    public bool? ExecuteOperationOnScriptFailure { get; set; }

    /// <summary>The SSM document that includes the pre and/or post scripts to run. In case automating VSS backups, specify AWS_VSS_BACKUP. In case automating application-consistent snapshots for SAP HANA workloads, specify AWSSystemsManagerSAP-CreateDLMSnapshotForSAPHANA. If you are using a custom SSM document that you own, specify either the name or ARN of the SSM document.</summary>
    [JsonPropertyName("executionHandler")]
    public string? ExecutionHandler { get; set; }

    /// <summary>Indicates the service used to execute the pre and/or post scripts. If using custom SSM documents or automating application-consistent snapshots of SAP HANA workloads, specify AWS_SYSTEMS_MANAGER. In case automating VSS Backups, omit this parameter. The default is AWS_SYSTEMS_MANAGER.</summary>
    [JsonPropertyName("executionHandlerService")]
    public string? ExecutionHandlerService { get; set; }

    /// <summary>Specifies a timeout period, in seconds, after which Amazon Data Lifecycle Manager fails the script run attempt if it has not completed. In case automating VSS Backups, omit this parameter. The default is 10.</summary>
    [JsonPropertyName("executionTimeout")]
    public double? ExecutionTimeout { get; set; }

    /// <summary>Specifies the number of times Amazon Data Lifecycle Manager should retry scripts that fail. Must be an integer between 0 and 3. The default is 0.</summary>
    [JsonPropertyName("maximumRetryCount")]
    public double? MaximumRetryCount { get; set; }

    /// <summary>List to indicate which scripts Amazon Data Lifecycle Manager should run on target instances. Pre scripts run before Amazon Data Lifecycle Manager initiates snapshot creation. Post scripts run after Amazon Data Lifecycle Manager initiates snapshot creation. Valid values: PRE and POST. The default is PRE and POST</summary>
    [JsonPropertyName("stages")]
    public IList<string>? Stages { get; set; }
}

/// <summary>See the create_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCreateRule
{
    /// <summary>The schedule, as a Cron expression. The schedule interval must be between 1 hour and 1 year. Conflicts with interval, interval_unit, and times. For details on valid Cron expressions, see here.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }

    /// <summary>Specifies the destination for snapshots created by the policy. To create snapshots in the same Region as the source resource, specify CLOUD. To create snapshots on the same Outpost as the source resource, specify OUTPOST_LOCAL. If you omit this parameter, CLOUD is used by default. If the policy targets resources in an AWS Region, then you must create snapshots in the same Region as the source resource. If the policy targets resources on an Outpost, then you can create snapshots on the same Outpost as the source resource, or in the Region of that Outpost. Valid values are CLOUD and OUTPOST_LOCAL.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies pre and/or post scripts for a snapshot lifecycle policy that targets instances. Valid only when resource_type is INSTANCE. See the scripts configuration block.</summary>
    [JsonPropertyName("scripts")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCreateRuleScripts? Scripts { get; set; }

    /// <summary>A list of times in 24 hour clock format that sets when the lifecycle policy should be evaluated. Max of 1. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("times")]
    public IList<string>? Times { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolutionEnum>))]
public enum V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolveEnum>))]
public enum V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate cmkArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolveEnum>))]
public enum V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate cmkArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelector
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
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelectorPolicy? Policy { get; set; }
}

/// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRule
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>Reference to a Key in kms to populate cmkArn.</summary>
    [JsonPropertyName("cmkArnRef")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnRef? CmkArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate cmkArn.</summary>
    [JsonPropertyName("cmkArnSelector")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleCmkArnSelector? CmkArnSelector { get; set; }

    /// <summary>Indicates whether the policy should copy tags from the source resource to the snapshot or AMI. Default value is false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule? DeprecateRule { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Use only for DLM policies of policy_type=IMAGE_MANAGEMENT. The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("targetRegion")]
    public string? TargetRegion { get; set; }
}

/// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleDeprecateRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>See the fast_restore_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleFastRestoreRule
{
    /// <summary>The Availability Zones in which to enable fast snapshot restore.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleRetainRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>See the share_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleShareRule
{
    /// <summary>The IDs of the AWS accounts with which to share the snapshots.</summary>
    [JsonPropertyName("targetAccounts")]
    public IList<string>? TargetAccounts { get; set; }

    /// <summary>The period after which snapshots that are shared with other AWS accounts are automatically unshared.</summary>
    [JsonPropertyName("unshareInterval")]
    public double? UnshareInterval { get; set; }

    /// <summary>The unit of time for the automatic unsharing interval. Valid values are DAYS, WEEKS, MONTHS, YEARS.</summary>
    [JsonPropertyName("unshareIntervalUnit")]
    public string? UnshareIntervalUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetailsSchedule
{
    /// <summary>Specifies a snapshot archiving rule for a schedule. See archive_rule block.</summary>
    [JsonPropertyName("archiveRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleArchiveRule? ArchiveRule { get; set; }

    /// <summary>Indicates whether the policy should copy tags from the source resource to the snapshot or AMI. Default value is false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the create_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("createRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCreateRule? CreateRule { get; set; }

    /// <summary>See the cross_region_copy_rule block. Max of 3 per schedule.</summary>
    [JsonPropertyName("crossRegionCopyRule")]
    public IList<V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleCrossRegionCopyRule>? CrossRegionCopyRule { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleDeprecateRule? DeprecateRule { get; set; }

    /// <summary>See the fast_restore_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("fastRestoreRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleFastRestoreRule? FastRestoreRule { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleRetainRule? RetainRule { get; set; }

    /// <summary>See the share_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("shareRule")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsScheduleShareRule? ShareRule { get; set; }

    /// <summary>A map of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.</summary>
    [JsonPropertyName("tagsToAdd")]
    public IDictionary<string, string>? TagsToAdd { get; set; }

    /// <summary>A map of tag keys and variable values, where the values are determined when the policy is executed. Only $(instance-id) or $(timestamp) are valid values. Can only be used when resource_types is INSTANCE.</summary>
    [JsonPropertyName("variableTags")]
    public IDictionary<string, string>? VariableTags { get; set; }
}

/// <summary>See the policy_details configuration block. Max of 1.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecInitProviderPolicyDetails
{
    /// <summary>The actions to be performed when the event-based policy is triggered. You can specify only one action per policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the action configuration block.</summary>
    [JsonPropertyName("action")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsAction? Action { get; set; }

    /// <summary>Indicates whether the policy should copy tags from the source resource to the snapshot or AMI. Default value is false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>How often the policy should run and create snapshots or AMIs. valid values range from 1 to 7. Default value is 1.</summary>
    [JsonPropertyName("createInterval")]
    public double? CreateInterval { get; set; }

    /// <summary>The event that triggers the event-based policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the event_source configuration block.</summary>
    [JsonPropertyName("eventSource")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsEventSource? EventSource { get; set; }

    /// <summary>Specifies exclusion parameters for volumes or instances for which you do not want to create snapshots or AMIs.  See the exclusions configuration block.</summary>
    [JsonPropertyName("exclusions")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsExclusions? Exclusions { get; set; }

    /// <summary>snapshot or AMI retention behavior for the policy if the source volume or instance is deleted, or if the policy enters the error, disabled, or deleted state. Default value is false.</summary>
    [JsonPropertyName("extendDeletion")]
    public bool? ExtendDeletion { get; set; }

    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetailsParameters? Parameters { get; set; }

    /// <summary>Type of policy to create. SIMPLIFIED To create a default policy. STANDARD To create a custom policy.</summary>
    [JsonPropertyName("policyLanguage")]
    public string? PolicyLanguage { get; set; }

    /// <summary>The valid target resource types and actions a policy can manage. Specify EBS_SNAPSHOT_MANAGEMENT to create a lifecycle policy that manages the lifecycle of Amazon EBS snapshots. Specify IMAGE_MANAGEMENT to create a lifecycle policy that manages the lifecycle of EBS-backed AMIs. Specify EVENT_BASED_POLICY to create an event-based policy that performs specific actions when a defined event occurs in your AWS account. Default value is EBS_SNAPSHOT_MANAGEMENT.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>The location of the resources to backup. If the source resources are located in an AWS Region, specify CLOUD. If the source resources are located on an Outpost in your account, specify OUTPOST. If the source resources are located in a Local Zone, specify LOCAL_ZONE. Valid values are CLOUD, LOCAL_ZONE, and OUTPOST.</summary>
    [JsonPropertyName("resourceLocations")]
    public IList<string>? ResourceLocations { get; set; }

    /// <summary>Type of default policy to create. Valid values are VOLUME and INSTANCE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A list of resource types that should be targeted by the lifecycle policy. Valid values are VOLUME and INSTANCE.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>Specifies how long the policy should retain snapshots or AMIs before deleting them. valid values range from 2 to 14. Default value is 7.</summary>
    [JsonPropertyName("retainInterval")]
    public double? RetainInterval { get; set; }

    /// <summary>See the schedule configuration block.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta2LifecyclePolicySpecInitProviderPolicyDetailsSchedule>? Schedule { get; set; }

    /// <summary>A map of tag keys and their values. Any resources that match the resource_types and are tagged with any of these tags will be targeted. Required when policy_type is EBS_SNAPSHOT_MANAGEMENT or IMAGE_MANAGEMENT. Must not be specified when policy_type is EVENT_BASED_POLICY.</summary>
    [JsonPropertyName("targetTags")]
    public IDictionary<string, string>? TargetTags { get; set; }
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
public partial class V1beta2LifecyclePolicySpecInitProvider
{
    /// <summary>Specify the type of default policy to create. valid values are VOLUME or INSTANCE.</summary>
    [JsonPropertyName("defaultPolicy")]
    public string? DefaultPolicy { get; set; }

    /// <summary>A description for the DLM lifecycle policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ARN of an IAM role that is able to be assumed by the DLM service.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta2LifecyclePolicySpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>See the policy_details configuration block. Max of 1.</summary>
    [JsonPropertyName("policyDetails")]
    public V1beta2LifecyclePolicySpecInitProviderPolicyDetails? PolicyDetails { get; set; }

    /// <summary>Whether the lifecycle policy should be enabled or disabled. ENABLED or DISABLED are valid values. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecManagementPoliciesEnum>))]
public enum V1beta2LifecyclePolicySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2LifecyclePolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LifecyclePolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2LifecyclePolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LifecyclePolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LifecyclePolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LifecyclePolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>LifecyclePolicySpec defines the desired state of LifecyclePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicySpec
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
    public V1beta2LifecyclePolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2LifecyclePolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2LifecyclePolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2LifecyclePolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2LifecyclePolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2LifecyclePolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The encryption settings for the copied snapshot. See the encryption_configuration block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }
}

/// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopyRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopy
{
    /// <summary>The encryption settings for the copied snapshot. See the encryption_configuration block. Max of 1 per action.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopyEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopyRetainRule? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>The actions to be performed when the event-based policy is triggered. You can specify only one action per policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the action configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsAction
{
    /// <summary>The rule for copying shared snapshots across Regions. See the cross_region_copy configuration block.</summary>
    [JsonPropertyName("crossRegionCopy")]
    public IList<V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsActionCrossRegionCopy>? CrossRegionCopy { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsEventSourceParameters
{
    /// <summary>The snapshot description that can trigger the policy. The description pattern is specified using a regular expression. The policy runs only if a snapshot with a description that matches the specified pattern is shared with your account.</summary>
    [JsonPropertyName("descriptionRegex")]
    public string? DescriptionRegex { get; set; }

    /// <summary>The type of event. Currently, only shareSnapshot events are supported.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>The IDs of the AWS accounts that can trigger policy by sharing snapshots with your account. The policy only runs if one of the specified AWS accounts shares a snapshot with your account.</summary>
    [JsonPropertyName("snapshotOwner")]
    public IList<string>? SnapshotOwner { get; set; }
}

/// <summary>The event that triggers the event-based policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the event_source configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsEventSource
{
    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsEventSourceParameters? Parameters { get; set; }

    /// <summary>The source of the event. Currently only managed CloudWatch Events rules are supported. Valid values are MANAGED_CWE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Specifies exclusion parameters for volumes or instances for which you do not want to create snapshots or AMIs.  See the exclusions configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsExclusions
{
    /// <summary>Indicates whether to exclude volumes that are attached to instances as the boot volume. To exclude boot volumes, specify true.</summary>
    [JsonPropertyName("excludeBootVolumes")]
    public bool? ExcludeBootVolumes { get; set; }

    /// <summary>Map specifies whether to exclude volumes that have specific tags.</summary>
    [JsonPropertyName("excludeTags")]
    public IDictionary<string, string>? ExcludeTags { get; set; }

    /// <summary>List specifies the volume types to exclude.</summary>
    [JsonPropertyName("excludeVolumeTypes")]
    public IList<string>? ExcludeVolumeTypes { get; set; }
}

/// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsParameters
{
    /// <summary>Indicates whether to exclude the root volume from snapshots created using CreateSnapshots. The default is false.</summary>
    [JsonPropertyName("excludeBootVolume")]
    public bool? ExcludeBootVolume { get; set; }

    /// <summary>Applies to AMI lifecycle policies only. Indicates whether targeted instances are rebooted when the lifecycle policy runs. true indicates that targeted instances are not rebooted when the policy runs. false indicates that target instances are rebooted when the policy runs. The default is true (instances are not rebooted).</summary>
    [JsonPropertyName("noReboot")]
    public bool? NoReboot { get; set; }
}

/// <summary>Information about retention period in the Amazon EBS Snapshots Archive. See the retention_archive_tier block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>Information about the retention period for the snapshot archiving rule. See the archive_retain_rule block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRule
{
    /// <summary>Information about retention period in the Amazon EBS Snapshots Archive. See the retention_archive_tier block.</summary>
    [JsonPropertyName("retentionArchiveTier")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier? RetentionArchiveTier { get; set; }
}

/// <summary>Specifies a snapshot archiving rule for a schedule. See archive_rule block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleArchiveRule
{
    /// <summary>Information about the retention period for the snapshot archiving rule. See the archive_retain_rule block.</summary>
    [JsonPropertyName("archiveRetainRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleArchiveRuleArchiveRetainRule? ArchiveRetainRule { get; set; }
}

/// <summary>Specifies pre and/or post scripts for a snapshot lifecycle policy that targets instances. Valid only when resource_type is INSTANCE. See the scripts configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCreateRuleScripts
{
    /// <summary>Indicates whether Amazon Data Lifecycle Manager should default to crash-consistent snapshots if the pre script fails. The default is true.</summary>
    [JsonPropertyName("executeOperationOnScriptFailure")]
    public bool? ExecuteOperationOnScriptFailure { get; set; }

    /// <summary>The SSM document that includes the pre and/or post scripts to run. In case automating VSS backups, specify AWS_VSS_BACKUP. In case automating application-consistent snapshots for SAP HANA workloads, specify AWSSystemsManagerSAP-CreateDLMSnapshotForSAPHANA. If you are using a custom SSM document that you own, specify either the name or ARN of the SSM document.</summary>
    [JsonPropertyName("executionHandler")]
    public string? ExecutionHandler { get; set; }

    /// <summary>Indicates the service used to execute the pre and/or post scripts. If using custom SSM documents or automating application-consistent snapshots of SAP HANA workloads, specify AWS_SYSTEMS_MANAGER. In case automating VSS Backups, omit this parameter. The default is AWS_SYSTEMS_MANAGER.</summary>
    [JsonPropertyName("executionHandlerService")]
    public string? ExecutionHandlerService { get; set; }

    /// <summary>Specifies a timeout period, in seconds, after which Amazon Data Lifecycle Manager fails the script run attempt if it has not completed. In case automating VSS Backups, omit this parameter. The default is 10.</summary>
    [JsonPropertyName("executionTimeout")]
    public double? ExecutionTimeout { get; set; }

    /// <summary>Specifies the number of times Amazon Data Lifecycle Manager should retry scripts that fail. Must be an integer between 0 and 3. The default is 0.</summary>
    [JsonPropertyName("maximumRetryCount")]
    public double? MaximumRetryCount { get; set; }

    /// <summary>List to indicate which scripts Amazon Data Lifecycle Manager should run on target instances. Pre scripts run before Amazon Data Lifecycle Manager initiates snapshot creation. Post scripts run after Amazon Data Lifecycle Manager initiates snapshot creation. Valid values: PRE and POST. The default is PRE and POST</summary>
    [JsonPropertyName("stages")]
    public IList<string>? Stages { get; set; }
}

/// <summary>See the create_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCreateRule
{
    /// <summary>The schedule, as a Cron expression. The schedule interval must be between 1 hour and 1 year. Conflicts with interval, interval_unit, and times. For details on valid Cron expressions, see here.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }

    /// <summary>Specifies the destination for snapshots created by the policy. To create snapshots in the same Region as the source resource, specify CLOUD. To create snapshots on the same Outpost as the source resource, specify OUTPOST_LOCAL. If you omit this parameter, CLOUD is used by default. If the policy targets resources in an AWS Region, then you must create snapshots in the same Region as the source resource. If the policy targets resources on an Outpost, then you can create snapshots on the same Outpost as the source resource, or in the Region of that Outpost. Valid values are CLOUD and OUTPOST_LOCAL.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies pre and/or post scripts for a snapshot lifecycle policy that targets instances. Valid only when resource_type is INSTANCE. See the scripts configuration block.</summary>
    [JsonPropertyName("scripts")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCreateRuleScripts? Scripts { get; set; }

    /// <summary>A list of times in 24 hour clock format that sets when the lifecycle policy should be evaluated. Max of 1. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("times")]
    public IList<string>? Times { get; set; }
}

/// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule
{
    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRule
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this parameter is not specified, the default KMS key for the account is used.</summary>
    [JsonPropertyName("cmkArn")]
    public string? CmkArn { get; set; }

    /// <summary>Indicates whether the policy should copy tags from the source resource to the snapshot or AMI. Default value is false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule? DeprecateRule { get; set; }

    /// <summary>To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this parameter is false or when encryption by default is not enabled.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRuleRetainRule? RetainRule { get; set; }

    /// <summary>The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Use only for DLM policies of policy_type=IMAGE_MANAGEMENT. The target Region or the Amazon Resource Name (ARN) of the target Outpost for the snapshot copies.</summary>
    [JsonPropertyName("targetRegion")]
    public string? TargetRegion { get; set; }
}

/// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleDeprecateRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>See the fast_restore_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleFastRestoreRule
{
    /// <summary>The Availability Zones in which to enable fast snapshot restore.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleRetainRule
{
    /// <summary>Specifies the number of oldest AMIs to deprecate. Must be an integer between 1 and 1000. Conflicts with interval and interval_unit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>How often this lifecycle policy should be evaluated. 1, 2,3,4,6,8,12 or 24 are valid values. Conflicts with cron_expression. If set, interval_unit and times must also be set.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The unit for how often the lifecycle policy should be evaluated. HOURS is currently the only allowed value and also the default value. Conflicts with cron_expression. Must be set if interval is set.</summary>
    [JsonPropertyName("intervalUnit")]
    public string? IntervalUnit { get; set; }
}

/// <summary>See the share_rule block. Max of 1 per schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleShareRule
{
    /// <summary>The IDs of the AWS accounts with which to share the snapshots.</summary>
    [JsonPropertyName("targetAccounts")]
    public IList<string>? TargetAccounts { get; set; }

    /// <summary>The period after which snapshots that are shared with other AWS accounts are automatically unshared.</summary>
    [JsonPropertyName("unshareInterval")]
    public double? UnshareInterval { get; set; }

    /// <summary>The unit of time for the automatic unsharing interval. Valid values are DAYS, WEEKS, MONTHS, YEARS.</summary>
    [JsonPropertyName("unshareIntervalUnit")]
    public string? UnshareIntervalUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsSchedule
{
    /// <summary>Specifies a snapshot archiving rule for a schedule. See archive_rule block.</summary>
    [JsonPropertyName("archiveRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleArchiveRule? ArchiveRule { get; set; }

    /// <summary>Indicates whether the policy should copy tags from the source resource to the snapshot or AMI. Default value is false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>See the create_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("createRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCreateRule? CreateRule { get; set; }

    /// <summary>See the cross_region_copy_rule block. Max of 3 per schedule.</summary>
    [JsonPropertyName("crossRegionCopyRule")]
    public IList<V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleCrossRegionCopyRule>? CrossRegionCopyRule { get; set; }

    /// <summary>See the deprecate_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("deprecateRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleDeprecateRule? DeprecateRule { get; set; }

    /// <summary>See the fast_restore_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("fastRestoreRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleFastRestoreRule? FastRestoreRule { get; set; }

    /// <summary>A descriptive name for the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the retention rule for cross-Region snapshot copies. See the retain_rule block. Max of 1 per action.</summary>
    [JsonPropertyName("retainRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleRetainRule? RetainRule { get; set; }

    /// <summary>See the share_rule block. Max of 1 per schedule.</summary>
    [JsonPropertyName("shareRule")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsScheduleShareRule? ShareRule { get; set; }

    /// <summary>A map of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.</summary>
    [JsonPropertyName("tagsToAdd")]
    public IDictionary<string, string>? TagsToAdd { get; set; }

    /// <summary>A map of tag keys and variable values, where the values are determined when the policy is executed. Only $(instance-id) or $(timestamp) are valid values. Can only be used when resource_types is INSTANCE.</summary>
    [JsonPropertyName("variableTags")]
    public IDictionary<string, string>? VariableTags { get; set; }
}

/// <summary>See the policy_details configuration block. Max of 1.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProviderPolicyDetails
{
    /// <summary>The actions to be performed when the event-based policy is triggered. You can specify only one action per policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the action configuration block.</summary>
    [JsonPropertyName("action")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsAction? Action { get; set; }

    /// <summary>Indicates whether the policy should copy tags from the source resource to the snapshot or AMI. Default value is false.</summary>
    [JsonPropertyName("copyTags")]
    public bool? CopyTags { get; set; }

    /// <summary>How often the policy should run and create snapshots or AMIs. valid values range from 1 to 7. Default value is 1.</summary>
    [JsonPropertyName("createInterval")]
    public double? CreateInterval { get; set; }

    /// <summary>The event that triggers the event-based policy. This parameter is required for event-based policies only. If you are creating a snapshot or AMI policy, omit this parameter. See the event_source configuration block.</summary>
    [JsonPropertyName("eventSource")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsEventSource? EventSource { get; set; }

    /// <summary>Specifies exclusion parameters for volumes or instances for which you do not want to create snapshots or AMIs.  See the exclusions configuration block.</summary>
    [JsonPropertyName("exclusions")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsExclusions? Exclusions { get; set; }

    /// <summary>snapshot or AMI retention behavior for the policy if the source volume or instance is deleted, or if the policy enters the error, disabled, or deleted state. Default value is false.</summary>
    [JsonPropertyName("extendDeletion")]
    public bool? ExtendDeletion { get; set; }

    /// <summary>A set of optional parameters for snapshot and AMI lifecycle policies. See the parameters configuration block.</summary>
    [JsonPropertyName("parameters")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsParameters? Parameters { get; set; }

    /// <summary>Type of policy to create. SIMPLIFIED To create a default policy. STANDARD To create a custom policy.</summary>
    [JsonPropertyName("policyLanguage")]
    public string? PolicyLanguage { get; set; }

    /// <summary>The valid target resource types and actions a policy can manage. Specify EBS_SNAPSHOT_MANAGEMENT to create a lifecycle policy that manages the lifecycle of Amazon EBS snapshots. Specify IMAGE_MANAGEMENT to create a lifecycle policy that manages the lifecycle of EBS-backed AMIs. Specify EVENT_BASED_POLICY to create an event-based policy that performs specific actions when a defined event occurs in your AWS account. Default value is EBS_SNAPSHOT_MANAGEMENT.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>The location of the resources to backup. If the source resources are located in an AWS Region, specify CLOUD. If the source resources are located on an Outpost in your account, specify OUTPOST. If the source resources are located in a Local Zone, specify LOCAL_ZONE. Valid values are CLOUD, LOCAL_ZONE, and OUTPOST.</summary>
    [JsonPropertyName("resourceLocations")]
    public IList<string>? ResourceLocations { get; set; }

    /// <summary>Type of default policy to create. Valid values are VOLUME and INSTANCE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A list of resource types that should be targeted by the lifecycle policy. Valid values are VOLUME and INSTANCE.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>Specifies how long the policy should retain snapshots or AMIs before deleting them. valid values range from 2 to 14. Default value is 7.</summary>
    [JsonPropertyName("retainInterval")]
    public double? RetainInterval { get; set; }

    /// <summary>See the schedule configuration block.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta2LifecyclePolicyStatusAtProviderPolicyDetailsSchedule>? Schedule { get; set; }

    /// <summary>A map of tag keys and their values. Any resources that match the resource_types and are tagged with any of these tags will be targeted. Required when policy_type is EBS_SNAPSHOT_MANAGEMENT or IMAGE_MANAGEMENT. Must not be specified when policy_type is EVENT_BASED_POLICY.</summary>
    [JsonPropertyName("targetTags")]
    public IDictionary<string, string>? TargetTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the DLM Lifecycle Policy.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specify the type of default policy to create. valid values are VOLUME or INSTANCE.</summary>
    [JsonPropertyName("defaultPolicy")]
    public string? DefaultPolicy { get; set; }

    /// <summary>A description for the DLM lifecycle policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ARN of an IAM role that is able to be assumed by the DLM service.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Identifier of the DLM Lifecycle Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>See the policy_details configuration block. Max of 1.</summary>
    [JsonPropertyName("policyDetails")]
    public V1beta2LifecyclePolicyStatusAtProviderPolicyDetails? PolicyDetails { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Whether the lifecycle policy should be enabled or disabled. ENABLED or DISABLED are valid values. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatusConditions
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

/// <summary>LifecyclePolicyStatus defines the observed state of LifecyclePolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LifecyclePolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2LifecyclePolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2LifecyclePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LifecyclePolicy is the Schema for the LifecyclePolicys API. Provides a Data Lifecycle Manager (DLM) lifecycle policy for managing snapshots.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LifecyclePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2LifecyclePolicySpec>, IStatus<V1beta2LifecyclePolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LifecyclePolicy";
    public const string KubeGroup = "dlm.aws.upbound.io";
    public const string KubePluralName = "lifecyclepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dlm.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LifecyclePolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LifecyclePolicySpec defines the desired state of LifecyclePolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2LifecyclePolicySpec Spec { get; set; }

    /// <summary>LifecyclePolicyStatus defines the observed state of LifecyclePolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2LifecyclePolicyStatus? Status { get; set; }
}