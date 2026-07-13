#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alertsmanagement.azure.upbound.io;
/// <summary>MonitorAlertProcessingRuleSuppression is the Schema for the MonitorAlertProcessingRuleSuppressions API. Manages an Alert Processing Rule which suppress notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2MonitorAlertProcessingRuleSuppression>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorAlertProcessingRuleSuppressionList";
    public const string KubeGroup = "alertsmanagement.azure.upbound.io";
    public const string KubePluralName = "monitoralertprocessingrulesuppressions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alertsmanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorAlertProcessingRuleSuppressionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2MonitorAlertProcessingRuleSuppression objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2MonitorAlertProcessingRuleSuppression> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecDeletionPolicyEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A alert_context block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_id block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_name block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertRuleName
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A description block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionMonitorCondition
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A severity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A signal_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionSignalType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResource
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_group block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResourceGroup
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderCondition
{
    /// <summary>A alert_context block as defined above.</summary>
    [JsonPropertyName("alertContext")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertContext? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined above.</summary>
    [JsonPropertyName("alertRuleId")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertRuleId? AlertRuleId { get; set; }

    /// <summary>A alert_rule_name block as defined above.</summary>
    [JsonPropertyName("alertRuleName")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertRuleName? AlertRuleName { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionDescription? Description { get; set; }

    /// <summary>A monitor_condition block as defined below.</summary>
    [JsonPropertyName("monitorCondition")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionMonitorCondition? MonitorCondition { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionMonitorService? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionSeverity? Severity { get; set; }

    /// <summary>A signal_type block as defined below.</summary>
    [JsonPropertyName("signalType")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionSignalType? SignalType { get; set; }

    /// <summary>A target_resource block as defined below.</summary>
    [JsonPropertyName("targetResource")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResource? TargetResource { get; set; }

    /// <summary>A target_resource_group block as defined below.</summary>
    [JsonPropertyName("targetResourceGroup")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResourceGroup? TargetResourceGroup { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResourceType? TargetResourceType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelector
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
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceDaily
{
    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceMonthly
{
    /// <summary>Specifies a list of dayOfMonth to recurrence. Possible values are integers between 1 - 31.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceWeekly
{
    /// <summary>Specifies a list of dayOfWeek to recurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>A recurrence block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrence
{
    /// <summary>One or more daily blocks as defined above.</summary>
    [JsonPropertyName("daily")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceDaily>? Daily { get; set; }

    /// <summary>One or more monthly blocks as defined above.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceMonthly>? Monthly { get; set; }

    /// <summary>One or more weekly blocks as defined below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceWeekly>? Weekly { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderSchedule
{
    /// <summary>Specifies the Alert Processing Rule effective start time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }

    /// <summary>Specifies the Alert Processing Rule effective end time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>A recurrence block as defined above.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrence? Recurrence { get; set; }

    /// <summary>The time zone (e.g. Pacific Standard time, Eastern Standard Time). Defaults to UTC. possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicyResolutionEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicyResolveEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelector
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
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecForProvider
{
    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderCondition? Condition { get; set; }

    /// <summary>Specifies a description for the Alert Processing Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the Alert Processing Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Resource Group where the Alert Processing Rule should exist. Changing this forces a new Alert Processing Rule to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>A list of resource IDs which will be the target of Alert Processing Rule.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Alert Processing Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A alert_context block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_id block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_name block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertRuleName
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A description block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionMonitorCondition
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A severity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A signal_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionSignalType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResource
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_group block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResourceGroup
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderCondition
{
    /// <summary>A alert_context block as defined above.</summary>
    [JsonPropertyName("alertContext")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertContext? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined above.</summary>
    [JsonPropertyName("alertRuleId")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertRuleId? AlertRuleId { get; set; }

    /// <summary>A alert_rule_name block as defined above.</summary>
    [JsonPropertyName("alertRuleName")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertRuleName? AlertRuleName { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionDescription? Description { get; set; }

    /// <summary>A monitor_condition block as defined below.</summary>
    [JsonPropertyName("monitorCondition")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionMonitorCondition? MonitorCondition { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionMonitorService? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionSeverity? Severity { get; set; }

    /// <summary>A signal_type block as defined below.</summary>
    [JsonPropertyName("signalType")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionSignalType? SignalType { get; set; }

    /// <summary>A target_resource block as defined below.</summary>
    [JsonPropertyName("targetResource")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResource? TargetResource { get; set; }

    /// <summary>A target_resource_group block as defined below.</summary>
    [JsonPropertyName("targetResourceGroup")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResourceGroup? TargetResourceGroup { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResourceType? TargetResourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceDaily
{
    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceMonthly
{
    /// <summary>Specifies a list of dayOfMonth to recurrence. Possible values are integers between 1 - 31.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceWeekly
{
    /// <summary>Specifies a list of dayOfWeek to recurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>A recurrence block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrence
{
    /// <summary>One or more daily blocks as defined above.</summary>
    [JsonPropertyName("daily")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceDaily>? Daily { get; set; }

    /// <summary>One or more monthly blocks as defined above.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceMonthly>? Monthly { get; set; }

    /// <summary>One or more weekly blocks as defined below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceWeekly>? Weekly { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderSchedule
{
    /// <summary>Specifies the Alert Processing Rule effective start time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }

    /// <summary>Specifies the Alert Processing Rule effective end time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>A recurrence block as defined above.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrence? Recurrence { get; set; }

    /// <summary>The time zone (e.g. Pacific Standard time, Eastern Standard Time). Defaults to UTC. possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicyResolutionEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicyResolveEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelector
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
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProvider
{
    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderCondition? Condition { get; set; }

    /// <summary>Specifies a description for the Alert Processing Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the Alert Processing Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>A list of resource IDs which will be the target of Alert Processing Rule.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Alert Processing Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecManagementPoliciesEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MonitorAlertProcessingRuleSuppressionSpec defines the desired state of MonitorAlertProcessingRuleSuppression</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionSpec
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
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2MonitorAlertProcessingRuleSuppressionSpecForProvider ForProvider { get; set; }

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
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2MonitorAlertProcessingRuleSuppressionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A alert_context block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_id block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_name block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertRuleName
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A description block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionMonitorCondition
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A severity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A signal_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionSignalType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResource
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_group block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResourceGroup
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderCondition
{
    /// <summary>A alert_context block as defined above.</summary>
    [JsonPropertyName("alertContext")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertContext? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined above.</summary>
    [JsonPropertyName("alertRuleId")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertRuleId? AlertRuleId { get; set; }

    /// <summary>A alert_rule_name block as defined above.</summary>
    [JsonPropertyName("alertRuleName")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertRuleName? AlertRuleName { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionDescription? Description { get; set; }

    /// <summary>A monitor_condition block as defined below.</summary>
    [JsonPropertyName("monitorCondition")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionMonitorCondition? MonitorCondition { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionMonitorService? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionSeverity? Severity { get; set; }

    /// <summary>A signal_type block as defined below.</summary>
    [JsonPropertyName("signalType")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionSignalType? SignalType { get; set; }

    /// <summary>A target_resource block as defined below.</summary>
    [JsonPropertyName("targetResource")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResource? TargetResource { get; set; }

    /// <summary>A target_resource_group block as defined below.</summary>
    [JsonPropertyName("targetResourceGroup")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResourceGroup? TargetResourceGroup { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResourceType? TargetResourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceDaily
{
    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceMonthly
{
    /// <summary>Specifies a list of dayOfMonth to recurrence. Possible values are integers between 1 - 31.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceWeekly
{
    /// <summary>Specifies a list of dayOfWeek to recurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>A recurrence block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrence
{
    /// <summary>One or more daily blocks as defined above.</summary>
    [JsonPropertyName("daily")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceDaily>? Daily { get; set; }

    /// <summary>One or more monthly blocks as defined above.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceMonthly>? Monthly { get; set; }

    /// <summary>One or more weekly blocks as defined below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceWeekly>? Weekly { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderSchedule
{
    /// <summary>Specifies the Alert Processing Rule effective start time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }

    /// <summary>Specifies the Alert Processing Rule effective end time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>A recurrence block as defined above.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrence? Recurrence { get; set; }

    /// <summary>The time zone (e.g. Pacific Standard time, Eastern Standard Time). Defaults to UTC. possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProvider
{
    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderCondition? Condition { get; set; }

    /// <summary>Specifies a description for the Alert Processing Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the Alert Processing Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the Alert Processing Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Resource Group where the Alert Processing Rule should exist. Changing this forces a new Alert Processing Rule to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>A list of resource IDs which will be the target of Alert Processing Rule.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Alert Processing Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatusConditions
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

/// <summary>MonitorAlertProcessingRuleSuppressionStatus defines the observed state of MonitorAlertProcessingRuleSuppression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorAlertProcessingRuleSuppressionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2MonitorAlertProcessingRuleSuppressionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorAlertProcessingRuleSuppression is the Schema for the MonitorAlertProcessingRuleSuppressions API. Manages an Alert Processing Rule which suppress notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorAlertProcessingRuleSuppression : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2MonitorAlertProcessingRuleSuppressionSpec>, IStatus<V1beta2MonitorAlertProcessingRuleSuppressionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorAlertProcessingRuleSuppression";
    public const string KubeGroup = "alertsmanagement.azure.upbound.io";
    public const string KubePluralName = "monitoralertprocessingrulesuppressions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alertsmanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorAlertProcessingRuleSuppression";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorAlertProcessingRuleSuppressionSpec defines the desired state of MonitorAlertProcessingRuleSuppression</summary>
    [JsonPropertyName("spec")]
    public required V1beta2MonitorAlertProcessingRuleSuppressionSpec Spec { get; set; }

    /// <summary>MonitorAlertProcessingRuleSuppressionStatus defines the observed state of MonitorAlertProcessingRuleSuppression.</summary>
    [JsonPropertyName("status")]
    public V1beta2MonitorAlertProcessingRuleSuppressionStatus? Status { get; set; }
}