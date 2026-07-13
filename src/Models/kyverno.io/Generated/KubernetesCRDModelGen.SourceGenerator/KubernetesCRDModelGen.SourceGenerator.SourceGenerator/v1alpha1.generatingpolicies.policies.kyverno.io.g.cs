#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.policies.kyverno.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GeneratingPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1GeneratingPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GeneratingPolicyList";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "generatingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GeneratingPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1GeneratingPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1GeneratingPolicy> Items { get; set; }
}

/// <summary>Admission controls policy evaluation during admission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecEvaluationAdmission
{
    /// <summary>
    /// Enabled controls if rules are applied during admission.
    /// Optional. Default value is &quot;true&quot;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>GenerateExisting defines the configuration for generating resources for existing triggeres.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecEvaluationGenerateExisting
{
    /// <summary>
    /// Enabled controls whether to trigger the policy for existing resources
    /// If is set to &quot;true&quot; the policy will be triggered and applied to existing matched resources.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>OrphanDownstreamOnPolicyDelete defines the configuration for orphaning downstream resources on policy delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecEvaluationOrphanDownstreamOnPolicyDelete
{
    /// <summary>
    /// Enabled controls whether generated resources should be deleted when the policy that generated
    /// them is deleted with synchronization enabled. This option is only applicable to generate rules of the data type.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Synchronization defines the configuration for the synchronization of generated resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecEvaluationSynchronize
{
    /// <summary>
    /// Enabled controls if generated resources should be kept in-sync with their source resource.
    /// If Synchronize is set to &quot;true&quot; changes to generated resources will be overwritten with resource
    /// data from Data or the resource specified in the Clone declaration.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecEvaluation
{
    /// <summary>Admission controls policy evaluation during admission.</summary>
    [JsonPropertyName("admission")]
    public V1alpha1GeneratingPolicySpecEvaluationAdmission? Admission { get; set; }

    /// <summary>GenerateExisting defines the configuration for generating resources for existing triggeres.</summary>
    [JsonPropertyName("generateExisting")]
    public V1alpha1GeneratingPolicySpecEvaluationGenerateExisting? GenerateExisting { get; set; }

    /// <summary>OrphanDownstreamOnPolicyDelete defines the configuration for orphaning downstream resources on policy delete.</summary>
    [JsonPropertyName("orphanDownstreamOnPolicyDelete")]
    public V1alpha1GeneratingPolicySpecEvaluationOrphanDownstreamOnPolicyDelete? OrphanDownstreamOnPolicyDelete { get; set; }

    /// <summary>Synchronization defines the configuration for the synchronization of generated resources.</summary>
    [JsonPropertyName("synchronize")]
    public V1alpha1GeneratingPolicySpecEvaluationSynchronize? Synchronize { get; set; }
}

/// <summary>Generation defines the configuration for the generation of resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecGenerate
{
    /// <summary>Expression is a CEL expression that takes a list of resources to be generated.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecMatchConditions
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL. Must evaluate to bool.
    /// CEL expressions have access to the contents of the AdmissionRequest and Authorizer, organized into CEL variables:
    /// 
    /// &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// &apos;request&apos; - Attributes of the admission request(/pkg/apis/admission/types.go#AdmissionRequest).
    /// &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// Documentation on CEL: https://kubernetes.io/docs/reference/using-api/cel/
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is an identifier for this match condition, used for strategic merging of MatchConditions,
    /// as well as providing an identifier for logging purposes. A good name should be descriptive of
    /// the associated expression.
    /// Name must be a qualified name consisting of alphanumeric characters, &apos;-&apos;, &apos;_&apos; or &apos;.&apos;, and
    /// must start and end with an alphanumeric character (e.g. &apos;MyName&apos;,  or &apos;my.name&apos;,  or
    /// &apos;123-abc&apos;, regex used for validation is &apos;([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]&apos;) with an
    /// optional DNS subdomain prefix and &apos;/&apos; (e.g. &apos;example.com/MyName&apos;)
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>NamedRuleWithOperations is a tuple of Operations and Resources with ResourceNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecMatchConstraintsExcludeResourceRules
{
    /// <summary>
    /// APIGroups is the API groups the resources belong to. &apos;*&apos; is all groups.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiGroups")]
    public IList<string>? ApiGroups { get; set; }

    /// <summary>
    /// APIVersions is the API versions the resources belong to. &apos;*&apos; is all versions.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>
    /// Operations is the operations the admission hook cares about - CREATE, UPDATE, DELETE, CONNECT or *
    /// for all of those operations and any future admission operations that are added.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<string>? Operations { get; set; }

    /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>
    /// Resources is a list of resources this rule applies to.
    /// 
    /// For example:
    /// &apos;pods&apos; means pods.
    /// &apos;pods/log&apos; means the log subresource of pods.
    /// &apos;*&apos; means all resources, but not subresources.
    /// &apos;pods/*&apos; means all subresources of pods.
    /// &apos;*/scale&apos; means all scale subresources.
    /// &apos;*/*&apos; means all resources and their subresources.
    /// 
    /// If wildcard is present, the validation rule will ensure resources do not
    /// overlap with each other.
    /// 
    /// Depending on the enclosing object, subresources might not be allowed.
    /// Required.
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// scope specifies the scope of this rule.
    /// Valid values are &quot;Cluster&quot;, &quot;Namespaced&quot;, and &quot;*&quot;
    /// &quot;Cluster&quot; means that only cluster-scoped resources will match this rule.
    /// Namespace API objects are cluster-scoped.
    /// &quot;Namespaced&quot; means that only namespaced resources will match this rule.
    /// &quot;*&quot; means that there are no scope restrictions.
    /// Subresources match the scope of their parent resource.
    /// Default is &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecMatchConstraintsNamespaceSelectorMatchExpressions
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
/// NamespaceSelector decides whether to run the admission control policy on an object based
/// on whether the namespace for that object matches the selector. If the
/// object itself is a namespace, the matching is performed on
/// object.metadata.labels. If the object is another cluster scoped resource,
/// it never skips the policy.
/// 
/// For example, to run the webhook on any objects whose namespace is not
/// associated with &quot;runlevel&quot; of &quot;0&quot; or &quot;1&quot;;  you will set the selector as
/// follows:
/// &quot;namespaceSelector&quot;: {
///   &quot;matchExpressions&quot;: [
///     {
///       &quot;key&quot;: &quot;runlevel&quot;,
///       &quot;operator&quot;: &quot;NotIn&quot;,
///       &quot;values&quot;: [
///         &quot;0&quot;,
///         &quot;1&quot;
///       ]
///     }
///   ]
/// }
/// 
/// If instead you want to only run the policy on any objects whose
/// namespace is associated with the &quot;environment&quot; of &quot;prod&quot; or &quot;staging&quot;;
/// you will set the selector as follows:
/// &quot;namespaceSelector&quot;: {
///   &quot;matchExpressions&quot;: [
///     {
///       &quot;key&quot;: &quot;environment&quot;,
///       &quot;operator&quot;: &quot;In&quot;,
///       &quot;values&quot;: [
///         &quot;prod&quot;,
///         &quot;staging&quot;
///       ]
///     }
///   ]
/// }
/// 
/// See
/// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
/// for more examples of label selectors.
/// 
/// Default to the empty LabelSelector, which matches everything.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecMatchConstraintsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1GeneratingPolicySpecMatchConstraintsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecMatchConstraintsObjectSelectorMatchExpressions
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
/// ObjectSelector decides whether to run the validation based on if the
/// object has matching labels. objectSelector is evaluated against both
/// the oldObject and newObject that would be sent to the cel validation, and
/// is considered to match if either object matches the selector. A null
/// object (oldObject in the case of create, or newObject in the case of
/// delete) or an object that cannot have labels (like a
/// DeploymentRollback or a PodProxyOptions object) is not considered to
/// match.
/// Use the object selector only if the webhook is opt-in, because end
/// users may skip the admission webhook by setting the labels.
/// Default to the empty LabelSelector, which matches everything.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecMatchConstraintsObjectSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1GeneratingPolicySpecMatchConstraintsObjectSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>NamedRuleWithOperations is a tuple of Operations and Resources with ResourceNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecMatchConstraintsResourceRules
{
    /// <summary>
    /// APIGroups is the API groups the resources belong to. &apos;*&apos; is all groups.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiGroups")]
    public IList<string>? ApiGroups { get; set; }

    /// <summary>
    /// APIVersions is the API versions the resources belong to. &apos;*&apos; is all versions.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>
    /// Operations is the operations the admission hook cares about - CREATE, UPDATE, DELETE, CONNECT or *
    /// for all of those operations and any future admission operations that are added.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<string>? Operations { get; set; }

    /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>
    /// Resources is a list of resources this rule applies to.
    /// 
    /// For example:
    /// &apos;pods&apos; means pods.
    /// &apos;pods/log&apos; means the log subresource of pods.
    /// &apos;*&apos; means all resources, but not subresources.
    /// &apos;pods/*&apos; means all subresources of pods.
    /// &apos;*/scale&apos; means all scale subresources.
    /// &apos;*/*&apos; means all resources and their subresources.
    /// 
    /// If wildcard is present, the validation rule will ensure resources do not
    /// overlap with each other.
    /// 
    /// Depending on the enclosing object, subresources might not be allowed.
    /// Required.
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// scope specifies the scope of this rule.
    /// Valid values are &quot;Cluster&quot;, &quot;Namespaced&quot;, and &quot;*&quot;
    /// &quot;Cluster&quot; means that only cluster-scoped resources will match this rule.
    /// Namespace API objects are cluster-scoped.
    /// &quot;Namespaced&quot; means that only namespaced resources will match this rule.
    /// &quot;*&quot; means that there are no scope restrictions.
    /// Subresources match the scope of their parent resource.
    /// Default is &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>
/// MatchConstraints specifies what resources will trigger this policy.
/// The AdmissionPolicy cares about a request if it matches _all_ Constraints.
/// Required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecMatchConstraints
{
    /// <summary>
    /// ExcludeResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy should not care about.
    /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
    /// </summary>
    [JsonPropertyName("excludeResourceRules")]
    public IList<V1alpha1GeneratingPolicySpecMatchConstraintsExcludeResourceRules>? ExcludeResourceRules { get; set; }

    /// <summary>
    /// matchPolicy defines how the &quot;MatchResources&quot; list is used to match incoming requests.
    /// Allowed values are &quot;Exact&quot; or &quot;Equivalent&quot;.
    /// 
    /// - Exact: match a request only if it exactly matches a specified rule.
    /// For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1,
    /// but &quot;rules&quot; only included `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]`,
    /// a request to apps/v1beta1 or extensions/v1beta1 would not be sent to the ValidatingAdmissionPolicy.
    /// 
    /// - Equivalent: match a request if modifies a resource listed in rules, even via another API group or version.
    /// For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1,
    /// and &quot;rules&quot; only included `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]`,
    /// a request to apps/v1beta1 or extensions/v1beta1 would be converted to apps/v1 and sent to the ValidatingAdmissionPolicy.
    /// 
    /// Defaults to &quot;Equivalent&quot;
    /// </summary>
    [JsonPropertyName("matchPolicy")]
    public string? MatchPolicy { get; set; }

    /// <summary>
    /// NamespaceSelector decides whether to run the admission control policy on an object based
    /// on whether the namespace for that object matches the selector. If the
    /// object itself is a namespace, the matching is performed on
    /// object.metadata.labels. If the object is another cluster scoped resource,
    /// it never skips the policy.
    /// 
    /// For example, to run the webhook on any objects whose namespace is not
    /// associated with &quot;runlevel&quot; of &quot;0&quot; or &quot;1&quot;;  you will set the selector as
    /// follows:
    /// &quot;namespaceSelector&quot;: {
    ///   &quot;matchExpressions&quot;: [
    ///     {
    ///       &quot;key&quot;: &quot;runlevel&quot;,
    ///       &quot;operator&quot;: &quot;NotIn&quot;,
    ///       &quot;values&quot;: [
    ///         &quot;0&quot;,
    ///         &quot;1&quot;
    ///       ]
    ///     }
    ///   ]
    /// }
    /// 
    /// If instead you want to only run the policy on any objects whose
    /// namespace is associated with the &quot;environment&quot; of &quot;prod&quot; or &quot;staging&quot;;
    /// you will set the selector as follows:
    /// &quot;namespaceSelector&quot;: {
    ///   &quot;matchExpressions&quot;: [
    ///     {
    ///       &quot;key&quot;: &quot;environment&quot;,
    ///       &quot;operator&quot;: &quot;In&quot;,
    ///       &quot;values&quot;: [
    ///         &quot;prod&quot;,
    ///         &quot;staging&quot;
    ///       ]
    ///     }
    ///   ]
    /// }
    /// 
    /// See
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
    /// for more examples of label selectors.
    /// 
    /// Default to the empty LabelSelector, which matches everything.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1GeneratingPolicySpecMatchConstraintsNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// ObjectSelector decides whether to run the validation based on if the
    /// object has matching labels. objectSelector is evaluated against both
    /// the oldObject and newObject that would be sent to the cel validation, and
    /// is considered to match if either object matches the selector. A null
    /// object (oldObject in the case of create, or newObject in the case of
    /// delete) or an object that cannot have labels (like a
    /// DeploymentRollback or a PodProxyOptions object) is not considered to
    /// match.
    /// Use the object selector only if the webhook is opt-in, because end
    /// users may skip the admission webhook by setting the labels.
    /// Default to the empty LabelSelector, which matches everything.
    /// </summary>
    [JsonPropertyName("objectSelector")]
    public V1alpha1GeneratingPolicySpecMatchConstraintsObjectSelector? ObjectSelector { get; set; }

    /// <summary>
    /// ResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy matches.
    /// The policy cares about an operation if it matches _any_ Rule.
    /// </summary>
    [JsonPropertyName("resourceRules")]
    public IList<V1alpha1GeneratingPolicySpecMatchConstraintsResourceRules>? ResourceRules { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecVariables
{
    /// <summary>
    /// Expression is the expression that will be evaluated as the value of the variable.
    /// The CEL expression has access to the same identifiers as the CEL expressions in Validation.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is the name of the variable. The name must be a valid CEL identifier and unique among all variables.
    /// The variable can be accessed in other expressions through `variables`
    /// For example, if name is &quot;foo&quot;, the variable will be available as `variables.foo`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WebhookConfiguration defines the configuration for the webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpecWebhookConfiguration
{
    /// <summary>
    /// TimeoutSeconds specifies the maximum time in seconds allowed to apply this policy.
    /// After the configured time expires, the admission request may fail, or may simply ignore the policy results,
    /// based on the failure policy. The default timeout is 10s, the value must be between 1 and 30 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>GeneratingPolicySpec is the specification of the desired behavior of the GeneratingPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicySpec
{
    /// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
    [JsonPropertyName("evaluation")]
    public V1alpha1GeneratingPolicySpecEvaluation? Evaluation { get; set; }

    /// <summary>
    /// Generation defines a set of CEL expressions that will be evaluated to generate resources.
    /// Required.
    /// </summary>
    [JsonPropertyName("generate")]
    public required IList<V1alpha1GeneratingPolicySpecGenerate> Generate { get; set; }

    /// <summary>
    /// MatchConditions is a list of conditions that must be met for a request to be validated.
    /// Match conditions filter requests that have already been matched by the rules,
    /// namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests.
    /// There are a maximum of 64 match conditions allowed.
    /// 
    /// The exact matching logic is (in order):
    ///   1. If ANY matchCondition evaluates to FALSE, the policy is skipped.
    ///   2. If ALL matchConditions evaluate to TRUE, the policy is evaluated.
    ///   3. If any matchCondition evaluates to an error (but none are FALSE):
    ///      - If failurePolicy=Fail, reject the request
    ///      - If failurePolicy=Ignore, the policy is skipped
    /// </summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1alpha1GeneratingPolicySpecMatchConditions>? MatchConditions { get; set; }

    /// <summary>
    /// MatchConstraints specifies what resources will trigger this policy.
    /// The AdmissionPolicy cares about a request if it matches _all_ Constraints.
    /// Required.
    /// </summary>
    [JsonPropertyName("matchConstraints")]
    public V1alpha1GeneratingPolicySpecMatchConstraints? MatchConstraints { get; set; }

    /// <summary>
    /// Variables contain definitions of variables that can be used in composition of other expressions.
    /// Each variable is defined as a named CEL expression.
    /// The variables defined here will be available under `variables` in other expressions of the policy
    /// except MatchConditions because MatchConditions are evaluated before the rest of the policy.
    /// 
    /// The expression of a variable can refer to other variables defined earlier in the list but not those after.
    /// Thus, Variables must be sorted by the order of first appearance and acyclic.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V1alpha1GeneratingPolicySpecVariables>? Variables { get; set; }

    /// <summary>WebhookConfiguration defines the configuration for the webhook.</summary>
    [JsonPropertyName("webhookConfiguration")]
    public V1alpha1GeneratingPolicySpecWebhookConfiguration? WebhookConfiguration { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1GeneratingPolicyStatusConditionStatusConditionsStatusEnum>))]
[global::System.Obsolete]
public enum V1alpha1GeneratingPolicyStatusConditionStatusConditionsStatusEnum
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
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicyStatusConditionStatusConditions
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
    public required V1alpha1GeneratingPolicyStatusConditionStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ConditionStatus is the shared status across all policy types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicyStatusConditionStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GeneratingPolicyStatusConditionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Message is a human readable message indicating details about the generation of ValidatingAdmissionPolicy/MutatingAdmissionPolicy
    /// It is an empty string when ValidatingAdmissionPolicy/MutatingAdmissionPolicy is successfully generated.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// The ready of a policy is a high-level summary of where the policy is in its lifecycle.
    /// The conditions array, the reason and message fields contain more detail about the policy&apos;s status.
    /// </summary>
    [JsonPropertyName("ready")]
    public bool? Ready { get; set; }
}

/// <summary>Status contains policy runtime data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1GeneratingPolicyStatus
{
    /// <summary>ConditionStatus is the shared status across all policy types</summary>
    [JsonPropertyName("conditionStatus")]
    public V1alpha1GeneratingPolicyStatusConditionStatus? ConditionStatus { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GeneratingPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GeneratingPolicySpec>, IStatus<V1alpha1GeneratingPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GeneratingPolicy";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "generatingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GeneratingPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GeneratingPolicySpec is the specification of the desired behavior of the GeneratingPolicy.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1GeneratingPolicySpec Spec { get; set; }

    /// <summary>Status contains policy runtime data.</summary>
    [JsonPropertyName("status")]
    public V1alpha1GeneratingPolicyStatus? Status { get; set; }
}