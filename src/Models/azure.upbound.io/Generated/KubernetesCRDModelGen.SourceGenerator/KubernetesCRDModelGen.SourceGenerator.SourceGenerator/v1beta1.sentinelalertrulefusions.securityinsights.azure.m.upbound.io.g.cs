#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.securityinsights.azure.m.upbound.io;
/// <summary>SentinelAlertRuleFusion is the Schema for the SentinelAlertRuleFusions API. Manages a Sentinel Fusion Alert Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SentinelAlertRuleFusionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SentinelAlertRuleFusion>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SentinelAlertRuleFusionList";
    public const string KubeGroup = "securityinsights.azure.m.upbound.io";
    public const string KubePluralName = "sentinelalertrulefusions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "securityinsights.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SentinelAlertRuleFusionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1SentinelAlertRuleFusion objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1SentinelAlertRuleFusion> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum>))]
public enum V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum>))]
public enum V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum>))]
public enum V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecForProviderSourceSubType
{
    /// <summary>Whether this source subtype under source signal is enabled or disabled in Fusion detection. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Name of the source subtype under a given source signal in Fusion detection. Refer to Fusion alert rule template for supported values.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of severities that are enabled for this source subtype consumed in Fusion detection. Possible values for each element are High, Medium, Low, Informational.</summary>
    [JsonPropertyName("severitiesAllowed")]
    public IList<string>? SeveritiesAllowed { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecForProviderSource
{
    /// <summary>Whether this source signal is enabled or disabled in Fusion detection? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Fusion source signal. Refer to Fusion alert rule template for supported values.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more sub_type blocks as defined below.</summary>
    [JsonPropertyName("subType")]
    public IList<V1beta1SentinelAlertRuleFusionSpecForProviderSourceSubType>? SubType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecForProvider
{
    /// <summary>The GUID of the alert rule template which is used for this Sentinel Fusion Alert Rule. Changing this forces a new Sentinel Fusion Alert Rule to be created.</summary>
    [JsonPropertyName("alertRuleTemplateGuid")]
    public string? AlertRuleTemplateGuid { get; set; }

    /// <summary>Should this Sentinel Fusion Alert Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the Log Analytics Workspace this Sentinel Fusion Alert Rule belongs to. Changing this forces a new Sentinel Fusion Alert Rule to be created.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Reference to a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdRef")]
    public V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdRef? LogAnalyticsWorkspaceIdRef { get; set; }

    /// <summary>Selector for a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdSelector")]
    public V1beta1SentinelAlertRuleFusionSpecForProviderLogAnalyticsWorkspaceIdSelector? LogAnalyticsWorkspaceIdSelector { get; set; }

    /// <summary>The Name of the source subtype under a given source signal in Fusion detection. Refer to Fusion alert rule template for supported values.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more source blocks as defined below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1SentinelAlertRuleFusionSpecForProviderSource>? Source { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum>))]
public enum V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum>))]
public enum V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum>))]
public enum V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecInitProviderSourceSubType
{
    /// <summary>Whether this source subtype under source signal is enabled or disabled in Fusion detection. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Name of the source subtype under a given source signal in Fusion detection. Refer to Fusion alert rule template for supported values.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of severities that are enabled for this source subtype consumed in Fusion detection. Possible values for each element are High, Medium, Low, Informational.</summary>
    [JsonPropertyName("severitiesAllowed")]
    public IList<string>? SeveritiesAllowed { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpecInitProviderSource
{
    /// <summary>Whether this source signal is enabled or disabled in Fusion detection? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Fusion source signal. Refer to Fusion alert rule template for supported values.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more sub_type blocks as defined below.</summary>
    [JsonPropertyName("subType")]
    public IList<V1beta1SentinelAlertRuleFusionSpecInitProviderSourceSubType>? SubType { get; set; }
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
public partial class V1beta1SentinelAlertRuleFusionSpecInitProvider
{
    /// <summary>The GUID of the alert rule template which is used for this Sentinel Fusion Alert Rule. Changing this forces a new Sentinel Fusion Alert Rule to be created.</summary>
    [JsonPropertyName("alertRuleTemplateGuid")]
    public string? AlertRuleTemplateGuid { get; set; }

    /// <summary>Should this Sentinel Fusion Alert Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the Log Analytics Workspace this Sentinel Fusion Alert Rule belongs to. Changing this forces a new Sentinel Fusion Alert Rule to be created.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Reference to a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdRef")]
    public V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdRef? LogAnalyticsWorkspaceIdRef { get; set; }

    /// <summary>Selector for a SentinelLogAnalyticsWorkspaceOnboarding in securityinsights to populate logAnalyticsWorkspaceId.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceIdSelector")]
    public V1beta1SentinelAlertRuleFusionSpecInitProviderLogAnalyticsWorkspaceIdSelector? LogAnalyticsWorkspaceIdSelector { get; set; }

    /// <summary>The Name of the source subtype under a given source signal in Fusion detection. Refer to Fusion alert rule template for supported values.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more source blocks as defined below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1SentinelAlertRuleFusionSpecInitProviderSource>? Source { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SentinelAlertRuleFusionSpecManagementPoliciesEnum>))]
public enum V1beta1SentinelAlertRuleFusionSpecManagementPoliciesEnum
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
public partial class V1beta1SentinelAlertRuleFusionSpecProviderConfigRef
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
public partial class V1beta1SentinelAlertRuleFusionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SentinelAlertRuleFusionSpec defines the desired state of SentinelAlertRuleFusion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1SentinelAlertRuleFusionSpecForProvider ForProvider { get; set; }

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
    public V1beta1SentinelAlertRuleFusionSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SentinelAlertRuleFusionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SentinelAlertRuleFusionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SentinelAlertRuleFusionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionStatusAtProviderSourceSubType
{
    /// <summary>Whether this source subtype under source signal is enabled or disabled in Fusion detection. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Name of the source subtype under a given source signal in Fusion detection. Refer to Fusion alert rule template for supported values.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of severities that are enabled for this source subtype consumed in Fusion detection. Possible values for each element are High, Medium, Low, Informational.</summary>
    [JsonPropertyName("severitiesAllowed")]
    public IList<string>? SeveritiesAllowed { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionStatusAtProviderSource
{
    /// <summary>Whether this source signal is enabled or disabled in Fusion detection? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Fusion source signal. Refer to Fusion alert rule template for supported values.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more sub_type blocks as defined below.</summary>
    [JsonPropertyName("subType")]
    public IList<V1beta1SentinelAlertRuleFusionStatusAtProviderSourceSubType>? SubType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionStatusAtProvider
{
    /// <summary>The GUID of the alert rule template which is used for this Sentinel Fusion Alert Rule. Changing this forces a new Sentinel Fusion Alert Rule to be created.</summary>
    [JsonPropertyName("alertRuleTemplateGuid")]
    public string? AlertRuleTemplateGuid { get; set; }

    /// <summary>Should this Sentinel Fusion Alert Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the Sentinel Fusion Alert Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Log Analytics Workspace this Sentinel Fusion Alert Rule belongs to. Changing this forces a new Sentinel Fusion Alert Rule to be created.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>The Name of the source subtype under a given source signal in Fusion detection. Refer to Fusion alert rule template for supported values.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more source blocks as defined below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1SentinelAlertRuleFusionStatusAtProviderSource>? Source { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionStatusConditions
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

/// <summary>SentinelAlertRuleFusionStatus defines the observed state of SentinelAlertRuleFusion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SentinelAlertRuleFusionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1SentinelAlertRuleFusionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SentinelAlertRuleFusionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SentinelAlertRuleFusion is the Schema for the SentinelAlertRuleFusions API. Manages a Sentinel Fusion Alert Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SentinelAlertRuleFusion : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SentinelAlertRuleFusionSpec>, IStatus<V1beta1SentinelAlertRuleFusionStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SentinelAlertRuleFusion";
    public const string KubeGroup = "securityinsights.azure.m.upbound.io";
    public const string KubePluralName = "sentinelalertrulefusions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "securityinsights.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SentinelAlertRuleFusion";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SentinelAlertRuleFusionSpec defines the desired state of SentinelAlertRuleFusion</summary>
    [JsonPropertyName("spec")]
    public required V1beta1SentinelAlertRuleFusionSpec Spec { get; set; }

    /// <summary>SentinelAlertRuleFusionStatus defines the observed state of SentinelAlertRuleFusion.</summary>
    [JsonPropertyName("status")]
    public V1beta1SentinelAlertRuleFusionStatus? Status { get; set; }
}