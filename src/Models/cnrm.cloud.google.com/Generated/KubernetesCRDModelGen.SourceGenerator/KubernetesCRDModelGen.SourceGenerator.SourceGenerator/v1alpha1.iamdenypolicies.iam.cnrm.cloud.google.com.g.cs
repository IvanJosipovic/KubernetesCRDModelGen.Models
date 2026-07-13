#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.cnrm.cloud.google.com;
/// <summary>IAMDenyPolicy is the Schema for the IAMDenyPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IAMDenyPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1IAMDenyPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IAMDenyPolicyList";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamdenypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMDenyPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1IAMDenyPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1IAMDenyPolicy> Items { get; set; }
}

/// <summary>
/// The condition that determines whether this deny rule applies to a request.
///  If the condition expression evaluates to `true`, then the deny rule is
///  applied; otherwise, the deny rule is not applied.
/// 
///  Each deny rule is evaluated independently. If this deny rule does not apply
///  to a request, other deny rules might still apply.
/// 
///  The condition can use CEL functions that evaluate
///  [resource
///  tags](https://cloud.google.com/iam/help/conditions/resource-tags). Other
///  functions and operators are not supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMDenyPolicySpecRulesDenyRuleDenialCondition
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

/// <summary>A rule for a deny policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMDenyPolicySpecRulesDenyRule
{
    /// <summary>
    /// The condition that determines whether this deny rule applies to a request.
    ///  If the condition expression evaluates to `true`, then the deny rule is
    ///  applied; otherwise, the deny rule is not applied.
    /// 
    ///  Each deny rule is evaluated independently. If this deny rule does not apply
    ///  to a request, other deny rules might still apply.
    /// 
    ///  The condition can use CEL functions that evaluate
    ///  [resource
    ///  tags](https://cloud.google.com/iam/help/conditions/resource-tags). Other
    ///  functions and operators are not supported.
    /// </summary>
    [JsonPropertyName("denialCondition")]
    public V1alpha1IAMDenyPolicySpecRulesDenyRuleDenialCondition? DenialCondition { get; set; }

    /// <summary>The permissions that are explicitly denied by this rule. Each permission uses the format `{service_fqdn}/{resource}.{verb}`, where `{service_fqdn}` is the fully qualified domain name for the service. For example, `iam.googleapis.com/roles.list`.</summary>
    [JsonPropertyName("deniedPermissions")]
    public IList<string>? DeniedPermissions { get; set; }

    /// <summary>
    /// The identities that are prevented from using one or more permissions on
    ///  Google Cloud resources. This field can contain the following values:
    /// 
    ///  * `principalSet://goog/public:all`: A special identifier that represents
    ///    any principal that is on the internet, even if they do not have a Google
    ///    Account or are not logged in.
    /// 
    ///  * `principal://goog/subject/{email_id}`: A specific Google Account.
    ///    Includes Gmail, Cloud Identity, and Google Workspace user accounts. For
    ///    example, `principal://goog/subject/alice@example.com`.
    /// 
    ///  * `deleted:principal://goog/subject/{email_id}?uid={uid}`: A specific
    ///    Google Account that was deleted recently. For example,
    ///    `deleted:principal://goog/subject/alice@example.com?uid=1234567890`. If
    ///    the Google Account is recovered, this identifier reverts to the standard
    ///    identifier for a Google Account.
    /// 
    ///  * `principalSet://goog/group/{group_id}`: A Google group. For example,
    ///    `principalSet://goog/group/admins@example.com`.
    /// 
    ///  * `deleted:principalSet://goog/group/{group_id}?uid={uid}`: A Google group
    ///    that was deleted recently. For example,
    ///    `deleted:principalSet://goog/group/admins@example.com?uid=1234567890`. If
    ///    the Google group is restored, this identifier reverts to the standard
    ///    identifier for a Google group.
    /// 
    ///  * `principal://iam.googleapis.com/projects/-/serviceAccounts/{service_account_id}`:
    ///    A Google Cloud service account. For example,
    ///    `principal://iam.googleapis.com/projects/-/serviceAccounts/my-service-account@iam.gserviceaccount.com`.
    /// 
    ///  * `deleted:principal://iam.googleapis.com/projects/-/serviceAccounts/{service_account_id}?uid={uid}`:
    ///    A Google Cloud service account that was deleted recently. For example,
    ///    `deleted:principal://iam.googleapis.com/projects/-/serviceAccounts/my-service-account@iam.gserviceaccount.com?uid=1234567890`.
    ///    If the service account is undeleted, this identifier reverts to the
    ///    standard identifier for a service account.
    /// 
    ///  * `principalSet://goog/cloudIdentityCustomerId/{customer_id}`: All of the
    ///    principals associated with the specified Google Workspace or Cloud
    ///    Identity customer ID. For example,
    ///    `principalSet://goog/cloudIdentityCustomerId/C01Abc35`.
    /// </summary>
    [JsonPropertyName("deniedPrincipals")]
    public IList<string>? DeniedPrincipals { get; set; }

    /// <summary>
    /// Specifies the permissions that this rule excludes from the set of denied
    ///  permissions given by `denied_permissions`. If a permission appears in
    ///  `denied_permissions` _and_ in `exception_permissions` then it will _not_ be
    ///  denied.
    /// 
    ///  The excluded permissions can be specified using the same syntax as
    ///  `denied_permissions`.
    /// </summary>
    [JsonPropertyName("exceptionPermissions")]
    public IList<string>? ExceptionPermissions { get; set; }

    /// <summary>
    /// The identities that are excluded from the deny rule, even if they are
    ///  listed in the `denied_principals`. For example, you could add a Google
    ///  group to the `denied_principals`, then exclude specific users who belong to
    ///  that group.
    /// 
    ///  This field can contain the same values as the `denied_principals` field,
    ///  excluding `principalSet://goog/public:all`, which represents all users on
    ///  the internet.
    /// </summary>
    [JsonPropertyName("exceptionPrincipals")]
    public IList<string>? ExceptionPrincipals { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMDenyPolicySpecRules
{
    /// <summary>A rule for a deny policy.</summary>
    [JsonPropertyName("denyRule")]
    public V1alpha1IAMDenyPolicySpecRulesDenyRule? DenyRule { get; set; }

    /// <summary>A user-specified description of the rule. This value can be up to 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>IAMDenyPolicySpec defines the desired state of IAMDenyPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMDenyPolicySpec
{
    /// <summary>A user-specified description of the `Policy`. This value can be up to 63 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The IAMDenyPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A list of rules that specify the behavior of the `Policy`. All of the rules should be of the `kind` specified in the `Policy`.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1IAMDenyPolicySpecRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMDenyPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMDenyPolicyStatusObservedState
{
}

/// <summary>IAMDenyPolicyStatus defines the config connector machine state of IAMDenyPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMDenyPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1IAMDenyPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the IAMDenyPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1IAMDenyPolicyStatusObservedState? ObservedState { get; set; }
}

/// <summary>IAMDenyPolicy is the Schema for the IAMDenyPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IAMDenyPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IAMDenyPolicySpec>, IStatus<V1alpha1IAMDenyPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IAMDenyPolicy";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamdenypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMDenyPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IAMDenyPolicySpec defines the desired state of IAMDenyPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1IAMDenyPolicySpec Spec { get; set; }

    /// <summary>IAMDenyPolicyStatus defines the config connector machine state of IAMDenyPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1IAMDenyPolicyStatus? Status { get; set; }
}