#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.modelarmor.gcp.m.upbound.io;
/// <summary>FloorSetting is the Schema for the FloorSettings API. Model Armor floor settings define rules that dictate minimum requirements for all Model Armor templates created at a specific point in the Google Cloud resource hierarchy (that is, at an organization, folder, or project level).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FloorSettingList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FloorSetting>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FloorSettingList";
    public const string KubeGroup = "modelarmor.gcp.m.upbound.io";
    public const string KubePluralName = "floorsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "modelarmor.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FloorSettingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1FloorSetting objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1FloorSetting> Items { get; set; }
}

/// <summary>
/// AI Platform floor setting.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderAiPlatformFloorSetting
{
    /// <summary>If true, log Model Armor filter results to Cloud Logging.</summary>
    [JsonPropertyName("enableCloudLogging")]
    public bool? EnableCloudLogging { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect and block mode.
    /// Requests that trip Model Armor filters will be blocked.
    /// </summary>
    [JsonPropertyName("inspectAndBlock")]
    public bool? InspectAndBlock { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect only mode. No action
    /// will be taken on the request.
    /// </summary>
    [JsonPropertyName("inspectOnly")]
    public bool? InspectOnly { get; set; }
}

/// <summary>
/// Malicious URI filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigMaliciousUriFilterSettings
{
    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

/// <summary>
/// Prompt injection and Jailbreak Filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigPiAndJailbreakFilterSettings
{
    /// <summary>
    /// Possible values:
    /// LOW_AND_ABOVE
    /// MEDIUM_AND_ABOVE
    /// HIGH
    /// </summary>
    [JsonPropertyName("confidenceLevel")]
    public string? ConfidenceLevel { get; set; }

    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigRaiSettingsRaiFilters
{
    /// <summary>
    /// Possible values:
    /// LOW_AND_ABOVE
    /// MEDIUM_AND_ABOVE
    /// HIGH
    /// </summary>
    [JsonPropertyName("confidenceLevel")]
    public string? ConfidenceLevel { get; set; }

    /// <summary>
    /// Possible values:
    /// SEXUALLY_EXPLICIT
    /// HATE_SPEECH
    /// HARASSMENT
    /// DANGEROUS
    /// </summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
}

/// <summary>
/// Responsible AI Filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigRaiSettings
{
    /// <summary>
    /// List of Responsible AI filters enabled for template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiFilters")]
    public IList<V1beta1FloorSettingSpecForProviderFilterConfigRaiSettingsRaiFilters>? RaiFilters { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum>))]
public enum V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum>))]
public enum V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelector
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
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum>))]
public enum V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum>))]
public enum V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelector
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
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Sensitive Data Protection Advanced configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfig
{
    /// <summary>
    /// Optional Sensitive Data Protection Deidentify template resource name.
    /// If provided then DeidentifyContent action is performed during Sanitization
    /// using this template and inspect template. The De-identified data will
    /// be returned in SdpDeidentifyResult.
    /// Note that all info-types present in the deidentify template must be present
    /// in inspect template.
    /// e.g.
    /// projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}
    /// </summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>Reference to a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
    [JsonPropertyName("deidentifyTemplateRef")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef? DeidentifyTemplateRef { get; set; }

    /// <summary>Selector for a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
    [JsonPropertyName("deidentifyTemplateSelector")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelector? DeidentifyTemplateSelector { get; set; }

    /// <summary>
    /// Sensitive Data Protection inspect template resource name
    /// If only inspect template is provided (de-identify template not provided),
    /// then Sensitive Data Protection InspectContent action is performed during
    /// Sanitization. All Sensitive Data Protection findings identified during
    /// inspection will be returned as SdpFinding in SdpInsepctionResult.
    /// e.g:-
    /// projects/{project}/locations/{location}/inspectTemplates/{inspect_template}
    /// </summary>
    [JsonPropertyName("inspectTemplate")]
    public string? InspectTemplate { get; set; }

    /// <summary>Reference to a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
    [JsonPropertyName("inspectTemplateRef")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef? InspectTemplateRef { get; set; }

    /// <summary>Selector for a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
    [JsonPropertyName("inspectTemplateSelector")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelector? InspectTemplateSelector { get; set; }
}

/// <summary>
/// Sensitive Data Protection basic configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsBasicConfig
{
    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

/// <summary>
/// Sensitive Data Protection settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfigSdpSettings
{
    /// <summary>
    /// Sensitive Data Protection Advanced configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedConfig")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsAdvancedConfig? AdvancedConfig { get; set; }

    /// <summary>
    /// Sensitive Data Protection basic configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicConfig")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettingsBasicConfig? BasicConfig { get; set; }
}

/// <summary>
/// Filters configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFilterConfig
{
    /// <summary>
    /// Malicious URI filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maliciousUriFilterSettings")]
    public V1beta1FloorSettingSpecForProviderFilterConfigMaliciousUriFilterSettings? MaliciousUriFilterSettings { get; set; }

    /// <summary>
    /// Prompt injection and Jailbreak Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("piAndJailbreakFilterSettings")]
    public V1beta1FloorSettingSpecForProviderFilterConfigPiAndJailbreakFilterSettings? PiAndJailbreakFilterSettings { get; set; }

    /// <summary>
    /// Responsible AI Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiSettings")]
    public V1beta1FloorSettingSpecForProviderFilterConfigRaiSettings? RaiSettings { get; set; }

    /// <summary>
    /// Sensitive Data Protection settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sdpSettings")]
    public V1beta1FloorSettingSpecForProviderFilterConfigSdpSettings? SdpSettings { get; set; }
}

/// <summary>
/// Metadata for multi language detection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFloorSettingMetadataMultiLanguageDetection
{
    /// <summary>If true, multi language detection will be enabled.</summary>
    [JsonPropertyName("enableMultiLanguageDetection")]
    public bool? EnableMultiLanguageDetection { get; set; }
}

/// <summary>
/// Metadata to enable multi language detection via floor setting.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProviderFloorSettingMetadata
{
    /// <summary>
    /// Metadata for multi language detection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("multiLanguageDetection")]
    public V1beta1FloorSettingSpecForProviderFloorSettingMetadataMultiLanguageDetection? MultiLanguageDetection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecForProvider
{
    /// <summary>
    /// AI Platform floor setting.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aiPlatformFloorSetting")]
    public V1beta1FloorSettingSpecForProviderAiPlatformFloorSetting? AiPlatformFloorSetting { get; set; }

    /// <summary>Floor Settings enforcement status.</summary>
    [JsonPropertyName("enableFloorSettingEnforcement")]
    public bool? EnableFloorSettingEnforcement { get; set; }

    /// <summary>
    /// Filters configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterConfig")]
    public V1beta1FloorSettingSpecForProviderFilterConfig? FilterConfig { get; set; }

    /// <summary>
    /// Metadata to enable multi language detection via floor setting.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("floorSettingMetadata")]
    public V1beta1FloorSettingSpecForProviderFloorSettingMetadata? FloorSettingMetadata { get; set; }

    /// <summary>List of integrated services for which the floor setting is applicable.</summary>
    [JsonPropertyName("integratedServices")]
    public IList<string>? IntegratedServices { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Will be any one of these:</summary>
    [JsonPropertyName("parent")]
    public required string Parent { get; set; }
}

/// <summary>
/// AI Platform floor setting.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderAiPlatformFloorSetting
{
    /// <summary>If true, log Model Armor filter results to Cloud Logging.</summary>
    [JsonPropertyName("enableCloudLogging")]
    public bool? EnableCloudLogging { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect and block mode.
    /// Requests that trip Model Armor filters will be blocked.
    /// </summary>
    [JsonPropertyName("inspectAndBlock")]
    public bool? InspectAndBlock { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect only mode. No action
    /// will be taken on the request.
    /// </summary>
    [JsonPropertyName("inspectOnly")]
    public bool? InspectOnly { get; set; }
}

/// <summary>
/// Malicious URI filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigMaliciousUriFilterSettings
{
    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

/// <summary>
/// Prompt injection and Jailbreak Filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigPiAndJailbreakFilterSettings
{
    /// <summary>
    /// Possible values:
    /// LOW_AND_ABOVE
    /// MEDIUM_AND_ABOVE
    /// HIGH
    /// </summary>
    [JsonPropertyName("confidenceLevel")]
    public string? ConfidenceLevel { get; set; }

    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigRaiSettingsRaiFilters
{
    /// <summary>
    /// Possible values:
    /// LOW_AND_ABOVE
    /// MEDIUM_AND_ABOVE
    /// HIGH
    /// </summary>
    [JsonPropertyName("confidenceLevel")]
    public string? ConfidenceLevel { get; set; }

    /// <summary>
    /// Possible values:
    /// SEXUALLY_EXPLICIT
    /// HATE_SPEECH
    /// HARASSMENT
    /// DANGEROUS
    /// </summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
}

/// <summary>
/// Responsible AI Filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigRaiSettings
{
    /// <summary>
    /// List of Responsible AI filters enabled for template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiFilters")]
    public IList<V1beta1FloorSettingSpecInitProviderFilterConfigRaiSettingsRaiFilters>? RaiFilters { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum>))]
public enum V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum>))]
public enum V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelector
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
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum>))]
public enum V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum>))]
public enum V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelector
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
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Sensitive Data Protection Advanced configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfig
{
    /// <summary>
    /// Optional Sensitive Data Protection Deidentify template resource name.
    /// If provided then DeidentifyContent action is performed during Sanitization
    /// using this template and inspect template. The De-identified data will
    /// be returned in SdpDeidentifyResult.
    /// Note that all info-types present in the deidentify template must be present
    /// in inspect template.
    /// e.g.
    /// projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}
    /// </summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>Reference to a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
    [JsonPropertyName("deidentifyTemplateRef")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef? DeidentifyTemplateRef { get; set; }

    /// <summary>Selector for a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
    [JsonPropertyName("deidentifyTemplateSelector")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelector? DeidentifyTemplateSelector { get; set; }

    /// <summary>
    /// Sensitive Data Protection inspect template resource name
    /// If only inspect template is provided (de-identify template not provided),
    /// then Sensitive Data Protection InspectContent action is performed during
    /// Sanitization. All Sensitive Data Protection findings identified during
    /// inspection will be returned as SdpFinding in SdpInsepctionResult.
    /// e.g:-
    /// projects/{project}/locations/{location}/inspectTemplates/{inspect_template}
    /// </summary>
    [JsonPropertyName("inspectTemplate")]
    public string? InspectTemplate { get; set; }

    /// <summary>Reference to a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
    [JsonPropertyName("inspectTemplateRef")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef? InspectTemplateRef { get; set; }

    /// <summary>Selector for a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
    [JsonPropertyName("inspectTemplateSelector")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelector? InspectTemplateSelector { get; set; }
}

/// <summary>
/// Sensitive Data Protection basic configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsBasicConfig
{
    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

/// <summary>
/// Sensitive Data Protection settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettings
{
    /// <summary>
    /// Sensitive Data Protection Advanced configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedConfig")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsAdvancedConfig? AdvancedConfig { get; set; }

    /// <summary>
    /// Sensitive Data Protection basic configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicConfig")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettingsBasicConfig? BasicConfig { get; set; }
}

/// <summary>
/// Filters configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFilterConfig
{
    /// <summary>
    /// Malicious URI filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maliciousUriFilterSettings")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigMaliciousUriFilterSettings? MaliciousUriFilterSettings { get; set; }

    /// <summary>
    /// Prompt injection and Jailbreak Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("piAndJailbreakFilterSettings")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigPiAndJailbreakFilterSettings? PiAndJailbreakFilterSettings { get; set; }

    /// <summary>
    /// Responsible AI Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiSettings")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigRaiSettings? RaiSettings { get; set; }

    /// <summary>
    /// Sensitive Data Protection settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sdpSettings")]
    public V1beta1FloorSettingSpecInitProviderFilterConfigSdpSettings? SdpSettings { get; set; }
}

/// <summary>
/// Metadata for multi language detection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFloorSettingMetadataMultiLanguageDetection
{
    /// <summary>If true, multi language detection will be enabled.</summary>
    [JsonPropertyName("enableMultiLanguageDetection")]
    public bool? EnableMultiLanguageDetection { get; set; }
}

/// <summary>
/// Metadata to enable multi language detection via floor setting.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpecInitProviderFloorSettingMetadata
{
    /// <summary>
    /// Metadata for multi language detection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("multiLanguageDetection")]
    public V1beta1FloorSettingSpecInitProviderFloorSettingMetadataMultiLanguageDetection? MultiLanguageDetection { get; set; }
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
public partial class V1beta1FloorSettingSpecInitProvider
{
    /// <summary>
    /// AI Platform floor setting.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aiPlatformFloorSetting")]
    public V1beta1FloorSettingSpecInitProviderAiPlatformFloorSetting? AiPlatformFloorSetting { get; set; }

    /// <summary>Floor Settings enforcement status.</summary>
    [JsonPropertyName("enableFloorSettingEnforcement")]
    public bool? EnableFloorSettingEnforcement { get; set; }

    /// <summary>
    /// Filters configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterConfig")]
    public V1beta1FloorSettingSpecInitProviderFilterConfig? FilterConfig { get; set; }

    /// <summary>
    /// Metadata to enable multi language detection via floor setting.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("floorSettingMetadata")]
    public V1beta1FloorSettingSpecInitProviderFloorSettingMetadata? FloorSettingMetadata { get; set; }

    /// <summary>List of integrated services for which the floor setting is applicable.</summary>
    [JsonPropertyName("integratedServices")]
    public IList<string>? IntegratedServices { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FloorSettingSpecManagementPoliciesEnum>))]
public enum V1beta1FloorSettingSpecManagementPoliciesEnum
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
public partial class V1beta1FloorSettingSpecProviderConfigRef
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
public partial class V1beta1FloorSettingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>FloorSettingSpec defines the desired state of FloorSetting</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1FloorSettingSpecForProvider ForProvider { get; set; }

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
    public V1beta1FloorSettingSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FloorSettingSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FloorSettingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FloorSettingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// AI Platform floor setting.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderAiPlatformFloorSetting
{
    /// <summary>If true, log Model Armor filter results to Cloud Logging.</summary>
    [JsonPropertyName("enableCloudLogging")]
    public bool? EnableCloudLogging { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect and block mode.
    /// Requests that trip Model Armor filters will be blocked.
    /// </summary>
    [JsonPropertyName("inspectAndBlock")]
    public bool? InspectAndBlock { get; set; }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect only mode. No action
    /// will be taken on the request.
    /// </summary>
    [JsonPropertyName("inspectOnly")]
    public bool? InspectOnly { get; set; }
}

/// <summary>
/// Malicious URI filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFilterConfigMaliciousUriFilterSettings
{
    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

/// <summary>
/// Prompt injection and Jailbreak Filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFilterConfigPiAndJailbreakFilterSettings
{
    /// <summary>
    /// Possible values:
    /// LOW_AND_ABOVE
    /// MEDIUM_AND_ABOVE
    /// HIGH
    /// </summary>
    [JsonPropertyName("confidenceLevel")]
    public string? ConfidenceLevel { get; set; }

    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFilterConfigRaiSettingsRaiFilters
{
    /// <summary>
    /// Possible values:
    /// LOW_AND_ABOVE
    /// MEDIUM_AND_ABOVE
    /// HIGH
    /// </summary>
    [JsonPropertyName("confidenceLevel")]
    public string? ConfidenceLevel { get; set; }

    /// <summary>
    /// Possible values:
    /// SEXUALLY_EXPLICIT
    /// HATE_SPEECH
    /// HARASSMENT
    /// DANGEROUS
    /// </summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
}

/// <summary>
/// Responsible AI Filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFilterConfigRaiSettings
{
    /// <summary>
    /// List of Responsible AI filters enabled for template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiFilters")]
    public IList<V1beta1FloorSettingStatusAtProviderFilterConfigRaiSettingsRaiFilters>? RaiFilters { get; set; }
}

/// <summary>
/// Sensitive Data Protection Advanced configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFilterConfigSdpSettingsAdvancedConfig
{
    /// <summary>
    /// Optional Sensitive Data Protection Deidentify template resource name.
    /// If provided then DeidentifyContent action is performed during Sanitization
    /// using this template and inspect template. The De-identified data will
    /// be returned in SdpDeidentifyResult.
    /// Note that all info-types present in the deidentify template must be present
    /// in inspect template.
    /// e.g.
    /// projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}
    /// </summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>
    /// Sensitive Data Protection inspect template resource name
    /// If only inspect template is provided (de-identify template not provided),
    /// then Sensitive Data Protection InspectContent action is performed during
    /// Sanitization. All Sensitive Data Protection findings identified during
    /// inspection will be returned as SdpFinding in SdpInsepctionResult.
    /// e.g:-
    /// projects/{project}/locations/{location}/inspectTemplates/{inspect_template}
    /// </summary>
    [JsonPropertyName("inspectTemplate")]
    public string? InspectTemplate { get; set; }
}

/// <summary>
/// Sensitive Data Protection basic configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFilterConfigSdpSettingsBasicConfig
{
    /// <summary>
    /// Tells whether Prompt injection and Jailbreak filter is enabled or
    /// disabled.
    /// Possible values:
    /// ENABLED
    /// DISABLED
    /// </summary>
    [JsonPropertyName("filterEnforcement")]
    public string? FilterEnforcement { get; set; }
}

/// <summary>
/// Sensitive Data Protection settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFilterConfigSdpSettings
{
    /// <summary>
    /// Sensitive Data Protection Advanced configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedConfig")]
    public V1beta1FloorSettingStatusAtProviderFilterConfigSdpSettingsAdvancedConfig? AdvancedConfig { get; set; }

    /// <summary>
    /// Sensitive Data Protection basic configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicConfig")]
    public V1beta1FloorSettingStatusAtProviderFilterConfigSdpSettingsBasicConfig? BasicConfig { get; set; }
}

/// <summary>
/// Filters configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFilterConfig
{
    /// <summary>
    /// Malicious URI filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maliciousUriFilterSettings")]
    public V1beta1FloorSettingStatusAtProviderFilterConfigMaliciousUriFilterSettings? MaliciousUriFilterSettings { get; set; }

    /// <summary>
    /// Prompt injection and Jailbreak Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("piAndJailbreakFilterSettings")]
    public V1beta1FloorSettingStatusAtProviderFilterConfigPiAndJailbreakFilterSettings? PiAndJailbreakFilterSettings { get; set; }

    /// <summary>
    /// Responsible AI Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiSettings")]
    public V1beta1FloorSettingStatusAtProviderFilterConfigRaiSettings? RaiSettings { get; set; }

    /// <summary>
    /// Sensitive Data Protection settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sdpSettings")]
    public V1beta1FloorSettingStatusAtProviderFilterConfigSdpSettings? SdpSettings { get; set; }
}

/// <summary>
/// Metadata for multi language detection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFloorSettingMetadataMultiLanguageDetection
{
    /// <summary>If true, multi language detection will be enabled.</summary>
    [JsonPropertyName("enableMultiLanguageDetection")]
    public bool? EnableMultiLanguageDetection { get; set; }
}

/// <summary>
/// Metadata to enable multi language detection via floor setting.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProviderFloorSettingMetadata
{
    /// <summary>
    /// Metadata for multi language detection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("multiLanguageDetection")]
    public V1beta1FloorSettingStatusAtProviderFloorSettingMetadataMultiLanguageDetection? MultiLanguageDetection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusAtProvider
{
    /// <summary>
    /// AI Platform floor setting.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aiPlatformFloorSetting")]
    public V1beta1FloorSettingStatusAtProviderAiPlatformFloorSetting? AiPlatformFloorSetting { get; set; }

    /// <summary>[Output only] Create timestamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Floor Settings enforcement status.</summary>
    [JsonPropertyName("enableFloorSettingEnforcement")]
    public bool? EnableFloorSettingEnforcement { get; set; }

    /// <summary>
    /// Filters configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterConfig")]
    public V1beta1FloorSettingStatusAtProviderFilterConfig? FilterConfig { get; set; }

    /// <summary>
    /// Metadata to enable multi language detection via floor setting.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("floorSettingMetadata")]
    public V1beta1FloorSettingStatusAtProviderFloorSettingMetadata? FloorSettingMetadata { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/locations/{{location}}/floorSetting</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of integrated services for which the floor setting is applicable.</summary>
    [JsonPropertyName("integratedServices")]
    public IList<string>? IntegratedServices { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Identifier. The resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Will be any one of these:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>[Output only] Update timestamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatusConditions
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

/// <summary>FloorSettingStatus defines the observed state of FloorSetting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FloorSettingStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1FloorSettingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FloorSettingStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FloorSetting is the Schema for the FloorSettings API. Model Armor floor settings define rules that dictate minimum requirements for all Model Armor templates created at a specific point in the Google Cloud resource hierarchy (that is, at an organization, folder, or project level).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FloorSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FloorSettingSpec>, IStatus<V1beta1FloorSettingStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FloorSetting";
    public const string KubeGroup = "modelarmor.gcp.m.upbound.io";
    public const string KubePluralName = "floorsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "modelarmor.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FloorSetting";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FloorSettingSpec defines the desired state of FloorSetting</summary>
    [JsonPropertyName("spec")]
    public required V1beta1FloorSettingSpec Spec { get; set; }

    /// <summary>FloorSettingStatus defines the observed state of FloorSetting.</summary>
    [JsonPropertyName("status")]
    public V1beta1FloorSettingStatus? Status { get; set; }
}