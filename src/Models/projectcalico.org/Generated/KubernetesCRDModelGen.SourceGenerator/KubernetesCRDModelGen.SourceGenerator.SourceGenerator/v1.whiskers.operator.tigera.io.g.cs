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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1WhiskerList : IKubernetesObject<V1ListMeta>, IItems<V1Whisker>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "WhiskerList";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "whiskers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WhiskerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Whisker objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Whisker> Items { get; set; }
}

/// <summary>Metadata is a subset of a Kubernetes object&apos;s metadata that is added to the Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentMetadata
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
/// Rolling update config params. Present only if DeploymentStrategyType =
/// RollingUpdate.
/// to be.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecStrategyRollingUpdate
{
    /// <summary>
    /// The maximum number of pods that can be scheduled above the desired number of
    /// pods.
    /// Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%).
    /// This can not be 0 if MaxUnavailable is 0.
    /// Absolute number is calculated from percentage by rounding up.
    /// Defaults to 25%.
    /// Example: when this is set to 30%, the new ReplicaSet can be scaled up immediately when
    /// the rolling update starts, such that the total number of old and new pods do not exceed
    /// 130% of desired pods. Once old pods have been killed,
    /// new ReplicaSet can be scaled up further, ensuring that total number of pods running
    /// at any time during the update is at most 130% of desired pods.
    /// </summary>
    [JsonPropertyName("maxSurge")]
    public IntOrString? MaxSurge { get; set; }

    /// <summary>
    /// The maximum number of pods that can be unavailable during the update.
    /// Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%).
    /// Absolute number is calculated from percentage by rounding down.
    /// This can not be 0 if MaxSurge is 0.
    /// Defaults to 25%.
    /// Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of desired pods
    /// immediately when the rolling update starts. Once new pods are ready, old ReplicaSet
    /// can be scaled down further, followed by scaling up the new ReplicaSet, ensuring
    /// that the total number of pods available at all times during the update is at
    /// least 70% of desired pods.
    /// </summary>
    [JsonPropertyName("maxUnavailable")]
    public IntOrString? MaxUnavailable { get; set; }
}

/// <summary>The deployment strategy to use to replace existing pods with new ones.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecStrategy
{
    /// <summary>
    /// Rolling update config params. Present only if DeploymentStrategyType =
    /// RollingUpdate.
    /// to be.
    /// </summary>
    [JsonPropertyName("rollingUpdate")]
    public V1WhiskerSpecWhiskerDeploymentSpecStrategyRollingUpdate? RollingUpdate { get; set; }
}

/// <summary>Metadata is a subset of a Kubernetes object&apos;s metadata that is added to the pod&apos;s metadata.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0
/// (i.e. it&apos;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public required V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public required int Weight { get; set; }
}

