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
/// <summary>BranchProtection is the Schema for the BranchProtections API. Protects a GitHub branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BranchProtectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BranchProtection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BranchProtectionList";
    public const string KubeGroup = "repo.github.m.upbound.io";
    public const string KubePluralName = "branchprotections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "repo.github.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BranchProtectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BranchProtection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BranchProtection> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionSpecForProviderRepositoryIdRefPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionSpecForProviderRepositoryIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionSpecForProviderRepositoryIdRefPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionSpecForProviderRepositoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecForProviderRepositoryIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionSpecForProviderRepositoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionSpecForProviderRepositoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Repository in repo to populate repositoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecForProviderRepositoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionSpecForProviderRepositoryIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionSpecForProviderRepositoryIdSelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionSpecForProviderRepositoryIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionSpecForProviderRepositoryIdSelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionSpecForProviderRepositoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecForProviderRepositoryIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionSpecForProviderRepositoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionSpecForProviderRepositoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Repository in repo to populate repositoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecForProviderRepositoryIdSelector
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
    public V1alpha1BranchProtectionSpecForProviderRepositoryIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecForProviderRequiredPullRequestReviews
{
    /// <summary>
    /// :  Dismiss approved reviews automatically when a new commit is pushed. Defaults to false.
    /// Dismiss approved reviews automatically when a new commit is pushed.
    /// </summary>
    [JsonPropertyName("dismissStaleReviews")]
    public bool? DismissStaleReviews { get; set; }

    /// <summary>
    /// :  The list of actor Names/IDs with dismissal access. If not empty, restrict_dismissals is ignored. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams.
    /// The list of actor Names/IDs with dismissal access. If not empty, &apos;restrict_dismissals&apos; is ignored. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("dismissalRestrictions")]
    public IList<string>? DismissalRestrictions { get; set; }

    /// <summary>
    /// :  The list of actor Names/IDs that are allowed to bypass pull request requirements. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams.
    /// The list of actor Names/IDs that are allowed to bypass pull request requirements. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("pullRequestBypassers")]
    public IList<string>? PullRequestBypassers { get; set; }

    /// <summary>
    /// :  Require an approved review in pull requests including files with a designated code owner. Defaults to false.
    /// Require an approved review in pull requests including files with a designated code owner.
    /// </summary>
    [JsonPropertyName("requireCodeOwnerReviews")]
    public bool? RequireCodeOwnerReviews { get; set; }

    /// <summary>
    /// :  Require that The most recent push must be approved by someone other than the last pusher.  Defaults to false
    /// Require that The most recent push must be approved by someone other than the last pusher.
    /// </summary>
    [JsonPropertyName("requireLastPushApproval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// 6. This requirement matches GitHub&apos;s API, see the upstream documentation for more information.
    /// (https://developer.github.com/v3/repos/branches/#parameters-1) for more information.
    /// Require &apos;x&apos; number of approvals to satisfy branch protection requirements. If this is specified it must be a number between 0-6.
    /// </summary>
    [JsonPropertyName("requiredApprovingReviewCount")]
    public long? RequiredApprovingReviewCount { get; set; }

    /// <summary>
    /// :  Restrict pull request review dismissals.
    /// Restrict pull request review dismissals.
    /// </summary>
    [JsonPropertyName("restrictDismissals")]
    public bool? RestrictDismissals { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecForProviderRequiredStatusChecks
{
    /// <summary>
    /// :  The list of status checks to require in order to merge into this branch. No status checks are required by default.
    /// The list of status checks to require in order to merge into this branch. No status checks are required by default.
    /// </summary>
    [JsonPropertyName("contexts")]
    public IList<string>? Contexts { get; set; }

    /// <summary>
    /// :  Require branches to be up to date before merging. Defaults to false.
    /// Require branches to be up to date before merging.
    /// </summary>
    [JsonPropertyName("strict")]
    public bool? Strict { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecForProviderRestrictPushes
{
    /// <summary>
    /// Boolean, setting this to false allows people, teams, or apps to create new branches matching this rule. Defaults to true.
    /// Restrict pushes that create matching branches.
    /// </summary>
    [JsonPropertyName("blocksCreations")]
    public bool? BlocksCreations { get; set; }

    /// <summary>
    /// A list of actor Names/IDs that may push to the branch. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams. Organization administrators, repository administrators, and users with the Maintain role on the repository can always push when all other requirements have passed.
    /// The list of actor Names/IDs that may push to the branch. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("pushAllowances")]
    public IList<string>? PushAllowances { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecForProvider
{
    /// <summary>
    /// Boolean, setting this to true to allow the branch to be deleted.
    /// Setting this to &apos;true&apos; to allow the branch to be deleted.
    /// </summary>
    [JsonPropertyName("allowsDeletions")]
    public bool? AllowsDeletions { get; set; }

    /// <summary>
    /// Boolean, setting this to true to allow force pushes on the branch to everyone. Set it to false if you specify force_push_bypassers.
    /// Setting this to &apos;true&apos; to allow force pushes on the branch.
    /// </summary>
    [JsonPropertyName("allowsForcePushes")]
    public bool? AllowsForcePushes { get; set; }

    /// <summary>
    /// Boolean, setting this to true enforces status checks for repository administrators.
    /// Setting this to &apos;true&apos; enforces status checks for repository administrators.
    /// </summary>
    [JsonPropertyName("enforceAdmins")]
    public bool? EnforceAdmins { get; set; }

    /// <summary>
    /// The list of actor Names/IDs that are allowed to bypass force push restrictions. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams. If the list is not empty, allows_force_pushes should be set to false.
    /// The list of actor Names/IDs that are allowed to bypass force push restrictions. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("forcePushBypassers")]
    public IList<string>? ForcePushBypassers { get; set; }

    /// <summary>
    /// Boolean, Setting this to true will make the branch read-only and preventing any pushes to it. Defaults to false
    /// Setting this to &apos;true&apos; will make the branch read-only and preventing any pushes to it.
    /// </summary>
    [JsonPropertyName("lockBranch")]
    public bool? LockBranch { get; set; }

    /// <summary>
    /// Identifies the protection rule pattern.
    /// Identifies the protection rule pattern.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>
    /// The name or node ID of the repository associated with this branch protection rule.
    /// The name or node ID of the repository associated with this branch protection rule.
    /// </summary>
    [JsonPropertyName("repositoryId")]
    public string? RepositoryId { get; set; }

    /// <summary>Reference to a Repository in repo to populate repositoryId.</summary>
    [JsonPropertyName("repositoryIdRef")]
    public V1alpha1BranchProtectionSpecForProviderRepositoryIdRef? RepositoryIdRef { get; set; }

    /// <summary>Selector for a Repository in repo to populate repositoryId.</summary>
    [JsonPropertyName("repositoryIdSelector")]
    public V1alpha1BranchProtectionSpecForProviderRepositoryIdSelector? RepositoryIdSelector { get; set; }

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
    /// Boolean, setting this to true enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch
    /// Setting this to &apos;true&apos; enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch.
    /// </summary>
    [JsonPropertyName("requiredLinearHistory")]
    public bool? RequiredLinearHistory { get; set; }

    /// <summary>
    /// Enforce restrictions for pull request reviews. See Required Pull Request Reviews below for details.
    /// Enforce restrictions for pull request reviews.
    /// </summary>
    [JsonPropertyName("requiredPullRequestReviews")]
    public IList<V1alpha1BranchProtectionSpecForProviderRequiredPullRequestReviews>? RequiredPullRequestReviews { get; set; }

    /// <summary>
    /// Enforce restrictions for required status checks. See Required Status Checks below for details.
    /// Enforce restrictions for required status checks.
    /// </summary>
    [JsonPropertyName("requiredStatusChecks")]
    public IList<V1alpha1BranchProtectionSpecForProviderRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// Restrict pushes to matching branches. See Restrict Pushes below for details.
    /// Restrict who can push to matching branches.
    /// </summary>
    [JsonPropertyName("restrictPushes")]
    public IList<V1alpha1BranchProtectionSpecForProviderRestrictPushes>? RestrictPushes { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionSpecInitProviderRepositoryIdRefPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionSpecInitProviderRepositoryIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionSpecInitProviderRepositoryIdRefPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionSpecInitProviderRepositoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecInitProviderRepositoryIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionSpecInitProviderRepositoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionSpecInitProviderRepositoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Repository in repo to populate repositoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecInitProviderRepositoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BranchProtectionSpecInitProviderRepositoryIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelectorPolicyResolutionEnum>))]
public enum V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelectorPolicyResolveEnum>))]
public enum V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Repository in repo to populate repositoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelector
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
    public V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecInitProviderRequiredPullRequestReviews
{
    /// <summary>
    /// :  Dismiss approved reviews automatically when a new commit is pushed. Defaults to false.
    /// Dismiss approved reviews automatically when a new commit is pushed.
    /// </summary>
    [JsonPropertyName("dismissStaleReviews")]
    public bool? DismissStaleReviews { get; set; }

    /// <summary>
    /// :  The list of actor Names/IDs with dismissal access. If not empty, restrict_dismissals is ignored. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams.
    /// The list of actor Names/IDs with dismissal access. If not empty, &apos;restrict_dismissals&apos; is ignored. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("dismissalRestrictions")]
    public IList<string>? DismissalRestrictions { get; set; }

    /// <summary>
    /// :  The list of actor Names/IDs that are allowed to bypass pull request requirements. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams.
    /// The list of actor Names/IDs that are allowed to bypass pull request requirements. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("pullRequestBypassers")]
    public IList<string>? PullRequestBypassers { get; set; }

    /// <summary>
    /// :  Require an approved review in pull requests including files with a designated code owner. Defaults to false.
    /// Require an approved review in pull requests including files with a designated code owner.
    /// </summary>
    [JsonPropertyName("requireCodeOwnerReviews")]
    public bool? RequireCodeOwnerReviews { get; set; }

    /// <summary>
    /// :  Require that The most recent push must be approved by someone other than the last pusher.  Defaults to false
    /// Require that The most recent push must be approved by someone other than the last pusher.
    /// </summary>
    [JsonPropertyName("requireLastPushApproval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// 6. This requirement matches GitHub&apos;s API, see the upstream documentation for more information.
    /// (https://developer.github.com/v3/repos/branches/#parameters-1) for more information.
    /// Require &apos;x&apos; number of approvals to satisfy branch protection requirements. If this is specified it must be a number between 0-6.
    /// </summary>
    [JsonPropertyName("requiredApprovingReviewCount")]
    public long? RequiredApprovingReviewCount { get; set; }

    /// <summary>
    /// :  Restrict pull request review dismissals.
    /// Restrict pull request review dismissals.
    /// </summary>
    [JsonPropertyName("restrictDismissals")]
    public bool? RestrictDismissals { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecInitProviderRequiredStatusChecks
{
    /// <summary>
    /// :  The list of status checks to require in order to merge into this branch. No status checks are required by default.
    /// The list of status checks to require in order to merge into this branch. No status checks are required by default.
    /// </summary>
    [JsonPropertyName("contexts")]
    public IList<string>? Contexts { get; set; }

    /// <summary>
    /// :  Require branches to be up to date before merging. Defaults to false.
    /// Require branches to be up to date before merging.
    /// </summary>
    [JsonPropertyName("strict")]
    public bool? Strict { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpecInitProviderRestrictPushes
{
    /// <summary>
    /// Boolean, setting this to false allows people, teams, or apps to create new branches matching this rule. Defaults to true.
    /// Restrict pushes that create matching branches.
    /// </summary>
    [JsonPropertyName("blocksCreations")]
    public bool? BlocksCreations { get; set; }

    /// <summary>
    /// A list of actor Names/IDs that may push to the branch. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams. Organization administrators, repository administrators, and users with the Maintain role on the repository can always push when all other requirements have passed.
    /// The list of actor Names/IDs that may push to the branch. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("pushAllowances")]
    public IList<string>? PushAllowances { get; set; }
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
public partial class V1alpha1BranchProtectionSpecInitProvider
{
    /// <summary>
    /// Boolean, setting this to true to allow the branch to be deleted.
    /// Setting this to &apos;true&apos; to allow the branch to be deleted.
    /// </summary>
    [JsonPropertyName("allowsDeletions")]
    public bool? AllowsDeletions { get; set; }

    /// <summary>
    /// Boolean, setting this to true to allow force pushes on the branch to everyone. Set it to false if you specify force_push_bypassers.
    /// Setting this to &apos;true&apos; to allow force pushes on the branch.
    /// </summary>
    [JsonPropertyName("allowsForcePushes")]
    public bool? AllowsForcePushes { get; set; }

    /// <summary>
    /// Boolean, setting this to true enforces status checks for repository administrators.
    /// Setting this to &apos;true&apos; enforces status checks for repository administrators.
    /// </summary>
    [JsonPropertyName("enforceAdmins")]
    public bool? EnforceAdmins { get; set; }

    /// <summary>
    /// The list of actor Names/IDs that are allowed to bypass force push restrictions. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams. If the list is not empty, allows_force_pushes should be set to false.
    /// The list of actor Names/IDs that are allowed to bypass force push restrictions. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("forcePushBypassers")]
    public IList<string>? ForcePushBypassers { get; set; }

    /// <summary>
    /// Boolean, Setting this to true will make the branch read-only and preventing any pushes to it. Defaults to false
    /// Setting this to &apos;true&apos; will make the branch read-only and preventing any pushes to it.
    /// </summary>
    [JsonPropertyName("lockBranch")]
    public bool? LockBranch { get; set; }

    /// <summary>
    /// Identifies the protection rule pattern.
    /// Identifies the protection rule pattern.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>
    /// The name or node ID of the repository associated with this branch protection rule.
    /// The name or node ID of the repository associated with this branch protection rule.
    /// </summary>
    [JsonPropertyName("repositoryId")]
    public string? RepositoryId { get; set; }

    /// <summary>Reference to a Repository in repo to populate repositoryId.</summary>
    [JsonPropertyName("repositoryIdRef")]
    public V1alpha1BranchProtectionSpecInitProviderRepositoryIdRef? RepositoryIdRef { get; set; }

    /// <summary>Selector for a Repository in repo to populate repositoryId.</summary>
    [JsonPropertyName("repositoryIdSelector")]
    public V1alpha1BranchProtectionSpecInitProviderRepositoryIdSelector? RepositoryIdSelector { get; set; }

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
    /// Boolean, setting this to true enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch
    /// Setting this to &apos;true&apos; enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch.
    /// </summary>
    [JsonPropertyName("requiredLinearHistory")]
    public bool? RequiredLinearHistory { get; set; }

    /// <summary>
    /// Enforce restrictions for pull request reviews. See Required Pull Request Reviews below for details.
    /// Enforce restrictions for pull request reviews.
    /// </summary>
    [JsonPropertyName("requiredPullRequestReviews")]
    public IList<V1alpha1BranchProtectionSpecInitProviderRequiredPullRequestReviews>? RequiredPullRequestReviews { get; set; }

    /// <summary>
    /// Enforce restrictions for required status checks. See Required Status Checks below for details.
    /// Enforce restrictions for required status checks.
    /// </summary>
    [JsonPropertyName("requiredStatusChecks")]
    public IList<V1alpha1BranchProtectionSpecInitProviderRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// Restrict pushes to matching branches. See Restrict Pushes below for details.
    /// Restrict who can push to matching branches.
    /// </summary>
    [JsonPropertyName("restrictPushes")]
    public IList<V1alpha1BranchProtectionSpecInitProviderRestrictPushes>? RestrictPushes { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1BranchProtectionSpecManagementPoliciesEnum>))]
public enum V1alpha1BranchProtectionSpecManagementPoliciesEnum
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
public partial class V1alpha1BranchProtectionSpecProviderConfigRef
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
public partial class V1alpha1BranchProtectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>BranchProtectionSpec defines the desired state of BranchProtection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1BranchProtectionSpecForProvider ForProvider { get; set; }

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
    public V1alpha1BranchProtectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1BranchProtectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1BranchProtectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1BranchProtectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionStatusAtProviderRequiredPullRequestReviews
{
    /// <summary>
    /// :  Dismiss approved reviews automatically when a new commit is pushed. Defaults to false.
    /// Dismiss approved reviews automatically when a new commit is pushed.
    /// </summary>
    [JsonPropertyName("dismissStaleReviews")]
    public bool? DismissStaleReviews { get; set; }

    /// <summary>
    /// :  The list of actor Names/IDs with dismissal access. If not empty, restrict_dismissals is ignored. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams.
    /// The list of actor Names/IDs with dismissal access. If not empty, &apos;restrict_dismissals&apos; is ignored. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("dismissalRestrictions")]
    public IList<string>? DismissalRestrictions { get; set; }

    /// <summary>
    /// :  The list of actor Names/IDs that are allowed to bypass pull request requirements. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams.
    /// The list of actor Names/IDs that are allowed to bypass pull request requirements. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("pullRequestBypassers")]
    public IList<string>? PullRequestBypassers { get; set; }

    /// <summary>
    /// :  Require an approved review in pull requests including files with a designated code owner. Defaults to false.
    /// Require an approved review in pull requests including files with a designated code owner.
    /// </summary>
    [JsonPropertyName("requireCodeOwnerReviews")]
    public bool? RequireCodeOwnerReviews { get; set; }

    /// <summary>
    /// :  Require that The most recent push must be approved by someone other than the last pusher.  Defaults to false
    /// Require that The most recent push must be approved by someone other than the last pusher.
    /// </summary>
    [JsonPropertyName("requireLastPushApproval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// 6. This requirement matches GitHub&apos;s API, see the upstream documentation for more information.
    /// (https://developer.github.com/v3/repos/branches/#parameters-1) for more information.
    /// Require &apos;x&apos; number of approvals to satisfy branch protection requirements. If this is specified it must be a number between 0-6.
    /// </summary>
    [JsonPropertyName("requiredApprovingReviewCount")]
    public long? RequiredApprovingReviewCount { get; set; }

    /// <summary>
    /// :  Restrict pull request review dismissals.
    /// Restrict pull request review dismissals.
    /// </summary>
    [JsonPropertyName("restrictDismissals")]
    public bool? RestrictDismissals { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionStatusAtProviderRequiredStatusChecks
{
    /// <summary>
    /// :  The list of status checks to require in order to merge into this branch. No status checks are required by default.
    /// The list of status checks to require in order to merge into this branch. No status checks are required by default.
    /// </summary>
    [JsonPropertyName("contexts")]
    public IList<string>? Contexts { get; set; }

    /// <summary>
    /// :  Require branches to be up to date before merging. Defaults to false.
    /// Require branches to be up to date before merging.
    /// </summary>
    [JsonPropertyName("strict")]
    public bool? Strict { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionStatusAtProviderRestrictPushes
{
    /// <summary>
    /// Boolean, setting this to false allows people, teams, or apps to create new branches matching this rule. Defaults to true.
    /// Restrict pushes that create matching branches.
    /// </summary>
    [JsonPropertyName("blocksCreations")]
    public bool? BlocksCreations { get; set; }

    /// <summary>
    /// A list of actor Names/IDs that may push to the branch. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams. Organization administrators, repository administrators, and users with the Maintain role on the repository can always push when all other requirements have passed.
    /// The list of actor Names/IDs that may push to the branch. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("pushAllowances")]
    public IList<string>? PushAllowances { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionStatusAtProvider
{
    /// <summary>
    /// Boolean, setting this to true to allow the branch to be deleted.
    /// Setting this to &apos;true&apos; to allow the branch to be deleted.
    /// </summary>
    [JsonPropertyName("allowsDeletions")]
    public bool? AllowsDeletions { get; set; }

    /// <summary>
    /// Boolean, setting this to true to allow force pushes on the branch to everyone. Set it to false if you specify force_push_bypassers.
    /// Setting this to &apos;true&apos; to allow force pushes on the branch.
    /// </summary>
    [JsonPropertyName("allowsForcePushes")]
    public bool? AllowsForcePushes { get; set; }

    /// <summary>
    /// Boolean, setting this to true enforces status checks for repository administrators.
    /// Setting this to &apos;true&apos; enforces status checks for repository administrators.
    /// </summary>
    [JsonPropertyName("enforceAdmins")]
    public bool? EnforceAdmins { get; set; }

    /// <summary>
    /// The list of actor Names/IDs that are allowed to bypass force push restrictions. Actor names must either begin with a &quot;/&quot; for users or the organization name followed by a &quot;/&quot; for teams. If the list is not empty, allows_force_pushes should be set to false.
    /// The list of actor Names/IDs that are allowed to bypass force push restrictions. Actor names must either begin with a &apos;/&apos; for users or the organization name followed by a &apos;/&apos; for teams.
    /// </summary>
    [JsonPropertyName("forcePushBypassers")]
    public IList<string>? ForcePushBypassers { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Boolean, Setting this to true will make the branch read-only and preventing any pushes to it. Defaults to false
    /// Setting this to &apos;true&apos; will make the branch read-only and preventing any pushes to it.
    /// </summary>
    [JsonPropertyName("lockBranch")]
    public bool? LockBranch { get; set; }

    /// <summary>
    /// Identifies the protection rule pattern.
    /// Identifies the protection rule pattern.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>
    /// The name or node ID of the repository associated with this branch protection rule.
    /// The name or node ID of the repository associated with this branch protection rule.
    /// </summary>
    [JsonPropertyName("repositoryId")]
    public string? RepositoryId { get; set; }

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
    /// Boolean, setting this to true enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch
    /// Setting this to &apos;true&apos; enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch.
    /// </summary>
    [JsonPropertyName("requiredLinearHistory")]
    public bool? RequiredLinearHistory { get; set; }

    /// <summary>
    /// Enforce restrictions for pull request reviews. See Required Pull Request Reviews below for details.
    /// Enforce restrictions for pull request reviews.
    /// </summary>
    [JsonPropertyName("requiredPullRequestReviews")]
    public IList<V1alpha1BranchProtectionStatusAtProviderRequiredPullRequestReviews>? RequiredPullRequestReviews { get; set; }

    /// <summary>
    /// Enforce restrictions for required status checks. See Required Status Checks below for details.
    /// Enforce restrictions for required status checks.
    /// </summary>
    [JsonPropertyName("requiredStatusChecks")]
    public IList<V1alpha1BranchProtectionStatusAtProviderRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// Restrict pushes to matching branches. See Restrict Pushes below for details.
    /// Restrict who can push to matching branches.
    /// </summary>
    [JsonPropertyName("restrictPushes")]
    public IList<V1alpha1BranchProtectionStatusAtProviderRestrictPushes>? RestrictPushes { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionStatusConditions
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

/// <summary>BranchProtectionStatus defines the observed state of BranchProtection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BranchProtectionStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1BranchProtectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BranchProtectionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BranchProtection is the Schema for the BranchProtections API. Protects a GitHub branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BranchProtection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BranchProtectionSpec>, IStatus<V1alpha1BranchProtectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BranchProtection";
    public const string KubeGroup = "repo.github.m.upbound.io";
    public const string KubePluralName = "branchprotections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "repo.github.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BranchProtection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BranchProtectionSpec defines the desired state of BranchProtection</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BranchProtectionSpec Spec { get; set; }

    /// <summary>BranchProtectionStatus defines the observed state of BranchProtection.</summary>
    [JsonPropertyName("status")]
    public V1alpha1BranchProtectionStatus? Status { get; set; }
}