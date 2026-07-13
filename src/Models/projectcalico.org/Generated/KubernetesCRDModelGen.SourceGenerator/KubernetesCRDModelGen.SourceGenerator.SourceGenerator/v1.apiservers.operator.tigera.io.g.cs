#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.@operator.tigera.io;
/// <summary>
/// APIServer installs the Tigera API server and related resources. At most one instance
/// of this resource is supported. It must be named &quot;default&quot; or &quot;tigera-secure&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1APIServerList : IKubernetesObject<V1ListMeta>, IItems<V1APIServer>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "APIServerList";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "apiservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIServerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1APIServer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1APIServer> Items { get; set; }
}

/// <summary>Metadata is a subset of a Kubernetes object&apos;s metadata that is added to the Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentMetadata
{
    /// <summary>
    /// Annotations is a map of arbitrary non-identifying metadata. Each of these
    /// key/value pairs are added to the object&apos;s annotations provided the key does not
    /// already exist in the object&apos;s annotations.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Labels is a map of string keys and values that may match replicaset and
    /// service selectors. Each of these key/value pairs are added to the
    /// object&apos;s labels provided the key does not already exist in the object&apos;s labels.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// Metadata is a subset of a Kubernetes object&apos;s metadata that is added to
/// the pod&apos;s metadata.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateMetadata
{
    /// <summary>
    /// Annotations is a map of arbitrary non-identifying metadata. Each of these
    /// key/value pairs are added to the object&apos;s annotations provided the key does not
    /// already exist in the object&apos;s annotations.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Labels is a map of string keys and values that may match replicaset and
    /// service selectors. Each of these key/value pairs are added to the
    /// object&apos;s labels provided the key does not already exist in the object&apos;s labels.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0
/// (i.e. it&apos;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public required V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A null or empty node selector term matches no objects. The requirements of
/// them are ANDed.
/// The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// If the affinity requirements specified by this field are not met at
/// scheduling time, the pod will not be scheduled onto the node.
/// If the affinity requirements specified by this field cease to be met
/// at some point during pod execution (e.g. due to an update), the system
/// may or may not try to eventually evict the pod from its node.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and adding
    /// &quot;weight&quot; to the sum if the node matches the corresponding matchExpressions; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to an update), the system
    /// may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm,
    /// in the range 1-100.
    /// </summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Defines a set of pods (namely those matching the labelSelector
/// relative to the given namespace(s)) that this pod should be
/// co-located (affinity) or not co-located (anti-affinity) with,
/// where co-located is defined as running on a node whose value of
/// the label with key &lt;topologyKey&gt; matches that of any node on which
/// a pod of the set of pods is running
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and adding
    /// &quot;weight&quot; to the sum if the node has pods which matches the corresponding podAffinityTerm; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to a pod label update), the
    /// system may or may not try to eventually evict the pod from its node.
    /// When there are multiple elements, the lists of nodes corresponding to each
    /// podAffinityTerm are intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm,
    /// in the range 1-100.
    /// </summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Defines a set of pods (namely those matching the labelSelector
/// relative to the given namespace(s)) that this pod should be
/// co-located (affinity) or not co-located (anti-affinity) with,
/// where co-located is defined as running on a node whose value of
/// the label with key &lt;topologyKey&gt; matches that of any node on which
/// a pod of the set of pods is running
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the anti-affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling anti-affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and subtracting
    /// &quot;weight&quot; from the sum if the node has pods which matches the corresponding podAffinityTerm; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the anti-affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the anti-affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to a pod label update), the
    /// system may or may not try to eventually evict the pod from its node.
    /// When there are multiple elements, the lists of nodes corresponding to each
    /// podAffinityTerm are intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// Affinity is a group of affinity scheduling rules for the API server pods.
/// If specified, this overrides any affinity that may be set on the API server Deployment.
/// If omitted, the API server Deployment will use its default value for affinity.
/// WARNING: Please note that this field will override the default API server Deployment affinity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary>
/// Name is an enum which identifies the API server Deployment container by name.
/// Supported values are: calico-apiserver, tigera-queryserver, calico-l7-admission-controller
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersNameEnum>))]
public enum V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersNameEnum
{
    [EnumMember(Value = "calico-apiserver"), JsonStringEnumMemberName("calico-apiserver")]
    CalicoApiserver,
    [EnumMember(Value = "tigera-queryserver"), JsonStringEnumMemberName("tigera-queryserver")]
    TigeraQueryserver,
    [EnumMember(Value = "calico-l7-admission-controller"), JsonStringEnumMemberName("calico-l7-admission-controller")]
    CalicoL7AdmissionController
}

