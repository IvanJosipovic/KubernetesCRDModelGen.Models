#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.gcp.upbound.io;
/// <summary>SLO is the Schema for the SLOs API. A Service-Level Objective (SLO) describes the level of desired good service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SLOList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SLO>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SLOList";
    public const string KubeGroup = "monitoring.gcp.upbound.io";
    public const string KubePluralName = "sloes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "monitoring.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SLOList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SLO objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SLO> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecDeletionPolicyEnum>))]
public enum V1beta2SLOSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Availability based SLI, dervied from count of requests made to this service that return successfully.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderBasicSliAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Parameters for a latency threshold SLI.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderBasicSliLatency
{
    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>
/// Basic Service-Level Indicator (SLI) on a well-known service type.
/// Performance will be computed on the basis of pre-defined metrics.
/// SLIs are used to measure and calculate the quality of the Service&apos;s
/// performance with respect to a single aspect of service quality.
/// Exactly one of the following must be set:
/// basic_sli, request_based_sli, windows_based_sli
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderBasicSli
{
    /// <summary>
    /// Availability based SLI, dervied from count of requests made to this service that return successfully.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("availability")]
    public V1beta2SLOSpecForProviderBasicSliAvailability? Availability { get; set; }

    /// <summary>
    /// Parameters for a latency threshold SLI.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("latency")]
    public V1beta2SLOSpecForProviderBasicSliLatency? Latency { get; set; }

    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&apos;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&apos;s methods. For service types that don&apos;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&apos;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderRequestBasedSliDistributionCutRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Used when good_service is defined by a count of values aggregated in a
/// Distribution that fall into a good range. The total_service is the
/// total count of all values aggregated in the Distribution.
/// Defines a distribution TimeSeries filter and thresholds used for
/// measuring good service and total service.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderRequestBasedSliDistributionCut
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// aggregating values to quantify the good service provided.
    /// Must have ValueType = DISTRIBUTION and
    /// MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOSpecForProviderRequestBasedSliDistributionCutRange? Range { get; set; }
}

/// <summary>
/// A means to compute a ratio of good_service to total_service.
/// Defines computing this ratio with two TimeSeries monitoring filters
/// Must specify exactly two of good, bad, and total service filters.
/// The relationship good_service + bad_service = total_service
/// will be assumed.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderRequestBasedSliGoodTotalRatio
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying bad service provided, either demanded service that
    /// was not provided or demanded service that was of inadequate
    /// quality.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying good service provided.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying total demanded service.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

/// <summary>
/// A request-based SLI defines a SLI for which atomic units of
/// service are counted directly.
/// A SLI describes a good service.
/// It is used to measure and calculate the quality of the Service&apos;s
/// performance with respect to a single aspect of service quality.
/// Exactly one of the following must be set:
/// basic_sli, request_based_sli, windows_based_sli
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderRequestBasedSli
{
    /// <summary>
    /// Used when good_service is defined by a count of values aggregated in a
    /// Distribution that fall into a good range. The total_service is the
    /// total count of all values aggregated in the Distribution.
    /// Defines a distribution TimeSeries filter and thresholds used for
    /// measuring good service and total service.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("distributionCut")]
    public V1beta2SLOSpecForProviderRequestBasedSliDistributionCut? DistributionCut { get; set; }

    /// <summary>
    /// A means to compute a ratio of good_service to total_service.
    /// Defines computing this ratio with two TimeSeries monitoring filters
    /// Must specify exactly two of good, bad, and total service filters.
    /// The relationship good_service + bad_service = total_service
    /// will be assumed.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goodTotalRatio")]
    public V1beta2SLOSpecForProviderRequestBasedSliGoodTotalRatio? GoodTotalRatio { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecForProviderServiceRefPolicyResolutionEnum>))]
