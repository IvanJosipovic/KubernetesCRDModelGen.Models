#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataplex.gcp.upbound.io;
/// <summary>Asset is the Schema for the Assets API. The Dataplex Asset resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AssetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Asset>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AssetList";
    public const string KubeGroup = "dataplex.gcp.upbound.io";
    public const string KubePluralName = "assets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AssetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Asset objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Asset> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecDeletionPolicyEnum>))]
public enum V1beta2AssetSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecForProviderDataplexZoneRefPolicyResolutionEnum>))]
public enum V1beta2AssetSpecForProviderDataplexZoneRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecForProviderDataplexZoneRefPolicyResolveEnum>))]
public enum V1beta2AssetSpecForProviderDataplexZoneRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderDataplexZoneRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AssetSpecForProviderDataplexZoneRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AssetSpecForProviderDataplexZoneRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Zone in dataplex to populate dataplexZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderDataplexZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AssetSpecForProviderDataplexZoneRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecForProviderDataplexZoneSelectorPolicyResolutionEnum>))]
public enum V1beta2AssetSpecForProviderDataplexZoneSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecForProviderDataplexZoneSelectorPolicyResolveEnum>))]
public enum V1beta2AssetSpecForProviderDataplexZoneSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderDataplexZoneSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AssetSpecForProviderDataplexZoneSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AssetSpecForProviderDataplexZoneSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Zone in dataplex to populate dataplexZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderDataplexZoneSelector
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
    public V1beta2AssetSpecForProviderDataplexZoneSelectorPolicy? Policy { get; set; }
}

/// <summary>Optional. Configuration for CSV data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderDiscoverySpecCsvOptions
{
    /// <summary>Optional. The delimiter being used to separate values. This defaults to &apos;,&apos;.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.</summary>
    [JsonPropertyName("headerRows")]
    public double? HeaderRows { get; set; }
}

/// <summary>Optional. Configuration for Json data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderDiscoverySpecJsonOptions
{
    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Required. Specification of the discovery feature applied to data referenced by this asset. When this spec is left unset, the asset will use the spec set on the parent zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderDiscoverySpec
{
    /// <summary>Optional. Configuration for CSV data.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta2AssetSpecForProviderDiscoverySpecCsvOptions? CsvOptions { get; set; }

    /// <summary>Required. Whether discovery is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. The list of patterns to apply for selecting data to exclude during discovery. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("excludePatterns")]
    public IList<string>? ExcludePatterns { get; set; }

    /// <summary>Optional. The list of patterns to apply for selecting data to include during discovery if only a subset of the data should considered. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("includePatterns")]
    public IList<string>? IncludePatterns { get; set; }

    /// <summary>Optional. Configuration for Json data.</summary>
    [JsonPropertyName("jsonOptions")]
    public V1beta2AssetSpecForProviderDiscoverySpecJsonOptions? JsonOptions { get; set; }

    /// <summary>Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60 minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &quot;CRON_TZ=${IANA_TIME_ZONE}&quot; or TZ=${IANA_TIME_ZONE}&quot;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, &quot;CRON_TZ=America/New_York 1 * * * *&quot;, or &quot;TZ=America/New_York 1 * * * *&quot;.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecForProviderLakeRefPolicyResolutionEnum>))]
public enum V1beta2AssetSpecForProviderLakeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecForProviderLakeRefPolicyResolveEnum>))]
public enum V1beta2AssetSpecForProviderLakeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderLakeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AssetSpecForProviderLakeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AssetSpecForProviderLakeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Lake in dataplex to populate lake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderLakeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AssetSpecForProviderLakeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecForProviderLakeSelectorPolicyResolutionEnum>))]
public enum V1beta2AssetSpecForProviderLakeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecForProviderLakeSelectorPolicyResolveEnum>))]
public enum V1beta2AssetSpecForProviderLakeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderLakeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AssetSpecForProviderLakeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AssetSpecForProviderLakeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Lake in dataplex to populate lake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderLakeSelector
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
    public V1beta2AssetSpecForProviderLakeSelectorPolicy? Policy { get; set; }
}

