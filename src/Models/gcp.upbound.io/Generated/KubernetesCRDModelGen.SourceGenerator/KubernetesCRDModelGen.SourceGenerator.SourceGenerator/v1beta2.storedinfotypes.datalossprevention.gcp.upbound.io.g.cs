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
/// <summary>StoredInfoType is the Schema for the StoredInfoTypes API. Allows creation of custom info types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2StoredInfoTypeList : IKubernetesObject<V1ListMeta>, IItems<V1beta2StoredInfoType>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "StoredInfoTypeList";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "storedinfotypes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalossprevention.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StoredInfoTypeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2StoredInfoType objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2StoredInfoType> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StoredInfoTypeSpecDeletionPolicyEnum>))]
public enum V1beta2StoredInfoTypeSpecDeletionPolicyEnum
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
public partial class V1beta2StoredInfoTypeSpecForProviderDictionaryCloudStoragePath
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
public partial class V1beta2StoredInfoTypeSpecForProviderDictionaryWordList
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
public partial class V1beta2StoredInfoTypeSpecForProviderDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2StoredInfoTypeSpecForProviderDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2StoredInfoTypeSpecForProviderDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Designated field in the BigQuery table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryFieldField
{
    /// <summary>The resource name of the info type. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Field in a BigQuery table where each cell represents a dictionary phrase.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryFieldTable
{
    /// <summary>The dataset ID of the table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The Google Cloud Platform project ID of the project containing the table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Field in a BigQuery table where each cell represents a dictionary phrase.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryField
{
    /// <summary>
    /// Designated field in the BigQuery table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("field")]
    public V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryFieldField? Field { get; set; }

    /// <summary>
    /// Field in a BigQuery table where each cell represents a dictionary phrase.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("table")]
    public V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryFieldTable? Table { get; set; }
}

/// <summary>
/// Set of files containing newline-delimited lists of dictionary phrases.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryCloudStorageFileSet
{
    /// <summary>The url, in the format gs://&lt;bucket&gt;/&lt;path&gt;. Trailing wildcard in the path is allowed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API.
/// If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryOutputPath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Dictionary which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionary
{
    /// <summary>
    /// Field in a BigQuery table where each cell represents a dictionary phrase.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigQueryField")]
    public V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryField? BigQueryField { get; set; }

    /// <summary>
    /// Set of files containing newline-delimited lists of dictionary phrases.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorageFileSet")]
    public V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryCloudStorageFileSet? CloudStorageFileSet { get; set; }

    /// <summary>
    /// Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API.
    /// If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputPath")]
    public V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionaryOutputPath? OutputPath { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecForProviderRegex
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecForProvider
{
    /// <summary>A description of the info type.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2StoredInfoTypeSpecForProviderDictionary? Dictionary { get; set; }

    /// <summary>User set display name of the info type.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("largeCustomDictionary")]
    public V1beta2StoredInfoTypeSpecForProviderLargeCustomDictionary? LargeCustomDictionary { get; set; }

    /// <summary>The parent of the info type in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Regular expression which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regex")]
    public V1beta2StoredInfoTypeSpecForProviderRegex? Regex { get; set; }

    /// <summary>
    /// The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100
    /// characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("storedInfoTypeId")]
    public string? StoredInfoTypeId { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecInitProviderDictionaryCloudStoragePath
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
public partial class V1beta2StoredInfoTypeSpecInitProviderDictionaryWordList
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
public partial class V1beta2StoredInfoTypeSpecInitProviderDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2StoredInfoTypeSpecInitProviderDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2StoredInfoTypeSpecInitProviderDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Designated field in the BigQuery table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryFieldField
{
    /// <summary>The resource name of the info type. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Field in a BigQuery table where each cell represents a dictionary phrase.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryFieldTable
{
    /// <summary>The dataset ID of the table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The Google Cloud Platform project ID of the project containing the table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Field in a BigQuery table where each cell represents a dictionary phrase.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryField
{
    /// <summary>
    /// Designated field in the BigQuery table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("field")]
    public V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryFieldField? Field { get; set; }

    /// <summary>
    /// Field in a BigQuery table where each cell represents a dictionary phrase.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("table")]
    public V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryFieldTable? Table { get; set; }
}

/// <summary>
/// Set of files containing newline-delimited lists of dictionary phrases.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryCloudStorageFileSet
{
    /// <summary>The url, in the format gs://&lt;bucket&gt;/&lt;path&gt;. Trailing wildcard in the path is allowed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API.
/// If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryOutputPath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Dictionary which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionary
{
    /// <summary>
    /// Field in a BigQuery table where each cell represents a dictionary phrase.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigQueryField")]
    public V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryField? BigQueryField { get; set; }

    /// <summary>
    /// Set of files containing newline-delimited lists of dictionary phrases.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorageFileSet")]
    public V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryCloudStorageFileSet? CloudStorageFileSet { get; set; }

    /// <summary>
    /// Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API.
    /// If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputPath")]
    public V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionaryOutputPath? OutputPath { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecInitProviderRegex
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
public partial class V1beta2StoredInfoTypeSpecInitProvider
{
    /// <summary>A description of the info type.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2StoredInfoTypeSpecInitProviderDictionary? Dictionary { get; set; }

    /// <summary>User set display name of the info type.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("largeCustomDictionary")]
    public V1beta2StoredInfoTypeSpecInitProviderLargeCustomDictionary? LargeCustomDictionary { get; set; }

    /// <summary>The parent of the info type in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Regular expression which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regex")]
    public V1beta2StoredInfoTypeSpecInitProviderRegex? Regex { get; set; }

    /// <summary>
    /// The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100
    /// characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("storedInfoTypeId")]
    public string? StoredInfoTypeId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StoredInfoTypeSpecManagementPoliciesEnum>))]
public enum V1beta2StoredInfoTypeSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StoredInfoTypeSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2StoredInfoTypeSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StoredInfoTypeSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2StoredInfoTypeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StoredInfoTypeSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StoredInfoTypeSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2StoredInfoTypeSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>StoredInfoTypeSpec defines the desired state of StoredInfoType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeSpec
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
    public V1beta2StoredInfoTypeSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2StoredInfoTypeSpecForProvider ForProvider { get; set; }

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
    public V1beta2StoredInfoTypeSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2StoredInfoTypeSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2StoredInfoTypeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2StoredInfoTypeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusAtProviderDictionaryCloudStoragePath
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
public partial class V1beta2StoredInfoTypeStatusAtProviderDictionaryWordList
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
public partial class V1beta2StoredInfoTypeStatusAtProviderDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2StoredInfoTypeStatusAtProviderDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2StoredInfoTypeStatusAtProviderDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Designated field in the BigQuery table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryFieldField
{
    /// <summary>The resource name of the info type. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Field in a BigQuery table where each cell represents a dictionary phrase.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryFieldTable
{
    /// <summary>The dataset ID of the table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The Google Cloud Platform project ID of the project containing the table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Field in a BigQuery table where each cell represents a dictionary phrase.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryField
{
    /// <summary>
    /// Designated field in the BigQuery table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("field")]
    public V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryFieldField? Field { get; set; }

    /// <summary>
    /// Field in a BigQuery table where each cell represents a dictionary phrase.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("table")]
    public V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryFieldTable? Table { get; set; }
}

/// <summary>
/// Set of files containing newline-delimited lists of dictionary phrases.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryCloudStorageFileSet
{
    /// <summary>The url, in the format gs://&lt;bucket&gt;/&lt;path&gt;. Trailing wildcard in the path is allowed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API.
/// If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryOutputPath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Dictionary which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionary
{
    /// <summary>
    /// Field in a BigQuery table where each cell represents a dictionary phrase.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigQueryField")]
    public V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryField? BigQueryField { get; set; }

    /// <summary>
    /// Set of files containing newline-delimited lists of dictionary phrases.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorageFileSet")]
    public V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryCloudStorageFileSet? CloudStorageFileSet { get; set; }

    /// <summary>
    /// Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API.
    /// If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputPath")]
    public V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionaryOutputPath? OutputPath { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusAtProviderRegex
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusAtProvider
{
    /// <summary>A description of the info type.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2StoredInfoTypeStatusAtProviderDictionary? Dictionary { get; set; }

    /// <summary>User set display name of the info type.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/storedInfoTypes/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("largeCustomDictionary")]
    public V1beta2StoredInfoTypeStatusAtProviderLargeCustomDictionary? LargeCustomDictionary { get; set; }

    /// <summary>The resource name of the info type. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parent of the info type in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Regular expression which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regex")]
    public V1beta2StoredInfoTypeStatusAtProviderRegex? Regex { get; set; }

    /// <summary>
    /// The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100
    /// characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("storedInfoTypeId")]
    public string? StoredInfoTypeId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatusConditions
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

/// <summary>StoredInfoTypeStatus defines the observed state of StoredInfoType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StoredInfoTypeStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2StoredInfoTypeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2StoredInfoTypeStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StoredInfoType is the Schema for the StoredInfoTypes API. Allows creation of custom info types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2StoredInfoType : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2StoredInfoTypeSpec>, IStatus<V1beta2StoredInfoTypeStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "StoredInfoType";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "storedinfotypes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalossprevention.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StoredInfoType";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StoredInfoTypeSpec defines the desired state of StoredInfoType</summary>
    [JsonPropertyName("spec")]
    public required V1beta2StoredInfoTypeSpec Spec { get; set; }

    /// <summary>StoredInfoTypeStatus defines the observed state of StoredInfoType.</summary>
    [JsonPropertyName("status")]
    public V1beta2StoredInfoTypeStatus? Status { get; set; }
}