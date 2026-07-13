#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
/// <summary>Job is the Schema for the Jobs API. Jobs are actions that BigQuery runs on your behalf to load data, export data, query data, or copy data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2JobList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Job>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Job objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Job> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecDeletionPolicyEnum>))]
public enum V1beta2JobSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Custom encryption configuration (e.g., Cloud KMS keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationEncryptionConfiguration
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelector
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
    public V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopyDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderCopyDestinationTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationTableTableIdSelector
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
    public V1beta2JobSpecForProviderCopyDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The destination table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopyDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecForProviderCopyDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecForProviderCopyDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecForProviderCopyDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecForProviderCopyDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopySourceTablesDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopySourceTablesDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderCopySourceTablesDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelector
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
    public V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesProjectIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesProjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesProjectIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesProjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesProjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopySourceTablesProjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopySourceTablesProjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderCopySourceTablesProjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesProjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesProjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesProjectIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesProjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesProjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopySourceTablesProjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopySourceTablesProjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesProjectIdSelector
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
    public V1beta2JobSpecForProviderCopySourceTablesProjectIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopySourceTablesTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopySourceTablesTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderCopySourceTablesTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderCopySourceTablesTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderCopySourceTablesTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderCopySourceTablesTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderCopySourceTablesTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTablesTableIdSelector
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
    public V1beta2JobSpecForProviderCopySourceTablesTableIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopySourceTables
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecForProviderCopySourceTablesDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecForProviderCopySourceTablesDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdRef")]
    public V1beta2JobSpecForProviderCopySourceTablesProjectIdRef? ProjectIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdSelector")]
    public V1beta2JobSpecForProviderCopySourceTablesProjectIdSelector? ProjectIdSelector { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecForProviderCopySourceTablesTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecForProviderCopySourceTablesTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Copies a table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderCopy
{
    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &apos;notFound&apos; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion
    /// Default value is CREATE_IF_NEEDED.
    /// Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.
    /// </summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>
    /// Custom encryption configuration (e.g., Cloud KMS keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta2JobSpecForProviderCopyDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// The destination table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationTable")]
    public V1beta2JobSpecForProviderCopyDestinationTable? DestinationTable { get; set; }

    /// <summary>
    /// Source tables to copy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceTables")]
    public IList<V1beta2JobSpecForProviderCopySourceTables>? SourceTables { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &apos;duplicate&apos; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion.
    /// Default value is WRITE_EMPTY.
    /// Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.
    /// </summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

/// <summary>
/// A reference to the model being exported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceModel
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the model.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderExtractSourceTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderExtractSourceTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelector
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
    public V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderExtractSourceTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderExtractSourceTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderExtractSourceTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderExtractSourceTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderExtractSourceTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderExtractSourceTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderExtractSourceTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderExtractSourceTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceTableTableIdSelector
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
    public V1beta2JobSpecForProviderExtractSourceTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A reference to the table being exported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtractSourceTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecForProviderExtractSourceTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecForProviderExtractSourceTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecForProviderExtractSourceTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecForProviderExtractSourceTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Configures an extract job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderExtract
{
    /// <summary>
    /// The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE.
    /// The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.
    /// </summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>
    /// The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models.
    /// The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV.
    /// The default value for models is SAVED_MODEL.
    /// </summary>
    [JsonPropertyName("destinationFormat")]
    public string? DestinationFormat { get; set; }

    /// <summary>A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.</summary>
    [JsonPropertyName("destinationUris")]
    public IList<string>? DestinationUris { get; set; }

    /// <summary>
    /// When extracting data in CSV format, this defines the delimiter to use between fields in the exported data.
    /// Default is &apos;,&apos;
    /// </summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Whether to print out a header row in the results. Default is true.</summary>
    [JsonPropertyName("printHeader")]
    public bool? PrintHeader { get; set; }

    /// <summary>
    /// A reference to the model being exported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceModel")]
    public V1beta2JobSpecForProviderExtractSourceModel? SourceModel { get; set; }

    /// <summary>
    /// A reference to the table being exported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceTable")]
    public V1beta2JobSpecForProviderExtractSourceTable? SourceTable { get; set; }

    /// <summary>Whether to use logical types when extracting to AVRO format.</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

/// <summary>
/// Custom encryption configuration (e.g., Cloud KMS keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationEncryptionConfiguration
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelector
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
    public V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderLoadDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderLoadDestinationTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationTableTableIdSelector
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
    public V1beta2JobSpecForProviderLoadDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The destination table to load the data into.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecForProviderLoadDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecForProviderLoadDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecForProviderLoadDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecForProviderLoadDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Parquet Options for load and make external tables.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadParquetOptions
{
    /// <summary>If sourceFormat is set to PARQUET, indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>If sourceFormat is set to PARQUET, indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

/// <summary>
/// Time-based partitioning specification for the destination table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoadTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.</summary>
    [JsonPropertyName("expirationMs")]
    public string? ExpirationMs { get; set; }

    /// <summary>
    /// If not set, the table is partitioned by pseudo column &apos;_PARTITIONTIME&apos;; if set, the table is partitioned by this field.
    /// The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED.
    /// A wrapper is used here because an empty string is an invalid value.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>
    /// The only type supported is DAY, which will generate one partition per day. Providing an empty string used to cause an error,
    /// but in OnePlatform the field will be treated as unset.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Configures a load job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderLoad
{
    /// <summary>
    /// Accept rows that are missing trailing optional columns. The missing values are treated as nulls.
    /// If false, records with missing trailing columns are treated as bad records, and if there are too many bad records,
    /// an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.
    /// </summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>
    /// Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file.
    /// The default value is false.
    /// </summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>Indicates if we should automatically infer the options and schema for CSV and JSON sources.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &apos;notFound&apos; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion
    /// Default value is CREATE_IF_NEEDED.
    /// Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.
    /// </summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>
    /// Custom encryption configuration (e.g., Cloud KMS keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta2JobSpecForProviderLoadDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// The destination table to load the data into.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationTable")]
    public V1beta2JobSpecForProviderLoadDestinationTable? DestinationTable { get; set; }

    /// <summary>
    /// The character encoding of the data. The supported values are UTF-8 or ISO-8859-1.
    /// The default value is UTF-8. BigQuery decodes the data after the raw, binary data
    /// has been split using the values of the quote and fieldDelimiter properties.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character.
    /// To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts
    /// the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the
    /// data in its raw, binary state. BigQuery also supports the escape sequence &quot;\t&quot; to specify a tab separator.
    /// The default value is a comma (&apos;,&apos;).
    /// </summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema.
    /// If true, the extra values are ignored. If false, records with extra columns are treated as bad records,
    /// and if there are too many bad records, an invalid error is returned in the job result.
    /// The default value is false. The sourceFormat property determines what BigQuery treats as an extra value:
    /// CSV: Trailing columns
    /// JSON: Named values that don&apos;t match any column names
    /// </summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>
    /// If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON.
    /// For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited
    /// GeoJSON: set to GEOJSON.
    /// </summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value,
    /// an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.
    /// </summary>
    [JsonPropertyName("maxBadRecords")]
    public double? MaxBadRecords { get; set; }

    /// <summary>
    /// Specifies a string that represents a null value in a CSV file. For example, if you specify &quot;\N&quot;, BigQuery interprets &quot;\N&quot; as a null value
    /// when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an
    /// empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as
    /// an empty value.
    /// </summary>
    [JsonPropertyName("nullMarker")]
    public string? NullMarker { get; set; }

    /// <summary>
    /// Parquet Options for load and make external tables.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("parquetOptions")]
    public V1beta2JobSpecForProviderLoadParquetOptions? ParquetOptions { get; set; }

    /// <summary>
    /// If sourceFormat is set to &quot;DATASTORE_BACKUP&quot;, indicates which entity properties to load into BigQuery from a Cloud Datastore backup.
    /// Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties.
    /// If any named property isn&apos;t found in the Cloud Datastore backup, an invalid error is returned in the job result.
    /// </summary>
    [JsonPropertyName("projectionFields")]
    public IList<string>? ProjectionFields { get; set; }

    /// <summary>
    /// The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding,
    /// and then uses the first byte of the encoded string to split the data in its raw, binary state.
    /// The default value is a double-quote (&apos; &quot; &apos;). If your data does not contain quoted sections, set the property value to an empty string.
    /// If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.
    /// </summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or
    /// supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators.
    /// For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>
    /// The number of rows at the top of a CSV file that BigQuery will skip when loading the data.
    /// The default value is 0. This property is useful if you have header rows in the file that should be skipped.
    /// When autodetect is on, the behavior is the following:
    /// skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected,
    /// the row is read as data. Otherwise data is read starting from the second row.
    /// skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row.
    /// skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected,
    /// row N is just skipped. Otherwise row N is used to extract column names for the detected schema.
    /// </summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }

    /// <summary>
    /// The format of the data files. For CSV files, specify &quot;CSV&quot;. For datastore backups, specify &quot;DATASTORE_BACKUP&quot;.
    /// For newline-delimited JSON, specify &quot;NEWLINE_DELIMITED_JSON&quot;. For Avro, specify &quot;AVRO&quot;. For parquet, specify &quot;PARQUET&quot;.
    /// For orc, specify &quot;ORC&quot;. [Beta] For Bigtable, specify &quot;BIGTABLE&quot;.
    /// The default value is CSV.
    /// </summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>
    /// The fully-qualified URIs that point to your data in Google Cloud.
    /// For Google Cloud Storage URIs: Each URI can contain one &apos;*&apos; wildcard character
    /// and it must come after the &apos;bucket&apos; name. Size limits related to load jobs apply
    /// to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be
    /// specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table.
    /// For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the &apos;*&apos; wildcard character is not allowed.
    /// </summary>
    [JsonPropertyName("sourceUris")]
    public IList<string>? SourceUris { get; set; }

    /// <summary>
    /// Time-based partitioning specification for the destination table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartitioning")]
    public V1beta2JobSpecForProviderLoadTimePartitioning? TimePartitioning { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &apos;duplicate&apos; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion.
    /// Default value is WRITE_EMPTY.
    /// Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.
    /// </summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelector
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
    public V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDefaultDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecForProviderQueryDefaultDatasetDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// Custom encryption configuration (e.g., Cloud KMS keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationEncryptionConfiguration
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelector
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
    public V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderQueryDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderQueryDestinationTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationTableTableIdSelector
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
    public V1beta2JobSpecForProviderQueryDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Describes the table where the query results should be stored.
/// This property must be set for large results that exceed the maximum response size.
/// For queries that produce anonymous (cached) results, this field will be populated by BigQuery.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecForProviderQueryDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecForProviderQueryDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecForProviderQueryDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecForProviderQueryDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Options controlling the execution of scripts.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryScriptOptions
{
    /// <summary>
    /// Determines which statement in the script represents the &quot;key result&quot;,
    /// used to populate the schema and query results of the script job.
    /// Possible values are: LAST, FIRST_SELECT.
    /// </summary>
    [JsonPropertyName("keyResultStatement")]
    public string? KeyResultStatement { get; set; }

    /// <summary>Limit on the number of bytes billed per statement. Exceeding this budget results in an error.</summary>
    [JsonPropertyName("statementByteBudget")]
    public string? StatementByteBudget { get; set; }

    /// <summary>Timeout period for each statement in a script.</summary>
    [JsonPropertyName("statementTimeoutMs")]
    public string? StatementTimeoutMs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQueryUserDefinedFunctionResources
{
    /// <summary>
    /// An inline resource that contains code for a user-defined function (UDF).
    /// Providing a inline code resource is equivalent to providing a URI for a file containing the same code.
    /// </summary>
    [JsonPropertyName("inlineCode")]
    public string? InlineCode { get; set; }

    /// <summary>A code resource to load from a Google Cloud Storage URI (gs://bucket/path).</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>
/// Configures a query job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderQuery
{
    /// <summary>
    /// If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance.
    /// Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed.
    /// However, you must still set destinationTable when result size exceeds the allowed maximum response size.
    /// </summary>
    [JsonPropertyName("allowLargeResults")]
    public bool? AllowLargeResults { get; set; }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &apos;notFound&apos; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion
    /// Default value is CREATE_IF_NEEDED.
    /// Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.
    /// </summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>
    /// Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultDataset")]
    public V1beta2JobSpecForProviderQueryDefaultDataset? DefaultDataset { get; set; }

    /// <summary>
    /// Custom encryption configuration (e.g., Cloud KMS keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta2JobSpecForProviderQueryDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// Describes the table where the query results should be stored.
    /// This property must be set for large results that exceed the maximum response size.
    /// For queries that produce anonymous (cached) results, this field will be populated by BigQuery.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationTable")]
    public V1beta2JobSpecForProviderQueryDestinationTable? DestinationTable { get; set; }

    /// <summary>
    /// If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results.
    /// allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.
    /// </summary>
    [JsonPropertyName("flattenResults")]
    public bool? FlattenResults { get; set; }

    /// <summary>
    /// Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    [JsonPropertyName("maximumBillingTier")]
    public double? MaximumBillingTier { get; set; }

    /// <summary>
    /// Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    [JsonPropertyName("maximumBytesBilled")]
    public string? MaximumBytesBilled { get; set; }

    /// <summary>Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.</summary>
    [JsonPropertyName("parameterMode")]
    public string? ParameterMode { get; set; }

    /// <summary>
    /// Specifies a priority for the query.
    /// Default value is INTERACTIVE.
    /// Possible values are: INTERACTIVE, BATCH.
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL.
    /// NOTE: queries containing DML language
    /// (DELETE, UPDATE, MERGE, INSERT) must specify create_disposition = &quot; &quot; and write_disposition = &quot; &quot;.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the query job.
    /// Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table,
    /// specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema.
    /// One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>
    /// Options controlling the execution of scripts.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scriptOptions")]
    public V1beta2JobSpecForProviderQueryScriptOptions? ScriptOptions { get; set; }

    /// <summary>
    /// Specifies whether to use BigQuery&apos;s legacy SQL dialect for this query. The default value is true.
    /// If set to false, the query will use BigQuery&apos;s standard SQL.
    /// </summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }

    /// <summary>
    /// Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever
    /// tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified.
    /// The default value is true.
    /// </summary>
    [JsonPropertyName("useQueryCache")]
    public bool? UseQueryCache { get; set; }

    /// <summary>
    /// Describes user-defined function resources used in the query.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("userDefinedFunctionResources")]
    public IList<V1beta2JobSpecForProviderQueryUserDefinedFunctionResources>? UserDefinedFunctionResources { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &apos;duplicate&apos; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion.
    /// Default value is WRITE_EMPTY.
    /// Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.
    /// </summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProvider
{
    /// <summary>
    /// Copies a table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("copy")]
    public V1beta2JobSpecForProviderCopy? Copy { get; set; }

    /// <summary>
    /// Configures an extract job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extract")]
    public V1beta2JobSpecForProviderExtract? Extract { get; set; }

    /// <summary>The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.</summary>
    [JsonPropertyName("jobTimeoutMs")]
    public string? JobTimeoutMs { get; set; }

    /// <summary>The labels associated with this job. You can use these to organize and group your jobs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Configures a load job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("load")]
    public V1beta2JobSpecForProviderLoad? Load { get; set; }

    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Configures a query job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("query")]
    public V1beta2JobSpecForProviderQuery? Query { get; set; }
}

/// <summary>
/// Custom encryption configuration (e.g., Cloud KMS keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationEncryptionConfiguration
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelector
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
    public V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopyDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderCopyDestinationTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelector
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
    public V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The destination table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopyDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecInitProviderCopyDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecInitProviderCopyDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecInitProviderCopyDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelector
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
    public V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesProjectIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesProjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesProjectIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesProjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesProjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopySourceTablesProjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopySourceTablesProjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderCopySourceTablesProjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelector
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
    public V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopySourceTablesTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopySourceTablesTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderCopySourceTablesTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderCopySourceTablesTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderCopySourceTablesTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderCopySourceTablesTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderCopySourceTablesTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTablesTableIdSelector
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
    public V1beta2JobSpecInitProviderCopySourceTablesTableIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopySourceTables
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecInitProviderCopySourceTablesDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecInitProviderCopySourceTablesDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdRef")]
    public V1beta2JobSpecInitProviderCopySourceTablesProjectIdRef? ProjectIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate projectId.</summary>
    [JsonPropertyName("projectIdSelector")]
    public V1beta2JobSpecInitProviderCopySourceTablesProjectIdSelector? ProjectIdSelector { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecInitProviderCopySourceTablesTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecInitProviderCopySourceTablesTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Copies a table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderCopy
{
    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &apos;notFound&apos; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion
    /// Default value is CREATE_IF_NEEDED.
    /// Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.
    /// </summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>
    /// Custom encryption configuration (e.g., Cloud KMS keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta2JobSpecInitProviderCopyDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// The destination table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationTable")]
    public V1beta2JobSpecInitProviderCopyDestinationTable? DestinationTable { get; set; }

    /// <summary>
    /// Source tables to copy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceTables")]
    public IList<V1beta2JobSpecInitProviderCopySourceTables>? SourceTables { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &apos;duplicate&apos; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion.
    /// Default value is WRITE_EMPTY.
    /// Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.
    /// </summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

/// <summary>
/// A reference to the model being exported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceModel
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the model.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelector
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
    public V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderExtractSourceTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderExtractSourceTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderExtractSourceTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceTableTableIdSelector
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
    public V1beta2JobSpecInitProviderExtractSourceTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A reference to the table being exported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtractSourceTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecInitProviderExtractSourceTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecInitProviderExtractSourceTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecInitProviderExtractSourceTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecInitProviderExtractSourceTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Configures an extract job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderExtract
{
    /// <summary>
    /// The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE.
    /// The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.
    /// </summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>
    /// The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models.
    /// The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV.
    /// The default value for models is SAVED_MODEL.
    /// </summary>
    [JsonPropertyName("destinationFormat")]
    public string? DestinationFormat { get; set; }

    /// <summary>A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.</summary>
    [JsonPropertyName("destinationUris")]
    public IList<string>? DestinationUris { get; set; }

    /// <summary>
    /// When extracting data in CSV format, this defines the delimiter to use between fields in the exported data.
    /// Default is &apos;,&apos;
    /// </summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Whether to print out a header row in the results. Default is true.</summary>
    [JsonPropertyName("printHeader")]
    public bool? PrintHeader { get; set; }

    /// <summary>
    /// A reference to the model being exported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceModel")]
    public V1beta2JobSpecInitProviderExtractSourceModel? SourceModel { get; set; }

    /// <summary>
    /// A reference to the table being exported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceTable")]
    public V1beta2JobSpecInitProviderExtractSourceTable? SourceTable { get; set; }

    /// <summary>Whether to use logical types when extracting to AVRO format.</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

/// <summary>
/// Custom encryption configuration (e.g., Cloud KMS keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationEncryptionConfiguration
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelector
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
    public V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderLoadDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderLoadDestinationTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelector
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
    public V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The destination table to load the data into.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecInitProviderLoadDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecInitProviderLoadDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecInitProviderLoadDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Parquet Options for load and make external tables.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadParquetOptions
{
    /// <summary>If sourceFormat is set to PARQUET, indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>If sourceFormat is set to PARQUET, indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

/// <summary>
/// Time-based partitioning specification for the destination table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoadTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.</summary>
    [JsonPropertyName("expirationMs")]
    public string? ExpirationMs { get; set; }

    /// <summary>
    /// If not set, the table is partitioned by pseudo column &apos;_PARTITIONTIME&apos;; if set, the table is partitioned by this field.
    /// The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED.
    /// A wrapper is used here because an empty string is an invalid value.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>
    /// The only type supported is DAY, which will generate one partition per day. Providing an empty string used to cause an error,
    /// but in OnePlatform the field will be treated as unset.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Configures a load job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderLoad
{
    /// <summary>
    /// Accept rows that are missing trailing optional columns. The missing values are treated as nulls.
    /// If false, records with missing trailing columns are treated as bad records, and if there are too many bad records,
    /// an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.
    /// </summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>
    /// Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file.
    /// The default value is false.
    /// </summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>Indicates if we should automatically infer the options and schema for CSV and JSON sources.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &apos;notFound&apos; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion
    /// Default value is CREATE_IF_NEEDED.
    /// Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.
    /// </summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>
    /// Custom encryption configuration (e.g., Cloud KMS keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta2JobSpecInitProviderLoadDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// The destination table to load the data into.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationTable")]
    public V1beta2JobSpecInitProviderLoadDestinationTable? DestinationTable { get; set; }

    /// <summary>
    /// The character encoding of the data. The supported values are UTF-8 or ISO-8859-1.
    /// The default value is UTF-8. BigQuery decodes the data after the raw, binary data
    /// has been split using the values of the quote and fieldDelimiter properties.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character.
    /// To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts
    /// the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the
    /// data in its raw, binary state. BigQuery also supports the escape sequence &quot;\t&quot; to specify a tab separator.
    /// The default value is a comma (&apos;,&apos;).
    /// </summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema.
    /// If true, the extra values are ignored. If false, records with extra columns are treated as bad records,
    /// and if there are too many bad records, an invalid error is returned in the job result.
    /// The default value is false. The sourceFormat property determines what BigQuery treats as an extra value:
    /// CSV: Trailing columns
    /// JSON: Named values that don&apos;t match any column names
    /// </summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>
    /// If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON.
    /// For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited
    /// GeoJSON: set to GEOJSON.
    /// </summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value,
    /// an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.
    /// </summary>
    [JsonPropertyName("maxBadRecords")]
    public double? MaxBadRecords { get; set; }

    /// <summary>
    /// Specifies a string that represents a null value in a CSV file. For example, if you specify &quot;\N&quot;, BigQuery interprets &quot;\N&quot; as a null value
    /// when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an
    /// empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as
    /// an empty value.
    /// </summary>
    [JsonPropertyName("nullMarker")]
    public string? NullMarker { get; set; }

    /// <summary>
    /// Parquet Options for load and make external tables.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("parquetOptions")]
    public V1beta2JobSpecInitProviderLoadParquetOptions? ParquetOptions { get; set; }

    /// <summary>
    /// If sourceFormat is set to &quot;DATASTORE_BACKUP&quot;, indicates which entity properties to load into BigQuery from a Cloud Datastore backup.
    /// Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties.
    /// If any named property isn&apos;t found in the Cloud Datastore backup, an invalid error is returned in the job result.
    /// </summary>
    [JsonPropertyName("projectionFields")]
    public IList<string>? ProjectionFields { get; set; }

    /// <summary>
    /// The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding,
    /// and then uses the first byte of the encoded string to split the data in its raw, binary state.
    /// The default value is a double-quote (&apos; &quot; &apos;). If your data does not contain quoted sections, set the property value to an empty string.
    /// If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.
    /// </summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or
    /// supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators.
    /// For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>
    /// The number of rows at the top of a CSV file that BigQuery will skip when loading the data.
    /// The default value is 0. This property is useful if you have header rows in the file that should be skipped.
    /// When autodetect is on, the behavior is the following:
    /// skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected,
    /// the row is read as data. Otherwise data is read starting from the second row.
    /// skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row.
    /// skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected,
    /// row N is just skipped. Otherwise row N is used to extract column names for the detected schema.
    /// </summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }

    /// <summary>
    /// The format of the data files. For CSV files, specify &quot;CSV&quot;. For datastore backups, specify &quot;DATASTORE_BACKUP&quot;.
    /// For newline-delimited JSON, specify &quot;NEWLINE_DELIMITED_JSON&quot;. For Avro, specify &quot;AVRO&quot;. For parquet, specify &quot;PARQUET&quot;.
    /// For orc, specify &quot;ORC&quot;. [Beta] For Bigtable, specify &quot;BIGTABLE&quot;.
    /// The default value is CSV.
    /// </summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>
    /// The fully-qualified URIs that point to your data in Google Cloud.
    /// For Google Cloud Storage URIs: Each URI can contain one &apos;*&apos; wildcard character
    /// and it must come after the &apos;bucket&apos; name. Size limits related to load jobs apply
    /// to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be
    /// specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table.
    /// For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the &apos;*&apos; wildcard character is not allowed.
    /// </summary>
    [JsonPropertyName("sourceUris")]
    public IList<string>? SourceUris { get; set; }

    /// <summary>
    /// Time-based partitioning specification for the destination table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartitioning")]
    public V1beta2JobSpecInitProviderLoadTimePartitioning? TimePartitioning { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &apos;duplicate&apos; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion.
    /// Default value is WRITE_EMPTY.
    /// Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.
    /// </summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelector
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
    public V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDefaultDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecInitProviderQueryDefaultDatasetDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// Custom encryption configuration (e.g., Cloud KMS keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationEncryptionConfiguration
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelector
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
    public V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationTableTableIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderQueryDestinationTableTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationTableTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderQueryDestinationTableTableIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate tableId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelector
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
    public V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Describes the table where the query results should be stored.
/// This property must be set for large results that exceed the maximum response size.
/// For queries that produce anonymous (cached) results, this field will be populated by BigQuery.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta2JobSpecInitProviderQueryDestinationTableDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }

    /// <summary>Reference to a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdRef")]
    public V1beta2JobSpecInitProviderQueryDestinationTableTableIdRef? TableIdRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate tableId.</summary>
    [JsonPropertyName("tableIdSelector")]
    public V1beta2JobSpecInitProviderQueryDestinationTableTableIdSelector? TableIdSelector { get; set; }
}

/// <summary>
/// Options controlling the execution of scripts.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryScriptOptions
{
    /// <summary>
    /// Determines which statement in the script represents the &quot;key result&quot;,
    /// used to populate the schema and query results of the script job.
    /// Possible values are: LAST, FIRST_SELECT.
    /// </summary>
    [JsonPropertyName("keyResultStatement")]
    public string? KeyResultStatement { get; set; }

    /// <summary>Limit on the number of bytes billed per statement. Exceeding this budget results in an error.</summary>
    [JsonPropertyName("statementByteBudget")]
    public string? StatementByteBudget { get; set; }

    /// <summary>Timeout period for each statement in a script.</summary>
    [JsonPropertyName("statementTimeoutMs")]
    public string? StatementTimeoutMs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQueryUserDefinedFunctionResources
{
    /// <summary>
    /// An inline resource that contains code for a user-defined function (UDF).
    /// Providing a inline code resource is equivalent to providing a URI for a file containing the same code.
    /// </summary>
    [JsonPropertyName("inlineCode")]
    public string? InlineCode { get; set; }

    /// <summary>A code resource to load from a Google Cloud Storage URI (gs://bucket/path).</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>
/// Configures a query job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderQuery
{
    /// <summary>
    /// If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance.
    /// Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed.
    /// However, you must still set destinationTable when result size exceeds the allowed maximum response size.
    /// </summary>
    [JsonPropertyName("allowLargeResults")]
    public bool? AllowLargeResults { get; set; }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &apos;notFound&apos; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion
    /// Default value is CREATE_IF_NEEDED.
    /// Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.
    /// </summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>
    /// Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultDataset")]
    public V1beta2JobSpecInitProviderQueryDefaultDataset? DefaultDataset { get; set; }

    /// <summary>
    /// Custom encryption configuration (e.g., Cloud KMS keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta2JobSpecInitProviderQueryDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// Describes the table where the query results should be stored.
    /// This property must be set for large results that exceed the maximum response size.
    /// For queries that produce anonymous (cached) results, this field will be populated by BigQuery.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationTable")]
    public V1beta2JobSpecInitProviderQueryDestinationTable? DestinationTable { get; set; }

    /// <summary>
    /// If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results.
    /// allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.
    /// </summary>
    [JsonPropertyName("flattenResults")]
    public bool? FlattenResults { get; set; }

    /// <summary>
    /// Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    [JsonPropertyName("maximumBillingTier")]
    public double? MaximumBillingTier { get; set; }

    /// <summary>
    /// Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    [JsonPropertyName("maximumBytesBilled")]
    public string? MaximumBytesBilled { get; set; }

    /// <summary>Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.</summary>
    [JsonPropertyName("parameterMode")]
    public string? ParameterMode { get; set; }

    /// <summary>
    /// Specifies a priority for the query.
    /// Default value is INTERACTIVE.
    /// Possible values are: INTERACTIVE, BATCH.
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL.
    /// NOTE: queries containing DML language
    /// (DELETE, UPDATE, MERGE, INSERT) must specify create_disposition = &quot; &quot; and write_disposition = &quot; &quot;.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the query job.
    /// Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table,
    /// specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema.
    /// One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>
    /// Options controlling the execution of scripts.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scriptOptions")]
    public V1beta2JobSpecInitProviderQueryScriptOptions? ScriptOptions { get; set; }

    /// <summary>
    /// Specifies whether to use BigQuery&apos;s legacy SQL dialect for this query. The default value is true.
    /// If set to false, the query will use BigQuery&apos;s standard SQL.
    /// </summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }

    /// <summary>
    /// Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever
    /// tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified.
    /// The default value is true.
    /// </summary>
    [JsonPropertyName("useQueryCache")]
    public bool? UseQueryCache { get; set; }

    /// <summary>
    /// Describes user-defined function resources used in the query.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("userDefinedFunctionResources")]
    public IList<V1beta2JobSpecInitProviderQueryUserDefinedFunctionResources>? UserDefinedFunctionResources { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &apos;duplicate&apos; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion.
    /// Default value is WRITE_EMPTY.
    /// Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.
    /// </summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
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
public partial class V1beta2JobSpecInitProvider
{
    /// <summary>
    /// Copies a table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("copy")]
    public V1beta2JobSpecInitProviderCopy? Copy { get; set; }

    /// <summary>
    /// Configures an extract job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extract")]
    public V1beta2JobSpecInitProviderExtract? Extract { get; set; }

    /// <summary>The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.</summary>
    [JsonPropertyName("jobTimeoutMs")]
    public string? JobTimeoutMs { get; set; }

    /// <summary>The labels associated with this job. You can use these to organize and group your jobs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Configures a load job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("load")]
    public V1beta2JobSpecInitProviderLoad? Load { get; set; }

    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Configures a query job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("query")]
    public V1beta2JobSpecInitProviderQuery? Query { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecManagementPoliciesEnum>))]
public enum V1beta2JobSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2JobSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>JobSpec defines the desired state of Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpec
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
    public V1beta2JobSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2JobSpecForProvider ForProvider { get; set; }

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
    public V1beta2JobSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2JobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Custom encryption configuration (e.g., Cloud KMS keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderCopyDestinationEncryptionConfiguration
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the Cloud KMS encryption key version used to protect destination BigQuery table.
    /// </summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

/// <summary>
/// The destination table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderCopyDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderCopySourceTables
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Copies a table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderCopy
{
    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &apos;notFound&apos; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion
    /// Default value is CREATE_IF_NEEDED.
    /// Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.
    /// </summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>
    /// Custom encryption configuration (e.g., Cloud KMS keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta2JobStatusAtProviderCopyDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// The destination table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationTable")]
    public V1beta2JobStatusAtProviderCopyDestinationTable? DestinationTable { get; set; }

    /// <summary>
    /// Source tables to copy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceTables")]
    public IList<V1beta2JobStatusAtProviderCopySourceTables>? SourceTables { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &apos;duplicate&apos; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion.
    /// Default value is WRITE_EMPTY.
    /// Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.
    /// </summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

/// <summary>
/// A reference to the model being exported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderExtractSourceModel
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the model.</summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// A reference to the table being exported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderExtractSourceTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Configures an extract job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderExtract
{
    /// <summary>
    /// The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE.
    /// The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.
    /// </summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>
    /// The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models.
    /// The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV.
    /// The default value for models is SAVED_MODEL.
    /// </summary>
    [JsonPropertyName("destinationFormat")]
    public string? DestinationFormat { get; set; }

    /// <summary>A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.</summary>
    [JsonPropertyName("destinationUris")]
    public IList<string>? DestinationUris { get; set; }

    /// <summary>
    /// When extracting data in CSV format, this defines the delimiter to use between fields in the exported data.
    /// Default is &apos;,&apos;
    /// </summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Whether to print out a header row in the results. Default is true.</summary>
    [JsonPropertyName("printHeader")]
    public bool? PrintHeader { get; set; }

    /// <summary>
    /// A reference to the model being exported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceModel")]
    public V1beta2JobStatusAtProviderExtractSourceModel? SourceModel { get; set; }

    /// <summary>
    /// A reference to the table being exported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceTable")]
    public V1beta2JobStatusAtProviderExtractSourceTable? SourceTable { get; set; }

    /// <summary>Whether to use logical types when extracting to AVRO format.</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

/// <summary>
/// Custom encryption configuration (e.g., Cloud KMS keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderLoadDestinationEncryptionConfiguration
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the Cloud KMS encryption key version used to protect destination BigQuery table.
    /// </summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

/// <summary>
/// The destination table to load the data into.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderLoadDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Parquet Options for load and make external tables.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderLoadParquetOptions
{
    /// <summary>If sourceFormat is set to PARQUET, indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>If sourceFormat is set to PARQUET, indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

/// <summary>
/// Time-based partitioning specification for the destination table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderLoadTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.</summary>
    [JsonPropertyName("expirationMs")]
    public string? ExpirationMs { get; set; }

    /// <summary>
    /// If not set, the table is partitioned by pseudo column &apos;_PARTITIONTIME&apos;; if set, the table is partitioned by this field.
    /// The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED.
    /// A wrapper is used here because an empty string is an invalid value.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>
    /// The only type supported is DAY, which will generate one partition per day. Providing an empty string used to cause an error,
    /// but in OnePlatform the field will be treated as unset.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Configures a load job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderLoad
{
    /// <summary>
    /// Accept rows that are missing trailing optional columns. The missing values are treated as nulls.
    /// If false, records with missing trailing columns are treated as bad records, and if there are too many bad records,
    /// an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.
    /// </summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>
    /// Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file.
    /// The default value is false.
    /// </summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>Indicates if we should automatically infer the options and schema for CSV and JSON sources.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &apos;notFound&apos; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion
    /// Default value is CREATE_IF_NEEDED.
    /// Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.
    /// </summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>
    /// Custom encryption configuration (e.g., Cloud KMS keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta2JobStatusAtProviderLoadDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// The destination table to load the data into.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationTable")]
    public V1beta2JobStatusAtProviderLoadDestinationTable? DestinationTable { get; set; }

    /// <summary>
    /// The character encoding of the data. The supported values are UTF-8 or ISO-8859-1.
    /// The default value is UTF-8. BigQuery decodes the data after the raw, binary data
    /// has been split using the values of the quote and fieldDelimiter properties.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character.
    /// To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts
    /// the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the
    /// data in its raw, binary state. BigQuery also supports the escape sequence &quot;\t&quot; to specify a tab separator.
    /// The default value is a comma (&apos;,&apos;).
    /// </summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema.
    /// If true, the extra values are ignored. If false, records with extra columns are treated as bad records,
    /// and if there are too many bad records, an invalid error is returned in the job result.
    /// The default value is false. The sourceFormat property determines what BigQuery treats as an extra value:
    /// CSV: Trailing columns
    /// JSON: Named values that don&apos;t match any column names
    /// </summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>
    /// If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON.
    /// For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited
    /// GeoJSON: set to GEOJSON.
    /// </summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value,
    /// an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.
    /// </summary>
    [JsonPropertyName("maxBadRecords")]
    public double? MaxBadRecords { get; set; }

    /// <summary>
    /// Specifies a string that represents a null value in a CSV file. For example, if you specify &quot;\N&quot;, BigQuery interprets &quot;\N&quot; as a null value
    /// when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an
    /// empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as
    /// an empty value.
    /// </summary>
    [JsonPropertyName("nullMarker")]
    public string? NullMarker { get; set; }

    /// <summary>
    /// Parquet Options for load and make external tables.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("parquetOptions")]
    public V1beta2JobStatusAtProviderLoadParquetOptions? ParquetOptions { get; set; }

    /// <summary>
    /// If sourceFormat is set to &quot;DATASTORE_BACKUP&quot;, indicates which entity properties to load into BigQuery from a Cloud Datastore backup.
    /// Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties.
    /// If any named property isn&apos;t found in the Cloud Datastore backup, an invalid error is returned in the job result.
    /// </summary>
    [JsonPropertyName("projectionFields")]
    public IList<string>? ProjectionFields { get; set; }

    /// <summary>
    /// The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding,
    /// and then uses the first byte of the encoded string to split the data in its raw, binary state.
    /// The default value is a double-quote (&apos; &quot; &apos;). If your data does not contain quoted sections, set the property value to an empty string.
    /// If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.
    /// </summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or
    /// supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators.
    /// For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>
    /// The number of rows at the top of a CSV file that BigQuery will skip when loading the data.
    /// The default value is 0. This property is useful if you have header rows in the file that should be skipped.
    /// When autodetect is on, the behavior is the following:
    /// skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected,
    /// the row is read as data. Otherwise data is read starting from the second row.
    /// skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row.
    /// skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected,
    /// row N is just skipped. Otherwise row N is used to extract column names for the detected schema.
    /// </summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }

    /// <summary>
    /// The format of the data files. For CSV files, specify &quot;CSV&quot;. For datastore backups, specify &quot;DATASTORE_BACKUP&quot;.
    /// For newline-delimited JSON, specify &quot;NEWLINE_DELIMITED_JSON&quot;. For Avro, specify &quot;AVRO&quot;. For parquet, specify &quot;PARQUET&quot;.
    /// For orc, specify &quot;ORC&quot;. [Beta] For Bigtable, specify &quot;BIGTABLE&quot;.
    /// The default value is CSV.
    /// </summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>
    /// The fully-qualified URIs that point to your data in Google Cloud.
    /// For Google Cloud Storage URIs: Each URI can contain one &apos;*&apos; wildcard character
    /// and it must come after the &apos;bucket&apos; name. Size limits related to load jobs apply
    /// to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be
    /// specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table.
    /// For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the &apos;*&apos; wildcard character is not allowed.
    /// </summary>
    [JsonPropertyName("sourceUris")]
    public IList<string>? SourceUris { get; set; }

    /// <summary>
    /// Time-based partitioning specification for the destination table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartitioning")]
    public V1beta2JobStatusAtProviderLoadTimePartitioning? TimePartitioning { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &apos;duplicate&apos; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion.
    /// Default value is WRITE_EMPTY.
    /// Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.
    /// </summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

/// <summary>
/// Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderQueryDefaultDataset
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// Custom encryption configuration (e.g., Cloud KMS keys)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderQueryDestinationEncryptionConfiguration
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the Cloud KMS encryption key version used to protect destination BigQuery table.
    /// </summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

/// <summary>
/// Describes the table where the query results should be stored.
/// This property must be set for large results that exceed the maximum response size.
/// For queries that produce anonymous (cached) results, this field will be populated by BigQuery.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderQueryDestinationTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The table. Can be specified {{table_id}} if project_id and dataset_id are also set,
    /// or of the form projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}} if not.
    /// </summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary>
/// Options controlling the execution of scripts.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderQueryScriptOptions
{
    /// <summary>
    /// Determines which statement in the script represents the &quot;key result&quot;,
    /// used to populate the schema and query results of the script job.
    /// Possible values are: LAST, FIRST_SELECT.
    /// </summary>
    [JsonPropertyName("keyResultStatement")]
    public string? KeyResultStatement { get; set; }

    /// <summary>Limit on the number of bytes billed per statement. Exceeding this budget results in an error.</summary>
    [JsonPropertyName("statementByteBudget")]
    public string? StatementByteBudget { get; set; }

    /// <summary>Timeout period for each statement in a script.</summary>
    [JsonPropertyName("statementTimeoutMs")]
    public string? StatementTimeoutMs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderQueryUserDefinedFunctionResources
{
    /// <summary>
    /// An inline resource that contains code for a user-defined function (UDF).
    /// Providing a inline code resource is equivalent to providing a URI for a file containing the same code.
    /// </summary>
    [JsonPropertyName("inlineCode")]
    public string? InlineCode { get; set; }

    /// <summary>A code resource to load from a Google Cloud Storage URI (gs://bucket/path).</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>
/// Configures a query job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderQuery
{
    /// <summary>
    /// If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance.
    /// Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed.
    /// However, you must still set destinationTable when result size exceeds the allowed maximum response size.
    /// </summary>
    [JsonPropertyName("allowLargeResults")]
    public bool? AllowLargeResults { get; set; }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &apos;notFound&apos; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion
    /// Default value is CREATE_IF_NEEDED.
    /// Possible values are: CREATE_IF_NEEDED, CREATE_NEVER.
    /// </summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>
    /// Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultDataset")]
    public V1beta2JobStatusAtProviderQueryDefaultDataset? DefaultDataset { get; set; }

    /// <summary>
    /// Custom encryption configuration (e.g., Cloud KMS keys)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta2JobStatusAtProviderQueryDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// Describes the table where the query results should be stored.
    /// This property must be set for large results that exceed the maximum response size.
    /// For queries that produce anonymous (cached) results, this field will be populated by BigQuery.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationTable")]
    public V1beta2JobStatusAtProviderQueryDestinationTable? DestinationTable { get; set; }

    /// <summary>
    /// If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results.
    /// allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.
    /// </summary>
    [JsonPropertyName("flattenResults")]
    public bool? FlattenResults { get; set; }

    /// <summary>
    /// Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    [JsonPropertyName("maximumBillingTier")]
    public double? MaximumBillingTier { get; set; }

    /// <summary>
    /// Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    [JsonPropertyName("maximumBytesBilled")]
    public string? MaximumBytesBilled { get; set; }

    /// <summary>Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.</summary>
    [JsonPropertyName("parameterMode")]
    public string? ParameterMode { get; set; }

    /// <summary>
    /// Specifies a priority for the query.
    /// Default value is INTERACTIVE.
    /// Possible values are: INTERACTIVE, BATCH.
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL.
    /// NOTE: queries containing DML language
    /// (DELETE, UPDATE, MERGE, INSERT) must specify create_disposition = &quot; &quot; and write_disposition = &quot; &quot;.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the query job.
    /// Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table,
    /// specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema.
    /// One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>
    /// Options controlling the execution of scripts.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scriptOptions")]
    public V1beta2JobStatusAtProviderQueryScriptOptions? ScriptOptions { get; set; }

    /// <summary>
    /// Specifies whether to use BigQuery&apos;s legacy SQL dialect for this query. The default value is true.
    /// If set to false, the query will use BigQuery&apos;s standard SQL.
    /// </summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }

    /// <summary>
    /// Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever
    /// tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified.
    /// The default value is true.
    /// </summary>
    [JsonPropertyName("useQueryCache")]
    public bool? UseQueryCache { get; set; }

    /// <summary>
    /// Describes user-defined function resources used in the query.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("userDefinedFunctionResources")]
    public IList<V1beta2JobStatusAtProviderQueryUserDefinedFunctionResources>? UserDefinedFunctionResources { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &apos;duplicate&apos; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion.
    /// Default value is WRITE_EMPTY.
    /// Possible values are: WRITE_TRUNCATE, WRITE_APPEND, WRITE_EMPTY.
    /// </summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderStatusErrorResult
{
    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A human-readable description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A short error code that summarizes the error.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderStatusErrors
{
    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A human-readable description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A short error code that summarizes the error.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderStatus
{
    /// <summary>
    /// (Output)
    /// Final error result of the job. If present, indicates that the job has completed and was unsuccessful.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResult")]
    public IList<V1beta2JobStatusAtProviderStatusErrorResult>? ErrorResult { get; set; }

    /// <summary>
    /// (Output)
    /// The first errors encountered during the running of the job. The final message
    /// includes the number of errors that caused the process to stop. Errors here do
    /// not necessarily mean that the job has not completed or was unsuccessful.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errors")]
    public IList<V1beta2JobStatusAtProviderStatusErrors>? Errors { get; set; }

    /// <summary>
    /// (Output)
    /// Running state of the job. Valid states include &apos;PENDING&apos;, &apos;RUNNING&apos;, and &apos;DONE&apos;.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProvider
{
    /// <summary>
    /// Copies a table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("copy")]
    public V1beta2JobStatusAtProviderCopy? Copy { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// Configures an extract job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extract")]
    public V1beta2JobStatusAtProviderExtract? Extract { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/jobs/{{job_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.</summary>
    [JsonPropertyName("jobTimeoutMs")]
    public string? JobTimeoutMs { get; set; }

    /// <summary>
    /// (Output)
    /// The type of the job.
    /// </summary>
    [JsonPropertyName("jobType")]
    public string? JobType { get; set; }

    /// <summary>The labels associated with this job. You can use these to organize and group your jobs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Configures a load job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("load")]
    public V1beta2JobStatusAtProviderLoad? Load { get; set; }

    /// <summary>The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Configures a query job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("query")]
    public V1beta2JobStatusAtProviderQuery? Query { get; set; }

    /// <summary>
    /// The status of this job. Examine this value when polling an asynchronous job to see if the job is complete.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("status")]
    public IList<V1beta2JobStatusAtProviderStatus>? Status { get; set; }

    /// <summary>
    /// (Output)
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Email address of the user who ran the job.</summary>
    [JsonPropertyName("userEmail")]
    public string? UserEmail { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusConditions
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

/// <summary>JobStatus defines the observed state of Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2JobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Job is the Schema for the Jobs API. Jobs are actions that BigQuery runs on your behalf to load data, export data, query data, or copy data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2JobSpec>, IStatus<V1beta2JobStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Job";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Job";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobSpec defines the desired state of Job</summary>
    [JsonPropertyName("spec")]
    public required V1beta2JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1beta2JobStatus? Status { get; set; }
}