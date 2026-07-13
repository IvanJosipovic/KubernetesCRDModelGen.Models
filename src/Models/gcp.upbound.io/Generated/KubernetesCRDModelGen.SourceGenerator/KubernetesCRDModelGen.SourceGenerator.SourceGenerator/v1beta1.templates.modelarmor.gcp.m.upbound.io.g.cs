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
/// <summary>Template is the Schema for the Templates API. A `Template` is a resource of Model Armor that lets you configure how Model Armor screens prompts and responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Template>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TemplateList";
    public const string KubeGroup = "modelarmor.gcp.m.upbound.io";
    public const string KubePluralName = "templates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "modelarmor.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Template objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Template> Items { get; set; }
}

/// <summary>
/// Malicious URI filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigMaliciousUriFilterSettings
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
public partial class V1beta1TemplateSpecForProviderFilterConfigPiAndJailbreakFilterSettings
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
public partial class V1beta1TemplateSpecForProviderFilterConfigRaiSettingsRaiFilters
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
public partial class V1beta1TemplateSpecForProviderFilterConfigRaiSettings
{
    /// <summary>
    /// List of Responsible AI filters enabled for template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiFilters")]
    public IList<V1beta1TemplateSpecForProviderFilterConfigRaiSettingsRaiFilters>? RaiFilters { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum>))]
public enum V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum>))]
public enum V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelector
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
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum>))]
public enum V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum>))]
public enum V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelector
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
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Sensitive Data Protection Advanced configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfig
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
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef? DeidentifyTemplateRef { get; set; }

    /// <summary>Selector for a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
    [JsonPropertyName("deidentifyTemplateSelector")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelector? DeidentifyTemplateSelector { get; set; }

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
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef? InspectTemplateRef { get; set; }

    /// <summary>Selector for a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
    [JsonPropertyName("inspectTemplateSelector")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelector? InspectTemplateSelector { get; set; }
}

/// <summary>
/// Sensitive Data Protection basic configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettingsBasicConfig
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
public partial class V1beta1TemplateSpecForProviderFilterConfigSdpSettings
{
    /// <summary>
    /// Sensitive Data Protection Advanced configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedConfig")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsAdvancedConfig? AdvancedConfig { get; set; }

    /// <summary>
    /// Sensitive Data Protection basic configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicConfig")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettingsBasicConfig? BasicConfig { get; set; }
}

/// <summary>
/// Filters configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderFilterConfig
{
    /// <summary>
    /// Malicious URI filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maliciousUriFilterSettings")]
    public V1beta1TemplateSpecForProviderFilterConfigMaliciousUriFilterSettings? MaliciousUriFilterSettings { get; set; }

    /// <summary>
    /// Prompt injection and Jailbreak Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("piAndJailbreakFilterSettings")]
    public V1beta1TemplateSpecForProviderFilterConfigPiAndJailbreakFilterSettings? PiAndJailbreakFilterSettings { get; set; }

    /// <summary>
    /// Responsible AI Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiSettings")]
    public V1beta1TemplateSpecForProviderFilterConfigRaiSettings? RaiSettings { get; set; }

    /// <summary>
    /// Sensitive Data Protection settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sdpSettings")]
    public V1beta1TemplateSpecForProviderFilterConfigSdpSettings? SdpSettings { get; set; }
}

/// <summary>
/// Metadata to enable multi language detection via template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderTemplateMetadataMultiLanguageDetection
{
    /// <summary>If true, multi language detection will be enabled.</summary>
    [JsonPropertyName("enableMultiLanguageDetection")]
    public bool? EnableMultiLanguageDetection { get; set; }
}

/// <summary>
/// Message describing TemplateMetadata
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProviderTemplateMetadata
{
    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user if the LLM response trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customLlmResponseSafetyErrorCode")]
    public double? CustomLlmResponseSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the LLM response trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customLlmResponseSafetyErrorMessage")]
    public string? CustomLlmResponseSafetyErrorMessage { get; set; }

    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user by the service extension if the prompt trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customPromptSafetyErrorCode")]
    public double? CustomPromptSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the prompt trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customPromptSafetyErrorMessage")]
    public string? CustomPromptSafetyErrorMessage { get; set; }

    /// <summary>
    /// Possible values:
    /// INSPECT_ONLY
    /// INSPECT_AND_BLOCK
    /// </summary>
    [JsonPropertyName("enforcementType")]
    public string? EnforcementType { get; set; }

    /// <summary>If true, partial detector failures should be ignored.</summary>
    [JsonPropertyName("ignorePartialInvocationFailures")]
    public bool? IgnorePartialInvocationFailures { get; set; }

    /// <summary>If true, log sanitize operations.</summary>
    [JsonPropertyName("logSanitizeOperations")]
    public bool? LogSanitizeOperations { get; set; }

    /// <summary>If true, log template crud operations.</summary>
    [JsonPropertyName("logTemplateOperations")]
    public bool? LogTemplateOperations { get; set; }

    /// <summary>
    /// Metadata to enable multi language detection via template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("multiLanguageDetection")]
    public V1beta1TemplateSpecForProviderTemplateMetadataMultiLanguageDetection? MultiLanguageDetection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecForProvider
{
    /// <summary>
    /// Filters configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterConfig")]
    public V1beta1TemplateSpecForProviderFilterConfig? FilterConfig { get; set; }

    /// <summary>
    /// Labels as key value pairs
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Message describing TemplateMetadata
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("templateMetadata")]
    public V1beta1TemplateSpecForProviderTemplateMetadata? TemplateMetadata { get; set; }
}

/// <summary>
/// Malicious URI filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigMaliciousUriFilterSettings
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
public partial class V1beta1TemplateSpecInitProviderFilterConfigPiAndJailbreakFilterSettings
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
public partial class V1beta1TemplateSpecInitProviderFilterConfigRaiSettingsRaiFilters
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
public partial class V1beta1TemplateSpecInitProviderFilterConfigRaiSettings
{
    /// <summary>
    /// List of Responsible AI filters enabled for template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiFilters")]
    public IList<V1beta1TemplateSpecInitProviderFilterConfigRaiSettingsRaiFilters>? RaiFilters { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum>))]