/// <summary>
/// Name is an enum which identifies the API server Deployment Container port by name.
/// Supported values are: apiserver, queryserver, l7admctrl
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersPortsNameEnum>))]
public enum V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersPortsNameEnum
{
    [EnumMember(Value = "apiserver"), JsonStringEnumMemberName("apiserver")]
    Apiserver,
    [EnumMember(Value = "queryserver"), JsonStringEnumMemberName("queryserver")]
    Queryserver,
    [EnumMember(Value = "l7admctrl"), JsonStringEnumMemberName("l7admctrl")]
    L7admctrl
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersPorts
{
    /// <summary>
    /// Number of port to expose on the pod&apos;s IP address.
    /// This must be a valid port number, 0 &lt; x &lt; 65536.
    /// </summary>
    [JsonPropertyName("containerPort")]
    public required int ContainerPort { get; set; }

    /// <summary>
    /// Name is an enum which identifies the API server Deployment Container port by name.
    /// Supported values are: apiserver, queryserver, l7admctrl
    /// </summary>
    [JsonPropertyName("name")]
    public required V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersPortsNameEnum Name { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersResourcesClaims
{
    /// <summary>
    /// Name must match the name of one entry in pod.spec.resourceClaims of
    /// the Pod where this field is used. It makes that resource available
    /// inside a container.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Request is the name chosen for a request in the referenced claim.
    /// If empty, everything from the claim is made available, otherwise
    /// only the result of this request.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>
/// Resources allows customization of limits and requests for compute resources such as cpu and memory.
/// If specified, this overrides the named API server Deployment container&apos;s resources.
/// If omitted, the API server Deployment will use its default value for this container&apos;s resources.
/// If used in conjunction with the deprecated ComponentResources, then this value takes precedence.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,
    /// otherwise to an implementation-defined value. Requests cannot exceed Limits.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>APIServerDeploymentContainer is an API server Deployment container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainers
{
    /// <summary>
    /// Name is an enum which identifies the API server Deployment container by name.
    /// Supported values are: calico-apiserver, tigera-queryserver, calico-l7-admission-controller
    /// </summary>
    [JsonPropertyName("name")]
    public required V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersNameEnum Name { get; set; }

    /// <summary>
    /// Ports allows customization of container&apos;s ports.
    /// If specified, this overrides the named APIServer Deployment container&apos;s ports.
    /// If omitted, the API server Deployment will use its default value for this container&apos;s port.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>
    /// Resources allows customization of limits and requests for compute resources such as cpu and memory.
    /// If specified, this overrides the named API server Deployment container&apos;s resources.
    /// If omitted, the API server Deployment will use its default value for this container&apos;s resources.
    /// If used in conjunction with the deprecated ComponentResources, then this value takes precedence.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainersResources? Resources { get; set; }
}

/// <summary>
/// Name is an enum which identifies the API server Deployment init container by name.
/// Supported values are: calico-apiserver-certs-key-cert-provisioner
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1APIServerSpecApiServerDeploymentSpecTemplateSpecInitContainersNameEnum>))]
public enum V1APIServerSpecApiServerDeploymentSpecTemplateSpecInitContainersNameEnum
{
    [EnumMember(Value = "calico-apiserver-certs-key-cert-provisioner"), JsonStringEnumMemberName("calico-apiserver-certs-key-cert-provisioner")]
    CalicoApiserverCertsKeyCertProvisioner
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecInitContainersResourcesClaims
{
    /// <summary>
    /// Name must match the name of one entry in pod.spec.resourceClaims of
    /// the Pod where this field is used. It makes that resource available
    /// inside a container.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Request is the name chosen for a request in the referenced claim.
    /// If empty, everything from the claim is made available, otherwise
    /// only the result of this request.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>
/// Resources allows customization of limits and requests for compute resources such as cpu and memory.
/// If specified, this overrides the named API server Deployment init container&apos;s resources.
/// If omitted, the API server Deployment will use its default value for this init container&apos;s resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecInitContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,
    /// otherwise to an implementation-defined value. Requests cannot exceed Limits.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>APIServerDeploymentInitContainer is an API server Deployment init container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecInitContainers
{
    /// <summary>
    /// Name is an enum which identifies the API server Deployment init container by name.
    /// Supported values are: calico-apiserver-certs-key-cert-provisioner
    /// </summary>
    [JsonPropertyName("name")]
    public required V1APIServerSpecApiServerDeploymentSpecTemplateSpecInitContainersNameEnum Name { get; set; }

    /// <summary>
    /// Resources allows customization of limits and requests for compute resources such as cpu and memory.
    /// If specified, this overrides the named API server Deployment init container&apos;s resources.
    /// If omitted, the API server Deployment will use its default value for this init container&apos;s resources.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecInitContainersResources? Resources { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches
/// the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecTolerations
{
    /// <summary>
    /// Effect indicates the taint effect to match. Empty means match all taint effects.
    /// When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
    /// </summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>
    /// Key is the taint key that the toleration applies to. Empty means match all taint keys.
    /// If the key is empty, operator must be Exists; this combination means to match all values and all keys.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Operator represents a key&apos;s relationship to the value.
    /// Valid operators are Exists, Equal, Lt, and Gt. Defaults to Equal.
    /// Exists is equivalent to wildcard for value, so that a pod can
    /// tolerate all taints of a particular category.
    /// Lt and Gt perform numeric comparisons (requires feature gate TaintTolerationComparisonOperators).
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// TolerationSeconds represents the period of time the toleration (which must be
    /// of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default,
    /// it is not set, which means tolerate the taint forever (do not evict). Zero and
    /// negative values will be treated as 0 (evict immediately) by the system.
    /// </summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary>
    /// Value is the taint value the toleration matches to.
    /// If the operator is Exists, the value should be empty, otherwise just a regular string.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// LabelSelector is used to find matching pods.
/// Pods that match this label selector are counted to determine the number of pods
/// in their corresponding topology domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>TopologySpreadConstraint specifies how to spread matching pods among the given topology.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary>
    /// LabelSelector is used to find matching pods.
    /// Pods that match this label selector are counted to determine the number of pods
    /// in their corresponding topology domain.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select the pods over which
    /// spreading will be calculated. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are ANDed with labelSelector
    /// to select the group of existing pods over which spreading will be calculated
    /// for the incoming pod. The same key is forbidden to exist in both MatchLabelKeys and LabelSelector.
    /// MatchLabelKeys cannot be set when LabelSelector isn&apos;t set.
    /// Keys that don&apos;t exist in the incoming pod labels will
    /// be ignored. A null or empty list means only match against labelSelector.
    /// This is a beta field and requires the MatchLabelKeysInPodTopologySpread feature gate to be enabled (enabled by default).
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MaxSkew describes the degree to which pods may be unevenly distributed.
    /// When `whenUnsatisfiable=DoNotSchedule`, it is the maximum permitted difference
    /// between the number of matching pods in the target topology and the global minimum.
    /// The global minimum is the minimum number of matching pods in an eligible domain
    /// or zero if the number of eligible domains is less than MinDomains.
    /// For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same
    /// labelSelector spread as 2/2/1:
    /// In this case, the global minimum is 1.
    /// | zone1 | zone2 | zone3 |
    /// |  P P  |  P P  |   P   |
    /// - if MaxSkew is 1, incoming pod can only be scheduled to zone3 to become 2/2/2;
    /// scheduling it onto zone1(zone2) would make the ActualSkew(3-1) on zone1(zone2)
    /// violate MaxSkew(1).
    /// - if MaxSkew is 2, incoming pod can be scheduled onto any zone.
    /// When `whenUnsatisfiable=ScheduleAnyway`, it is used to give higher precedence
    /// to topologies that satisfy it.
    /// It&apos;s a required field. Default value is 1 and 0 is not allowed.
    /// </summary>
    [JsonPropertyName("maxSkew")]
    public required int MaxSkew { get; set; }

    /// <summary>
    /// MinDomains indicates a minimum number of eligible domains.
    /// When the number of eligible domains with matching topology keys is less than minDomains,
    /// Pod Topology Spread treats &quot;global minimum&quot; as 0, and then the calculation of Skew is performed.
    /// And when the number of eligible domains with matching topology keys equals or greater than minDomains,
    /// this value has no effect on scheduling.
    /// As a result, when the number of eligible domains is less than minDomains,
    /// scheduler won&apos;t schedule more than maxSkew Pods to those domains.
    /// If value is nil, the constraint behaves as if MinDomains is equal to 1.
    /// Valid values are integers greater than 0.
    /// When value is not nil, WhenUnsatisfiable must be DoNotSchedule.
    /// For example, in a 3-zone cluster, MaxSkew is set to 2, MinDomains is set to 5 and pods with the same
    /// labelSelector spread as 2/2/2:
    /// | zone1 | zone2 | zone3 |
    /// |  P P  |  P P  |  P P  |
    /// The number of domains is less than 5(MinDomains), so &quot;global minimum&quot; is treated as 0.
    /// In this situation, new pod with the same labelSelector cannot be scheduled,
    /// because computed skew will be 3(3 - 0) if new Pod is scheduled to any of the three zones,
    /// it will violate MaxSkew.
    /// </summary>
    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    /// <summary>
    /// NodeAffinityPolicy indicates how we will treat Pod&apos;s nodeAffinity/nodeSelector
    /// when calculating pod topology spread skew. Options are:
    /// - Honor: only nodes matching nodeAffinity/nodeSelector are included in the calculations.
    /// - Ignore: nodeAffinity/nodeSelector are ignored. All nodes are included in the calculations.
    /// If this value is nil, the behavior is equivalent to the Honor policy.
    /// </summary>
    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    /// <summary>
    /// NodeTaintsPolicy indicates how we will treat node taints when calculating
    /// pod topology spread skew. Options are:
    /// - Honor: nodes without taints, along with tainted nodes for which the incoming pod
    /// has a toleration, are included.
    /// - Ignore: node taints are ignored. All nodes are included.
    /// If this value is nil, the behavior is equivalent to the Ignore policy.
    /// </summary>
    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    /// <summary>
    /// TopologyKey is the key of node labels. Nodes that have a label with this key
    /// and identical values are considered to be in the same topology.
    /// We consider each &lt;key, value&gt; as a &quot;bucket&quot;, and try to put balanced number
    /// of pods into each bucket.
    /// We define a domain as a particular instance of a topology.
    /// Also, we define an eligible domain as a domain whose nodes meet the requirements of
    /// nodeAffinityPolicy and nodeTaintsPolicy.
    /// e.g. If TopologyKey is &quot;kubernetes.io/hostname&quot;, each Node is a domain of that topology.
    /// And, if TopologyKey is &quot;topology.kubernetes.io/zone&quot;, each zone is a domain of that topology.
    /// It&apos;s a required field.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }

    /// <summary>
    /// WhenUnsatisfiable indicates how to deal with a pod if it doesn&apos;t satisfy
    /// the spread constraint.
    /// - DoNotSchedule (default) tells the scheduler not to schedule it.
    /// - ScheduleAnyway tells the scheduler to schedule the pod in any location,
    ///   but giving higher precedence to topologies that would help reduce the
    ///   skew.
    /// A constraint is considered &quot;Unsatisfiable&quot; for an incoming pod
    /// if and only if every possible node assignment for that pod would violate
    /// &quot;MaxSkew&quot; on some topology.
    /// For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same
    /// labelSelector spread as 3/1/1:
    /// | zone1 | zone2 | zone3 |
    /// | P P P |   P   |   P   |
    /// If WhenUnsatisfiable is set to DoNotSchedule, incoming pod can only be scheduled
    /// to zone2(zone3) to become 3/2/1(3/1/2) as ActualSkew(2-1) on zone2(zone3) satisfies
    /// MaxSkew(1). In other words, the cluster can still be imbalanced, but scheduler
    /// won&apos;t make it *more* imbalanced.
    /// It&apos;s a required field.
    /// </summary>
    [JsonPropertyName("whenUnsatisfiable")]
    public required string WhenUnsatisfiable { get; set; }
}

/// <summary>Spec is the API server Deployment&apos;s PodSpec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplateSpec
{
    /// <summary>
    /// Affinity is a group of affinity scheduling rules for the API server pods.
    /// If specified, this overrides any affinity that may be set on the API server Deployment.
    /// If omitted, the API server Deployment will use its default value for affinity.
    /// WARNING: Please note that this field will override the default API server Deployment affinity.
    /// </summary>
    [JsonPropertyName("affinity")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpecAffinity? Affinity { get; set; }

    /// <summary>
    /// Containers is a list of API server containers.
    /// If specified, this overrides the specified API server Deployment containers.
    /// If omitted, the API server Deployment will use its default values for its containers.
    /// </summary>
    [JsonPropertyName("containers")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecContainers>? Containers { get; set; }

    /// <summary>
    /// InitContainers is a list of API server init containers.
    /// If specified, this overrides the specified API server Deployment init containers.
    /// If omitted, the API server Deployment will use its default values for its init containers.
    /// </summary>
    [JsonPropertyName("initContainers")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    /// <summary>
    /// NodeSelector is the API server pod&apos;s scheduling constraints.
    /// If specified, each of the key/value pairs are added to the API server Deployment nodeSelector provided
    /// the key does not already exist in the object&apos;s nodeSelector.
    /// If used in conjunction with ControlPlaneNodeSelector, that nodeSelector is set on the API server Deployment
    /// and each of this field&apos;s key/value pairs are added to the API server Deployment nodeSelector provided
    /// the key does not already exist in the object&apos;s nodeSelector.
    /// If omitted, the API server Deployment will use its default value for nodeSelector.
    /// WARNING: Please note that this field will modify the default API server Deployment nodeSelector.
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>PriorityClassName allows to specify a PriorityClass resource to be used.</summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>
    /// Tolerations is the API server pod&apos;s tolerations.
    /// If specified, this overrides any tolerations that may be set on the API server Deployment.
    /// If omitted, the API server Deployment will use its default value for tolerations.
    /// WARNING: Please note that this field will override the default API server Deployment tolerations.
    /// </summary>
    [JsonPropertyName("tolerations")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary>
    /// TopologySpreadConstraints describes how a group of pods ought to spread across topology
    /// domains. Scheduler will schedule pods in a way which abides by the constraints.
    /// All topologySpreadConstraints are ANDed.
    /// </summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1APIServerSpecApiServerDeploymentSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }
}

/// <summary>Template describes the API server Deployment pod that will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpecTemplate
{
    /// <summary>
    /// Metadata is a subset of a Kubernetes object&apos;s metadata that is added to
    /// the pod&apos;s metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateMetadata? Metadata { get; set; }

    /// <summary>Spec is the API server Deployment&apos;s PodSpec.</summary>
    [JsonPropertyName("spec")]
    public V1APIServerSpecApiServerDeploymentSpecTemplateSpec? Spec { get; set; }
}

/// <summary>Spec is the specification of the API server Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeploymentSpec
{
    /// <summary>
    /// MinReadySeconds is the minimum number of seconds for which a newly created Deployment pod should
    /// be ready without any of its container crashing, for it to be considered available.
    /// If specified, this overrides any minReadySeconds value that may be set on the API server Deployment.
    /// If omitted, the API server Deployment will use its default value for minReadySeconds.
    /// </summary>
    [JsonPropertyName("minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    /// <summary>Template describes the API server Deployment pod that will be created.</summary>
    [JsonPropertyName("template")]
    public V1APIServerSpecApiServerDeploymentSpecTemplate? Template { get; set; }
}

/// <summary>
/// APIServerDeployment configures the calico-apiserver Deployment. If
/// used in conjunction with ControlPlaneNodeSelector or ControlPlaneTolerations, then these overrides
/// take precedence.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecApiServerDeployment
{
    /// <summary>Metadata is a subset of a Kubernetes object&apos;s metadata that is added to the Deployment.</summary>
    [JsonPropertyName("metadata")]
    public V1APIServerSpecApiServerDeploymentMetadata? Metadata { get; set; }

    /// <summary>Spec is the specification of the API server Deployment.</summary>
    [JsonPropertyName("spec")]
    public V1APIServerSpecApiServerDeploymentSpec? Spec { get; set; }
}

/// <summary>Metadata is a subset of a Kubernetes object&apos;s metadata that is added to the Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentMetadata
{
    /// <summary>
    /// Annotations is a map of arbitrary non-identifying metadata. Each of these
    /// key/value pairs are added to the object&apos;s annotations provided the key does not
    /// already exist in the object&apos;s annotations.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Labels is a map of string keys and values that may match replicaset and
    /// service selectors. Each of these key/value pairs are added to the
    /// object&apos;s labels provided the key does not already exist in the object&apos;s labels.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// Metadata is a subset of a Kubernetes object&apos;s metadata that is added to
/// the pod&apos;s metadata.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateMetadata
{
    /// <summary>
    /// Annotations is a map of arbitrary non-identifying metadata. Each of these
    /// key/value pairs are added to the object&apos;s annotations provided the key does not
    /// already exist in the object&apos;s annotations.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Labels is a map of string keys and values that may match replicaset and
    /// service selectors. Each of these key/value pairs are added to the
    /// object&apos;s labels provided the key does not already exist in the object&apos;s labels.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0
/// (i.e. it&apos;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public required V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. If the operator is Gt or Lt, the values
    /// array must have a single element, which will be interpreted as an integer.
    /// This array is replaced during a strategic merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A null or empty node selector term matches no objects. The requirements of
/// them are ANDed.
/// The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// If the affinity requirements specified by this field are not met at
/// scheduling time, the pod will not be scheduled onto the node.
/// If the affinity requirements specified by this field cease to be met
/// at some point during pod execution (e.g. due to an update), the system
/// may or may not try to eventually evict the pod from its node.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and adding
    /// &quot;weight&quot; to the sum if the node matches the corresponding matchExpressions; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to an update), the system
    /// may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm,
    /// in the range 1-100.
    /// </summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Defines a set of pods (namely those matching the labelSelector
/// relative to the given namespace(s)) that this pod should be
/// co-located (affinity) or not co-located (anti-affinity) with,
/// where co-located is defined as running on a node whose value of
/// the label with key &lt;topologyKey&gt; matches that of any node on which
/// a pod of the set of pods is running
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and adding
    /// &quot;weight&quot; to the sum if the node has pods which matches the corresponding podAffinityTerm; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to a pod label update), the
    /// system may or may not try to eventually evict the pod from its node.
    /// When there are multiple elements, the lists of nodes corresponding to each
    /// podAffinityTerm are intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm,
    /// in the range 1-100.
    /// </summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over a set of resources, in this case pods.
/// If it&apos;s null, this PodAffinityTerm matches with no Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label query over the set of namespaces that the term applies to.
/// The term is applied to the union of the namespaces selected by this field
/// and the ones listed in the namespaces field.
/// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
/// An empty selector ({}) matches all namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Defines a set of pods (namely those matching the labelSelector
/// relative to the given namespace(s)) that this pod should be
/// co-located (affinity) or not co-located (anti-affinity) with,
/// where co-located is defined as running on a node whose value of
/// the label with key &lt;topologyKey&gt; matches that of any node on which
/// a pod of the set of pods is running
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>
    /// MatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both matchLabelKeys and labelSelector.
    /// Also, matchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>
    /// MismatchLabelKeys is a set of pod label keys to select which pods will
    /// be taken into consideration. The keys are used to lookup values from the
    /// incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)`
    /// to select the group of existing pods which pods will be taken into consideration
    /// for the incoming pod&apos;s pod (anti) affinity. Keys that don&apos;t exist in the incoming
    /// pod labels will be ignored. The default value is empty.
    /// The same key is forbidden to exist in both mismatchLabelKeys and labelSelector.
    /// Also, mismatchLabelKeys cannot be set when labelSelector isn&apos;t set.
    /// </summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>
    /// A label query over the set of namespaces that the term applies to.
    /// The term is applied to the union of the namespaces selected by this field
    /// and the ones listed in the namespaces field.
    /// null selector and null or empty namespaces list means &quot;this pod&apos;s namespace&quot;.
    /// An empty selector ({}) matches all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// namespaces specifies a static list of namespace names that the term applies to.
    /// The term is applied to the union of the namespaces listed in this field
    /// and the ones selected by namespaceSelector.
    /// null or empty namespaces list and null namespaceSelector means &quot;this pod&apos;s namespace&quot;.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching
    /// the labelSelector in the specified namespaces, where co-located is defined as running on a node
    /// whose value of the label with key topologyKey matches that of any node on which any of the
    /// selected pods is running.
    /// Empty topologyKey is not allowed.
    /// </summary>
    [JsonPropertyName("topologyKey")]
    public required string TopologyKey { get; set; }
}

/// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinity
{
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy
    /// the anti-affinity expressions specified by this field, but it may choose
    /// a node that violates one or more of the expressions. The node that is
    /// most preferred is the one with the greatest sum of weights, i.e.
    /// for each node that meets all of the scheduling requirements (resource
    /// request, requiredDuringScheduling anti-affinity expressions, etc.),
    /// compute a sum by iterating through the elements of this field and subtracting
    /// &quot;weight&quot; from the sum if the node has pods which matches the corresponding podAffinityTerm; the
    /// node(s) with the highest sum are the most preferred.
    /// </summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the anti-affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the anti-affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to a pod label update), the
    /// system may or may not try to eventually evict the pod from its node.
    /// When there are multiple elements, the lists of nodes corresponding to each
    /// podAffinityTerm are intersected, i.e. all terms must be satisfied.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// Affinity is a group of affinity scheduling rules for the calico-webhooks pods.
/// If specified, this overrides any affinity that may be set on the calico-webhooks Deployment.
/// If omitted, the calico-webhooks Deployment will use its default value for affinity.
/// WARNING: Please note that this field will override the default calico-webhooks Deployment affinity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary>
/// Name is an enum which identifies the calico-webhooks Deployment container by name.
/// Supported values are: calico-webhooks
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersNameEnum>))]
public enum V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersNameEnum
{
    [EnumMember(Value = "calico-webhooks"), JsonStringEnumMemberName("calico-webhooks")]
    CalicoWebhooks
}

/// <summary>
/// Name is an enum which identifies the calico-webhooks Deployment container port by name.
/// Supported values are: calico-webhooks
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersPortsNameEnum>))]
public enum V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersPortsNameEnum
{
    [EnumMember(Value = "calico-webhooks"), JsonStringEnumMemberName("calico-webhooks")]
    CalicoWebhooks
}

/// <summary>CalicoWebhooksDeploymentContainerPort defines a port override for a calico-webhooks container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersPorts
{
    /// <summary>
    /// Number of port to expose on the pod&apos;s IP address.
    /// This must be a valid port number, 0 &lt; x &lt; 65536.
    /// </summary>
    [JsonPropertyName("containerPort")]
    public required int ContainerPort { get; set; }

    /// <summary>
    /// Name is an enum which identifies the calico-webhooks Deployment container port by name.
    /// Supported values are: calico-webhooks
    /// </summary>
    [JsonPropertyName("name")]
    public required V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersPortsNameEnum Name { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersResourcesClaims
{
    /// <summary>
    /// Name must match the name of one entry in pod.spec.resourceClaims of
    /// the Pod where this field is used. It makes that resource available
    /// inside a container.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Request is the name chosen for a request in the referenced claim.
    /// If empty, everything from the claim is made available, otherwise
    /// only the result of this request.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>
/// Resources allows customization of limits and requests for compute resources such as cpu and memory.
/// If specified, this overrides the named calico-webhooks Deployment container&apos;s resources.
/// If omitted, the calico-webhooks Deployment will use its default value for this container&apos;s resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,
    /// otherwise to an implementation-defined value. Requests cannot exceed Limits.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>CalicoWebhooksDeploymentContainer is a calico-webhooks Deployment container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainers
{
    /// <summary>
    /// Name is an enum which identifies the calico-webhooks Deployment container by name.
    /// Supported values are: calico-webhooks
    /// </summary>
    [JsonPropertyName("name")]
    public required V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersNameEnum Name { get; set; }

    /// <summary>
    /// Ports allows customization of the calico-webhooks container&apos;s ports.
    /// If specified, this overrides the default container port configuration.
    /// If omitted, the calico-webhooks Deployment will use its default port (6443).
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>
    /// Resources allows customization of limits and requests for compute resources such as cpu and memory.
    /// If specified, this overrides the named calico-webhooks Deployment container&apos;s resources.
    /// If omitted, the calico-webhooks Deployment will use its default value for this container&apos;s resources.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainersResources? Resources { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches
/// the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecTolerations
{
    /// <summary>
    /// Effect indicates the taint effect to match. Empty means match all taint effects.
    /// When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
    /// </summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>
    /// Key is the taint key that the toleration applies to. Empty means match all taint keys.
    /// If the key is empty, operator must be Exists; this combination means to match all values and all keys.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Operator represents a key&apos;s relationship to the value.
    /// Valid operators are Exists, Equal, Lt, and Gt. Defaults to Equal.
    /// Exists is equivalent to wildcard for value, so that a pod can
    /// tolerate all taints of a particular category.
    /// Lt and Gt perform numeric comparisons (requires feature gate TaintTolerationComparisonOperators).
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// TolerationSeconds represents the period of time the toleration (which must be
    /// of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default,
    /// it is not set, which means tolerate the taint forever (do not evict). Zero and
    /// negative values will be treated as 0 (evict immediately) by the system.
    /// </summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary>
    /// Value is the taint value the toleration matches to.
    /// If the operator is Exists, the value should be empty, otherwise just a regular string.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Spec is the calico-webhooks Deployment&apos;s PodSpec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpec
{
    /// <summary>
    /// Affinity is a group of affinity scheduling rules for the calico-webhooks pods.
    /// If specified, this overrides any affinity that may be set on the calico-webhooks Deployment.
    /// If omitted, the calico-webhooks Deployment will use its default value for affinity.
    /// WARNING: Please note that this field will override the default calico-webhooks Deployment affinity.
    /// </summary>
    [JsonPropertyName("affinity")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecAffinity? Affinity { get; set; }

    /// <summary>
    /// Containers is a list of calico-webhooks containers.
    /// If specified, this overrides the specified calico-webhooks Deployment containers.
    /// If omitted, the calico-webhooks Deployment will use its default values for its containers.
    /// </summary>
    [JsonPropertyName("containers")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecContainers>? Containers { get; set; }

    /// <summary>
    /// HostNetwork forces the webhook pod to use the host&apos;s network namespace.
    /// When true, the webhook pod will run with hostNetwork=true and DNSPolicy=ClusterFirstWithHostNet.
    /// When nil or omitted, the operator auto-detects whether host networking is required
    /// (e.g., for EKS/TKG with Calico CNI).
    /// </summary>
    [JsonPropertyName("hostNetwork")]
    public bool? HostNetwork { get; set; }

    /// <summary>
    /// NodeSelector is the calico-webhooks pod&apos;s scheduling constraints.
    /// If specified, each of the key/value pairs are added to the calico-webhooks Deployment nodeSelector provided
    /// the key does not already exist in the object&apos;s nodeSelector.
    /// If used in conjunction with ControlPlaneNodeSelector, that nodeSelector is set on the calico-webhooks Deployment
    /// and each of this field&apos;s key/value pairs are added to the calico-webhooks Deployment nodeSelector provided
    /// the key does not already exist in the object&apos;s nodeSelector.
    /// If omitted, the calico-webhooks Deployment will use its default value for nodeSelector.
    /// WARNING: Please note that this field will modify the default calico-webhooks Deployment nodeSelector.
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>
    /// Tolerations is the calico-webhooks pod&apos;s tolerations.
    /// If specified, this overrides any tolerations that may be set on the calico-webhooks Deployment.
    /// If omitted, the calico-webhooks Deployment will use its default value for tolerations.
    /// WARNING: Please note that this field will override the default calico-webhooks Deployment tolerations.
    /// </summary>
    [JsonPropertyName("tolerations")]
    public IList<V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpecTolerations>? Tolerations { get; set; }
}

/// <summary>Template describes the calico-webhooks Deployment pod that will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpecTemplate
{
    /// <summary>
    /// Metadata is a subset of a Kubernetes object&apos;s metadata that is added to
    /// the pod&apos;s metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateMetadata? Metadata { get; set; }

    /// <summary>Spec is the calico-webhooks Deployment&apos;s PodSpec.</summary>
    [JsonPropertyName("spec")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplateSpec? Spec { get; set; }
}

/// <summary>Spec is the specification of the calico-webhooks Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeploymentSpec
{
    /// <summary>
    /// MinReadySeconds is the minimum number of seconds for which a newly created Deployment pod should
    /// be ready without any of its container crashing, for it to be considered available.
    /// If specified, this overrides any minReadySeconds value that may be set on the calico-webhooks Deployment.
    /// If omitted, the calico-webhooks Deployment will use its default value for minReadySeconds.
    /// </summary>
    [JsonPropertyName("minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    /// <summary>Template describes the calico-webhooks Deployment pod that will be created.</summary>
    [JsonPropertyName("template")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpecTemplate? Template { get; set; }
}

/// <summary>CalicoWebhooksDeployment configures the calico-webhooks Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecCalicoWebhooksDeployment
{
    /// <summary>Metadata is a subset of a Kubernetes object&apos;s metadata that is added to the Deployment.</summary>
    [JsonPropertyName("metadata")]
    public V1APIServerSpecCalicoWebhooksDeploymentMetadata? Metadata { get; set; }

    /// <summary>Spec is the specification of the calico-webhooks Deployment.</summary>
    [JsonPropertyName("spec")]
    public V1APIServerSpecCalicoWebhooksDeploymentSpec? Spec { get; set; }
}

/// <summary>LogSeverity defines log level for APIServer container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1APIServerSpecLoggingApiServerLogSeverityEnum>))]
public enum V1APIServerSpecLoggingApiServerLogSeverityEnum
{
    [EnumMember(Value = "Fatal"), JsonStringEnumMemberName("Fatal")]
    Fatal,
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Warn"), JsonStringEnumMemberName("Warn")]
    Warn,
    [EnumMember(Value = "Info"), JsonStringEnumMemberName("Info")]
    Info,
    [EnumMember(Value = "Debug"), JsonStringEnumMemberName("Debug")]
    Debug,
    [EnumMember(Value = "Trace"), JsonStringEnumMemberName("Trace")]
    Trace
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecLoggingApiServer
{
    /// <summary>LogSeverity defines log level for APIServer container.</summary>
    [JsonPropertyName("logSeverity")]
    public V1APIServerSpecLoggingApiServerLogSeverityEnum? LogSeverity { get; set; }
}

/// <summary>LogSeverity defines log level for QueryServer container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1APIServerSpecLoggingQueryServerLogSeverityEnum>))]
public enum V1APIServerSpecLoggingQueryServerLogSeverityEnum
{
    [EnumMember(Value = "Fatal"), JsonStringEnumMemberName("Fatal")]
    Fatal,
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Warn"), JsonStringEnumMemberName("Warn")]
    Warn,
    [EnumMember(Value = "Info"), JsonStringEnumMemberName("Info")]
    Info,
    [EnumMember(Value = "Debug"), JsonStringEnumMemberName("Debug")]
    Debug,
    [EnumMember(Value = "Trace"), JsonStringEnumMemberName("Trace")]
    Trace
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecLoggingQueryServer
{
    /// <summary>LogSeverity defines log level for QueryServer container.</summary>
    [JsonPropertyName("logSeverity")]
    public V1APIServerSpecLoggingQueryServerLogSeverityEnum? LogSeverity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpecLogging
{
    [JsonPropertyName("apiServer")]
    public V1APIServerSpecLoggingApiServer? ApiServer { get; set; }

    [JsonPropertyName("queryServer")]
    public V1APIServerSpecLoggingQueryServer? QueryServer { get; set; }
}

/// <summary>Specification of the desired state for the Tigera API server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerSpec
{
    /// <summary>
    /// APIServerDeployment configures the calico-apiserver Deployment. If
    /// used in conjunction with ControlPlaneNodeSelector or ControlPlaneTolerations, then these overrides
    /// take precedence.
    /// </summary>
    [JsonPropertyName("apiServerDeployment")]
    public V1APIServerSpecApiServerDeployment? ApiServerDeployment { get; set; }

    /// <summary>CalicoWebhooksDeployment configures the calico-webhooks Deployment.</summary>
    [JsonPropertyName("calicoWebhooksDeployment")]
    public V1APIServerSpecCalicoWebhooksDeployment? CalicoWebhooksDeployment { get; set; }

    [JsonPropertyName("logging")]
    public V1APIServerSpecLogging? Logging { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1APIServerStatusConditionsStatusEnum>))]
public enum V1APIServerStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1APIServerStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Most recently observed status for the Tigera API server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1APIServerStatus
{
    /// <summary>
    /// Conditions represents the latest observed set of conditions for the component. A component may be one or more of
    /// Ready, Progressing, Degraded or other customer types.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1APIServerStatusConditions>? Conditions { get; set; }

    /// <summary>State provides user-readable status.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// APIServer installs the Tigera API server and related resources. At most one instance
/// of this resource is supported. It must be named &quot;default&quot; or &quot;tigera-secure&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1APIServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1APIServerSpec?>, IStatus<V1APIServerStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "APIServer";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "apiservers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIServer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired state for the Tigera API server.</summary>
    [JsonPropertyName("spec")]
    public V1APIServerSpec? Spec { get; set; }

    /// <summary>Most recently observed status for the Tigera API server.</summary>
    [JsonPropertyName("status")]
    public V1APIServerStatus? Status { get; set; }
}