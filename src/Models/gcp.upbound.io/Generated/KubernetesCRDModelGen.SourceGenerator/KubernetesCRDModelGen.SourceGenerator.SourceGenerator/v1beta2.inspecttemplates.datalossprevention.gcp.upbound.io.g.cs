#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datalossprevention.gcp.upbound.io;
/// <summary>InspectTemplate is the Schema for the InspectTemplates API. An inspect job template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InspectTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta2InspectTemplate>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InspectTemplateList";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "inspecttemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalossprevention.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InspectTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2InspectTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2InspectTemplate> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InspectTemplateSpecDeletionPolicyEnum>))]
public enum V1beta2InspectTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// List of words or phrases to search for.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Dictionary which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
/// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
/// specified in another InfoTypeLimit.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesInfoType
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// A reference to a StoredInfoType to use with scanning.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesStoredType
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesSurrogateType
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypes
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesDictionary? Dictionary { get; set; }

    /// <summary>
    /// If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching.
    /// Possible values are: EXCLUSION_TYPE_EXCLUDE.
    /// </summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>
    /// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
    /// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
    /// specified in another InfoTypeLimit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoType")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesInfoType? InfoType { get; set; }

    /// <summary>
    /// Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria
    /// specified by the rule.
    /// Default value is VERY_LIKELY.
    /// Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.
    /// </summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>
    /// Regular expression which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regex")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesRegex? Regex { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>
    /// A reference to a StoredInfoType to use with scanning.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storedType")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesStoredType? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypesSurrogateType? SurrogateType { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigInfoTypes
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
/// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
/// specified in another InfoTypeLimit.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>
    /// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
    /// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
    /// specified in another InfoTypeLimit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoType")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public double? MaxFindings { get; set; }
}

/// <summary>
/// Configuration to control the number of findings returned.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigLimits
{
    /// <summary>
    /// Configuration of findings limit given for specified infoTypes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta2InspectTemplateSpecForProviderInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public double? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public double? MaxFindingsPerRequest { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetInfoTypes
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// List of words or phrases to search for.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Dictionary which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
/// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
/// used to match substrings of the finding itself. For example, the certainty of a phone number regex
/// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
/// office using the hotword regex (xxx), where xxx is the area code in question.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary>
/// Drop if the hotword rule is contained in the proximate context.
/// For tabular data, the context includes the column name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity? Proximity { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>When true, excludes type information of the findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleDictionary? Dictionary { get; set; }

    /// <summary>
    /// Drop if the hotword rule is contained in the proximate context.
    /// For tabular data, the context includes the column name.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeByHotword")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes? ExcludeInfoTypes { get; set; }

    /// <summary>
    /// How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType
    /// Possible values are: MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH.
    /// </summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>
    /// Regular expression which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regex")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRuleRegex? Regex { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Likelihood adjustment to apply to all matching findings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>
    /// Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set.
    /// Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.
    /// </summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>
    /// Increase or decrease the likelihood by the specified number of levels. For example,
    /// if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1,
    /// then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY.
    /// Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an
    /// adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY
    /// will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.
    /// </summary>
    [JsonPropertyName("relativeLikelihood")]
    public double? RelativeLikelihood { get; set; }
}

/// <summary>
/// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
/// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
/// used to match substrings of the finding itself. For example, the certainty of a phone number regex
/// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
/// office using the hotword regex (xxx), where xxx is the area code in question.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary>
/// Hotword-based detection rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Likelihood adjustment to apply to all matching findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment? LikelihoodAdjustment { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRuleProximity? Proximity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRules
{
    /// <summary>
    /// The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exclusionRule")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesExclusionRule? ExclusionRule { get; set; }

    /// <summary>
    /// Hotword-based detection rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRule")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRulesHotwordRule? HotwordRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfigRuleSet
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Set of rules to be applied to infoTypes. The rules are applied in order.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta2InspectTemplateSpecForProviderInspectConfigRuleSetRules>? Rules { get; set; }
}