public enum V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum>))]
public enum V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelector
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
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum>))]
public enum V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum>))]
public enum V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum>))]
public enum V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelector
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
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Sensitive Data Protection Advanced configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfig
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
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateRef? DeidentifyTemplateRef { get; set; }

    /// <summary>Selector for a DeidentifyTemplate in datalossprevention to populate deidentifyTemplate.</summary>
    [JsonPropertyName("deidentifyTemplateSelector")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigDeidentifyTemplateSelector? DeidentifyTemplateSelector { get; set; }

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
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateRef? InspectTemplateRef { get; set; }

    /// <summary>Selector for a InspectTemplate in datalossprevention to populate inspectTemplate.</summary>
    [JsonPropertyName("inspectTemplateSelector")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfigInspectTemplateSelector? InspectTemplateSelector { get; set; }
}

/// <summary>
/// Sensitive Data Protection basic configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsBasicConfig
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
public partial class V1beta1TemplateSpecInitProviderFilterConfigSdpSettings
{
    /// <summary>
    /// Sensitive Data Protection Advanced configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedConfig")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsAdvancedConfig? AdvancedConfig { get; set; }

    /// <summary>
    /// Sensitive Data Protection basic configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicConfig")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettingsBasicConfig? BasicConfig { get; set; }
}

/// <summary>
/// Filters configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderFilterConfig
{
    /// <summary>
    /// Malicious URI filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maliciousUriFilterSettings")]
    public V1beta1TemplateSpecInitProviderFilterConfigMaliciousUriFilterSettings? MaliciousUriFilterSettings { get; set; }

    /// <summary>
    /// Prompt injection and Jailbreak Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("piAndJailbreakFilterSettings")]
    public V1beta1TemplateSpecInitProviderFilterConfigPiAndJailbreakFilterSettings? PiAndJailbreakFilterSettings { get; set; }

    /// <summary>
    /// Responsible AI Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiSettings")]
    public V1beta1TemplateSpecInitProviderFilterConfigRaiSettings? RaiSettings { get; set; }

    /// <summary>
    /// Sensitive Data Protection settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sdpSettings")]
    public V1beta1TemplateSpecInitProviderFilterConfigSdpSettings? SdpSettings { get; set; }
}

/// <summary>
/// Metadata to enable multi language detection via template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderTemplateMetadataMultiLanguageDetection
{
    /// <summary>If true, multi language detection will be enabled.</summary>
    [JsonPropertyName("enableMultiLanguageDetection")]
    public bool? EnableMultiLanguageDetection { get; set; }
}

/// <summary>
/// Message describing TemplateMetadata
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpecInitProviderTemplateMetadata
{
    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user if the LLM response trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customLlmResponseSafetyErrorCode")]
    public double? CustomLlmResponseSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the LLM response trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customLlmResponseSafetyErrorMessage")]
    public string? CustomLlmResponseSafetyErrorMessage { get; set; }

    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user by the service extension if the prompt trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customPromptSafetyErrorCode")]
    public double? CustomPromptSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the prompt trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customPromptSafetyErrorMessage")]
    public string? CustomPromptSafetyErrorMessage { get; set; }

    /// <summary>
    /// Possible values:
    /// INSPECT_ONLY
    /// INSPECT_AND_BLOCK
    /// </summary>
    [JsonPropertyName("enforcementType")]
    public string? EnforcementType { get; set; }

    /// <summary>If true, partial detector failures should be ignored.</summary>
    [JsonPropertyName("ignorePartialInvocationFailures")]
    public bool? IgnorePartialInvocationFailures { get; set; }

    /// <summary>If true, log sanitize operations.</summary>
    [JsonPropertyName("logSanitizeOperations")]
    public bool? LogSanitizeOperations { get; set; }

    /// <summary>If true, log template crud operations.</summary>
    [JsonPropertyName("logTemplateOperations")]
    public bool? LogTemplateOperations { get; set; }

    /// <summary>
    /// Metadata to enable multi language detection via template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("multiLanguageDetection")]
    public V1beta1TemplateSpecInitProviderTemplateMetadataMultiLanguageDetection? MultiLanguageDetection { get; set; }
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
public partial class V1beta1TemplateSpecInitProvider
{
    /// <summary>
    /// Filters configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterConfig")]
    public V1beta1TemplateSpecInitProviderFilterConfig? FilterConfig { get; set; }

    /// <summary>
    /// Labels as key value pairs
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Message describing TemplateMetadata
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("templateMetadata")]
    public V1beta1TemplateSpecInitProviderTemplateMetadata? TemplateMetadata { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TemplateSpecManagementPoliciesEnum>))]