public enum V1beta2SLOSpecForProviderServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecForProviderServiceRefPolicyResolveEnum>))]
public enum V1beta2SLOSpecForProviderServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SLOSpecForProviderServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SLOSpecForProviderServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CustomService in monitoring to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SLOSpecForProviderServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecForProviderServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2SLOSpecForProviderServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecForProviderServiceSelectorPolicyResolveEnum>))]
public enum V1beta2SLOSpecForProviderServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SLOSpecForProviderServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SLOSpecForProviderServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CustomService in monitoring to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderServiceSelector
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
    public V1beta2SLOSpecForProviderServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Availability based SLI, dervied from count of requests made to this service that return successfully.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Parameters for a latency threshold SLI.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency
{
    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>
/// Basic SLI to evaluate to judge window quality.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance
{
    /// <summary>
    /// Availability based SLI, dervied from count of requests made to this service that return successfully.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("availability")]
    public V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability? Availability { get; set; }

    /// <summary>
    /// Parameters for a latency threshold SLI.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("latency")]
    public V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency? Latency { get; set; }

    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&apos;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&apos;s methods. For service types that don&apos;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&apos;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Used when good_service is defined by a count of values aggregated in a
/// Distribution that fall into a good range. The total_service is the
/// total count of all values aggregated in the Distribution.
/// Defines a distribution TimeSeries filter and thresholds used for
/// measuring good service and total service.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// aggregating values to quantify the good service provided.
    /// Must have ValueType = DISTRIBUTION and
    /// MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange? Range { get; set; }
}

/// <summary>
/// A means to compute a ratio of good_service to total_service.
/// Defines computing this ratio with two TimeSeries monitoring filters
/// Must specify exactly two of good, bad, and total service filters.
/// The relationship good_service + bad_service = total_service
/// will be assumed.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying bad service provided, either demanded service that
    /// was not provided or demanded service that was of inadequate
    /// quality.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying good service provided.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying total demanded service.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

/// <summary>
/// Request-based SLI to evaluate to judge window quality.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformance
{
    /// <summary>
    /// Used when good_service is defined by a count of values aggregated in a
    /// Distribution that fall into a good range. The total_service is the
    /// total count of all values aggregated in the Distribution.
    /// Defines a distribution TimeSeries filter and thresholds used for
    /// measuring good service and total service.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("distributionCut")]
    public V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut? DistributionCut { get; set; }

    /// <summary>
    /// A means to compute a ratio of good_service to total_service.
    /// Defines computing this ratio with two TimeSeries monitoring filters
    /// Must specify exactly two of good, bad, and total service filters.
    /// The relationship good_service + bad_service = total_service
    /// will be assumed.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goodTotalRatio")]
    public V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio? GoodTotalRatio { get; set; }
}

/// <summary>
/// Criterion that describes a window as good if its performance is
/// high enough. One of good_bad_metric_filter,
/// good_total_ratio_threshold, metric_mean_in_range,
/// metric_sum_in_range must be set for windows_based_sli.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThreshold
{
    /// <summary>
    /// Basic SLI to evaluate to judge window quality.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicSliPerformance")]
    public V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance? BasicSliPerformance { get; set; }

    /// <summary>
    /// Request-based SLI to evaluate to judge window quality.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("performance")]
    public V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformance? Performance { get; set; }

    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliMetricMeanInRangeRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Criterion that describes a window as good if the metric&apos;s value
/// is in a good range, averaged across returned streams.
/// One of good_bad_metric_filter,
/// good_total_ratio_threshold, metric_mean_in_range,
/// metric_sum_in_range must be set for windows_based_sli.
/// Average value X of time_series should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliMetricMeanInRange
{
    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOSpecForProviderWindowsBasedSliMetricMeanInRangeRange? Range { get; set; }

    /// <summary>
    /// A monitoring filter
    /// specifying the TimeSeries to use for evaluating window
    /// quality. The provided TimeSeries must have
    /// ValueType = INT64 or ValueType = DOUBLE and
    /// MetricKind = GAUGE.
    /// Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// </summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliMetricSumInRangeRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Criterion that describes a window as good if the metric&apos;s value
/// is in a good range, summed across returned streams.
/// Summed value X of time_series should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// One of good_bad_metric_filter,
/// good_total_ratio_threshold, metric_mean_in_range,
/// metric_sum_in_range must be set for windows_based_sli.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSliMetricSumInRange
{
    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOSpecForProviderWindowsBasedSliMetricSumInRangeRange? Range { get; set; }

    /// <summary>
    /// A monitoring filter
    /// specifying the TimeSeries to use for evaluating window
    /// quality. The provided TimeSeries must have
    /// ValueType = INT64 or ValueType = DOUBLE and
    /// MetricKind = GAUGE.
    /// Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// </summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

/// <summary>
/// A windows-based SLI defines the criteria for time windows.
/// good_service is defined based off the count of these time windows
/// for which the provided service was of good quality.
/// A SLI describes a good service. It is used to measure and calculate
/// the quality of the Service&apos;s performance with respect to a single
/// aspect of service quality.
/// Exactly one of the following must be set:
/// basic_sli, request_based_sli, windows_based_sli
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProviderWindowsBasedSli
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// with ValueType = BOOL. The window is good if any true values
    /// appear in the window. One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// </summary>
    [JsonPropertyName("goodBadMetricFilter")]
    public string? GoodBadMetricFilter { get; set; }

    /// <summary>
    /// Criterion that describes a window as good if its performance is
    /// high enough. One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goodTotalRatioThreshold")]
    public V1beta2SLOSpecForProviderWindowsBasedSliGoodTotalRatioThreshold? GoodTotalRatioThreshold { get; set; }

    /// <summary>
    /// Criterion that describes a window as good if the metric&apos;s value
    /// is in a good range, averaged across returned streams.
    /// One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// Average value X of time_series should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metricMeanInRange")]
    public V1beta2SLOSpecForProviderWindowsBasedSliMetricMeanInRange? MetricMeanInRange { get; set; }

    /// <summary>
    /// Criterion that describes a window as good if the metric&apos;s value
    /// is in a good range, summed across returned streams.
    /// Summed value X of time_series should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metricSumInRange")]
    public V1beta2SLOSpecForProviderWindowsBasedSliMetricSumInRange? MetricSumInRange { get; set; }

    /// <summary>
    /// Duration over which window quality is evaluated, given as a
    /// duration string &quot;{X}s&quot; representing X seconds. Must be an
    /// integer fraction of a day and at least 60s.
    /// </summary>
    [JsonPropertyName("windowPeriod")]
    public string? WindowPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecForProvider
{
    /// <summary>
    /// Basic Service-Level Indicator (SLI) on a well-known service type.
    /// Performance will be computed on the basis of pre-defined metrics.
    /// SLIs are used to measure and calculate the quality of the Service&apos;s
    /// performance with respect to a single aspect of service quality.
    /// Exactly one of the following must be set:
    /// basic_sli, request_based_sli, windows_based_sli
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicSli")]
    public V1beta2SLOSpecForProviderBasicSli? BasicSli { get; set; }

    /// <summary>
    /// A calendar period, semantically &quot;since the start of the current
    /// &quot;.
    /// Possible values are: DAY, WEEK, FORTNIGHT, MONTH.
    /// </summary>
    [JsonPropertyName("calendarPeriod")]
    public string? CalendarPeriod { get; set; }

    /// <summary>Name used for UI elements listing this SLO.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The fraction of service that must be good in order for this objective
    /// to be met. 0 &lt; goal &lt;= 0.999
    /// </summary>
    [JsonPropertyName("goal")]
    public double? Goal { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// A request-based SLI defines a SLI for which atomic units of
    /// service are counted directly.
    /// A SLI describes a good service.
    /// It is used to measure and calculate the quality of the Service&apos;s
    /// performance with respect to a single aspect of service quality.
    /// Exactly one of the following must be set:
    /// basic_sli, request_based_sli, windows_based_sli
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestBasedSli")]
    public V1beta2SLOSpecForProviderRequestBasedSli? RequestBasedSli { get; set; }

    /// <summary>
    /// A rolling time period, semantically &quot;in the past X days&quot;.
    /// Must be between 1 to 30 days, inclusive.
    /// </summary>
    [JsonPropertyName("rollingPeriodDays")]
    public double? RollingPeriodDays { get; set; }

    /// <summary>ID of the service to which this SLO belongs.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a CustomService in monitoring to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2SLOSpecForProviderServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a CustomService in monitoring to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2SLOSpecForProviderServiceSelector? ServiceSelector { get; set; }

    /// <summary>The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.</summary>
    [JsonPropertyName("sloId")]
    public string? SloId { get; set; }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }

    /// <summary>
    /// A windows-based SLI defines the criteria for time windows.
    /// good_service is defined based off the count of these time windows
    /// for which the provided service was of good quality.
    /// A SLI describes a good service. It is used to measure and calculate
    /// the quality of the Service&apos;s performance with respect to a single
    /// aspect of service quality.
    /// Exactly one of the following must be set:
    /// basic_sli, request_based_sli, windows_based_sli
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsBasedSli")]
    public V1beta2SLOSpecForProviderWindowsBasedSli? WindowsBasedSli { get; set; }
}

/// <summary>
/// Availability based SLI, dervied from count of requests made to this service that return successfully.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderBasicSliAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Parameters for a latency threshold SLI.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderBasicSliLatency
{
    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>
/// Basic Service-Level Indicator (SLI) on a well-known service type.
/// Performance will be computed on the basis of pre-defined metrics.
/// SLIs are used to measure and calculate the quality of the Service&apos;s
/// performance with respect to a single aspect of service quality.
/// Exactly one of the following must be set:
/// basic_sli, request_based_sli, windows_based_sli
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderBasicSli
{
    /// <summary>
    /// Availability based SLI, dervied from count of requests made to this service that return successfully.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("availability")]
    public V1beta2SLOSpecInitProviderBasicSliAvailability? Availability { get; set; }

    /// <summary>
    /// Parameters for a latency threshold SLI.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("latency")]
    public V1beta2SLOSpecInitProviderBasicSliLatency? Latency { get; set; }

    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&apos;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&apos;s methods. For service types that don&apos;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&apos;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderRequestBasedSliDistributionCutRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Used when good_service is defined by a count of values aggregated in a
/// Distribution that fall into a good range. The total_service is the
/// total count of all values aggregated in the Distribution.
/// Defines a distribution TimeSeries filter and thresholds used for
/// measuring good service and total service.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderRequestBasedSliDistributionCut
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// aggregating values to quantify the good service provided.
    /// Must have ValueType = DISTRIBUTION and
    /// MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOSpecInitProviderRequestBasedSliDistributionCutRange? Range { get; set; }
}

/// <summary>
/// A means to compute a ratio of good_service to total_service.
/// Defines computing this ratio with two TimeSeries monitoring filters
/// Must specify exactly two of good, bad, and total service filters.
/// The relationship good_service + bad_service = total_service
/// will be assumed.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderRequestBasedSliGoodTotalRatio
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying bad service provided, either demanded service that
    /// was not provided or demanded service that was of inadequate
    /// quality.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying good service provided.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying total demanded service.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

/// <summary>
/// A request-based SLI defines a SLI for which atomic units of
/// service are counted directly.
/// A SLI describes a good service.
/// It is used to measure and calculate the quality of the Service&apos;s
/// performance with respect to a single aspect of service quality.
/// Exactly one of the following must be set:
/// basic_sli, request_based_sli, windows_based_sli
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderRequestBasedSli
{
    /// <summary>
    /// Used when good_service is defined by a count of values aggregated in a
    /// Distribution that fall into a good range. The total_service is the
    /// total count of all values aggregated in the Distribution.
    /// Defines a distribution TimeSeries filter and thresholds used for
    /// measuring good service and total service.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("distributionCut")]
    public V1beta2SLOSpecInitProviderRequestBasedSliDistributionCut? DistributionCut { get; set; }

    /// <summary>
    /// A means to compute a ratio of good_service to total_service.
    /// Defines computing this ratio with two TimeSeries monitoring filters
    /// Must specify exactly two of good, bad, and total service filters.
    /// The relationship good_service + bad_service = total_service
    /// will be assumed.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goodTotalRatio")]
    public V1beta2SLOSpecInitProviderRequestBasedSliGoodTotalRatio? GoodTotalRatio { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecInitProviderServiceRefPolicyResolutionEnum>))]
public enum V1beta2SLOSpecInitProviderServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecInitProviderServiceRefPolicyResolveEnum>))]
public enum V1beta2SLOSpecInitProviderServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SLOSpecInitProviderServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SLOSpecInitProviderServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CustomService in monitoring to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SLOSpecInitProviderServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecInitProviderServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2SLOSpecInitProviderServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecInitProviderServiceSelectorPolicyResolveEnum>))]
public enum V1beta2SLOSpecInitProviderServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SLOSpecInitProviderServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SLOSpecInitProviderServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CustomService in monitoring to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderServiceSelector
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
    public V1beta2SLOSpecInitProviderServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Availability based SLI, dervied from count of requests made to this service that return successfully.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Parameters for a latency threshold SLI.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency
{
    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>
/// Basic SLI to evaluate to judge window quality.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance
{
    /// <summary>
    /// Availability based SLI, dervied from count of requests made to this service that return successfully.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("availability")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability? Availability { get; set; }

    /// <summary>
    /// Parameters for a latency threshold SLI.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("latency")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency? Latency { get; set; }

    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&apos;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&apos;s methods. For service types that don&apos;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&apos;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Used when good_service is defined by a count of values aggregated in a
/// Distribution that fall into a good range. The total_service is the
/// total count of all values aggregated in the Distribution.
/// Defines a distribution TimeSeries filter and thresholds used for
/// measuring good service and total service.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// aggregating values to quantify the good service provided.
    /// Must have ValueType = DISTRIBUTION and
    /// MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange? Range { get; set; }
}

/// <summary>
/// A means to compute a ratio of good_service to total_service.
/// Defines computing this ratio with two TimeSeries monitoring filters
/// Must specify exactly two of good, bad, and total service filters.
/// The relationship good_service + bad_service = total_service
/// will be assumed.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying bad service provided, either demanded service that
    /// was not provided or demanded service that was of inadequate
    /// quality.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying good service provided.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying total demanded service.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

/// <summary>
/// Request-based SLI to evaluate to judge window quality.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformance
{
    /// <summary>
    /// Used when good_service is defined by a count of values aggregated in a
    /// Distribution that fall into a good range. The total_service is the
    /// total count of all values aggregated in the Distribution.
    /// Defines a distribution TimeSeries filter and thresholds used for
    /// measuring good service and total service.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("distributionCut")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut? DistributionCut { get; set; }

    /// <summary>
    /// A means to compute a ratio of good_service to total_service.
    /// Defines computing this ratio with two TimeSeries monitoring filters
    /// Must specify exactly two of good, bad, and total service filters.
    /// The relationship good_service + bad_service = total_service
    /// will be assumed.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goodTotalRatio")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio? GoodTotalRatio { get; set; }
}

/// <summary>
/// Criterion that describes a window as good if its performance is
/// high enough. One of good_bad_metric_filter,
/// good_total_ratio_threshold, metric_mean_in_range,
/// metric_sum_in_range must be set for windows_based_sli.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThreshold
{
    /// <summary>
    /// Basic SLI to evaluate to judge window quality.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicSliPerformance")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance? BasicSliPerformance { get; set; }

    /// <summary>
    /// Request-based SLI to evaluate to judge window quality.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("performance")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformance? Performance { get; set; }

    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliMetricMeanInRangeRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Criterion that describes a window as good if the metric&apos;s value
/// is in a good range, averaged across returned streams.
/// One of good_bad_metric_filter,
/// good_total_ratio_threshold, metric_mean_in_range,
/// metric_sum_in_range must be set for windows_based_sli.
/// Average value X of time_series should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliMetricMeanInRange
{
    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliMetricMeanInRangeRange? Range { get; set; }

    /// <summary>
    /// A monitoring filter
    /// specifying the TimeSeries to use for evaluating window
    /// quality. The provided TimeSeries must have
    /// ValueType = INT64 or ValueType = DOUBLE and
    /// MetricKind = GAUGE.
    /// Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// </summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliMetricSumInRangeRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Criterion that describes a window as good if the metric&apos;s value
/// is in a good range, summed across returned streams.
/// Summed value X of time_series should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// One of good_bad_metric_filter,
/// good_total_ratio_threshold, metric_mean_in_range,
/// metric_sum_in_range must be set for windows_based_sli.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSliMetricSumInRange
{
    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliMetricSumInRangeRange? Range { get; set; }

    /// <summary>
    /// A monitoring filter
    /// specifying the TimeSeries to use for evaluating window
    /// quality. The provided TimeSeries must have
    /// ValueType = INT64 or ValueType = DOUBLE and
    /// MetricKind = GAUGE.
    /// Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// </summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

/// <summary>
/// A windows-based SLI defines the criteria for time windows.
/// good_service is defined based off the count of these time windows
/// for which the provided service was of good quality.
/// A SLI describes a good service. It is used to measure and calculate
/// the quality of the Service&apos;s performance with respect to a single
/// aspect of service quality.
/// Exactly one of the following must be set:
/// basic_sli, request_based_sli, windows_based_sli
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecInitProviderWindowsBasedSli
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// with ValueType = BOOL. The window is good if any true values
    /// appear in the window. One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// </summary>
    [JsonPropertyName("goodBadMetricFilter")]
    public string? GoodBadMetricFilter { get; set; }

    /// <summary>
    /// Criterion that describes a window as good if its performance is
    /// high enough. One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goodTotalRatioThreshold")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThreshold? GoodTotalRatioThreshold { get; set; }

    /// <summary>
    /// Criterion that describes a window as good if the metric&apos;s value
    /// is in a good range, averaged across returned streams.
    /// One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// Average value X of time_series should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metricMeanInRange")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliMetricMeanInRange? MetricMeanInRange { get; set; }

    /// <summary>
    /// Criterion that describes a window as good if the metric&apos;s value
    /// is in a good range, summed across returned streams.
    /// Summed value X of time_series should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metricSumInRange")]
    public V1beta2SLOSpecInitProviderWindowsBasedSliMetricSumInRange? MetricSumInRange { get; set; }

    /// <summary>
    /// Duration over which window quality is evaluated, given as a
    /// duration string &quot;{X}s&quot; representing X seconds. Must be an
    /// integer fraction of a day and at least 60s.
    /// </summary>
    [JsonPropertyName("windowPeriod")]
    public string? WindowPeriod { get; set; }
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
public partial class V1beta2SLOSpecInitProvider
{
    /// <summary>
    /// Basic Service-Level Indicator (SLI) on a well-known service type.
    /// Performance will be computed on the basis of pre-defined metrics.
    /// SLIs are used to measure and calculate the quality of the Service&apos;s
    /// performance with respect to a single aspect of service quality.
    /// Exactly one of the following must be set:
    /// basic_sli, request_based_sli, windows_based_sli
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicSli")]
    public V1beta2SLOSpecInitProviderBasicSli? BasicSli { get; set; }

    /// <summary>
    /// A calendar period, semantically &quot;since the start of the current
    /// &quot;.
    /// Possible values are: DAY, WEEK, FORTNIGHT, MONTH.
    /// </summary>
    [JsonPropertyName("calendarPeriod")]
    public string? CalendarPeriod { get; set; }

    /// <summary>Name used for UI elements listing this SLO.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The fraction of service that must be good in order for this objective
    /// to be met. 0 &lt; goal &lt;= 0.999
    /// </summary>
    [JsonPropertyName("goal")]
    public double? Goal { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// A request-based SLI defines a SLI for which atomic units of
    /// service are counted directly.
    /// A SLI describes a good service.
    /// It is used to measure and calculate the quality of the Service&apos;s
    /// performance with respect to a single aspect of service quality.
    /// Exactly one of the following must be set:
    /// basic_sli, request_based_sli, windows_based_sli
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestBasedSli")]
    public V1beta2SLOSpecInitProviderRequestBasedSli? RequestBasedSli { get; set; }

    /// <summary>
    /// A rolling time period, semantically &quot;in the past X days&quot;.
    /// Must be between 1 to 30 days, inclusive.
    /// </summary>
    [JsonPropertyName("rollingPeriodDays")]
    public double? RollingPeriodDays { get; set; }

    /// <summary>ID of the service to which this SLO belongs.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a CustomService in monitoring to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2SLOSpecInitProviderServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a CustomService in monitoring to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2SLOSpecInitProviderServiceSelector? ServiceSelector { get; set; }

    /// <summary>The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.</summary>
    [JsonPropertyName("sloId")]
    public string? SloId { get; set; }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }

    /// <summary>
    /// A windows-based SLI defines the criteria for time windows.
    /// good_service is defined based off the count of these time windows
    /// for which the provided service was of good quality.
    /// A SLI describes a good service. It is used to measure and calculate
    /// the quality of the Service&apos;s performance with respect to a single
    /// aspect of service quality.
    /// Exactly one of the following must be set:
    /// basic_sli, request_based_sli, windows_based_sli
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsBasedSli")]
    public V1beta2SLOSpecInitProviderWindowsBasedSli? WindowsBasedSli { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecManagementPoliciesEnum>))]
public enum V1beta2SLOSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SLOSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SLOSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SLOSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SLOSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SLOSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SLOSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SLOSpec defines the desired state of SLO</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOSpec
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
    public V1beta2SLOSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SLOSpecForProvider ForProvider { get; set; }

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
    public V1beta2SLOSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SLOSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SLOSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SLOSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Availability based SLI, dervied from count of requests made to this service that return successfully.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderBasicSliAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Parameters for a latency threshold SLI.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderBasicSliLatency
{
    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>
/// Basic Service-Level Indicator (SLI) on a well-known service type.
/// Performance will be computed on the basis of pre-defined metrics.
/// SLIs are used to measure and calculate the quality of the Service&apos;s
/// performance with respect to a single aspect of service quality.
/// Exactly one of the following must be set:
/// basic_sli, request_based_sli, windows_based_sli
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderBasicSli
{
    /// <summary>
    /// Availability based SLI, dervied from count of requests made to this service that return successfully.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("availability")]
    public V1beta2SLOStatusAtProviderBasicSliAvailability? Availability { get; set; }

    /// <summary>
    /// Parameters for a latency threshold SLI.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("latency")]
    public V1beta2SLOStatusAtProviderBasicSliLatency? Latency { get; set; }

    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&apos;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&apos;s methods. For service types that don&apos;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&apos;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderRequestBasedSliDistributionCutRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Used when good_service is defined by a count of values aggregated in a
/// Distribution that fall into a good range. The total_service is the
/// total count of all values aggregated in the Distribution.
/// Defines a distribution TimeSeries filter and thresholds used for
/// measuring good service and total service.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderRequestBasedSliDistributionCut
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// aggregating values to quantify the good service provided.
    /// Must have ValueType = DISTRIBUTION and
    /// MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOStatusAtProviderRequestBasedSliDistributionCutRange? Range { get; set; }
}

/// <summary>
/// A means to compute a ratio of good_service to total_service.
/// Defines computing this ratio with two TimeSeries monitoring filters
/// Must specify exactly two of good, bad, and total service filters.
/// The relationship good_service + bad_service = total_service
/// will be assumed.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderRequestBasedSliGoodTotalRatio
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying bad service provided, either demanded service that
    /// was not provided or demanded service that was of inadequate
    /// quality.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying good service provided.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying total demanded service.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

/// <summary>
/// A request-based SLI defines a SLI for which atomic units of
/// service are counted directly.
/// A SLI describes a good service.
/// It is used to measure and calculate the quality of the Service&apos;s
/// performance with respect to a single aspect of service quality.
/// Exactly one of the following must be set:
/// basic_sli, request_based_sli, windows_based_sli
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderRequestBasedSli
{
    /// <summary>
    /// Used when good_service is defined by a count of values aggregated in a
    /// Distribution that fall into a good range. The total_service is the
    /// total count of all values aggregated in the Distribution.
    /// Defines a distribution TimeSeries filter and thresholds used for
    /// measuring good service and total service.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("distributionCut")]
    public V1beta2SLOStatusAtProviderRequestBasedSliDistributionCut? DistributionCut { get; set; }

    /// <summary>
    /// A means to compute a ratio of good_service to total_service.
    /// Defines computing this ratio with two TimeSeries monitoring filters
    /// Must specify exactly two of good, bad, and total service filters.
    /// The relationship good_service + bad_service = total_service
    /// will be assumed.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goodTotalRatio")]
    public V1beta2SLOStatusAtProviderRequestBasedSliGoodTotalRatio? GoodTotalRatio { get; set; }
}

/// <summary>
/// Availability based SLI, dervied from count of requests made to this service that return successfully.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Parameters for a latency threshold SLI.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency
{
    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>
/// Basic SLI to evaluate to judge window quality.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance
{
    /// <summary>
    /// Availability based SLI, dervied from count of requests made to this service that return successfully.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("availability")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability? Availability { get; set; }

    /// <summary>
    /// Parameters for a latency threshold SLI.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("latency")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency? Latency { get; set; }

    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&apos;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&apos;s methods. For service types that don&apos;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&apos;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Used when good_service is defined by a count of values aggregated in a
/// Distribution that fall into a good range. The total_service is the
/// total count of all values aggregated in the Distribution.
/// Defines a distribution TimeSeries filter and thresholds used for
/// measuring good service and total service.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// aggregating values to quantify the good service provided.
    /// Must have ValueType = DISTRIBUTION and
    /// MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange? Range { get; set; }
}

/// <summary>
/// A means to compute a ratio of good_service to total_service.
/// Defines computing this ratio with two TimeSeries monitoring filters
/// Must specify exactly two of good, bad, and total service filters.
/// The relationship good_service + bad_service = total_service
/// will be assumed.
/// Exactly one of distribution_cut or good_total_ratio can be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying bad service provided, either demanded service that
    /// was not provided or demanded service that was of inadequate
    /// quality.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying good service provided.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>
    /// A TimeSeries monitoring filter
    /// quantifying total demanded service.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// Exactly two of good_service_filter,bad_service_filter,total_service_filter
    /// must be set (good + bad = total is assumed).
    /// </summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

/// <summary>
/// Request-based SLI to evaluate to judge window quality.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformance
{
    /// <summary>
    /// Used when good_service is defined by a count of values aggregated in a
    /// Distribution that fall into a good range. The total_service is the
    /// total count of all values aggregated in the Distribution.
    /// Defines a distribution TimeSeries filter and thresholds used for
    /// measuring good service and total service.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("distributionCut")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut? DistributionCut { get; set; }

    /// <summary>
    /// A means to compute a ratio of good_service to total_service.
    /// Defines computing this ratio with two TimeSeries monitoring filters
    /// Must specify exactly two of good, bad, and total service filters.
    /// The relationship good_service + bad_service = total_service
    /// will be assumed.
    /// Exactly one of distribution_cut or good_total_ratio can be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goodTotalRatio")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio? GoodTotalRatio { get; set; }
}

/// <summary>
/// Criterion that describes a window as good if its performance is
/// high enough. One of good_bad_metric_filter,
/// good_total_ratio_threshold, metric_mean_in_range,
/// metric_sum_in_range must be set for windows_based_sli.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThreshold
{
    /// <summary>
    /// Basic SLI to evaluate to judge window quality.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicSliPerformance")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance? BasicSliPerformance { get; set; }

    /// <summary>
    /// Request-based SLI to evaluate to judge window quality.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("performance")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformance? Performance { get; set; }

    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliMetricMeanInRangeRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Criterion that describes a window as good if the metric&apos;s value
/// is in a good range, averaged across returned streams.
/// One of good_bad_metric_filter,
/// good_total_ratio_threshold, metric_mean_in_range,
/// metric_sum_in_range must be set for windows_based_sli.
/// Average value X of time_series should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliMetricMeanInRange
{
    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliMetricMeanInRangeRange? Range { get; set; }

    /// <summary>
    /// A monitoring filter
    /// specifying the TimeSeries to use for evaluating window
    /// quality. The provided TimeSeries must have
    /// ValueType = INT64 or ValueType = DOUBLE and
    /// MetricKind = GAUGE.
    /// Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// </summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

/// <summary>
/// Range of numerical values. The computed good_service
/// will be the count of values x in the Distribution such
/// that range.min &lt;= x &lt;= range.max. inclusive of min and
/// max. Open ranges can be defined by setting
/// just one of min or max. Summed value X should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliMetricSumInRangeRange
{
    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// Criterion that describes a window as good if the metric&apos;s value
/// is in a good range, summed across returned streams.
/// Summed value X of time_series should satisfy
/// range.min &lt;= X &lt;= range.max for a good window.
/// One of good_bad_metric_filter,
/// good_total_ratio_threshold, metric_mean_in_range,
/// metric_sum_in_range must be set for windows_based_sli.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSliMetricSumInRange
{
    /// <summary>
    /// Range of numerical values. The computed good_service
    /// will be the count of values x in the Distribution such
    /// that range.min &lt;= x &lt;= range.max. inclusive of min and
    /// max. Open ranges can be defined by setting
    /// just one of min or max. Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("range")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliMetricSumInRangeRange? Range { get; set; }

    /// <summary>
    /// A monitoring filter
    /// specifying the TimeSeries to use for evaluating window
    /// quality. The provided TimeSeries must have
    /// ValueType = INT64 or ValueType = DOUBLE and
    /// MetricKind = GAUGE.
    /// Summed value X should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// </summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

/// <summary>
/// A windows-based SLI defines the criteria for time windows.
/// good_service is defined based off the count of these time windows
/// for which the provided service was of good quality.
/// A SLI describes a good service. It is used to measure and calculate
/// the quality of the Service&apos;s performance with respect to a single
/// aspect of service quality.
/// Exactly one of the following must be set:
/// basic_sli, request_based_sli, windows_based_sli
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProviderWindowsBasedSli
{
    /// <summary>
    /// A TimeSeries monitoring filter
    /// with ValueType = BOOL. The window is good if any true values
    /// appear in the window. One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// </summary>
    [JsonPropertyName("goodBadMetricFilter")]
    public string? GoodBadMetricFilter { get; set; }

    /// <summary>
    /// Criterion that describes a window as good if its performance is
    /// high enough. One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("goodTotalRatioThreshold")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThreshold? GoodTotalRatioThreshold { get; set; }

    /// <summary>
    /// Criterion that describes a window as good if the metric&apos;s value
    /// is in a good range, averaged across returned streams.
    /// One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// Average value X of time_series should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metricMeanInRange")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliMetricMeanInRange? MetricMeanInRange { get; set; }

    /// <summary>
    /// Criterion that describes a window as good if the metric&apos;s value
    /// is in a good range, summed across returned streams.
    /// Summed value X of time_series should satisfy
    /// range.min &lt;= X &lt;= range.max for a good window.
    /// One of good_bad_metric_filter,
    /// good_total_ratio_threshold, metric_mean_in_range,
    /// metric_sum_in_range must be set for windows_based_sli.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metricSumInRange")]
    public V1beta2SLOStatusAtProviderWindowsBasedSliMetricSumInRange? MetricSumInRange { get; set; }

    /// <summary>
    /// Duration over which window quality is evaluated, given as a
    /// duration string &quot;{X}s&quot; representing X seconds. Must be an
    /// integer fraction of a day and at least 60s.
    /// </summary>
    [JsonPropertyName("windowPeriod")]
    public string? WindowPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusAtProvider
{
    /// <summary>
    /// Basic Service-Level Indicator (SLI) on a well-known service type.
    /// Performance will be computed on the basis of pre-defined metrics.
    /// SLIs are used to measure and calculate the quality of the Service&apos;s
    /// performance with respect to a single aspect of service quality.
    /// Exactly one of the following must be set:
    /// basic_sli, request_based_sli, windows_based_sli
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicSli")]
    public V1beta2SLOStatusAtProviderBasicSli? BasicSli { get; set; }

    /// <summary>
    /// A calendar period, semantically &quot;since the start of the current
    /// &quot;.
    /// Possible values are: DAY, WEEK, FORTNIGHT, MONTH.
    /// </summary>
    [JsonPropertyName("calendarPeriod")]
    public string? CalendarPeriod { get; set; }

    /// <summary>Name used for UI elements listing this SLO.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The fraction of service that must be good in order for this objective
    /// to be met. 0 &lt; goal &lt;= 0.999
    /// </summary>
    [JsonPropertyName("goal")]
    public double? Goal { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// A request-based SLI defines a SLI for which atomic units of
    /// service are counted directly.
    /// A SLI describes a good service.
    /// It is used to measure and calculate the quality of the Service&apos;s
    /// performance with respect to a single aspect of service quality.
    /// Exactly one of the following must be set:
    /// basic_sli, request_based_sli, windows_based_sli
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestBasedSli")]
    public V1beta2SLOStatusAtProviderRequestBasedSli? RequestBasedSli { get; set; }

    /// <summary>
    /// A rolling time period, semantically &quot;in the past X days&quot;.
    /// Must be between 1 to 30 days, inclusive.
    /// </summary>
    [JsonPropertyName("rollingPeriodDays")]
    public double? RollingPeriodDays { get; set; }

    /// <summary>ID of the service to which this SLO belongs.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.</summary>
    [JsonPropertyName("sloId")]
    public string? SloId { get; set; }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }

    /// <summary>
    /// A windows-based SLI defines the criteria for time windows.
    /// good_service is defined based off the count of these time windows
    /// for which the provided service was of good quality.
    /// A SLI describes a good service. It is used to measure and calculate
    /// the quality of the Service&apos;s performance with respect to a single
    /// aspect of service quality.
    /// Exactly one of the following must be set:
    /// basic_sli, request_based_sli, windows_based_sli
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("windowsBasedSli")]
    public V1beta2SLOStatusAtProviderWindowsBasedSli? WindowsBasedSli { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatusConditions
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

/// <summary>SLOStatus defines the observed state of SLO.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SLOStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SLOStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SLOStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SLO is the Schema for the SLOs API. A Service-Level Objective (SLO) describes the level of desired good service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SLO : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SLOSpec>, IStatus<V1beta2SLOStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SLO";
    public const string KubeGroup = "monitoring.gcp.upbound.io";
    public const string KubePluralName = "sloes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "monitoring.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SLO";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SLOSpec defines the desired state of SLO</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SLOSpec Spec { get; set; }

    /// <summary>SLOStatus defines the observed state of SLO.</summary>
    [JsonPropertyName("status")]
    public V1beta2SLOStatus? Status { get; set; }
}