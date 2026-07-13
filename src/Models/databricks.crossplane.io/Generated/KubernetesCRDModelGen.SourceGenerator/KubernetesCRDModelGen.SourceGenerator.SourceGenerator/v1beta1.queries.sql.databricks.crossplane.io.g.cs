#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.databricks.crossplane.io;
/// <summary>Query is the Schema for the Querys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1QueryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Query>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "QueryList";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "queries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "QueryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Query objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Query> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecDeletionPolicyEnum>))]
public enum V1beta1QuerySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameterDateRangeValueDateRangeValue
{
    /// <summary>end of the date range.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>begin of the date range.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameterDateRangeValue
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public V1beta1QuerySpecForProviderParameterDateRangeValueDateRangeValue? DateRangeValue { get; set; }

    /// <summary>(String) Dynamic date-time range value based on current date-time.  Possible values are TODAY, YESTERDAY, THIS_WEEK, THIS_MONTH, THIS_YEAR, LAST_WEEK, LAST_MONTH, LAST_YEAR, LAST_HOUR, LAST_8_HOURS, LAST_24_HOURS, LAST_7_DAYS, LAST_14_DAYS, LAST_30_DAYS, LAST_60_DAYS, LAST_90_DAYS, LAST_12_MONTHS.</summary>
    [JsonPropertyName("dynamicDateRangeValue")]
    public string? DynamicDateRangeValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }

    /// <summary>Specify what day that starts the week.</summary>
    [JsonPropertyName("startDayOfWeek")]
    public double? StartDayOfWeek { get; set; }
}

/// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameterDateValue
{
    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>(String) Dynamic date-time value based on current date-time.  Possible values are NOW, YESTERDAY.</summary>
    [JsonPropertyName("dynamicDateValue")]
    public string? DynamicDateValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }
}

/// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameterEnumValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>(Block) Dropdown parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameterEnumValue
{
    /// <summary>(String) List of valid query parameter values, newline delimited.</summary>
    [JsonPropertyName("enumOptions")]
    public string? EnumOptions { get; set; }

    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public V1beta1QuerySpecForProviderParameterEnumValueMultiValuesOptions? MultiValuesOptions { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>(Block) Numeric parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameterNumericValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameterQueryBackedValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>(Block) Query-based dropdown parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameterQueryBackedValue
{
    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public V1beta1QuerySpecForProviderParameterQueryBackedValueMultiValuesOptions? MultiValuesOptions { get; set; }

    /// <summary>ID of the query that provides the parameter values.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>(Block) Text parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameterTextValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParameter
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public V1beta1QuerySpecForProviderParameterDateRangeValue? DateRangeValue { get; set; }

    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1QuerySpecForProviderParameterDateValue? DateValue { get; set; }

    /// <summary>(Block) Dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("enumValue")]
    public V1beta1QuerySpecForProviderParameterEnumValue? EnumValue { get; set; }

    /// <summary>Literal parameter marker that appears between double curly braces in the query text.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Block) Numeric parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("numericValue")]
    public V1beta1QuerySpecForProviderParameterNumericValue? NumericValue { get; set; }

    /// <summary>(Block) Query-based dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("queryBackedValue")]
    public V1beta1QuerySpecForProviderParameterQueryBackedValue? QueryBackedValue { get; set; }

    /// <summary>(Block) Text parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("textValue")]
    public V1beta1QuerySpecForProviderParameterTextValue? TextValue { get; set; }

    /// <summary>Text displayed in the user-facing parameter widget in the UI.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecForProviderParentPathRefPolicyResolutionEnum>))]
public enum V1beta1QuerySpecForProviderParentPathRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecForProviderParentPathRefPolicyResolveEnum>))]
public enum V1beta1QuerySpecForProviderParentPathRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParentPathRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuerySpecForProviderParentPathRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuerySpecForProviderParentPathRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Directory in workspace to populate parentPath.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParentPathRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QuerySpecForProviderParentPathRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecForProviderParentPathSelectorPolicyResolutionEnum>))]
public enum V1beta1QuerySpecForProviderParentPathSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecForProviderParentPathSelectorPolicyResolveEnum>))]
public enum V1beta1QuerySpecForProviderParentPathSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParentPathSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuerySpecForProviderParentPathSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuerySpecForProviderParentPathSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Directory in workspace to populate parentPath.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderParentPathSelector
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
    public V1beta1QuerySpecForProviderParentPathSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecForProviderWarehouseIdRefPolicyResolutionEnum>))]
