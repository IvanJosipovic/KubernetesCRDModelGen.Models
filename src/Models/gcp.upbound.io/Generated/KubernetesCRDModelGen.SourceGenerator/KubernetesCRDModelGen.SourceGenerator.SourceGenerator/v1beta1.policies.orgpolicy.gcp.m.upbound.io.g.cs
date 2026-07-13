#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.orgpolicy.gcp.m.upbound.io;
/// <summary>Policy is the Schema for the Policys API. Defines an organization policy which is used to specify constraints for configurations of Google Cloud resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Policy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "orgpolicy.gcp.m.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "orgpolicy.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Policy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Policy> Items { get; set; }
}

/// <summary>
/// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderDryRunSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderDryRunSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderDryRunSpecRules
{
    /// <summary>Setting this to &quot;TRUE&quot; means that all values are allowed. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public string? AllowAll { get; set; }

    /// <summary>
    /// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta1PolicySpecForProviderDryRunSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to &quot;TRUE&quot; means that all values are denied. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public string? DenyAll { get; set; }

    /// <summary>If &quot;TRUE&quot;, then the Policy is enforced. If &quot;FALSE&quot;, then any configuration is acceptable. This field can be set only in Policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public string? Enforce { get; set; }

    /// <summary>Optional. Required for Managed Constraints if parameters defined in constraints. Pass parameter values when policy enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition. For example: { &quot;allowedLocations&quot; : [&quot;us-east1&quot;, &quot;us-west1&quot;], &quot;allowAll&quot; : true }</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>
    /// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("values")]
    public V1beta1PolicySpecForProviderDryRunSpecRulesValues? Values { get; set; }
}

/// <summary>
/// Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderDryRunSpec
{
    /// <summary>Determines the inheritance behavior for this policy. If inherit_from_parent is true, policy rules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this policy becomes the new root for evaluation. This field can be set only for policies which configure list constraints.</summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the constraint_default enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, rules must be empty and inherit_from_parent must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>
    /// In policies for boolean constraints, the following requirements apply: - There must be one and only one policy rule where condition is unset. - Boolean policy rules with conditions must set enforced to the opposite of the policy rule without a condition. - During policy evaluation, policy rules with conditions that are true for a target resource take precedence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1PolicySpecForProviderDryRunSpecRules>? Rules { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderParentRefPolicyResolutionEnum>))]
public enum V1beta1PolicySpecForProviderParentRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderParentRefPolicyResolveEnum>))]
public enum V1beta1PolicySpecForProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PolicySpecForProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PolicySpecForProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Folder in cloudplatform to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecForProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta1PolicySpecForProviderParentSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta1PolicySpecForProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PolicySpecForProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PolicySpecForProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Folder in cloudplatform to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderParentSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecForProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderSpecRules
{
    /// <summary>Setting this to &quot;TRUE&quot; means that all values are allowed. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public string? AllowAll { get; set; }

    /// <summary>
    /// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta1PolicySpecForProviderSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to &quot;TRUE&quot; means that all values are denied. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public string? DenyAll { get; set; }

    /// <summary>If &quot;TRUE&quot;, then the Policy is enforced. If &quot;FALSE&quot;, then any configuration is acceptable. This field can be set only in Policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public string? Enforce { get; set; }

    /// <summary>Optional. Required for Managed Constraints if parameters defined in constraints. Pass parameter values when policy enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition. For example: { &quot;allowedLocations&quot; : [&quot;us-east1&quot;, &quot;us-west1&quot;], &quot;allowAll&quot; : true }</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>
    /// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("values")]
    public V1beta1PolicySpecForProviderSpecRulesValues? Values { get; set; }
}

