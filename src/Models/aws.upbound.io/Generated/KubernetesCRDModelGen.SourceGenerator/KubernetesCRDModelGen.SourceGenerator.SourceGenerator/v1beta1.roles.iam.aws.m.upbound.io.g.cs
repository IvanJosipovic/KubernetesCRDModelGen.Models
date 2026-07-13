#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.aws.m.upbound.io;
/// <summary>Role is the Schema for the Roles API. Provides an IAM role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RoleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Role>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RoleList";
    public const string KubeGroup = "iam.aws.m.upbound.io";
    public const string KubePluralName = "roles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RoleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Role objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Role> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecForProviderInlinePolicy
{
    /// <summary>Friendly name of the role. See IAM Identifiers for more information.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Policy document as a JSON formatted string.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleSpecForProviderManagedPolicyArnsRefsPolicyResolutionEnum>))]
public enum V1beta1RoleSpecForProviderManagedPolicyArnsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleSpecForProviderManagedPolicyArnsRefsPolicyResolveEnum>))]
public enum V1beta1RoleSpecForProviderManagedPolicyArnsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecForProviderManagedPolicyArnsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleSpecForProviderManagedPolicyArnsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleSpecForProviderManagedPolicyArnsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecForProviderManagedPolicyArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleSpecForProviderManagedPolicyArnsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleSpecForProviderManagedPolicyArnsSelectorPolicyResolutionEnum>))]
public enum V1beta1RoleSpecForProviderManagedPolicyArnsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleSpecForProviderManagedPolicyArnsSelectorPolicyResolveEnum>))]
public enum V1beta1RoleSpecForProviderManagedPolicyArnsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecForProviderManagedPolicyArnsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleSpecForProviderManagedPolicyArnsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleSpecForProviderManagedPolicyArnsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Policy in iam to populate managedPolicyArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecForProviderManagedPolicyArnsSelector
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
    public V1beta1RoleSpecForProviderManagedPolicyArnsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecForProvider
{
    /// <summary>Policy that grants an entity permission to assume the role. This field is required, but it can be specified in either &apos;spec.forProvider.assumeRolePolicy&apos; or &apos;spec.initProvider.assumeRolePolicy&apos;. While it may appear optional in each location individually, the resource requires that it is defined in at least one of them during creation.</summary>
    [JsonPropertyName("assumeRolePolicy")]
    public string? AssumeRolePolicy { get; set; }

    /// <summary>Description of the role.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to force detaching any policies the role has before destroying it. Defaults to false.</summary>
    [JsonPropertyName("forceDetachPolicies")]
    public bool? ForceDetachPolicies { get; set; }

    /// <summary>Configuration block defining an exclusive set of IAM inline policies associated with the IAM role. See below. If no blocks are configured, Crossplane will not manage any inline policies in this resource. Configuring one empty block (i.e., inline_policy {}) will cause Crossplane to remove all inline policies added out of band on apply.</summary>
    [JsonPropertyName("inlinePolicy")]
    public IList<V1beta1RoleSpecForProviderInlinePolicy>? InlinePolicy { get; set; }

    /// <summary>Set of exclusive IAM managed policy ARNs to attach to the IAM role. If this attribute is not configured, Crossplane will ignore policy attachments to this resource. When configured, Crossplane will align the role&apos;s managed policy attachments with this set by attaching or detaching managed policies. Configuring an empty set (i.e., managed_policy_arns = []) will cause Crossplane to remove all managed policy attachments.</summary>
    [JsonPropertyName("managedPolicyArns")]
    public IList<string>? ManagedPolicyArns { get; set; }

    /// <summary>References to Policy in iam to populate managedPolicyArns.</summary>
    [JsonPropertyName("managedPolicyArnsRefs")]
    public IList<V1beta1RoleSpecForProviderManagedPolicyArnsRefs>? ManagedPolicyArnsRefs { get; set; }

    /// <summary>Selector for a list of Policy in iam to populate managedPolicyArns.</summary>
    [JsonPropertyName("managedPolicyArnsSelector")]
    public V1beta1RoleSpecForProviderManagedPolicyArnsSelector? ManagedPolicyArnsSelector { get; set; }

    /// <summary>Maximum session duration (in seconds) that you want to set for the specified role. If you do not specify a value for this setting, the default maximum of one hour is applied. This setting can have a value from 1 hour to 12 hours.</summary>
    [JsonPropertyName("maxSessionDuration")]
    public double? MaxSessionDuration { get; set; }

    /// <summary>Path to the role. See IAM Identifiers for more information.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>ARN of the policy that is used to set the permissions boundary for the role.</summary>
    [JsonPropertyName("permissionsBoundary")]
    public string? PermissionsBoundary { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecInitProviderInlinePolicy
{
    /// <summary>Friendly name of the role. See IAM Identifiers for more information.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Policy document as a JSON formatted string.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleSpecInitProviderManagedPolicyArnsRefsPolicyResolutionEnum>))]
public enum V1beta1RoleSpecInitProviderManagedPolicyArnsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleSpecInitProviderManagedPolicyArnsRefsPolicyResolveEnum>))]
public enum V1beta1RoleSpecInitProviderManagedPolicyArnsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecInitProviderManagedPolicyArnsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleSpecInitProviderManagedPolicyArnsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleSpecInitProviderManagedPolicyArnsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecInitProviderManagedPolicyArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoleSpecInitProviderManagedPolicyArnsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleSpecInitProviderManagedPolicyArnsSelectorPolicyResolutionEnum>))]
public enum V1beta1RoleSpecInitProviderManagedPolicyArnsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleSpecInitProviderManagedPolicyArnsSelectorPolicyResolveEnum>))]
public enum V1beta1RoleSpecInitProviderManagedPolicyArnsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecInitProviderManagedPolicyArnsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RoleSpecInitProviderManagedPolicyArnsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RoleSpecInitProviderManagedPolicyArnsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Policy in iam to populate managedPolicyArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpecInitProviderManagedPolicyArnsSelector
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
    public V1beta1RoleSpecInitProviderManagedPolicyArnsSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1RoleSpecInitProvider
{
    /// <summary>Policy that grants an entity permission to assume the role. This field is required, but it can be specified in either &apos;spec.forProvider.assumeRolePolicy&apos; or &apos;spec.initProvider.assumeRolePolicy&apos;. While it may appear optional in each location individually, the resource requires that it is defined in at least one of them during creation.</summary>
    [JsonPropertyName("assumeRolePolicy")]
    public string? AssumeRolePolicy { get; set; }

    /// <summary>Description of the role.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to force detaching any policies the role has before destroying it. Defaults to false.</summary>
    [JsonPropertyName("forceDetachPolicies")]
    public bool? ForceDetachPolicies { get; set; }

    /// <summary>Configuration block defining an exclusive set of IAM inline policies associated with the IAM role. See below. If no blocks are configured, Crossplane will not manage any inline policies in this resource. Configuring one empty block (i.e., inline_policy {}) will cause Crossplane to remove all inline policies added out of band on apply.</summary>
    [JsonPropertyName("inlinePolicy")]
    public IList<V1beta1RoleSpecInitProviderInlinePolicy>? InlinePolicy { get; set; }

    /// <summary>Set of exclusive IAM managed policy ARNs to attach to the IAM role. If this attribute is not configured, Crossplane will ignore policy attachments to this resource. When configured, Crossplane will align the role&apos;s managed policy attachments with this set by attaching or detaching managed policies. Configuring an empty set (i.e., managed_policy_arns = []) will cause Crossplane to remove all managed policy attachments.</summary>
    [JsonPropertyName("managedPolicyArns")]
    public IList<string>? ManagedPolicyArns { get; set; }

    /// <summary>References to Policy in iam to populate managedPolicyArns.</summary>
    [JsonPropertyName("managedPolicyArnsRefs")]
    public IList<V1beta1RoleSpecInitProviderManagedPolicyArnsRefs>? ManagedPolicyArnsRefs { get; set; }

    /// <summary>Selector for a list of Policy in iam to populate managedPolicyArns.</summary>
    [JsonPropertyName("managedPolicyArnsSelector")]
    public V1beta1RoleSpecInitProviderManagedPolicyArnsSelector? ManagedPolicyArnsSelector { get; set; }

    /// <summary>Maximum session duration (in seconds) that you want to set for the specified role. If you do not specify a value for this setting, the default maximum of one hour is applied. This setting can have a value from 1 hour to 12 hours.</summary>
    [JsonPropertyName("maxSessionDuration")]
    public double? MaxSessionDuration { get; set; }

    /// <summary>Path to the role. See IAM Identifiers for more information.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>ARN of the policy that is used to set the permissions boundary for the role.</summary>
    [JsonPropertyName("permissionsBoundary")]
    public string? PermissionsBoundary { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RoleSpecManagementPoliciesEnum>))]
