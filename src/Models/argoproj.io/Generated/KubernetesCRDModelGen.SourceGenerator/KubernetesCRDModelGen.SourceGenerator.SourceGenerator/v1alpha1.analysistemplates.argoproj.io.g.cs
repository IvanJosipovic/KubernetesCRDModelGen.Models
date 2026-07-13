#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.argoproj.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AnalysisTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AnalysisTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AnalysisTemplateList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "analysistemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AnalysisTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AnalysisTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AnalysisTemplate> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecArgsValueFromFieldRef
{
    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecArgsValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecArgsValueFrom
{
    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisTemplateSpecArgsValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisTemplateSpecArgsValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecArgs
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisTemplateSpecArgsValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecDryRun
{
    [JsonPropertyName("metricName")]
    public required string MetricName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMeasurementRetention
{
    [JsonPropertyName("limit")]
    public required int Limit { get; set; }

    [JsonPropertyName("metricName")]
    public required string MetricName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric
{
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat
{
    [JsonPropertyName("metric")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric? Metric { get; set; }

    [JsonPropertyName("period")]
    public IntOrString? Period { get; set; }

    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueries
{
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("metricStat")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat? MetricStat { get; set; }

    [JsonPropertyName("period")]
    public IntOrString? Period { get; set; }

    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatch
{
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    [JsonPropertyName("metricDataQueries")]
    public required IList<V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueries> MetricDataQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AnalysisTemplateSpecMetricsProviderDatadogAggregatorEnum>))]
public enum V1alpha1AnalysisTemplateSpecMetricsProviderDatadogAggregatorEnum
{
    [EnumMember(Value = "avg"), JsonStringEnumMemberName("avg")]
    Avg,
    [EnumMember(Value = "min"), JsonStringEnumMemberName("min")]
    Min,
    [EnumMember(Value = "max"), JsonStringEnumMemberName("max")]
    Max,
    [EnumMember(Value = "sum"), JsonStringEnumMemberName("sum")]
    Sum,
    [EnumMember(Value = "last"), JsonStringEnumMemberName("last")]
    Last,
    [EnumMember(Value = "percentile"), JsonStringEnumMemberName("percentile")]
    Percentile,
    [EnumMember(Value = "mean"), JsonStringEnumMemberName("mean")]
    Mean,
    [EnumMember(Value = "l2norm"), JsonStringEnumMemberName("l2norm")]
    L2norm,
    [EnumMember(Value = "area"), JsonStringEnumMemberName("area")]
    Area
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AnalysisTemplateSpecMetricsProviderDatadogApiVersionEnum>))]
public enum V1alpha1AnalysisTemplateSpecMetricsProviderDatadogApiVersionEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderDatadogSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespaced")]
    public bool? Namespaced { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderDatadog
{
    [JsonPropertyName("aggregator")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderDatadogAggregatorEnum? Aggregator { get; set; }

    [JsonPropertyName("apiVersion")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderDatadogApiVersionEnum? ApiVersion { get; set; }

    [JsonPropertyName("formula")]
    public string? Formula { get; set; }

    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    [JsonPropertyName("queries")]
    public IDictionary<string, string>? Queries { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderDatadogSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderGraphite
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderInfluxdb
{
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public required IList<int> Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions
{
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("onExitCodes")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes? OnExitCodes { get; set; }

    [JsonPropertyName("onPodConditions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions>? OnPodConditions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicy
{
    [JsonPropertyName("rules")]
    public required IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRules> Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSuccessPolicyRules
{
    [JsonPropertyName("succeededCount")]
    public int? SucceededCount { get; set; }

    [JsonPropertyName("succeededIndexes")]
    public string? SucceededIndexes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSuccessPolicy
{
    [JsonPropertyName("rules")]
    public required IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSuccessPolicyRules> Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public required V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFileKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("volumeName")]
    public required string VolumeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("divisor")]
    public IntOrString? Divisor { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersPorts
{
    [JsonPropertyName("containerPort")]
    public required int ContainerPort { get; set; }

    [JsonPropertyName("hostIP")]
    public string? HostIP { get; set; }

    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public required string MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    [JsonPropertyName("volumeDevices")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFileKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("volumeName")]
    public required string VolumeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("divisor")]
    public IntOrString? Divisor { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts
{
    [JsonPropertyName("containerPort")]
    public required int ContainerPort { get; set; }

    [JsonPropertyName("hostIP")]
    public string? HostIP { get; set; }

    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public required string MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    [JsonPropertyName("targetContainerName")]
    public string? TargetContainerName { get; set; }

    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    [JsonPropertyName("volumeDevices")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public required string Ip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFileKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("volumeName")]
    public required string VolumeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("divisor")]
    public IntOrString? Divisor { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts
{
    [JsonPropertyName("containerPort")]
    public required int ContainerPort { get; set; }

    [JsonPropertyName("hostIP")]
    public string? HostIP { get; set; }

    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public required string MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    [JsonPropertyName("volumeDevices")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecOs
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecReadinessGates
{
    [JsonPropertyName("conditionType")]
    public required string ConditionType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("resourceClaimName")]
    public string? ResourceClaimName { get; set; }

    [JsonPropertyName("resourceClaimTemplateName")]
    public string? ResourceClaimTemplateName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSchedulingGates
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("fsGroup")]
    public long? FsGroup { get; set; }

    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxChangePolicy")]
    public string? SeLinuxChangePolicy { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTolerations
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("maxSkew")]
    public required int MaxSkew { get; set; }

    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }

    [JsonPropertyName("whenUnsatisfiable")]
    public required string WhenUnsatisfiable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpec
{
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    [JsonPropertyName("affinity")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinity? Affinity { get; set; }

    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    [JsonPropertyName("containers")]
    public required IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainers> Containers { get; set; }

    [JsonPropertyName("dnsConfig")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfig? DnsConfig { get; set; }

    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    [JsonPropertyName("ephemeralContainers")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecHostAliases>? HostAliases { get; set; }

    [JsonPropertyName("hostIPC")]
    public bool? HostIPC { get; set; }

    [JsonPropertyName("hostNetwork")]
    public bool? HostNetwork { get; set; }

    [JsonPropertyName("hostPID")]
    public bool? HostPID { get; set; }

    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }

    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    [JsonPropertyName("hostnameOverride")]
    public string? HostnameOverride { get; set; }

    [JsonPropertyName("imagePullSecrets")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    [JsonPropertyName("initContainers")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    [JsonPropertyName("os")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecOs? Os { get; set; }

    [JsonPropertyName("overhead")]
    public IDictionary<string, IntOrString>? Overhead { get; set; }

    [JsonPropertyName("preemptionPolicy")]
    public string? PreemptionPolicy { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    [JsonPropertyName("readinessGates")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    [JsonPropertyName("resourceClaims")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaims>? ResourceClaims { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("runtimeClassName")]
    public string? RuntimeClassName { get; set; }

    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    [JsonPropertyName("schedulingGates")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("setHostnameAsFQDN")]
    public bool? SetHostnameAsFQDN { get; set; }

    [JsonPropertyName("shareProcessNamespace")]
    public bool? ShareProcessNamespace { get; set; }

    [JsonPropertyName("subdomain")]
    public string? Subdomain { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("tolerations")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTolerations>? Tolerations { get; set; }

    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    [JsonPropertyName("volumes")]
    public JsonNode? Volumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplate
{
    [JsonPropertyName("metadata")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpec
{
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    [JsonPropertyName("backoffLimit")]
    public int? BackoffLimit { get; set; }

    [JsonPropertyName("backoffLimitPerIndex")]
    public int? BackoffLimitPerIndex { get; set; }

    [JsonPropertyName("completionMode")]
    public string? CompletionMode { get; set; }

    [JsonPropertyName("completions")]
    public int? Completions { get; set; }

    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    [JsonPropertyName("manualSelector")]
    public bool? ManualSelector { get; set; }

    [JsonPropertyName("maxFailedIndexes")]
    public int? MaxFailedIndexes { get; set; }

    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("podFailurePolicy")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicy? PodFailurePolicy { get; set; }

    [JsonPropertyName("podReplacementPolicy")]
    public string? PodReplacementPolicy { get; set; }

    [JsonPropertyName("selector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSelector? Selector { get; set; }

    [JsonPropertyName("successPolicy")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSuccessPolicy? SuccessPolicy { get; set; }

    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    [JsonPropertyName("template")]
    public required V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplate Template { get; set; }

    [JsonPropertyName("ttlSecondsAfterFinished")]
    public int? TtlSecondsAfterFinished { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJob
{
    [JsonPropertyName("metadata")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobMetadata? Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1AnalysisTemplateSpecMetricsProviderJobSpec Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopesControlScope
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("region")]
    public required string Region { get; set; }

    [JsonPropertyName("scope")]
    public required string Scope { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }

    [JsonPropertyName("step")]
    public required long Step { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopesExperimentScope
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("region")]
    public required string Region { get; set; }

    [JsonPropertyName("scope")]
    public required string Scope { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }

    [JsonPropertyName("step")]
    public required long Step { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopes
{
    [JsonPropertyName("controlScope")]
    public required V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopesControlScope ControlScope { get; set; }

    [JsonPropertyName("experimentScope")]
    public required V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopesExperimentScope ExperimentScope { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayentaThreshold
{
    [JsonPropertyName("marginal")]
    public required long Marginal { get; set; }

    [JsonPropertyName("pass")]
    public required long Pass { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayenta
{
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    [JsonPropertyName("application")]
    public required string Application { get; set; }

    [JsonPropertyName("canaryConfigName")]
    public required string CanaryConfigName { get; set; }

    [JsonPropertyName("configurationAccountName")]
    public required string ConfigurationAccountName { get; set; }

    [JsonPropertyName("lookback")]
    public bool? Lookback { get; set; }

    [JsonPropertyName("metricsAccountName")]
    public required string MetricsAccountName { get; set; }

    [JsonPropertyName("scopes")]
    public required IList<V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopes> Scopes { get; set; }

    [JsonPropertyName("storageAccountName")]
    public required string StorageAccountName { get; set; }

    [JsonPropertyName("threshold")]
    public required V1alpha1AnalysisTemplateSpecMetricsProviderKayentaThreshold Threshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderNewRelic
{
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("query")]
    public required string Query { get; set; }

    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthenticationOauth2
{
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenUrl")]
    public string? TokenUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthenticationSigv4
{
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthentication
{
    [JsonPropertyName("oauth2")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthenticationOauth2? Oauth2 { get; set; }

    [JsonPropertyName("sigv4")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthenticationSigv4? Sigv4 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusHeaders
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusRangeQuery
{
    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }

    [JsonPropertyName("step")]
    public string? Step { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheus
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("authentication")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthentication? Authentication { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusHeaders>? Headers { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("rangeQuery")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusRangeQuery? RangeQuery { get; set; }

    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderSkywalking
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWavefront
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthenticationOauth2
{
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenUrl")]
    public string? TokenUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthenticationSigv4
{
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthentication
{
    [JsonPropertyName("oauth2")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthenticationOauth2? Oauth2 { get; set; }

    [JsonPropertyName("sigv4")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthenticationSigv4? Sigv4 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWebHeaders
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWeb
{
    [JsonPropertyName("authentication")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthentication? Authentication { get; set; }

    [JsonPropertyName("body")]
    public string? Body { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderWebHeaders>? Headers { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("jsonBody")]
    public JsonNode? JsonBody { get; set; }

    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public long? TimeoutSeconds { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProvider
{
    [JsonPropertyName("cloudWatch")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatch? CloudWatch { get; set; }

    [JsonPropertyName("datadog")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderDatadog? Datadog { get; set; }

    [JsonPropertyName("graphite")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderGraphite? Graphite { get; set; }

    [JsonPropertyName("influxdb")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderInfluxdb? Influxdb { get; set; }

    [JsonPropertyName("job")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJob? Job { get; set; }

    [JsonPropertyName("kayenta")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderKayenta? Kayenta { get; set; }

    [JsonPropertyName("newRelic")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderNewRelic? NewRelic { get; set; }

    [JsonPropertyName("plugin")]
    public JsonNode? Plugin { get; set; }

    [JsonPropertyName("prometheus")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheus? Prometheus { get; set; }

    [JsonPropertyName("skywalking")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderSkywalking? Skywalking { get; set; }

    [JsonPropertyName("wavefront")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWavefront? Wavefront { get; set; }

    [JsonPropertyName("web")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWeb? Web { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetrics
{
    [JsonPropertyName("consecutiveErrorLimit")]
    public IntOrString? ConsecutiveErrorLimit { get; set; }

    [JsonPropertyName("consecutiveSuccessLimit")]
    public IntOrString? ConsecutiveSuccessLimit { get; set; }

    [JsonPropertyName("count")]
    public IntOrString? Count { get; set; }

    [JsonPropertyName("failureCondition")]
    public string? FailureCondition { get; set; }

    [JsonPropertyName("failureLimit")]
    public IntOrString? FailureLimit { get; set; }

    [JsonPropertyName("inconclusiveLimit")]
    public IntOrString? InconclusiveLimit { get; set; }

    [JsonPropertyName("initialDelay")]
    public string? InitialDelay { get; set; }

    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("provider")]
    public required V1alpha1AnalysisTemplateSpecMetricsProvider Provider { get; set; }

    [JsonPropertyName("successCondition")]
    public string? SuccessCondition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecTemplates
{
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    [JsonPropertyName("templateName")]
    public string? TemplateName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpec
{
    [JsonPropertyName("args")]
    public IList<V1alpha1AnalysisTemplateSpecArgs>? Args { get; set; }

    [JsonPropertyName("dryRun")]
    public IList<V1alpha1AnalysisTemplateSpecDryRun>? DryRun { get; set; }

    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1AnalysisTemplateSpecMeasurementRetention>? MeasurementRetention { get; set; }

    [JsonPropertyName("metrics")]
    public IList<V1alpha1AnalysisTemplateSpecMetrics>? Metrics { get; set; }

    [JsonPropertyName("templates")]
    public IList<V1alpha1AnalysisTemplateSpecTemplates>? Templates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AnalysisTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AnalysisTemplateSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AnalysisTemplate";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "analysistemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AnalysisTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1AnalysisTemplateSpec Spec { get; set; }
}