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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TemporalWorkerDeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TemporalWorkerDeployment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TemporalWorkerDeploymentList";
    public const string KubeGroup = "temporal.io";
    public const string KubePluralName = "temporalworkerdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "temporal.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TemporalWorkerDeploymentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TemporalWorkerDeployment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TemporalWorkerDeployment> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecRolloutGateInputFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecRolloutGateInputFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecRolloutGateInputFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecRolloutGateInputFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecRolloutGateInputFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecRolloutGate
{
    [JsonPropertyName("input")]
    public JsonNode? Input { get; set; }

    [JsonPropertyName("inputFrom")]
    public V1alpha1TemporalWorkerDeploymentSpecRolloutGateInputFrom? InputFrom { get; set; }

    [JsonPropertyName("workflowType")]
    public required string WorkflowType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecRolloutSteps
{
    [JsonPropertyName("pauseDuration")]
    public required string PauseDuration { get; set; }

    [JsonPropertyName("rampPercentage")]
    public required int RampPercentage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TemporalWorkerDeploymentSpecRolloutStrategyEnum>))]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public enum V1alpha1TemporalWorkerDeploymentSpecRolloutStrategyEnum
{
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual,
    [EnumMember(Value = "AllAtOnce"), JsonStringEnumMemberName("AllAtOnce")]
    AllAtOnce,
    [EnumMember(Value = "Progressive"), JsonStringEnumMemberName("Progressive")]
    Progressive
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecRollout
{
    [JsonPropertyName("gate")]
    public V1alpha1TemporalWorkerDeploymentSpecRolloutGate? Gate { get; set; }

    [JsonPropertyName("steps")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecRolloutSteps>? Steps { get; set; }

    [JsonPropertyName("strategy")]
    public required V1alpha1TemporalWorkerDeploymentSpecRolloutStrategyEnum Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecSunset
{
    [JsonPropertyName("deleteDelay")]
    public string? DeleteDelay { get; set; }

    [JsonPropertyName("scaledownDelay")]
    public string? ScaledownDelay { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateMetadata
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public required V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromFileKeyRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromResourceFieldRef
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("divisor")]
    public IntOrString? Divisor { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersPorts
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextSeLinuxOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextWindowsOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersVolumeMounts
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromFileKeyRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("divisor")]
    public IntOrString? Divisor { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersPorts
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersVolumeMounts
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public required string Ip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromFileKeyRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("divisor")]
    public IntOrString? Divisor { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("fileKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromFileKeyRef? FileKeyRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersPorts
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersRestartPolicyRulesExitCodes
{
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<int>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersRestartPolicyRules
{
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("exitCodes")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersRestartPolicyRulesExitCodes? ExitCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextWindowsOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersVolumeMounts
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("restartPolicyRules")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersRestartPolicyRules>? RestartPolicyRules { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecOs
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecReadinessGates
{
    [JsonPropertyName("conditionType")]
    public required string ConditionType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecResourceClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("resourceClaimName")]
    public string? ResourceClaimName { get; set; }

    [JsonPropertyName("resourceClaimTemplateName")]
    public string? ResourceClaimTemplateName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSchedulingGates
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextSeLinuxOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextWindowsOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

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
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecTolerations
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesAwsElasticBlockStore
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesAzureDisk
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesAzureFile
{
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    [JsonPropertyName("shareName")]
    public required string ShareName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCephfsSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCephfs
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
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCephfsSecretRef? SecretRef { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCinderSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCinder
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCinderSecretRef? SecretRef { get; set; }

    [JsonPropertyName("volumeID")]
    public required string VolumeID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCsi
{
    [JsonPropertyName("driver")]
    public required string Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsResourceFieldRef
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("divisor")]
    public IntOrString? Divisor { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItems
{
    [JsonPropertyName("fieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesDownwardAPI
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesDownwardAPIItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEmptyDir
{
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    [JsonPropertyName("sizeLimit")]
    public IntOrString? SizeLimit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateMetadata
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSource
{
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSourceRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecResources
{
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpec
{
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    [JsonPropertyName("dataSource")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSource? DataSource { get; set; }

    [JsonPropertyName("dataSourceRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecDataSourceRef? DataSourceRef { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecResources? Resources { get; set; }

    [JsonPropertyName("selector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpecSelector? Selector { get; set; }

    [JsonPropertyName("storageClassName")]
    public string? StorageClassName { get; set; }

    [JsonPropertyName("volumeAttributesClassName")]
    public string? VolumeAttributesClassName { get; set; }

    [JsonPropertyName("volumeMode")]
    public string? VolumeMode { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplate
{
    [JsonPropertyName("metadata")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplateSpec Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeral
{
    [JsonPropertyName("volumeClaimTemplate")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeralVolumeClaimTemplate? VolumeClaimTemplate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesFc
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesFlexVolumeSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesFlexVolume
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
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesFlexVolumeSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesFlocker
{
    [JsonPropertyName("datasetName")]
    public string? DatasetName { get; set; }

    [JsonPropertyName("datasetUUID")]
    public string? DatasetUUID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesGcePersistentDisk
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesGitRepo
{
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    [JsonPropertyName("repository")]
    public required string Repository { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesGlusterfs
{
    [JsonPropertyName("endpoints")]
    public required string Endpoints { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesHostPath
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesIscsiSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesIscsi
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
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesIscsiSecretRef? SecretRef { get; set; }

    [JsonPropertyName("targetPortal")]
    public required string TargetPortal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesNfs
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("server")]
    public required string Server { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public required string ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesPhotonPersistentDisk
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("pdID")]
    public required string PdID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesPortworxVolume
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeID")]
    public required string VolumeID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundle
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundleLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("signerName")]
    public string? SignerName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesConfigMapItems
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesConfigMap
{
    [JsonPropertyName("items")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef
{
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("divisor")]
    public IntOrString? Divisor { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItems
{
    [JsonPropertyName("fieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPI
{
    [JsonPropertyName("items")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesPodCertificate
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesSecretItems
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesSecret
{
    [JsonPropertyName("items")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesSecretItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesServiceAccountToken
{
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    [JsonPropertyName("expirationSeconds")]
    public long? ExpirationSeconds { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSources
{
    [JsonPropertyName("clusterTrustBundle")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesClusterTrustBundle? ClusterTrustBundle { get; set; }

    [JsonPropertyName("configMap")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesConfigMap? ConfigMap { get; set; }

    [JsonPropertyName("downwardAPI")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesDownwardAPI? DownwardAPI { get; set; }

    [JsonPropertyName("podCertificate")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesPodCertificate? PodCertificate { get; set; }

    [JsonPropertyName("secret")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesSecret? Secret { get; set; }

    [JsonPropertyName("serviceAccountToken")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSourcesServiceAccountToken? ServiceAccountToken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjected
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("sources")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjectedSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesQuobyte
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesRbdSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesRbd
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
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesRbdSecretRef? SecretRef { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesScaleIOSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesScaleIO
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
    public required V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesScaleIOSecretRef SecretRef { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesSecretItems
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesStorageosSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesStorageos
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesStorageosSecretRef? SecretRef { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }

    [JsonPropertyName("volumeNamespace")]
    public string? VolumeNamespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesVsphereVolume
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumes
{
    [JsonPropertyName("awsElasticBlockStore")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesAwsElasticBlockStore? AwsElasticBlockStore { get; set; }

    [JsonPropertyName("azureDisk")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesAzureDisk? AzureDisk { get; set; }

    [JsonPropertyName("azureFile")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesAzureFile? AzureFile { get; set; }

    [JsonPropertyName("cephfs")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCephfs? Cephfs { get; set; }

    [JsonPropertyName("cinder")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCinder? Cinder { get; set; }

    [JsonPropertyName("configMap")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesConfigMap? ConfigMap { get; set; }

    [JsonPropertyName("csi")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesCsi? Csi { get; set; }

    [JsonPropertyName("downwardAPI")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesDownwardAPI? DownwardAPI { get; set; }

    [JsonPropertyName("emptyDir")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEmptyDir? EmptyDir { get; set; }

    [JsonPropertyName("ephemeral")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesEphemeral? Ephemeral { get; set; }

    [JsonPropertyName("fc")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesFc? Fc { get; set; }

    [JsonPropertyName("flexVolume")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesFlexVolume? FlexVolume { get; set; }

    [JsonPropertyName("flocker")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesFlocker? Flocker { get; set; }

    [JsonPropertyName("gcePersistentDisk")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesGcePersistentDisk? GcePersistentDisk { get; set; }

    [JsonPropertyName("gitRepo")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesGitRepo? GitRepo { get; set; }

    [JsonPropertyName("glusterfs")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesGlusterfs? Glusterfs { get; set; }

    [JsonPropertyName("hostPath")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesHostPath? HostPath { get; set; }

    [JsonPropertyName("image")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesImage? Image { get; set; }

    [JsonPropertyName("iscsi")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesIscsi? Iscsi { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("nfs")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesNfs? Nfs { get; set; }

    [JsonPropertyName("persistentVolumeClaim")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    [JsonPropertyName("photonPersistentDisk")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesPhotonPersistentDisk? PhotonPersistentDisk { get; set; }

    [JsonPropertyName("portworxVolume")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesPortworxVolume? PortworxVolume { get; set; }

    [JsonPropertyName("projected")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesProjected? Projected { get; set; }

    [JsonPropertyName("quobyte")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesQuobyte? Quobyte { get; set; }

    [JsonPropertyName("rbd")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesRbd? Rbd { get; set; }

    [JsonPropertyName("scaleIO")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesScaleIO? ScaleIO { get; set; }

    [JsonPropertyName("secret")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesSecret? Secret { get; set; }

    [JsonPropertyName("storageos")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesStorageos? Storageos { get; set; }

    [JsonPropertyName("vsphereVolume")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumesVsphereVolume? VsphereVolume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpecWorkloadRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("podGroup")]
    public required string PodGroup { get; set; }

    [JsonPropertyName("podGroupReplicaKey")]
    public string? PodGroupReplicaKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplateSpec
{
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    [JsonPropertyName("affinity")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecAffinity? Affinity { get; set; }

    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    [JsonPropertyName("containers")]
    public required IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecContainers> Containers { get; set; }

    [JsonPropertyName("dnsConfig")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecDnsConfig? DnsConfig { get; set; }

    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    [JsonPropertyName("ephemeralContainers")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecHostAliases>? HostAliases { get; set; }

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
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    [JsonPropertyName("initContainers")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    [JsonPropertyName("os")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecOs? Os { get; set; }

    [JsonPropertyName("overhead")]
    public IDictionary<string, IntOrString>? Overhead { get; set; }

    [JsonPropertyName("preemptionPolicy")]
    public string? PreemptionPolicy { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    [JsonPropertyName("readinessGates")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    [JsonPropertyName("resourceClaims")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecResourceClaims>? ResourceClaims { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("runtimeClassName")]
    public string? RuntimeClassName { get; set; }

    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    [JsonPropertyName("schedulingGates")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecSecurityContext? SecurityContext { get; set; }

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
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecTolerations>? Tolerations { get; set; }

    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    [JsonPropertyName("volumes")]
    public IList<V1alpha1TemporalWorkerDeploymentSpecTemplateSpecVolumes>? Volumes { get; set; }

    [JsonPropertyName("workloadRef")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpecWorkloadRef? WorkloadRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecTemplate
{
    [JsonPropertyName("metadata")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1TemporalWorkerDeploymentSpecTemplateSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecWorkerOptionsConnectionRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpecWorkerOptions
{
    [JsonPropertyName("connectionRef")]
    public required V1alpha1TemporalWorkerDeploymentSpecWorkerOptionsConnectionRef ConnectionRef { get; set; }

    [JsonPropertyName("temporalNamespace")]
    public required string TemporalNamespace { get; set; }

    [JsonPropertyName("unsafeCustomBuildID")]
    public string? UnsafeCustomBuildID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentSpec
{
    [JsonPropertyName("minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    [JsonPropertyName("progressDeadlineSeconds")]
    public int? ProgressDeadlineSeconds { get; set; }

    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    [JsonPropertyName("rollout")]
    public required V1alpha1TemporalWorkerDeploymentSpecRollout Rollout { get; set; }

    [JsonPropertyName("sunset")]
    public required V1alpha1TemporalWorkerDeploymentSpecSunset Sunset { get; set; }

    [JsonPropertyName("template")]
    public required V1alpha1TemporalWorkerDeploymentSpecTemplate Template { get; set; }

    [JsonPropertyName("workerOptions")]
    public required V1alpha1TemporalWorkerDeploymentSpecWorkerOptions WorkerOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TemporalWorkerDeploymentStatusConditionsStatusEnum>))]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public enum V1alpha1TemporalWorkerDeploymentStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusConditions
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
    public required V1alpha1TemporalWorkerDeploymentStatusConditionsStatusEnum Status { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusCurrentVersionDeployment
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusCurrentVersionTaskQueues
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusCurrentVersion
{
    [JsonPropertyName("buildID")]
    public required string BuildID { get; set; }

    [JsonPropertyName("deployment")]
    public V1alpha1TemporalWorkerDeploymentStatusCurrentVersionDeployment? Deployment { get; set; }

    [JsonPropertyName("healthySince")]
    public DateTime? HealthySince { get; set; }

    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("taskQueues")]
    public IList<V1alpha1TemporalWorkerDeploymentStatusCurrentVersionTaskQueues>? TaskQueues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusDeprecatedVersionsDeployment
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusDeprecatedVersionsTaskQueues
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusDeprecatedVersions
{
    [JsonPropertyName("buildID")]
    public required string BuildID { get; set; }

    [JsonPropertyName("deployment")]
    public V1alpha1TemporalWorkerDeploymentStatusDeprecatedVersionsDeployment? Deployment { get; set; }

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
    public IList<V1alpha1TemporalWorkerDeploymentStatusDeprecatedVersionsTaskQueues>? TaskQueues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusTargetVersionDeployment
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusTargetVersionTaskQueues
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusTargetVersionTestWorkflows
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatusTargetVersion
{
    [JsonPropertyName("buildID")]
    public required string BuildID { get; set; }

    [JsonPropertyName("deployment")]
    public V1alpha1TemporalWorkerDeploymentStatusTargetVersionDeployment? Deployment { get; set; }

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
    public IList<V1alpha1TemporalWorkerDeploymentStatusTargetVersionTaskQueues>? TaskQueues { get; set; }

    [JsonPropertyName("testWorkflows")]
    public IList<V1alpha1TemporalWorkerDeploymentStatusTargetVersionTestWorkflows>? TestWorkflows { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
public partial class V1alpha1TemporalWorkerDeploymentStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TemporalWorkerDeploymentStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("currentVersion")]
    public V1alpha1TemporalWorkerDeploymentStatusCurrentVersion? CurrentVersion { get; set; }

    [JsonPropertyName("deprecatedVersions")]
    public IList<V1alpha1TemporalWorkerDeploymentStatusDeprecatedVersions>? DeprecatedVersions { get; set; }

    [JsonPropertyName("lastModifierIdentity")]
    public string? LastModifierIdentity { get; set; }

    [JsonPropertyName("managerIdentity")]
    public string? ManagerIdentity { get; set; }

    [JsonPropertyName("targetVersion")]
    public required V1alpha1TemporalWorkerDeploymentStatusTargetVersion TargetVersion { get; set; }

    [JsonPropertyName("versionConflictToken")]
    public byte[]? VersionConflictToken { get; set; }

    [JsonPropertyName("versionCount")]
    public int? VersionCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalWorkerDeployment is deprecated. Use WorkerDeployment instead.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TemporalWorkerDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TemporalWorkerDeploymentSpec?>, IStatus<V1alpha1TemporalWorkerDeploymentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TemporalWorkerDeployment";
    public const string KubeGroup = "temporal.io";
    public const string KubePluralName = "temporalworkerdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "temporal.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TemporalWorkerDeployment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1TemporalWorkerDeploymentSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1TemporalWorkerDeploymentStatus? Status { get; set; }
}