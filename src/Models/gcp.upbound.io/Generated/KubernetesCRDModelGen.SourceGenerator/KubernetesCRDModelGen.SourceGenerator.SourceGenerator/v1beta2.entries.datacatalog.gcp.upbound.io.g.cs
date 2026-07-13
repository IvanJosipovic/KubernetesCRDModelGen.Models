#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datacatalog.gcp.upbound.io;
/// <summary>Entry is the Schema for the Entrys API. Entry Metadata.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EntryList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Entry>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EntryList";
    public const string KubeGroup = "datacatalog.gcp.upbound.io";
    public const string KubePluralName = "entries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datacatalog.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EntryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Entry objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Entry> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecDeletionPolicyEnum>))]
public enum V1beta2EntrySpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecForProviderEntryGroupRefPolicyResolutionEnum>))]
public enum V1beta2EntrySpecForProviderEntryGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecForProviderEntryGroupRefPolicyResolveEnum>))]
public enum V1beta2EntrySpecForProviderEntryGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecForProviderEntryGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EntrySpecForProviderEntryGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EntrySpecForProviderEntryGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EntryGroup in datacatalog to populate entryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecForProviderEntryGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EntrySpecForProviderEntryGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecForProviderEntryGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2EntrySpecForProviderEntryGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecForProviderEntryGroupSelectorPolicyResolveEnum>))]
public enum V1beta2EntrySpecForProviderEntryGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecForProviderEntryGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EntrySpecForProviderEntryGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EntrySpecForProviderEntryGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EntryGroup in datacatalog to populate entryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecForProviderEntryGroupSelector
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
    public V1beta2EntrySpecForProviderEntryGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecForProviderGcsFilesetSpec
{
    /// <summary>
    /// Patterns to identify a set of files in Google Cloud Storage.
    /// See Cloud Storage documentation
    /// for more information. Note that bucket wildcards are currently not supported. Examples of valid filePatterns:
    /// </summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecForProvider
{
    /// <summary>Entry description, which can consist of several sentences or paragraphs that describe entry contents.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Display information such as title and description. A short name to identify the entry,
    /// for example, &quot;Analytics Data - Jan 2011&quot;.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the entry group this entry is in.</summary>
    [JsonPropertyName("entryGroup")]
    public string? EntryGroup { get; set; }

    /// <summary>Reference to a EntryGroup in datacatalog to populate entryGroup.</summary>
    [JsonPropertyName("entryGroupRef")]
    public V1beta2EntrySpecForProviderEntryGroupRef? EntryGroupRef { get; set; }

    /// <summary>Selector for a EntryGroup in datacatalog to populate entryGroup.</summary>
    [JsonPropertyName("entryGroupSelector")]
    public V1beta2EntrySpecForProviderEntryGroupSelector? EntryGroupSelector { get; set; }

    /// <summary>The id of the entry to create.</summary>
    [JsonPropertyName("entryId")]
    public string? EntryId { get; set; }

    /// <summary>
    /// Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsFilesetSpec")]
    public V1beta2EntrySpecForProviderGcsFilesetSpec? GcsFilesetSpec { get; set; }

    /// <summary>
    /// The resource this metadata entry refers to.
    /// For Google Cloud Platform resources, linkedResource is the full name of the resource.
    /// For example, the linkedResource for a table resource from BigQuery is:
    /// //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId
    /// Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType,
    /// this field is optional and defaults to an empty string.
    /// </summary>
    [JsonPropertyName("linkedResource")]
    public string? LinkedResource { get; set; }

    /// <summary>
    /// Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema
    /// attached to it. See
    /// https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema
    /// for what fields this schema can contain.
    /// </summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// The type of the entry. Only used for Entries with types in the EntryType enum.
    /// Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType.
    /// Possible values are: FILESET.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// This field indicates the entry&apos;s source system that Data Catalog does not integrate with.
    /// userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers,
    /// and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    [JsonPropertyName("userSpecifiedSystem")]
    public string? UserSpecifiedSystem { get; set; }

    /// <summary>
    /// Entry type if it does not fit any of the input-allowed values listed in EntryType enum above.
    /// When creating an entry, users should check the enum values first, if nothing matches the entry
    /// to be created, then provide a custom value, for example &quot;my_special_type&quot;.
    /// userSpecifiedType strings must begin with a letter or underscore and can only contain letters,
    /// numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    [JsonPropertyName("userSpecifiedType")]
    public string? UserSpecifiedType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecInitProviderEntryGroupRefPolicyResolutionEnum>))]
public enum V1beta2EntrySpecInitProviderEntryGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecInitProviderEntryGroupRefPolicyResolveEnum>))]
public enum V1beta2EntrySpecInitProviderEntryGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecInitProviderEntryGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EntrySpecInitProviderEntryGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EntrySpecInitProviderEntryGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EntryGroup in datacatalog to populate entryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecInitProviderEntryGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EntrySpecInitProviderEntryGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecInitProviderEntryGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2EntrySpecInitProviderEntryGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecInitProviderEntryGroupSelectorPolicyResolveEnum>))]
public enum V1beta2EntrySpecInitProviderEntryGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecInitProviderEntryGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EntrySpecInitProviderEntryGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EntrySpecInitProviderEntryGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EntryGroup in datacatalog to populate entryGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecInitProviderEntryGroupSelector
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
    public V1beta2EntrySpecInitProviderEntryGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecInitProviderGcsFilesetSpec
{
    /// <summary>
    /// Patterns to identify a set of files in Google Cloud Storage.
    /// See Cloud Storage documentation
    /// for more information. Note that bucket wildcards are currently not supported. Examples of valid filePatterns:
    /// </summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }
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
public partial class V1beta2EntrySpecInitProvider
{
    /// <summary>Entry description, which can consist of several sentences or paragraphs that describe entry contents.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Display information such as title and description. A short name to identify the entry,
    /// for example, &quot;Analytics Data - Jan 2011&quot;.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the entry group this entry is in.</summary>
    [JsonPropertyName("entryGroup")]
    public string? EntryGroup { get; set; }

    /// <summary>Reference to a EntryGroup in datacatalog to populate entryGroup.</summary>
    [JsonPropertyName("entryGroupRef")]
    public V1beta2EntrySpecInitProviderEntryGroupRef? EntryGroupRef { get; set; }

    /// <summary>Selector for a EntryGroup in datacatalog to populate entryGroup.</summary>
    [JsonPropertyName("entryGroupSelector")]
    public V1beta2EntrySpecInitProviderEntryGroupSelector? EntryGroupSelector { get; set; }

    /// <summary>The id of the entry to create.</summary>
    [JsonPropertyName("entryId")]
    public string? EntryId { get; set; }

    /// <summary>
    /// Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsFilesetSpec")]
    public V1beta2EntrySpecInitProviderGcsFilesetSpec? GcsFilesetSpec { get; set; }

    /// <summary>
    /// The resource this metadata entry refers to.
    /// For Google Cloud Platform resources, linkedResource is the full name of the resource.
    /// For example, the linkedResource for a table resource from BigQuery is:
    /// //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId
    /// Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType,
    /// this field is optional and defaults to an empty string.
    /// </summary>
    [JsonPropertyName("linkedResource")]
    public string? LinkedResource { get; set; }

    /// <summary>
    /// Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema
    /// attached to it. See
    /// https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema
    /// for what fields this schema can contain.
    /// </summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// The type of the entry. Only used for Entries with types in the EntryType enum.
    /// Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType.
    /// Possible values are: FILESET.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// This field indicates the entry&apos;s source system that Data Catalog does not integrate with.
    /// userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers,
    /// and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    [JsonPropertyName("userSpecifiedSystem")]
    public string? UserSpecifiedSystem { get; set; }

    /// <summary>
    /// Entry type if it does not fit any of the input-allowed values listed in EntryType enum above.
    /// When creating an entry, users should check the enum values first, if nothing matches the entry
    /// to be created, then provide a custom value, for example &quot;my_special_type&quot;.
    /// userSpecifiedType strings must begin with a letter or underscore and can only contain letters,
    /// numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    [JsonPropertyName("userSpecifiedType")]
    public string? UserSpecifiedType { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecManagementPoliciesEnum>))]
