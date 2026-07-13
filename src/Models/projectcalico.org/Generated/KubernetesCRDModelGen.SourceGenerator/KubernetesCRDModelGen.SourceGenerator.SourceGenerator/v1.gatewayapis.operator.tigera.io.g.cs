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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GatewayAPIList : IKubernetesObject<V1ListMeta>, IItems<V1GatewayAPI>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GatewayAPIList";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "gatewayapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayAPIList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1GatewayAPI objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1GatewayAPI> Items { get; set; }
}

/// <summary>
/// Configures how to manage and update Gateway API CRDs.  The default behaviour - which is
/// used when this field is not set, or is set to &quot;PreferExisting&quot; - is that the Tigera
/// operator will create the Gateway API CRDs if they do not already exist, but will not
/// overwrite any existing Gateway API CRDs.  This setting may be preferable if the customer
/// is using other implementations of the Gateway API concurrently with the Gateway API
/// support in Calico Enterprise.  It is then the customer&apos;s responsibility to ensure that
/// CRDs are installed that meet the needs of all the Gateway API implementations in their
/// cluster.
/// Alternatively, if this field is set to &quot;Reconcile&quot;, the Tigera operator will keep the
/// cluster&apos;s Gateway API CRDs aligned with those that it would install on a cluster that
/// does not yet have any version of those CRDs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewayAPISpecCrdManagementEnum>))]
public enum V1GatewayAPISpecCrdManagementEnum
{
    [EnumMember(Value = "Reconcile"), JsonStringEnumMemberName("Reconcile")]
    Reconcile,
    [EnumMember(Value = "PreferExisting"), JsonStringEnumMemberName("PreferExisting")]
    PreferExisting
}

