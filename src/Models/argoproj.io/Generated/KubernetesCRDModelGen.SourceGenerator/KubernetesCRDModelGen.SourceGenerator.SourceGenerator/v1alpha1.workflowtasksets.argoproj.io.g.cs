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
public partial class V1alpha1WorkflowTaskSetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WorkflowTaskSet>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowTaskSetList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workflowtasksets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkflowTaskSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1WorkflowTaskSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1WorkflowTaskSet> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public required V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public required V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationAzureAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGitPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGitUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationOssAccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationOssSecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3AccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3CaSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3SecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3SessionTokenSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksArchiveLocation
{
    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationAzure? Azure { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationGit? Git { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationHttp? Http { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationOss? Oss { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationRaw? Raw { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocationS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFromResourceFieldRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFromSecretKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerPorts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextWindowsOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerVolumeMounts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainer
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersPorts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextWindowsOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersVolumeMounts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetRetryStrategy
{
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("retries")]
    public required IntOrString Retries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSetVolumeMounts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksContainerSet
{
    [JsonPropertyName("containers")]
    public required IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetContainers> Containers { get; set; }

    [JsonPropertyName("retryStrategy")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSetRetryStrategy? RetryStrategy { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksContainerSetVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArchiveNone
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArchiveTar
{
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArchiveZip
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArchive
{
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArchiveNone? None { get; set; }

    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArchiveTar? Tar { get; set; }

    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArchiveZip? Zip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactGC
{
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsAzureAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGitPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGitUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsOssAccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsOssSecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3AccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3CaSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3SecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3SessionTokenSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifacts
{
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArchive? Archive { get; set; }

    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactGC? ArtifactGC { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsAzure? Azure { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsGit? Git { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsHttp? Http { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsOss? Oss { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsRaw? Raw { get; set; }

    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifactsS3? S3 { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsParametersValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsParametersValueFromSupplied
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsParametersValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("event")]
    public string? Event { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("jqFilter")]
    public string? JqFilter { get; set; }

    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("supplied")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsParametersValueFromSupplied? Supplied { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsParameters
{
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("enum")]
    public IList<string>? Enum { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsParametersValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksArguments
{
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsArtifacts>? Artifacts { get; set; }

    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDagTasksArgumentsParameters>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksContinueOn
{
    [JsonPropertyName("error")]
    public bool? Error { get; set; }

    [JsonPropertyName("failed")]
    public bool? Failed { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArchiveNone
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArchiveTar
{
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArchiveZip
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArchive
{
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArchiveNone? None { get; set; }

    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArchiveTar? Tar { get; set; }

    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArchiveZip? Zip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactGC
{
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsAzureAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGitPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGitUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsOssAccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsOssSecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3AccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3CaSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3SecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3SessionTokenSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifacts
{
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArchive? Archive { get; set; }

    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactGC? ArtifactGC { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsAzure? Azure { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsGit? Git { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsHttp? Http { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsOss? Oss { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsRaw? Raw { get; set; }

    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifactsS3? S3 { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsParametersValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsParametersValueFromSupplied
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsParametersValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("event")]
    public string? Event { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("jqFilter")]
    public string? JqFilter { get; set; }

    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("supplied")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsParametersValueFromSupplied? Supplied { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsParameters
{
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("enum")]
    public IList<string>? Enum { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsParametersValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArguments
{
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsArtifacts>? Artifacts { get; set; }

    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArgumentsParameters>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksTemplateRef
{
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("template")]
    public string? Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksHooks
{
    [JsonPropertyName("arguments")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksArguments? Arguments { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("template")]
    public string? Template { get; set; }

    [JsonPropertyName("templateRef")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksHooksTemplateRef? TemplateRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksTemplateRef
{
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("template")]
    public string? Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasksWithSequence
{
    [JsonPropertyName("count")]
    public IntOrString? Count { get; set; }

    [JsonPropertyName("end")]
    public IntOrString? End { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("start")]
    public IntOrString? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDagTasks
{
    [JsonPropertyName("arguments")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksArguments? Arguments { get; set; }

    [JsonPropertyName("continueOn")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksContinueOn? ContinueOn { get; set; }

    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }

    [JsonPropertyName("depends")]
    public string? Depends { get; set; }

    [JsonPropertyName("hooks")]
    public IDictionary<string, V1alpha1WorkflowTaskSetSpecTasksDagTasksHooks>? Hooks { get; set; }

    [JsonPropertyName("inline")]
    public JsonNode? Inline { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("onExit")]
    public string? OnExit { get; set; }

    [JsonPropertyName("template")]
    public string? Template { get; set; }

    [JsonPropertyName("templateRef")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksTemplateRef? TemplateRef { get; set; }

    [JsonPropertyName("when")]
    public string? When { get; set; }

    [JsonPropertyName("withItems")]
    public JsonNode? WithItems { get; set; }

    [JsonPropertyName("withParam")]
    public string? WithParam { get; set; }

    [JsonPropertyName("withSequence")]
    public V1alpha1WorkflowTaskSetSpecTasksDagTasksWithSequence? WithSequence { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDag
{
    [JsonPropertyName("failFast")]
    public bool? FailFast { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    [JsonPropertyName("tasks")]
    public required IList<V1alpha1WorkflowTaskSetSpecTasksDagTasks> Tasks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArchiveNone
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArchiveTar
{
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArchiveZip
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArchive
{
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArchiveNone? None { get; set; }

    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArchiveTar? Tar { get; set; }

    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArchiveZip? Zip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactGC
{
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactGCPodMetadata? PodMetadata { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsAzureAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGitPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGitUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsOssAccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsOssSecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3AccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3CaSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3SecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3SessionTokenSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPaths
{
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArchive? Archive { get; set; }

    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactGC? ArtifactGC { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsAzure? Azure { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsGit? Git { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsHttp? Http { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsOss? Oss { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsRaw? Raw { get; set; }

    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPathsS3? S3 { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataSource
{
    [JsonPropertyName("artifactPaths")]
    public V1alpha1WorkflowTaskSetSpecTasksDataSourceArtifactPaths? ArtifactPaths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksDataTransformation
{
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksData
{
    [JsonPropertyName("source")]
    public required V1alpha1WorkflowTaskSetSpecTasksDataSource Source { get; set; }

    [JsonPropertyName("transformation")]
    public required IList<V1alpha1WorkflowTaskSetSpecTasksDataTransformation> Transformation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksExecutor
{
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public required string Ip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksHttpBodyFrom
{
    [JsonPropertyName("bytes")]
    public byte[]? Bytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksHttpHeadersValueFromSecretKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksHttpHeadersValueFrom
{
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksHttpHeadersValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksHttpHeadersValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksHttp
{
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    [JsonPropertyName("bodyFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksHttpBodyFrom? BodyFrom { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("successCondition")]
    public string? SuccessCondition { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public long? TimeoutSeconds { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersPorts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextWindowsOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainersVolumeMounts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInitContainers
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("mirrorVolumeMounts")]
    public bool? MirrorVolumeMounts { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksInitContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainersVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArchiveNone
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArchiveTar
{
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArchiveZip
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArchive
{
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArchiveNone? None { get; set; }

    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArchiveTar? Tar { get; set; }

    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArchiveZip? Zip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactGC
{
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsAzureAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGitPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGitUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsOssAccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsOssSecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3AccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3CaSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3SecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3SessionTokenSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsArtifacts
{
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArchive? Archive { get; set; }

    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactGC? ArtifactGC { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsAzure? Azure { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsGit? Git { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsHttp? Http { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsOss? Oss { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsRaw? Raw { get; set; }

    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsArtifactsS3? S3 { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsParametersValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsParametersValueFromSupplied
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsParametersValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("event")]
    public string? Event { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("jqFilter")]
    public string? JqFilter { get; set; }

    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("supplied")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsParametersValueFromSupplied? Supplied { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputsParameters
{
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("enum")]
    public IList<string>? Enum { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksInputsParametersValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksInputs
{
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInputsArtifacts>? Artifacts { get; set; }

    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInputsParameters>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMemoizeCacheConfigMap
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMemoizeCache
{
    [JsonPropertyName("configMap")]
    public required V1alpha1WorkflowTaskSetSpecTasksMemoizeCacheConfigMap ConfigMap { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMemoize
{
    [JsonPropertyName("cache")]
    public required V1alpha1WorkflowTaskSetSpecTasksMemoizeCache Cache { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("maxAge")]
    public required string MaxAge { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusCounter
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusGaugeOperationEnum>))]
public enum V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusGaugeOperationEnum
{
    [EnumMember(Value = "Set"), JsonStringEnumMemberName("Set")]
    Set,
    [EnumMember(Value = "Add"), JsonStringEnumMemberName("Add")]
    Add,
    [EnumMember(Value = "Sub"), JsonStringEnumMemberName("Sub")]
    Sub
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusGauge
{
    [JsonPropertyName("operation")]
    public V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusGaugeOperationEnum? Operation { get; set; }

    [JsonPropertyName("realtime")]
    public required bool Realtime { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusHistogram
{
    [JsonPropertyName("buckets")]
    public required IList<double> Buckets { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusLabels
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheus
{
    [JsonPropertyName("counter")]
    public V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusCounter? Counter { get; set; }

    [JsonPropertyName("gauge")]
    public V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusGauge? Gauge { get; set; }

    [JsonPropertyName("help")]
    public required string Help { get; set; }

    [JsonPropertyName("histogram")]
    public V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusHistogram? Histogram { get; set; }

    [JsonPropertyName("labels")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheusLabels>? Labels { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("when")]
    public string? When { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksMetrics
{
    [JsonPropertyName("prometheus")]
    public required IList<V1alpha1WorkflowTaskSetSpecTasksMetricsPrometheus> Prometheus { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArchiveNone
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArchiveTar
{
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArchiveZip
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArchive
{
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArchiveNone? None { get; set; }

    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArchiveTar? Tar { get; set; }

    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArchiveZip? Zip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactGC
{
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsAzureAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGitPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGitUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsOssAccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsOssSecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3AccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3CaSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3SecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3SessionTokenSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsArtifacts
{
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArchive? Archive { get; set; }

    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactGC? ArtifactGC { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsAzure? Azure { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsGit? Git { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsHttp? Http { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsOss? Oss { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsRaw? Raw { get; set; }

    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsArtifactsS3? S3 { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsParametersValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsParametersValueFromSupplied
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsParametersValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("event")]
    public string? Event { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("jqFilter")]
    public string? JqFilter { get; set; }

    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("supplied")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsParametersValueFromSupplied? Supplied { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputsParameters
{
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("enum")]
    public IList<string>? Enum { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputsParametersValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksOutputs
{
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksOutputsArtifacts>? Artifacts { get; set; }

    [JsonPropertyName("exitCode")]
    public string? ExitCode { get; set; }

    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksOutputsParameters>? Parameters { get; set; }

    [JsonPropertyName("result")]
    public string? Result { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WorkflowTaskSetSpecTasksResourceActionEnum>))]
public enum V1alpha1WorkflowTaskSetSpecTasksResourceActionEnum
{
    [EnumMember(Value = "get"), JsonStringEnumMemberName("get")]
    Get,
    [EnumMember(Value = "create"), JsonStringEnumMemberName("create")]
    Create,
    [EnumMember(Value = "apply"), JsonStringEnumMemberName("apply")]
    Apply,
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete,
    [EnumMember(Value = "replace"), JsonStringEnumMemberName("replace")]
    Replace,
    [EnumMember(Value = "patch"), JsonStringEnumMemberName("patch")]
    Patch
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArchiveNone
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArchiveTar
{
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArchiveZip
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArchive
{
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArchiveNone? None { get; set; }

    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArchiveTar? Tar { get; set; }

    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArchiveZip? Zip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactGC
{
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactGCPodMetadata? PodMetadata { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactAzureAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGitPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGitUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactOssAccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactOssSecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3AccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3CaSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3SecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3SessionTokenSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifact
{
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArchive? Archive { get; set; }

    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactGC? ArtifactGC { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactAzure? Azure { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactGit? Git { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactHttp? Http { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactOss? Oss { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactRaw? Raw { get; set; }

    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifactS3? S3 { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResourceManifestFrom
{
    [JsonPropertyName("artifact")]
    public required V1alpha1WorkflowTaskSetSpecTasksResourceManifestFromArtifact Artifact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WorkflowTaskSetSpecTasksResourceMergeStrategyEnum>))]
public enum V1alpha1WorkflowTaskSetSpecTasksResourceMergeStrategyEnum
{
    [EnumMember(Value = "strategic"), JsonStringEnumMemberName("strategic")]
    Strategic,
    [EnumMember(Value = "merge"), JsonStringEnumMemberName("merge")]
    Merge,
    [EnumMember(Value = "json"), JsonStringEnumMemberName("json")]
    Json
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksResource
{
    [JsonPropertyName("action")]
    public required V1alpha1WorkflowTaskSetSpecTasksResourceActionEnum Action { get; set; }

    [JsonPropertyName("failureCondition")]
    public string? FailureCondition { get; set; }

    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }

    [JsonPropertyName("manifest")]
    public string? Manifest { get; set; }

    [JsonPropertyName("manifestFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceManifestFrom? ManifestFrom { get; set; }

    [JsonPropertyName("mergeStrategy")]
    public V1alpha1WorkflowTaskSetSpecTasksResourceMergeStrategyEnum? MergeStrategy { get; set; }

    [JsonPropertyName("setOwnerReference")]
    public bool? SetOwnerReference { get; set; }

    [JsonPropertyName("successCondition")]
    public string? SuccessCondition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksRetryStrategyAffinityNodeAntiAffinity
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksRetryStrategyAffinity
{
    [JsonPropertyName("nodeAntiAffinity")]
    public V1alpha1WorkflowTaskSetSpecTasksRetryStrategyAffinityNodeAntiAffinity? NodeAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksRetryStrategyBackoff
{
    [JsonPropertyName("cap")]
    public string? Cap { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("factor")]
    public IntOrString? Factor { get; set; }

    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WorkflowTaskSetSpecTasksRetryStrategyRetryPolicyEnum>))]
public enum V1alpha1WorkflowTaskSetSpecTasksRetryStrategyRetryPolicyEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "OnFailure"), JsonStringEnumMemberName("OnFailure")]
    OnFailure,
    [EnumMember(Value = "OnError"), JsonStringEnumMemberName("OnError")]
    OnError,
    [EnumMember(Value = "OnTransientError"), JsonStringEnumMemberName("OnTransientError")]
    OnTransientError
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksRetryStrategy
{
    [JsonPropertyName("affinity")]
    public V1alpha1WorkflowTaskSetSpecTasksRetryStrategyAffinity? Affinity { get; set; }

    [JsonPropertyName("backoff")]
    public V1alpha1WorkflowTaskSetSpecTasksRetryStrategyBackoff? Backoff { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("limit")]
    public IntOrString? Limit { get; set; }

    [JsonPropertyName("retryPolicy")]
    public V1alpha1WorkflowTaskSetSpecTasksRetryStrategyRetryPolicyEnum? RetryPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFromResourceFieldRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFromSecretKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptPorts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextWindowsOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksScriptVolumeMounts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksScript
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksScriptStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksScriptVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSecurityContextWindowsOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

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
    public V1alpha1WorkflowTaskSetSpecTasksSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFromFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFromResourceFieldRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFromSecretKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFromFieldRef? FieldRef { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    [JsonPropertyName("secretKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsEnv
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvFromConfigMapRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvFromSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvFrom
{
    [JsonPropertyName("configMapRef")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvFromConfigMapRef? ConfigMapRef { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvFromSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStart
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopSleep
{
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStop
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopExec? Exec { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopHttpGet? HttpGet { get; set; }

    [JsonPropertyName("sleep")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopSleep? Sleep { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecycle
{
    [JsonPropertyName("postStart")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePostStart? PostStart { get; set; }

    [JsonPropertyName("preStop")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecyclePreStop? PreStop { get; set; }

    [JsonPropertyName("stopSignal")]
    public string? StopSignal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsPorts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsResizePolicy
{
    [JsonPropertyName("resourceName")]
    public required string ResourceName { get; set; }

    [JsonPropertyName("restartPolicy")]
    public required string RestartPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsResourcesClaims
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsResources
{
    [JsonPropertyName("claims")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextSeLinuxOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextWindowsOptions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeExec
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeGrpc
{
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeHttpGet
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbe
{
    [JsonPropertyName("exec")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeExec? Exec { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    [JsonPropertyName("grpc")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeGrpc? Grpc { get; set; }

    [JsonPropertyName("httpGet")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    [JsonPropertyName("tcpSocket")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbeTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsVolumeDevices
{
    [JsonPropertyName("devicePath")]
    public required string DevicePath { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecarsVolumeMounts
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSidecars
{
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsEnv>? Env { get; set; }

    [JsonPropertyName("envFrom")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsEnvFrom>? EnvFrom { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    [JsonPropertyName("lifecycle")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLifecycle? Lifecycle { get; set; }

    [JsonPropertyName("livenessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsLivenessProbe? LivenessProbe { get; set; }

    [JsonPropertyName("mirrorVolumeMounts")]
    public bool? MirrorVolumeMounts { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsPorts>? Ports { get; set; }

    [JsonPropertyName("readinessProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsReadinessProbe? ReadinessProbe { get; set; }

    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsResizePolicy>? ResizePolicy { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsResources? Resources { get; set; }

    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("startupProbe")]
    public V1alpha1WorkflowTaskSetSpecTasksSidecarsStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsVolumeDevices>? VolumeDevices { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecarsVolumeMounts>? VolumeMounts { get; set; }

    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArchiveNone
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArchiveTar
{
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArchiveZip
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArchive
{
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArchiveNone? None { get; set; }

    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArchiveTar? Tar { get; set; }

    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArchiveZip? Zip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactGC
{
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsAzureAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGitPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGitUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsOssAccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsOssSecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3AccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3CaSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3SecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3SessionTokenSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifacts
{
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArchive? Archive { get; set; }

    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactGC? ArtifactGC { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsAzure? Azure { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsGit? Git { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsHttp? Http { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsOss? Oss { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsRaw? Raw { get; set; }

    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifactsS3? S3 { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsParametersValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsParametersValueFromSupplied
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsParametersValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("event")]
    public string? Event { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("jqFilter")]
    public string? JqFilter { get; set; }

    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("supplied")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsParametersValueFromSupplied? Supplied { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsParameters
{
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("enum")]
    public IList<string>? Enum { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsParametersValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsArguments
{
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsArtifacts>? Artifacts { get; set; }

    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksStepsStepsArgumentsParameters>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsContinueOn
{
    [JsonPropertyName("error")]
    public bool? Error { get; set; }

    [JsonPropertyName("failed")]
    public bool? Failed { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArchiveNone
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArchiveTar
{
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArchiveZip
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArchive
{
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArchiveNone? None { get; set; }

    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArchiveTar? Tar { get; set; }

    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArchiveZip? Zip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactGC
{
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsAzureAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGitPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGitUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsOssAccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsOssSecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3AccessKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3CaSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3SecretKeySecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3SessionTokenSecret
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifacts
{
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArchive? Archive { get; set; }

    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactGC? ArtifactGC { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsAzure? Azure { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsGit? Git { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsHttp? Http { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsOss? Oss { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsRaw? Raw { get; set; }

    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifactsS3? S3 { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsParametersValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsParametersValueFromSupplied
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsParametersValueFrom
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("event")]
    public string? Event { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("jqFilter")]
    public string? JqFilter { get; set; }

    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("supplied")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsParametersValueFromSupplied? Supplied { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsParameters
{
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("enum")]
    public IList<string>? Enum { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsParametersValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArguments
{
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsArtifacts>? Artifacts { get; set; }

    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArgumentsParameters>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksTemplateRef
{
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("template")]
    public string? Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooks
{
    [JsonPropertyName("arguments")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksArguments? Arguments { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("template")]
    public string? Template { get; set; }

    [JsonPropertyName("templateRef")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooksTemplateRef? TemplateRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsTemplateRef
{
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("template")]
    public string? Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsStepsWithSequence
{
    [JsonPropertyName("count")]
    public IntOrString? Count { get; set; }

    [JsonPropertyName("end")]
    public IntOrString? End { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("start")]
    public IntOrString? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksStepsSteps
{
    [JsonPropertyName("arguments")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsArguments? Arguments { get; set; }

    [JsonPropertyName("continueOn")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsContinueOn? ContinueOn { get; set; }

    [JsonPropertyName("hooks")]
    public IDictionary<string, V1alpha1WorkflowTaskSetSpecTasksStepsStepsHooks>? Hooks { get; set; }

    [JsonPropertyName("inline")]
    public JsonNode? Inline { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("onExit")]
    public string? OnExit { get; set; }

    [JsonPropertyName("template")]
    public string? Template { get; set; }

    [JsonPropertyName("templateRef")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsTemplateRef? TemplateRef { get; set; }

    [JsonPropertyName("when")]
    public string? When { get; set; }

    [JsonPropertyName("withItems")]
    public JsonNode? WithItems { get; set; }

    [JsonPropertyName("withParam")]
    public string? WithParam { get; set; }

    [JsonPropertyName("withSequence")]
    public V1alpha1WorkflowTaskSetSpecTasksStepsStepsWithSequence? WithSequence { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSteps
{
    [JsonPropertyName("steps")]
    public required IList<V1alpha1WorkflowTaskSetSpecTasksStepsSteps> Steps { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSuspend
{
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSynchronizationMutexes
{
    [JsonPropertyName("database")]
    public bool? Database { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSynchronizationSemaphoresConfigMapKeyRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksSynchronizationSemaphoresDatabase
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSynchronizationSemaphores
{
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetSpecTasksSynchronizationSemaphoresConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    [JsonPropertyName("database")]
    public V1alpha1WorkflowTaskSetSpecTasksSynchronizationSemaphoresDatabase? Database { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksSynchronization
{
    [JsonPropertyName("mutexes")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSynchronizationMutexes>? Mutexes { get; set; }

    [JsonPropertyName("semaphores")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSynchronizationSemaphores>? Semaphores { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksTolerations
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesAwsElasticBlockStore
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesAzureDisk
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesAzureFile
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesCephfsSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesCephfs
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
    public V1alpha1WorkflowTaskSetSpecTasksVolumesCephfsSecretRef? SecretRef { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesCinderSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesCinder
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesCinderSecretRef? SecretRef { get; set; }

    [JsonPropertyName("volumeID")]
    public required string VolumeID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesConfigMapItems
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesCsi
{
    [JsonPropertyName("driver")]
    public required string Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesDownwardAPIItemsFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesDownwardAPIItemsResourceFieldRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesDownwardAPIItems
{
    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesDownwardAPI
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumesDownwardAPIItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEmptyDir
{
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    [JsonPropertyName("sizeLimit")]
    public IntOrString? SizeLimit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    [JsonPropertyName("generateName")]
    public string? GenerateName { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecDataSource
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecDataSourceRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecResources
{
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpec
{
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    [JsonPropertyName("dataSource")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecDataSource? DataSource { get; set; }

    [JsonPropertyName("dataSourceRef")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecDataSourceRef? DataSourceRef { get; set; }

    [JsonPropertyName("resources")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecResources? Resources { get; set; }

    [JsonPropertyName("selector")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpecSelector? Selector { get; set; }

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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplate
{
    [JsonPropertyName("metadata")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplateSpec Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeral
{
    [JsonPropertyName("volumeClaimTemplate")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeralVolumeClaimTemplate? VolumeClaimTemplate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesFc
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesFlexVolumeSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesFlexVolume
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
    public V1alpha1WorkflowTaskSetSpecTasksVolumesFlexVolumeSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesFlocker
{
    [JsonPropertyName("datasetName")]
    public string? DatasetName { get; set; }

    [JsonPropertyName("datasetUUID")]
    public string? DatasetUUID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesGcePersistentDisk
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesGitRepo
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesGlusterfs
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesHostPath
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesIscsiSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesIscsi
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
    public V1alpha1WorkflowTaskSetSpecTasksVolumesIscsiSecretRef? SecretRef { get; set; }

    [JsonPropertyName("targetPortal")]
    public required string TargetPortal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesNfs
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public required string ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesPhotonPersistentDisk
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("pdID")]
    public required string PdID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesPortworxVolume
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesClusterTrustBundleLabelSelectorMatchExpressions
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesClusterTrustBundleLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesClusterTrustBundleLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesClusterTrustBundle
{
    [JsonPropertyName("labelSelector")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesClusterTrustBundleLabelSelector? LabelSelector { get; set; }

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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesConfigMapItems
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesConfigMap
{
    [JsonPropertyName("items")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesDownwardAPIItemsFieldRef
{
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesDownwardAPIItems
{
    [JsonPropertyName("fieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesDownwardAPI
{
    [JsonPropertyName("items")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesDownwardAPIItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesSecretItems
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesSecret
{
    [JsonPropertyName("items")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesSecretItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesServiceAccountToken
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSources
{
    [JsonPropertyName("clusterTrustBundle")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesClusterTrustBundle? ClusterTrustBundle { get; set; }

    [JsonPropertyName("configMap")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesConfigMap? ConfigMap { get; set; }

    [JsonPropertyName("downwardAPI")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesDownwardAPI? DownwardAPI { get; set; }

    [JsonPropertyName("secret")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesSecret? Secret { get; set; }

    [JsonPropertyName("serviceAccountToken")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSourcesServiceAccountToken? ServiceAccountToken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesProjected
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("sources")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumesProjectedSources>? Sources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesQuobyte
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesRbdSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesRbd
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
    public V1alpha1WorkflowTaskSetSpecTasksVolumesRbdSecretRef? SecretRef { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesScaleIOSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesScaleIO
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
    public required V1alpha1WorkflowTaskSetSpecTasksVolumesScaleIOSecretRef SecretRef { get; set; }

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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesSecretItems
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesStorageosSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesStorageos
{
    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("secretRef")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesStorageosSecretRef? SecretRef { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }

    [JsonPropertyName("volumeNamespace")]
    public string? VolumeNamespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumesVsphereVolume
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
public partial class V1alpha1WorkflowTaskSetSpecTasksVolumes
{
    [JsonPropertyName("awsElasticBlockStore")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesAwsElasticBlockStore? AwsElasticBlockStore { get; set; }

    [JsonPropertyName("azureDisk")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesAzureDisk? AzureDisk { get; set; }

    [JsonPropertyName("azureFile")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesAzureFile? AzureFile { get; set; }

    [JsonPropertyName("cephfs")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesCephfs? Cephfs { get; set; }

    [JsonPropertyName("cinder")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesCinder? Cinder { get; set; }

    [JsonPropertyName("configMap")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesConfigMap? ConfigMap { get; set; }

    [JsonPropertyName("csi")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesCsi? Csi { get; set; }

    [JsonPropertyName("downwardAPI")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesDownwardAPI? DownwardAPI { get; set; }

    [JsonPropertyName("emptyDir")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesEmptyDir? EmptyDir { get; set; }

    [JsonPropertyName("ephemeral")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesEphemeral? Ephemeral { get; set; }

    [JsonPropertyName("fc")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesFc? Fc { get; set; }

    [JsonPropertyName("flexVolume")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesFlexVolume? FlexVolume { get; set; }

    [JsonPropertyName("flocker")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesFlocker? Flocker { get; set; }

    [JsonPropertyName("gcePersistentDisk")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesGcePersistentDisk? GcePersistentDisk { get; set; }

    [JsonPropertyName("gitRepo")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesGitRepo? GitRepo { get; set; }

    [JsonPropertyName("glusterfs")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesGlusterfs? Glusterfs { get; set; }

    [JsonPropertyName("hostPath")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesHostPath? HostPath { get; set; }

    [JsonPropertyName("image")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesImage? Image { get; set; }

    [JsonPropertyName("iscsi")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesIscsi? Iscsi { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("nfs")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesNfs? Nfs { get; set; }

    [JsonPropertyName("persistentVolumeClaim")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    [JsonPropertyName("photonPersistentDisk")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesPhotonPersistentDisk? PhotonPersistentDisk { get; set; }

    [JsonPropertyName("portworxVolume")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesPortworxVolume? PortworxVolume { get; set; }

    [JsonPropertyName("projected")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesProjected? Projected { get; set; }

    [JsonPropertyName("quobyte")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesQuobyte? Quobyte { get; set; }

    [JsonPropertyName("rbd")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesRbd? Rbd { get; set; }

    [JsonPropertyName("scaleIO")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesScaleIO? ScaleIO { get; set; }

    [JsonPropertyName("secret")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesSecret? Secret { get; set; }

    [JsonPropertyName("storageos")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesStorageos? Storageos { get; set; }

    [JsonPropertyName("vsphereVolume")]
    public V1alpha1WorkflowTaskSetSpecTasksVolumesVsphereVolume? VsphereVolume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpecTasks
{
    [JsonPropertyName("activeDeadlineSeconds")]
    public IntOrString? ActiveDeadlineSeconds { get; set; }

    [JsonPropertyName("affinity")]
    public V1alpha1WorkflowTaskSetSpecTasksAffinity? Affinity { get; set; }

    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("archiveLocation")]
    public V1alpha1WorkflowTaskSetSpecTasksArchiveLocation? ArchiveLocation { get; set; }

    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    [JsonPropertyName("container")]
    public V1alpha1WorkflowTaskSetSpecTasksContainer? Container { get; set; }

    [JsonPropertyName("containerSet")]
    public V1alpha1WorkflowTaskSetSpecTasksContainerSet? ContainerSet { get; set; }

    [JsonPropertyName("daemon")]
    public bool? Daemon { get; set; }

    [JsonPropertyName("dag")]
    public V1alpha1WorkflowTaskSetSpecTasksDag? Dag { get; set; }

    [JsonPropertyName("data")]
    public V1alpha1WorkflowTaskSetSpecTasksData? Data { get; set; }

    [JsonPropertyName("executor")]
    public V1alpha1WorkflowTaskSetSpecTasksExecutor? Executor { get; set; }

    [JsonPropertyName("failFast")]
    public bool? FailFast { get; set; }

    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksHostAliases>? HostAliases { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetSpecTasksHttp? Http { get; set; }

    [JsonPropertyName("initContainers")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksInitContainers>? InitContainers { get; set; }

    [JsonPropertyName("inputs")]
    public V1alpha1WorkflowTaskSetSpecTasksInputs? Inputs { get; set; }

    [JsonPropertyName("memoize")]
    public V1alpha1WorkflowTaskSetSpecTasksMemoize? Memoize { get; set; }

    [JsonPropertyName("metadata")]
    public V1alpha1WorkflowTaskSetSpecTasksMetadata? Metadata { get; set; }

    [JsonPropertyName("metrics")]
    public V1alpha1WorkflowTaskSetSpecTasksMetrics? Metrics { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    [JsonPropertyName("outputs")]
    public V1alpha1WorkflowTaskSetSpecTasksOutputs? Outputs { get; set; }

    [JsonPropertyName("parallelism")]
    public long? Parallelism { get; set; }

    [JsonPropertyName("plugin")]
    public JsonNode? Plugin { get; set; }

    [JsonPropertyName("podSpecPatch")]
    public string? PodSpecPatch { get; set; }

    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    [JsonPropertyName("resource")]
    public V1alpha1WorkflowTaskSetSpecTasksResource? Resource { get; set; }

    [JsonPropertyName("retryStrategy")]
    public V1alpha1WorkflowTaskSetSpecTasksRetryStrategy? RetryStrategy { get; set; }

    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    [JsonPropertyName("script")]
    public V1alpha1WorkflowTaskSetSpecTasksScript? Script { get; set; }

    [JsonPropertyName("securityContext")]
    public V1alpha1WorkflowTaskSetSpecTasksSecurityContext? SecurityContext { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("sidecars")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSidecars>? Sidecars { get; set; }

    [JsonPropertyName("steps")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksSteps>? Steps { get; set; }

    [JsonPropertyName("suspend")]
    public V1alpha1WorkflowTaskSetSpecTasksSuspend? Suspend { get; set; }

    [JsonPropertyName("synchronization")]
    public V1alpha1WorkflowTaskSetSpecTasksSynchronization? Synchronization { get; set; }

    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    [JsonPropertyName("tolerations")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksTolerations>? Tolerations { get; set; }

    [JsonPropertyName("volumes")]
    public IList<V1alpha1WorkflowTaskSetSpecTasksVolumes>? Volumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetSpec
{
    [JsonPropertyName("tasks")]
    public IDictionary<string, V1alpha1WorkflowTaskSetSpecTasks>? Tasks { get; set; }
}

/// <summary>
/// NoneStrategy indicates to skip tar process and upload the files or directory tree as independent
/// files. Note that if the artifact is a directory, the artifact driver must support the ability to
/// save/load the directory appropriately.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArchiveNone
{
}

/// <summary>TarStrategy will tar and gzip the file or directory when saving</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArchiveTar
{
    /// <summary>
    /// CompressionLevel specifies the gzip compression level to use for the artifact.
    /// Defaults to gzip.DefaultCompression.
    /// </summary>
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

/// <summary>ZipStrategy will unzip zipped input artifacts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArchiveZip
{
}

/// <summary>Archive controls how the artifact will be saved to the artifact repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArchive
{
    /// <summary>
    /// NoneStrategy indicates to skip tar process and upload the files or directory tree as independent
    /// files. Note that if the artifact is a directory, the artifact driver must support the ability to
    /// save/load the directory appropriately.
    /// </summary>
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArchiveNone? None { get; set; }

    /// <summary>TarStrategy will tar and gzip the file or directory when saving</summary>
    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArchiveTar? Tar { get; set; }

    /// <summary>ZipStrategy will unzip zipped input artifacts</summary>
    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArchiveZip? Zip { get; set; }
}

/// <summary>PodMetadata is an optional field for specifying the Labels and Annotations that should be assigned to the Pod doing the deletion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>ArtifactGC describes the strategy to use when to deleting an artifact from completed or deleted workflows</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactGC
{
    /// <summary>PodMetadata is an optional field for specifying the Labels and Annotations that should be assigned to the Pod doing the deletion</summary>
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    /// <summary>ServiceAccountName is an optional field for specifying the Service Account that should be assigned to the Pod doing the deletion</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>Strategy is the strategy to use.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary>PasswordSecret is the secret selector to the repository password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactoryPasswordSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>UsernameSecret is the secret selector to the repository username</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactoryUsernameSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Artifactory contains artifactory artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactory
{
    /// <summary>PasswordSecret is the secret selector to the repository password</summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    /// <summary>URL of the artifact</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>UsernameSecret is the secret selector to the repository username</summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

/// <summary>AccountKeySecret is the secret selector to the Azure Blob Storage account access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsAzureAccountKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Azure contains Azure Storage artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsAzure
{
    /// <summary>AccountKeySecret is the secret selector to the Azure Blob Storage account access key</summary>
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    /// <summary>Blob is the blob name (i.e., path) in the container where the artifact resides</summary>
    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    /// <summary>Container is the container where resources will be stored</summary>
    [JsonPropertyName("container")]
    public required string Container { get; set; }

    /// <summary>Endpoint is the service url associated with an account. It is most likely &quot;https://&lt;ACCOUNT_NAME&gt;.blob.core.windows.net&quot;</summary>
    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    /// <summary>UseSDKCreds tells the driver to figure out credentials based on sdk defaults.</summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary>ServiceAccountKeySecret is the secret selector to the bucket&apos;s service account key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGcsServiceAccountKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>GCS contains GCS artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGcs
{
    /// <summary>Bucket is the name of the bucket</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Key is the path in the bucket where the artifact resides</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>ServiceAccountKeySecret is the secret selector to the bucket&apos;s service account key</summary>
    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

/// <summary>PasswordSecret is the secret selector to the repository password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGitPasswordSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>SSHPrivateKeySecret is the secret selector to the repository ssh private key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGitSshPrivateKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>UsernameSecret is the secret selector to the repository username</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGitUsernameSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Git contains git artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGit
{
    /// <summary>Branch is the branch to fetch when `SingleBranch` is enabled</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Depth specifies clones/fetches should be shallow and include the given
    /// number of commits from the branch tip
    /// </summary>
    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    /// <summary>DisableSubmodules disables submodules during git clone</summary>
    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    /// <summary>Fetch specifies a number of refs that should be fetched before checkout</summary>
    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    /// <summary>InsecureIgnoreHostKey disables SSH strict host key checking during git clone</summary>
    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    /// <summary>InsecureSkipTLS disables server certificate verification resulting in insecure HTTPS connections</summary>
    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    /// <summary>PasswordSecret is the secret selector to the repository password</summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    /// <summary>Repo is the git repository</summary>
    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    /// <summary>Revision is the git commit, tag, branch to checkout</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>SingleBranch enables single branch clone, using the `branch` parameter</summary>
    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    /// <summary>SSHPrivateKeySecret is the secret selector to the repository ssh private key</summary>
    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    /// <summary>UsernameSecret is the secret selector to the repository username</summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

/// <summary>
/// KrbCCacheSecret is the secret selector for Kerberos ccache
/// Either ccache or keytab can be set to use Kerberos.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHdfsKrbCCacheSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// KrbConfig is the configmap selector for Kerberos config as string
/// It must be set if either ccache or keytab is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHdfsKrbConfigConfigMap
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// KrbKeytabSecret is the secret selector for Kerberos keytab
/// Either ccache or keytab can be set to use Kerberos.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHdfsKrbKeytabSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>HDFS contains HDFS artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHdfs
{
    /// <summary>Addresses is accessible addresses of HDFS name nodes</summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    /// <summary>
    /// DataTransferProtection is the protection level for HDFS data transfer.
    /// It corresponds to the dfs.data.transfer.protection configuration in HDFS.
    /// </summary>
    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    /// <summary>Force copies a file forcibly even if it exists</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>
    /// HDFSUser is the user to access HDFS file system.
    /// It is ignored if either ccache or keytab is used.
    /// </summary>
    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    /// <summary>
    /// KrbCCacheSecret is the secret selector for Kerberos ccache
    /// Either ccache or keytab can be set to use Kerberos.
    /// </summary>
    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    /// <summary>
    /// KrbConfig is the configmap selector for Kerberos config as string
    /// It must be set if either ccache or keytab is used.
    /// </summary>
    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    /// <summary>
    /// KrbKeytabSecret is the secret selector for Kerberos keytab
    /// Either ccache or keytab can be set to use Kerberos.
    /// </summary>
    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    /// <summary>
    /// KrbRealm is the Kerberos realm used with Kerberos keytab
    /// It must be set if keytab is used.
    /// </summary>
    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    /// <summary>
    /// KrbServicePrincipalName is the principal name of Kerberos service
    /// It must be set if either ccache or keytab is used.
    /// </summary>
    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    /// <summary>
    /// KrbUsername is the Kerberos username used with Kerberos keytab
    /// It must be set if keytab is used.
    /// </summary>
    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    /// <summary>Path is a file path in HDFS</summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

/// <summary>PasswordSecret is the secret selector to the repository password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthBasicAuthPasswordSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>UsernameSecret is the secret selector to the repository username</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthBasicAuthUsernameSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>BasicAuth describes the secret selectors required for basic authentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthBasicAuth
{
    /// <summary>PasswordSecret is the secret selector to the repository password</summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    /// <summary>UsernameSecret is the secret selector to the repository username</summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthClientCertClientCertSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthClientCertClientKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ClientCertAuth holds necessary information for client authentication via certificates</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthClientCert
{
    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2ClientIDSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2ClientSecretSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>EndpointParam is for requesting optional fields that should be sent in the oauth request</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2EndpointParams
{
    /// <summary>Name is the header name</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the literal value to use for the header</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2TokenURLSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>OAuth2Auth holds all information for client authentication via OAuth2 tokens</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2
{
    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

/// <summary>Auth contains information for client authentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuth
{
    /// <summary>BasicAuth describes the secret selectors required for basic authentication</summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    /// <summary>ClientCertAuth holds necessary information for client authentication via certificates</summary>
    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    /// <summary>OAuth2Auth holds all information for client authentication via OAuth2 tokens</summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

/// <summary>Header indicate a key-value request header to be used when fetching artifacts over HTTP</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpHeaders
{
    /// <summary>Name is the header name</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the literal value to use for the header</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>HTTP contains HTTP artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttp
{
    /// <summary>Auth contains information for client authentication</summary>
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpAuth? Auth { get; set; }

    /// <summary>Headers are an optional list of headers to send with HTTP requests for artifacts</summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttpHeaders>? Headers { get; set; }

    /// <summary>URL of the artifact</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>AccessKeySecret is the secret selector to the bucket&apos;s access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsOssAccessKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>LifecycleRule specifies how to manage bucket&apos;s lifecycle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsOssLifecycleRule
{
    /// <summary>MarkDeletionAfterDays is the number of days before we delete objects in the bucket</summary>
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    /// <summary>MarkInfrequentAccessAfterDays is the number of days before we convert the objects in the bucket to Infrequent Access (IA) storage type</summary>
    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

/// <summary>SecretKeySecret is the secret selector to the bucket&apos;s secret key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsOssSecretKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>OSS contains OSS artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsOss
{
    /// <summary>AccessKeySecret is the secret selector to the bucket&apos;s access key</summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    /// <summary>Bucket is the name of the bucket</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>CreateBucketIfNotPresent tells the driver to attempt to create the OSS bucket for output artifacts, if it doesn&apos;t exist</summary>
    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    /// <summary>Endpoint is the hostname of the bucket endpoint</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Key is the path in the bucket where the artifact resides</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>LifecycleRule specifies how to manage bucket&apos;s lifecycle</summary>
    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    /// <summary>SecretKeySecret is the secret selector to the bucket&apos;s secret key</summary>
    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    /// <summary>SecurityToken is the user&apos;s temporary security token. For more details, check out: https://www.alibabacloud.com/help/doc-detail/100624.htm</summary>
    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    /// <summary>UseSDKCreds tells the driver to figure out credentials based on sdk defaults.</summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary>Plugin contains plugin artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsPlugin
{
    /// <summary>Configuration is the plugin defined configuration for the artifact driver plugin</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>ConnectionTimeoutSeconds is the timeout for the artifact driver connection, overriding the driver&apos;s timeout</summary>
    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    /// <summary>Key is the path in the artifact repository where the artifact resides</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name is the name of the artifact driver plugin</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Raw contains raw artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsRaw
{
    /// <summary>Data is the string contents of the artifact</summary>
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

/// <summary>AccessKeySecret is the secret selector to the bucket&apos;s access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3AccessKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>CASecret specifies the secret that contains the CA, used to verify the TLS connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3CaSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>CreateBucketIfNotPresent tells the driver to attempt to create the S3 bucket for output artifacts, if it doesn&apos;t exist. Setting Enabled Encryption will apply either SSE-S3 to the bucket if KmsKeyId is not set or SSE-KMS if it is.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3CreateBucketIfNotPresent
{
    /// <summary>ObjectLocking Enable object locking</summary>
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

/// <summary>ServerSideCustomerKeySecret tells the driver to encrypt the output artifacts using SSE-C with the specified secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>S3EncryptionOptions used to determine encryption options during s3 operations</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3EncryptionOptions
{
    /// <summary>EnableEncryption tells the driver to encrypt objects if set to true. If kmsKeyId and serverSideCustomerKeySecret are not set, SSE-S3 will be used</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>KmsEncryptionContext is a json blob that contains an encryption context. See https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context for more information</summary>
    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    /// <summary>KMSKeyId tells the driver to encrypt the object using the specified KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>ServerSideCustomerKeySecret tells the driver to encrypt the output artifacts using SSE-C with the specified secret.</summary>
    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

/// <summary>SecretKeySecret is the secret selector to the bucket&apos;s secret key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3SecretKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>SessionTokenSecret is used for ephemeral credentials like an IAM assume role or S3 access grant</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3SessionTokenSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>S3 contains S3 artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3
{
    /// <summary>AccessKeySecret is the secret selector to the bucket&apos;s access key</summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    /// <summary>Bucket is the name of the bucket</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>CASecret specifies the secret that contains the CA, used to verify the TLS connection</summary>
    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3CaSecret? CaSecret { get; set; }

    /// <summary>CreateBucketIfNotPresent tells the driver to attempt to create the S3 bucket for output artifacts, if it doesn&apos;t exist. Setting Enabled Encryption will apply either SSE-S3 to the bucket if KmsKeyId is not set or SSE-KMS if it is.</summary>
    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    /// <summary>S3EncryptionOptions used to determine encryption options during s3 operations</summary>
    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    /// <summary>Endpoint is the hostname of the bucket endpoint</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Insecure will connect to the service with TLS</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>Key is the key in the bucket where the artifact resides</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Region contains the optional bucket region</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>RoleARN is the Amazon Resource Name (ARN) of the role to assume.</summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>SecretKeySecret is the secret selector to the bucket&apos;s secret key</summary>
    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    /// <summary>SessionTokenSecret is used for ephemeral credentials like an IAM assume role or S3 access grant</summary>
    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    /// <summary>UseSDKCreds tells the driver to figure out credentials based on sdk defaults.</summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary>Artifact indicates an artifact to place at a specified path</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsArtifacts
{
    /// <summary>Archive controls how the artifact will be saved to the artifact repository.</summary>
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArchive? Archive { get; set; }

    /// <summary>ArchiveLogs indicates if the container logs should be archived</summary>
    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    /// <summary>ArtifactGC describes the strategy to use when to deleting an artifact from completed or deleted workflows</summary>
    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactGC? ArtifactGC { get; set; }

    /// <summary>Artifactory contains artifactory artifact location details</summary>
    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsArtifactory? Artifactory { get; set; }

    /// <summary>Azure contains Azure Storage artifact location details</summary>
    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsAzure? Azure { get; set; }

    /// <summary>Has this been deleted?</summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>From allows an artifact to reference an artifact from a previous step</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>FromExpression, if defined, is evaluated to specify the value for the artifact</summary>
    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    /// <summary>GCS contains GCS artifact location details</summary>
    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGcs? Gcs { get; set; }

    /// <summary>Git contains git artifact location details</summary>
    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsGit? Git { get; set; }

    /// <summary>
    /// GlobalName exports an output artifact to the global scope, making it available as
    /// workflow.outputs.artifacts.XXXX and in workflow.status.outputs.artifacts
    /// </summary>
    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    /// <summary>HDFS contains HDFS artifact location details</summary>
    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHdfs? Hdfs { get; set; }

    /// <summary>HTTP contains HTTP artifact location details</summary>
    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsHttp? Http { get; set; }

    /// <summary>
    /// mode bits to use on this file, must be a value between 0 and 0777.
    /// Set when loading input artifacts. It is recommended to set the mode value
    /// to ensure the artifact has the expected permissions in your container.
    /// </summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>name of the artifact. must be unique within a template&apos;s inputs/outputs.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Make Artifacts optional, if Artifacts doesn&apos;t generate or exist</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>OSS contains OSS artifact location details</summary>
    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsOss? Oss { get; set; }

    /// <summary>Path is the container path to the artifact</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin contains plugin artifact location details</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsPlugin? Plugin { get; set; }

    /// <summary>Raw contains raw artifact location details</summary>
    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsRaw? Raw { get; set; }

    /// <summary>If mode is set, apply the permission recursively into the artifact if it is a folder</summary>
    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    /// <summary>S3 contains S3 artifact location details</summary>
    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsArtifactsS3? S3 { get; set; }

    /// <summary>SubPath allows an artifact to be sourced from a subpath within the specified source</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary>ConfigMapKeyRef is configmap selector for input parameter configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsParametersValueFromConfigMapKeyRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Supplied value to be filled in directly, either through the CLI, API, etc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsParametersValueFromSupplied
{
}

/// <summary>ValueFrom is the source for the output parameter&apos;s value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsParametersValueFrom
{
    /// <summary>ConfigMapKeyRef is configmap selector for input parameter configuration</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>Default specifies a value to be used if retrieving the value from the specified source fails</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>Selector (https://github.com/expr-lang/expr) that is evaluated against the event to get the value of the parameter. E.g. `payload.message`</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>Expression, if defined, is evaluated to specify the value for the parameter</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>JQFilter expression against the resource object in resource templates</summary>
    [JsonPropertyName("jqFilter")]
    public string? JqFilter { get; set; }

    /// <summary>JSONPath of a resource to retrieve an output parameter value from in resource templates</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    /// <summary>
    /// Parameter reference to a step or dag task in which to retrieve an output parameter value from
    /// (e.g. steps.mystep.outputs.myparam)
    /// </summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>Path in the container to retrieve an output parameter value from in container templates</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Supplied value to be filled in directly, either through the CLI, API, etc.</summary>
    [JsonPropertyName("supplied")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsParametersValueFromSupplied? Supplied { get; set; }
}

/// <summary>Parameter indicate a passed string parameter to a service template with an optional default value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputsParameters
{
    /// <summary>Default is the default value to use for an input parameter if a value was not supplied</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>Description is the parameter description</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enum holds a list of string values to choose from, for the actual value of the parameter</summary>
    [JsonPropertyName("enum")]
    public IList<string>? Enum { get; set; }

    /// <summary>
    /// GlobalName exports an output parameter to the global scope, making it available as
    /// workflow.outputs.parameters.XXXX and in workflow.status.outputs.parameters
    /// </summary>
    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    /// <summary>Name is the parameter name</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is the literal value to use for the parameter.
    /// If specified in the context of an input parameter, any passed values take precedence over the specified value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFrom is the source for the output parameter&apos;s value</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputsParametersValueFrom? ValueFrom { get; set; }
}

/// <summary>Outputs hold parameters, artifacts, and results from a step</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodesOutputs
{
    /// <summary>Artifacts holds the list of output artifacts produced by a step</summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowTaskSetStatusNodesOutputsArtifacts>? Artifacts { get; set; }

    /// <summary>ExitCode holds the exit code of a script template</summary>
    [JsonPropertyName("exitCode")]
    public string? ExitCode { get; set; }

    /// <summary>Parameters holds the list of output parameters produced by a step</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowTaskSetStatusNodesOutputsParameters>? Parameters { get; set; }

    /// <summary>Result holds the result (stdout) of a script or container template, or the response body of an HTTP template</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatusNodes
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Outputs hold parameters, artifacts, and results from a step</summary>
    [JsonPropertyName("outputs")]
    public V1alpha1WorkflowTaskSetStatusNodesOutputs? Outputs { get; set; }

    /// <summary>NodePhase is a label for the condition of a node at the current time.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>Progress in N/M format. N is number of task complete. M is number of tasks.</summary>
    [JsonPropertyName("progress")]
    public string? Progress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskSetStatus
{
    [JsonPropertyName("nodes")]
    public IDictionary<string, V1alpha1WorkflowTaskSetStatusNodes>? Nodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowTaskSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WorkflowTaskSetSpec>, IStatus<V1alpha1WorkflowTaskSetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowTaskSet";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workflowtasksets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkflowTaskSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1WorkflowTaskSetSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1WorkflowTaskSetStatus? Status { get; set; }
}