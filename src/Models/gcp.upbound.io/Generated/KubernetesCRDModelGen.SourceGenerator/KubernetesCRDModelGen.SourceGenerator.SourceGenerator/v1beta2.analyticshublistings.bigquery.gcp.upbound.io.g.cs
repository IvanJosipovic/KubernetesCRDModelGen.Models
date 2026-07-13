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
/// <summary>AnalyticsHubListing is the Schema for the AnalyticsHubListings API. A Bigquery Analytics Hub data exchange listing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AnalyticsHubListingList : IKubernetesObject<V1ListMeta>, IItems<V1beta2AnalyticsHubListing>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AnalyticsHubListingList";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "analyticshublistings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AnalyticsHubListingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2AnalyticsHubListing objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2AnalyticsHubListing> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecDeletionPolicyEnum>))]
public enum V1beta2AnalyticsHubListingSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelector
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
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelector
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
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResources
{
    /// <summary>Format: For table: projects/{projectId}/datasets/{datasetId}/tables/{tableId} Example:&quot;projects/test_project/datasets/test_dataset/tables/test_table&quot;</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Reference to a Table in bigquery to populate table.</summary>
    [JsonPropertyName("tableRef")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableRef? TableRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate table.</summary>
    [JsonPropertyName("tableSelector")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResourcesTableSelector? TableSelector { get; set; }
}

/// <summary>
/// Shared dataset i.e. BigQuery dataset source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderBigqueryDataset
{
    /// <summary>Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate dataset.</summary>
    [JsonPropertyName("datasetRef")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetRef? DatasetRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate dataset.</summary>
    [JsonPropertyName("datasetSelector")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetDatasetSelector? DatasetSelector { get; set; }

    /// <summary>
    /// Resource in this dataset that is selectively shared. This field is required for data clean room exchanges.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("selectedResources")]
    public IList<V1beta2AnalyticsHubListingSpecForProviderBigqueryDatasetSelectedResources>? SelectedResources { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AnalyticsHubDataExchange in bigquery to populate dataExchangeId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AnalyticsHubDataExchange in bigquery to populate dataExchangeId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelector
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
    public V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Details of the data provider who owns the source data.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderDataProvider
{
    /// <summary>Name of the data provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the data provider.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary>
/// Details of the publisher who owns the listing and who can share the source data.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderPublisher
{
    /// <summary>Name of the listing publisher.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRefPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRefPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelectorPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelector
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
    public V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Pub/Sub topic source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderPubsubTopic
{
    /// <summary>
    /// Region hint on where the data might be published. Data affinity regions are modifiable.
    /// See https://cloud.google.com/about/locations for full listing of possible Cloud regions.
    /// </summary>
    [JsonPropertyName("dataAffinityRegions")]
    public IList<string>? DataAffinityRegions { get; set; }

    /// <summary>Resource name of the Pub/Sub topic source for this listing. e.g. projects/myproject/topics/topicId</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta2AnalyticsHubListingSpecForProviderPubsubTopicTopicSelector? TopicSelector { get; set; }
}

/// <summary>
/// If set, restricted export configuration will be propagated and enforced on the linked dataset.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProviderRestrictedExportConfig
{
    /// <summary>If true, enable restricted export.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>If true, restrict export of query result derived from restricted linked dataset table.</summary>
    [JsonPropertyName("restrictQueryResult")]
    public bool? RestrictQueryResult { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecForProvider
{
    /// <summary>If true, the listing is only available to get the resource metadata. Listing is non subscribable.</summary>
    [JsonPropertyName("allowOnlyMetadataSharing")]
    public bool? AllowOnlyMetadataSharing { get; set; }

    /// <summary>
    /// Shared dataset i.e. BigQuery dataset source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryDataset")]
    public V1beta2AnalyticsHubListingSpecForProviderBigqueryDataset? BigqueryDataset { get; set; }

    /// <summary>Categories of the listing. Up to two categories are allowed.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.</summary>
    [JsonPropertyName("dataExchangeId")]
    public string? DataExchangeId { get; set; }

    /// <summary>Reference to a AnalyticsHubDataExchange in bigquery to populate dataExchangeId.</summary>
    [JsonPropertyName("dataExchangeIdRef")]
    public V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdRef? DataExchangeIdRef { get; set; }

    /// <summary>Selector for a AnalyticsHubDataExchange in bigquery to populate dataExchangeId.</summary>
    [JsonPropertyName("dataExchangeIdSelector")]
    public V1beta2AnalyticsHubListingSpecForProviderDataExchangeIdSelector? DataExchangeIdSelector { get; set; }

    /// <summary>
    /// Details of the data provider who owns the source data.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataProvider")]
    public V1beta2AnalyticsHubListingSpecForProviderDataProvider? DataProvider { get; set; }

    /// <summary>If the listing is commercial then this field must be set to true, otherwise a failure is thrown. This acts as a safety guard to avoid deleting commercial listings accidentally.</summary>
    [JsonPropertyName("deleteCommercial")]
    public bool? DeleteCommercial { get; set; }

    /// <summary>Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies the type of discovery on the discovery page. Cannot be set for a restricted listing. Note that this does not control the visibility of the exchange/listing which is defined by IAM permission.
    /// Possible values are: DISCOVERY_TYPE_PRIVATE, DISCOVERY_TYPE_PUBLIC.
    /// </summary>
    [JsonPropertyName("discoveryType")]
    public string? DiscoveryType { get; set; }

    /// <summary>Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;) and can&apos;t start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation describing the listing.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the listing.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>The name of the location this data exchange listing.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.</summary>
    [JsonPropertyName("logLinkedDatasetQueryUserEmail")]
    public bool? LogLinkedDatasetQueryUserEmail { get; set; }

    /// <summary>Email or URL of the primary point of contact of the listing.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Details of the publisher who owns the listing and who can share the source data.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publisher")]
    public V1beta2AnalyticsHubListingSpecForProviderPublisher? Publisher { get; set; }

    /// <summary>
    /// Pub/Sub topic source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubsubTopic")]
    public V1beta2AnalyticsHubListingSpecForProviderPubsubTopic? PubsubTopic { get; set; }

    /// <summary>Email or URL of the request access of the listing. Subscribers can use this reference to request access.</summary>
    [JsonPropertyName("requestAccess")]
    public string? RequestAccess { get; set; }

    /// <summary>
    /// If set, restricted export configuration will be propagated and enforced on the linked dataset.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("restrictedExportConfig")]
    public V1beta2AnalyticsHubListingSpecForProviderRestrictedExportConfig? RestrictedExportConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelector
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
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Table in bigquery to populate table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Table in bigquery to populate table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelector
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
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResources
{
    /// <summary>Format: For table: projects/{projectId}/datasets/{datasetId}/tables/{tableId} Example:&quot;projects/test_project/datasets/test_dataset/tables/test_table&quot;</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Reference to a Table in bigquery to populate table.</summary>
    [JsonPropertyName("tableRef")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableRef? TableRef { get; set; }

    /// <summary>Selector for a Table in bigquery to populate table.</summary>
    [JsonPropertyName("tableSelector")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResourcesTableSelector? TableSelector { get; set; }
}

/// <summary>
/// Shared dataset i.e. BigQuery dataset source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderBigqueryDataset
{
    /// <summary>Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate dataset.</summary>
    [JsonPropertyName("datasetRef")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetRef? DatasetRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate dataset.</summary>
    [JsonPropertyName("datasetSelector")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetDatasetSelector? DatasetSelector { get; set; }

    /// <summary>
    /// Resource in this dataset that is selectively shared. This field is required for data clean room exchanges.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("selectedResources")]
    public IList<V1beta2AnalyticsHubListingSpecInitProviderBigqueryDatasetSelectedResources>? SelectedResources { get; set; }
}

/// <summary>
/// Details of the data provider who owns the source data.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderDataProvider
{
    /// <summary>Name of the data provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the data provider.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary>
/// Details of the publisher who owns the listing and who can share the source data.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderPublisher
{
    /// <summary>Name of the listing publisher.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRefPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRefPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelectorPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelector
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
    public V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Pub/Sub topic source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderPubsubTopic
{
    /// <summary>
    /// Region hint on where the data might be published. Data affinity regions are modifiable.
    /// See https://cloud.google.com/about/locations for full listing of possible Cloud regions.
    /// </summary>
    [JsonPropertyName("dataAffinityRegions")]
    public IList<string>? DataAffinityRegions { get; set; }

    /// <summary>Resource name of the Pub/Sub topic source for this listing. e.g. projects/myproject/topics/topicId</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta2AnalyticsHubListingSpecInitProviderPubsubTopicTopicSelector? TopicSelector { get; set; }
}

/// <summary>
/// If set, restricted export configuration will be propagated and enforced on the linked dataset.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecInitProviderRestrictedExportConfig
{
    /// <summary>If true, enable restricted export.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>If true, restrict export of query result derived from restricted linked dataset table.</summary>
    [JsonPropertyName("restrictQueryResult")]
    public bool? RestrictQueryResult { get; set; }
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
public partial class V1beta2AnalyticsHubListingSpecInitProvider
{
    /// <summary>If true, the listing is only available to get the resource metadata. Listing is non subscribable.</summary>
    [JsonPropertyName("allowOnlyMetadataSharing")]
    public bool? AllowOnlyMetadataSharing { get; set; }

    /// <summary>
    /// Shared dataset i.e. BigQuery dataset source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryDataset")]
    public V1beta2AnalyticsHubListingSpecInitProviderBigqueryDataset? BigqueryDataset { get; set; }

    /// <summary>Categories of the listing. Up to two categories are allowed.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>
    /// Details of the data provider who owns the source data.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataProvider")]
    public V1beta2AnalyticsHubListingSpecInitProviderDataProvider? DataProvider { get; set; }

    /// <summary>If the listing is commercial then this field must be set to true, otherwise a failure is thrown. This acts as a safety guard to avoid deleting commercial listings accidentally.</summary>
    [JsonPropertyName("deleteCommercial")]
    public bool? DeleteCommercial { get; set; }

    /// <summary>Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies the type of discovery on the discovery page. Cannot be set for a restricted listing. Note that this does not control the visibility of the exchange/listing which is defined by IAM permission.
    /// Possible values are: DISCOVERY_TYPE_PRIVATE, DISCOVERY_TYPE_PUBLIC.
    /// </summary>
    [JsonPropertyName("discoveryType")]
    public string? DiscoveryType { get; set; }

    /// <summary>Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;) and can&apos;t start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation describing the listing.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the listing.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.</summary>
    [JsonPropertyName("logLinkedDatasetQueryUserEmail")]
    public bool? LogLinkedDatasetQueryUserEmail { get; set; }

    /// <summary>Email or URL of the primary point of contact of the listing.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Details of the publisher who owns the listing and who can share the source data.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publisher")]
    public V1beta2AnalyticsHubListingSpecInitProviderPublisher? Publisher { get; set; }

    /// <summary>
    /// Pub/Sub topic source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubsubTopic")]
    public V1beta2AnalyticsHubListingSpecInitProviderPubsubTopic? PubsubTopic { get; set; }

    /// <summary>Email or URL of the request access of the listing. Subscribers can use this reference to request access.</summary>
    [JsonPropertyName("requestAccess")]
    public string? RequestAccess { get; set; }

    /// <summary>
    /// If set, restricted export configuration will be propagated and enforced on the linked dataset.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("restrictedExportConfig")]
    public V1beta2AnalyticsHubListingSpecInitProviderRestrictedExportConfig? RestrictedExportConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecManagementPoliciesEnum>))]
public enum V1beta2AnalyticsHubListingSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AnalyticsHubListingSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyticsHubListingSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AnalyticsHubListingSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyticsHubListingSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyticsHubListingSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AnalyticsHubListingSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AnalyticsHubListingSpec defines the desired state of AnalyticsHubListing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingSpec
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
    public V1beta2AnalyticsHubListingSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AnalyticsHubListingSpecForProvider ForProvider { get; set; }

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
    public V1beta2AnalyticsHubListingSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2AnalyticsHubListingSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AnalyticsHubListingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AnalyticsHubListingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusAtProviderBigqueryDatasetSelectedResources
{
    /// <summary>Format: For table: projects/{projectId}/datasets/{datasetId}/tables/{tableId} Example:&quot;projects/test_project/datasets/test_dataset/tables/test_table&quot;</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// Shared dataset i.e. BigQuery dataset source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusAtProviderBigqueryDataset
{
    /// <summary>Resource name of the dataset source for this listing. e.g. projects/myproject/datasets/123</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>
    /// Resource in this dataset that is selectively shared. This field is required for data clean room exchanges.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("selectedResources")]
    public IList<V1beta2AnalyticsHubListingStatusAtProviderBigqueryDatasetSelectedResources>? SelectedResources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusAtProviderCommercialInfoCloudMarketplace
{
    /// <summary>
    /// (Output)
    /// Commercial state of the Marketplace Data Product.
    /// Possible values: COMMERCIAL_STATE_UNSPECIFIED, ONBOARDING, ACTIVE
    /// </summary>
    [JsonPropertyName("commercialState")]
    public string? CommercialState { get; set; }

    /// <summary>
    /// (Output)
    /// Resource name of the commercial service associated with the Marketplace Data Product. e.g. example.com
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusAtProviderCommercialInfo
{
    /// <summary>
    /// (Output)
    /// Details of the Marketplace Data Product associated with the Listing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudMarketplace")]
    public IList<V1beta2AnalyticsHubListingStatusAtProviderCommercialInfoCloudMarketplace>? CloudMarketplace { get; set; }
}

/// <summary>
/// Details of the data provider who owns the source data.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusAtProviderDataProvider
{
    /// <summary>Name of the data provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the data provider.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary>
/// Details of the publisher who owns the listing and who can share the source data.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusAtProviderPublisher
{
    /// <summary>Name of the listing publisher.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the listing publisher.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }
}

/// <summary>
/// Pub/Sub topic source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusAtProviderPubsubTopic
{
    /// <summary>
    /// Region hint on where the data might be published. Data affinity regions are modifiable.
    /// See https://cloud.google.com/about/locations for full listing of possible Cloud regions.
    /// </summary>
    [JsonPropertyName("dataAffinityRegions")]
    public IList<string>? DataAffinityRegions { get; set; }

    /// <summary>Resource name of the Pub/Sub topic source for this listing. e.g. projects/myproject/topics/topicId</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>
/// If set, restricted export configuration will be propagated and enforced on the linked dataset.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusAtProviderRestrictedExportConfig
{
    /// <summary>If true, enable restricted export.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// (Output)
    /// If true, restrict direct table access(read api/tabledata.list) on linked table.
    /// </summary>
    [JsonPropertyName("restrictDirectTableAccess")]
    public bool? RestrictDirectTableAccess { get; set; }

    /// <summary>If true, restrict export of query result derived from restricted linked dataset table.</summary>
    [JsonPropertyName("restrictQueryResult")]
    public bool? RestrictQueryResult { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusAtProvider
{
    /// <summary>If true, the listing is only available to get the resource metadata. Listing is non subscribable.</summary>
    [JsonPropertyName("allowOnlyMetadataSharing")]
    public bool? AllowOnlyMetadataSharing { get; set; }

    /// <summary>
    /// Shared dataset i.e. BigQuery dataset source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryDataset")]
    public V1beta2AnalyticsHubListingStatusAtProviderBigqueryDataset? BigqueryDataset { get; set; }

    /// <summary>Categories of the listing. Up to two categories are allowed.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>
    /// Commercial info contains the information about the commercial data products associated with the listing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("commercialInfo")]
    public IList<V1beta2AnalyticsHubListingStatusAtProviderCommercialInfo>? CommercialInfo { get; set; }

    /// <summary>The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.</summary>
    [JsonPropertyName("dataExchangeId")]
    public string? DataExchangeId { get; set; }

    /// <summary>
    /// Details of the data provider who owns the source data.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataProvider")]
    public V1beta2AnalyticsHubListingStatusAtProviderDataProvider? DataProvider { get; set; }

    /// <summary>If the listing is commercial then this field must be set to true, otherwise a failure is thrown. This acts as a safety guard to avoid deleting commercial listings accidentally.</summary>
    [JsonPropertyName("deleteCommercial")]
    public bool? DeleteCommercial { get; set; }

    /// <summary>Short description of the listing. The description must not contain Unicode non-characters and C0 and C1 control codes except tabs (HT), new lines (LF), carriage returns (CR), and page breaks (FF).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies the type of discovery on the discovery page. Cannot be set for a restricted listing. Note that this does not control the visibility of the exchange/listing which is defined by IAM permission.
    /// Possible values are: DISCOVERY_TYPE_PRIVATE, DISCOVERY_TYPE_PUBLIC.
    /// </summary>
    [JsonPropertyName("discoveryType")]
    public string? DiscoveryType { get; set; }

    /// <summary>Human-readable display name of the listing. The display name must contain only Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), ampersands (&amp;) and can&apos;t start or end with spaces.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation describing the listing.</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>Base64 encoded image representing the listing.</summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/dataExchanges/{{data_exchange_id}}/listings/{{listing_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the location this data exchange listing.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>If true, subscriber email logging is enabled and all queries on the linked dataset will log the email address of the querying user. Once enabled, this setting cannot be turned off.</summary>
    [JsonPropertyName("logLinkedDatasetQueryUserEmail")]
    public bool? LogLinkedDatasetQueryUserEmail { get; set; }

    /// <summary>The resource name of the listing. e.g. &quot;projects/myproject/locations/US/dataExchanges/123/listings/456&quot;</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Email or URL of the primary point of contact of the listing.</summary>
    [JsonPropertyName("primaryContact")]
    public string? PrimaryContact { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Details of the publisher who owns the listing and who can share the source data.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publisher")]
    public V1beta2AnalyticsHubListingStatusAtProviderPublisher? Publisher { get; set; }

    /// <summary>
    /// Pub/Sub topic source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubsubTopic")]
    public V1beta2AnalyticsHubListingStatusAtProviderPubsubTopic? PubsubTopic { get; set; }

    /// <summary>Email or URL of the request access of the listing. Subscribers can use this reference to request access.</summary>
    [JsonPropertyName("requestAccess")]
    public string? RequestAccess { get; set; }

    /// <summary>
    /// If set, restricted export configuration will be propagated and enforced on the linked dataset.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("restrictedExportConfig")]
    public V1beta2AnalyticsHubListingStatusAtProviderRestrictedExportConfig? RestrictedExportConfig { get; set; }

    /// <summary>Current state of the listing.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatusConditions
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

/// <summary>AnalyticsHubListingStatus defines the observed state of AnalyticsHubListing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyticsHubListingStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AnalyticsHubListingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AnalyticsHubListingStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AnalyticsHubListing is the Schema for the AnalyticsHubListings API. A Bigquery Analytics Hub data exchange listing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AnalyticsHubListing : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AnalyticsHubListingSpec>, IStatus<V1beta2AnalyticsHubListingStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AnalyticsHubListing";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "analyticshublistings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AnalyticsHubListing";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AnalyticsHubListingSpec defines the desired state of AnalyticsHubListing</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AnalyticsHubListingSpec Spec { get; set; }

    /// <summary>AnalyticsHubListingStatus defines the observed state of AnalyticsHubListing.</summary>
    [JsonPropertyName("status")]
    public V1beta2AnalyticsHubListingStatus? Status { get; set; }
}