/// <summary>
/// Reference to a custom EnvoyGateway YAML to use as the base EnvoyGateway configuration for
/// the gateway controller.  When specified, must identify a ConfigMap resource with an
/// &quot;envoy-gateway.yaml&quot; key whose value is the desired EnvoyGateway YAML (i.e. following the
/// same pattern as the default `envoy-gateway-config` ConfigMap).
/// When not specified, the Tigera operator uses the `envoy-gateway-config` from the Envoy
/// Gateway helm chart as its base.
/// Starting from that base, the Tigera operator copies and modifies the EnvoyGateway
/// resource as follows:
/// 1. If not already specified, it sets the ControllerName to
/// &quot;gateway.envoyproxy.io/gatewayclass-controller&quot;.
/// 2. It configures the `tigera/envoy-gateway` and `tigera/envoy-ratelimit` images that will
/// be used (according to the current Calico version, private registry and image set
/// settings) and any pull secrets that are needed to pull those images.
/// 3. It enables use of the Backend API.
/// The resulting EnvoyGateway is provisioned as the `envoy-gateway-config` ConfigMap (which
/// the gateway controller then uses as its config).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecEnvoyGatewayConfigRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// If non-nil, non-clashing labels and annotations from this metadata are added into the
/// job&apos;s top-level metadata.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobMetadata
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
/// If non-nil, non-clashing labels and annotations from this metadata are added into the
/// job&apos;s pod template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateMetadata
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0
/// (i.e. it&apos;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public required V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinity
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
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to an update), the system
    /// may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinity
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
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinity
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
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>If non-nil, Affinity sets the affinity field of the job&apos;s pod template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecContainersNameEnum>))]
public enum V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecContainersNameEnum
{
    [EnumMember(Value = "envoy-gateway-certgen"), JsonStringEnumMemberName("envoy-gateway-certgen")]
    EnvoyGatewayCertgen
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecContainersResourcesClaims
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
/// If non-nil, Resources sets the ResourceRequirements of the job&apos;s &quot;envoy-gateway-certgen&quot;
/// container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

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

/// <summary>
/// GatewayCertgenJobContainer allows customization of the gateway certgen job&apos;s resource
/// requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecContainers
{
    [JsonPropertyName("name")]
    public required V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecContainersNameEnum Name { get; set; }

    /// <summary>
    /// If non-nil, Resources sets the ResourceRequirements of the job&apos;s &quot;envoy-gateway-certgen&quot;
    /// container.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecContainersResources? Resources { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches
/// the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecTolerations
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

/// <summary>GatewayCertgenJobPodSpec allows customization of the gateway certgen job&apos;s pod spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpec
{
    /// <summary>If non-nil, Affinity sets the affinity field of the job&apos;s pod template.</summary>
    [JsonPropertyName("affinity")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecAffinity? Affinity { get; set; }

    [JsonPropertyName("containers")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecContainers>? Containers { get; set; }

    /// <summary>If non-nil, NodeSelector sets the node selector for where job pods may be scheduled.</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>If non-nil, Tolerations sets the tolerations field of the job&apos;s pod template.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpecTolerations>? Tolerations { get; set; }
}

/// <summary>GatewayCertgenJobPodTemplate allows customization of the gateway certgen job&apos;s pod template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpecTemplate
{
    /// <summary>
    /// If non-nil, non-clashing labels and annotations from this metadata are added into the
    /// job&apos;s pod template.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateMetadata? Metadata { get; set; }

    /// <summary>GatewayCertgenJobPodSpec allows customization of the gateway certgen job&apos;s pod spec.</summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplateSpec? Spec { get; set; }
}

/// <summary>GatewayCertgenJobSpec allows customization of the gateway certgen job spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJobSpec
{
    /// <summary>GatewayCertgenJobPodTemplate allows customization of the gateway certgen job&apos;s pod template.</summary>
    [JsonPropertyName("template")]
    public V1GatewayAPISpecGatewayCertgenJobSpecTemplate? Template { get; set; }
}

/// <summary>Allows customization of the gateway certgen job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayCertgenJob
{
    /// <summary>
    /// If non-nil, non-clashing labels and annotations from this metadata are added into the
    /// job&apos;s top-level metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1GatewayAPISpecGatewayCertgenJobMetadata? Metadata { get; set; }

    /// <summary>GatewayCertgenJobSpec allows customization of the gateway certgen job spec.</summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpecGatewayCertgenJobSpec? Spec { get; set; }
}

/// <summary>
/// Reference to a custom EnvoyProxy resource to use as the base EnvoyProxy configuration for
/// this GatewayClass.  When specified, must identify an EnvoyProxy resource.
/// When not specified, the Tigera operator uses an empty EnvoyProxy resource as its base.
/// Starting from that base, the Tigera operator copies and modifies the EnvoyProxy resource
/// as follows, in the order described:
/// 1. It configures the `tigera/envoy-proxy` image that will be used (according to the
/// current Calico version, private registry and image set settings) and any pull secrets
/// that are needed to pull that image.
/// 2. It applies customizations as specified by the following `GatewayKind`,
/// `GatewayDeployment`, `GatewayDaemonSet` and `GatewayService` fields.
/// The resulting EnvoyProxy is provisioned in the `tigera-gateway` namespace, together with
/// a GatewayClass that references it.
/// If a custom EnvoyProxy resource is specified and uses `EnvoyDaemonSet` instead of the
/// default `EnvoyDeployment`, deployment-related customizations will be applied within
/// `EnvoyDaemonSet` instead of within `EnvoyDeployment`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesEnvoyProxyRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// If non-nil, non-clashing labels and annotations from this metadata are added into each
/// daemonset&apos;s pod template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateMetadata
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0
/// (i.e. it&apos;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public required V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinity
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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to an update), the system
    /// may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinity
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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinity
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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>If non-nil, Affinity sets the affinity field of the daemonset&apos;s pod template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecContainersNameEnum>))]
public enum V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecContainersNameEnum
{
    [EnumMember(Value = "envoy"), JsonStringEnumMemberName("envoy")]
    Envoy
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecContainersResourcesClaims
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
/// If non-nil, Resources sets the ResourceRequirements of the daemonset&apos;s &quot;envoy&quot;
/// container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

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

/// <summary>
/// GatewayDaemonSetContainer allows customization of the resource requirements of gateway
/// daemonsets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecContainers
{
    [JsonPropertyName("name")]
    public required V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecContainersNameEnum Name { get; set; }

    /// <summary>
    /// If non-nil, Resources sets the ResourceRequirements of the daemonset&apos;s &quot;envoy&quot;
    /// container.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecContainersResources? Resources { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches
/// the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecTolerations
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary>
    /// LabelSelector is used to find matching pods.
    /// Pods that match this label selector are counted to determine the number of pods
    /// in their corresponding topology domain.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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

/// <summary>GatewayDaemonSetPodSpec allows customization of the pod spec of gateway daemonsets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpec
{
    /// <summary>If non-nil, Affinity sets the affinity field of the daemonset&apos;s pod template.</summary>
    [JsonPropertyName("affinity")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecAffinity? Affinity { get; set; }

    [JsonPropertyName("containers")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecContainers>? Containers { get; set; }

    /// <summary>
    /// If non-nil, NodeSelector sets the node selector for where daemonset pods may be
    /// scheduled.
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>If non-nil, Tolerations sets the tolerations field of the daemonset&apos;s pod template.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary>
    /// If non-nil, TopologySpreadConstraints sets the topology spread constraints of the
    /// daemonset&apos;s pod template.  TopologySpreadConstraints describes how a group of pods ought
    /// to spread across topology domains. Scheduler will schedule pods in a way which abides by
    /// the constraints.  All topologySpreadConstraints are ANDed.
    /// </summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }
}

/// <summary>GatewayDeploymentPodTemplate allows customization of the pod template of gateway daemonsets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplate
{
    /// <summary>
    /// If non-nil, non-clashing labels and annotations from this metadata are added into each
    /// daemonset&apos;s pod template.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateMetadata? Metadata { get; set; }

    /// <summary>GatewayDaemonSetPodSpec allows customization of the pod spec of gateway daemonsets.</summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplateSpec? Spec { get; set; }
}

/// <summary>GatewayDeploymentSpec allows customization of the spec of gateway daemonsets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpec
{
    /// <summary>GatewayDeploymentPodTemplate allows customization of the pod template of gateway daemonsets.</summary>
    [JsonPropertyName("template")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpecTemplate? Template { get; set; }
}

/// <summary>
/// Allows customization of Gateways when deployed as Kubernetes DaemonSets, for Gateways in
/// this GatewayClass.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDaemonSet
{
    /// <summary>GatewayDeploymentSpec allows customization of the spec of gateway daemonsets.</summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSetSpec? Spec { get; set; }
}

/// <summary>Spec to control the desired behavior of rolling update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecStrategyRollingUpdate
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecStrategy
{
    /// <summary>Spec to control the desired behavior of rolling update.</summary>
    [JsonPropertyName("rollingUpdate")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecStrategyRollingUpdate? RollingUpdate { get; set; }
}

/// <summary>
/// If non-nil, non-clashing labels and annotations from this metadata are added into each
/// deployment&apos;s pod template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateMetadata
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0
/// (i.e. it&apos;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public required V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinity
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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to an update), the system
    /// may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinity
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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinity
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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>If non-nil, Affinity sets the affinity field of the deployment&apos;s pod template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecContainersNameEnum>))]
public enum V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecContainersNameEnum
{
    [EnumMember(Value = "envoy"), JsonStringEnumMemberName("envoy")]
    Envoy
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecContainersResourcesClaims
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
/// If non-nil, Resources sets the ResourceRequirements of the deployment&apos;s &quot;envoy&quot;
/// container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

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

/// <summary>
/// GatewayDeploymentContainer allows customization of the resource requirements of gateway
/// deployments.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecContainers
{
    [JsonPropertyName("name")]
    public required V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecContainersNameEnum Name { get; set; }

    /// <summary>
    /// If non-nil, Resources sets the ResourceRequirements of the deployment&apos;s &quot;envoy&quot;
    /// container.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecContainersResources? Resources { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches
/// the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecTolerations
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary>
    /// LabelSelector is used to find matching pods.
    /// Pods that match this label selector are counted to determine the number of pods
    /// in their corresponding topology domain.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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

/// <summary>GatewayDeploymentPodSpec allows customization of the pod spec of gateway deployments.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpec
{
    /// <summary>If non-nil, Affinity sets the affinity field of the deployment&apos;s pod template.</summary>
    [JsonPropertyName("affinity")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecAffinity? Affinity { get; set; }

    [JsonPropertyName("containers")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecContainers>? Containers { get; set; }

    /// <summary>
    /// If non-nil, NodeSelector sets the node selector for where deployment pods may be
    /// scheduled.
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>If non-nil, Tolerations sets the tolerations field of the deployment&apos;s pod template.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary>
    /// If non-nil, TopologySpreadConstraints sets the topology spread constraints of the
    /// deployment&apos;s pod template.  TopologySpreadConstraints describes how a group of pods ought
    /// to spread across topology domains. Scheduler will schedule pods in a way which abides by
    /// the constraints.  All topologySpreadConstraints are ANDed.
    /// </summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }
}

/// <summary>GatewayDeploymentPodTemplate allows customization of the pod template of gateway deployments.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplate
{
    /// <summary>
    /// If non-nil, non-clashing labels and annotations from this metadata are added into each
    /// deployment&apos;s pod template.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateMetadata? Metadata { get; set; }

    /// <summary>GatewayDeploymentPodSpec allows customization of the pod spec of gateway deployments.</summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplateSpec? Spec { get; set; }
}

/// <summary>GatewayDeploymentSpec allows customization of the spec of gateway deployments.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeploymentSpec
{
    /// <summary>If non-nil, Replicas sets the number of replicas for the deployment.</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary>The deployment strategy to use to replace existing pods with new ones.</summary>
    [JsonPropertyName("strategy")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecStrategy? Strategy { get; set; }

    /// <summary>GatewayDeploymentPodTemplate allows customization of the pod template of gateway deployments.</summary>
    [JsonPropertyName("template")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpecTemplate? Template { get; set; }
}

/// <summary>
/// Allows customization of Gateways when deployed as Kubernetes Deployments, for Gateways in
/// this GatewayClass.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayDeployment
{
    /// <summary>GatewayDeploymentSpec allows customization of the spec of gateway deployments.</summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpecGatewayClassesGatewayDeploymentSpec? Spec { get; set; }
}

/// <summary>
/// Specifies whether Gateways in this class are deployed as Deployments (default) or as
/// DaemonSets.  It is an error for GatewayKind to specify a choice that is incompatible with
/// the custom EnvoyProxy, when EnvoyProxyRef is also specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewayAPISpecGatewayClassesGatewayKindEnum>))]
public enum V1GatewayAPISpecGatewayClassesGatewayKindEnum
{
    [EnumMember(Value = "Deployment"), JsonStringEnumMemberName("Deployment")]
    Deployment,
    [EnumMember(Value = "DaemonSet"), JsonStringEnumMemberName("DaemonSet")]
    DaemonSet
}

/// <summary>
/// If non-nil, non-clashing labels and annotations from this metadata are added into the
/// each Gateway Service&apos;s metadata.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayServiceMetadata
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
/// GatewayServiceSpec allows customization of the services that front gateway deployments.
/// The LoadBalancer fields allow customization of the corresponding fields in the Kubernetes
/// ServiceSpec.  These can be used for some cloud-independent control of the external load balancer
/// that is provisioned for each Gateway.  For finer-grained cloud-specific control please use
/// the Metadata.Annotations field in GatewayService.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayServiceSpec
{
    [JsonPropertyName("allocateLoadBalancerNodePorts")]
    public bool? AllocateLoadBalancerNodePorts { get; set; }

    [JsonPropertyName("loadBalancerClass")]
    public string? LoadBalancerClass { get; set; }

    [JsonPropertyName("loadBalancerIP")]
    public string? LoadBalancerIP { get; set; }

    [JsonPropertyName("loadBalancerSourceRanges")]
    public IList<string>? LoadBalancerSourceRanges { get; set; }
}

/// <summary>Allows customization of gateway services, for Gateways in this GatewayClass.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClassesGatewayService
{
    /// <summary>
    /// If non-nil, non-clashing labels and annotations from this metadata are added into the
    /// each Gateway Service&apos;s metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1GatewayAPISpecGatewayClassesGatewayServiceMetadata? Metadata { get; set; }

    /// <summary>
    /// GatewayServiceSpec allows customization of the services that front gateway deployments.
    /// The LoadBalancer fields allow customization of the corresponding fields in the Kubernetes
    /// ServiceSpec.  These can be used for some cloud-independent control of the external load balancer
    /// that is provisioned for each Gateway.  For finer-grained cloud-specific control please use
    /// the Metadata.Annotations field in GatewayService.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpecGatewayClassesGatewayServiceSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayClasses
{
    /// <summary>
    /// Reference to a custom EnvoyProxy resource to use as the base EnvoyProxy configuration for
    /// this GatewayClass.  When specified, must identify an EnvoyProxy resource.
    /// When not specified, the Tigera operator uses an empty EnvoyProxy resource as its base.
    /// Starting from that base, the Tigera operator copies and modifies the EnvoyProxy resource
    /// as follows, in the order described:
    /// 1. It configures the `tigera/envoy-proxy` image that will be used (according to the
    /// current Calico version, private registry and image set settings) and any pull secrets
    /// that are needed to pull that image.
    /// 2. It applies customizations as specified by the following `GatewayKind`,
    /// `GatewayDeployment`, `GatewayDaemonSet` and `GatewayService` fields.
    /// The resulting EnvoyProxy is provisioned in the `tigera-gateway` namespace, together with
    /// a GatewayClass that references it.
    /// If a custom EnvoyProxy resource is specified and uses `EnvoyDaemonSet` instead of the
    /// default `EnvoyDeployment`, deployment-related customizations will be applied within
    /// `EnvoyDaemonSet` instead of within `EnvoyDeployment`.
    /// </summary>
    [JsonPropertyName("envoyProxyRef")]
    public V1GatewayAPISpecGatewayClassesEnvoyProxyRef? EnvoyProxyRef { get; set; }

    /// <summary>
    /// Allows customization of Gateways when deployed as Kubernetes DaemonSets, for Gateways in
    /// this GatewayClass.
    /// </summary>
    [JsonPropertyName("gatewayDaemonSet")]
    public V1GatewayAPISpecGatewayClassesGatewayDaemonSet? GatewayDaemonSet { get; set; }

    /// <summary>
    /// Allows customization of Gateways when deployed as Kubernetes Deployments, for Gateways in
    /// this GatewayClass.
    /// </summary>
    [JsonPropertyName("gatewayDeployment")]
    public V1GatewayAPISpecGatewayClassesGatewayDeployment? GatewayDeployment { get; set; }

    /// <summary>
    /// Specifies whether Gateways in this class are deployed as Deployments (default) or as
    /// DaemonSets.  It is an error for GatewayKind to specify a choice that is incompatible with
    /// the custom EnvoyProxy, when EnvoyProxyRef is also specified.
    /// </summary>
    [JsonPropertyName("gatewayKind")]
    public V1GatewayAPISpecGatewayClassesGatewayKindEnum? GatewayKind { get; set; }

    /// <summary>Allows customization of gateway services, for Gateways in this GatewayClass.</summary>
    [JsonPropertyName("gatewayService")]
    public V1GatewayAPISpecGatewayClassesGatewayService? GatewayService { get; set; }

    /// <summary>The name of this GatewayClass.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// If non-nil, non-clashing labels and annotations from this metadata are added into the
/// deployment&apos;s top-level metadata.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentMetadata
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
/// If non-nil, non-clashing labels and annotations from this metadata are added into the
/// deployment&apos;s pod template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateMetadata
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0
/// (i.e. it&apos;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public required V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node&apos;s labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node&apos;s fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public required IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinity
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
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at
    /// scheduling time, the pod will not be scheduled onto the node.
    /// If the affinity requirements specified by this field cease to be met
    /// at some point during pod execution (e.g. due to an update), the system
    /// may or may not try to eventually evict the pod from its node.
    /// </summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinity
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
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public required V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// If it&apos;s null, this PodAffinityTerm matches with no Pods.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

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
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinity
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
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

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
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>If non-nil, Affinity sets the affinity field of the deployment&apos;s pod template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecContainersNameEnum>))]
public enum V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecContainersNameEnum
{
    [EnumMember(Value = "envoy-gateway"), JsonStringEnumMemberName("envoy-gateway")]
    EnvoyGateway
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecContainersResourcesClaims
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
/// If non-nil, Resources sets the ResourceRequirements of the controller&apos;s &quot;envoy-gateway&quot;
/// container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

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

/// <summary>
/// GatewayControllerDeploymentContainer allows customization of the gateway controller&apos;s resource
/// requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecContainers
{
    [JsonPropertyName("name")]
    public required V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecContainersNameEnum Name { get; set; }

    /// <summary>
    /// If non-nil, Resources sets the ResourceRequirements of the controller&apos;s &quot;envoy-gateway&quot;
    /// container.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecContainersResources? Resources { get; set; }
}

/// <summary>
/// The pod this Toleration is attached to tolerates any taint that matches
/// the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecTolerations
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary>
    /// LabelSelector is used to find matching pods.
    /// Pods that match this label selector are counted to determine the number of pods
    /// in their corresponding topology domain.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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

/// <summary>
/// GatewayControllerDeploymentPodSpec allows customization of the gateway controller deployment pod
/// spec.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpec
{
    /// <summary>If non-nil, Affinity sets the affinity field of the deployment&apos;s pod template.</summary>
    [JsonPropertyName("affinity")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecAffinity? Affinity { get; set; }

    [JsonPropertyName("containers")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecContainers>? Containers { get; set; }

    /// <summary>
    /// If non-nil, NodeSelector sets the node selector for where deployment pods may be
    /// scheduled.
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>If non-nil, Tolerations sets the tolerations field of the deployment&apos;s pod template.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary>
    /// If non-nil, TopologySpreadConstraints sets the topology spread constraints of the
    /// deployment&apos;s pod template.  TopologySpreadConstraints describes how a group of pods ought
    /// to spread across topology domains. Scheduler will schedule pods in a way which abides by
    /// the constraints.  All topologySpreadConstraints are ANDed.
    /// </summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }
}

/// <summary>
/// GatewayControllerDeploymentPodTemplate allows customization of the gateway controller deployment
/// pod template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpecTemplate
{
    /// <summary>
    /// If non-nil, non-clashing labels and annotations from this metadata are added into the
    /// deployment&apos;s pod template.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateMetadata? Metadata { get; set; }

    /// <summary>
    /// GatewayControllerDeploymentPodSpec allows customization of the gateway controller deployment pod
    /// spec.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplateSpec? Spec { get; set; }
}

/// <summary>GatewayControllerDeploymentSpec allows customization of the gateway controller deployment spec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeploymentSpec
{
    /// <summary>If non-nil, MinReadySeconds sets the minReadySeconds field for the deployment.</summary>
    [JsonPropertyName("minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    /// <summary>If non-nil, Replicas sets the number of replicas for the deployment.</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary>
    /// GatewayControllerDeploymentPodTemplate allows customization of the gateway controller deployment
    /// pod template.
    /// </summary>
    [JsonPropertyName("template")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpecTemplate? Template { get; set; }
}

/// <summary>Allows customization of the gateway controller deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpecGatewayControllerDeployment
{
    /// <summary>
    /// If non-nil, non-clashing labels and annotations from this metadata are added into the
    /// deployment&apos;s top-level metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1GatewayAPISpecGatewayControllerDeploymentMetadata? Metadata { get; set; }

    /// <summary>GatewayControllerDeploymentSpec allows customization of the gateway controller deployment spec.</summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpecGatewayControllerDeploymentSpec? Spec { get; set; }
}

/// <summary>GatewayAPISpec has fields that can be used to customize our GatewayAPI support.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayAPISpec
{
    /// <summary>
    /// Configures how to manage and update Gateway API CRDs.  The default behaviour - which is
    /// used when this field is not set, or is set to &quot;PreferExisting&quot; - is that the Tigera
    /// operator will create the Gateway API CRDs if they do not already exist, but will not
    /// overwrite any existing Gateway API CRDs.  This setting may be preferable if the customer
    /// is using other implementations of the Gateway API concurrently with the Gateway API
    /// support in Calico Enterprise.  It is then the customer&apos;s responsibility to ensure that
    /// CRDs are installed that meet the needs of all the Gateway API implementations in their
    /// cluster.
    /// Alternatively, if this field is set to &quot;Reconcile&quot;, the Tigera operator will keep the
    /// cluster&apos;s Gateway API CRDs aligned with those that it would install on a cluster that
    /// does not yet have any version of those CRDs.
    /// </summary>
    [JsonPropertyName("crdManagement")]
    public V1GatewayAPISpecCrdManagementEnum? CrdManagement { get; set; }

    /// <summary>
    /// Reference to a custom EnvoyGateway YAML to use as the base EnvoyGateway configuration for
    /// the gateway controller.  When specified, must identify a ConfigMap resource with an
    /// &quot;envoy-gateway.yaml&quot; key whose value is the desired EnvoyGateway YAML (i.e. following the
    /// same pattern as the default `envoy-gateway-config` ConfigMap).
    /// When not specified, the Tigera operator uses the `envoy-gateway-config` from the Envoy
    /// Gateway helm chart as its base.
    /// Starting from that base, the Tigera operator copies and modifies the EnvoyGateway
    /// resource as follows:
    /// 1. If not already specified, it sets the ControllerName to
    /// &quot;gateway.envoyproxy.io/gatewayclass-controller&quot;.
    /// 2. It configures the `tigera/envoy-gateway` and `tigera/envoy-ratelimit` images that will
    /// be used (according to the current Calico version, private registry and image set
    /// settings) and any pull secrets that are needed to pull those images.
    /// 3. It enables use of the Backend API.
    /// The resulting EnvoyGateway is provisioned as the `envoy-gateway-config` ConfigMap (which
    /// the gateway controller then uses as its config).
    /// </summary>
    [JsonPropertyName("envoyGatewayConfigRef")]
    public V1GatewayAPISpecEnvoyGatewayConfigRef? EnvoyGatewayConfigRef { get; set; }

    /// <summary>Allows customization of the gateway certgen job.</summary>
    [JsonPropertyName("gatewayCertgenJob")]
    public V1GatewayAPISpecGatewayCertgenJob? GatewayCertgenJob { get; set; }

    /// <summary>
    /// Configures the GatewayClasses that will be available; please see GatewayClassSpec for
    /// more detail.  If GatewayClasses is nil, the Tigera operator defaults to provisioning a
    /// single GatewayClass named &quot;tigera-gateway-class&quot;, without any of the detailed
    /// customizations that are allowed within GatewayClassSpec.
    /// </summary>
    [JsonPropertyName("gatewayClasses")]
    public IList<V1GatewayAPISpecGatewayClasses>? GatewayClasses { get; set; }

    /// <summary>Allows customization of the gateway controller deployment.</summary>
    [JsonPropertyName("gatewayControllerDeployment")]
    public V1GatewayAPISpecGatewayControllerDeployment? GatewayControllerDeployment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GatewayAPI : IKubernetesObject<V1ObjectMeta>, ISpec<V1GatewayAPISpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GatewayAPI";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "gatewayapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayAPI";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GatewayAPISpec has fields that can be used to customize our GatewayAPI support.</summary>
    [JsonPropertyName("spec")]
    public V1GatewayAPISpec? Spec { get; set; }
}