/// <summary>
/// A node selector requirement is a selector that contains values, a key, and an operator
/// that relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// If the affinity requirements specified by this field are not met at
/// scheduling time, the pod will not be scheduled onto the node.
/// If the affinity requirements specified by this field cease to be met
/// at some point during pod execution (e.g. due to an update), the system
/// may or may not try to eventually evict the pod from its node.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinity
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
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to an update), the system
    /// may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinity
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
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinity
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
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>Affinity is a group of affinity scheduling rules for the whisker pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecContainersNameEnum>))]
public enum V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecContainersNameEnum
{
    [EnumMember(Value = "whisker"), JsonStringEnumMemberName("whisker")]
    Whisker,
    [EnumMember(Value = "whisker-backend"), JsonStringEnumMemberName("whisker-backend")]
    WhiskerBackend
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecContainersResourcesClaims
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

/// <summary>ResourceRequirements describes the compute resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecContainers
{
    [JsonPropertyName("name")]
    public required V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecContainersNameEnum Name { get; set; }

    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecContainersResources? Resources { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches
/// the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecTolerations
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>TopologySpreadConstraint specifies how to spread matching pods among the given topology.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary>
    /// LabelSelector is used to find matching pods.
    /// Pods that match this label selector are counted to determine the number of pods
    /// in their corresponding topology domain.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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

/// <summary>Spec is the whisker Deployment&apos;s PodSpec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplateSpec
{
    /// <summary>Affinity is a group of affinity scheduling rules for the whisker pods.</summary>
    [JsonPropertyName("affinity")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecAffinity? Affinity { get; set; }

    /// <summary>
    /// Containers is a list of whisker containers.
    /// If specified, this overrides the specified EGW Deployment containers.
    /// If omitted, the whisker Deployment will use its default values for its containers.
    /// </summary>
    [JsonPropertyName("containers")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecContainers>? Containers { get; set; }

    /// <summary>NodeSelector gives more control over the nodes where the whisker pods will run on.</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>PriorityClassName allows to specify a PriorityClass resource to be used.</summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>TerminationGracePeriodSeconds defines the termination grace period of the whisker pods in seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// Tolerations is the whisker pod&apos;s tolerations.
    /// If specified, this overrides any tolerations that may be set on the whisker Deployment.
    /// If omitted, the whisker Deployment will use its default value for tolerations.
    /// </summary>
    [JsonPropertyName("tolerations")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary>
    /// TopologySpreadConstraints describes how a group of pods ought to spread across topology
    /// domains. Scheduler will schedule pods in a way which abides by the constraints.
    /// All topologySpreadConstraints are ANDed.
    /// </summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1WhiskerSpecWhiskerDeploymentSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }
}

/// <summary>Template describes the whisker Deployment pod that will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpecTemplate
{
    /// <summary>Metadata is a subset of a Kubernetes object&apos;s metadata that is added to the pod&apos;s metadata.</summary>
    [JsonPropertyName("metadata")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateMetadata? Metadata { get; set; }

    /// <summary>Spec is the whisker Deployment&apos;s PodSpec.</summary>
    [JsonPropertyName("spec")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplateSpec? Spec { get; set; }
}

/// <summary>Spec is the specification of the whisker Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeploymentSpec
{
    /// <summary>
    /// MinReadySeconds is the minimum number of seconds for which a newly created Deployment pod should
    /// be ready without any of its container crashing, for it to be considered available.
    /// If specified, this overrides any minReadySeconds value that may be set on the whisker Deployment.
    /// If omitted, the whisker Deployment will use its default value for minReadySeconds.
    /// </summary>
    [JsonPropertyName("minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    /// <summary>The deployment strategy to use to replace existing pods with new ones.</summary>
    [JsonPropertyName("strategy")]
    public V1WhiskerSpecWhiskerDeploymentSpecStrategy? Strategy { get; set; }

    /// <summary>Template describes the whisker Deployment pod that will be created.</summary>
    [JsonPropertyName("template")]
    public V1WhiskerSpecWhiskerDeploymentSpecTemplate? Template { get; set; }
}

/// <summary>WhiskerDeployment is the configuration for the whisker Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpecWhiskerDeployment
{
    /// <summary>Metadata is a subset of a Kubernetes object&apos;s metadata that is added to the Deployment.</summary>
    [JsonPropertyName("metadata")]
    public V1WhiskerSpecWhiskerDeploymentMetadata? Metadata { get; set; }

    /// <summary>Spec is the specification of the whisker Deployment.</summary>
    [JsonPropertyName("spec")]
    public V1WhiskerSpecWhiskerDeploymentSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerSpec
{
    /// <summary>
    /// Default: Enabled
    /// This setting enables calls to an external API to retrieve notification banner text in the Whisker UI.
    /// Allowed values are Enabled or Disabled. Defaults to Enabled.
    /// </summary>
    [JsonPropertyName("notifications")]
    public string? Notifications { get; set; }

    /// <summary>WhiskerDeployment is the configuration for the whisker Deployment.</summary>
    [JsonPropertyName("whiskerDeployment")]
    public V1WhiskerSpecWhiskerDeployment? WhiskerDeployment { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1WhiskerStatusConditionsStatusEnum>))]
public enum V1WhiskerStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerStatusConditions
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
    public required V1WhiskerStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>WhiskerStatus defines the observed state of Whisker</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WhiskerStatus
{
    /// <summary>
    /// Conditions represents the latest observed set of conditions for the component. A component may be one or more of
    /// Ready, Progressing, Degraded or other customer types.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1WhiskerStatusConditions>? Conditions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Whisker : IKubernetesObject<V1ObjectMeta>, ISpec<V1WhiskerSpec?>, IStatus<V1WhiskerStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Whisker";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "whiskers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Whisker";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1WhiskerSpec? Spec { get; set; }

    /// <summary>WhiskerStatus defines the observed state of Whisker</summary>
    [JsonPropertyName("status")]
    public V1WhiskerStatus? Status { get; set; }
}