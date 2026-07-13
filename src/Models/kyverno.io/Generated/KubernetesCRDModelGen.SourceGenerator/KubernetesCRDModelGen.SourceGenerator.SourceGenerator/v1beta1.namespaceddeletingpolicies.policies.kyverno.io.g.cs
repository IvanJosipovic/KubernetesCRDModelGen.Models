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
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NamespacedDeletingPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NamespacedDeletingPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NamespacedDeletingPolicyList";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "namespaceddeletingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacedDeletingPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1NamespacedDeletingPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1NamespacedDeletingPolicy> Items { get; set; }
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedDeletingPolicySpecConditions
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

/// <summary>DeletionPropagationPolicy defines how resources will be deleted (Foreground, Background, Orphan).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespacedDeletingPolicySpecDeletionPropagationPolicyEnum>))]
public enum V1beta1NamespacedDeletingPolicySpecDeletionPropagationPolicyEnum
{
    [EnumMember(Value = "Foreground"), JsonStringEnumMemberName("Foreground")]
    Foreground,
    [EnumMember(Value = "Background"), JsonStringEnumMemberName("Background")]
    Background,
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan
}

/// <summary>NamedRuleWithOperations is a tuple of Operations and Resources with ResourceNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedDeletingPolicySpecMatchConstraintsExcludeResourceRules
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
public partial class V1beta1NamespacedDeletingPolicySpecMatchConstraintsNamespaceSelectorMatchExpressions
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
public partial class V1beta1NamespacedDeletingPolicySpecMatchConstraintsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1beta1NamespacedDeletingPolicySpecMatchConstraintsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1beta1NamespacedDeletingPolicySpecMatchConstraintsObjectSelectorMatchExpressions
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
public partial class V1beta1NamespacedDeletingPolicySpecMatchConstraintsObjectSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1beta1NamespacedDeletingPolicySpecMatchConstraintsObjectSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1beta1NamespacedDeletingPolicySpecMatchConstraintsResourceRules
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
/// MatchConstraints specifies what resources this policy is designed to validate.
/// The AdmissionPolicy cares about a request if it matches _all_ Constraints.
/// Required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedDeletingPolicySpecMatchConstraints
{
    /// <summary>
    /// ExcludeResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy should not care about.
    /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
    /// </summary>
    [JsonPropertyName("excludeResourceRules")]
    public IList<V1beta1NamespacedDeletingPolicySpecMatchConstraintsExcludeResourceRules>? ExcludeResourceRules { get; set; }

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
    public V1beta1NamespacedDeletingPolicySpecMatchConstraintsNamespaceSelector? NamespaceSelector { get; set; }

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
    public V1beta1NamespacedDeletingPolicySpecMatchConstraintsObjectSelector? ObjectSelector { get; set; }

    /// <summary>
    /// ResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy matches.
    /// The policy cares about an operation if it matches _any_ Rule.
    /// </summary>
    [JsonPropertyName("resourceRules")]
    public IList<V1beta1NamespacedDeletingPolicySpecMatchConstraintsResourceRules>? ResourceRules { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedDeletingPolicySpecVariables
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

/// <summary>DeletingPolicySpec is the specification of the desired behavior of the DeletingPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedDeletingPolicySpec
{
    /// <summary>
    /// Conditions is a list of conditions that must be met for a resource to be deleted.
    /// Conditions filter resources that have already been matched by the match constraints,
    /// namespaceSelector, and objectSelector. An empty list of conditions matches all resources.
    /// There are a maximum of 64 conditions allowed.
    /// 
    /// The exact matching logic is (in order):
    ///   1. If ANY condition evaluates to FALSE, the policy is skipped.
    ///   2. If ALL conditions evaluate to TRUE, the policy is executed.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NamespacedDeletingPolicySpecConditions>? Conditions { get; set; }

    /// <summary>DeletionPropagationPolicy defines how resources will be deleted (Foreground, Background, Orphan).</summary>
    [JsonPropertyName("deletionPropagationPolicy")]
    public V1beta1NamespacedDeletingPolicySpecDeletionPropagationPolicyEnum? DeletionPropagationPolicy { get; set; }

    /// <summary>
    /// MatchConstraints specifies what resources this policy is designed to validate.
    /// The AdmissionPolicy cares about a request if it matches _all_ Constraints.
    /// Required.
    /// </summary>
    [JsonPropertyName("matchConstraints")]
    public V1beta1NamespacedDeletingPolicySpecMatchConstraints? MatchConstraints { get; set; }

    /// <summary>
    /// The schedule in Cron format
    /// Required.
    /// </summary>
    [JsonPropertyName("schedule")]
    public required string Schedule { get; set; }

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
    public IList<V1beta1NamespacedDeletingPolicySpecVariables>? Variables { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespacedDeletingPolicyStatusConditionStatusConditionsStatusEnum>))]
public enum V1beta1NamespacedDeletingPolicyStatusConditionStatusConditionsStatusEnum
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
public partial class V1beta1NamespacedDeletingPolicyStatusConditionStatusConditions
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
    public required V1beta1NamespacedDeletingPolicyStatusConditionStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ConditionStatus is the shared status across all policy types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedDeletingPolicyStatusConditionStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1beta1NamespacedDeletingPolicyStatusConditionStatusConditions>? Conditions { get; set; }

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
public partial class V1beta1NamespacedDeletingPolicyStatus
{
    /// <summary>ConditionStatus is the shared status across all policy types</summary>
    [JsonPropertyName("conditionStatus")]
    public V1beta1NamespacedDeletingPolicyStatusConditionStatus? ConditionStatus { get; set; }

    [JsonPropertyName("lastExecutionTime")]
    public DateTime? LastExecutionTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NamespacedDeletingPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NamespacedDeletingPolicySpec>, IStatus<V1beta1NamespacedDeletingPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NamespacedDeletingPolicy";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "namespaceddeletingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacedDeletingPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeletingPolicySpec is the specification of the desired behavior of the DeletingPolicy.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1NamespacedDeletingPolicySpec Spec { get; set; }

    /// <summary>Status contains policy runtime data.</summary>
    [JsonPropertyName("status")]
    public V1beta1NamespacedDeletingPolicyStatus? Status { get; set; }
}