public enum V1beta1TemplateSpecManagementPoliciesEnum
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
public partial class V1beta1TemplateSpecProviderConfigRef
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
public partial class V1beta1TemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>TemplateSpec defines the desired state of Template</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1TemplateSpecForProvider ForProvider { get; set; }

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
    public V1beta1TemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Malicious URI filter settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateStatusAtProviderFilterConfigMaliciousUriFilterSettings
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
public partial class V1beta1TemplateStatusAtProviderFilterConfigPiAndJailbreakFilterSettings
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
public partial class V1beta1TemplateStatusAtProviderFilterConfigRaiSettingsRaiFilters
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
public partial class V1beta1TemplateStatusAtProviderFilterConfigRaiSettings
{
    /// <summary>
    /// List of Responsible AI filters enabled for template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiFilters")]
    public IList<V1beta1TemplateStatusAtProviderFilterConfigRaiSettingsRaiFilters>? RaiFilters { get; set; }
}

/// <summary>
/// Sensitive Data Protection Advanced configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateStatusAtProviderFilterConfigSdpSettingsAdvancedConfig
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
public partial class V1beta1TemplateStatusAtProviderFilterConfigSdpSettingsBasicConfig
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
public partial class V1beta1TemplateStatusAtProviderFilterConfigSdpSettings
{
    /// <summary>
    /// Sensitive Data Protection Advanced configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedConfig")]
    public V1beta1TemplateStatusAtProviderFilterConfigSdpSettingsAdvancedConfig? AdvancedConfig { get; set; }

    /// <summary>
    /// Sensitive Data Protection basic configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicConfig")]
    public V1beta1TemplateStatusAtProviderFilterConfigSdpSettingsBasicConfig? BasicConfig { get; set; }
}

