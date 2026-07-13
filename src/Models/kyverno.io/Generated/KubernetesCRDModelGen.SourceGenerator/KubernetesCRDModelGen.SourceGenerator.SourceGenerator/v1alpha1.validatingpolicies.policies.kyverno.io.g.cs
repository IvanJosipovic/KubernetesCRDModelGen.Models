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
public partial class V1alpha1ValidatingPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ValidatingPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ValidatingPolicyList";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "validatingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ValidatingPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ValidatingPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ValidatingPolicy> Items { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecAuditAnnotations
{
    /// <summary>
    /// key specifies the audit annotation key. The audit annotation keys of
    /// a ValidatingAdmissionPolicy must be unique. The key must be a qualified
    /// name ([A-Za-z0-9][-A-Za-z0-9_.]*) no more than 63 bytes in length.
    /// 
    /// The key is combined with the resource name of the
    /// ValidatingAdmissionPolicy to construct an audit annotation key:
    /// &quot;{ValidatingAdmissionPolicy name}/{key}&quot;.
    /// 
    /// If an admission webhook uses the same resource name as this ValidatingAdmissionPolicy
    /// and the same audit annotation key, the annotation key will be identical.
    /// In this case, the first annotation written with the key will be included
    /// in the audit event and all subsequent annotations with the same key
    /// will be discarded.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// valueExpression represents the expression which is evaluated by CEL to
    /// produce an audit annotation value. The expression must evaluate to either
    /// a string or null value. If the expression evaluates to a string, the
    /// audit annotation is included with the string value. If the expression
    /// evaluates to null or empty string the audit annotation will be omitted.
    /// The valueExpression may be no longer than 5kb in length.
    /// If the result of the valueExpression is more than 10kb in length, it
    /// will be truncated to 10kb.
    /// 
    /// If multiple ValidatingAdmissionPolicyBinding resources match an
    /// API request, then the valueExpression will be evaluated for
    /// each binding. All unique values produced by the valueExpressions
    /// will be joined together in a comma-separated list.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("valueExpression")]
    public required string ValueExpression { get; set; }
}

/// <summary>PodControllers specifies whether to generate a pod controllers rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecAutogenPodControllers
{
    [JsonPropertyName("controllers")]
    public IList<string>? Controllers { get; set; }
}

/// <summary>ValidatingAdmissionPolicy specifies whether to generate a Kubernetes ValidatingAdmissionPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecAutogenValidatingAdmissionPolicy
{
    /// <summary>
    /// Enabled specifies whether to generate a Kubernetes ValidatingAdmissionPolicy.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>AutogenConfiguration defines the configuration for the generation controller.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecAutogen
{
    /// <summary>PodControllers specifies whether to generate a pod controllers rules.</summary>
    [JsonPropertyName("podControllers")]
    public V1alpha1ValidatingPolicySpecAutogenPodControllers? PodControllers { get; set; }

    /// <summary>ValidatingAdmissionPolicy specifies whether to generate a Kubernetes ValidatingAdmissionPolicy.</summary>
    [JsonPropertyName("validatingAdmissionPolicy")]
    public V1alpha1ValidatingPolicySpecAutogenValidatingAdmissionPolicy? ValidatingAdmissionPolicy { get; set; }
}

/// <summary>Admission controls policy evaluation during admission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecEvaluationAdmission
{
    /// <summary>
    /// Enabled controls if rules are applied during admission.
    /// Optional. Default value is &quot;true&quot;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Background  controls policy evaluation during background scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecEvaluationBackground
{
    /// <summary>
    /// Enabled controls if rules are applied to existing resources during a background scan.
    /// Optional. Default value is &quot;true&quot;. The value must be set to &quot;false&quot; if the policy rule
    /// uses variables that are only available in the admission review request (e.g. user name).
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecEvaluation
{
    /// <summary>Admission controls policy evaluation during admission.</summary>
    [JsonPropertyName("admission")]
    public V1alpha1ValidatingPolicySpecEvaluationAdmission? Admission { get; set; }

    /// <summary>Background  controls policy evaluation during background scan.</summary>
    [JsonPropertyName("background")]
    public V1alpha1ValidatingPolicySpecEvaluationBackground? Background { get; set; }

    /// <summary>
    /// Mode is the mode of policy evaluation.
    /// Allowed values are &quot;Kubernetes&quot; or &quot;JSON&quot;.
    /// Optional. Default value is &quot;Kubernetes&quot;.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// failurePolicy defines how to handle failures for the admission policy. Failures can
/// occur from CEL expression parse errors, type check errors, runtime errors and invalid
/// or mis-configured policy definitions or bindings.
/// 
/// failurePolicy does not define how validations that evaluate to false are handled.
/// 
/// When failurePolicy is set to Fail, the validationActions field define how failures are enforced.
/// 
/// Allowed values are Ignore or Fail. Defaults to Fail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ValidatingPolicySpecFailurePolicyEnum>))]
[global::System.Obsolete]
public enum V1alpha1ValidatingPolicySpecFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecMatchConditions
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
public partial class V1alpha1ValidatingPolicySpecMatchConstraintsExcludeResourceRules
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
public partial class V1alpha1ValidatingPolicySpecMatchConstraintsNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ValidatingPolicySpecMatchConstraintsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ValidatingPolicySpecMatchConstraintsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1alpha1ValidatingPolicySpecMatchConstraintsObjectSelectorMatchExpressions
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
public partial class V1alpha1ValidatingPolicySpecMatchConstraintsObjectSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ValidatingPolicySpecMatchConstraintsObjectSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1alpha1ValidatingPolicySpecMatchConstraintsResourceRules
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
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecMatchConstraints
{
    /// <summary>
    /// ExcludeResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy should not care about.
    /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
    /// </summary>
    [JsonPropertyName("excludeResourceRules")]
    public IList<V1alpha1ValidatingPolicySpecMatchConstraintsExcludeResourceRules>? ExcludeResourceRules { get; set; }

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
    public V1alpha1ValidatingPolicySpecMatchConstraintsNamespaceSelector? NamespaceSelector { get; set; }

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
    public V1alpha1ValidatingPolicySpecMatchConstraintsObjectSelector? ObjectSelector { get; set; }

    /// <summary>
    /// ResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy matches.
    /// The policy cares about an operation if it matches _any_ Rule.
    /// </summary>
    [JsonPropertyName("resourceRules")]
    public IList<V1alpha1ValidatingPolicySpecMatchConstraintsResourceRules>? ResourceRules { get; set; }
}

/// <summary>ValidationAction specifies a policy enforcement action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ValidatingPolicySpecValidationActionsEnum>))]
[global::System.Obsolete]
public enum V1alpha1ValidatingPolicySpecValidationActionsEnum
{
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Warn"), JsonStringEnumMemberName("Warn")]
    Warn
}

/// <summary>Validation specifies the CEL expression which is used to apply the validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecValidations
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL.
    /// ref: https://github.com/google/cel-spec
    /// CEL expressions have access to the contents of the API request/response, organized into CEL variables as well as some other useful variables:
    /// 
    /// - &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// - &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// - &apos;request&apos; - Attributes of the API request([ref](/pkg/apis/admission/types.go#AdmissionRequest)).
    /// - &apos;params&apos; - Parameter resource referred to by the policy binding being evaluated. Only populated if the policy has a ParamKind.
    /// - &apos;namespaceObject&apos; - The namespace object that the incoming object belongs to. The value is null for cluster-scoped resources.
    /// - &apos;variables&apos; - Map of composited variables, from its name to its lazily evaluated value.
    ///   For example, a variable named &apos;foo&apos; can be accessed as &apos;variables.foo&apos;.
    /// - &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// - &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// 
    /// The `apiVersion`, `kind`, `metadata.name` and `metadata.generateName` are always accessible from the root of the
    /// object. No other metadata properties are accessible.
    /// 
    /// Only property names of the form `[a-zA-Z_.-/][a-zA-Z0-9_.-/]*` are accessible.
    /// Accessible property names are escaped according to the following rules when accessed in the expression:
    /// - &apos;__&apos; escapes to &apos;__underscores__&apos;
    /// - &apos;.&apos; escapes to &apos;__dot__&apos;
    /// - &apos;-&apos; escapes to &apos;__dash__&apos;
    /// - &apos;/&apos; escapes to &apos;__slash__&apos;
    /// - Property names that exactly match a CEL RESERVED keyword escape to &apos;__{keyword}__&apos;. The keywords are:
    /// 	  &quot;true&quot;, &quot;false&quot;, &quot;null&quot;, &quot;in&quot;, &quot;as&quot;, &quot;break&quot;, &quot;const&quot;, &quot;continue&quot;, &quot;else&quot;, &quot;for&quot;, &quot;function&quot;, &quot;if&quot;,
    /// 	  &quot;import&quot;, &quot;let&quot;, &quot;loop&quot;, &quot;package&quot;, &quot;namespace&quot;, &quot;return&quot;.
    /// Examples:
    ///   - Expression accessing a property named &quot;namespace&quot;: {&quot;Expression&quot;: &quot;object.__namespace__ &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;x-prop&quot;: {&quot;Expression&quot;: &quot;object.x__dash__prop &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;redact__d&quot;: {&quot;Expression&quot;: &quot;object.redact__underscores__d &gt; 0&quot;}
    /// 
    /// Equality on arrays with list type of &apos;set&apos; or &apos;map&apos; ignores element order, i.e. [1, 2] == [2, 1].
    /// Concatenation on arrays with x-kubernetes-list-type use the semantics of the list type:
    ///   - &apos;set&apos;: `X + Y` performs a union where the array positions of all elements in `X` are preserved and
    ///     non-intersecting elements in `Y` are appended, retaining their partial order.
    ///   - &apos;map&apos;: `X + Y` performs a merge where the array positions of all keys in `X` are preserved but the values
    ///     are overwritten by values in `Y` when the key sets of `X` and `Y` intersect. Elements in `Y` with
    ///     non-intersecting keys are appended, retaining their partial order.
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Message represents the message displayed when validation fails. The message is required if the Expression contains
    /// line breaks. The message must not contain line breaks.
    /// If unset, the message is &quot;failed rule: {Rule}&quot;.
    /// e.g. &quot;must be a URL with the host matching spec.host&quot;
    /// If the Expression contains line breaks. Message is required.
    /// The message must not contain line breaks.
    /// If unset, the message is &quot;failed Expression: {Expression}&quot;.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// messageExpression declares a CEL expression that evaluates to the validation failure message that is returned when this rule fails.
    /// Since messageExpression is used as a failure message, it must evaluate to a string.
    /// If both message and messageExpression are present on a validation, then messageExpression will be used if validation fails.
    /// If messageExpression results in a runtime error, the runtime error is logged, and the validation failure message is produced
    /// as if the messageExpression field were unset. If messageExpression evaluates to an empty string, a string with only spaces, or a string
    /// that contains line breaks, then the validation failure message will also be produced as if the messageExpression field were unset, and
    /// the fact that messageExpression produced an empty string/string with only spaces/string with line breaks will be logged.
    /// messageExpression has access to all the same variables as the `expression` except for &apos;authorizer&apos; and &apos;authorizer.requestResource&apos;.
    /// Example:
    /// &quot;object.x must be less than max (&quot;+string(params.max)+&quot;)&quot;
    /// </summary>
    [JsonPropertyName("messageExpression")]
    public string? MessageExpression { get; set; }

    /// <summary>
    /// Reason represents a machine-readable description of why this validation failed.
    /// If this is the first validation in the list to fail, this reason, as well as the
    /// corresponding HTTP response code, are used in the
    /// HTTP response to the client.
    /// The currently supported reasons are: &quot;Unauthorized&quot;, &quot;Forbidden&quot;, &quot;Invalid&quot;, &quot;RequestEntityTooLarge&quot;.
    /// If not set, StatusReasonInvalid is used in the response to the client.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpecVariables
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
public partial class V1alpha1ValidatingPolicySpecWebhookConfiguration
{
    /// <summary>
    /// TimeoutSeconds specifies the maximum time in seconds allowed to apply this policy.
    /// After the configured time expires, the admission request may fail, or may simply ignore the policy results,
    /// based on the failure policy. The default timeout is 10s, the value must be between 1 and 30 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ValidatingPolicySpec is the specification of the desired behavior of the ValidatingPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicySpec
{
    /// <summary>
    /// auditAnnotations contains CEL expressions which are used to produce audit
    /// annotations for the audit event of the API request.
    /// validations and auditAnnotations may not both be empty; a least one of validations or auditAnnotations is
    /// required.
    /// </summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V1alpha1ValidatingPolicySpecAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>AutogenConfiguration defines the configuration for the generation controller.</summary>
    [JsonPropertyName("autogen")]
    public V1alpha1ValidatingPolicySpecAutogen? Autogen { get; set; }

    /// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
    [JsonPropertyName("evaluation")]
    public V1alpha1ValidatingPolicySpecEvaluation? Evaluation { get; set; }

    /// <summary>
    /// failurePolicy defines how to handle failures for the admission policy. Failures can
    /// occur from CEL expression parse errors, type check errors, runtime errors and invalid
    /// or mis-configured policy definitions or bindings.
    /// 
    /// failurePolicy does not define how validations that evaluate to false are handled.
    /// 
    /// When failurePolicy is set to Fail, the validationActions field define how failures are enforced.
    /// 
    /// Allowed values are Ignore or Fail. Defaults to Fail.
    /// </summary>
    [JsonPropertyName("failurePolicy")]
    public V1alpha1ValidatingPolicySpecFailurePolicyEnum? FailurePolicy { get; set; }

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
    public IList<V1alpha1ValidatingPolicySpecMatchConditions>? MatchConditions { get; set; }

    /// <summary>
    /// MatchConstraints specifies what resources this policy is designed to validate.
    /// The AdmissionPolicy cares about a request if it matches _all_ Constraints.
    /// Required.
    /// </summary>
    [JsonPropertyName("matchConstraints")]
    public V1alpha1ValidatingPolicySpecMatchConstraints? MatchConstraints { get; set; }

    /// <summary>
    /// ValidationAction specifies the action to be taken when the matched resource violates the policy.
    /// If a validation evaluates to false it is always enforced according to these actions.
    /// 
    /// Failures defined by the ValidatingAdmissionPolicy&apos;s FailurePolicy are enforced according
    /// to these actions only if the FailurePolicy is set to Fail, otherwise the failures are
    /// ignored. This includes compilation errors, runtime errors and misconfigurations of the policy.
    /// 
    /// validationActions is declared as a set of action values. Order does
    /// not matter. validationActions may not contain duplicates of the same action.
    /// 
    /// The supported actions values are:
    /// 
    /// &quot;Deny&quot; specifies that a validation failure results in a denied request.
    /// 
    /// &quot;Warn&quot; specifies that a validation failure is reported to the request client
    /// in HTTP Warning headers, with a warning code of 299. Warnings can be sent
    /// both for allowed or denied admission responses.
    /// 
    /// &quot;Audit&quot; specifies that a validation failure is recorded in the created reports.
    /// 
    /// Clients should expect to handle additional values by ignoring
    /// any values not recognized.
    /// 
    /// &quot;Deny&quot; and &quot;Warn&quot; may not be used together since this combination
    /// needlessly duplicates the validation failure both in the
    /// API response body and the HTTP warning headers.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("validationActions")]
    public IList<V1alpha1ValidatingPolicySpecValidationActionsEnum>? ValidationActions { get; set; }

    /// <summary>
    /// Validations contain CEL expressions which is used to apply the validation.
    /// Validations and AuditAnnotations may not both be empty; a minimum of one Validations or AuditAnnotations is
    /// required.
    /// </summary>
    [JsonPropertyName("validations")]
    public IList<V1alpha1ValidatingPolicySpecValidations>? Validations { get; set; }

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
    public IList<V1alpha1ValidatingPolicySpecVariables>? Variables { get; set; }

    /// <summary>WebhookConfiguration defines the configuration for the webhook.</summary>
    [JsonPropertyName("webhookConfiguration")]
    public V1alpha1ValidatingPolicySpecWebhookConfiguration? WebhookConfiguration { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecAuditAnnotations
{
    /// <summary>
    /// key specifies the audit annotation key. The audit annotation keys of
    /// a ValidatingAdmissionPolicy must be unique. The key must be a qualified
    /// name ([A-Za-z0-9][-A-Za-z0-9_.]*) no more than 63 bytes in length.
    /// 
    /// The key is combined with the resource name of the
    /// ValidatingAdmissionPolicy to construct an audit annotation key:
    /// &quot;{ValidatingAdmissionPolicy name}/{key}&quot;.
    /// 
    /// If an admission webhook uses the same resource name as this ValidatingAdmissionPolicy
    /// and the same audit annotation key, the annotation key will be identical.
    /// In this case, the first annotation written with the key will be included
    /// in the audit event and all subsequent annotations with the same key
    /// will be discarded.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// valueExpression represents the expression which is evaluated by CEL to
    /// produce an audit annotation value. The expression must evaluate to either
    /// a string or null value. If the expression evaluates to a string, the
    /// audit annotation is included with the string value. If the expression
    /// evaluates to null or empty string the audit annotation will be omitted.
    /// The valueExpression may be no longer than 5kb in length.
    /// If the result of the valueExpression is more than 10kb in length, it
    /// will be truncated to 10kb.
    /// 
    /// If multiple ValidatingAdmissionPolicyBinding resources match an
    /// API request, then the valueExpression will be evaluated for
    /// each binding. All unique values produced by the valueExpressions
    /// will be joined together in a comma-separated list.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("valueExpression")]
    public required string ValueExpression { get; set; }
}

/// <summary>PodControllers specifies whether to generate a pod controllers rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecAutogenPodControllers
{
    [JsonPropertyName("controllers")]
    public IList<string>? Controllers { get; set; }
}

/// <summary>ValidatingAdmissionPolicy specifies whether to generate a Kubernetes ValidatingAdmissionPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecAutogenValidatingAdmissionPolicy
{
    /// <summary>
    /// Enabled specifies whether to generate a Kubernetes ValidatingAdmissionPolicy.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>AutogenConfiguration defines the configuration for the generation controller.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecAutogen
{
    /// <summary>PodControllers specifies whether to generate a pod controllers rules.</summary>
    [JsonPropertyName("podControllers")]
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecAutogenPodControllers? PodControllers { get; set; }

    /// <summary>ValidatingAdmissionPolicy specifies whether to generate a Kubernetes ValidatingAdmissionPolicy.</summary>
    [JsonPropertyName("validatingAdmissionPolicy")]
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecAutogenValidatingAdmissionPolicy? ValidatingAdmissionPolicy { get; set; }
}

/// <summary>Admission controls policy evaluation during admission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecEvaluationAdmission
{
    /// <summary>
    /// Enabled controls if rules are applied during admission.
    /// Optional. Default value is &quot;true&quot;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Background  controls policy evaluation during background scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecEvaluationBackground
{
    /// <summary>
    /// Enabled controls if rules are applied to existing resources during a background scan.
    /// Optional. Default value is &quot;true&quot;. The value must be set to &quot;false&quot; if the policy rule
    /// uses variables that are only available in the admission review request (e.g. user name).
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecEvaluation
{
    /// <summary>Admission controls policy evaluation during admission.</summary>
    [JsonPropertyName("admission")]
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecEvaluationAdmission? Admission { get; set; }

    /// <summary>Background  controls policy evaluation during background scan.</summary>
    [JsonPropertyName("background")]
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecEvaluationBackground? Background { get; set; }

    /// <summary>
    /// Mode is the mode of policy evaluation.
    /// Allowed values are &quot;Kubernetes&quot; or &quot;JSON&quot;.
    /// Optional. Default value is &quot;Kubernetes&quot;.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// failurePolicy defines how to handle failures for the admission policy. Failures can
/// occur from CEL expression parse errors, type check errors, runtime errors and invalid
/// or mis-configured policy definitions or bindings.
/// 
/// failurePolicy does not define how validations that evaluate to false are handled.
/// 
/// When failurePolicy is set to Fail, the validationActions field define how failures are enforced.
/// 
/// Allowed values are Ignore or Fail. Defaults to Fail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecFailurePolicyEnum>))]
[global::System.Obsolete]
public enum V1alpha1ValidatingPolicyStatusAutogenConfigsSpecFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConditions
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
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsExcludeResourceRules
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
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsObjectSelectorMatchExpressions
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
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsObjectSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsObjectSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsResourceRules
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
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraints
{
    /// <summary>
    /// ExcludeResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy should not care about.
    /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
    /// </summary>
    [JsonPropertyName("excludeResourceRules")]
    public IList<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsExcludeResourceRules>? ExcludeResourceRules { get; set; }

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
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsNamespaceSelector? NamespaceSelector { get; set; }

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
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsObjectSelector? ObjectSelector { get; set; }

    /// <summary>
    /// ResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy matches.
    /// The policy cares about an operation if it matches _any_ Rule.
    /// </summary>
    [JsonPropertyName("resourceRules")]
    public IList<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsResourceRules>? ResourceRules { get; set; }
}

/// <summary>ValidationAction specifies a policy enforcement action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecValidationActionsEnum>))]
[global::System.Obsolete]
public enum V1alpha1ValidatingPolicyStatusAutogenConfigsSpecValidationActionsEnum
{
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Warn"), JsonStringEnumMemberName("Warn")]
    Warn
}

/// <summary>Validation specifies the CEL expression which is used to apply the validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecValidations
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL.
    /// ref: https://github.com/google/cel-spec
    /// CEL expressions have access to the contents of the API request/response, organized into CEL variables as well as some other useful variables:
    /// 
    /// - &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// - &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// - &apos;request&apos; - Attributes of the API request([ref](/pkg/apis/admission/types.go#AdmissionRequest)).
    /// - &apos;params&apos; - Parameter resource referred to by the policy binding being evaluated. Only populated if the policy has a ParamKind.
    /// - &apos;namespaceObject&apos; - The namespace object that the incoming object belongs to. The value is null for cluster-scoped resources.
    /// - &apos;variables&apos; - Map of composited variables, from its name to its lazily evaluated value.
    ///   For example, a variable named &apos;foo&apos; can be accessed as &apos;variables.foo&apos;.
    /// - &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// - &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// 
    /// The `apiVersion`, `kind`, `metadata.name` and `metadata.generateName` are always accessible from the root of the
    /// object. No other metadata properties are accessible.
    /// 
    /// Only property names of the form `[a-zA-Z_.-/][a-zA-Z0-9_.-/]*` are accessible.
    /// Accessible property names are escaped according to the following rules when accessed in the expression:
    /// - &apos;__&apos; escapes to &apos;__underscores__&apos;
    /// - &apos;.&apos; escapes to &apos;__dot__&apos;
    /// - &apos;-&apos; escapes to &apos;__dash__&apos;
    /// - &apos;/&apos; escapes to &apos;__slash__&apos;
    /// - Property names that exactly match a CEL RESERVED keyword escape to &apos;__{keyword}__&apos;. The keywords are:
    /// 	  &quot;true&quot;, &quot;false&quot;, &quot;null&quot;, &quot;in&quot;, &quot;as&quot;, &quot;break&quot;, &quot;const&quot;, &quot;continue&quot;, &quot;else&quot;, &quot;for&quot;, &quot;function&quot;, &quot;if&quot;,
    /// 	  &quot;import&quot;, &quot;let&quot;, &quot;loop&quot;, &quot;package&quot;, &quot;namespace&quot;, &quot;return&quot;.
    /// Examples:
    ///   - Expression accessing a property named &quot;namespace&quot;: {&quot;Expression&quot;: &quot;object.__namespace__ &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;x-prop&quot;: {&quot;Expression&quot;: &quot;object.x__dash__prop &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;redact__d&quot;: {&quot;Expression&quot;: &quot;object.redact__underscores__d &gt; 0&quot;}
    /// 
    /// Equality on arrays with list type of &apos;set&apos; or &apos;map&apos; ignores element order, i.e. [1, 2] == [2, 1].
    /// Concatenation on arrays with x-kubernetes-list-type use the semantics of the list type:
    ///   - &apos;set&apos;: `X + Y` performs a union where the array positions of all elements in `X` are preserved and
    ///     non-intersecting elements in `Y` are appended, retaining their partial order.
    ///   - &apos;map&apos;: `X + Y` performs a merge where the array positions of all keys in `X` are preserved but the values
    ///     are overwritten by values in `Y` when the key sets of `X` and `Y` intersect. Elements in `Y` with
    ///     non-intersecting keys are appended, retaining their partial order.
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Message represents the message displayed when validation fails. The message is required if the Expression contains
    /// line breaks. The message must not contain line breaks.
    /// If unset, the message is &quot;failed rule: {Rule}&quot;.
    /// e.g. &quot;must be a URL with the host matching spec.host&quot;
    /// If the Expression contains line breaks. Message is required.
    /// The message must not contain line breaks.
    /// If unset, the message is &quot;failed Expression: {Expression}&quot;.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// messageExpression declares a CEL expression that evaluates to the validation failure message that is returned when this rule fails.
    /// Since messageExpression is used as a failure message, it must evaluate to a string.
    /// If both message and messageExpression are present on a validation, then messageExpression will be used if validation fails.
    /// If messageExpression results in a runtime error, the runtime error is logged, and the validation failure message is produced
    /// as if the messageExpression field were unset. If messageExpression evaluates to an empty string, a string with only spaces, or a string
    /// that contains line breaks, then the validation failure message will also be produced as if the messageExpression field were unset, and
    /// the fact that messageExpression produced an empty string/string with only spaces/string with line breaks will be logged.
    /// messageExpression has access to all the same variables as the `expression` except for &apos;authorizer&apos; and &apos;authorizer.requestResource&apos;.
    /// Example:
    /// &quot;object.x must be less than max (&quot;+string(params.max)+&quot;)&quot;
    /// </summary>
    [JsonPropertyName("messageExpression")]
    public string? MessageExpression { get; set; }

    /// <summary>
    /// Reason represents a machine-readable description of why this validation failed.
    /// If this is the first validation in the list to fail, this reason, as well as the
    /// corresponding HTTP response code, are used in the
    /// HTTP response to the client.
    /// The currently supported reasons are: &quot;Unauthorized&quot;, &quot;Forbidden&quot;, &quot;Invalid&quot;, &quot;RequestEntityTooLarge&quot;.
    /// If not set, StatusReasonInvalid is used in the response to the client.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecVariables
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
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpecWebhookConfiguration
{
    /// <summary>
    /// TimeoutSeconds specifies the maximum time in seconds allowed to apply this policy.
    /// After the configured time expires, the admission request may fail, or may simply ignore the policy results,
    /// based on the failure policy. The default timeout is 10s, the value must be between 1 and 30 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ValidatingPolicySpec is the specification of the desired behavior of the ValidatingPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsSpec
{
    /// <summary>
    /// auditAnnotations contains CEL expressions which are used to produce audit
    /// annotations for the audit event of the API request.
    /// validations and auditAnnotations may not both be empty; a least one of validations or auditAnnotations is
    /// required.
    /// </summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>AutogenConfiguration defines the configuration for the generation controller.</summary>
    [JsonPropertyName("autogen")]
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecAutogen? Autogen { get; set; }

    /// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
    [JsonPropertyName("evaluation")]
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecEvaluation? Evaluation { get; set; }

    /// <summary>
    /// failurePolicy defines how to handle failures for the admission policy. Failures can
    /// occur from CEL expression parse errors, type check errors, runtime errors and invalid
    /// or mis-configured policy definitions or bindings.
    /// 
    /// failurePolicy does not define how validations that evaluate to false are handled.
    /// 
    /// When failurePolicy is set to Fail, the validationActions field define how failures are enforced.
    /// 
    /// Allowed values are Ignore or Fail. Defaults to Fail.
    /// </summary>
    [JsonPropertyName("failurePolicy")]
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecFailurePolicyEnum? FailurePolicy { get; set; }

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
    public IList<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConditions>? MatchConditions { get; set; }

    /// <summary>
    /// MatchConstraints specifies what resources this policy is designed to validate.
    /// The AdmissionPolicy cares about a request if it matches _all_ Constraints.
    /// Required.
    /// </summary>
    [JsonPropertyName("matchConstraints")]
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecMatchConstraints? MatchConstraints { get; set; }

    /// <summary>
    /// ValidationAction specifies the action to be taken when the matched resource violates the policy.
    /// If a validation evaluates to false it is always enforced according to these actions.
    /// 
    /// Failures defined by the ValidatingAdmissionPolicy&apos;s FailurePolicy are enforced according
    /// to these actions only if the FailurePolicy is set to Fail, otherwise the failures are
    /// ignored. This includes compilation errors, runtime errors and misconfigurations of the policy.
    /// 
    /// validationActions is declared as a set of action values. Order does
    /// not matter. validationActions may not contain duplicates of the same action.
    /// 
    /// The supported actions values are:
    /// 
    /// &quot;Deny&quot; specifies that a validation failure results in a denied request.
    /// 
    /// &quot;Warn&quot; specifies that a validation failure is reported to the request client
    /// in HTTP Warning headers, with a warning code of 299. Warnings can be sent
    /// both for allowed or denied admission responses.
    /// 
    /// &quot;Audit&quot; specifies that a validation failure is recorded in the created reports.
    /// 
    /// Clients should expect to handle additional values by ignoring
    /// any values not recognized.
    /// 
    /// &quot;Deny&quot; and &quot;Warn&quot; may not be used together since this combination
    /// needlessly duplicates the validation failure both in the
    /// API response body and the HTTP warning headers.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("validationActions")]
    public IList<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecValidationActionsEnum>? ValidationActions { get; set; }

    /// <summary>
    /// Validations contain CEL expressions which is used to apply the validation.
    /// Validations and AuditAnnotations may not both be empty; a minimum of one Validations or AuditAnnotations is
    /// required.
    /// </summary>
    [JsonPropertyName("validations")]
    public IList<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecValidations>? Validations { get; set; }

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
    public IList<V1alpha1ValidatingPolicyStatusAutogenConfigsSpecVariables>? Variables { get; set; }

    /// <summary>WebhookConfiguration defines the configuration for the webhook.</summary>
    [JsonPropertyName("webhookConfiguration")]
    public V1alpha1ValidatingPolicyStatusAutogenConfigsSpecWebhookConfiguration? WebhookConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigsTargets
{
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogenConfigs
{
    /// <summary>ValidatingPolicySpec is the specification of the desired behavior of the ValidatingPolicy.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ValidatingPolicyStatusAutogenConfigsSpec Spec { get; set; }

    [JsonPropertyName("targets")]
    public required IList<V1alpha1ValidatingPolicyStatusAutogenConfigsTargets> Targets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusAutogen
{
    [JsonPropertyName("configs")]
    public IDictionary<string, V1alpha1ValidatingPolicyStatusAutogenConfigs>? Configs { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ValidatingPolicyStatusConditionStatusConditionsStatusEnum>))]
[global::System.Obsolete]
public enum V1alpha1ValidatingPolicyStatusConditionStatusConditionsStatusEnum
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
public partial class V1alpha1ValidatingPolicyStatusConditionStatusConditions
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
    public required V1alpha1ValidatingPolicyStatusConditionStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ConditionStatus is the shared status across all policy types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ValidatingPolicyStatusConditionStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ValidatingPolicyStatusConditionStatusConditions>? Conditions { get; set; }

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
public partial class V1alpha1ValidatingPolicyStatus
{
    [JsonPropertyName("autogen")]
    public V1alpha1ValidatingPolicyStatusAutogen? Autogen { get; set; }

    /// <summary>ConditionStatus is the shared status across all policy types</summary>
    [JsonPropertyName("conditionStatus")]
    public V1alpha1ValidatingPolicyStatusConditionStatus? ConditionStatus { get; set; }

    /// <summary>Generated indicates whether a ValidatingAdmissionPolicy/MutatingAdmissionPolicy is generated from the policy or not</summary>
    [JsonPropertyName("generated")]
    public bool? Generated { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ValidatingPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ValidatingPolicySpec>, IStatus<V1alpha1ValidatingPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ValidatingPolicy";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "validatingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ValidatingPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ValidatingPolicySpec is the specification of the desired behavior of the ValidatingPolicy.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ValidatingPolicySpec Spec { get; set; }

    /// <summary>Status contains policy runtime data.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ValidatingPolicyStatus? Status { get; set; }
}