/// <summary>
/// Basic information about the Organization Policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderSpec
{
    /// <summary>Determines the inheritance behavior for this Policy. If inherit_from_parent is true, PolicyRules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this Policy becomes the new root for evaluation. This field can be set only for Policies which configure list constraints.</summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the constraint_default enforcement behavior of the specific Constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, rules must be empty and inherit_from_parent must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>
    /// In Policies for boolean constraints, the following requirements apply: - There must be one and only one PolicyRule where condition is unset. - BooleanPolicyRules with conditions must set enforced to the opposite of the PolicyRule without a condition. - During policy evaluation, PolicyRules with conditions that are true for a target resource take precedence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1PolicySpecForProviderSpecRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProvider
{
    /// <summary>
    /// Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dryRunSpec")]
    public V1beta1PolicySpecForProviderDryRunSpec? DryRunSpec { get; set; }

    /// <summary>The parent of the resource.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Folder in cloudplatform to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1PolicySpecForProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Folder in cloudplatform to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1PolicySpecForProviderParentSelector? ParentSelector { get; set; }

    /// <summary>
    /// Basic information about the Organization Policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta1PolicySpecForProviderSpec? Spec { get; set; }
}

/// <summary>
/// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderDryRunSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderDryRunSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderDryRunSpecRules
{
    /// <summary>Setting this to &quot;TRUE&quot; means that all values are allowed. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public string? AllowAll { get; set; }

    /// <summary>
    /// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta1PolicySpecInitProviderDryRunSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to &quot;TRUE&quot; means that all values are denied. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public string? DenyAll { get; set; }

    /// <summary>If &quot;TRUE&quot;, then the Policy is enforced. If &quot;FALSE&quot;, then any configuration is acceptable. This field can be set only in Policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public string? Enforce { get; set; }

    /// <summary>Optional. Required for Managed Constraints if parameters defined in constraints. Pass parameter values when policy enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition. For example: { &quot;allowedLocations&quot; : [&quot;us-east1&quot;, &quot;us-west1&quot;], &quot;allowAll&quot; : true }</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>
    /// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("values")]
    public V1beta1PolicySpecInitProviderDryRunSpecRulesValues? Values { get; set; }
}

/// <summary>
/// Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderDryRunSpec
{
    /// <summary>Determines the inheritance behavior for this policy. If inherit_from_parent is true, policy rules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this policy becomes the new root for evaluation. This field can be set only for policies which configure list constraints.</summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the constraint_default enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, rules must be empty and inherit_from_parent must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>
    /// In policies for boolean constraints, the following requirements apply: - There must be one and only one policy rule where condition is unset. - Boolean policy rules with conditions must set enforced to the opposite of the policy rule without a condition. - During policy evaluation, policy rules with conditions that are true for a target resource take precedence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1PolicySpecInitProviderDryRunSpecRules>? Rules { get; set; }
}

/// <summary>
/// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderSpecRules
{
    /// <summary>Setting this to &quot;TRUE&quot; means that all values are allowed. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public string? AllowAll { get; set; }

    /// <summary>
    /// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta1PolicySpecInitProviderSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to &quot;TRUE&quot; means that all values are denied. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public string? DenyAll { get; set; }

    /// <summary>If &quot;TRUE&quot;, then the Policy is enforced. If &quot;FALSE&quot;, then any configuration is acceptable. This field can be set only in Policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public string? Enforce { get; set; }

    /// <summary>Optional. Required for Managed Constraints if parameters defined in constraints. Pass parameter values when policy enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition. For example: { &quot;allowedLocations&quot; : [&quot;us-east1&quot;, &quot;us-west1&quot;], &quot;allowAll&quot; : true }</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>
    /// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("values")]
    public V1beta1PolicySpecInitProviderSpecRulesValues? Values { get; set; }
}

/// <summary>
/// Basic information about the Organization Policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderSpec
{
    /// <summary>Determines the inheritance behavior for this Policy. If inherit_from_parent is true, PolicyRules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this Policy becomes the new root for evaluation. This field can be set only for Policies which configure list constraints.</summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the constraint_default enforcement behavior of the specific Constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, rules must be empty and inherit_from_parent must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>
    /// In Policies for boolean constraints, the following requirements apply: - There must be one and only one PolicyRule where condition is unset. - BooleanPolicyRules with conditions must set enforced to the opposite of the PolicyRule without a condition. - During policy evaluation, PolicyRules with conditions that are true for a target resource take precedence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1PolicySpecInitProviderSpecRules>? Rules { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProvider
{
    /// <summary>
    /// Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dryRunSpec")]
    public V1beta1PolicySpecInitProviderDryRunSpec? DryRunSpec { get; set; }

    /// <summary>
    /// Basic information about the Organization Policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta1PolicySpecInitProviderSpec? Spec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecManagementPoliciesEnum>))]
public enum V1beta1PolicySpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>PolicySpec defines the desired state of Policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1PolicySpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderDryRunSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderDryRunSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderDryRunSpecRules
{
    /// <summary>Setting this to &quot;TRUE&quot; means that all values are allowed. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public string? AllowAll { get; set; }

    /// <summary>
    /// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta1PolicyStatusAtProviderDryRunSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to &quot;TRUE&quot; means that all values are denied. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public string? DenyAll { get; set; }

    /// <summary>If &quot;TRUE&quot;, then the Policy is enforced. If &quot;FALSE&quot;, then any configuration is acceptable. This field can be set only in Policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public string? Enforce { get; set; }

    /// <summary>Optional. Required for Managed Constraints if parameters defined in constraints. Pass parameter values when policy enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition. For example: { &quot;allowedLocations&quot; : [&quot;us-east1&quot;, &quot;us-west1&quot;], &quot;allowAll&quot; : true }</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>
    /// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("values")]
    public V1beta1PolicyStatusAtProviderDryRunSpecRulesValues? Values { get; set; }
}

/// <summary>
/// Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderDryRunSpec
{
    /// <summary>
    /// (Output)
    /// An opaque tag indicating the current version of the policy, used for concurrency control. This field is ignored if used in a CreatePolicy request. When the policyis returned from either aGetPolicyor aListPoliciesrequest, thisetagindicates the version of the current policy to use when executing a read-modify-write loop. When the policy is returned from aGetEffectivePolicyrequest, theetag` will be unset.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Determines the inheritance behavior for this policy. If inherit_from_parent is true, policy rules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this policy becomes the new root for evaluation. This field can be set only for policies which configure list constraints.</summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the constraint_default enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, rules must be empty and inherit_from_parent must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>
    /// In policies for boolean constraints, the following requirements apply: - There must be one and only one policy rule where condition is unset. - Boolean policy rules with conditions must set enforced to the opposite of the policy rule without a condition. - During policy evaluation, policy rules with conditions that are true for a target resource take precedence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1PolicyStatusAtProviderDryRunSpecRules>? Rules { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The time stamp this was previously updated. This represents the last time a call to CreatePolicy or UpdatePolicy was made for that policy.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>
/// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderSpecRules
{
    /// <summary>Setting this to &quot;TRUE&quot; means that all values are allowed. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public string? AllowAll { get; set; }

    /// <summary>
    /// A condition which determines whether this rule is used in the evaluation of the policy. When set, the expression field in the `Expr&apos; must include from 1 to 10 subexpressions, joined by the &quot;||&quot; or &quot; &amp; &amp; &quot; operators. Each subexpression must be of the form &quot;resource.matchTag(&apos;/tag_key_short_name, &apos;tag_value_short_name&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/key_id&apos;, &apos;tagValues/value_id&apos;)&quot;. where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: &quot;resource.matchTag(&apos;123456789/environment, &apos;prod&apos;)&quot;. or &quot;resource.matchTagId(&apos;tagKeys/123&apos;, &apos;tagValues/456&apos;)&quot;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta1PolicyStatusAtProviderSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to &quot;TRUE&quot; means that all values are denied. This field can be set only in Policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public string? DenyAll { get; set; }

    /// <summary>If &quot;TRUE&quot;, then the Policy is enforced. If &quot;FALSE&quot;, then any configuration is acceptable. This field can be set only in Policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public string? Enforce { get; set; }

    /// <summary>Optional. Required for Managed Constraints if parameters defined in constraints. Pass parameter values when policy enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition. For example: { &quot;allowedLocations&quot; : [&quot;us-east1&quot;, &quot;us-west1&quot;], &quot;allowAll&quot; : true }</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>
    /// List of values to be used for this PolicyRule. This field can be set only in Policies for list constraints.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("values")]
    public V1beta1PolicyStatusAtProviderSpecRulesValues? Values { get; set; }
}

/// <summary>
/// Basic information about the Organization Policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderSpec
{
    /// <summary>
    /// (Output)
    /// An opaque tag indicating the current version of the Policy, used for concurrency control. This field is ignored if used in a CreatePolicy request. When the Policy is returned from either a GetPolicy or a ListPolicies request, this etag indicates the version of the current Policy to use when executing a read-modify-write loop. When the Policy is returned from a GetEffectivePolicy request, the etag will be unset.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Determines the inheritance behavior for this Policy. If inherit_from_parent is true, PolicyRules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this Policy becomes the new root for evaluation. This field can be set only for Policies which configure list constraints.</summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the constraint_default enforcement behavior of the specific Constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, rules must be empty and inherit_from_parent must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>
    /// In Policies for boolean constraints, the following requirements apply: - There must be one and only one PolicyRule where condition is unset. - BooleanPolicyRules with conditions must set enforced to the opposite of the PolicyRule without a condition. - During policy evaluation, PolicyRules with conditions that are true for a target resource take precedence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1PolicyStatusAtProviderSpecRules>? Rules { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The time stamp this was previously updated. This represents the last time a call to CreatePolicy or UpdatePolicy was made for that Policy.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProvider
{
    /// <summary>
    /// Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it&apos;s enforced.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dryRunSpec")]
    public V1beta1PolicyStatusAtProviderDryRunSpec? DryRunSpec { get; set; }

    /// <summary>Optional. An opaque tag indicating the current state of the policy, used for concurrency control. This &apos;etag&apos; is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/policies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The parent of the resource.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Basic information about the Organization Policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta1PolicyStatusAtProviderSpec? Spec { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>PolicyStatus defines the observed state of Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Policy is the Schema for the Policys API. Defines an organization policy which is used to specify constraints for configurations of Google Cloud resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PolicySpec>, IStatus<V1beta1PolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "orgpolicy.gcp.m.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "orgpolicy.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Policy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicySpec defines the desired state of Policy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PolicySpec Spec { get; set; }

    /// <summary>PolicyStatus defines the observed state of Policy.</summary>
    [JsonPropertyName("status")]
    public V1beta1PolicyStatus? Status { get; set; }
}