#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.temporal.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkerDeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WorkerDeployment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkerDeploymentList";
    public const string KubeGroup = "temporal.io";
    public const string KubePluralName = "workerdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "temporal.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkerDeploymentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1WorkerDeployment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1WorkerDeployment> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecRolloutGateInputFromConfigMapKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecRolloutGateInputFromSecretKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecRolloutGateInputFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkerDeploymentSpecRolloutGateInputFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkerDeploymentSpecRolloutGateInputFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecRolloutGate
{
    [JsonPropertyName("input")]
    public JsonNode? Input { get; set; }

    [JsonPropertyName("inputFrom")]
    public V1alpha1WorkerDeploymentSpecRolloutGateInputFrom? InputFrom { get; set; }

    [JsonPropertyName("workflowType")]
    public required string WorkflowType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecRolloutSteps
{
    [JsonPropertyName("pauseDuration")]
    public required string PauseDuration { get; set; }

    [JsonPropertyName("rampPercentage")]
    public required int RampPercentage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WorkerDeploymentSpecRolloutStrategyEnum>))]
public enum V1alpha1WorkerDeploymentSpecRolloutStrategyEnum
{
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual,
    [EnumMember(Value = "AllAtOnce"), JsonStringEnumMemberName("AllAtOnce")]
    AllAtOnce,
    [EnumMember(Value = "Progressive"), JsonStringEnumMemberName("Progressive")]
    Progressive
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecRollout
{
    [JsonPropertyName("gate")]
    public V1alpha1WorkerDeploymentSpecRolloutGate? Gate { get; set; }

    [JsonPropertyName("steps")]
    public IList<V1alpha1WorkerDeploymentSpecRolloutSteps>? Steps { get; set; }

    [JsonPropertyName("strategy")]
    public required V1alpha1WorkerDeploymentSpecRolloutStrategyEnum Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecSunset
{
    [JsonPropertyName("deleteDelay")]
    public string? DeleteDelay { get; set; }

    [JsonPropertyName("scaledownDelay")]
    public string? ScaledownDelay { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public required V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromFileKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersPorts
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextWindowsOptions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainersVolumeMounts
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromFileKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersPorts
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersVolumeMounts
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public required string Ip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromFileKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersPorts
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextWindowsOptions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersVolumeMounts
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecInitContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecOs
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecReadinessGates
{
    [JsonPropertyName("conditionType")]
    public required string ConditionType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecResourceClaims
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecSchedulingGates
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextWindowsOptions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

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
    public V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecTolerations
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesAwsElasticBlockStore
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("partition")]
    public int? Partition { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeID")]
    public required string VolumeID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesAzureDisk
{
    [JsonPropertyName("cachingMode")]
    public string? CachingMode { get; set; }

    [JsonPropertyName("diskName")]
    public required string DiskName { get; set; }

    [JsonPropertyName("diskURI")]
    public required string DiskURI { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesAzureFile
{
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    [JsonPropertyName("shareName")]
    public required string ShareName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCephfsSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCephfs
{
    [JsonPropertyName("monitors")]
    public required IList<string> Monitors { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretFile")]
    public string? SecretFile { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCephfsSecretRef? SecretRef { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCinderSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCinder
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCinderSecretRef? SecretRef { get; set; }

    [JsonPropertyName("volumeID")]
    public required string VolumeID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCsi
{
    [JsonPropertyName("driver")]
    public required string Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsResourceFieldRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItems
{
    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesDownwardAPI
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEmptyDir
{
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    [JsonPropertyName("sizeLimit")]
    public IntOrString? SizeLimit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSource
{
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSourceRef
{
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecResources
{
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpec
{
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    [JsonPropertyName("dataSource")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSource? DataSource { get; set; }

    [JsonPropertyName("dataSourceRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSourceRef? DataSourceRef { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecResources? Resources { get; set; }

    [JsonPropertyName("selector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelector? Selector { get; set; }

    [JsonPropertyName("storageClassName")]
    public string? StorageClassName { get; set; }

    [JsonPropertyName("volumeAttributesClassName")]
    public string? VolumeAttributesClassName { get; set; }

    [JsonPropertyName("volumeMode")]
    public string? VolumeMode { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplate
{
    [JsonPropertyName("metadata")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpec Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeral
{
    [JsonPropertyName("volumeClaimTemplate")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplate? VolumeClaimTemplate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesFc
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("targetWWNs")]
    public IList<string>? TargetWWNs { get; set; }

    [JsonPropertyName("wwids")]
    public IList<string>? Wwids { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesFlexVolumeSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesFlexVolume
{
    [JsonPropertyName("driver")]
    public required string Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesFlexVolumeSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesFlocker
{
    [JsonPropertyName("datasetName")]
    public string? DatasetName { get; set; }

    [JsonPropertyName("datasetUUID")]
    public string? DatasetUUID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesGcePersistentDisk
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("partition")]
    public int? Partition { get; set; }

    [JsonPropertyName("pdName")]
    public required string PdName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesGitRepo
{
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    [JsonPropertyName("repository")]
    public required string Repository { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesGlusterfs
{
    [JsonPropertyName("endpoints")]
    public required string Endpoints { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesHostPath
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesIscsiSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesIscsi
{
    [JsonPropertyName("chapAuthDiscovery")]
    public bool? ChapAuthDiscovery { get; set; }

    [JsonPropertyName("chapAuthSession")]
    public bool? ChapAuthSession { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("initiatorName")]
    public string? InitiatorName { get; set; }

    [JsonPropertyName("iqn")]
    public required string Iqn { get; set; }

    [JsonPropertyName("iscsiInterface")]
    public string? IscsiInterface { get; set; }

    [JsonPropertyName("lun")]
    public required int Lun { get; set; }

    [JsonPropertyName("portals")]
    public IList<string>? Portals { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesIscsiSecretRef? SecretRef { get; set; }

    [JsonPropertyName("targetPortal")]
    public required string TargetPortal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesNfs
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("server")]
    public required string Server { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public required string ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesPhotonPersistentDisk
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("pdID")]
    public required string PdID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesPortworxVolume
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeID")]
    public required string VolumeID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundle
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("signerName")]
    public string? SignerName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesConfigMapItems
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesConfigMap
{
    [JsonPropertyName("items")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef
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
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItems
{
    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPI
{
    [JsonPropertyName("items")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesPodCertificate
{
    [JsonPropertyName("certificateChainPath")]
    public string? CertificateChainPath { get; set; }

    [JsonPropertyName("credentialBundlePath")]
    public string? CredentialBundlePath { get; set; }

    [JsonPropertyName("keyPath")]
    public string? KeyPath { get; set; }

    [JsonPropertyName("keyType")]
    public required string KeyType { get; set; }

    [JsonPropertyName("maxExpirationSeconds")]
    public int? MaxExpirationSeconds { get; set; }

    [JsonPropertyName("signerName")]
    public required string SignerName { get; set; }

    [JsonPropertyName("userAnnotations")]
    public IDictionary<string, string>? UserAnnotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesSecretItems
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesSecret
{
    [JsonPropertyName("items")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesSecretItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesServiceAccountToken
{
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    [JsonPropertyName("expirationSeconds")]
    public long? ExpirationSeconds { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSources
{
    [JsonPropertyName("clusterTrustBundle")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundle? ClusterTrustBundle { get; set; }

    [JsonPropertyName("configMap")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesConfigMap? ConfigMap { get; set; }

    [JsonPropertyName("downwardAPI")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPI? DownwardAPI { get; set; }

    [JsonPropertyName("podCertificate")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesPodCertificate? PodCertificate { get; set; }

    [JsonPropertyName("secret")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesSecret? Secret { get; set; }

    [JsonPropertyName("serviceAccountToken")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesServiceAccountToken? ServiceAccountToken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjected
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("sources")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjectedSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesQuobyte
{
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("registry")]
    public required string Registry { get; set; }

    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }

    [JsonPropertyName("volume")]
    public required string Volume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesRbdSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesRbd
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("image")]
    public required string Image { get; set; }

    [JsonPropertyName("keyring")]
    public string? Keyring { get; set; }

    [JsonPropertyName("monitors")]
    public required IList<string> Monitors { get; set; }

    [JsonPropertyName("pool")]
    public string? Pool { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesRbdSecretRef? SecretRef { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesScaleIOSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesScaleIO
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("gateway")]
    public required string Gateway { get; set; }

    [JsonPropertyName("protectionDomain")]
    public string? ProtectionDomain { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public required V1alpha1WorkerDeploymentSpecTemplateSpecVolumesScaleIOSecretRef SecretRef { get; set; }

    [JsonPropertyName("sslEnabled")]
    public bool? SslEnabled { get; set; }

    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    [JsonPropertyName("storagePool")]
    public string? StoragePool { get; set; }

    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesSecretItems
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesStorageosSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesStorageos
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesStorageosSecretRef? SecretRef { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }

    [JsonPropertyName("volumeNamespace")]
    public string? VolumeNamespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumesVsphereVolume
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("storagePolicyID")]
    public string? StoragePolicyID { get; set; }

    [JsonPropertyName("storagePolicyName")]
    public string? StoragePolicyName { get; set; }

    [JsonPropertyName("volumePath")]
    public required string VolumePath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecVolumes
{
    [JsonPropertyName("awsElasticBlockStore")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesAwsElasticBlockStore? AwsElasticBlockStore { get; set; }

    [JsonPropertyName("azureDisk")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesAzureDisk? AzureDisk { get; set; }

    [JsonPropertyName("azureFile")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesAzureFile? AzureFile { get; set; }

    [JsonPropertyName("cephfs")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCephfs? Cephfs { get; set; }

    [JsonPropertyName("cinder")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCinder? Cinder { get; set; }

    [JsonPropertyName("configMap")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesConfigMap? ConfigMap { get; set; }

    [JsonPropertyName("csi")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesCsi? Csi { get; set; }

    [JsonPropertyName("downwardAPI")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesDownwardAPI? DownwardAPI { get; set; }

    [JsonPropertyName("emptyDir")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEmptyDir? EmptyDir { get; set; }

    [JsonPropertyName("ephemeral")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesEphemeral? Ephemeral { get; set; }

    [JsonPropertyName("fc")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesFc? Fc { get; set; }

    [JsonPropertyName("flexVolume")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesFlexVolume? FlexVolume { get; set; }

    [JsonPropertyName("flocker")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesFlocker? Flocker { get; set; }

    [JsonPropertyName("gcePersistentDisk")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesGcePersistentDisk? GcePersistentDisk { get; set; }

    [JsonPropertyName("gitRepo")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesGitRepo? GitRepo { get; set; }

    [JsonPropertyName("glusterfs")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesGlusterfs? Glusterfs { get; set; }

    [JsonPropertyName("hostPath")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesHostPath? HostPath { get; set; }

    [JsonPropertyName("image")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesImage? Image { get; set; }

    [JsonPropertyName("iscsi")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesIscsi? Iscsi { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("nfs")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesNfs? Nfs { get; set; }

    [JsonPropertyName("persistentVolumeClaim")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    [JsonPropertyName("photonPersistentDisk")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesPhotonPersistentDisk? PhotonPersistentDisk { get; set; }

    [JsonPropertyName("portworxVolume")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesPortworxVolume? PortworxVolume { get; set; }

    [JsonPropertyName("projected")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesProjected? Projected { get; set; }

    [JsonPropertyName("quobyte")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesQuobyte? Quobyte { get; set; }

    [JsonPropertyName("rbd")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesRbd? Rbd { get; set; }

    [JsonPropertyName("scaleIO")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesScaleIO? ScaleIO { get; set; }

    [JsonPropertyName("secret")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesSecret? Secret { get; set; }

    [JsonPropertyName("storageos")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesStorageos? Storageos { get; set; }

    [JsonPropertyName("vsphereVolume")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecVolumesVsphereVolume? VsphereVolume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpecWorkloadRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("podGroup")]
    public required string PodGroup { get; set; }

    [JsonPropertyName("podGroupReplicaKey")]
    public string? PodGroupReplicaKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplateSpec
{
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    [JsonPropertyName("affinity")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecAffinity? Affinity { get; set; }

    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    [JsonPropertyName("containers")]
    public required IList<V1alpha1WorkerDeploymentSpecTemplateSpecContainers> Containers { get; set; }

    [JsonPropertyName("dnsConfig")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecDnsConfig? DnsConfig { get; set; }

    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    [JsonPropertyName("ephemeralContainers")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecHostAliases>? HostAliases { get; set; }

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
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    [JsonPropertyName("initContainers")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    [JsonPropertyName("os")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecOs? Os { get; set; }

    [JsonPropertyName("overhead")]
    public IDictionary<string, IntOrString>? Overhead { get; set; }

    [JsonPropertyName("preemptionPolicy")]
    public string? PreemptionPolicy { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    [JsonPropertyName("readinessGates")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    [JsonPropertyName("resourceClaims")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecResourceClaims>? ResourceClaims { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("runtimeClassName")]
    public string? RuntimeClassName { get; set; }

    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    [JsonPropertyName("schedulingGates")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecSecurityContext? SecurityContext { get; set; }

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
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecTolerations>? Tolerations { get; set; }

    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    [JsonPropertyName("volumes")]
    public IList<V1alpha1WorkerDeploymentSpecTemplateSpecVolumes>? Volumes { get; set; }

    [JsonPropertyName("workloadRef")]
    public V1alpha1WorkerDeploymentSpecTemplateSpecWorkloadRef? WorkloadRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecTemplate
{
    [JsonPropertyName("metadata")]
    public V1alpha1WorkerDeploymentSpecTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1WorkerDeploymentSpecTemplateSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecWorkerOptionsConnectionRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpecWorkerOptions
{
    [JsonPropertyName("connectionRef")]
    public required V1alpha1WorkerDeploymentSpecWorkerOptionsConnectionRef ConnectionRef { get; set; }

    [JsonPropertyName("temporalNamespace")]
    public required string TemporalNamespace { get; set; }

    [JsonPropertyName("unsafeCustomBuildID")]
    public string? UnsafeCustomBuildID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentSpec
{
    [JsonPropertyName("minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    [JsonPropertyName("progressDeadlineSeconds")]
    public int? ProgressDeadlineSeconds { get; set; }

    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    [JsonPropertyName("rollout")]
    public required V1alpha1WorkerDeploymentSpecRollout Rollout { get; set; }

    [JsonPropertyName("sunset")]
    public required V1alpha1WorkerDeploymentSpecSunset Sunset { get; set; }

    [JsonPropertyName("template")]
    public required V1alpha1WorkerDeploymentSpecTemplate Template { get; set; }

    [JsonPropertyName("workerOptions")]
    public required V1alpha1WorkerDeploymentSpecWorkerOptions WorkerOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WorkerDeploymentStatusConditionsStatusEnum>))]
public enum V1alpha1WorkerDeploymentStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusConditions
{
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    [JsonPropertyName("status")]
    public required V1alpha1WorkerDeploymentStatusConditionsStatusEnum Status { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusCurrentVersionDeployment
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusCurrentVersionTaskQueues
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusCurrentVersion
{
    [JsonPropertyName("buildID")]
    public required string BuildID { get; set; }

    [JsonPropertyName("deployment")]
    public V1alpha1WorkerDeploymentStatusCurrentVersionDeployment? Deployment { get; set; }

    [JsonPropertyName("healthySince")]
    public DateTime? HealthySince { get; set; }

    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("taskQueues")]
    public IList<V1alpha1WorkerDeploymentStatusCurrentVersionTaskQueues>? TaskQueues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusDeprecatedVersionsDeployment
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusDeprecatedVersionsTaskQueues
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusDeprecatedVersions
{
    [JsonPropertyName("buildID")]
    public required string BuildID { get; set; }

    [JsonPropertyName("deployment")]
    public V1alpha1WorkerDeploymentStatusDeprecatedVersionsDeployment? Deployment { get; set; }

    [JsonPropertyName("drainedSince")]
    public DateTime? DrainedSince { get; set; }

    [JsonPropertyName("eligibleForDeletion")]
    public bool? EligibleForDeletion { get; set; }

    [JsonPropertyName("healthySince")]
    public DateTime? HealthySince { get; set; }

    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("taskQueues")]
    public IList<V1alpha1WorkerDeploymentStatusDeprecatedVersionsTaskQueues>? TaskQueues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusTargetVersionDeployment
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusTargetVersionTaskQueues
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusTargetVersionTestWorkflows
{
    [JsonPropertyName("runID")]
    public required string RunID { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("taskQueue")]
    public required string TaskQueue { get; set; }

    [JsonPropertyName("workflowID")]
    public required string WorkflowID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatusTargetVersion
{
    [JsonPropertyName("buildID")]
    public required string BuildID { get; set; }

    [JsonPropertyName("deployment")]
    public V1alpha1WorkerDeploymentStatusTargetVersionDeployment? Deployment { get; set; }

    [JsonPropertyName("healthySince")]
    public DateTime? HealthySince { get; set; }

    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    [JsonPropertyName("rampLastModifiedAt")]
    public DateTime? RampLastModifiedAt { get; set; }

    [JsonPropertyName("rampPercentage")]
    public double? RampPercentage { get; set; }

    [JsonPropertyName("rampingSince")]
    public DateTime? RampingSince { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("taskQueues")]
    public IList<V1alpha1WorkerDeploymentStatusTargetVersionTaskQueues>? TaskQueues { get; set; }

    [JsonPropertyName("testWorkflows")]
    public IList<V1alpha1WorkerDeploymentStatusTargetVersionTestWorkflows>? TestWorkflows { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkerDeploymentStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1WorkerDeploymentStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("currentVersion")]
    public V1alpha1WorkerDeploymentStatusCurrentVersion? CurrentVersion { get; set; }

    [JsonPropertyName("deprecatedVersions")]
    public IList<V1alpha1WorkerDeploymentStatusDeprecatedVersions>? DeprecatedVersions { get; set; }

    [JsonPropertyName("lastModifierIdentity")]
    public string? LastModifierIdentity { get; set; }

    [JsonPropertyName("managerIdentity")]
    public string? ManagerIdentity { get; set; }

    [JsonPropertyName("targetVersion")]
    public required V1alpha1WorkerDeploymentStatusTargetVersion TargetVersion { get; set; }

    [JsonPropertyName("versionConflictToken")]
    public byte[]? VersionConflictToken { get; set; }

    [JsonPropertyName("versionCount")]
    public int? VersionCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkerDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WorkerDeploymentSpec?>, IStatus<V1alpha1WorkerDeploymentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkerDeployment";
    public const string KubeGroup = "temporal.io";
    public const string KubePluralName = "workerdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "temporal.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkerDeployment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1WorkerDeploymentSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1WorkerDeploymentStatus? Status { get; set; }
}