/// <summary>
/// Filters configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateStatusAtProviderFilterConfig
{
    /// <summary>
    /// Malicious URI filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maliciousUriFilterSettings")]
    public V1beta1TemplateStatusAtProviderFilterConfigMaliciousUriFilterSettings? MaliciousUriFilterSettings { get; set; }

    /// <summary>
    /// Prompt injection and Jailbreak Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("piAndJailbreakFilterSettings")]
    public V1beta1TemplateStatusAtProviderFilterConfigPiAndJailbreakFilterSettings? PiAndJailbreakFilterSettings { get; set; }

    /// <summary>
    /// Responsible AI Filter settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("raiSettings")]
    public V1beta1TemplateStatusAtProviderFilterConfigRaiSettings? RaiSettings { get; set; }

    /// <summary>
    /// Sensitive Data Protection settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sdpSettings")]
    public V1beta1TemplateStatusAtProviderFilterConfigSdpSettings? SdpSettings { get; set; }
}

/// <summary>
/// Metadata to enable multi language detection via template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateStatusAtProviderTemplateMetadataMultiLanguageDetection
{
    /// <summary>If true, multi language detection will be enabled.</summary>
    [JsonPropertyName("enableMultiLanguageDetection")]
    public bool? EnableMultiLanguageDetection { get; set; }
}

/// <summary>
/// Message describing TemplateMetadata
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateStatusAtProviderTemplateMetadata
{
    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user if the LLM response trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customLlmResponseSafetyErrorCode")]
    public double? CustomLlmResponseSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the LLM response trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customLlmResponseSafetyErrorMessage")]
    public string? CustomLlmResponseSafetyErrorMessage { get; set; }

    /// <summary>
    /// Indicates the custom error code set by the user to be returned to the end
    /// user by the service extension if the prompt trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customPromptSafetyErrorCode")]
    public double? CustomPromptSafetyErrorCode { get; set; }

    /// <summary>
    /// Indicates the custom error message set by the user to be returned to the
    /// end user if the prompt trips Model Armor filters.
    /// </summary>
    [JsonPropertyName("customPromptSafetyErrorMessage")]
    public string? CustomPromptSafetyErrorMessage { get; set; }

    /// <summary>
    /// Possible values:
    /// INSPECT_ONLY
    /// INSPECT_AND_BLOCK
    /// </summary>
    [JsonPropertyName("enforcementType")]
    public string? EnforcementType { get; set; }

    /// <summary>If true, partial detector failures should be ignored.</summary>
    [JsonPropertyName("ignorePartialInvocationFailures")]
    public bool? IgnorePartialInvocationFailures { get; set; }

    /// <summary>If true, log sanitize operations.</summary>
    [JsonPropertyName("logSanitizeOperations")]
    public bool? LogSanitizeOperations { get; set; }

    /// <summary>If true, log template crud operations.</summary>
    [JsonPropertyName("logTemplateOperations")]
    public bool? LogTemplateOperations { get; set; }

    /// <summary>
    /// Metadata to enable multi language detection via template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("multiLanguageDetection")]
    public V1beta1TemplateStatusAtProviderTemplateMetadataMultiLanguageDetection? MultiLanguageDetection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateStatusAtProvider
{
    /// <summary>Create time stamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// Filters configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterConfig")]
    public V1beta1TemplateStatusAtProviderFilterConfig? FilterConfig { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/templates/{{template_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Labels as key value pairs
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Identifier. name of resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Message describing TemplateMetadata
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("templateMetadata")]
    public V1beta1TemplateStatusAtProviderTemplateMetadata? TemplateMetadata { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Update time stamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateStatusConditions
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

/// <summary>TemplateStatus defines the observed state of Template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TemplateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1TemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Template is the Schema for the Templates API. A `Template` is a resource of Model Armor that lets you configure how Model Armor screens prompts and responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Template : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TemplateSpec>, IStatus<V1beta1TemplateStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Template";
    public const string KubeGroup = "modelarmor.gcp.m.upbound.io";
    public const string KubePluralName = "templates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "modelarmor.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Template";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TemplateSpec defines the desired state of Template</summary>
    [JsonPropertyName("spec")]
    public required V1beta1TemplateSpec Spec { get; set; }

    /// <summary>TemplateStatus defines the observed state of Template.</summary>
    [JsonPropertyName("status")]
    public V1beta1TemplateStatus? Status { get; set; }
}