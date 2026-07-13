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
/// <summary>
/// MonitorAlertProcessingRuleActionGroup is the Schema for the MonitorAlertProcessingRuleActionGroups API. Manages an Alert Processing Rule which apply action group.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MonitorAlertProcessingRuleActionGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorAlertProcessingRuleActionGroupList";
    public const string KubeGroup = "alertsmanagement.azure.upbound.io";
    public const string KubePluralName = "monitoralertprocessingruleactiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alertsmanagement.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorAlertProcessingRuleActionGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MonitorAlertProcessingRuleActionGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MonitorAlertProcessingRuleActionGroup> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefsPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefsPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of MonitorActionGroup in insights to populate addActionGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelector
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
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionAlertRuleName
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionMonitorCondition
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionSignalType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionTargetResource
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionTargetResourceGroup
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderCondition
{
    /// <summary>A alert_context block as defined above.</summary>
    [JsonPropertyName("alertContext")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionAlertContext>? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined above.</summary>
    [JsonPropertyName("alertRuleId")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionAlertRuleId>? AlertRuleId { get; set; }

    /// <summary>A alert_rule_name block as defined above.</summary>
    [JsonPropertyName("alertRuleName")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionAlertRuleName>? AlertRuleName { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionDescription>? Description { get; set; }

    /// <summary>A monitor_condition block as defined below.</summary>
    [JsonPropertyName("monitorCondition")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionMonitorCondition>? MonitorCondition { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionMonitorService>? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionSeverity>? Severity { get; set; }

    /// <summary>A signal_type block as defined below.</summary>
    [JsonPropertyName("signalType")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionSignalType>? SignalType { get; set; }

    /// <summary>A target_resource block as defined below.</summary>
    [JsonPropertyName("targetResource")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionTargetResource>? TargetResource { get; set; }

    /// <summary>A target_resource_group block as defined below.</summary>
    [JsonPropertyName("targetResourceGroup")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionTargetResourceGroup>? TargetResourceGroup { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderConditionTargetResourceType>? TargetResourceType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelector
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
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScheduleRecurrenceDaily
{
    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScheduleRecurrenceMonthly
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScheduleRecurrenceWeekly
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScheduleRecurrence
{
    /// <summary>One or more daily blocks as defined above.</summary>
    [JsonPropertyName("daily")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScheduleRecurrenceDaily>? Daily { get; set; }

    /// <summary>One or more monthly blocks as defined above.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScheduleRecurrenceMonthly>? Monthly { get; set; }

    /// <summary>One or more weekly blocks as defined below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScheduleRecurrenceWeekly>? Weekly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderSchedule
{
    /// <summary>Specifies the Alert Processing Rule effective start time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }

    /// <summary>Specifies the Alert Processing Rule effective end time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>A recurrence block as defined above.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScheduleRecurrence>? Recurrence { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefsPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefsPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelector
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
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecForProvider
{
    /// <summary>Specifies a list of Action Group IDs.</summary>
    [JsonPropertyName("addActionGroupIds")]
    public IList<string>? AddActionGroupIds { get; set; }

    /// <summary>References to MonitorActionGroup in insights to populate addActionGroupIds.</summary>
    [JsonPropertyName("addActionGroupIdsRefs")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsRefs>? AddActionGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of MonitorActionGroup in insights to populate addActionGroupIds.</summary>
    [JsonPropertyName("addActionGroupIdsSelector")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderAddActionGroupIdsSelector? AddActionGroupIdsSelector { get; set; }

    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderCondition>? Condition { get; set; }

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
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderSchedule>? Schedule { get; set; }

    /// <summary>A list of resource IDs which will be the target of alert processing rule.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecForProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Alert Processing Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefsPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefsPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of MonitorActionGroup in insights to populate addActionGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelector
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
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionAlertRuleName
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionMonitorCondition
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionSignalType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionTargetResource
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionTargetResourceGroup
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderCondition
{
    /// <summary>A alert_context block as defined above.</summary>
    [JsonPropertyName("alertContext")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionAlertContext>? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined above.</summary>
    [JsonPropertyName("alertRuleId")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionAlertRuleId>? AlertRuleId { get; set; }

    /// <summary>A alert_rule_name block as defined above.</summary>
    [JsonPropertyName("alertRuleName")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionAlertRuleName>? AlertRuleName { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionDescription>? Description { get; set; }

    /// <summary>A monitor_condition block as defined below.</summary>
    [JsonPropertyName("monitorCondition")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionMonitorCondition>? MonitorCondition { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionMonitorService>? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionSeverity>? Severity { get; set; }

    /// <summary>A signal_type block as defined below.</summary>
    [JsonPropertyName("signalType")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionSignalType>? SignalType { get; set; }

    /// <summary>A target_resource block as defined below.</summary>
    [JsonPropertyName("targetResource")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionTargetResource>? TargetResource { get; set; }

    /// <summary>A target_resource_group block as defined below.</summary>
    [JsonPropertyName("targetResourceGroup")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionTargetResourceGroup>? TargetResourceGroup { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderConditionTargetResourceType>? TargetResourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScheduleRecurrenceDaily
{
    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScheduleRecurrenceMonthly
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScheduleRecurrenceWeekly
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScheduleRecurrence
{
    /// <summary>One or more daily blocks as defined above.</summary>
    [JsonPropertyName("daily")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScheduleRecurrenceDaily>? Daily { get; set; }

    /// <summary>One or more monthly blocks as defined above.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScheduleRecurrenceMonthly>? Monthly { get; set; }

    /// <summary>One or more weekly blocks as defined below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScheduleRecurrenceWeekly>? Weekly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderSchedule
{
    /// <summary>Specifies the Alert Processing Rule effective start time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }

    /// <summary>Specifies the Alert Processing Rule effective end time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>A recurrence block as defined above.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScheduleRecurrence>? Recurrence { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefsPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefsPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelector
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
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelectorPolicy? Policy { get; set; }
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProvider
{
    /// <summary>Specifies a list of Action Group IDs.</summary>
    [JsonPropertyName("addActionGroupIds")]
    public IList<string>? AddActionGroupIds { get; set; }

    /// <summary>References to MonitorActionGroup in insights to populate addActionGroupIds.</summary>
    [JsonPropertyName("addActionGroupIdsRefs")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsRefs>? AddActionGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of MonitorActionGroup in insights to populate addActionGroupIds.</summary>
    [JsonPropertyName("addActionGroupIdsSelector")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderAddActionGroupIdsSelector? AddActionGroupIdsSelector { get; set; }

    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderCondition>? Condition { get; set; }

    /// <summary>Specifies a description for the Alert Processing Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the Alert Processing Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderSchedule>? Schedule { get; set; }

    /// <summary>A list of resource IDs which will be the target of alert processing rule.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Alert Processing Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MonitorAlertProcessingRuleActionGroupSpec defines the desired state of MonitorAlertProcessingRuleActionGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupSpec
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
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1MonitorAlertProcessingRuleActionGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorAlertProcessingRuleActionGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionAlertRuleName
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionMonitorCondition
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionSignalType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionTargetResource
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionTargetResourceGroup
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderCondition
{
    /// <summary>A alert_context block as defined above.</summary>
    [JsonPropertyName("alertContext")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionAlertContext>? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined above.</summary>
    [JsonPropertyName("alertRuleId")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionAlertRuleId>? AlertRuleId { get; set; }

    /// <summary>A alert_rule_name block as defined above.</summary>
    [JsonPropertyName("alertRuleName")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionAlertRuleName>? AlertRuleName { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionDescription>? Description { get; set; }

    /// <summary>A monitor_condition block as defined below.</summary>
    [JsonPropertyName("monitorCondition")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionMonitorCondition>? MonitorCondition { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionMonitorService>? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionSeverity>? Severity { get; set; }

    /// <summary>A signal_type block as defined below.</summary>
    [JsonPropertyName("signalType")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionSignalType>? SignalType { get; set; }

    /// <summary>A target_resource block as defined below.</summary>
    [JsonPropertyName("targetResource")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionTargetResource>? TargetResource { get; set; }

    /// <summary>A target_resource_group block as defined below.</summary>
    [JsonPropertyName("targetResourceGroup")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionTargetResourceGroup>? TargetResourceGroup { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderConditionTargetResourceType>? TargetResourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderScheduleRecurrenceDaily
{
    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderScheduleRecurrenceMonthly
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderScheduleRecurrenceWeekly
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderScheduleRecurrence
{
    /// <summary>One or more daily blocks as defined above.</summary>
    [JsonPropertyName("daily")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderScheduleRecurrenceDaily>? Daily { get; set; }

    /// <summary>One or more monthly blocks as defined above.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderScheduleRecurrenceMonthly>? Monthly { get; set; }

    /// <summary>One or more weekly blocks as defined below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderScheduleRecurrenceWeekly>? Weekly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderSchedule
{
    /// <summary>Specifies the Alert Processing Rule effective start time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }

    /// <summary>Specifies the Alert Processing Rule effective end time (Y-m-d&apos;T&apos;H:M:S).</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>A recurrence block as defined above.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderScheduleRecurrence>? Recurrence { get; set; }

    /// <summary>The time zone (e.g. Pacific Standard time, Eastern Standard Time). Defaults to UTC. possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProvider
{
    /// <summary>Specifies a list of Action Group IDs.</summary>
    [JsonPropertyName("addActionGroupIds")]
    public IList<string>? AddActionGroupIds { get; set; }

    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderCondition>? Condition { get; set; }

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
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProviderSchedule>? Schedule { get; set; }

    /// <summary>A list of resource IDs which will be the target of alert processing rule.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Alert Processing Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatusConditions
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

/// <summary>MonitorAlertProcessingRuleActionGroupStatus defines the observed state of MonitorAlertProcessingRuleActionGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1MonitorAlertProcessingRuleActionGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorAlertProcessingRuleActionGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorAlertProcessingRuleActionGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// MonitorAlertProcessingRuleActionGroup is the Schema for the MonitorAlertProcessingRuleActionGroups API. Manages an Alert Processing Rule which apply action group.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorAlertProcessingRuleActionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorAlertProcessingRuleActionGroupSpec>, IStatus<V1beta1MonitorAlertProcessingRuleActionGroupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorAlertProcessingRuleActionGroup";
    public const string KubeGroup = "alertsmanagement.azure.upbound.io";
    public const string KubePluralName = "monitoralertprocessingruleactiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "alertsmanagement.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorAlertProcessingRuleActionGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorAlertProcessingRuleActionGroupSpec defines the desired state of MonitorAlertProcessingRuleActionGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MonitorAlertProcessingRuleActionGroupSpec Spec { get; set; }

    /// <summary>MonitorAlertProcessingRuleActionGroupStatus defines the observed state of MonitorAlertProcessingRuleActionGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorAlertProcessingRuleActionGroupStatus? Status { get; set; }
}