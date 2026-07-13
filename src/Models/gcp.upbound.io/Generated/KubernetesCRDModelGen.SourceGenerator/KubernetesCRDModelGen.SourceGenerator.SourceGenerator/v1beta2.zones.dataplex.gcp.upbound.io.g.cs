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
/// <summary>Zone is the Schema for the Zones API. The Dataplex Zone resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ZoneList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Zone>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ZoneList";
    public const string KubeGroup = "dataplex.gcp.upbound.io";
    public const string KubePluralName = "zones";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ZoneList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Zone objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Zone> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ZoneSpecDeletionPolicyEnum>))]
public enum V1beta2ZoneSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Optional. Configuration for CSV data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecForProviderDiscoverySpecCsvOptions
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
public partial class V1beta2ZoneSpecForProviderDiscoverySpecJsonOptions
{
    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Required. Specification of the discovery feature applied to data in this zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecForProviderDiscoverySpec
{
    /// <summary>Optional. Configuration for CSV data.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta2ZoneSpecForProviderDiscoverySpecCsvOptions? CsvOptions { get; set; }

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
    public V1beta2ZoneSpecForProviderDiscoverySpecJsonOptions? JsonOptions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ZoneSpecForProviderLakeRefPolicyResolutionEnum>))]
public enum V1beta2ZoneSpecForProviderLakeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ZoneSpecForProviderLakeRefPolicyResolveEnum>))]
public enum V1beta2ZoneSpecForProviderLakeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecForProviderLakeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ZoneSpecForProviderLakeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ZoneSpecForProviderLakeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Lake in dataplex to populate lake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecForProviderLakeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ZoneSpecForProviderLakeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ZoneSpecForProviderLakeSelectorPolicyResolutionEnum>))]
public enum V1beta2ZoneSpecForProviderLakeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ZoneSpecForProviderLakeSelectorPolicyResolveEnum>))]
public enum V1beta2ZoneSpecForProviderLakeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecForProviderLakeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ZoneSpecForProviderLakeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ZoneSpecForProviderLakeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Lake in dataplex to populate lake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecForProviderLakeSelector
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
    public V1beta2ZoneSpecForProviderLakeSelectorPolicy? Policy { get; set; }
}