/// <summary>
/// The core content of the template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProviderInspectConfig
{
    /// <summary>
    /// List of options defining data content to scan. If empty, text, images, and other content will be included.
    /// Each value may be one of: CONTENT_TEXT, CONTENT_IMAGE.
    /// </summary>
    [JsonPropertyName("contentOptions")]
    public IList<string>? ContentOptions { get; set; }

    /// <summary>
    /// Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta2InspectTemplateSpecForProviderInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>
    /// Restricts what infoTypes to look for. The values must correspond to InfoType values returned by infoTypes.list
    /// or listed at https://cloud.google.com/dlp/docs/infotypes-reference.
    /// When no InfoTypes or CustomInfoTypes are specified in a request, the system may automatically choose what detectors to run.
    /// By default this may be all types, but may change over time as detectors are updated.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2InspectTemplateSpecForProviderInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Configuration to control the number of findings returned.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("limits")]
    public V1beta2InspectTemplateSpecForProviderInspectConfigLimits? Limits { get; set; }

    /// <summary>
    /// Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info
    /// Default value is POSSIBLE.
    /// Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.
    /// </summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>
    /// Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end,
    /// other rules are executed in the order they are specified for each info type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta2InspectTemplateSpecForProviderInspectConfigRuleSet>? RuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecForProvider
{
    /// <summary>A description of the inspect template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the inspect template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The core content of the template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inspectConfig")]
    public V1beta2InspectTemplateSpecForProviderInspectConfig? InspectConfig { get; set; }

    /// <summary>The parent of the inspect template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// List of words or phrases to search for.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Dictionary which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
/// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
/// specified in another InfoTypeLimit.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesInfoType
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// A reference to a StoredInfoType to use with scanning.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesStoredType
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesSurrogateType
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypes
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesDictionary? Dictionary { get; set; }

    /// <summary>
    /// If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching.
    /// Possible values are: EXCLUSION_TYPE_EXCLUDE.
    /// </summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>
    /// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
    /// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
    /// specified in another InfoTypeLimit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoType")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesInfoType? InfoType { get; set; }

    /// <summary>
    /// Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria
    /// specified by the rule.
    /// Default value is VERY_LIKELY.
    /// Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.
    /// </summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>
    /// Regular expression which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regex")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesRegex? Regex { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>
    /// A reference to a StoredInfoType to use with scanning.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storedType")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesStoredType? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypesSurrogateType? SurrogateType { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigInfoTypes
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
/// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
/// specified in another InfoTypeLimit.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>
    /// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
    /// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
    /// specified in another InfoTypeLimit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoType")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public double? MaxFindings { get; set; }
}

/// <summary>
/// Configuration to control the number of findings returned.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigLimits
{
    /// <summary>
    /// Configuration of findings limit given for specified infoTypes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta2InspectTemplateSpecInitProviderInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public double? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public double? MaxFindingsPerRequest { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetInfoTypes
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// List of words or phrases to search for.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Dictionary which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
/// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
/// used to match substrings of the finding itself. For example, the certainty of a phone number regex
/// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
/// office using the hotword regex (xxx), where xxx is the area code in question.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary>
/// Drop if the hotword rule is contained in the proximate context.
/// For tabular data, the context includes the column name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity? Proximity { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>When true, excludes type information of the findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleDictionary? Dictionary { get; set; }

    /// <summary>
    /// Drop if the hotword rule is contained in the proximate context.
    /// For tabular data, the context includes the column name.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeByHotword")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes? ExcludeInfoTypes { get; set; }

    /// <summary>
    /// How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType
    /// Possible values are: MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH.
    /// </summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>
    /// Regular expression which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regex")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRuleRegex? Regex { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Likelihood adjustment to apply to all matching findings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>
    /// Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set.
    /// Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.
    /// </summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>
    /// Increase or decrease the likelihood by the specified number of levels. For example,
    /// if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1,
    /// then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY.
    /// Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an
    /// adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY
    /// will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.
    /// </summary>
    [JsonPropertyName("relativeLikelihood")]
    public double? RelativeLikelihood { get; set; }
}

/// <summary>
/// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
/// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
/// used to match substrings of the finding itself. For example, the certainty of a phone number regex
/// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
/// office using the hotword regex (xxx), where xxx is the area code in question.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary>
/// Hotword-based detection rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Likelihood adjustment to apply to all matching findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment? LikelihoodAdjustment { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRuleProximity? Proximity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRules
{
    /// <summary>
    /// The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exclusionRule")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesExclusionRule? ExclusionRule { get; set; }

    /// <summary>
    /// Hotword-based detection rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRule")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRulesHotwordRule? HotwordRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSet
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Set of rules to be applied to infoTypes. The rules are applied in order.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSetRules>? Rules { get; set; }
}

/// <summary>
/// The core content of the template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecInitProviderInspectConfig
{
    /// <summary>
    /// List of options defining data content to scan. If empty, text, images, and other content will be included.
    /// Each value may be one of: CONTENT_TEXT, CONTENT_IMAGE.
    /// </summary>
    [JsonPropertyName("contentOptions")]
    public IList<string>? ContentOptions { get; set; }

    /// <summary>
    /// Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta2InspectTemplateSpecInitProviderInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>
    /// Restricts what infoTypes to look for. The values must correspond to InfoType values returned by infoTypes.list
    /// or listed at https://cloud.google.com/dlp/docs/infotypes-reference.
    /// When no InfoTypes or CustomInfoTypes are specified in a request, the system may automatically choose what detectors to run.
    /// By default this may be all types, but may change over time as detectors are updated.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2InspectTemplateSpecInitProviderInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Configuration to control the number of findings returned.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("limits")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfigLimits? Limits { get; set; }

    /// <summary>
    /// Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info
    /// Default value is POSSIBLE.
    /// Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.
    /// </summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>
    /// Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end,
    /// other rules are executed in the order they are specified for each info type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta2InspectTemplateSpecInitProviderInspectConfigRuleSet>? RuleSet { get; set; }
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
public partial class V1beta2InspectTemplateSpecInitProvider
{
    /// <summary>A description of the inspect template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the inspect template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The core content of the template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inspectConfig")]
    public V1beta2InspectTemplateSpecInitProviderInspectConfig? InspectConfig { get; set; }

    /// <summary>The parent of the inspect template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InspectTemplateSpecManagementPoliciesEnum>))]
public enum V1beta2InspectTemplateSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InspectTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2InspectTemplateSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InspectTemplateSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2InspectTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InspectTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InspectTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InspectTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InspectTemplateSpec defines the desired state of InspectTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateSpec
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
    public V1beta2InspectTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2InspectTemplateSpecForProvider ForProvider { get; set; }

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
    public V1beta2InspectTemplateSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2InspectTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2InspectTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2InspectTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// List of words or phrases to search for.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionaryWordList
{
    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Dictionary which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
/// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
/// specified in another InfoTypeLimit.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesInfoType
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// A reference to a StoredInfoType to use with scanning.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesStoredType
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesSurrogateType
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypes
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesDictionary? Dictionary { get; set; }

    /// <summary>
    /// If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching.
    /// Possible values are: EXCLUSION_TYPE_EXCLUDE.
    /// </summary>
    [JsonPropertyName("exclusionType")]
    public string? ExclusionType { get; set; }

    /// <summary>
    /// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
    /// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
    /// specified in another InfoTypeLimit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoType")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesInfoType? InfoType { get; set; }

    /// <summary>
    /// Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria
    /// specified by the rule.
    /// Default value is VERY_LIKELY.
    /// Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.
    /// </summary>
    [JsonPropertyName("likelihood")]
    public string? Likelihood { get; set; }

    /// <summary>
    /// Regular expression which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regex")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesRegex? Regex { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>
    /// A reference to a StoredInfoType to use with scanning.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storedType")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesStoredType? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypesSurrogateType? SurrogateType { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigInfoTypes
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
/// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
/// specified in another InfoTypeLimit.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>
    /// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
    /// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
    /// specified in another InfoTypeLimit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoType")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoTypeInfoType? InfoType { get; set; }

    /// <summary>Max findings limit for the given infoType.</summary>
    [JsonPropertyName("maxFindings")]
    public double? MaxFindings { get; set; }
}

/// <summary>
/// Configuration to control the number of findings returned.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigLimits
{
    /// <summary>
    /// Configuration of findings limit given for specified infoTypes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta2InspectTemplateStatusAtProviderInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

    /// <summary>Max number of findings that will be returned for each item scanned. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerItem")]
    public double? MaxFindingsPerItem { get; set; }

    /// <summary>Max number of findings that will be returned per request/job. The maximum returned is 2000.</summary>
    [JsonPropertyName("maxFindingsPerRequest")]
    public double? MaxFindingsPerRequest { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetInfoTypes
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// List of words or phrases to search for.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
{
    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Dictionary which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
/// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
/// used to match substrings of the finding itself. For example, the certainty of a phone number regex
/// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
/// office using the hotword regex (xxx), where xxx is the area code in question.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary>
/// Drop if the hotword rule is contained in the proximate context.
/// For tabular data, the context includes the column name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity? Proximity { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>
    /// Resource name of the requested StoredInfoType, for example organizations/433245324/storedInfoTypes/432452342
    /// or projects/project-id/storedInfoTypes/432452342.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>When true, excludes type information of the findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleDictionary? Dictionary { get; set; }

    /// <summary>
    /// Drop if the hotword rule is contained in the proximate context.
    /// For tabular data, the context includes the column name.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeByHotword")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeByHotword? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes? ExcludeInfoTypes { get; set; }

    /// <summary>
    /// How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType
    /// Possible values are: MATCHING_TYPE_FULL_MATCH, MATCHING_TYPE_PARTIAL_MATCH, MATCHING_TYPE_INVERSE_MATCH.
    /// </summary>
    [JsonPropertyName("matchingType")]
    public string? MatchingType { get; set; }

    /// <summary>
    /// Regular expression which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regex")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRuleRegex? Regex { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// Likelihood adjustment to apply to all matching findings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
{
    /// <summary>
    /// Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set.
    /// Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.
    /// </summary>
    [JsonPropertyName("fixedLikelihood")]
    public string? FixedLikelihood { get; set; }

    /// <summary>
    /// Increase or decrease the likelihood by the specified number of levels. For example,
    /// if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1,
    /// then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY.
    /// Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an
    /// adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY
    /// will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.
    /// </summary>
    [JsonPropertyName("relativeLikelihood")]
    public double? RelativeLikelihood { get; set; }
}

/// <summary>
/// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
/// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
/// used to match substrings of the finding itself. For example, the certainty of a phone number regex
/// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
/// office using the hotword regex (xxx), where xxx is the area code in question.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleProximity
{
    /// <summary>Number of characters after the finding to consider. Either this or window_before must be specified</summary>
    [JsonPropertyName("windowAfter")]
    public double? WindowAfter { get; set; }

    /// <summary>Number of characters before the finding to consider. Either this or window_after must be specified</summary>
    [JsonPropertyName("windowBefore")]
    public double? WindowBefore { get; set; }
}

/// <summary>
/// Hotword-based detection rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Likelihood adjustment to apply to all matching findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment? LikelihoodAdjustment { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRuleProximity? Proximity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRules
{
    /// <summary>
    /// The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exclusionRule")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesExclusionRule? ExclusionRule { get; set; }

    /// <summary>
    /// Hotword-based detection rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRule")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRulesHotwordRule? HotwordRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSet
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Set of rules to be applied to infoTypes. The rules are applied in order.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSetRules>? Rules { get; set; }
}

/// <summary>
/// The core content of the template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProviderInspectConfig
{
    /// <summary>
    /// List of options defining data content to scan. If empty, text, images, and other content will be included.
    /// Each value may be one of: CONTENT_TEXT, CONTENT_IMAGE.
    /// </summary>
    [JsonPropertyName("contentOptions")]
    public IList<string>? ContentOptions { get; set; }

    /// <summary>
    /// Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta2InspectTemplateStatusAtProviderInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>
    /// Restricts what infoTypes to look for. The values must correspond to InfoType values returned by infoTypes.list
    /// or listed at https://cloud.google.com/dlp/docs/infotypes-reference.
    /// When no InfoTypes or CustomInfoTypes are specified in a request, the system may automatically choose what detectors to run.
    /// By default this may be all types, but may change over time as detectors are updated.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2InspectTemplateStatusAtProviderInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Configuration to control the number of findings returned.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("limits")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfigLimits? Limits { get; set; }

    /// <summary>
    /// Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info
    /// Default value is POSSIBLE.
    /// Possible values are: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY.
    /// </summary>
    [JsonPropertyName("minLikelihood")]
    public string? MinLikelihood { get; set; }

    /// <summary>
    /// Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are executed in the end,
    /// other rules are executed in the order they are specified for each info type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ruleSet")]
    public IList<V1beta2InspectTemplateStatusAtProviderInspectConfigRuleSet>? RuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusAtProvider
{
    /// <summary>A description of the inspect template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the inspect template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/inspectTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The core content of the template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inspectConfig")]
    public V1beta2InspectTemplateStatusAtProviderInspectConfig? InspectConfig { get; set; }

    /// <summary>The resource name of the inspect template. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parent of the inspect template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatusConditions
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

/// <summary>InspectTemplateStatus defines the observed state of InspectTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InspectTemplateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2InspectTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2InspectTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InspectTemplate is the Schema for the InspectTemplates API. An inspect job template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InspectTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InspectTemplateSpec>, IStatus<V1beta2InspectTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InspectTemplate";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "inspecttemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalossprevention.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InspectTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InspectTemplateSpec defines the desired state of InspectTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1beta2InspectTemplateSpec Spec { get; set; }

    /// <summary>InspectTemplateStatus defines the observed state of InspectTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta2InspectTemplateStatus? Status { get; set; }
}