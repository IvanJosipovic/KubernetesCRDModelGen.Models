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
public partial class V1alpha1ClusterAnalysisTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterAnalysisTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterAnalysisTemplateList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "clusteranalysistemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterAnalysisTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ClusterAnalysisTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ClusterAnalysisTemplate> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecArgsValueFromFieldRef
{
    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecArgsValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecArgsValueFrom
{
    [JsonPropertyName("fieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecArgsValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecArgsValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecArgs
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterAnalysisTemplateSpecArgsValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecDryRun
{
    [JsonPropertyName("metricName")]
    public required string MetricName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMeasurementRetention
{
    [JsonPropertyName("limit")]
    public required int Limit { get; set; }

    [JsonPropertyName("metricName")]
    public required string MetricName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric
{
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat
{
    [JsonPropertyName("metric")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric? Metric { get; set; }

    [JsonPropertyName("period")]
    public IntOrString? Period { get; set; }

    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueries
{
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("metricStat")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat? MetricStat { get; set; }

    [JsonPropertyName("period")]
    public IntOrString? Period { get; set; }

    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatch
{
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    [JsonPropertyName("metricDataQueries")]
    public required IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueries> MetricDataQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogAggregatorEnum>))]
public enum V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogAggregatorEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogApiVersionEnum>))]
public enum V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogApiVersionEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespaced")]
    public bool? Namespaced { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadog
{
    [JsonPropertyName("aggregator")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogAggregatorEnum? Aggregator { get; set; }

    [JsonPropertyName("apiVersion")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogApiVersionEnum? ApiVersion { get; set; }

    [JsonPropertyName("formula")]
    public string? Formula { get; set; }

    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    [JsonPropertyName("queries")]
    public IDictionary<string, string>? Queries { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderGraphite
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderInfluxdb
{
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions
{
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("onExitCodes")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes? OnExitCodes { get; set; }

    [JsonPropertyName("onPodConditions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions>? OnPodConditions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicy
{
    [JsonPropertyName("rules")]
    public required IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRules> Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSuccessPolicyRules
{
    [JsonPropertyName("succeededCount")]
    public int? SucceededCount { get; set; }

    [JsonPropertyName("succeededIndexes")]
    public string? SucceededIndexes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSuccessPolicy
{
    [JsonPropertyName("rules")]
    public required IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSuccessPolicyRules> Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public required V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFileKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersPorts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFileKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public required string Ip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFileKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecOs
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecReadinessGates
{
    [JsonPropertyName("conditionType")]
    public required string ConditionType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaims
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSchedulingGates
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTolerations
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpec
{
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    [JsonPropertyName("affinity")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinity? Affinity { get; set; }

    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    [JsonPropertyName("containers")]
    public required IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainers> Containers { get; set; }

    [JsonPropertyName("dnsConfig")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfig? DnsConfig { get; set; }

    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    [JsonPropertyName("ephemeralContainers")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecHostAliases>? HostAliases { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    [JsonPropertyName("initContainers")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    [JsonPropertyName("os")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecOs? Os { get; set; }

    [JsonPropertyName("overhead")]
    public IDictionary<string, IntOrString>? Overhead { get; set; }

    [JsonPropertyName("preemptionPolicy")]
    public string? PreemptionPolicy { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    [JsonPropertyName("readinessGates")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    [JsonPropertyName("resourceClaims")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaims>? ResourceClaims { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("runtimeClassName")]
    public string? RuntimeClassName { get; set; }

    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    [JsonPropertyName("schedulingGates")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContext? SecurityContext { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTolerations>? Tolerations { get; set; }

    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    [JsonPropertyName("volumes")]
    public JsonNode? Volumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplate
{
    [JsonPropertyName("metadata")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpec
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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicy? PodFailurePolicy { get; set; }

    [JsonPropertyName("podReplacementPolicy")]
    public string? PodReplacementPolicy { get; set; }

    [JsonPropertyName("selector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSelector? Selector { get; set; }

    [JsonPropertyName("successPolicy")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSuccessPolicy? SuccessPolicy { get; set; }

    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    [JsonPropertyName("template")]
    public required V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplate Template { get; set; }

    [JsonPropertyName("ttlSecondsAfterFinished")]
    public int? TtlSecondsAfterFinished { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJob
{
    [JsonPropertyName("metadata")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobMetadata? Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpec Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopesControlScope
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopesExperimentScope
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopes
{
    [JsonPropertyName("controlScope")]
    public required V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopesControlScope ControlScope { get; set; }

    [JsonPropertyName("experimentScope")]
    public required V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopesExperimentScope ExperimentScope { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaThreshold
{
    [JsonPropertyName("marginal")]
    public required long Marginal { get; set; }

    [JsonPropertyName("pass")]
    public required long Pass { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayenta
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
    public required IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopes> Scopes { get; set; }

    [JsonPropertyName("storageAccountName")]
    public required string StorageAccountName { get; set; }

    [JsonPropertyName("threshold")]
    public required V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaThreshold Threshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderNewRelic
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthenticationOauth2
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthenticationSigv4
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthentication
{
    [JsonPropertyName("oauth2")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthenticationOauth2? Oauth2 { get; set; }

    [JsonPropertyName("sigv4")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthenticationSigv4? Sigv4 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusHeaders
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusRangeQuery
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheus
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("authentication")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthentication? Authentication { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusHeaders>? Headers { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("rangeQuery")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusRangeQuery? RangeQuery { get; set; }

    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderSkywalking
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWavefront
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthenticationOauth2
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthenticationSigv4
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthentication
{
    [JsonPropertyName("oauth2")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthenticationOauth2? Oauth2 { get; set; }

    [JsonPropertyName("sigv4")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthenticationSigv4? Sigv4 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebHeaders
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWeb
{
    [JsonPropertyName("authentication")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthentication? Authentication { get; set; }

    [JsonPropertyName("body")]
    public string? Body { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebHeaders>? Headers { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProvider
{
    [JsonPropertyName("cloudWatch")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatch? CloudWatch { get; set; }

    [JsonPropertyName("datadog")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadog? Datadog { get; set; }

    [JsonPropertyName("graphite")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderGraphite? Graphite { get; set; }

    [JsonPropertyName("influxdb")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderInfluxdb? Influxdb { get; set; }

    [JsonPropertyName("job")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJob? Job { get; set; }

    [JsonPropertyName("kayenta")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayenta? Kayenta { get; set; }

    [JsonPropertyName("newRelic")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderNewRelic? NewRelic { get; set; }

    [JsonPropertyName("plugin")]
    public JsonNode? Plugin { get; set; }

    [JsonPropertyName("prometheus")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheus? Prometheus { get; set; }

    [JsonPropertyName("skywalking")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderSkywalking? Skywalking { get; set; }

    [JsonPropertyName("wavefront")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWavefront? Wavefront { get; set; }

    [JsonPropertyName("web")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWeb? Web { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetrics
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
    public required V1alpha1ClusterAnalysisTemplateSpecMetricsProvider Provider { get; set; }

    [JsonPropertyName("successCondition")]
    public string? SuccessCondition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecTemplates
{
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    [JsonPropertyName("templateName")]
    public string? TemplateName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpec
{
    [JsonPropertyName("args")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecArgs>? Args { get; set; }

    [JsonPropertyName("dryRun")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecDryRun>? DryRun { get; set; }

    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMeasurementRetention>? MeasurementRetention { get; set; }

    [JsonPropertyName("metrics")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetrics>? Metrics { get; set; }

    [JsonPropertyName("templates")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecTemplates>? Templates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterAnalysisTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterAnalysisTemplateSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterAnalysisTemplate";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "clusteranalysistemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterAnalysisTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1ClusterAnalysisTemplateSpec Spec { get; set; }
}