public enum V1beta2EntrySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2EntrySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EntrySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2EntrySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EntrySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EntrySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EntrySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>EntrySpec defines the desired state of Entry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntrySpec
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
    public V1beta2EntrySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2EntrySpecForProvider ForProvider { get; set; }

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
    public V1beta2EntrySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2EntrySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2EntrySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2EntrySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntryStatusAtProviderBigqueryDateShardedSpec
{
    /// <summary>
    /// (Output)
    /// The Data Catalog resource name of the dataset entry the current table belongs to, for example,
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}
    /// </summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>
    /// (Output)
    /// Total number of shards.
    /// </summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>
    /// (Output)
    /// The table name prefix of the shards. The name of any given shard is [tablePrefix]YYYYMMDD,
    /// for example, for shard MyTable20180101, the tablePrefix is MyTable.
    /// </summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntryStatusAtProviderBigqueryTableSpecTableSpec
{
    /// <summary>
    /// (Output)
    /// If the table is a dated shard, i.e., with name pattern [prefix]YYYYMMDD, groupedEntry is the
    /// Data Catalog resource name of the date sharded grouped entry, for example,
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}.
    /// Otherwise, groupedEntry is empty.
    /// </summary>
    [JsonPropertyName("groupedEntry")]
    public string? GroupedEntry { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntryStatusAtProviderBigqueryTableSpecViewSpec
{
    /// <summary>
    /// (Output)
    /// The query that defines the table view.
    /// </summary>
    [JsonPropertyName("viewQuery")]
    public string? ViewQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntryStatusAtProviderBigqueryTableSpec
{
    /// <summary>
    /// (Output)
    /// The table source type.
    /// </summary>
    [JsonPropertyName("tableSourceType")]
    public string? TableSourceType { get; set; }

    /// <summary>
    /// (Output)
    /// Spec of a BigQuery table. This field should only be populated if tableSourceType is BIGQUERY_TABLE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tableSpec")]
    public IList<V1beta2EntryStatusAtProviderBigqueryTableSpecTableSpec>? TableSpec { get; set; }

    /// <summary>
    /// (Output)
    /// Table view specification. This field should only be populated if tableSourceType is BIGQUERY_VIEW.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("viewSpec")]
    public IList<V1beta2EntryStatusAtProviderBigqueryTableSpecViewSpec>? ViewSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntryStatusAtProviderGcsFilesetSpecSampleGcsFileSpecs
{
    /// <summary>
    /// (Output)
    /// The full file path
    /// </summary>
    [JsonPropertyName("filePath")]
    public string? FilePath { get; set; }

    /// <summary>
    /// (Output)
    /// The size of the file, in bytes.
    /// </summary>
    [JsonPropertyName("sizeBytes")]
    public double? SizeBytes { get; set; }
}

/// <summary>
/// Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntryStatusAtProviderGcsFilesetSpec
{
    /// <summary>
    /// Patterns to identify a set of files in Google Cloud Storage.
    /// See Cloud Storage documentation
    /// for more information. Note that bucket wildcards are currently not supported. Examples of valid filePatterns:
    /// </summary>
    [JsonPropertyName("filePatterns")]
    public IList<string>? FilePatterns { get; set; }

    /// <summary>
    /// (Output)
    /// Sample files contained in this fileset, not all files contained in this fileset are represented here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sampleGcsFileSpecs")]
    public IList<V1beta2EntryStatusAtProviderGcsFilesetSpecSampleGcsFileSpecs>? SampleGcsFileSpecs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntryStatusAtProvider
{
    /// <summary>
    /// Specification for a group of BigQuery tables with name pattern [prefix]YYYYMMDD.
    /// Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryDateShardedSpec")]
    public IList<V1beta2EntryStatusAtProviderBigqueryDateShardedSpec>? BigqueryDateShardedSpec { get; set; }

    /// <summary>
    /// Specification that applies to a BigQuery table. This is only valid on entries of type TABLE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryTableSpec")]
    public IList<V1beta2EntryStatusAtProviderBigqueryTableSpec>? BigqueryTableSpec { get; set; }

    /// <summary>Entry description, which can consist of several sentences or paragraphs that describe entry contents.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Display information such as title and description. A short name to identify the entry,
    /// for example, &quot;Analytics Data - Jan 2011&quot;.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The name of the entry group this entry is in.</summary>
    [JsonPropertyName("entryGroup")]
    public string? EntryGroup { get; set; }

    /// <summary>The id of the entry to create.</summary>
    [JsonPropertyName("entryId")]
    public string? EntryId { get; set; }

    /// <summary>
    /// Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsFilesetSpec")]
    public V1beta2EntryStatusAtProviderGcsFilesetSpec? GcsFilesetSpec { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>This field indicates the entry&apos;s source system that Data Catalog integrates with, such as BigQuery or Pub/Sub.</summary>
    [JsonPropertyName("integratedSystem")]
    public string? IntegratedSystem { get; set; }

    /// <summary>
    /// The resource this metadata entry refers to.
    /// For Google Cloud Platform resources, linkedResource is the full name of the resource.
    /// For example, the linkedResource for a table resource from BigQuery is:
    /// //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId
    /// Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType,
    /// this field is optional and defaults to an empty string.
    /// </summary>
    [JsonPropertyName("linkedResource")]
    public string? LinkedResource { get; set; }

    /// <summary>
    /// The Data Catalog resource name of the entry in URL format.
    /// Example: projects/{project_id}/locations/{location}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// Note that this Entry and its child resources may not actually be stored in the location in this name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema
    /// attached to it. See
    /// https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema
    /// for what fields this schema can contain.
    /// </summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// The type of the entry. Only used for Entries with types in the EntryType enum.
    /// Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType.
    /// Possible values are: FILESET.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// This field indicates the entry&apos;s source system that Data Catalog does not integrate with.
    /// userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers,
    /// and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    [JsonPropertyName("userSpecifiedSystem")]
    public string? UserSpecifiedSystem { get; set; }

    /// <summary>
    /// Entry type if it does not fit any of the input-allowed values listed in EntryType enum above.
    /// When creating an entry, users should check the enum values first, if nothing matches the entry
    /// to be created, then provide a custom value, for example &quot;my_special_type&quot;.
    /// userSpecifiedType strings must begin with a letter or underscore and can only contain letters,
    /// numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    [JsonPropertyName("userSpecifiedType")]
    public string? UserSpecifiedType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntryStatusConditions
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

/// <summary>EntryStatus defines the observed state of Entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EntryStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2EntryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2EntryStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Entry is the Schema for the Entrys API. Entry Metadata.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Entry : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EntrySpec>, IStatus<V1beta2EntryStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Entry";
    public const string KubeGroup = "datacatalog.gcp.upbound.io";
    public const string KubePluralName = "entries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datacatalog.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Entry";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EntrySpec defines the desired state of Entry</summary>
    [JsonPropertyName("spec")]
    public required V1beta2EntrySpec Spec { get; set; }

    /// <summary>EntryStatus defines the observed state of Entry.</summary>
    [JsonPropertyName("status")]
    public V1beta2EntryStatus? Status { get; set; }
}