public enum V1beta1QuerySpecForProviderWarehouseIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecForProviderWarehouseIdRefPolicyResolveEnum>))]
public enum V1beta1QuerySpecForProviderWarehouseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderWarehouseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuerySpecForProviderWarehouseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuerySpecForProviderWarehouseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SQLEndpoint in sql to populate warehouseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderWarehouseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QuerySpecForProviderWarehouseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecForProviderWarehouseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1QuerySpecForProviderWarehouseIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecForProviderWarehouseIdSelectorPolicyResolveEnum>))]
public enum V1beta1QuerySpecForProviderWarehouseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderWarehouseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuerySpecForProviderWarehouseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuerySpecForProviderWarehouseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SQLEndpoint in sql to populate warehouseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProviderWarehouseIdSelector
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
    public V1beta1QuerySpecForProviderWarehouseIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecForProvider
{
    /// <summary>Whether to apply a 1000 row limit to the query result.</summary>
    [JsonPropertyName("applyAutoLimit")]
    public bool? ApplyAutoLimit { get; set; }

    /// <summary>Name of the catalog where this query will be executed.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the query.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Query owner&apos;s username.</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>Query parameter definition.  Consists of following attributes (one of *_value is required):</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1QuerySpecForProviderParameter>? Parameter { get; set; }

    /// <summary>The path to a workspace folder containing the query. The default is the user&apos;s home folder.  If changed, the query will be recreated.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>Reference to a Directory in workspace to populate parentPath.</summary>
    [JsonPropertyName("parentPathRef")]
    public V1beta1QuerySpecForProviderParentPathRef? ParentPathRef { get; set; }

    /// <summary>Selector for a Directory in workspace to populate parentPath.</summary>
    [JsonPropertyName("parentPathSelector")]
    public V1beta1QuerySpecForProviderParentPathSelector? ParentPathSelector { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1QuerySpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Text of SQL query.</summary>
    [JsonPropertyName("queryText")]
    public string? QueryText { get; set; }

    /// <summary>Sets the &quot;Run as&quot; role for the object.  Should be one of OWNER, VIEWER.</summary>
    [JsonPropertyName("runAsMode")]
    public string? RunAsMode { get; set; }

    /// <summary>Name of the schema where this query will be executed.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Tags that will be added to the query.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>ID of a SQL warehouse which will be used to execute this query.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    /// <summary>Reference to a SQLEndpoint in sql to populate warehouseId.</summary>
    [JsonPropertyName("warehouseIdRef")]
    public V1beta1QuerySpecForProviderWarehouseIdRef? WarehouseIdRef { get; set; }

    /// <summary>Selector for a SQLEndpoint in sql to populate warehouseId.</summary>
    [JsonPropertyName("warehouseIdSelector")]
    public V1beta1QuerySpecForProviderWarehouseIdSelector? WarehouseIdSelector { get; set; }
}

/// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameterDateRangeValueDateRangeValue
{
    /// <summary>end of the date range.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>begin of the date range.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameterDateRangeValue
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public V1beta1QuerySpecInitProviderParameterDateRangeValueDateRangeValue? DateRangeValue { get; set; }

    /// <summary>(String) Dynamic date-time range value based on current date-time.  Possible values are TODAY, YESTERDAY, THIS_WEEK, THIS_MONTH, THIS_YEAR, LAST_WEEK, LAST_MONTH, LAST_YEAR, LAST_HOUR, LAST_8_HOURS, LAST_24_HOURS, LAST_7_DAYS, LAST_14_DAYS, LAST_30_DAYS, LAST_60_DAYS, LAST_90_DAYS, LAST_12_MONTHS.</summary>
    [JsonPropertyName("dynamicDateRangeValue")]
    public string? DynamicDateRangeValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }

    /// <summary>Specify what day that starts the week.</summary>
    [JsonPropertyName("startDayOfWeek")]
    public double? StartDayOfWeek { get; set; }
}

/// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameterDateValue
{
    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>(String) Dynamic date-time value based on current date-time.  Possible values are NOW, YESTERDAY.</summary>
    [JsonPropertyName("dynamicDateValue")]
    public string? DynamicDateValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }
}

/// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameterEnumValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>(Block) Dropdown parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameterEnumValue
{
    /// <summary>(String) List of valid query parameter values, newline delimited.</summary>
    [JsonPropertyName("enumOptions")]
    public string? EnumOptions { get; set; }

    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public V1beta1QuerySpecInitProviderParameterEnumValueMultiValuesOptions? MultiValuesOptions { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>(Block) Numeric parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameterNumericValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameterQueryBackedValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>(Block) Query-based dropdown parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameterQueryBackedValue
{
    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public V1beta1QuerySpecInitProviderParameterQueryBackedValueMultiValuesOptions? MultiValuesOptions { get; set; }

    /// <summary>ID of the query that provides the parameter values.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>(Block) Text parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameterTextValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParameter
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public V1beta1QuerySpecInitProviderParameterDateRangeValue? DateRangeValue { get; set; }

    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1QuerySpecInitProviderParameterDateValue? DateValue { get; set; }

    /// <summary>(Block) Dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("enumValue")]
    public V1beta1QuerySpecInitProviderParameterEnumValue? EnumValue { get; set; }

    /// <summary>Literal parameter marker that appears between double curly braces in the query text.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Block) Numeric parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("numericValue")]
    public V1beta1QuerySpecInitProviderParameterNumericValue? NumericValue { get; set; }

    /// <summary>(Block) Query-based dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("queryBackedValue")]
    public V1beta1QuerySpecInitProviderParameterQueryBackedValue? QueryBackedValue { get; set; }

    /// <summary>(Block) Text parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("textValue")]
    public V1beta1QuerySpecInitProviderParameterTextValue? TextValue { get; set; }

    /// <summary>Text displayed in the user-facing parameter widget in the UI.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecInitProviderParentPathRefPolicyResolutionEnum>))]
public enum V1beta1QuerySpecInitProviderParentPathRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecInitProviderParentPathRefPolicyResolveEnum>))]
public enum V1beta1QuerySpecInitProviderParentPathRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParentPathRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuerySpecInitProviderParentPathRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuerySpecInitProviderParentPathRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Directory in workspace to populate parentPath.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParentPathRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QuerySpecInitProviderParentPathRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecInitProviderParentPathSelectorPolicyResolutionEnum>))]
public enum V1beta1QuerySpecInitProviderParentPathSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecInitProviderParentPathSelectorPolicyResolveEnum>))]
public enum V1beta1QuerySpecInitProviderParentPathSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParentPathSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuerySpecInitProviderParentPathSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuerySpecInitProviderParentPathSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Directory in workspace to populate parentPath.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderParentPathSelector
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
    public V1beta1QuerySpecInitProviderParentPathSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecInitProviderWarehouseIdRefPolicyResolutionEnum>))]
