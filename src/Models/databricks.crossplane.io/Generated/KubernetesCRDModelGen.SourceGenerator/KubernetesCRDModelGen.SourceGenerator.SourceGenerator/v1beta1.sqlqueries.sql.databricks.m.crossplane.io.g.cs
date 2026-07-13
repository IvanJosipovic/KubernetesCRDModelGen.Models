#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.databricks.m.crossplane.io;
/// <summary>SQLQuery is the Schema for the SQLQuerys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLQueryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SQLQuery>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLQueryList";
    public const string KubeGroup = "sql.databricks.m.crossplane.io";
    public const string KubePluralName = "sqlqueries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SQLQueryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1SQLQuery objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1SQLQuery> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SQLQuerySpecForProviderDataSourceIdRefPolicyResolutionEnum>))]
public enum V1beta1SQLQuerySpecForProviderDataSourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SQLQuerySpecForProviderDataSourceIdRefPolicyResolveEnum>))]
public enum V1beta1SQLQuerySpecForProviderDataSourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderDataSourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SQLQuerySpecForProviderDataSourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SQLQuerySpecForProviderDataSourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SQLEndpoint in sql to populate dataSourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderDataSourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLQuerySpecForProviderDataSourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SQLQuerySpecForProviderDataSourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SQLQuerySpecForProviderDataSourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SQLQuerySpecForProviderDataSourceIdSelectorPolicyResolveEnum>))]
public enum V1beta1SQLQuerySpecForProviderDataSourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderDataSourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SQLQuerySpecForProviderDataSourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SQLQuerySpecForProviderDataSourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SQLEndpoint in sql to populate dataSourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderDataSourceIdSelector
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
    public V1beta1SQLQuerySpecForProviderDataSourceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterDate
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterDateRangeRange
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterDateRange
{
    [JsonPropertyName("range")]
    public V1beta1SQLQuerySpecForProviderParameterDateRangeRange? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterDatetime
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterDatetimeRangeRange
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterDatetimeRange
{
    [JsonPropertyName("range")]
    public V1beta1SQLQuerySpecForProviderParameterDatetimeRangeRange? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterDatetimesec
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterDatetimesecRangeRange
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterDatetimesecRange
{
    [JsonPropertyName("range")]
    public V1beta1SQLQuerySpecForProviderParameterDatetimesecRangeRange? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterEnumMultiple
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterEnum
{
    [JsonPropertyName("multiple")]
    public V1beta1SQLQuerySpecForProviderParameterEnumMultiple? Multiple { get; set; }

    [JsonPropertyName("options")]
    public IList<string>? Options { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterNumber
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterQueryMultiple
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>The text of the query to be run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterQuery
{
    [JsonPropertyName("multiple")]
    public V1beta1SQLQuerySpecForProviderParameterQueryMultiple? Multiple { get; set; }

    /// <summary>the unique ID of the SQL Query.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameterText
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderParameter
{
    [JsonPropertyName("date")]
    public V1beta1SQLQuerySpecForProviderParameterDate? Date { get; set; }

    [JsonPropertyName("dateRange")]
    public V1beta1SQLQuerySpecForProviderParameterDateRange? DateRange { get; set; }

    [JsonPropertyName("datetime")]
    public V1beta1SQLQuerySpecForProviderParameterDatetime? Datetime { get; set; }

    [JsonPropertyName("datetimeRange")]
    public V1beta1SQLQuerySpecForProviderParameterDatetimeRange? DatetimeRange { get; set; }

    [JsonPropertyName("datetimesec")]
    public V1beta1SQLQuerySpecForProviderParameterDatetimesec? Datetimesec { get; set; }

    [JsonPropertyName("datetimesecRange")]
    public V1beta1SQLQuerySpecForProviderParameterDatetimesecRange? DatetimesecRange { get; set; }

    [JsonPropertyName("enum")]
    public V1beta1SQLQuerySpecForProviderParameterEnum? Enum { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("number")]
    public V1beta1SQLQuerySpecForProviderParameterNumber? Number { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public V1beta1SQLQuerySpecForProviderParameterQuery? Query { get; set; }

    [JsonPropertyName("text")]
    public V1beta1SQLQuerySpecForProviderParameterText? Text { get; set; }

    /// <summary>The text displayed in a parameter picking widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderScheduleContinuous
{
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderScheduleDaily
{
    [JsonPropertyName("intervalDays")]
    public double? IntervalDays { get; set; }

    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderScheduleWeekly
{
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    [JsonPropertyName("intervalWeeks")]
    public double? IntervalWeeks { get; set; }

    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProviderSchedule
{
    [JsonPropertyName("continuous")]
    public V1beta1SQLQuerySpecForProviderScheduleContinuous? Continuous { get; set; }

    [JsonPropertyName("daily")]
    public V1beta1SQLQuerySpecForProviderScheduleDaily? Daily { get; set; }

    [JsonPropertyName("weekly")]
    public V1beta1SQLQuerySpecForProviderScheduleWeekly? Weekly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecForProvider
{
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Data source ID of a SQL warehouse</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Reference to a SQLEndpoint in sql to populate dataSourceId.</summary>
    [JsonPropertyName("dataSourceIdRef")]
    public V1beta1SQLQuerySpecForProviderDataSourceIdRef? DataSourceIdRef { get; set; }

    /// <summary>Selector for a SQLEndpoint in sql to populate dataSourceId.</summary>
    [JsonPropertyName("dataSourceIdSelector")]
    public V1beta1SQLQuerySpecForProviderDataSourceIdSelector? DataSourceIdSelector { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("parameter")]
    public IList<V1beta1SQLQuerySpecForProviderParameter>? Parameter { get; set; }

    /// <summary>The identifier of the workspace folder containing the object.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1SQLQuerySpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Run as role. Possible values are viewer, owner.</summary>
    [JsonPropertyName("runAsRole")]
    public string? RunAsRole { get; set; }

    [JsonPropertyName("schedule")]
    public V1beta1SQLQuerySpecForProviderSchedule? Schedule { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SQLQuerySpecInitProviderDataSourceIdRefPolicyResolutionEnum>))]
public enum V1beta1SQLQuerySpecInitProviderDataSourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SQLQuerySpecInitProviderDataSourceIdRefPolicyResolveEnum>))]
public enum V1beta1SQLQuerySpecInitProviderDataSourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderDataSourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SQLQuerySpecInitProviderDataSourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SQLQuerySpecInitProviderDataSourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SQLEndpoint in sql to populate dataSourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderDataSourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLQuerySpecInitProviderDataSourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SQLQuerySpecInitProviderDataSourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SQLQuerySpecInitProviderDataSourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SQLQuerySpecInitProviderDataSourceIdSelectorPolicyResolveEnum>))]
public enum V1beta1SQLQuerySpecInitProviderDataSourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderDataSourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SQLQuerySpecInitProviderDataSourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SQLQuerySpecInitProviderDataSourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SQLEndpoint in sql to populate dataSourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderDataSourceIdSelector
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
    public V1beta1SQLQuerySpecInitProviderDataSourceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterDate
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterDateRangeRange
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterDateRange
{
    [JsonPropertyName("range")]
    public V1beta1SQLQuerySpecInitProviderParameterDateRangeRange? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterDatetime
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterDatetimeRangeRange
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterDatetimeRange
{
    [JsonPropertyName("range")]
    public V1beta1SQLQuerySpecInitProviderParameterDatetimeRangeRange? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterDatetimesec
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterDatetimesecRangeRange
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterDatetimesecRange
{
    [JsonPropertyName("range")]
    public V1beta1SQLQuerySpecInitProviderParameterDatetimesecRangeRange? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterEnumMultiple
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterEnum
{
    [JsonPropertyName("multiple")]
    public V1beta1SQLQuerySpecInitProviderParameterEnumMultiple? Multiple { get; set; }

    [JsonPropertyName("options")]
    public IList<string>? Options { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterNumber
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterQueryMultiple
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>The text of the query to be run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterQuery
{
    [JsonPropertyName("multiple")]
    public V1beta1SQLQuerySpecInitProviderParameterQueryMultiple? Multiple { get; set; }

    /// <summary>the unique ID of the SQL Query.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameterText
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderParameter
{
    [JsonPropertyName("date")]
    public V1beta1SQLQuerySpecInitProviderParameterDate? Date { get; set; }

    [JsonPropertyName("dateRange")]
    public V1beta1SQLQuerySpecInitProviderParameterDateRange? DateRange { get; set; }

    [JsonPropertyName("datetime")]
    public V1beta1SQLQuerySpecInitProviderParameterDatetime? Datetime { get; set; }

    [JsonPropertyName("datetimeRange")]
    public V1beta1SQLQuerySpecInitProviderParameterDatetimeRange? DatetimeRange { get; set; }

    [JsonPropertyName("datetimesec")]
    public V1beta1SQLQuerySpecInitProviderParameterDatetimesec? Datetimesec { get; set; }

    [JsonPropertyName("datetimesecRange")]
    public V1beta1SQLQuerySpecInitProviderParameterDatetimesecRange? DatetimesecRange { get; set; }

    [JsonPropertyName("enum")]
    public V1beta1SQLQuerySpecInitProviderParameterEnum? Enum { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("number")]
    public V1beta1SQLQuerySpecInitProviderParameterNumber? Number { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public V1beta1SQLQuerySpecInitProviderParameterQuery? Query { get; set; }

    [JsonPropertyName("text")]
    public V1beta1SQLQuerySpecInitProviderParameterText? Text { get; set; }

    /// <summary>The text displayed in a parameter picking widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderScheduleContinuous
{
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderScheduleDaily
{
    [JsonPropertyName("intervalDays")]
    public double? IntervalDays { get; set; }

    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderScheduleWeekly
{
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    [JsonPropertyName("intervalWeeks")]
    public double? IntervalWeeks { get; set; }

    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpecInitProviderSchedule
{
    [JsonPropertyName("continuous")]
    public V1beta1SQLQuerySpecInitProviderScheduleContinuous? Continuous { get; set; }

    [JsonPropertyName("daily")]
    public V1beta1SQLQuerySpecInitProviderScheduleDaily? Daily { get; set; }

    [JsonPropertyName("weekly")]
    public V1beta1SQLQuerySpecInitProviderScheduleWeekly? Weekly { get; set; }
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
public partial class V1beta1SQLQuerySpecInitProvider
{
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Data source ID of a SQL warehouse</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Reference to a SQLEndpoint in sql to populate dataSourceId.</summary>
    [JsonPropertyName("dataSourceIdRef")]
    public V1beta1SQLQuerySpecInitProviderDataSourceIdRef? DataSourceIdRef { get; set; }

    /// <summary>Selector for a SQLEndpoint in sql to populate dataSourceId.</summary>
    [JsonPropertyName("dataSourceIdSelector")]
    public V1beta1SQLQuerySpecInitProviderDataSourceIdSelector? DataSourceIdSelector { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("parameter")]
    public IList<V1beta1SQLQuerySpecInitProviderParameter>? Parameter { get; set; }

    /// <summary>The identifier of the workspace folder containing the object.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1SQLQuerySpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Run as role. Possible values are viewer, owner.</summary>
    [JsonPropertyName("runAsRole")]
    public string? RunAsRole { get; set; }

    [JsonPropertyName("schedule")]
    public V1beta1SQLQuerySpecInitProviderSchedule? Schedule { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SQLQuerySpecManagementPoliciesEnum>))]
public enum V1beta1SQLQuerySpecManagementPoliciesEnum
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
public partial class V1beta1SQLQuerySpecProviderConfigRef
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
public partial class V1beta1SQLQuerySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SQLQuerySpec defines the desired state of SQLQuery</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQuerySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1SQLQuerySpecForProvider ForProvider { get; set; }

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
    public V1beta1SQLQuerySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SQLQuerySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SQLQuerySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SQLQuerySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterDate
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterDateRangeRange
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterDateRange
{
    [JsonPropertyName("range")]
    public V1beta1SQLQueryStatusAtProviderParameterDateRangeRange? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterDatetime
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterDatetimeRangeRange
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterDatetimeRange
{
    [JsonPropertyName("range")]
    public V1beta1SQLQueryStatusAtProviderParameterDatetimeRangeRange? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterDatetimesec
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterDatetimesecRangeRange
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterDatetimesecRange
{
    [JsonPropertyName("range")]
    public V1beta1SQLQueryStatusAtProviderParameterDatetimesecRangeRange? Range { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterEnumMultiple
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterEnum
{
    [JsonPropertyName("multiple")]
    public V1beta1SQLQueryStatusAtProviderParameterEnumMultiple? Multiple { get; set; }

    [JsonPropertyName("options")]
    public IList<string>? Options { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterNumber
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterQueryMultiple
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>The text of the query to be run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterQuery
{
    [JsonPropertyName("multiple")]
    public V1beta1SQLQueryStatusAtProviderParameterQueryMultiple? Multiple { get; set; }

    /// <summary>the unique ID of the SQL Query.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameterText
{
    /// <summary>The default value for this parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderParameter
{
    [JsonPropertyName("date")]
    public V1beta1SQLQueryStatusAtProviderParameterDate? Date { get; set; }

    [JsonPropertyName("dateRange")]
    public V1beta1SQLQueryStatusAtProviderParameterDateRange? DateRange { get; set; }

    [JsonPropertyName("datetime")]
    public V1beta1SQLQueryStatusAtProviderParameterDatetime? Datetime { get; set; }

    [JsonPropertyName("datetimeRange")]
    public V1beta1SQLQueryStatusAtProviderParameterDatetimeRange? DatetimeRange { get; set; }

    [JsonPropertyName("datetimesec")]
    public V1beta1SQLQueryStatusAtProviderParameterDatetimesec? Datetimesec { get; set; }

    [JsonPropertyName("datetimesecRange")]
    public V1beta1SQLQueryStatusAtProviderParameterDatetimesecRange? DatetimesecRange { get; set; }

    [JsonPropertyName("enum")]
    public V1beta1SQLQueryStatusAtProviderParameterEnum? Enum { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("number")]
    public V1beta1SQLQueryStatusAtProviderParameterNumber? Number { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public V1beta1SQLQueryStatusAtProviderParameterQuery? Query { get; set; }

    [JsonPropertyName("text")]
    public V1beta1SQLQueryStatusAtProviderParameterText? Text { get; set; }

    /// <summary>The text displayed in a parameter picking widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderScheduleContinuous
{
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderScheduleDaily
{
    [JsonPropertyName("intervalDays")]
    public double? IntervalDays { get; set; }

    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderScheduleWeekly
{
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    [JsonPropertyName("intervalWeeks")]
    public double? IntervalWeeks { get; set; }

    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    [JsonPropertyName("untilDate")]
    public string? UntilDate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProviderSchedule
{
    [JsonPropertyName("continuous")]
    public V1beta1SQLQueryStatusAtProviderScheduleContinuous? Continuous { get; set; }

    [JsonPropertyName("daily")]
    public V1beta1SQLQueryStatusAtProviderScheduleDaily? Daily { get; set; }

    [JsonPropertyName("weekly")]
    public V1beta1SQLQueryStatusAtProviderScheduleWeekly? Weekly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusAtProvider
{
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Data source ID of a SQL warehouse</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>the unique ID of the SQL Query.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The title of this query that appears in list views, widget headings, and on the query page.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("parameter")]
    public IList<V1beta1SQLQueryStatusAtProviderParameter>? Parameter { get; set; }

    /// <summary>The identifier of the workspace folder containing the object.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1SQLQueryStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The text of the query to be run.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Run as role. Possible values are viewer, owner.</summary>
    [JsonPropertyName("runAsRole")]
    public string? RunAsRole { get; set; }

    [JsonPropertyName("schedule")]
    public V1beta1SQLQueryStatusAtProviderSchedule? Schedule { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatusConditions
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

/// <summary>SQLQueryStatus defines the observed state of SQLQuery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLQueryStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1SQLQueryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SQLQueryStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SQLQuery is the Schema for the SQLQuerys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLQuery : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SQLQuerySpec>, IStatus<V1beta1SQLQueryStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLQuery";
    public const string KubeGroup = "sql.databricks.m.crossplane.io";
    public const string KubePluralName = "sqlqueries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SQLQuery";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLQuerySpec defines the desired state of SQLQuery</summary>
    [JsonPropertyName("spec")]
    public required V1beta1SQLQuerySpec Spec { get; set; }

    /// <summary>SQLQueryStatus defines the observed state of SQLQuery.</summary>
    [JsonPropertyName("status")]
    public V1beta1SQLQueryStatus? Status { get; set; }
}