public enum V1beta1RoleSpecManagementPoliciesEnum
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
public partial class V1beta1RoleSpecProviderConfigRef
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
public partial class V1beta1RoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RoleSpec defines the desired state of Role</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1RoleSpecForProvider ForProvider { get; set; }

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
    public V1beta1RoleSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RoleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RoleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RoleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleStatusAtProviderInlinePolicy
{
    /// <summary>Friendly name of the role. See IAM Identifiers for more information.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Policy document as a JSON formatted string.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) specifying the role.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Policy that grants an entity permission to assume the role. This field is required, but it can be specified in either &apos;spec.forProvider.assumeRolePolicy&apos; or &apos;spec.initProvider.assumeRolePolicy&apos;. While it may appear optional in each location individually, the resource requires that it is defined in at least one of them during creation.</summary>
    [JsonPropertyName("assumeRolePolicy")]
    public string? AssumeRolePolicy { get; set; }

    /// <summary>Creation date of the IAM role.</summary>
    [JsonPropertyName("createDate")]
    public string? CreateDate { get; set; }

    /// <summary>Description of the role.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to force detaching any policies the role has before destroying it. Defaults to false.</summary>
    [JsonPropertyName("forceDetachPolicies")]
    public bool? ForceDetachPolicies { get; set; }

    /// <summary>Name of the role.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block defining an exclusive set of IAM inline policies associated with the IAM role. See below. If no blocks are configured, Crossplane will not manage any inline policies in this resource. Configuring one empty block (i.e., inline_policy {}) will cause Crossplane to remove all inline policies added out of band on apply.</summary>
    [JsonPropertyName("inlinePolicy")]
    public IList<V1beta1RoleStatusAtProviderInlinePolicy>? InlinePolicy { get; set; }

    /// <summary>Set of exclusive IAM managed policy ARNs to attach to the IAM role. If this attribute is not configured, Crossplane will ignore policy attachments to this resource. When configured, Crossplane will align the role&apos;s managed policy attachments with this set by attaching or detaching managed policies. Configuring an empty set (i.e., managed_policy_arns = []) will cause Crossplane to remove all managed policy attachments.</summary>
    [JsonPropertyName("managedPolicyArns")]
    public IList<string>? ManagedPolicyArns { get; set; }

    /// <summary>Maximum session duration (in seconds) that you want to set for the specified role. If you do not specify a value for this setting, the default maximum of one hour is applied. This setting can have a value from 1 hour to 12 hours.</summary>
    [JsonPropertyName("maxSessionDuration")]
    public double? MaxSessionDuration { get; set; }

    /// <summary>Path to the role. See IAM Identifiers for more information.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>ARN of the policy that is used to set the permissions boundary for the role.</summary>
    [JsonPropertyName("permissionsBoundary")]
    public string? PermissionsBoundary { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Stable and unique string identifying the role.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleStatusConditions
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

/// <summary>RoleStatus defines the observed state of Role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RoleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RoleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Role is the Schema for the Roles API. Provides an IAM role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Role : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RoleSpec>, IStatus<V1beta1RoleStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Role";
    public const string KubeGroup = "iam.aws.m.upbound.io";
    public const string KubePluralName = "roles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Role";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RoleSpec defines the desired state of Role</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RoleSpec Spec { get; set; }

    /// <summary>RoleStatus defines the observed state of Role.</summary>
    [JsonPropertyName("status")]
    public V1beta1RoleStatus? Status { get; set; }
}