/// <summary>Required. Immutable. Specification of the resource that is referenced by this asset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProviderResourceSpec
{
    /// <summary>Immutable. Relative name of the cloud resource that contains the data that is being managed within a lake. For example: projects/{project_number}/buckets/{bucket_id} projects/{project_number}/datasets/{dataset_id}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Determines how read permissions are handled for each asset and their associated tables. Only available to storage buckets assets. Possible values: DIRECT, MANAGED</summary>
    [JsonPropertyName("readAccessMode")]
    public string? ReadAccessMode { get; set; }

    /// <summary>Required. Immutable. Type of resource. Possible values: STORAGE_BUCKET, BIGQUERY_DATASET</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecForProvider
{
    /// <summary>The zone for the resource</summary>
    [JsonPropertyName("dataplexZone")]
    public string? DataplexZone { get; set; }

    /// <summary>Reference to a Zone in dataplex to populate dataplexZone.</summary>
    [JsonPropertyName("dataplexZoneRef")]
    public V1beta2AssetSpecForProviderDataplexZoneRef? DataplexZoneRef { get; set; }

    /// <summary>Selector for a Zone in dataplex to populate dataplexZone.</summary>
    [JsonPropertyName("dataplexZoneSelector")]
    public V1beta2AssetSpecForProviderDataplexZoneSelector? DataplexZoneSelector { get; set; }

    /// <summary>Optional. Description of the asset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Specification of the discovery feature applied to data referenced by this asset. When this spec is left unset, the asset will use the spec set on the parent zone.</summary>
    [JsonPropertyName("discoverySpec")]
    public V1beta2AssetSpecForProviderDiscoverySpec? DiscoverySpec { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. User defined labels for the asset.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The lake for the resource</summary>
    [JsonPropertyName("lake")]
    public string? Lake { get; set; }

    /// <summary>Reference to a Lake in dataplex to populate lake.</summary>
    [JsonPropertyName("lakeRef")]
    public V1beta2AssetSpecForProviderLakeRef? LakeRef { get; set; }

    /// <summary>Selector for a Lake in dataplex to populate lake.</summary>
    [JsonPropertyName("lakeSelector")]
    public V1beta2AssetSpecForProviderLakeSelector? LakeSelector { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Required. Immutable. Specification of the resource that is referenced by this asset.</summary>
    [JsonPropertyName("resourceSpec")]
    public V1beta2AssetSpecForProviderResourceSpec? ResourceSpec { get; set; }
}

/// <summary>Optional. Configuration for CSV data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecInitProviderDiscoverySpecCsvOptions
{
    /// <summary>Optional. The delimiter being used to separate values. This defaults to &apos;,&apos;.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.</summary>
    [JsonPropertyName("headerRows")]
    public double? HeaderRows { get; set; }
}

/// <summary>Optional. Configuration for Json data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecInitProviderDiscoverySpecJsonOptions
{
    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Required. Specification of the discovery feature applied to data referenced by this asset. When this spec is left unset, the asset will use the spec set on the parent zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecInitProviderDiscoverySpec
{
    /// <summary>Optional. Configuration for CSV data.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta2AssetSpecInitProviderDiscoverySpecCsvOptions? CsvOptions { get; set; }

    /// <summary>Required. Whether discovery is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. The list of patterns to apply for selecting data to exclude during discovery. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("excludePatterns")]
    public IList<string>? ExcludePatterns { get; set; }

    /// <summary>Optional. The list of patterns to apply for selecting data to include during discovery if only a subset of the data should considered. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("includePatterns")]
    public IList<string>? IncludePatterns { get; set; }

    /// <summary>Optional. Configuration for Json data.</summary>
    [JsonPropertyName("jsonOptions")]
    public V1beta2AssetSpecInitProviderDiscoverySpecJsonOptions? JsonOptions { get; set; }

    /// <summary>Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60 minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &quot;CRON_TZ=${IANA_TIME_ZONE}&quot; or TZ=${IANA_TIME_ZONE}&quot;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, &quot;CRON_TZ=America/New_York 1 * * * *&quot;, or &quot;TZ=America/New_York 1 * * * *&quot;.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>Required. Immutable. Specification of the resource that is referenced by this asset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecInitProviderResourceSpec
{
    /// <summary>Immutable. Relative name of the cloud resource that contains the data that is being managed within a lake. For example: projects/{project_number}/buckets/{bucket_id} projects/{project_number}/datasets/{dataset_id}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Determines how read permissions are handled for each asset and their associated tables. Only available to storage buckets assets. Possible values: DIRECT, MANAGED</summary>
    [JsonPropertyName("readAccessMode")]
    public string? ReadAccessMode { get; set; }

    /// <summary>Required. Immutable. Type of resource. Possible values: STORAGE_BUCKET, BIGQUERY_DATASET</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
public partial class V1beta2AssetSpecInitProvider
{
    /// <summary>Optional. Description of the asset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Specification of the discovery feature applied to data referenced by this asset. When this spec is left unset, the asset will use the spec set on the parent zone.</summary>
    [JsonPropertyName("discoverySpec")]
    public V1beta2AssetSpecInitProviderDiscoverySpec? DiscoverySpec { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. User defined labels for the asset.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Required. Immutable. Specification of the resource that is referenced by this asset.</summary>
    [JsonPropertyName("resourceSpec")]
    public V1beta2AssetSpecInitProviderResourceSpec? ResourceSpec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecManagementPoliciesEnum>))]
public enum V1beta2AssetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AssetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AssetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AssetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AssetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AssetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AssetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AssetSpec defines the desired state of Asset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetSpec
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
    public V1beta2AssetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AssetSpecForProvider ForProvider { get; set; }

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
    public V1beta2AssetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2AssetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AssetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AssetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Optional. Configuration for CSV data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusAtProviderDiscoverySpecCsvOptions
{
    /// <summary>Optional. The delimiter being used to separate values. This defaults to &apos;,&apos;.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.</summary>
    [JsonPropertyName("headerRows")]
    public double? HeaderRows { get; set; }
}

/// <summary>Optional. Configuration for Json data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusAtProviderDiscoverySpecJsonOptions
{
    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Required. Specification of the discovery feature applied to data referenced by this asset. When this spec is left unset, the asset will use the spec set on the parent zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusAtProviderDiscoverySpec
{
    /// <summary>Optional. Configuration for CSV data.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta2AssetStatusAtProviderDiscoverySpecCsvOptions? CsvOptions { get; set; }

    /// <summary>Required. Whether discovery is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. The list of patterns to apply for selecting data to exclude during discovery. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("excludePatterns")]
    public IList<string>? ExcludePatterns { get; set; }

    /// <summary>Optional. The list of patterns to apply for selecting data to include during discovery if only a subset of the data should considered. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.</summary>
    [JsonPropertyName("includePatterns")]
    public IList<string>? IncludePatterns { get; set; }

    /// <summary>Optional. Configuration for Json data.</summary>
    [JsonPropertyName("jsonOptions")]
    public V1beta2AssetStatusAtProviderDiscoverySpecJsonOptions? JsonOptions { get; set; }

    /// <summary>Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60 minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &quot;CRON_TZ=${IANA_TIME_ZONE}&quot; or TZ=${IANA_TIME_ZONE}&quot;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, &quot;CRON_TZ=America/New_York 1 * * * *&quot;, or &quot;TZ=America/New_York 1 * * * *&quot;.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusAtProviderDiscoveryStatusStats
{
    [JsonPropertyName("dataItems")]
    public double? DataItems { get; set; }

    [JsonPropertyName("dataSize")]
    public double? DataSize { get; set; }

    [JsonPropertyName("filesets")]
    public double? Filesets { get; set; }

    [JsonPropertyName("tables")]
    public double? Tables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusAtProviderDiscoveryStatus
{
    [JsonPropertyName("lastRunDuration")]
    public string? LastRunDuration { get; set; }

    [JsonPropertyName("lastRunTime")]
    public string? LastRunTime { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Output only. Current state of the asset. Possible values: STATE_UNSPECIFIED, ACTIVE, CREATING, DELETING, ACTION_REQUIRED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("stats")]
    public IList<V1beta2AssetStatusAtProviderDiscoveryStatusStats>? Stats { get; set; }

    /// <summary>Output only. The time when the asset was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Required. Immutable. Specification of the resource that is referenced by this asset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusAtProviderResourceSpec
{
    /// <summary>Immutable. Relative name of the cloud resource that contains the data that is being managed within a lake. For example: projects/{project_number}/buckets/{bucket_id} projects/{project_number}/datasets/{dataset_id}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. Determines how read permissions are handled for each asset and their associated tables. Only available to storage buckets assets. Possible values: DIRECT, MANAGED</summary>
    [JsonPropertyName("readAccessMode")]
    public string? ReadAccessMode { get; set; }

    /// <summary>Required. Immutable. Type of resource. Possible values: STORAGE_BUCKET, BIGQUERY_DATASET</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusAtProviderResourceStatus
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Output only. Current state of the asset. Possible values: STATE_UNSPECIFIED, ACTIVE, CREATING, DELETING, ACTION_REQUIRED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when the asset was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusAtProviderSecurityStatus
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Output only. Current state of the asset. Possible values: STATE_UNSPECIFIED, ACTIVE, CREATING, DELETING, ACTION_REQUIRED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when the asset was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusAtProvider
{
    /// <summary>Output only. The time when the asset was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The zone for the resource</summary>
    [JsonPropertyName("dataplexZone")]
    public string? DataplexZone { get; set; }

    /// <summary>Optional. Description of the asset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Specification of the discovery feature applied to data referenced by this asset. When this spec is left unset, the asset will use the spec set on the parent zone.</summary>
    [JsonPropertyName("discoverySpec")]
    public V1beta2AssetStatusAtProviderDiscoverySpec? DiscoverySpec { get; set; }

    /// <summary>Output only. Status of the discovery feature applied to data referenced by this asset.</summary>
    [JsonPropertyName("discoveryStatus")]
    public IList<V1beta2AssetStatusAtProviderDiscoveryStatus>? DiscoveryStatus { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/lakes/{{lake}}/zones/{{dataplex_zone}}/assets/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. User defined labels for the asset.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The lake for the resource</summary>
    [JsonPropertyName("lake")]
    public string? Lake { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Required. Immutable. Specification of the resource that is referenced by this asset.</summary>
    [JsonPropertyName("resourceSpec")]
    public V1beta2AssetStatusAtProviderResourceSpec? ResourceSpec { get; set; }

    /// <summary>Output only. Status of the resource referenced by this asset.</summary>
    [JsonPropertyName("resourceStatus")]
    public IList<V1beta2AssetStatusAtProviderResourceStatus>? ResourceStatus { get; set; }

    /// <summary>Output only. Status of the security policy applied to resource referenced by this asset.</summary>
    [JsonPropertyName("securityStatus")]
    public IList<V1beta2AssetStatusAtProviderSecurityStatus>? SecurityStatus { get; set; }

    /// <summary>Output only. Current state of the asset. Possible values: STATE_UNSPECIFIED, ACTIVE, CREATING, DELETING, ACTION_REQUIRED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Output only. System generated globally unique ID for the asset. This ID will be different if the asset is deleted and re-created with the same name.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the asset was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatusConditions
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

/// <summary>AssetStatus defines the observed state of Asset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AssetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AssetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AssetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Asset is the Schema for the Assets API. The Dataplex Asset resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Asset : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AssetSpec>, IStatus<V1beta2AssetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Asset";
    public const string KubeGroup = "dataplex.gcp.upbound.io";
    public const string KubePluralName = "assets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Asset";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AssetSpec defines the desired state of Asset</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AssetSpec Spec { get; set; }

    /// <summary>AssetStatus defines the observed state of Asset.</summary>
    [JsonPropertyName("status")]
    public V1beta2AssetStatus? Status { get; set; }
}