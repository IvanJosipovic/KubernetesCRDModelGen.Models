#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.gcp.upbound.io;
/// <summary>Metric is the Schema for the Metrics API. Logs-based metric can also be used to extract values from logs and create a a distribution of the values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MetricList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Metric>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MetricList";
    public const string KubeGroup = "logging.gcp.upbound.io";
    public const string KubePluralName = "metrics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "logging.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Metric objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Metric> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecDeletionPolicyEnum>))]
public enum V1beta2MetricSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecForProviderBucketNameRefPolicyResolutionEnum>))]
public enum V1beta2MetricSpecForProviderBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecForProviderBucketNameRefPolicyResolveEnum>))]
public enum V1beta2MetricSpecForProviderBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetricSpecForProviderBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetricSpecForProviderBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ProjectBucketConfig in logging to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MetricSpecForProviderBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecForProviderBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MetricSpecForProviderBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecForProviderBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2MetricSpecForProviderBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetricSpecForProviderBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetricSpecForProviderBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ProjectBucketConfig in logging to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderBucketNameSelector
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
    public V1beta2MetricSpecForProviderBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies a set of buckets with arbitrary widths.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderBucketOptionsExplicitBuckets
{
    /// <summary>The values must be monotonically increasing.</summary>
    [JsonPropertyName("bounds")]
    public IList<double>? Bounds { get; set; }
}