public enum V1beta1QuerySpecInitProviderWarehouseIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecInitProviderWarehouseIdRefPolicyResolveEnum>))]
public enum V1beta1QuerySpecInitProviderWarehouseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderWarehouseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuerySpecInitProviderWarehouseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuerySpecInitProviderWarehouseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SQLEndpoint in sql to populate warehouseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderWarehouseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QuerySpecInitProviderWarehouseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecInitProviderWarehouseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1QuerySpecInitProviderWarehouseIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecInitProviderWarehouseIdSelectorPolicyResolveEnum>))]
public enum V1beta1QuerySpecInitProviderWarehouseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderWarehouseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuerySpecInitProviderWarehouseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuerySpecInitProviderWarehouseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SQLEndpoint in sql to populate warehouseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecInitProviderWarehouseIdSelector
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
    public V1beta1QuerySpecInitProviderWarehouseIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1QuerySpecInitProvider
{
    /// <summary>Whether to apply a 1000 row limit to the query result.</summary>
    [JsonPropertyName("applyAutoLimit")]
    public bool? ApplyAutoLimit { get; set; }

    /// <summary>Name of the catalog where this query will be executed.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the query.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Query owner&apos;s username.</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>Query parameter definition.  Consists of following attributes (one of *_value is required):</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1QuerySpecInitProviderParameter>? Parameter { get; set; }

    /// <summary>The path to a workspace folder containing the query. The default is the user&apos;s home folder.  If changed, the query will be recreated.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>Reference to a Directory in workspace to populate parentPath.</summary>
    [JsonPropertyName("parentPathRef")]
    public V1beta1QuerySpecInitProviderParentPathRef? ParentPathRef { get; set; }

    /// <summary>Selector for a Directory in workspace to populate parentPath.</summary>
    [JsonPropertyName("parentPathSelector")]
    public V1beta1QuerySpecInitProviderParentPathSelector? ParentPathSelector { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1QuerySpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Text of SQL query.</summary>
    [JsonPropertyName("queryText")]
    public string? QueryText { get; set; }

    /// <summary>Sets the &quot;Run as&quot; role for the object.  Should be one of OWNER, VIEWER.</summary>
    [JsonPropertyName("runAsMode")]
    public string? RunAsMode { get; set; }

    /// <summary>Name of the schema where this query will be executed.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Tags that will be added to the query.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>ID of a SQL warehouse which will be used to execute this query.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    /// <summary>Reference to a SQLEndpoint in sql to populate warehouseId.</summary>
    [JsonPropertyName("warehouseIdRef")]
    public V1beta1QuerySpecInitProviderWarehouseIdRef? WarehouseIdRef { get; set; }

    /// <summary>Selector for a SQLEndpoint in sql to populate warehouseId.</summary>
    [JsonPropertyName("warehouseIdSelector")]
    public V1beta1QuerySpecInitProviderWarehouseIdSelector? WarehouseIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecManagementPoliciesEnum>))]
public enum V1beta1QuerySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1QuerySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuerySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1QuerySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuerySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuerySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QuerySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>QuerySpec defines the desired state of Query</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuerySpec
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
    public V1beta1QuerySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1QuerySpecForProvider ForProvider { get; set; }

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
    public V1beta1QuerySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1QuerySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1QuerySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1QuerySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameterDateRangeValueDateRangeValue
{
    /// <summary>end of the date range.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>begin of the date range.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameterDateRangeValue
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public V1beta1QueryStatusAtProviderParameterDateRangeValueDateRangeValue? DateRangeValue { get; set; }

    /// <summary>(String) Dynamic date-time range value based on current date-time.  Possible values are TODAY, YESTERDAY, THIS_WEEK, THIS_MONTH, THIS_YEAR, LAST_WEEK, LAST_MONTH, LAST_YEAR, LAST_HOUR, LAST_8_HOURS, LAST_24_HOURS, LAST_7_DAYS, LAST_14_DAYS, LAST_30_DAYS, LAST_60_DAYS, LAST_90_DAYS, LAST_12_MONTHS.</summary>
    [JsonPropertyName("dynamicDateRangeValue")]
    public string? DynamicDateRangeValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }

    /// <summary>Specify what day that starts the week.</summary>
    [JsonPropertyName("startDayOfWeek")]
    public double? StartDayOfWeek { get; set; }
}

/// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameterDateValue
{
    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public string? DateValue { get; set; }

    /// <summary>(String) Dynamic date-time value based on current date-time.  Possible values are NOW, YESTERDAY.</summary>
    [JsonPropertyName("dynamicDateValue")]
    public string? DynamicDateValue { get; set; }

    /// <summary>Date-time precision to format the value into when the query is run.  Possible values are DAY_PRECISION, MINUTE_PRECISION, SECOND_PRECISION.  Defaults to DAY_PRECISION (YYYY-MM-DD).</summary>
    [JsonPropertyName("precision")]
    public string? Precision { get; set; }
}

/// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameterEnumValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>(Block) Dropdown parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameterEnumValue
{
    /// <summary>(String) List of valid query parameter values, newline delimited.</summary>
    [JsonPropertyName("enumOptions")]
    public string? EnumOptions { get; set; }

    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public V1beta1QueryStatusAtProviderParameterEnumValueMultiValuesOptions? MultiValuesOptions { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>(Block) Numeric parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameterNumericValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameterQueryBackedValueMultiValuesOptions
{
    /// <summary>Character that prefixes each selected parameter value.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Character that separates each selected parameter value. Defaults to a comma.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>Character that suffixes each selected parameter value.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>(Block) Query-based dropdown parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameterQueryBackedValue
{
    /// <summary>If specified, allows multiple values to be selected for this parameter. Consists of following attributes:</summary>
    [JsonPropertyName("multiValuesOptions")]
    public V1beta1QueryStatusAtProviderParameterQueryBackedValueMultiValuesOptions? MultiValuesOptions { get; set; }

    /// <summary>ID of the query that provides the parameter values.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>(Array of strings) List of selected query parameter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>(Block) Text parameter value. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameterTextValue
{
    /// <summary>- actual text value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderParameter
{
    /// <summary>(Block) Date-range query parameter value. Consists of following attributes (Can only specify one of dynamic_date_range_value or date_range_value):</summary>
    [JsonPropertyName("dateRangeValue")]
    public V1beta1QueryStatusAtProviderParameterDateRangeValue? DateRangeValue { get; set; }

    /// <summary>(Block) Date query parameter value. Consists of following attributes (Can only specify one of dynamic_date_value or date_value):</summary>
    [JsonPropertyName("dateValue")]
    public V1beta1QueryStatusAtProviderParameterDateValue? DateValue { get; set; }

    /// <summary>(Block) Dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("enumValue")]
    public V1beta1QueryStatusAtProviderParameterEnumValue? EnumValue { get; set; }

    /// <summary>Literal parameter marker that appears between double curly braces in the query text.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Block) Numeric parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("numericValue")]
    public V1beta1QueryStatusAtProviderParameterNumericValue? NumericValue { get; set; }

    /// <summary>(Block) Query-based dropdown parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("queryBackedValue")]
    public V1beta1QueryStatusAtProviderParameterQueryBackedValue? QueryBackedValue { get; set; }

    /// <summary>(Block) Text parameter value. Consists of following attributes:</summary>
    [JsonPropertyName("textValue")]
    public V1beta1QueryStatusAtProviderParameterTextValue? TextValue { get; set; }

    /// <summary>Text displayed in the user-facing parameter widget in the UI.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusAtProvider
{
    /// <summary>Whether to apply a 1000 row limit to the query result.</summary>
    [JsonPropertyName("applyAutoLimit")]
    public bool? ApplyAutoLimit { get; set; }

    /// <summary>Name of the catalog where this query will be executed.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>The timestamp string indicating when the query was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>General description that conveys additional information about this query such as usage notes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the query.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>unique ID of the created Query.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Username of the user who last saved changes to this query.</summary>
    [JsonPropertyName("lastModifierUserName")]
    public string? LastModifierUserName { get; set; }

    /// <summary>The workspace state of the query. Used for tracking trashed status. (Possible values are ACTIVE or TRASHED).</summary>
    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }

    /// <summary>Query owner&apos;s username.</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>Query parameter definition.  Consists of following attributes (one of *_value is required):</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1QueryStatusAtProviderParameter>? Parameter { get; set; }

    /// <summary>The path to a workspace folder containing the query. The default is the user&apos;s home folder.  If changed, the query will be recreated.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1QueryStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Text of SQL query.</summary>
    [JsonPropertyName("queryText")]
    public string? QueryText { get; set; }

    /// <summary>Sets the &quot;Run as&quot; role for the object.  Should be one of OWNER, VIEWER.</summary>
    [JsonPropertyName("runAsMode")]
    public string? RunAsMode { get; set; }

    /// <summary>Name of the schema where this query will be executed.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Tags that will be added to the query.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The timestamp string indicating when the query was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>ID of a SQL warehouse which will be used to execute this query.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatusConditions
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

/// <summary>QueryStatus defines the observed state of Query.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueryStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1QueryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1QueryStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Query is the Schema for the Querys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Query : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1QuerySpec>, IStatus<V1beta1QueryStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Query";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "queries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Query";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>QuerySpec defines the desired state of Query</summary>
    [JsonPropertyName("spec")]
    public required V1beta1QuerySpec Spec { get; set; }

    /// <summary>QueryStatus defines the observed state of Query.</summary>
    [JsonPropertyName("status")]
    public V1beta1QueryStatus? Status { get; set; }
}