/// <summary>Required. Immutable. Specification of the resources that are referenced by the assets within this zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecForProviderResourceSpec
{
    /// <summary>Required. Immutable. The location type of the resources that are allowed to be attached to the assets within this zone. Possible values: LOCATION_TYPE_UNSPECIFIED, SINGLE_REGION, MULTI_REGION</summary>
    [JsonPropertyName("locationType")]
    public string? LocationType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecForProvider
{
    /// <summary>Optional. Description of the zone.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Specification of the discovery feature applied to data in this zone.</summary>
    [JsonPropertyName("discoverySpec")]
    public V1beta2ZoneSpecForProviderDiscoverySpec? DiscoverySpec { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. User defined labels for the zone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The lake for the resource</summary>
    [JsonPropertyName("lake")]
    public string? Lake { get; set; }

    /// <summary>Reference to a Lake in dataplex to populate lake.</summary>
    [JsonPropertyName("lakeRef")]
    public V1beta2ZoneSpecForProviderLakeRef? LakeRef { get; set; }

    /// <summary>Selector for a Lake in dataplex to populate lake.</summary>
    [JsonPropertyName("lakeSelector")]
    public V1beta2ZoneSpecForProviderLakeSelector? LakeSelector { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Required. Immutable. Specification of the resources that are referenced by the assets within this zone.</summary>
    [JsonPropertyName("resourceSpec")]
    public V1beta2ZoneSpecForProviderResourceSpec? ResourceSpec { get; set; }

    /// <summary>Required. Immutable. The type of the zone. Possible values: TYPE_UNSPECIFIED, RAW, CURATED</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Optional. Configuration for CSV data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecInitProviderDiscoverySpecCsvOptions
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
public partial class V1beta2ZoneSpecInitProviderDiscoverySpecJsonOptions
{
    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Required. Specification of the discovery feature applied to data in this zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecInitProviderDiscoverySpec
{
    /// <summary>Optional. Configuration for CSV data.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta2ZoneSpecInitProviderDiscoverySpecCsvOptions? CsvOptions { get; set; }

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
    public V1beta2ZoneSpecInitProviderDiscoverySpecJsonOptions? JsonOptions { get; set; }

    /// <summary>Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60 minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &quot;CRON_TZ=${IANA_TIME_ZONE}&quot; or TZ=${IANA_TIME_ZONE}&quot;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, &quot;CRON_TZ=America/New_York 1 * * * *&quot;, or &quot;TZ=America/New_York 1 * * * *&quot;.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>Required. Immutable. Specification of the resources that are referenced by the assets within this zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecInitProviderResourceSpec
{
    /// <summary>Required. Immutable. The location type of the resources that are allowed to be attached to the assets within this zone. Possible values: LOCATION_TYPE_UNSPECIFIED, SINGLE_REGION, MULTI_REGION</summary>
    [JsonPropertyName("locationType")]
    public string? LocationType { get; set; }
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
public partial class V1beta2ZoneSpecInitProvider
{
    /// <summary>Optional. Description of the zone.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Specification of the discovery feature applied to data in this zone.</summary>
    [JsonPropertyName("discoverySpec")]
    public V1beta2ZoneSpecInitProviderDiscoverySpec? DiscoverySpec { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. User defined labels for the zone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Required. Immutable. Specification of the resources that are referenced by the assets within this zone.</summary>
    [JsonPropertyName("resourceSpec")]
    public V1beta2ZoneSpecInitProviderResourceSpec? ResourceSpec { get; set; }

    /// <summary>Required. Immutable. The type of the zone. Possible values: TYPE_UNSPECIFIED, RAW, CURATED</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ZoneSpecManagementPoliciesEnum>))]
public enum V1beta2ZoneSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ZoneSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ZoneSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ZoneSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ZoneSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ZoneSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ZoneSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ZoneSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ZoneSpec defines the desired state of Zone</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneSpec
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
    public V1beta2ZoneSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ZoneSpecForProvider ForProvider { get; set; }

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
    public V1beta2ZoneSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ZoneSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ZoneSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ZoneSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneStatusAtProviderAssetStatus
{
    [JsonPropertyName("activeAssets")]
    public double? ActiveAssets { get; set; }

    [JsonPropertyName("securityPolicyApplyingAssets")]
    public double? SecurityPolicyApplyingAssets { get; set; }

    /// <summary>Output only. The time when the zone was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Optional. Configuration for CSV data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneStatusAtProviderDiscoverySpecCsvOptions
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
public partial class V1beta2ZoneStatusAtProviderDiscoverySpecJsonOptions
{
    /// <summary>Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).</summary>
    [JsonPropertyName("disableTypeInference")]
    public bool? DisableTypeInference { get; set; }

    /// <summary>Optional. The character encoding of the data. The default is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Required. Specification of the discovery feature applied to data in this zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneStatusAtProviderDiscoverySpec
{
    /// <summary>Optional. Configuration for CSV data.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta2ZoneStatusAtProviderDiscoverySpecCsvOptions? CsvOptions { get; set; }

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
    public V1beta2ZoneStatusAtProviderDiscoverySpecJsonOptions? JsonOptions { get; set; }

    /// <summary>Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60 minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &quot;CRON_TZ=${IANA_TIME_ZONE}&quot; or TZ=${IANA_TIME_ZONE}&quot;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, &quot;CRON_TZ=America/New_York 1 * * * *&quot;, or &quot;TZ=America/New_York 1 * * * *&quot;.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}

/// <summary>Required. Immutable. Specification of the resources that are referenced by the assets within this zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneStatusAtProviderResourceSpec
{
    /// <summary>Required. Immutable. The location type of the resources that are allowed to be attached to the assets within this zone. Possible values: LOCATION_TYPE_UNSPECIFIED, SINGLE_REGION, MULTI_REGION</summary>
    [JsonPropertyName("locationType")]
    public string? LocationType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneStatusAtProvider
{
    /// <summary>Output only. Aggregated status of the underlying assets of the zone.</summary>
    [JsonPropertyName("assetStatus")]
    public IList<V1beta2ZoneStatusAtProviderAssetStatus>? AssetStatus { get; set; }

    /// <summary>Output only. The time when the zone was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. Description of the zone.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Specification of the discovery feature applied to data in this zone.</summary>
    [JsonPropertyName("discoverySpec")]
    public V1beta2ZoneStatusAtProviderDiscoverySpec? DiscoverySpec { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/lakes/{{lake}}/zones/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. User defined labels for the zone.</summary>
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

    /// <summary>Required. Immutable. Specification of the resources that are referenced by the assets within this zone.</summary>
    [JsonPropertyName("resourceSpec")]
    public V1beta2ZoneStatusAtProviderResourceSpec? ResourceSpec { get; set; }

    /// <summary>Output only. Current state of the zone. Possible values: STATE_UNSPECIFIED, ACTIVE, CREATING, DELETING, ACTION_REQUIRED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Required. Immutable. The type of the zone. Possible values: TYPE_UNSPECIFIED, RAW, CURATED</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Output only. System generated globally unique ID for the zone. This ID will be different if the zone is deleted and re-created with the same name.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the zone was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneStatusConditions
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

/// <summary>ZoneStatus defines the observed state of Zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ZoneStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ZoneStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ZoneStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Zone is the Schema for the Zones API. The Dataplex Zone resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Zone : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ZoneSpec>, IStatus<V1beta2ZoneStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Zone";
    public const string KubeGroup = "dataplex.gcp.upbound.io";
    public const string KubePluralName = "zones";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataplex.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Zone";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ZoneSpec defines the desired state of Zone</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ZoneSpec Spec { get; set; }

    /// <summary>ZoneStatus defines the observed state of Zone.</summary>
    [JsonPropertyName("status")]
    public V1beta2ZoneStatus? Status { get; set; }
}