/// <summary>
/// Specifies an exponential sequence of buckets that have a width that is proportional to the value of
/// the lower bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderBucketOptionsExponentialBuckets
{
    /// <summary>Must be greater than 1.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

/// <summary>
/// Specifies a linear sequence of buckets that all have the same width (except overflow and underflow).
/// Each bucket represents a constant absolute uncertainty on the specific value in the bucket.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderBucketOptionsLinearBuckets
{
    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Lower bound of the first bucket.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>
/// The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it
/// describes the bucket boundaries used to create a histogram of the extracted values.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderBucketOptions
{
    /// <summary>
    /// Specifies a set of buckets with arbitrary widths.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("explicitBuckets")]
    public V1beta2MetricSpecForProviderBucketOptionsExplicitBuckets? ExplicitBuckets { get; set; }

    /// <summary>
    /// Specifies an exponential sequence of buckets that have a width that is proportional to the value of
    /// the lower bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exponentialBuckets")]
    public V1beta2MetricSpecForProviderBucketOptionsExponentialBuckets? ExponentialBuckets { get; set; }

    /// <summary>
    /// Specifies a linear sequence of buckets that all have the same width (except overflow and underflow).
    /// Each bucket represents a constant absolute uncertainty on the specific value in the bucket.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("linearBuckets")]
    public V1beta2MetricSpecForProviderBucketOptionsLinearBuckets? LinearBuckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderMetricDescriptorLabels
{
    /// <summary>A human-readable description for the label.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The label key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64.
    /// Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.
    /// </summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>
/// The optional metric descriptor associated with the logs-based metric.
/// If unspecified, it uses a default metric descriptor with a DELTA metric kind,
/// INT64 value type, with no labels and a unit of &quot;1&quot;. Such a metric counts the
/// number of log entries matching the filter expression.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProviderMetricDescriptor
{
    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case
    /// without an ending period, for example &quot;Request count&quot;. This field is optional but it is
    /// recommended to be set for any metrics associated with user-visible concepts, such as Quota.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The set of labels that can be used to describe a specific instance of this metric type. For
    /// example, the appengine.googleapis.com/http/server/response_latencies metric type has a label
    /// for the HTTP response code, response_code, so you can look at latencies for successful responses
    /// or just for responses that failed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("labels")]
    public IList<V1beta2MetricSpecForProviderMetricDescriptorLabels>? Labels { get; set; }

    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to DELTA.
    /// Possible values are: DELTA, GAUGE, CUMULATIVE.
    /// </summary>
    [JsonPropertyName("metricKind")]
    public string? MetricKind { get; set; }

    /// <summary>
    /// The unit in which the metric value is reported. It is only applicable if the valueType is
    /// INT64, DOUBLE, or DISTRIBUTION. The supported units are a subset of
    /// The Unified Code for Units of Measure standard
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64.
    /// Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.
    /// </summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecForProvider
{
    /// <summary>
    /// The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects
    /// are supported. The bucket has to be in the same project as the metric.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a ProjectBucketConfig in logging to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2MetricSpecForProviderBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a ProjectBucketConfig in logging to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2MetricSpecForProviderBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>
    /// The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it
    /// describes the bucket boundaries used to create a histogram of the extracted values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketOptions")]
    public V1beta2MetricSpecForProviderBucketOptions? BucketOptions { get; set; }

    /// <summary>
    /// A description of this metric, which is used in documentation. The maximum length of the
    /// description is 8000 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this metric is disabled and it does not generate any points.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which
    /// is used to match log entries.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// A map from a label key string to an extractor expression which is used to extract data from a log
    /// entry field and assign as the label value. Each label key specified in the LabelDescriptor must
    /// have an associated extractor expression in this map. The syntax of the extractor expression is
    /// the same as for the valueExtractor field.
    /// </summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }

    /// <summary>
    /// The optional metric descriptor associated with the logs-based metric.
    /// If unspecified, it uses a default metric descriptor with a DELTA metric kind,
    /// INT64 value type, with no labels and a unit of &quot;1&quot;. Such a metric counts the
    /// number of log entries matching the filter expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metricDescriptor")]
    public V1beta2MetricSpecForProviderMetricDescriptor? MetricDescriptor { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// A valueExtractor is required when using a distribution logs-based metric to extract the values to
    /// record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or
    /// REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which
    /// the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax
    /// (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified
    /// log entry field. The value of the field is converted to a string before applying the regex. It is an
    /// error to specify a regex that does not include exactly one capture group.
    /// </summary>
    [JsonPropertyName("valueExtractor")]
    public string? ValueExtractor { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecInitProviderBucketNameRefPolicyResolutionEnum>))]
public enum V1beta2MetricSpecInitProviderBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecInitProviderBucketNameRefPolicyResolveEnum>))]
public enum V1beta2MetricSpecInitProviderBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetricSpecInitProviderBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetricSpecInitProviderBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ProjectBucketConfig in logging to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MetricSpecInitProviderBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecInitProviderBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MetricSpecInitProviderBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecInitProviderBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2MetricSpecInitProviderBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetricSpecInitProviderBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetricSpecInitProviderBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ProjectBucketConfig in logging to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderBucketNameSelector
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
    public V1beta2MetricSpecInitProviderBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies a set of buckets with arbitrary widths.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderBucketOptionsExplicitBuckets
{
    /// <summary>The values must be monotonically increasing.</summary>
    [JsonPropertyName("bounds")]
    public IList<double>? Bounds { get; set; }
}

/// <summary>
/// Specifies an exponential sequence of buckets that have a width that is proportional to the value of
/// the lower bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderBucketOptionsExponentialBuckets
{
    /// <summary>Must be greater than 1.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

/// <summary>
/// Specifies a linear sequence of buckets that all have the same width (except overflow and underflow).
/// Each bucket represents a constant absolute uncertainty on the specific value in the bucket.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderBucketOptionsLinearBuckets
{
    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Lower bound of the first bucket.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>
/// The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it
/// describes the bucket boundaries used to create a histogram of the extracted values.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderBucketOptions
{
    /// <summary>
    /// Specifies a set of buckets with arbitrary widths.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("explicitBuckets")]
    public V1beta2MetricSpecInitProviderBucketOptionsExplicitBuckets? ExplicitBuckets { get; set; }

    /// <summary>
    /// Specifies an exponential sequence of buckets that have a width that is proportional to the value of
    /// the lower bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exponentialBuckets")]
    public V1beta2MetricSpecInitProviderBucketOptionsExponentialBuckets? ExponentialBuckets { get; set; }

    /// <summary>
    /// Specifies a linear sequence of buckets that all have the same width (except overflow and underflow).
    /// Each bucket represents a constant absolute uncertainty on the specific value in the bucket.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("linearBuckets")]
    public V1beta2MetricSpecInitProviderBucketOptionsLinearBuckets? LinearBuckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderMetricDescriptorLabels
{
    /// <summary>A human-readable description for the label.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The label key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64.
    /// Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.
    /// </summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>
/// The optional metric descriptor associated with the logs-based metric.
/// If unspecified, it uses a default metric descriptor with a DELTA metric kind,
/// INT64 value type, with no labels and a unit of &quot;1&quot;. Such a metric counts the
/// number of log entries matching the filter expression.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecInitProviderMetricDescriptor
{
    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case
    /// without an ending period, for example &quot;Request count&quot;. This field is optional but it is
    /// recommended to be set for any metrics associated with user-visible concepts, such as Quota.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The set of labels that can be used to describe a specific instance of this metric type. For
    /// example, the appengine.googleapis.com/http/server/response_latencies metric type has a label
    /// for the HTTP response code, response_code, so you can look at latencies for successful responses
    /// or just for responses that failed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("labels")]
    public IList<V1beta2MetricSpecInitProviderMetricDescriptorLabels>? Labels { get; set; }

    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to DELTA.
    /// Possible values are: DELTA, GAUGE, CUMULATIVE.
    /// </summary>
    [JsonPropertyName("metricKind")]
    public string? MetricKind { get; set; }

    /// <summary>
    /// The unit in which the metric value is reported. It is only applicable if the valueType is
    /// INT64, DOUBLE, or DISTRIBUTION. The supported units are a subset of
    /// The Unified Code for Units of Measure standard
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64.
    /// Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.
    /// </summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
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
public partial class V1beta2MetricSpecInitProvider
{
    /// <summary>
    /// The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects
    /// are supported. The bucket has to be in the same project as the metric.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a ProjectBucketConfig in logging to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2MetricSpecInitProviderBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a ProjectBucketConfig in logging to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2MetricSpecInitProviderBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>
    /// The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it
    /// describes the bucket boundaries used to create a histogram of the extracted values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketOptions")]
    public V1beta2MetricSpecInitProviderBucketOptions? BucketOptions { get; set; }

    /// <summary>
    /// A description of this metric, which is used in documentation. The maximum length of the
    /// description is 8000 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this metric is disabled and it does not generate any points.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which
    /// is used to match log entries.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// A map from a label key string to an extractor expression which is used to extract data from a log
    /// entry field and assign as the label value. Each label key specified in the LabelDescriptor must
    /// have an associated extractor expression in this map. The syntax of the extractor expression is
    /// the same as for the valueExtractor field.
    /// </summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }

    /// <summary>
    /// The optional metric descriptor associated with the logs-based metric.
    /// If unspecified, it uses a default metric descriptor with a DELTA metric kind,
    /// INT64 value type, with no labels and a unit of &quot;1&quot;. Such a metric counts the
    /// number of log entries matching the filter expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metricDescriptor")]
    public V1beta2MetricSpecInitProviderMetricDescriptor? MetricDescriptor { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// A valueExtractor is required when using a distribution logs-based metric to extract the values to
    /// record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or
    /// REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which
    /// the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax
    /// (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified
    /// log entry field. The value of the field is converted to a string before applying the regex. It is an
    /// error to specify a regex that does not include exactly one capture group.
    /// </summary>
    [JsonPropertyName("valueExtractor")]
    public string? ValueExtractor { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecManagementPoliciesEnum>))]
public enum V1beta2MetricSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2MetricSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MetricSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2MetricSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MetricSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MetricSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MetricSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MetricSpec defines the desired state of Metric</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricSpec
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
    public V1beta2MetricSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2MetricSpecForProvider ForProvider { get; set; }

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
    public V1beta2MetricSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2MetricSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2MetricSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2MetricSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Specifies a set of buckets with arbitrary widths.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricStatusAtProviderBucketOptionsExplicitBuckets
{
    /// <summary>The values must be monotonically increasing.</summary>
    [JsonPropertyName("bounds")]
    public IList<double>? Bounds { get; set; }
}

/// <summary>
/// Specifies an exponential sequence of buckets that have a width that is proportional to the value of
/// the lower bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricStatusAtProviderBucketOptionsExponentialBuckets
{
    /// <summary>Must be greater than 1.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

/// <summary>
/// Specifies a linear sequence of buckets that all have the same width (except overflow and underflow).
/// Each bucket represents a constant absolute uncertainty on the specific value in the bucket.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricStatusAtProviderBucketOptionsLinearBuckets
{
    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Lower bound of the first bucket.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>
/// The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it
/// describes the bucket boundaries used to create a histogram of the extracted values.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricStatusAtProviderBucketOptions
{
    /// <summary>
    /// Specifies a set of buckets with arbitrary widths.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("explicitBuckets")]
    public V1beta2MetricStatusAtProviderBucketOptionsExplicitBuckets? ExplicitBuckets { get; set; }

    /// <summary>
    /// Specifies an exponential sequence of buckets that have a width that is proportional to the value of
    /// the lower bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exponentialBuckets")]
    public V1beta2MetricStatusAtProviderBucketOptionsExponentialBuckets? ExponentialBuckets { get; set; }

    /// <summary>
    /// Specifies a linear sequence of buckets that all have the same width (except overflow and underflow).
    /// Each bucket represents a constant absolute uncertainty on the specific value in the bucket.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("linearBuckets")]
    public V1beta2MetricStatusAtProviderBucketOptionsLinearBuckets? LinearBuckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricStatusAtProviderMetricDescriptorLabels
{
    /// <summary>A human-readable description for the label.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The label key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64.
    /// Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.
    /// </summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>
/// The optional metric descriptor associated with the logs-based metric.
/// If unspecified, it uses a default metric descriptor with a DELTA metric kind,
/// INT64 value type, with no labels and a unit of &quot;1&quot;. Such a metric counts the
/// number of log entries matching the filter expression.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricStatusAtProviderMetricDescriptor
{
    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case
    /// without an ending period, for example &quot;Request count&quot;. This field is optional but it is
    /// recommended to be set for any metrics associated with user-visible concepts, such as Quota.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The set of labels that can be used to describe a specific instance of this metric type. For
    /// example, the appengine.googleapis.com/http/server/response_latencies metric type has a label
    /// for the HTTP response code, response_code, so you can look at latencies for successful responses
    /// or just for responses that failed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("labels")]
    public IList<V1beta2MetricStatusAtProviderMetricDescriptorLabels>? Labels { get; set; }

    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to DELTA.
    /// Possible values are: DELTA, GAUGE, CUMULATIVE.
    /// </summary>
    [JsonPropertyName("metricKind")]
    public string? MetricKind { get; set; }

    /// <summary>
    /// The unit in which the metric value is reported. It is only applicable if the valueType is
    /// INT64, DOUBLE, or DISTRIBUTION. The supported units are a subset of
    /// The Unified Code for Units of Measure standard
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64.
    /// Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.
    /// </summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricStatusAtProvider
{
    /// <summary>
    /// The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects
    /// are supported. The bucket has to be in the same project as the metric.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>
    /// The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it
    /// describes the bucket boundaries used to create a histogram of the extracted values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketOptions")]
    public V1beta2MetricStatusAtProviderBucketOptions? BucketOptions { get; set; }

    /// <summary>
    /// A description of this metric, which is used in documentation. The maximum length of the
    /// description is 8000 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this metric is disabled and it does not generate any points.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which
    /// is used to match log entries.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A map from a label key string to an extractor expression which is used to extract data from a log
    /// entry field and assign as the label value. Each label key specified in the LabelDescriptor must
    /// have an associated extractor expression in this map. The syntax of the extractor expression is
    /// the same as for the valueExtractor field.
    /// </summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }

    /// <summary>
    /// The optional metric descriptor associated with the logs-based metric.
    /// If unspecified, it uses a default metric descriptor with a DELTA metric kind,
    /// INT64 value type, with no labels and a unit of &quot;1&quot;. Such a metric counts the
    /// number of log entries matching the filter expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metricDescriptor")]
    public V1beta2MetricStatusAtProviderMetricDescriptor? MetricDescriptor { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// A valueExtractor is required when using a distribution logs-based metric to extract the values to
    /// record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or
    /// REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which
    /// the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax
    /// (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified
    /// log entry field. The value of the field is converted to a string before applying the regex. It is an
    /// error to specify a regex that does not include exactly one capture group.
    /// </summary>
    [JsonPropertyName("valueExtractor")]
    public string? ValueExtractor { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricStatusConditions
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

/// <summary>MetricStatus defines the observed state of Metric.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MetricStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2MetricStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2MetricStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Metric is the Schema for the Metrics API. Logs-based metric can also be used to extract values from logs and create a a distribution of the values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Metric : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2MetricSpec>, IStatus<V1beta2MetricStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Metric";
    public const string KubeGroup = "logging.gcp.upbound.io";
    public const string KubePluralName = "metrics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "logging.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Metric";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetricSpec defines the desired state of Metric</summary>
    [JsonPropertyName("spec")]
    public required V1beta2MetricSpec Spec { get; set; }

    /// <summary>MetricStatus defines the observed state of Metric.</summary>
    [JsonPropertyName("status")]
    public V1beta2MetricStatus? Status { get; set; }
}