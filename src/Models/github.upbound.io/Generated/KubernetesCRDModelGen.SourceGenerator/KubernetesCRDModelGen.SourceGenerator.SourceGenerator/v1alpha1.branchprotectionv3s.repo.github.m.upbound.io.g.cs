#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.repo.github.m.upbound.io;
/// <summary>BranchProtectionv3 is the Schema for the BranchProtectionv3s API. Protects a GitHub branch using the v3 / REST implementation.  The</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BranchProtectionv3List : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BranchProtectionv3>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BranchProtectionv3List";
    public const string KubeGroup = "repo.github.m.upbound.io";
    public const string KubePluralName = "branchprotectionv3s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "repo.github.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BranchProtectionv3List";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BranchProtectionv3 objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BranchProtectionv3> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRepositoryRefPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRepositoryRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRepositoryRefPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRepositoryRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecForProviderRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecForProviderRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Repository in repo to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionv3SpecForProviderRepositoryRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRepositorySelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRepositorySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRepositorySelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRepositorySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecForProviderRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecForProviderRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Repository in repo to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRepositorySelector
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
    public V1alpha1BranchProtectionv3SpecForProviderRepositorySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Team in team to populate teams.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelector
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
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowances
{
    /// <summary>:  The list of app slugs with push access.</summary>
    [JsonPropertyName("apps")]
    public IList<string>? Apps { get; set; }

    /// <summary>
    /// :  The list of team slugs with push access.
    /// Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("teams")]
    public IList<string>? Teams { get; set; }

    /// <summary>References to Team in team to populate teams.</summary>
    [JsonPropertyName("teamsRefs")]
    public IList<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefs>? TeamsRefs { get; set; }

    /// <summary>Selector for a list of Team in team to populate teams.</summary>
    [JsonPropertyName("teamsSelector")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelector? TeamsSelector { get; set; }

    /// <summary>:  The list of user logins with push access.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Team in team to populate dismissalTeams.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelector
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
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviews
{
    /// <summary>:  Allow specific users, teams, or apps to bypass pull request requirements. See Bypass Pull Request Allowances below for details.</summary>
    [JsonPropertyName("bypassPullRequestAllowances")]
    public IList<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsBypassPullRequestAllowances>? BypassPullRequestAllowances { get; set; }

    /// <summary>
    /// :  Dismiss approved reviews automatically when a new commit is pushed. Defaults to false.
    /// Dismiss approved reviews automatically when a new commit is pushed.
    /// </summary>
    [JsonPropertyName("dismissStaleReviews")]
    public bool? DismissStaleReviews { get; set; }

    /// <summary>
    /// :  The list of app slugs with dismissal access.
    /// The list of apps slugs with dismissal access. Always use slug of the app, not its name. Each app already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("dismissalApps")]
    public IList<string>? DismissalApps { get; set; }

    /// <summary>
    /// :  The list of team slugs with dismissal access.
    /// Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// The list of team slugs with dismissal access. Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("dismissalTeams")]
    public IList<string>? DismissalTeams { get; set; }

    /// <summary>References to Team in team to populate dismissalTeams.</summary>
    [JsonPropertyName("dismissalTeamsRefs")]
    public IList<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsRefs>? DismissalTeamsRefs { get; set; }

    /// <summary>Selector for a list of Team in team to populate dismissalTeams.</summary>
    [JsonPropertyName("dismissalTeamsSelector")]
    public V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviewsDismissalTeamsSelector? DismissalTeamsSelector { get; set; }

    /// <summary>
    /// :  The list of user logins with dismissal access
    /// The list of user logins with dismissal access.
    /// </summary>
    [JsonPropertyName("dismissalUsers")]
    public IList<string>? DismissalUsers { get; set; }

    [JsonPropertyName("includeAdmins")]
    public bool? IncludeAdmins { get; set; }

    /// <summary>
    /// :  Require an approved review in pull requests including files with a designated code owner. Defaults to false.
    /// Require an approved review in pull requests including files with a designated code owner.
    /// </summary>
    [JsonPropertyName("requireCodeOwnerReviews")]
    public bool? RequireCodeOwnerReviews { get; set; }

    /// <summary>
    /// :  Require that the most recent push must be approved by someone other than the last pusher.  Defaults to false
    /// Require that the most recent push must be approved by someone other than the last pusher.
    /// </summary>
    [JsonPropertyName("requireLastPushApproval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// 6. This requirement matches GitHub&apos;s API, see the upstream documentation for more information.
    /// Require &apos;x&apos; number of approvals to satisfy branch protection requirements. If this is specified it must be a number between 0-6.
    /// </summary>
    [JsonPropertyName("requiredApprovingReviewCount")]
    public long? RequiredApprovingReviewCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRequiredStatusChecks
{
    /// <summary>
    /// :  The list of status checks to require in order to merge into this branch. No status checks are required by default. Checks should be strings containing the context and app_id like so &quot;context:app_id&quot;.
    /// The list of status checks to require in order to merge into this branch. No status checks are required by default. Checks should be strings containing the &apos;context&apos; and &apos;app_id&apos; like so &apos;context:app_id&apos;
    /// </summary>
    [JsonPropertyName("checks")]
    public IList<string>? Checks { get; set; }

    /// <summary>: [DEPRECATED]  The list of status checks to require in order to merge into this branch. No status checks are required by default.</summary>
    [JsonPropertyName("contexts")]
    public IList<string>? Contexts { get; set; }

    [JsonPropertyName("includeAdmins")]
    public bool? IncludeAdmins { get; set; }

    /// <summary>
    /// :  Require branches to be up to date before merging. Defaults to false.
    /// Require branches to be up to date before merging.
    /// </summary>
    [JsonPropertyName("strict")]
    public bool? Strict { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefsPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefsPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Team in team to populate teams.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelector
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
    public V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProviderRestrictions
{
    /// <summary>
    /// :  The list of app slugs with push access.
    /// The list of app slugs with push access.
    /// </summary>
    [JsonPropertyName("apps")]
    public IList<string>? Apps { get; set; }

    /// <summary>
    /// :  The list of team slugs with push access.
    /// Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// The list of team slugs with push access. Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("teams")]
    public IList<string>? Teams { get; set; }

    /// <summary>References to Team in team to populate teams.</summary>
    [JsonPropertyName("teamsRefs")]
    public IList<V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsRefs>? TeamsRefs { get; set; }

    /// <summary>Selector for a list of Team in team to populate teams.</summary>
    [JsonPropertyName("teamsSelector")]
    public V1alpha1BranchProtectionv3SpecForProviderRestrictionsTeamsSelector? TeamsSelector { get; set; }

    /// <summary>
    /// :  The list of user logins with push access.
    /// The list of user logins with push access.
    /// </summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecForProvider
{
    /// <summary>
    /// The Git branch to protect.
    /// The Git branch to protect.
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Boolean, setting this to true enforces status checks for repository administrators.
    /// Setting this to &apos;true&apos; enforces status checks for repository administrators.
    /// </summary>
    [JsonPropertyName("enforceAdmins")]
    public bool? EnforceAdmins { get; set; }

    /// <summary>
    /// The GitHub repository name.
    /// The GitHub repository name.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Reference to a Repository in repo to populate repository.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1alpha1BranchProtectionv3SpecForProviderRepositoryRef? RepositoryRef { get; set; }

    /// <summary>Selector for a Repository in repo to populate repository.</summary>
    [JsonPropertyName("repositorySelector")]
    public V1alpha1BranchProtectionv3SpecForProviderRepositorySelector? RepositorySelector { get; set; }

    /// <summary>
    /// Boolean, setting this to true requires all conversations on code must be resolved before a pull request can be merged.
    /// Setting this to &apos;true&apos; requires all conversations on code must be resolved before a pull request can be merged.
    /// </summary>
    [JsonPropertyName("requireConversationResolution")]
    public bool? RequireConversationResolution { get; set; }

    /// <summary>
    /// Boolean, setting this to true requires all commits to be signed with GPG.
    /// Setting this to &apos;true&apos; requires all commits to be signed with GPG.
    /// </summary>
    [JsonPropertyName("requireSignedCommits")]
    public bool? RequireSignedCommits { get; set; }

    /// <summary>
    /// Enforce restrictions for pull request reviews. See Required Pull Request Reviews below for details.
    /// Enforce restrictions for pull request reviews.
    /// </summary>
    [JsonPropertyName("requiredPullRequestReviews")]
    public IList<V1alpha1BranchProtectionv3SpecForProviderRequiredPullRequestReviews>? RequiredPullRequestReviews { get; set; }

    /// <summary>
    /// Enforce restrictions for required status checks. See Required Status Checks below for details.
    /// Enforce restrictions for required status checks.
    /// </summary>
    [JsonPropertyName("requiredStatusChecks")]
    public IList<V1alpha1BranchProtectionv3SpecForProviderRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// Enforce restrictions for the users and teams that may push to the branch. See Restrictions below for details.
    /// Enforce restrictions for the users and teams that may push to the branch.
    /// </summary>
    [JsonPropertyName("restrictions")]
    public IList<V1alpha1BranchProtectionv3SpecForProviderRestrictions>? Restrictions { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRepositoryRefPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRepositoryRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRepositoryRefPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRepositoryRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecInitProviderRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecInitProviderRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Repository in repo to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionv3SpecInitProviderRepositoryRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRepositorySelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRepositorySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRepositorySelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRepositorySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecInitProviderRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecInitProviderRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Repository in repo to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRepositorySelector
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
    public V1alpha1BranchProtectionv3SpecInitProviderRepositorySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Team in team to populate teams.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelector
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
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowances
{
    /// <summary>:  The list of app slugs with push access.</summary>
    [JsonPropertyName("apps")]
    public IList<string>? Apps { get; set; }

    /// <summary>
    /// :  The list of team slugs with push access.
    /// Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("teams")]
    public IList<string>? Teams { get; set; }

    /// <summary>References to Team in team to populate teams.</summary>
    [JsonPropertyName("teamsRefs")]
    public IList<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsRefs>? TeamsRefs { get; set; }

    /// <summary>Selector for a list of Team in team to populate teams.</summary>
    [JsonPropertyName("teamsSelector")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowancesTeamsSelector? TeamsSelector { get; set; }

    /// <summary>:  The list of user logins with push access.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Team in team to populate dismissalTeams.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelector
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
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviews
{
    /// <summary>:  Allow specific users, teams, or apps to bypass pull request requirements. See Bypass Pull Request Allowances below for details.</summary>
    [JsonPropertyName("bypassPullRequestAllowances")]
    public IList<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsBypassPullRequestAllowances>? BypassPullRequestAllowances { get; set; }

    /// <summary>
    /// :  Dismiss approved reviews automatically when a new commit is pushed. Defaults to false.
    /// Dismiss approved reviews automatically when a new commit is pushed.
    /// </summary>
    [JsonPropertyName("dismissStaleReviews")]
    public bool? DismissStaleReviews { get; set; }

    /// <summary>
    /// :  The list of app slugs with dismissal access.
    /// The list of apps slugs with dismissal access. Always use slug of the app, not its name. Each app already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("dismissalApps")]
    public IList<string>? DismissalApps { get; set; }

    /// <summary>
    /// :  The list of team slugs with dismissal access.
    /// Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// The list of team slugs with dismissal access. Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("dismissalTeams")]
    public IList<string>? DismissalTeams { get; set; }

    /// <summary>References to Team in team to populate dismissalTeams.</summary>
    [JsonPropertyName("dismissalTeamsRefs")]
    public IList<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsRefs>? DismissalTeamsRefs { get; set; }

    /// <summary>Selector for a list of Team in team to populate dismissalTeams.</summary>
    [JsonPropertyName("dismissalTeamsSelector")]
    public V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviewsDismissalTeamsSelector? DismissalTeamsSelector { get; set; }

    /// <summary>
    /// :  The list of user logins with dismissal access
    /// The list of user logins with dismissal access.
    /// </summary>
    [JsonPropertyName("dismissalUsers")]
    public IList<string>? DismissalUsers { get; set; }

    [JsonPropertyName("includeAdmins")]
    public bool? IncludeAdmins { get; set; }

    /// <summary>
    /// :  Require an approved review in pull requests including files with a designated code owner. Defaults to false.
    /// Require an approved review in pull requests including files with a designated code owner.
    /// </summary>
    [JsonPropertyName("requireCodeOwnerReviews")]
    public bool? RequireCodeOwnerReviews { get; set; }

    /// <summary>
    /// :  Require that the most recent push must be approved by someone other than the last pusher.  Defaults to false
    /// Require that the most recent push must be approved by someone other than the last pusher.
    /// </summary>
    [JsonPropertyName("requireLastPushApproval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// 6. This requirement matches GitHub&apos;s API, see the upstream documentation for more information.
    /// Require &apos;x&apos; number of approvals to satisfy branch protection requirements. If this is specified it must be a number between 0-6.
    /// </summary>
    [JsonPropertyName("requiredApprovingReviewCount")]
    public long? RequiredApprovingReviewCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRequiredStatusChecks
{
    /// <summary>
    /// :  The list of status checks to require in order to merge into this branch. No status checks are required by default. Checks should be strings containing the context and app_id like so &quot;context:app_id&quot;.
    /// The list of status checks to require in order to merge into this branch. No status checks are required by default. Checks should be strings containing the &apos;context&apos; and &apos;app_id&apos; like so &apos;context:app_id&apos;
    /// </summary>
    [JsonPropertyName("checks")]
    public IList<string>? Checks { get; set; }

    /// <summary>: [DEPRECATED]  The list of status checks to require in order to merge into this branch. No status checks are required by default.</summary>
    [JsonPropertyName("contexts")]
    public IList<string>? Contexts { get; set; }

    [JsonPropertyName("includeAdmins")]
    public bool? IncludeAdmins { get; set; }

    /// <summary>
    /// :  Require branches to be up to date before merging. Defaults to false.
    /// Require branches to be up to date before merging.
    /// </summary>
    [JsonPropertyName("strict")]
    public bool? Strict { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefsPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefsPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Team in team to populate teams.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelector
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
    public V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3SpecInitProviderRestrictions
{
    /// <summary>
    /// :  The list of app slugs with push access.
    /// The list of app slugs with push access.
    /// </summary>
    [JsonPropertyName("apps")]
    public IList<string>? Apps { get; set; }

    /// <summary>
    /// :  The list of team slugs with push access.
    /// Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// The list of team slugs with push access. Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("teams")]
    public IList<string>? Teams { get; set; }

    /// <summary>References to Team in team to populate teams.</summary>
    [JsonPropertyName("teamsRefs")]
    public IList<V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsRefs>? TeamsRefs { get; set; }

    /// <summary>Selector for a list of Team in team to populate teams.</summary>
    [JsonPropertyName("teamsSelector")]
    public V1alpha1BranchProtectionv3SpecInitProviderRestrictionsTeamsSelector? TeamsSelector { get; set; }

    /// <summary>
    /// :  The list of user logins with push access.
    /// The list of user logins with push access.
    /// </summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
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
public partial class V1alpha1BranchProtectionv3SpecInitProvider
{
    /// <summary>
    /// The Git branch to protect.
    /// The Git branch to protect.
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Boolean, setting this to true enforces status checks for repository administrators.
    /// Setting this to &apos;true&apos; enforces status checks for repository administrators.
    /// </summary>
    [JsonPropertyName("enforceAdmins")]
    public bool? EnforceAdmins { get; set; }

    /// <summary>
    /// The GitHub repository name.
    /// The GitHub repository name.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Reference to a Repository in repo to populate repository.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1alpha1BranchProtectionv3SpecInitProviderRepositoryRef? RepositoryRef { get; set; }

    /// <summary>Selector for a Repository in repo to populate repository.</summary>
    [JsonPropertyName("repositorySelector")]
    public V1alpha1BranchProtectionv3SpecInitProviderRepositorySelector? RepositorySelector { get; set; }

    /// <summary>
    /// Boolean, setting this to true requires all conversations on code must be resolved before a pull request can be merged.
    /// Setting this to &apos;true&apos; requires all conversations on code must be resolved before a pull request can be merged.
    /// </summary>
    [JsonPropertyName("requireConversationResolution")]
    public bool? RequireConversationResolution { get; set; }

    /// <summary>
    /// Boolean, setting this to true requires all commits to be signed with GPG.
    /// Setting this to &apos;true&apos; requires all commits to be signed with GPG.
    /// </summary>
    [JsonPropertyName("requireSignedCommits")]
    public bool? RequireSignedCommits { get; set; }

    /// <summary>
    /// Enforce restrictions for pull request reviews. See Required Pull Request Reviews below for details.
    /// Enforce restrictions for pull request reviews.
    /// </summary>
    [JsonPropertyName("requiredPullRequestReviews")]
    public IList<V1alpha1BranchProtectionv3SpecInitProviderRequiredPullRequestReviews>? RequiredPullRequestReviews { get; set; }

    /// <summary>
    /// Enforce restrictions for required status checks. See Required Status Checks below for details.
    /// Enforce restrictions for required status checks.
    /// </summary>
    [JsonPropertyName("requiredStatusChecks")]
    public IList<V1alpha1BranchProtectionv3SpecInitProviderRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// Enforce restrictions for the users and teams that may push to the branch. See Restrictions below for details.
    /// Enforce restrictions for the users and teams that may push to the branch.
    /// </summary>
    [JsonPropertyName("restrictions")]
    public IList<V1alpha1BranchProtectionv3SpecInitProviderRestrictions>? Restrictions { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionv3SpecManagementPoliciesEnum>))]
public enum V1alpha1BranchProtectionv3SpecManagementPoliciesEnum
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
public partial class V1alpha1BranchProtectionv3SpecProviderConfigRef
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
public partial class V1alpha1BranchProtectionv3SpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>BranchProtectionv3Spec defines the desired state of BranchProtectionv3</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3Spec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1BranchProtectionv3SpecForProvider ForProvider { get; set; }

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
    public V1alpha1BranchProtectionv3SpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1BranchProtectionv3SpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1BranchProtectionv3SpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1BranchProtectionv3SpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3StatusAtProviderRequiredPullRequestReviewsBypassPullRequestAllowances
{
    /// <summary>:  The list of app slugs with push access.</summary>
    [JsonPropertyName("apps")]
    public IList<string>? Apps { get; set; }

    /// <summary>
    /// :  The list of team slugs with push access.
    /// Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("teams")]
    public IList<string>? Teams { get; set; }

    /// <summary>:  The list of user logins with push access.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3StatusAtProviderRequiredPullRequestReviews
{
    /// <summary>:  Allow specific users, teams, or apps to bypass pull request requirements. See Bypass Pull Request Allowances below for details.</summary>
    [JsonPropertyName("bypassPullRequestAllowances")]
    public IList<V1alpha1BranchProtectionv3StatusAtProviderRequiredPullRequestReviewsBypassPullRequestAllowances>? BypassPullRequestAllowances { get; set; }

    /// <summary>
    /// :  Dismiss approved reviews automatically when a new commit is pushed. Defaults to false.
    /// Dismiss approved reviews automatically when a new commit is pushed.
    /// </summary>
    [JsonPropertyName("dismissStaleReviews")]
    public bool? DismissStaleReviews { get; set; }

    /// <summary>
    /// :  The list of app slugs with dismissal access.
    /// The list of apps slugs with dismissal access. Always use slug of the app, not its name. Each app already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("dismissalApps")]
    public IList<string>? DismissalApps { get; set; }

    /// <summary>
    /// :  The list of team slugs with dismissal access.
    /// Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// The list of team slugs with dismissal access. Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("dismissalTeams")]
    public IList<string>? DismissalTeams { get; set; }

    /// <summary>
    /// :  The list of user logins with dismissal access
    /// The list of user logins with dismissal access.
    /// </summary>
    [JsonPropertyName("dismissalUsers")]
    public IList<string>? DismissalUsers { get; set; }

    [JsonPropertyName("includeAdmins")]
    public bool? IncludeAdmins { get; set; }

    /// <summary>
    /// :  Require an approved review in pull requests including files with a designated code owner. Defaults to false.
    /// Require an approved review in pull requests including files with a designated code owner.
    /// </summary>
    [JsonPropertyName("requireCodeOwnerReviews")]
    public bool? RequireCodeOwnerReviews { get; set; }

    /// <summary>
    /// :  Require that the most recent push must be approved by someone other than the last pusher.  Defaults to false
    /// Require that the most recent push must be approved by someone other than the last pusher.
    /// </summary>
    [JsonPropertyName("requireLastPushApproval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// 6. This requirement matches GitHub&apos;s API, see the upstream documentation for more information.
    /// Require &apos;x&apos; number of approvals to satisfy branch protection requirements. If this is specified it must be a number between 0-6.
    /// </summary>
    [JsonPropertyName("requiredApprovingReviewCount")]
    public long? RequiredApprovingReviewCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3StatusAtProviderRequiredStatusChecks
{
    /// <summary>
    /// :  The list of status checks to require in order to merge into this branch. No status checks are required by default. Checks should be strings containing the context and app_id like so &quot;context:app_id&quot;.
    /// The list of status checks to require in order to merge into this branch. No status checks are required by default. Checks should be strings containing the &apos;context&apos; and &apos;app_id&apos; like so &apos;context:app_id&apos;
    /// </summary>
    [JsonPropertyName("checks")]
    public IList<string>? Checks { get; set; }

    /// <summary>: [DEPRECATED]  The list of status checks to require in order to merge into this branch. No status checks are required by default.</summary>
    [JsonPropertyName("contexts")]
    public IList<string>? Contexts { get; set; }

    [JsonPropertyName("includeAdmins")]
    public bool? IncludeAdmins { get; set; }

    /// <summary>
    /// :  Require branches to be up to date before merging. Defaults to false.
    /// Require branches to be up to date before merging.
    /// </summary>
    [JsonPropertyName("strict")]
    public bool? Strict { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3StatusAtProviderRestrictions
{
    /// <summary>
    /// :  The list of app slugs with push access.
    /// The list of app slugs with push access.
    /// </summary>
    [JsonPropertyName("apps")]
    public IList<string>? Apps { get; set; }

    /// <summary>
    /// :  The list of team slugs with push access.
    /// Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// The list of team slugs with push access. Always use slug of the team, not its name. Each team already has to have access to the repository.
    /// </summary>
    [JsonPropertyName("teams")]
    public IList<string>? Teams { get; set; }

    /// <summary>
    /// :  The list of user logins with push access.
    /// The list of user logins with push access.
    /// </summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3StatusAtProvider
{
    /// <summary>
    /// The Git branch to protect.
    /// The Git branch to protect.
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Boolean, setting this to true enforces status checks for repository administrators.
    /// Setting this to &apos;true&apos; enforces status checks for repository administrators.
    /// </summary>
    [JsonPropertyName("enforceAdmins")]
    public bool? EnforceAdmins { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The GitHub repository name.
    /// The GitHub repository name.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>
    /// Boolean, setting this to true requires all conversations on code must be resolved before a pull request can be merged.
    /// Setting this to &apos;true&apos; requires all conversations on code must be resolved before a pull request can be merged.
    /// </summary>
    [JsonPropertyName("requireConversationResolution")]
    public bool? RequireConversationResolution { get; set; }

    /// <summary>
    /// Boolean, setting this to true requires all commits to be signed with GPG.
    /// Setting this to &apos;true&apos; requires all commits to be signed with GPG.
    /// </summary>
    [JsonPropertyName("requireSignedCommits")]
    public bool? RequireSignedCommits { get; set; }

    /// <summary>
    /// Enforce restrictions for pull request reviews. See Required Pull Request Reviews below for details.
    /// Enforce restrictions for pull request reviews.
    /// </summary>
    [JsonPropertyName("requiredPullRequestReviews")]
    public IList<V1alpha1BranchProtectionv3StatusAtProviderRequiredPullRequestReviews>? RequiredPullRequestReviews { get; set; }

    /// <summary>
    /// Enforce restrictions for required status checks. See Required Status Checks below for details.
    /// Enforce restrictions for required status checks.
    /// </summary>
    [JsonPropertyName("requiredStatusChecks")]
    public IList<V1alpha1BranchProtectionv3StatusAtProviderRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// Enforce restrictions for the users and teams that may push to the branch. See Restrictions below for details.
    /// Enforce restrictions for the users and teams that may push to the branch.
    /// </summary>
    [JsonPropertyName("restrictions")]
    public IList<V1alpha1BranchProtectionv3StatusAtProviderRestrictions>? Restrictions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3StatusConditions
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

/// <summary>BranchProtectionv3Status defines the observed state of BranchProtectionv3.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionv3Status
{
    [JsonPropertyName("atProvider")]
    public V1alpha1BranchProtectionv3StatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BranchProtectionv3StatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BranchProtectionv3 is the Schema for the BranchProtectionv3s API. Protects a GitHub branch using the v3 / REST implementation.  The</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BranchProtectionv3 : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BranchProtectionv3Spec>, IStatus<V1alpha1BranchProtectionv3Status?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BranchProtectionv3";
    public const string KubeGroup = "repo.github.m.upbound.io";
    public const string KubePluralName = "branchprotectionv3s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "repo.github.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BranchProtectionv3";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BranchProtectionv3Spec defines the desired state of BranchProtectionv3</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BranchProtectionv3Spec Spec { get; set; }

    /// <summary>BranchProtectionv3Status defines the observed state of BranchProtectionv3.</summary>
    [JsonPropertyName("status")]
    public V1alpha1BranchProtectionv3Status? Status { get; set; }
}