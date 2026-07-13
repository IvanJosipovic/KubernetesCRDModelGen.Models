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
/// <summary>JobTrigger is the Schema for the JobTriggers API. A job trigger configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2JobTriggerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2JobTrigger>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "JobTriggerList";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "jobtriggers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalossprevention.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobTriggerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2JobTrigger objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2JobTrigger> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecDeletionPolicyEnum>))]
public enum V1beta2JobTriggerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// User specified deidentify templates and configs for structured, unstructured, and image files.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationConfig
{
    /// <summary>If this template is specified, it will serve as the default de-identify template.</summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for images.</summary>
    [JsonPropertyName("imageRedactTemplate")]
    public string? ImageRedactTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for structured content such as delimited files and tables.</summary>
    [JsonPropertyName("structuredDeidentifyTemplate")]
    public string? StructuredDeidentifyTemplate { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelector
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
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelector
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
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The BigQuery table in which to store the output.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Config for storing transformation details.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig
{
    /// <summary>
    /// The BigQuery table in which to store the output.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("table")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable? Table { get; set; }
}

/// <summary>
/// Create a de-identified copy of the requested table or files.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentify
{
    /// <summary>
    /// User settable Cloud Storage bucket and folders to store de-identified files.
    /// This field must be set for cloud storage deidentification.
    /// The output Cloud Storage bucket must be different from the input bucket.
    /// De-identified files will overwrite files in the output path.
    /// Form of: gs://bucket/folder/ or gs://bucket
    /// </summary>
    [JsonPropertyName("cloudStorageOutput")]
    public string? CloudStorageOutput { get; set; }

    /// <summary>
    /// List of user-specified file type groups to transform. If specified, only the files with these filetypes will be transformed.
    /// If empty, all supported files will be transformed. Supported types may be automatically added over time.
    /// If a file type is set in this field that isn&apos;t supported by the Deidentify action then the job will fail and will not be successfully created/started.
    /// Each value may be one of: IMAGE, TEXT_FILE, CSV, TSV.
    /// </summary>
    [JsonPropertyName("fileTypesToTransform")]
    public IList<string>? FileTypesToTransform { get; set; }

    /// <summary>
    /// User specified deidentify templates and configs for structured, unstructured, and image files.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformationConfig")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationConfig? TransformationConfig { get; set; }

    /// <summary>
    /// Config for storing transformation details.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformationDetailsStorageConfig")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig? TransformationDetailsStorageConfig { get; set; }
}

/// <summary>Sends an email when the job completes. The email goes to IAM project owners and technical Essential Contacts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsJobNotificationEmails
{
}

/// <summary>
/// Publish a message into a given Pub/Sub topic when the job completes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsPubSub
{
    /// <summary>Cloud Pub/Sub topic to send notifications to.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>Publish findings of a DlpJob to Data Catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsPublishFindingsToCloudDataCatalog
{
}

/// <summary>Publish the result summary of a DlpJob to the Cloud Security Command Center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsPublishSummaryToCscc
{
}

/// <summary>Enable Stackdriver metric dlp.googleapis.com/findingCount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsPublishToStackdriver
{
}

/// <summary>
/// The BigQuery table in which to store the output.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsSaveFindingsOutputConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Information on where to store output
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsSaveFindingsOutputConfig
{
    /// <summary>
    /// Schema used for writing the findings for Inspect jobs. This field is only used for
    /// Inspect and must be unspecified for Risk jobs. Columns are derived from the Finding
    /// object. If appending to an existing table, any columns from the predefined schema
    /// that are missing will be added. No columns in the existing table will be deleted.
    /// If unspecified, then all available columns will be used for a new table or an (existing)
    /// table with no schema, and no changes will be made to an existing table that has a schema.
    /// Only for use with external storage.
    /// Possible values are: BASIC_COLUMNS, GCS_COLUMNS, DATASTORE_COLUMNS, BIG_QUERY_COLUMNS, ALL_COLUMNS.
    /// </summary>
    [JsonPropertyName("outputSchema")]
    public string? OutputSchema { get; set; }

    /// <summary>
    /// The BigQuery table in which to store the output.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("table")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsSaveFindingsOutputConfigTable? Table { get; set; }
}

/// <summary>
/// If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of this action can be specified. Compatible with: Inspect, Risk
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActionsSaveFindings
{
    /// <summary>
    /// Information on where to store output
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputConfig")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsSaveFindingsOutputConfig? OutputConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobActions
{
    /// <summary>
    /// Create a de-identified copy of the requested table or files.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deidentify")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsDeidentify? Deidentify { get; set; }

    /// <summary>Sends an email when the job completes. The email goes to IAM project owners and technical Essential Contacts.</summary>
    [JsonPropertyName("jobNotificationEmails")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsJobNotificationEmails? JobNotificationEmails { get; set; }

    /// <summary>
    /// Publish a message into a given Pub/Sub topic when the job completes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubSub")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsPubSub? PubSub { get; set; }

    /// <summary>Publish findings of a DlpJob to Data Catalog.</summary>
    [JsonPropertyName("publishFindingsToCloudDataCatalog")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsPublishFindingsToCloudDataCatalog? PublishFindingsToCloudDataCatalog { get; set; }

    /// <summary>Publish the result summary of a DlpJob to the Cloud Security Command Center.</summary>
    [JsonPropertyName("publishSummaryToCscc")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsPublishSummaryToCscc? PublishSummaryToCscc { get; set; }

    /// <summary>Enable Stackdriver metric dlp.googleapis.com/findingCount.</summary>
    [JsonPropertyName("publishToStackdriver")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsPublishToStackdriver? PublishToStackdriver { get; set; }

    /// <summary>
    /// If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of this action can be specified. Compatible with: Inspect, Risk
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("saveFindings")]
    public V1beta2JobTriggerSpecForProviderInspectJobActionsSaveFindings? SaveFindings { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesInfoType
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore? SensitivityScore { get; set; }

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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesRegex
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesStoredType
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesSurrogateType
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypes
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesDictionary? Dictionary { get; set; }

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
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesInfoType? InfoType { get; set; }

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
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesRegex? Regex { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>
    /// A reference to a StoredInfoType to use with scanning.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storedType")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesStoredType? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypesSurrogateType? SurrogateType { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigInfoTypes
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigInfoTypesSensitivityScore? SensitivityScore { get; set; }

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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>
    /// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
    /// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
    /// specified in another InfoTypeLimit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoType")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType? InfoType { get; set; }

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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigLimits
{
    /// <summary>
    /// Configuration of findings limit given for specified infoTypes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetInfoTypes
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore? SensitivityScore { get; set; }

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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
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
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity? Proximity { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>When true, excludes type information of the findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary? Dictionary { get; set; }

    /// <summary>
    /// Drop if the hotword rule is contained in the proximate context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeByHotword")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes? ExcludeInfoTypes { get; set; }

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
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex? Regex { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity
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
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Likelihood adjustment to apply to all matching findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment? LikelihoodAdjustment { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity? Proximity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRules
{
    /// <summary>
    /// The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exclusionRule")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesExclusionRule? ExclusionRule { get; set; }

    /// <summary>
    /// Hotword-based detection rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRule")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRulesHotwordRule? HotwordRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSet
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Set of rules to be applied to infoTypes. The rules are applied in order.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSetRules>? Rules { get; set; }
}

/// <summary>
/// The core content of the template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobInspectConfig
{
    /// <summary>
    /// Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Configuration to control the number of findings returned.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("limits")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfigLimits? Limits { get; set; }

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
    public IList<V1beta2JobTriggerSpecForProviderInspectJobInspectConfigRuleSet>? RuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsExcludedFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsIncludedFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Set of files to scan.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsTableReference
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Options defining BigQuery table and row identifiers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptions
{
    /// <summary>
    /// References to fields excluded from scanning.
    /// This allows you to skip inspection of entire columns which you know have no findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludedFields")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsExcludedFields>? ExcludedFields { get; set; }

    /// <summary>
    /// The columns that are the primary keys for table objects included in ContentItem. A copy of this
    /// cell&apos;s value will stored alongside alongside each finding so that the finding can be traced to
    /// the specific row it came from. No more than 3 may be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields>? IdentifyingFields { get; set; }

    /// <summary>
    /// Limit scanning only to these fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includedFields")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsIncludedFields>? IncludedFields { get; set; }

    /// <summary>
    /// Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted.
    /// If not set, or if set to 0, all rows will be scanned. Only one of rowsLimit and rowsLimitPercent can be
    /// specified. Cannot be used in conjunction with TimespanConfig.
    /// </summary>
    [JsonPropertyName("rowsLimit")]
    public double? RowsLimit { get; set; }

    /// <summary>
    /// Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of
    /// rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.
    /// </summary>
    [JsonPropertyName("rowsLimitPercent")]
    public double? RowsLimitPercent { get; set; }

    /// <summary>
    /// How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile.
    /// If not specified, scanning would start from the top.
    /// Possible values are: TOP, RANDOM_START.
    /// </summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }

    /// <summary>
    /// Set of files to scan.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tableReference")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptionsTableReference? TableReference { get; set; }
}

/// <summary>
/// The regex-filtered set of files to scan.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet
{
    /// <summary>The name of a Cloud Storage bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>
    /// A list of regular expressions matching file paths to exclude. All files in the bucket that match at
    /// least one of these regular expressions will be excluded from the scan.
    /// </summary>
    [JsonPropertyName("excludeRegex")]
    public IList<string>? ExcludeRegex { get; set; }

    /// <summary>
    /// A list of regular expressions matching file paths to include. All files in the bucket
    /// that match at least one of these regular expressions will be included in the set of files,
    /// except for those that also match an item in excludeRegex. Leaving this field empty will
    /// match all files by default (this is equivalent to including .* in the list)
    /// </summary>
    [JsonPropertyName("includeRegex")]
    public IList<string>? IncludeRegex { get; set; }
}

/// <summary>
/// Set of files to scan.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptionsFileSet
{
    /// <summary>
    /// The regex-filtered set of files to scan.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regexFileSet")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet? RegexFileSet { get; set; }

    /// <summary>
    /// The Cloud Storage url of the file(s) to scan, in the format gs://&lt;bucket&gt;/&lt;path&gt;. Trailing wildcard
    /// in the path is allowed.
    /// If the url ends in a trailing slash, the bucket or directory represented by the url will be scanned
    /// non-recursively (content in sub-directories will not be scanned). This means that gs://mybucket/ is
    /// equivalent to gs://mybucket/*, and gs://mybucket/directory/ is equivalent to gs://mybucket/directory/*.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Options defining a file or a set of files within a Google Cloud Storage bucket.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptions
{
    /// <summary>
    /// Max number of bytes to scan from a file. If a scanned file&apos;s size is bigger than this value
    /// then the rest of the bytes are omitted.
    /// </summary>
    [JsonPropertyName("bytesLimitPerFile")]
    public double? BytesLimitPerFile { get; set; }

    /// <summary>
    /// Max percentage of bytes to scan from a file. The rest are omitted. The number of bytes scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.
    /// </summary>
    [JsonPropertyName("bytesLimitPerFilePercent")]
    public double? BytesLimitPerFilePercent { get; set; }

    /// <summary>
    /// Set of files to scan.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fileSet")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptionsFileSet? FileSet { get; set; }

    /// <summary>
    /// List of file type groups to include in the scan. If empty, all files are scanned and available data
    /// format processors are applied. In addition, the binary content of the selected files is always scanned as well.
    /// Images are scanned only as binary if the specified region does not support image inspection and no fileTypes were specified.
    /// Each value may be one of: BINARY_FILE, TEXT_FILE, IMAGE, WORD, PDF, AVRO, CSV, TSV, POWERPOINT, EXCEL.
    /// </summary>
    [JsonPropertyName("fileTypes")]
    public IList<string>? FileTypes { get; set; }

    /// <summary>
    /// Limits the number of files to scan to this percentage of the input FileSet. Number of files scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.
    /// </summary>
    [JsonPropertyName("filesLimitPercent")]
    public double? FilesLimitPercent { get; set; }

    /// <summary>
    /// How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile.
    /// If not specified, scanning would start from the top.
    /// Possible values are: TOP, RANDOM_START.
    /// </summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }
}

/// <summary>
/// A representation of a Datastore kind.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptionsKind
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Datastore partition ID. A partition ID identifies a grouping of entities. The grouping
/// is always by project and namespace, however the namespace ID may be empty.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptionsPartitionId
{
    /// <summary>If not empty, the ID of the namespace to which the entities belong.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// Options defining a data set within Google Cloud Datastore.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptions
{
    /// <summary>
    /// A representation of a Datastore kind.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kind")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptionsKind? Kind { get; set; }

    /// <summary>
    /// Datastore partition ID. A partition ID identifies a grouping of entities. The grouping
    /// is always by project and namespace, however the namespace ID may be empty.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("partitionId")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptionsPartitionId? PartitionId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// If the container is a table, additional information to make findings meaningful such as the columns that are primary keys.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigHybridOptionsTableOptions
{
    /// <summary>
    /// The columns that are the primary keys for table objects included in ContentItem. A copy of this
    /// cell&apos;s value will stored alongside alongside each finding so that the finding can be traced to
    /// the specific row it came from. No more than 3 may be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields>? IdentifyingFields { get; set; }
}

/// <summary>
/// Configuration to control jobs where the content being inspected is outside of Google Cloud Platform.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigHybridOptions
{
    /// <summary>A short description of where the data is coming from. Will be stored once in the job. 256 max length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// To organize findings, these labels will be added to each finding.
    /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?.
    /// Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?.
    /// No more than 10 labels can be associated with a given finding.
    /// Examples:
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// These are labels that each inspection request must include within their &apos;finding_labels&apos; map. Request
    /// may contain others, but any missing one of these will be rejected.
    /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?.
    /// No more than 10 keys can be required.
    /// </summary>
    [JsonPropertyName("requiredFindingLabelKeys")]
    public IList<string>? RequiredFindingLabelKeys { get; set; }

    /// <summary>
    /// If the container is a table, additional information to make findings meaningful such as the columns that are primary keys.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tableOptions")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigHybridOptionsTableOptions? TableOptions { get; set; }
}

/// <summary>
/// Specification of the field containing the timestamp of scanned items.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigTimespanConfigTimestampField
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Configuration of the timespan of the items to include in scanning
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfigTimespanConfig
{
    /// <summary>
    /// When the job is started by a JobTrigger we will automatically figure out a valid startTime to avoid
    /// scanning files that have not been modified since the last time the JobTrigger executed. This will
    /// be based on the time of the execution of the last run of the JobTrigger or the timespan endTime
    /// used in the last run of the JobTrigger.
    /// </summary>
    [JsonPropertyName("enableAutoPopulationOfTimespanConfig")]
    public bool? EnableAutoPopulationOfTimespanConfig { get; set; }

    /// <summary>Exclude files, tables, or rows newer than this value. If not set, no upper time limit is applied.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Exclude files, tables, or rows older than this value. If not set, no lower time limit is applied.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Specification of the field containing the timestamp of scanned items.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timestampField")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigTimespanConfigTimestampField? TimestampField { get; set; }
}

/// <summary>
/// Information on where to inspect
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJobStorageConfig
{
    /// <summary>
    /// Options defining BigQuery table and row identifiers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigQueryOptions")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigBigQueryOptions? BigQueryOptions { get; set; }

    /// <summary>
    /// Options defining a file or a set of files within a Google Cloud Storage bucket.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorageOptions")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigCloudStorageOptions? CloudStorageOptions { get; set; }

    /// <summary>
    /// Options defining a data set within Google Cloud Datastore.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("datastoreOptions")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigDatastoreOptions? DatastoreOptions { get; set; }

    /// <summary>
    /// Configuration to control jobs where the content being inspected is outside of Google Cloud Platform.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hybridOptions")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigHybridOptions? HybridOptions { get; set; }

    /// <summary>
    /// Configuration of the timespan of the items to include in scanning
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timespanConfig")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfigTimespanConfig? TimespanConfig { get; set; }
}

/// <summary>
/// Controls what and how to inspect for findings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderInspectJob
{
    /// <summary>
    /// Configuration block for the actions to execute on the completion of a job. Can be specified multiple times, but only one for each type. Each action block supports fields documented below. This argument is processed in attribute-as-blocks mode.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("actions")]
    public IList<V1beta2JobTriggerSpecForProviderInspectJobActions>? Actions { get; set; }

    /// <summary>
    /// The core content of the template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inspectConfig")]
    public V1beta2JobTriggerSpecForProviderInspectJobInspectConfig? InspectConfig { get; set; }

    /// <summary>The name of the template to run when this job is triggered.</summary>
    [JsonPropertyName("inspectTemplateName")]
    public string? InspectTemplateName { get; set; }

    /// <summary>
    /// Information on where to inspect
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storageConfig")]
    public V1beta2JobTriggerSpecForProviderInspectJobStorageConfig? StorageConfig { get; set; }
}

/// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderTriggersManual
{
}

/// <summary>
/// Schedule for triggered jobs
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderTriggersSchedule
{
    /// <summary>
    /// With this option a job is started a regular periodic basis. For example: every day (86400 seconds).
    /// A scheduled start time will be skipped if the previous execution has not ended when its scheduled time occurs.
    /// This value must be set to a time duration greater than or equal to 1 day and can be no longer than 60 days.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("recurrencePeriodDuration")]
    public string? RecurrencePeriodDuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProviderTriggers
{
    /// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
    [JsonPropertyName("manual")]
    public V1beta2JobTriggerSpecForProviderTriggersManual? Manual { get; set; }

    /// <summary>
    /// Schedule for triggered jobs
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1beta2JobTriggerSpecForProviderTriggersSchedule? Schedule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecForProvider
{
    /// <summary>A description of the job trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the job trigger.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Controls what and how to inspect for findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inspectJob")]
    public V1beta2JobTriggerSpecForProviderInspectJob? InspectJob { get; set; }

    /// <summary>
    /// The parent of the trigger, either in the format projects/{{project}}
    /// or projects/{{project}}/locations/{{location}}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Whether the trigger is currently active.
    /// Default value is HEALTHY.
    /// Possible values are: PAUSED, HEALTHY, CANCELLED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The trigger id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+.
    /// The maximum length is 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; set; }

    /// <summary>
    /// What event needs to occur for a new job to be started.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta2JobTriggerSpecForProviderTriggers>? Triggers { get; set; }
}

/// <summary>
/// User specified deidentify templates and configs for structured, unstructured, and image files.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationConfig
{
    /// <summary>If this template is specified, it will serve as the default de-identify template.</summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for images.</summary>
    [JsonPropertyName("imageRedactTemplate")]
    public string? ImageRedactTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for structured content such as delimited files and tables.</summary>
    [JsonPropertyName("structuredDeidentifyTemplate")]
    public string? StructuredDeidentifyTemplate { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelector
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
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelector
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
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The BigQuery table in which to store the output.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Config for storing transformation details.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig
{
    /// <summary>
    /// The BigQuery table in which to store the output.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("table")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable? Table { get; set; }
}

/// <summary>
/// Create a de-identified copy of the requested table or files.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentify
{
    /// <summary>
    /// User settable Cloud Storage bucket and folders to store de-identified files.
    /// This field must be set for cloud storage deidentification.
    /// The output Cloud Storage bucket must be different from the input bucket.
    /// De-identified files will overwrite files in the output path.
    /// Form of: gs://bucket/folder/ or gs://bucket
    /// </summary>
    [JsonPropertyName("cloudStorageOutput")]
    public string? CloudStorageOutput { get; set; }

    /// <summary>
    /// List of user-specified file type groups to transform. If specified, only the files with these filetypes will be transformed.
    /// If empty, all supported files will be transformed. Supported types may be automatically added over time.
    /// If a file type is set in this field that isn&apos;t supported by the Deidentify action then the job will fail and will not be successfully created/started.
    /// Each value may be one of: IMAGE, TEXT_FILE, CSV, TSV.
    /// </summary>
    [JsonPropertyName("fileTypesToTransform")]
    public IList<string>? FileTypesToTransform { get; set; }

    /// <summary>
    /// User specified deidentify templates and configs for structured, unstructured, and image files.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformationConfig")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationConfig? TransformationConfig { get; set; }

    /// <summary>
    /// Config for storing transformation details.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformationDetailsStorageConfig")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig? TransformationDetailsStorageConfig { get; set; }
}

/// <summary>Sends an email when the job completes. The email goes to IAM project owners and technical Essential Contacts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsJobNotificationEmails
{
}

/// <summary>
/// Publish a message into a given Pub/Sub topic when the job completes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsPubSub
{
    /// <summary>Cloud Pub/Sub topic to send notifications to.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>Publish findings of a DlpJob to Data Catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsPublishFindingsToCloudDataCatalog
{
}

/// <summary>Publish the result summary of a DlpJob to the Cloud Security Command Center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsPublishSummaryToCscc
{
}

/// <summary>Enable Stackdriver metric dlp.googleapis.com/findingCount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsPublishToStackdriver
{
}

/// <summary>
/// The BigQuery table in which to store the output.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsSaveFindingsOutputConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Information on where to store output
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsSaveFindingsOutputConfig
{
    /// <summary>
    /// Schema used for writing the findings for Inspect jobs. This field is only used for
    /// Inspect and must be unspecified for Risk jobs. Columns are derived from the Finding
    /// object. If appending to an existing table, any columns from the predefined schema
    /// that are missing will be added. No columns in the existing table will be deleted.
    /// If unspecified, then all available columns will be used for a new table or an (existing)
    /// table with no schema, and no changes will be made to an existing table that has a schema.
    /// Only for use with external storage.
    /// Possible values are: BASIC_COLUMNS, GCS_COLUMNS, DATASTORE_COLUMNS, BIG_QUERY_COLUMNS, ALL_COLUMNS.
    /// </summary>
    [JsonPropertyName("outputSchema")]
    public string? OutputSchema { get; set; }

    /// <summary>
    /// The BigQuery table in which to store the output.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("table")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsSaveFindingsOutputConfigTable? Table { get; set; }
}

/// <summary>
/// If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of this action can be specified. Compatible with: Inspect, Risk
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActionsSaveFindings
{
    /// <summary>
    /// Information on where to store output
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputConfig")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsSaveFindingsOutputConfig? OutputConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobActions
{
    /// <summary>
    /// Create a de-identified copy of the requested table or files.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deidentify")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsDeidentify? Deidentify { get; set; }

    /// <summary>Sends an email when the job completes. The email goes to IAM project owners and technical Essential Contacts.</summary>
    [JsonPropertyName("jobNotificationEmails")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsJobNotificationEmails? JobNotificationEmails { get; set; }

    /// <summary>
    /// Publish a message into a given Pub/Sub topic when the job completes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubSub")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsPubSub? PubSub { get; set; }

    /// <summary>Publish findings of a DlpJob to Data Catalog.</summary>
    [JsonPropertyName("publishFindingsToCloudDataCatalog")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsPublishFindingsToCloudDataCatalog? PublishFindingsToCloudDataCatalog { get; set; }

    /// <summary>Publish the result summary of a DlpJob to the Cloud Security Command Center.</summary>
    [JsonPropertyName("publishSummaryToCscc")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsPublishSummaryToCscc? PublishSummaryToCscc { get; set; }

    /// <summary>Enable Stackdriver metric dlp.googleapis.com/findingCount.</summary>
    [JsonPropertyName("publishToStackdriver")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsPublishToStackdriver? PublishToStackdriver { get; set; }

    /// <summary>
    /// If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of this action can be specified. Compatible with: Inspect, Risk
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("saveFindings")]
    public V1beta2JobTriggerSpecInitProviderInspectJobActionsSaveFindings? SaveFindings { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesInfoType
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore? SensitivityScore { get; set; }

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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesRegex
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesStoredType
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesSurrogateType
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypes
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesDictionary? Dictionary { get; set; }

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
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesInfoType? InfoType { get; set; }

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
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesRegex? Regex { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>
    /// A reference to a StoredInfoType to use with scanning.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storedType")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesStoredType? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypesSurrogateType? SurrogateType { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigInfoTypes
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigInfoTypesSensitivityScore? SensitivityScore { get; set; }

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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>
    /// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
    /// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
    /// specified in another InfoTypeLimit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoType")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType? InfoType { get; set; }

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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigLimits
{
    /// <summary>
    /// Configuration of findings limit given for specified infoTypes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetInfoTypes
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore? SensitivityScore { get; set; }

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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
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
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity? Proximity { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>When true, excludes type information of the findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary? Dictionary { get; set; }

    /// <summary>
    /// Drop if the hotword rule is contained in the proximate context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeByHotword")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes? ExcludeInfoTypes { get; set; }

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
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex? Regex { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity
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
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Likelihood adjustment to apply to all matching findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment? LikelihoodAdjustment { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity? Proximity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRules
{
    /// <summary>
    /// The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exclusionRule")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesExclusionRule? ExclusionRule { get; set; }

    /// <summary>
    /// Hotword-based detection rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRule")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRulesHotwordRule? HotwordRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSet
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Set of rules to be applied to infoTypes. The rules are applied in order.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSetRules>? Rules { get; set; }
}

/// <summary>
/// The core content of the template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobInspectConfig
{
    /// <summary>
    /// Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Configuration to control the number of findings returned.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("limits")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigLimits? Limits { get; set; }

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
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobInspectConfigRuleSet>? RuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsExcludedFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsIncludedFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Set of files to scan.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsTableReference
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Options defining BigQuery table and row identifiers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptions
{
    /// <summary>
    /// References to fields excluded from scanning.
    /// This allows you to skip inspection of entire columns which you know have no findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludedFields")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsExcludedFields>? ExcludedFields { get; set; }

    /// <summary>
    /// The columns that are the primary keys for table objects included in ContentItem. A copy of this
    /// cell&apos;s value will stored alongside alongside each finding so that the finding can be traced to
    /// the specific row it came from. No more than 3 may be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields>? IdentifyingFields { get; set; }

    /// <summary>
    /// Limit scanning only to these fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includedFields")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsIncludedFields>? IncludedFields { get; set; }

    /// <summary>
    /// Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted.
    /// If not set, or if set to 0, all rows will be scanned. Only one of rowsLimit and rowsLimitPercent can be
    /// specified. Cannot be used in conjunction with TimespanConfig.
    /// </summary>
    [JsonPropertyName("rowsLimit")]
    public double? RowsLimit { get; set; }

    /// <summary>
    /// Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of
    /// rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.
    /// </summary>
    [JsonPropertyName("rowsLimitPercent")]
    public double? RowsLimitPercent { get; set; }

    /// <summary>
    /// How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile.
    /// If not specified, scanning would start from the top.
    /// Possible values are: TOP, RANDOM_START.
    /// </summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }

    /// <summary>
    /// Set of files to scan.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tableReference")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptionsTableReference? TableReference { get; set; }
}

/// <summary>
/// The regex-filtered set of files to scan.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet
{
    /// <summary>The name of a Cloud Storage bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>
    /// A list of regular expressions matching file paths to exclude. All files in the bucket that match at
    /// least one of these regular expressions will be excluded from the scan.
    /// </summary>
    [JsonPropertyName("excludeRegex")]
    public IList<string>? ExcludeRegex { get; set; }

    /// <summary>
    /// A list of regular expressions matching file paths to include. All files in the bucket
    /// that match at least one of these regular expressions will be included in the set of files,
    /// except for those that also match an item in excludeRegex. Leaving this field empty will
    /// match all files by default (this is equivalent to including .* in the list)
    /// </summary>
    [JsonPropertyName("includeRegex")]
    public IList<string>? IncludeRegex { get; set; }
}

/// <summary>
/// Set of files to scan.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptionsFileSet
{
    /// <summary>
    /// The regex-filtered set of files to scan.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regexFileSet")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet? RegexFileSet { get; set; }

    /// <summary>
    /// The Cloud Storage url of the file(s) to scan, in the format gs://&lt;bucket&gt;/&lt;path&gt;. Trailing wildcard
    /// in the path is allowed.
    /// If the url ends in a trailing slash, the bucket or directory represented by the url will be scanned
    /// non-recursively (content in sub-directories will not be scanned). This means that gs://mybucket/ is
    /// equivalent to gs://mybucket/*, and gs://mybucket/directory/ is equivalent to gs://mybucket/directory/*.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Options defining a file or a set of files within a Google Cloud Storage bucket.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptions
{
    /// <summary>
    /// Max number of bytes to scan from a file. If a scanned file&apos;s size is bigger than this value
    /// then the rest of the bytes are omitted.
    /// </summary>
    [JsonPropertyName("bytesLimitPerFile")]
    public double? BytesLimitPerFile { get; set; }

    /// <summary>
    /// Max percentage of bytes to scan from a file. The rest are omitted. The number of bytes scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.
    /// </summary>
    [JsonPropertyName("bytesLimitPerFilePercent")]
    public double? BytesLimitPerFilePercent { get; set; }

    /// <summary>
    /// Set of files to scan.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fileSet")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptionsFileSet? FileSet { get; set; }

    /// <summary>
    /// List of file type groups to include in the scan. If empty, all files are scanned and available data
    /// format processors are applied. In addition, the binary content of the selected files is always scanned as well.
    /// Images are scanned only as binary if the specified region does not support image inspection and no fileTypes were specified.
    /// Each value may be one of: BINARY_FILE, TEXT_FILE, IMAGE, WORD, PDF, AVRO, CSV, TSV, POWERPOINT, EXCEL.
    /// </summary>
    [JsonPropertyName("fileTypes")]
    public IList<string>? FileTypes { get; set; }

    /// <summary>
    /// Limits the number of files to scan to this percentage of the input FileSet. Number of files scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.
    /// </summary>
    [JsonPropertyName("filesLimitPercent")]
    public double? FilesLimitPercent { get; set; }

    /// <summary>
    /// How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile.
    /// If not specified, scanning would start from the top.
    /// Possible values are: TOP, RANDOM_START.
    /// </summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }
}

/// <summary>
/// A representation of a Datastore kind.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptionsKind
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Datastore partition ID. A partition ID identifies a grouping of entities. The grouping
/// is always by project and namespace, however the namespace ID may be empty.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptionsPartitionId
{
    /// <summary>If not empty, the ID of the namespace to which the entities belong.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// Options defining a data set within Google Cloud Datastore.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptions
{
    /// <summary>
    /// A representation of a Datastore kind.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kind")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptionsKind? Kind { get; set; }

    /// <summary>
    /// Datastore partition ID. A partition ID identifies a grouping of entities. The grouping
    /// is always by project and namespace, however the namespace ID may be empty.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("partitionId")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptionsPartitionId? PartitionId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// If the container is a table, additional information to make findings meaningful such as the columns that are primary keys.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptionsTableOptions
{
    /// <summary>
    /// The columns that are the primary keys for table objects included in ContentItem. A copy of this
    /// cell&apos;s value will stored alongside alongside each finding so that the finding can be traced to
    /// the specific row it came from. No more than 3 may be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields>? IdentifyingFields { get; set; }
}

/// <summary>
/// Configuration to control jobs where the content being inspected is outside of Google Cloud Platform.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptions
{
    /// <summary>A short description of where the data is coming from. Will be stored once in the job. 256 max length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// To organize findings, these labels will be added to each finding.
    /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?.
    /// Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?.
    /// No more than 10 labels can be associated with a given finding.
    /// Examples:
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// These are labels that each inspection request must include within their &apos;finding_labels&apos; map. Request
    /// may contain others, but any missing one of these will be rejected.
    /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?.
    /// No more than 10 keys can be required.
    /// </summary>
    [JsonPropertyName("requiredFindingLabelKeys")]
    public IList<string>? RequiredFindingLabelKeys { get; set; }

    /// <summary>
    /// If the container is a table, additional information to make findings meaningful such as the columns that are primary keys.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tableOptions")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptionsTableOptions? TableOptions { get; set; }
}

/// <summary>
/// Specification of the field containing the timestamp of scanned items.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigTimespanConfigTimestampField
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Configuration of the timespan of the items to include in scanning
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigTimespanConfig
{
    /// <summary>
    /// When the job is started by a JobTrigger we will automatically figure out a valid startTime to avoid
    /// scanning files that have not been modified since the last time the JobTrigger executed. This will
    /// be based on the time of the execution of the last run of the JobTrigger or the timespan endTime
    /// used in the last run of the JobTrigger.
    /// </summary>
    [JsonPropertyName("enableAutoPopulationOfTimespanConfig")]
    public bool? EnableAutoPopulationOfTimespanConfig { get; set; }

    /// <summary>Exclude files, tables, or rows newer than this value. If not set, no upper time limit is applied.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Exclude files, tables, or rows older than this value. If not set, no lower time limit is applied.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Specification of the field containing the timestamp of scanned items.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timestampField")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigTimespanConfigTimestampField? TimestampField { get; set; }
}

/// <summary>
/// Information on where to inspect
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJobStorageConfig
{
    /// <summary>
    /// Options defining BigQuery table and row identifiers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigQueryOptions")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigBigQueryOptions? BigQueryOptions { get; set; }

    /// <summary>
    /// Options defining a file or a set of files within a Google Cloud Storage bucket.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorageOptions")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigCloudStorageOptions? CloudStorageOptions { get; set; }

    /// <summary>
    /// Options defining a data set within Google Cloud Datastore.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("datastoreOptions")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigDatastoreOptions? DatastoreOptions { get; set; }

    /// <summary>
    /// Configuration to control jobs where the content being inspected is outside of Google Cloud Platform.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hybridOptions")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigHybridOptions? HybridOptions { get; set; }

    /// <summary>
    /// Configuration of the timespan of the items to include in scanning
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timespanConfig")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfigTimespanConfig? TimespanConfig { get; set; }
}

/// <summary>
/// Controls what and how to inspect for findings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderInspectJob
{
    /// <summary>
    /// Configuration block for the actions to execute on the completion of a job. Can be specified multiple times, but only one for each type. Each action block supports fields documented below. This argument is processed in attribute-as-blocks mode.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("actions")]
    public IList<V1beta2JobTriggerSpecInitProviderInspectJobActions>? Actions { get; set; }

    /// <summary>
    /// The core content of the template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inspectConfig")]
    public V1beta2JobTriggerSpecInitProviderInspectJobInspectConfig? InspectConfig { get; set; }

    /// <summary>The name of the template to run when this job is triggered.</summary>
    [JsonPropertyName("inspectTemplateName")]
    public string? InspectTemplateName { get; set; }

    /// <summary>
    /// Information on where to inspect
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storageConfig")]
    public V1beta2JobTriggerSpecInitProviderInspectJobStorageConfig? StorageConfig { get; set; }
}

/// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderTriggersManual
{
}

/// <summary>
/// Schedule for triggered jobs
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderTriggersSchedule
{
    /// <summary>
    /// With this option a job is started a regular periodic basis. For example: every day (86400 seconds).
    /// A scheduled start time will be skipped if the previous execution has not ended when its scheduled time occurs.
    /// This value must be set to a time duration greater than or equal to 1 day and can be no longer than 60 days.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("recurrencePeriodDuration")]
    public string? RecurrencePeriodDuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecInitProviderTriggers
{
    /// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
    [JsonPropertyName("manual")]
    public V1beta2JobTriggerSpecInitProviderTriggersManual? Manual { get; set; }

    /// <summary>
    /// Schedule for triggered jobs
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1beta2JobTriggerSpecInitProviderTriggersSchedule? Schedule { get; set; }
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
public partial class V1beta2JobTriggerSpecInitProvider
{
    /// <summary>A description of the job trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the job trigger.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Controls what and how to inspect for findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inspectJob")]
    public V1beta2JobTriggerSpecInitProviderInspectJob? InspectJob { get; set; }

    /// <summary>
    /// The parent of the trigger, either in the format projects/{{project}}
    /// or projects/{{project}}/locations/{{location}}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Whether the trigger is currently active.
    /// Default value is HEALTHY.
    /// Possible values are: PAUSED, HEALTHY, CANCELLED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The trigger id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+.
    /// The maximum length is 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; set; }

    /// <summary>
    /// What event needs to occur for a new job to be started.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta2JobTriggerSpecInitProviderTriggers>? Triggers { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecManagementPoliciesEnum>))]
public enum V1beta2JobTriggerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2JobTriggerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobTriggerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2JobTriggerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobTriggerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobTriggerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobTriggerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>JobTriggerSpec defines the desired state of JobTrigger</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerSpec
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
    public V1beta2JobTriggerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2JobTriggerSpecForProvider ForProvider { get; set; }

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
    public V1beta2JobTriggerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2JobTriggerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2JobTriggerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2JobTriggerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// User specified deidentify templates and configs for structured, unstructured, and image files.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationConfig
{
    /// <summary>If this template is specified, it will serve as the default de-identify template.</summary>
    [JsonPropertyName("deidentifyTemplate")]
    public string? DeidentifyTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for images.</summary>
    [JsonPropertyName("imageRedactTemplate")]
    public string? ImageRedactTemplate { get; set; }

    /// <summary>If this template is specified, it will serve as the de-identify template for structured content such as delimited files and tables.</summary>
    [JsonPropertyName("structuredDeidentifyTemplate")]
    public string? StructuredDeidentifyTemplate { get; set; }
}

/// <summary>
/// The BigQuery table in which to store the output.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Config for storing transformation details.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig
{
    /// <summary>
    /// The BigQuery table in which to store the output.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("table")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfigTable? Table { get; set; }
}

/// <summary>
/// Create a de-identified copy of the requested table or files.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsDeidentify
{
    /// <summary>
    /// User settable Cloud Storage bucket and folders to store de-identified files.
    /// This field must be set for cloud storage deidentification.
    /// The output Cloud Storage bucket must be different from the input bucket.
    /// De-identified files will overwrite files in the output path.
    /// Form of: gs://bucket/folder/ or gs://bucket
    /// </summary>
    [JsonPropertyName("cloudStorageOutput")]
    public string? CloudStorageOutput { get; set; }

    /// <summary>
    /// List of user-specified file type groups to transform. If specified, only the files with these filetypes will be transformed.
    /// If empty, all supported files will be transformed. Supported types may be automatically added over time.
    /// If a file type is set in this field that isn&apos;t supported by the Deidentify action then the job will fail and will not be successfully created/started.
    /// Each value may be one of: IMAGE, TEXT_FILE, CSV, TSV.
    /// </summary>
    [JsonPropertyName("fileTypesToTransform")]
    public IList<string>? FileTypesToTransform { get; set; }

    /// <summary>
    /// User specified deidentify templates and configs for structured, unstructured, and image files.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformationConfig")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationConfig? TransformationConfig { get; set; }

    /// <summary>
    /// Config for storing transformation details.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformationDetailsStorageConfig")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsDeidentifyTransformationDetailsStorageConfig? TransformationDetailsStorageConfig { get; set; }
}

/// <summary>Sends an email when the job completes. The email goes to IAM project owners and technical Essential Contacts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsJobNotificationEmails
{
}

/// <summary>
/// Publish a message into a given Pub/Sub topic when the job completes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsPubSub
{
    /// <summary>Cloud Pub/Sub topic to send notifications to.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>Publish findings of a DlpJob to Data Catalog.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsPublishFindingsToCloudDataCatalog
{
}

/// <summary>Publish the result summary of a DlpJob to the Cloud Security Command Center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsPublishSummaryToCscc
{
}

/// <summary>Enable Stackdriver metric dlp.googleapis.com/findingCount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsPublishToStackdriver
{
}

/// <summary>
/// The BigQuery table in which to store the output.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsSaveFindingsOutputConfigTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Information on where to store output
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsSaveFindingsOutputConfig
{
    /// <summary>
    /// Schema used for writing the findings for Inspect jobs. This field is only used for
    /// Inspect and must be unspecified for Risk jobs. Columns are derived from the Finding
    /// object. If appending to an existing table, any columns from the predefined schema
    /// that are missing will be added. No columns in the existing table will be deleted.
    /// If unspecified, then all available columns will be used for a new table or an (existing)
    /// table with no schema, and no changes will be made to an existing table that has a schema.
    /// Only for use with external storage.
    /// Possible values are: BASIC_COLUMNS, GCS_COLUMNS, DATASTORE_COLUMNS, BIG_QUERY_COLUMNS, ALL_COLUMNS.
    /// </summary>
    [JsonPropertyName("outputSchema")]
    public string? OutputSchema { get; set; }

    /// <summary>
    /// The BigQuery table in which to store the output.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("table")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsSaveFindingsOutputConfigTable? Table { get; set; }
}

/// <summary>
/// If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of this action can be specified. Compatible with: Inspect, Risk
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActionsSaveFindings
{
    /// <summary>
    /// Information on where to store output
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputConfig")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsSaveFindingsOutputConfig? OutputConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobActions
{
    /// <summary>
    /// Create a de-identified copy of the requested table or files.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deidentify")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsDeidentify? Deidentify { get; set; }

    /// <summary>Sends an email when the job completes. The email goes to IAM project owners and technical Essential Contacts.</summary>
    [JsonPropertyName("jobNotificationEmails")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsJobNotificationEmails? JobNotificationEmails { get; set; }

    /// <summary>
    /// Publish a message into a given Pub/Sub topic when the job completes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubSub")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsPubSub? PubSub { get; set; }

    /// <summary>Publish findings of a DlpJob to Data Catalog.</summary>
    [JsonPropertyName("publishFindingsToCloudDataCatalog")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsPublishFindingsToCloudDataCatalog? PublishFindingsToCloudDataCatalog { get; set; }

    /// <summary>Publish the result summary of a DlpJob to the Cloud Security Command Center.</summary>
    [JsonPropertyName("publishSummaryToCscc")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsPublishSummaryToCscc? PublishSummaryToCscc { get; set; }

    /// <summary>Enable Stackdriver metric dlp.googleapis.com/findingCount.</summary>
    [JsonPropertyName("publishToStackdriver")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsPublishToStackdriver? PublishToStackdriver { get; set; }

    /// <summary>
    /// If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of this action can be specified. Compatible with: Inspect, Risk
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("saveFindings")]
    public V1beta2JobTriggerStatusAtProviderInspectJobActionsSaveFindings? SaveFindings { get; set; }
}

/// <summary>
/// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesInfoType
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesInfoTypeSensitivityScore? SensitivityScore { get; set; }

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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesRegex
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesStoredType
{
    /// <summary>
    /// (Output)
    /// The creation timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesSurrogateType
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypes
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesDictionary? Dictionary { get; set; }

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
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesInfoType? InfoType { get; set; }

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
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesRegex? Regex { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>
    /// A reference to a StoredInfoType to use with scanning.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storedType")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesStoredType? StoredType { get; set; }

    /// <summary>Message for detecting output from deidentification transformations that support reversing.</summary>
    [JsonPropertyName("surrogateType")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypesSurrogateType? SurrogateType { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigInfoTypes
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigInfoTypesSensitivityScore? SensitivityScore { get; set; }

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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType
{
    /// <summary>
    /// Type of information the findings limit applies to. Only one limit per infoType should be provided. If InfoTypeLimit does
    /// not have an infoType, the DLP API applies the limit against all infoTypes that are found but not
    /// specified in another InfoTypeLimit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoType")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoTypeInfoType? InfoType { get; set; }

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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigLimits
{
    /// <summary>
    /// Configuration of findings limit given for specified infoTypes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxFindingsPerInfoType")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigLimitsMaxFindingsPerInfoType>? MaxFindingsPerInfoType { get; set; }

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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetInfoTypes
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetInfoTypesSensitivityScore? SensitivityScore { get; set; }

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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary
{
    /// <summary>
    /// Newline-delimited file of words in Cloud Storage. Only a single file is accepted.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>
    /// List of words or phrases to search for.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionaryWordList? WordList { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity
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
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotwordProximity? Proximity { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Version of the information type to use. By default, the version is set to stable</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>When true, excludes type information of the findings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypesInfoTypes>? InfoTypes { get; set; }
}

/// <summary>
/// Regular expression which defines the rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRule
{
    /// <summary>
    /// Dictionary which defines the rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dictionary")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleDictionary? Dictionary { get; set; }

    /// <summary>
    /// Drop if the hotword rule is contained in the proximate context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeByHotword")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeByHotword? ExcludeByHotword { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleExcludeInfoTypes? ExcludeInfoTypes { get; set; }

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
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRuleRegex? Regex { get; set; }
}

/// <summary>
/// Regular expression pattern defining what qualifies as a hotword.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity
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
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRule
{
    /// <summary>
    /// Regular expression pattern defining what qualifies as a hotword.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRegex")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleHotwordRegex? HotwordRegex { get; set; }

    /// <summary>
    /// Likelihood adjustment to apply to all matching findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("likelihoodAdjustment")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleLikelihoodAdjustment? LikelihoodAdjustment { get; set; }

    /// <summary>
    /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
    /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
    /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
    /// (\d{3}) \d{3}-\d{4} could be adjusted upwards if the area code is known to be the local area code of a company
    /// office using the hotword regex (xxx), where xxx is the area code in question.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("proximity")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRuleProximity? Proximity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRules
{
    /// <summary>
    /// The rule that specifies conditions when findings of infoTypes specified in InspectionRuleSet are removed from results.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exclusionRule")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesExclusionRule? ExclusionRule { get; set; }

    /// <summary>
    /// Hotword-based detection rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hotwordRule")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRulesHotwordRule? HotwordRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSet
{
    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Set of rules to be applied to infoTypes. The rules are applied in order.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSetRules>? Rules { get; set; }
}

/// <summary>
/// The core content of the template.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobInspectConfig
{
    /// <summary>
    /// Custom info types to be used. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customInfoTypes")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigCustomInfoTypes>? CustomInfoTypes { get; set; }

    /// <summary>When true, excludes type information of the findings.</summary>
    [JsonPropertyName("excludeInfoTypes")]
    public bool? ExcludeInfoTypes { get; set; }

    /// <summary>When true, a contextual quote from the data that triggered a finding is included in the response.</summary>
    [JsonPropertyName("includeQuote")]
    public bool? IncludeQuote { get; set; }

    /// <summary>
    /// List of infoTypes this rule set is applied to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Configuration to control the number of findings returned.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("limits")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigLimits? Limits { get; set; }

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
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobInspectConfigRuleSet>? RuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsExcludedFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsIncludedFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Set of files to scan.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsTableReference
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Options defining BigQuery table and row identifiers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptions
{
    /// <summary>
    /// References to fields excluded from scanning.
    /// This allows you to skip inspection of entire columns which you know have no findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludedFields")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsExcludedFields>? ExcludedFields { get; set; }

    /// <summary>
    /// The columns that are the primary keys for table objects included in ContentItem. A copy of this
    /// cell&apos;s value will stored alongside alongside each finding so that the finding can be traced to
    /// the specific row it came from. No more than 3 may be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsIdentifyingFields>? IdentifyingFields { get; set; }

    /// <summary>
    /// Limit scanning only to these fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includedFields")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsIncludedFields>? IncludedFields { get; set; }

    /// <summary>
    /// Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted.
    /// If not set, or if set to 0, all rows will be scanned. Only one of rowsLimit and rowsLimitPercent can be
    /// specified. Cannot be used in conjunction with TimespanConfig.
    /// </summary>
    [JsonPropertyName("rowsLimit")]
    public double? RowsLimit { get; set; }

    /// <summary>
    /// Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of
    /// rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.
    /// </summary>
    [JsonPropertyName("rowsLimitPercent")]
    public double? RowsLimitPercent { get; set; }

    /// <summary>
    /// How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile.
    /// If not specified, scanning would start from the top.
    /// Possible values are: TOP, RANDOM_START.
    /// </summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }

    /// <summary>
    /// Set of files to scan.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tableReference")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptionsTableReference? TableReference { get; set; }
}

/// <summary>
/// The regex-filtered set of files to scan.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet
{
    /// <summary>The name of a Cloud Storage bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>
    /// A list of regular expressions matching file paths to exclude. All files in the bucket that match at
    /// least one of these regular expressions will be excluded from the scan.
    /// </summary>
    [JsonPropertyName("excludeRegex")]
    public IList<string>? ExcludeRegex { get; set; }

    /// <summary>
    /// A list of regular expressions matching file paths to include. All files in the bucket
    /// that match at least one of these regular expressions will be included in the set of files,
    /// except for those that also match an item in excludeRegex. Leaving this field empty will
    /// match all files by default (this is equivalent to including .* in the list)
    /// </summary>
    [JsonPropertyName("includeRegex")]
    public IList<string>? IncludeRegex { get; set; }
}

/// <summary>
/// Set of files to scan.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptionsFileSet
{
    /// <summary>
    /// The regex-filtered set of files to scan.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("regexFileSet")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptionsFileSetRegexFileSet? RegexFileSet { get; set; }

    /// <summary>
    /// The Cloud Storage url of the file(s) to scan, in the format gs://&lt;bucket&gt;/&lt;path&gt;. Trailing wildcard
    /// in the path is allowed.
    /// If the url ends in a trailing slash, the bucket or directory represented by the url will be scanned
    /// non-recursively (content in sub-directories will not be scanned). This means that gs://mybucket/ is
    /// equivalent to gs://mybucket/*, and gs://mybucket/directory/ is equivalent to gs://mybucket/directory/*.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Options defining a file or a set of files within a Google Cloud Storage bucket.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptions
{
    /// <summary>
    /// Max number of bytes to scan from a file. If a scanned file&apos;s size is bigger than this value
    /// then the rest of the bytes are omitted.
    /// </summary>
    [JsonPropertyName("bytesLimitPerFile")]
    public double? BytesLimitPerFile { get; set; }

    /// <summary>
    /// Max percentage of bytes to scan from a file. The rest are omitted. The number of bytes scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.
    /// </summary>
    [JsonPropertyName("bytesLimitPerFilePercent")]
    public double? BytesLimitPerFilePercent { get; set; }

    /// <summary>
    /// Set of files to scan.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fileSet")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptionsFileSet? FileSet { get; set; }

    /// <summary>
    /// List of file type groups to include in the scan. If empty, all files are scanned and available data
    /// format processors are applied. In addition, the binary content of the selected files is always scanned as well.
    /// Images are scanned only as binary if the specified region does not support image inspection and no fileTypes were specified.
    /// Each value may be one of: BINARY_FILE, TEXT_FILE, IMAGE, WORD, PDF, AVRO, CSV, TSV, POWERPOINT, EXCEL.
    /// </summary>
    [JsonPropertyName("fileTypes")]
    public IList<string>? FileTypes { get; set; }

    /// <summary>
    /// Limits the number of files to scan to this percentage of the input FileSet. Number of files scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.
    /// </summary>
    [JsonPropertyName("filesLimitPercent")]
    public double? FilesLimitPercent { get; set; }

    /// <summary>
    /// How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile.
    /// If not specified, scanning would start from the top.
    /// Possible values are: TOP, RANDOM_START.
    /// </summary>
    [JsonPropertyName("sampleMethod")]
    public string? SampleMethod { get; set; }
}

/// <summary>
/// A representation of a Datastore kind.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptionsKind
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Datastore partition ID. A partition ID identifies a grouping of entities. The grouping
/// is always by project and namespace, however the namespace ID may be empty.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptionsPartitionId
{
    /// <summary>If not empty, the ID of the namespace to which the entities belong.</summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// Options defining a data set within Google Cloud Datastore.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptions
{
    /// <summary>
    /// A representation of a Datastore kind.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kind")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptionsKind? Kind { get; set; }

    /// <summary>
    /// Datastore partition ID. A partition ID identifies a grouping of entities. The grouping
    /// is always by project and namespace, however the namespace ID may be empty.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("partitionId")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptionsPartitionId? PartitionId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// If the container is a table, additional information to make findings meaningful such as the columns that are primary keys.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptionsTableOptions
{
    /// <summary>
    /// The columns that are the primary keys for table objects included in ContentItem. A copy of this
    /// cell&apos;s value will stored alongside alongside each finding so that the finding can be traced to
    /// the specific row it came from. No more than 3 may be provided.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identifyingFields")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptionsTableOptionsIdentifyingFields>? IdentifyingFields { get; set; }
}

/// <summary>
/// Configuration to control jobs where the content being inspected is outside of Google Cloud Platform.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptions
{
    /// <summary>A short description of where the data is coming from. Will be stored once in the job. 256 max length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// To organize findings, these labels will be added to each finding.
    /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?.
    /// Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?.
    /// No more than 10 labels can be associated with a given finding.
    /// Examples:
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// These are labels that each inspection request must include within their &apos;finding_labels&apos; map. Request
    /// may contain others, but any missing one of these will be rejected.
    /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?.
    /// No more than 10 keys can be required.
    /// </summary>
    [JsonPropertyName("requiredFindingLabelKeys")]
    public IList<string>? RequiredFindingLabelKeys { get; set; }

    /// <summary>
    /// If the container is a table, additional information to make findings meaningful such as the columns that are primary keys.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tableOptions")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptionsTableOptions? TableOptions { get; set; }
}

/// <summary>
/// Specification of the field containing the timestamp of scanned items.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigTimespanConfigTimestampField
{
    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Configuration of the timespan of the items to include in scanning
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigTimespanConfig
{
    /// <summary>
    /// When the job is started by a JobTrigger we will automatically figure out a valid startTime to avoid
    /// scanning files that have not been modified since the last time the JobTrigger executed. This will
    /// be based on the time of the execution of the last run of the JobTrigger or the timespan endTime
    /// used in the last run of the JobTrigger.
    /// </summary>
    [JsonPropertyName("enableAutoPopulationOfTimespanConfig")]
    public bool? EnableAutoPopulationOfTimespanConfig { get; set; }

    /// <summary>Exclude files, tables, or rows newer than this value. If not set, no upper time limit is applied.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Exclude files, tables, or rows older than this value. If not set, no lower time limit is applied.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Specification of the field containing the timestamp of scanned items.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timestampField")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigTimespanConfigTimestampField? TimestampField { get; set; }
}

/// <summary>
/// Information on where to inspect
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJobStorageConfig
{
    /// <summary>
    /// Options defining BigQuery table and row identifiers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigQueryOptions")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigBigQueryOptions? BigQueryOptions { get; set; }

    /// <summary>
    /// Options defining a file or a set of files within a Google Cloud Storage bucket.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudStorageOptions")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigCloudStorageOptions? CloudStorageOptions { get; set; }

    /// <summary>
    /// Options defining a data set within Google Cloud Datastore.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("datastoreOptions")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigDatastoreOptions? DatastoreOptions { get; set; }

    /// <summary>
    /// Configuration to control jobs where the content being inspected is outside of Google Cloud Platform.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hybridOptions")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigHybridOptions? HybridOptions { get; set; }

    /// <summary>
    /// Configuration of the timespan of the items to include in scanning
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timespanConfig")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfigTimespanConfig? TimespanConfig { get; set; }
}

/// <summary>
/// Controls what and how to inspect for findings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderInspectJob
{
    /// <summary>
    /// Configuration block for the actions to execute on the completion of a job. Can be specified multiple times, but only one for each type. Each action block supports fields documented below. This argument is processed in attribute-as-blocks mode.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("actions")]
    public IList<V1beta2JobTriggerStatusAtProviderInspectJobActions>? Actions { get; set; }

    /// <summary>
    /// The core content of the template.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inspectConfig")]
    public V1beta2JobTriggerStatusAtProviderInspectJobInspectConfig? InspectConfig { get; set; }

    /// <summary>The name of the template to run when this job is triggered.</summary>
    [JsonPropertyName("inspectTemplateName")]
    public string? InspectTemplateName { get; set; }

    /// <summary>
    /// Information on where to inspect
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storageConfig")]
    public V1beta2JobTriggerStatusAtProviderInspectJobStorageConfig? StorageConfig { get; set; }
}

/// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderTriggersManual
{
}

/// <summary>
/// Schedule for triggered jobs
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderTriggersSchedule
{
    /// <summary>
    /// With this option a job is started a regular periodic basis. For example: every day (86400 seconds).
    /// A scheduled start time will be skipped if the previous execution has not ended when its scheduled time occurs.
    /// This value must be set to a time duration greater than or equal to 1 day and can be no longer than 60 days.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("recurrencePeriodDuration")]
    public string? RecurrencePeriodDuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProviderTriggers
{
    /// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
    [JsonPropertyName("manual")]
    public V1beta2JobTriggerStatusAtProviderTriggersManual? Manual { get; set; }

    /// <summary>
    /// Schedule for triggered jobs
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1beta2JobTriggerStatusAtProviderTriggersSchedule? Schedule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusAtProvider
{
    /// <summary>The creation timestamp of an inspectTemplate. Set by the server.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A description of the job trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the job trigger.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/jobTriggers/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Controls what and how to inspect for findings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("inspectJob")]
    public V1beta2JobTriggerStatusAtProviderInspectJob? InspectJob { get; set; }

    /// <summary>The timestamp of the last time this trigger executed.</summary>
    [JsonPropertyName("lastRunTime")]
    public string? LastRunTime { get; set; }

    /// <summary>The resource name of the job trigger. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The parent of the trigger, either in the format projects/{{project}}
    /// or projects/{{project}}/locations/{{location}}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Whether the trigger is currently active.
    /// Default value is HEALTHY.
    /// Possible values are: PAUSED, HEALTHY, CANCELLED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The trigger id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+.
    /// The maximum length is 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; set; }

    /// <summary>
    /// What event needs to occur for a new job to be started.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggers")]
    public IList<V1beta2JobTriggerStatusAtProviderTriggers>? Triggers { get; set; }

    /// <summary>The last update timestamp of an inspectTemplate. Set by the server.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatusConditions
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

/// <summary>JobTriggerStatus defines the observed state of JobTrigger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobTriggerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2JobTriggerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2JobTriggerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>JobTrigger is the Schema for the JobTriggers API. A job trigger configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2JobTrigger : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2JobTriggerSpec>, IStatus<V1beta2JobTriggerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "JobTrigger";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "jobtriggers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalossprevention.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobTrigger";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobTriggerSpec defines the desired state of JobTrigger</summary>
    [JsonPropertyName("spec")]
    public required V1beta2JobTriggerSpec Spec { get; set; }

    /// <summary>JobTriggerStatus defines the observed state of JobTrigger.</summary>
    [JsonPropertyName("status")]
    public V1beta2JobTriggerStatus? Status { get; set; }
}