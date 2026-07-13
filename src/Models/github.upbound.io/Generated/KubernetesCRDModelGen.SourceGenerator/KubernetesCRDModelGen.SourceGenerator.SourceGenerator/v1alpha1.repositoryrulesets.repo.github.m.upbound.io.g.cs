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
/// <summary>RepositoryRuleset is the Schema for the RepositoryRulesets API. Creates a GitHub repository ruleset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RepositoryRulesetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RepositoryRuleset>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RepositoryRulesetList";
    public const string KubeGroup = "repo.github.m.upbound.io";
    public const string KubePluralName = "repositoryrulesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "repo.github.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RepositoryRulesetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RepositoryRuleset objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RepositoryRuleset> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderBypassActors
{
    /// <summary>
    /// (Number) The ID of the actor that can bypass a ruleset. If actor_type is Integration, actor_id is a GitHub App ID. App ID can be obtained by following instructions from the Get an App API docs
    /// The ID of the actor that can bypass a ruleset. When `actor_type` is `OrganizationAdmin`, this should be set to `1`.
    /// </summary>
    [JsonPropertyName("actorId")]
    public long? ActorId { get; set; }

    /// <summary>
    /// (String) The type of actor that can bypass a ruleset. Can be one of: RepositoryRole, Team, Integration, OrganizationAdmin.
    /// The type of actor that can bypass a ruleset. Can be one of: `RepositoryRole`, `Team`, `Integration`, `OrganizationAdmin`.
    /// </summary>
    [JsonPropertyName("actorType")]
    public string? ActorType { get; set; }

    /// <summary>
    /// (String) When the specified actor can bypass the ruleset. pull_request means that an actor can only bypass rules on pull requests. Can be one of: always, pull_request.
    /// When the specified actor can bypass the ruleset. pull_request means that an actor can only bypass rules on pull requests. Can be one of: `always`, `pull_request`.
    /// </summary>
    [JsonPropertyName("bypassMode")]
    public string? BypassMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderConditionsRefName
{
    /// <summary>
    /// (List of String) Array of ref names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// Array of ref names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// </summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>
    /// (List of String) Array of ref names or patterns to include. One of these patterns must match for the condition to pass. Also accepts ~DEFAULT_BRANCH to include the default branch or ~ALL to include all branches.
    /// Array of ref names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~DEFAULT_BRANCH` to include the default branch or `~ALL` to include all branches.
    /// </summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderConditions
{
    /// <summary>(Block List, Min: 1, Max: 1) (see below for nested schema)</summary>
    [JsonPropertyName("refName")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderConditionsRefName>? RefName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositoryRulesetSpecForProviderRepositoryRefPolicyResolutionEnum>))]
public enum V1alpha1RepositoryRulesetSpecForProviderRepositoryRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositoryRulesetSpecForProviderRepositoryRefPolicyResolveEnum>))]
public enum V1alpha1RepositoryRulesetSpecForProviderRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRepositoryRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1RepositoryRulesetSpecForProviderRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1RepositoryRulesetSpecForProviderRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Repository in repo to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1RepositoryRulesetSpecForProviderRepositoryRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositoryRulesetSpecForProviderRepositorySelectorPolicyResolutionEnum>))]
public enum V1alpha1RepositoryRulesetSpecForProviderRepositorySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositoryRulesetSpecForProviderRepositorySelectorPolicyResolveEnum>))]
public enum V1alpha1RepositoryRulesetSpecForProviderRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRepositorySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1RepositoryRulesetSpecForProviderRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1RepositoryRulesetSpecForProviderRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Repository in repo to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRepositorySelector
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
    public V1alpha1RepositoryRulesetSpecForProviderRepositorySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesBranchNamePattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesCommitAuthorEmailPattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesCommitMessagePattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesCommitterEmailPattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesMergeQueue
{
    /// <summary>
    /// (Number)Maximum time for a required status check to report a conclusion. After this much time has elapsed, checks that have not reported a conclusion will be assumed to have failed. Defaults to 60.
    /// Maximum time for a required status check to report a conclusion. After this much time has elapsed, checks that have not reported a conclusion will be assumed to have failed. Defaults to `60`.
    /// </summary>
    [JsonPropertyName("checkResponseTimeoutMinutes")]
    public long? CheckResponseTimeoutMinutes { get; set; }

    /// <summary>
    /// (String)When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge. Can be one of: ALLGREEN, HEADGREEN. Defaults to ALLGREEN.
    /// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge. Can be one of: ALLGREEN, HEADGREEN. Defaults to `ALLGREEN`.
    /// </summary>
    [JsonPropertyName("groupingStrategy")]
    public string? GroupingStrategy { get; set; }

    /// <summary>
    /// (Number) Limit the number of queued pull requests requesting checks and workflow runs at the same time. Defaults to 5.
    /// Limit the number of queued pull requests requesting checks and workflow runs at the same time. Defaults to `5`.
    /// </summary>
    [JsonPropertyName("maxEntriesToBuild")]
    public long? MaxEntriesToBuild { get; set; }

    /// <summary>
    /// (Number) Limit the number of queued pull requests requesting checks and workflow runs at the same time. Defaults to 5.
    /// The maximum number of PRs that will be merged together in a group. Defaults to `5`.
    /// </summary>
    [JsonPropertyName("maxEntriesToMerge")]
    public long? MaxEntriesToMerge { get; set; }

    /// <summary>
    /// (String) Method to use when merging changes from queued pull requests. Can be one of: MERGE, SQUASH, REBASE. Defaults to MERGE.
    /// Method to use when merging changes from queued pull requests. Can be one of: MERGE, SQUASH, REBASE. Defaults to `MERGE`.
    /// </summary>
    [JsonPropertyName("mergeMethod")]
    public string? MergeMethod { get; set; }

    /// <summary>
    /// (Number) The minimum number of PRs that will be merged together in a group. Defaults to 1.
    /// The minimum number of PRs that will be merged together in a group. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("minEntriesToMerge")]
    public long? MinEntriesToMerge { get; set; }

    /// <summary>
    /// (Number) The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged. Defaults to 5.
    /// The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged. Defaults to `5`.
    /// </summary>
    [JsonPropertyName("minEntriesToMergeWaitMinutes")]
    public long? MinEntriesToMergeWaitMinutes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesPullRequest
{
    /// <summary>
    /// (Boolean) New, reviewable commits pushed will dismiss previous pull request review approvals. Defaults to false.
    /// New, reviewable commits pushed will dismiss previous pull request review approvals. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("dismissStaleReviewsOnPush")]
    public bool? DismissStaleReviewsOnPush { get; set; }

    /// <summary>
    /// (Boolean) Require an approving review in pull requests that modify files that have a designated code owner. Defaults to false.
    /// Require an approving review in pull requests that modify files that have a designated code owner. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("requireCodeOwnerReview")]
    public bool? RequireCodeOwnerReview { get; set; }

    /// <summary>
    /// (Boolean) Whether the most recent reviewable push must be approved by someone other than the person who pushed it. Defaults to false.
    /// Whether the most recent reviewable push must be approved by someone other than the person who pushed it. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("requireLastPushApproval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// (Number) The number of approving reviews that are required before a pull request can be merged. Defaults to 0.
    /// The number of approving reviews that are required before a pull request can be merged. Defaults to `0`.
    /// </summary>
    [JsonPropertyName("requiredApprovingReviewCount")]
    public long? RequiredApprovingReviewCount { get; set; }

    /// <summary>
    /// (Boolean) All conversations on code must be resolved before a pull request can be merged. Defaults to false.
    /// All conversations on code must be resolved before a pull request can be merged. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("requiredReviewThreadResolution")]
    public bool? RequiredReviewThreadResolution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesRequiredCodeScanningRequiredCodeScanningTool
{
    /// <summary>
    /// (String) The severity level at which code scanning results that raise alerts block a reference update. Can be one of: none, errors, errors_and_warnings, all.
    /// The severity level at which code scanning results that raise alerts block a reference update. Can be one of: `none`, `errors`, `errors_and_warnings`, `all`.
    /// </summary>
    [JsonPropertyName("alertsThreshold")]
    public string? AlertsThreshold { get; set; }

    /// <summary>
    /// (String) The severity level at which code scanning results that raise security alerts block a reference update. Can be one of: none, critical, high_or_higher, medium_or_higher, all.
    /// The severity level at which code scanning results that raise security alerts block a reference update. Can be one of: `none`, `critical`, `high_or_higher`, `medium_or_higher`, `all`.
    /// </summary>
    [JsonPropertyName("securityAlertsThreshold")]
    public string? SecurityAlertsThreshold { get; set; }

    /// <summary>
    /// (String) The name of a code scanning tool.
    /// The name of a code scanning tool
    /// </summary>
    [JsonPropertyName("tool")]
    public string? Tool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesRequiredCodeScanning
{
    /// <summary>
    /// (Block Set, Min: 1) Actions code scanning tools that are required. Multiple can be defined. (see below for nested schema)
    /// Tools that must provide code scanning results for this rule to pass.
    /// </summary>
    [JsonPropertyName("requiredCodeScanningTool")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesRequiredCodeScanningRequiredCodeScanningTool>? RequiredCodeScanningTool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesRequiredDeployments
{
    /// <summary>
    /// (List of String) The environments that must be successfully deployed to before branches can be merged.
    /// The environments that must be successfully deployed to before branches can be merged.
    /// </summary>
    [JsonPropertyName("requiredDeploymentEnvironments")]
    public IList<string>? RequiredDeploymentEnvironments { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesRequiredStatusChecksRequiredCheck
{
    /// <summary>
    /// (String) The status check context name that must be present on the commit.
    /// The status check context name that must be present on the commit.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// (Number) The optional integration ID that this status check must originate from. It&apos;s a GitHub App ID, which can be obtained by following instructions from the Get an App API docs.
    /// The optional integration ID that this status check must originate from.
    /// </summary>
    [JsonPropertyName("integrationId")]
    public long? IntegrationId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesRequiredStatusChecks
{
    /// <summary>
    /// (Boolean) Allow repositories and branches to be created if a check would otherwise prohibit it. Defaults to false.
    /// Allow repositories and branches to be created if a check would otherwise prohibit it.
    /// </summary>
    [JsonPropertyName("doNotEnforceOnCreate")]
    public bool? DoNotEnforceOnCreate { get; set; }

    /// <summary>
    /// (Block Set, Min: 1) Status checks that are required. Several can be defined. (see below for nested schema)
    /// Status checks that are required. Several can be defined.
    /// </summary>
    [JsonPropertyName("requiredCheck")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesRequiredStatusChecksRequiredCheck>? RequiredCheck { get; set; }

    /// <summary>
    /// (Boolean) Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to false.
    /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("strictRequiredStatusChecksPolicy")]
    public bool? StrictRequiredStatusChecksPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRulesTagNamePattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProviderRules
{
    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with tag_name_pattern as it only applied to rulesets with target branch. (see below for nested schema)
    /// Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `tag_name_pattern` as it only applies to rulesets with target `branch`.
    /// </summary>
    [JsonPropertyName("branchNamePattern")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesBranchNamePattern>? BranchNamePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_author_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_author_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations.
    /// </summary>
    [JsonPropertyName("commitAuthorEmailPattern")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesCommitAuthorEmailPattern>? CommitAuthorEmailPattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_message_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_message_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations.
    /// </summary>
    [JsonPropertyName("commitMessagePattern")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesCommitMessagePattern>? CommitMessagePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the committer_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the committer_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations.
    /// </summary>
    [JsonPropertyName("committerEmailPattern")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesCommitterEmailPattern>? CommitterEmailPattern { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permission to create matching refs.
    /// Only allow users with bypass permission to create matching refs.
    /// </summary>
    [JsonPropertyName("creation")]
    public bool? Creation { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permissions to delete matching refs.
    /// Only allow users with bypass permissions to delete matching refs.
    /// </summary>
    [JsonPropertyName("deletion")]
    public bool? Deletion { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Merges must be performed via a merge queue.
    /// Merges must be performed via a merge queue.
    /// </summary>
    [JsonPropertyName("mergeQueue")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesMergeQueue>? MergeQueue { get; set; }

    /// <summary>
    /// (Boolean) Prevent users with push access from force pushing to branches.
    /// Prevent users with push access from force pushing to branches.
    /// </summary>
    [JsonPropertyName("nonFastForward")]
    public bool? NonFastForward { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Require all commits be made to a non-target branch and submitted via a pull request before they can be merged. (see below for nested schema)
    /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesPullRequest>? PullRequest { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Define which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated. Multiple code scanning tools can be specified. (see below for nested schema)
    /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
    /// </summary>
    [JsonPropertyName("requiredCodeScanning")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesRequiredCodeScanning>? RequiredCodeScanning { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Choose which environments must be successfully deployed to before branches can be merged into a branch that matches this rule. (see below for nested schema)
    /// Choose which environments must be successfully deployed to before branches can be merged into a branch that matches this rule.
    /// </summary>
    [JsonPropertyName("requiredDeployments")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesRequiredDeployments>? RequiredDeployments { get; set; }

    /// <summary>
    /// (Boolean) Prevent merge commits from being pushed to matching branches.
    /// Prevent merge commits from being pushed to matching branches.
    /// </summary>
    [JsonPropertyName("requiredLinearHistory")]
    public bool? RequiredLinearHistory { get; set; }

    /// <summary>
    /// (Boolean) Commits pushed to matching branches must have verified signatures.
    /// Commits pushed to matching branches must have verified signatures.
    /// </summary>
    [JsonPropertyName("requiredSignatures")]
    public bool? RequiredSignatures { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Choose which status checks must pass before branches can be merged into a branch that matches this rule. When enabled, commits must first be pushed to another branch, then merged or pushed directly to a branch that matches this rule after status checks have passed. (see below for nested schema)
    /// Choose which status checks must pass before branches can be merged into a branch that matches this rule. When enabled, commits must first be pushed to another branch, then merged or pushed directly to a branch that matches this rule after status checks have passed.
    /// </summary>
    [JsonPropertyName("requiredStatusChecks")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with branch_name_pattern as it only applied to rulesets with target tag. (see below for nested schema)
    /// Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `branch_name_pattern` as it only applies to rulesets with target `tag`.
    /// </summary>
    [JsonPropertyName("tagNamePattern")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRulesTagNamePattern>? TagNamePattern { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permission to update matching refs.
    /// Only allow users with bypass permission to update matching refs.
    /// </summary>
    [JsonPropertyName("update")]
    public bool? Update { get; set; }

    /// <summary>
    /// (Boolean) Branch can pull changes from its upstream repository. This is only applicable to forked repositories. Requires update to be set to true. Note: behaviour is affected by a known bug on the GitHub side which may cause issues when using this parameter.
    /// Branch can pull changes from its upstream repository. This is only applicable to forked repositories. Requires `update` to be set to `true`.
    /// </summary>
    [JsonPropertyName("updateAllowsFetchAndMerge")]
    public bool? UpdateAllowsFetchAndMerge { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecForProvider
{
    /// <summary>
    /// (Block List) The actors that can bypass the rules in this ruleset. (see below for nested schema)
    /// The actors that can bypass the rules in this ruleset.
    /// </summary>
    [JsonPropertyName("bypassActors")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderBypassActors>? BypassActors { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters for a repository ruleset ref name condition. (see below for nested schema)
    /// Parameters for a repository ruleset ref name condition.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderConditions>? Conditions { get; set; }

    /// <summary>
    /// (String) Possible values for Enforcement are disabled, active, evaluate. Note: evaluate is currently only supported for owners of type organization.
    /// Possible values for Enforcement are `disabled`, `active`, `evaluate`. Note: `evaluate` is currently only supported for owners of type `organization`.
    /// </summary>
    [JsonPropertyName("enforcement")]
    public string? Enforcement { get; set; }

    /// <summary>
    /// (String) The name of the ruleset.
    /// The name of the ruleset.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (String) Name of the repository to apply rulset to.
    /// Name of the repository to apply rulset to.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Reference to a Repository in repo to populate repository.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1alpha1RepositoryRulesetSpecForProviderRepositoryRef? RepositoryRef { get; set; }

    /// <summary>Selector for a Repository in repo to populate repository.</summary>
    [JsonPropertyName("repositorySelector")]
    public V1alpha1RepositoryRulesetSpecForProviderRepositorySelector? RepositorySelector { get; set; }

    /// <summary>
    /// (Block List, Min: 1, Max: 1) Rules within the ruleset. (see below for nested schema)
    /// Rules within the ruleset.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1RepositoryRulesetSpecForProviderRules>? Rules { get; set; }

    /// <summary>
    /// (String) Possible values are branch and tag.
    /// Possible values are `branch` and `tag`.
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderBypassActors
{
    /// <summary>
    /// (Number) The ID of the actor that can bypass a ruleset. If actor_type is Integration, actor_id is a GitHub App ID. App ID can be obtained by following instructions from the Get an App API docs
    /// The ID of the actor that can bypass a ruleset. When `actor_type` is `OrganizationAdmin`, this should be set to `1`.
    /// </summary>
    [JsonPropertyName("actorId")]
    public long? ActorId { get; set; }

    /// <summary>
    /// (String) The type of actor that can bypass a ruleset. Can be one of: RepositoryRole, Team, Integration, OrganizationAdmin.
    /// The type of actor that can bypass a ruleset. Can be one of: `RepositoryRole`, `Team`, `Integration`, `OrganizationAdmin`.
    /// </summary>
    [JsonPropertyName("actorType")]
    public string? ActorType { get; set; }

    /// <summary>
    /// (String) When the specified actor can bypass the ruleset. pull_request means that an actor can only bypass rules on pull requests. Can be one of: always, pull_request.
    /// When the specified actor can bypass the ruleset. pull_request means that an actor can only bypass rules on pull requests. Can be one of: `always`, `pull_request`.
    /// </summary>
    [JsonPropertyName("bypassMode")]
    public string? BypassMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderConditionsRefName
{
    /// <summary>
    /// (List of String) Array of ref names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// Array of ref names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// </summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>
    /// (List of String) Array of ref names or patterns to include. One of these patterns must match for the condition to pass. Also accepts ~DEFAULT_BRANCH to include the default branch or ~ALL to include all branches.
    /// Array of ref names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~DEFAULT_BRANCH` to include the default branch or `~ALL` to include all branches.
    /// </summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderConditions
{
    /// <summary>(Block List, Min: 1, Max: 1) (see below for nested schema)</summary>
    [JsonPropertyName("refName")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderConditionsRefName>? RefName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositoryRulesetSpecInitProviderRepositoryRefPolicyResolutionEnum>))]
public enum V1alpha1RepositoryRulesetSpecInitProviderRepositoryRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositoryRulesetSpecInitProviderRepositoryRefPolicyResolveEnum>))]
public enum V1alpha1RepositoryRulesetSpecInitProviderRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRepositoryRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1RepositoryRulesetSpecInitProviderRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1RepositoryRulesetSpecInitProviderRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Repository in repo to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1RepositoryRulesetSpecInitProviderRepositoryRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositoryRulesetSpecInitProviderRepositorySelectorPolicyResolutionEnum>))]
public enum V1alpha1RepositoryRulesetSpecInitProviderRepositorySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositoryRulesetSpecInitProviderRepositorySelectorPolicyResolveEnum>))]
public enum V1alpha1RepositoryRulesetSpecInitProviderRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRepositorySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1RepositoryRulesetSpecInitProviderRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1RepositoryRulesetSpecInitProviderRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Repository in repo to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRepositorySelector
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
    public V1alpha1RepositoryRulesetSpecInitProviderRepositorySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesBranchNamePattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesCommitAuthorEmailPattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesCommitMessagePattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesCommitterEmailPattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesMergeQueue
{
    /// <summary>
    /// (Number)Maximum time for a required status check to report a conclusion. After this much time has elapsed, checks that have not reported a conclusion will be assumed to have failed. Defaults to 60.
    /// Maximum time for a required status check to report a conclusion. After this much time has elapsed, checks that have not reported a conclusion will be assumed to have failed. Defaults to `60`.
    /// </summary>
    [JsonPropertyName("checkResponseTimeoutMinutes")]
    public long? CheckResponseTimeoutMinutes { get; set; }

    /// <summary>
    /// (String)When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge. Can be one of: ALLGREEN, HEADGREEN. Defaults to ALLGREEN.
    /// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge. Can be one of: ALLGREEN, HEADGREEN. Defaults to `ALLGREEN`.
    /// </summary>
    [JsonPropertyName("groupingStrategy")]
    public string? GroupingStrategy { get; set; }

    /// <summary>
    /// (Number) Limit the number of queued pull requests requesting checks and workflow runs at the same time. Defaults to 5.
    /// Limit the number of queued pull requests requesting checks and workflow runs at the same time. Defaults to `5`.
    /// </summary>
    [JsonPropertyName("maxEntriesToBuild")]
    public long? MaxEntriesToBuild { get; set; }

    /// <summary>
    /// (Number) Limit the number of queued pull requests requesting checks and workflow runs at the same time. Defaults to 5.
    /// The maximum number of PRs that will be merged together in a group. Defaults to `5`.
    /// </summary>
    [JsonPropertyName("maxEntriesToMerge")]
    public long? MaxEntriesToMerge { get; set; }

    /// <summary>
    /// (String) Method to use when merging changes from queued pull requests. Can be one of: MERGE, SQUASH, REBASE. Defaults to MERGE.
    /// Method to use when merging changes from queued pull requests. Can be one of: MERGE, SQUASH, REBASE. Defaults to `MERGE`.
    /// </summary>
    [JsonPropertyName("mergeMethod")]
    public string? MergeMethod { get; set; }

    /// <summary>
    /// (Number) The minimum number of PRs that will be merged together in a group. Defaults to 1.
    /// The minimum number of PRs that will be merged together in a group. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("minEntriesToMerge")]
    public long? MinEntriesToMerge { get; set; }

    /// <summary>
    /// (Number) The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged. Defaults to 5.
    /// The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged. Defaults to `5`.
    /// </summary>
    [JsonPropertyName("minEntriesToMergeWaitMinutes")]
    public long? MinEntriesToMergeWaitMinutes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesPullRequest
{
    /// <summary>
    /// (Boolean) New, reviewable commits pushed will dismiss previous pull request review approvals. Defaults to false.
    /// New, reviewable commits pushed will dismiss previous pull request review approvals. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("dismissStaleReviewsOnPush")]
    public bool? DismissStaleReviewsOnPush { get; set; }

    /// <summary>
    /// (Boolean) Require an approving review in pull requests that modify files that have a designated code owner. Defaults to false.
    /// Require an approving review in pull requests that modify files that have a designated code owner. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("requireCodeOwnerReview")]
    public bool? RequireCodeOwnerReview { get; set; }

    /// <summary>
    /// (Boolean) Whether the most recent reviewable push must be approved by someone other than the person who pushed it. Defaults to false.
    /// Whether the most recent reviewable push must be approved by someone other than the person who pushed it. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("requireLastPushApproval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// (Number) The number of approving reviews that are required before a pull request can be merged. Defaults to 0.
    /// The number of approving reviews that are required before a pull request can be merged. Defaults to `0`.
    /// </summary>
    [JsonPropertyName("requiredApprovingReviewCount")]
    public long? RequiredApprovingReviewCount { get; set; }

    /// <summary>
    /// (Boolean) All conversations on code must be resolved before a pull request can be merged. Defaults to false.
    /// All conversations on code must be resolved before a pull request can be merged. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("requiredReviewThreadResolution")]
    public bool? RequiredReviewThreadResolution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredCodeScanningRequiredCodeScanningTool
{
    /// <summary>
    /// (String) The severity level at which code scanning results that raise alerts block a reference update. Can be one of: none, errors, errors_and_warnings, all.
    /// The severity level at which code scanning results that raise alerts block a reference update. Can be one of: `none`, `errors`, `errors_and_warnings`, `all`.
    /// </summary>
    [JsonPropertyName("alertsThreshold")]
    public string? AlertsThreshold { get; set; }

    /// <summary>
    /// (String) The severity level at which code scanning results that raise security alerts block a reference update. Can be one of: none, critical, high_or_higher, medium_or_higher, all.
    /// The severity level at which code scanning results that raise security alerts block a reference update. Can be one of: `none`, `critical`, `high_or_higher`, `medium_or_higher`, `all`.
    /// </summary>
    [JsonPropertyName("securityAlertsThreshold")]
    public string? SecurityAlertsThreshold { get; set; }

    /// <summary>
    /// (String) The name of a code scanning tool.
    /// The name of a code scanning tool
    /// </summary>
    [JsonPropertyName("tool")]
    public string? Tool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredCodeScanning
{
    /// <summary>
    /// (Block Set, Min: 1) Actions code scanning tools that are required. Multiple can be defined. (see below for nested schema)
    /// Tools that must provide code scanning results for this rule to pass.
    /// </summary>
    [JsonPropertyName("requiredCodeScanningTool")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredCodeScanningRequiredCodeScanningTool>? RequiredCodeScanningTool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredDeployments
{
    /// <summary>
    /// (List of String) The environments that must be successfully deployed to before branches can be merged.
    /// The environments that must be successfully deployed to before branches can be merged.
    /// </summary>
    [JsonPropertyName("requiredDeploymentEnvironments")]
    public IList<string>? RequiredDeploymentEnvironments { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredStatusChecksRequiredCheck
{
    /// <summary>
    /// (String) The status check context name that must be present on the commit.
    /// The status check context name that must be present on the commit.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// (Number) The optional integration ID that this status check must originate from. It&apos;s a GitHub App ID, which can be obtained by following instructions from the Get an App API docs.
    /// The optional integration ID that this status check must originate from.
    /// </summary>
    [JsonPropertyName("integrationId")]
    public long? IntegrationId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredStatusChecks
{
    /// <summary>
    /// (Boolean) Allow repositories and branches to be created if a check would otherwise prohibit it. Defaults to false.
    /// Allow repositories and branches to be created if a check would otherwise prohibit it.
    /// </summary>
    [JsonPropertyName("doNotEnforceOnCreate")]
    public bool? DoNotEnforceOnCreate { get; set; }

    /// <summary>
    /// (Block Set, Min: 1) Status checks that are required. Several can be defined. (see below for nested schema)
    /// Status checks that are required. Several can be defined.
    /// </summary>
    [JsonPropertyName("requiredCheck")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredStatusChecksRequiredCheck>? RequiredCheck { get; set; }

    /// <summary>
    /// (Boolean) Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to false.
    /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("strictRequiredStatusChecksPolicy")]
    public bool? StrictRequiredStatusChecksPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRulesTagNamePattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpecInitProviderRules
{
    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with tag_name_pattern as it only applied to rulesets with target branch. (see below for nested schema)
    /// Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `tag_name_pattern` as it only applies to rulesets with target `branch`.
    /// </summary>
    [JsonPropertyName("branchNamePattern")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesBranchNamePattern>? BranchNamePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_author_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_author_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations.
    /// </summary>
    [JsonPropertyName("commitAuthorEmailPattern")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesCommitAuthorEmailPattern>? CommitAuthorEmailPattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_message_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_message_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations.
    /// </summary>
    [JsonPropertyName("commitMessagePattern")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesCommitMessagePattern>? CommitMessagePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the committer_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the committer_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations.
    /// </summary>
    [JsonPropertyName("committerEmailPattern")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesCommitterEmailPattern>? CommitterEmailPattern { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permission to create matching refs.
    /// Only allow users with bypass permission to create matching refs.
    /// </summary>
    [JsonPropertyName("creation")]
    public bool? Creation { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permissions to delete matching refs.
    /// Only allow users with bypass permissions to delete matching refs.
    /// </summary>
    [JsonPropertyName("deletion")]
    public bool? Deletion { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Merges must be performed via a merge queue.
    /// Merges must be performed via a merge queue.
    /// </summary>
    [JsonPropertyName("mergeQueue")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesMergeQueue>? MergeQueue { get; set; }

    /// <summary>
    /// (Boolean) Prevent users with push access from force pushing to branches.
    /// Prevent users with push access from force pushing to branches.
    /// </summary>
    [JsonPropertyName("nonFastForward")]
    public bool? NonFastForward { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Require all commits be made to a non-target branch and submitted via a pull request before they can be merged. (see below for nested schema)
    /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesPullRequest>? PullRequest { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Define which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated. Multiple code scanning tools can be specified. (see below for nested schema)
    /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
    /// </summary>
    [JsonPropertyName("requiredCodeScanning")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredCodeScanning>? RequiredCodeScanning { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Choose which environments must be successfully deployed to before branches can be merged into a branch that matches this rule. (see below for nested schema)
    /// Choose which environments must be successfully deployed to before branches can be merged into a branch that matches this rule.
    /// </summary>
    [JsonPropertyName("requiredDeployments")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredDeployments>? RequiredDeployments { get; set; }

    /// <summary>
    /// (Boolean) Prevent merge commits from being pushed to matching branches.
    /// Prevent merge commits from being pushed to matching branches.
    /// </summary>
    [JsonPropertyName("requiredLinearHistory")]
    public bool? RequiredLinearHistory { get; set; }

    /// <summary>
    /// (Boolean) Commits pushed to matching branches must have verified signatures.
    /// Commits pushed to matching branches must have verified signatures.
    /// </summary>
    [JsonPropertyName("requiredSignatures")]
    public bool? RequiredSignatures { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Choose which status checks must pass before branches can be merged into a branch that matches this rule. When enabled, commits must first be pushed to another branch, then merged or pushed directly to a branch that matches this rule after status checks have passed. (see below for nested schema)
    /// Choose which status checks must pass before branches can be merged into a branch that matches this rule. When enabled, commits must first be pushed to another branch, then merged or pushed directly to a branch that matches this rule after status checks have passed.
    /// </summary>
    [JsonPropertyName("requiredStatusChecks")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with branch_name_pattern as it only applied to rulesets with target tag. (see below for nested schema)
    /// Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `branch_name_pattern` as it only applies to rulesets with target `tag`.
    /// </summary>
    [JsonPropertyName("tagNamePattern")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRulesTagNamePattern>? TagNamePattern { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permission to update matching refs.
    /// Only allow users with bypass permission to update matching refs.
    /// </summary>
    [JsonPropertyName("update")]
    public bool? Update { get; set; }

    /// <summary>
    /// (Boolean) Branch can pull changes from its upstream repository. This is only applicable to forked repositories. Requires update to be set to true. Note: behaviour is affected by a known bug on the GitHub side which may cause issues when using this parameter.
    /// Branch can pull changes from its upstream repository. This is only applicable to forked repositories. Requires `update` to be set to `true`.
    /// </summary>
    [JsonPropertyName("updateAllowsFetchAndMerge")]
    public bool? UpdateAllowsFetchAndMerge { get; set; }
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
public partial class V1alpha1RepositoryRulesetSpecInitProvider
{
    /// <summary>
    /// (Block List) The actors that can bypass the rules in this ruleset. (see below for nested schema)
    /// The actors that can bypass the rules in this ruleset.
    /// </summary>
    [JsonPropertyName("bypassActors")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderBypassActors>? BypassActors { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters for a repository ruleset ref name condition. (see below for nested schema)
    /// Parameters for a repository ruleset ref name condition.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderConditions>? Conditions { get; set; }

    /// <summary>
    /// (String) Possible values for Enforcement are disabled, active, evaluate. Note: evaluate is currently only supported for owners of type organization.
    /// Possible values for Enforcement are `disabled`, `active`, `evaluate`. Note: `evaluate` is currently only supported for owners of type `organization`.
    /// </summary>
    [JsonPropertyName("enforcement")]
    public string? Enforcement { get; set; }

    /// <summary>
    /// (String) The name of the ruleset.
    /// The name of the ruleset.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (String) Name of the repository to apply rulset to.
    /// Name of the repository to apply rulset to.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Reference to a Repository in repo to populate repository.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1alpha1RepositoryRulesetSpecInitProviderRepositoryRef? RepositoryRef { get; set; }

    /// <summary>Selector for a Repository in repo to populate repository.</summary>
    [JsonPropertyName("repositorySelector")]
    public V1alpha1RepositoryRulesetSpecInitProviderRepositorySelector? RepositorySelector { get; set; }

    /// <summary>
    /// (Block List, Min: 1, Max: 1) Rules within the ruleset. (see below for nested schema)
    /// Rules within the ruleset.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1RepositoryRulesetSpecInitProviderRules>? Rules { get; set; }

    /// <summary>
    /// (String) Possible values are branch and tag.
    /// Possible values are `branch` and `tag`.
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositoryRulesetSpecManagementPoliciesEnum>))]
public enum V1alpha1RepositoryRulesetSpecManagementPoliciesEnum
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
public partial class V1alpha1RepositoryRulesetSpecProviderConfigRef
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
public partial class V1alpha1RepositoryRulesetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RepositoryRulesetSpec defines the desired state of RepositoryRuleset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1RepositoryRulesetSpecForProvider ForProvider { get; set; }

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
    public V1alpha1RepositoryRulesetSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1RepositoryRulesetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1RepositoryRulesetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1RepositoryRulesetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderBypassActors
{
    /// <summary>
    /// (Number) The ID of the actor that can bypass a ruleset. If actor_type is Integration, actor_id is a GitHub App ID. App ID can be obtained by following instructions from the Get an App API docs
    /// The ID of the actor that can bypass a ruleset. When `actor_type` is `OrganizationAdmin`, this should be set to `1`.
    /// </summary>
    [JsonPropertyName("actorId")]
    public long? ActorId { get; set; }

    /// <summary>
    /// (String) The type of actor that can bypass a ruleset. Can be one of: RepositoryRole, Team, Integration, OrganizationAdmin.
    /// The type of actor that can bypass a ruleset. Can be one of: `RepositoryRole`, `Team`, `Integration`, `OrganizationAdmin`.
    /// </summary>
    [JsonPropertyName("actorType")]
    public string? ActorType { get; set; }

    /// <summary>
    /// (String) When the specified actor can bypass the ruleset. pull_request means that an actor can only bypass rules on pull requests. Can be one of: always, pull_request.
    /// When the specified actor can bypass the ruleset. pull_request means that an actor can only bypass rules on pull requests. Can be one of: `always`, `pull_request`.
    /// </summary>
    [JsonPropertyName("bypassMode")]
    public string? BypassMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderConditionsRefName
{
    /// <summary>
    /// (List of String) Array of ref names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// Array of ref names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// </summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>
    /// (List of String) Array of ref names or patterns to include. One of these patterns must match for the condition to pass. Also accepts ~DEFAULT_BRANCH to include the default branch or ~ALL to include all branches.
    /// Array of ref names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~DEFAULT_BRANCH` to include the default branch or `~ALL` to include all branches.
    /// </summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderConditions
{
    /// <summary>(Block List, Min: 1, Max: 1) (see below for nested schema)</summary>
    [JsonPropertyName("refName")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderConditionsRefName>? RefName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesBranchNamePattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesCommitAuthorEmailPattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesCommitMessagePattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesCommitterEmailPattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesMergeQueue
{
    /// <summary>
    /// (Number)Maximum time for a required status check to report a conclusion. After this much time has elapsed, checks that have not reported a conclusion will be assumed to have failed. Defaults to 60.
    /// Maximum time for a required status check to report a conclusion. After this much time has elapsed, checks that have not reported a conclusion will be assumed to have failed. Defaults to `60`.
    /// </summary>
    [JsonPropertyName("checkResponseTimeoutMinutes")]
    public long? CheckResponseTimeoutMinutes { get; set; }

    /// <summary>
    /// (String)When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge. Can be one of: ALLGREEN, HEADGREEN. Defaults to ALLGREEN.
    /// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge. Can be one of: ALLGREEN, HEADGREEN. Defaults to `ALLGREEN`.
    /// </summary>
    [JsonPropertyName("groupingStrategy")]
    public string? GroupingStrategy { get; set; }

    /// <summary>
    /// (Number) Limit the number of queued pull requests requesting checks and workflow runs at the same time. Defaults to 5.
    /// Limit the number of queued pull requests requesting checks and workflow runs at the same time. Defaults to `5`.
    /// </summary>
    [JsonPropertyName("maxEntriesToBuild")]
    public long? MaxEntriesToBuild { get; set; }

    /// <summary>
    /// (Number) Limit the number of queued pull requests requesting checks and workflow runs at the same time. Defaults to 5.
    /// The maximum number of PRs that will be merged together in a group. Defaults to `5`.
    /// </summary>
    [JsonPropertyName("maxEntriesToMerge")]
    public long? MaxEntriesToMerge { get; set; }

    /// <summary>
    /// (String) Method to use when merging changes from queued pull requests. Can be one of: MERGE, SQUASH, REBASE. Defaults to MERGE.
    /// Method to use when merging changes from queued pull requests. Can be one of: MERGE, SQUASH, REBASE. Defaults to `MERGE`.
    /// </summary>
    [JsonPropertyName("mergeMethod")]
    public string? MergeMethod { get; set; }

    /// <summary>
    /// (Number) The minimum number of PRs that will be merged together in a group. Defaults to 1.
    /// The minimum number of PRs that will be merged together in a group. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("minEntriesToMerge")]
    public long? MinEntriesToMerge { get; set; }

    /// <summary>
    /// (Number) The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged. Defaults to 5.
    /// The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged. Defaults to `5`.
    /// </summary>
    [JsonPropertyName("minEntriesToMergeWaitMinutes")]
    public long? MinEntriesToMergeWaitMinutes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesPullRequest
{
    /// <summary>
    /// (Boolean) New, reviewable commits pushed will dismiss previous pull request review approvals. Defaults to false.
    /// New, reviewable commits pushed will dismiss previous pull request review approvals. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("dismissStaleReviewsOnPush")]
    public bool? DismissStaleReviewsOnPush { get; set; }

    /// <summary>
    /// (Boolean) Require an approving review in pull requests that modify files that have a designated code owner. Defaults to false.
    /// Require an approving review in pull requests that modify files that have a designated code owner. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("requireCodeOwnerReview")]
    public bool? RequireCodeOwnerReview { get; set; }

    /// <summary>
    /// (Boolean) Whether the most recent reviewable push must be approved by someone other than the person who pushed it. Defaults to false.
    /// Whether the most recent reviewable push must be approved by someone other than the person who pushed it. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("requireLastPushApproval")]
    public bool? RequireLastPushApproval { get; set; }

    /// <summary>
    /// (Number) The number of approving reviews that are required before a pull request can be merged. Defaults to 0.
    /// The number of approving reviews that are required before a pull request can be merged. Defaults to `0`.
    /// </summary>
    [JsonPropertyName("requiredApprovingReviewCount")]
    public long? RequiredApprovingReviewCount { get; set; }

    /// <summary>
    /// (Boolean) All conversations on code must be resolved before a pull request can be merged. Defaults to false.
    /// All conversations on code must be resolved before a pull request can be merged. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("requiredReviewThreadResolution")]
    public bool? RequiredReviewThreadResolution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredCodeScanningRequiredCodeScanningTool
{
    /// <summary>
    /// (String) The severity level at which code scanning results that raise alerts block a reference update. Can be one of: none, errors, errors_and_warnings, all.
    /// The severity level at which code scanning results that raise alerts block a reference update. Can be one of: `none`, `errors`, `errors_and_warnings`, `all`.
    /// </summary>
    [JsonPropertyName("alertsThreshold")]
    public string? AlertsThreshold { get; set; }

    /// <summary>
    /// (String) The severity level at which code scanning results that raise security alerts block a reference update. Can be one of: none, critical, high_or_higher, medium_or_higher, all.
    /// The severity level at which code scanning results that raise security alerts block a reference update. Can be one of: `none`, `critical`, `high_or_higher`, `medium_or_higher`, `all`.
    /// </summary>
    [JsonPropertyName("securityAlertsThreshold")]
    public string? SecurityAlertsThreshold { get; set; }

    /// <summary>
    /// (String) The name of a code scanning tool.
    /// The name of a code scanning tool
    /// </summary>
    [JsonPropertyName("tool")]
    public string? Tool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredCodeScanning
{
    /// <summary>
    /// (Block Set, Min: 1) Actions code scanning tools that are required. Multiple can be defined. (see below for nested schema)
    /// Tools that must provide code scanning results for this rule to pass.
    /// </summary>
    [JsonPropertyName("requiredCodeScanningTool")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredCodeScanningRequiredCodeScanningTool>? RequiredCodeScanningTool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredDeployments
{
    /// <summary>
    /// (List of String) The environments that must be successfully deployed to before branches can be merged.
    /// The environments that must be successfully deployed to before branches can be merged.
    /// </summary>
    [JsonPropertyName("requiredDeploymentEnvironments")]
    public IList<string>? RequiredDeploymentEnvironments { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredStatusChecksRequiredCheck
{
    /// <summary>
    /// (String) The status check context name that must be present on the commit.
    /// The status check context name that must be present on the commit.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// (Number) The optional integration ID that this status check must originate from. It&apos;s a GitHub App ID, which can be obtained by following instructions from the Get an App API docs.
    /// The optional integration ID that this status check must originate from.
    /// </summary>
    [JsonPropertyName("integrationId")]
    public long? IntegrationId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredStatusChecks
{
    /// <summary>
    /// (Boolean) Allow repositories and branches to be created if a check would otherwise prohibit it. Defaults to false.
    /// Allow repositories and branches to be created if a check would otherwise prohibit it.
    /// </summary>
    [JsonPropertyName("doNotEnforceOnCreate")]
    public bool? DoNotEnforceOnCreate { get; set; }

    /// <summary>
    /// (Block Set, Min: 1) Status checks that are required. Several can be defined. (see below for nested schema)
    /// Status checks that are required. Several can be defined.
    /// </summary>
    [JsonPropertyName("requiredCheck")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredStatusChecksRequiredCheck>? RequiredCheck { get; set; }

    /// <summary>
    /// (Boolean) Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to false.
    /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("strictRequiredStatusChecksPolicy")]
    public bool? StrictRequiredStatusChecksPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRulesTagNamePattern
{
    /// <summary>
    /// (String) How this rule will appear to users.
    /// How this rule will appear to users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (Boolean) If true, the rule will fail if the pattern matches.
    /// If true, the rule will fail if the pattern matches.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>
    /// (String) The operator to use for matching. Can be one of: starts_with, ends_with, contains, regex.
    /// The operator to use for matching. Can be one of: `starts_with`, `ends_with`, `contains`, `regex`.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// (String) The pattern to match with.
    /// The pattern to match with.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProviderRules
{
    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with tag_name_pattern as it only applied to rulesets with target branch. (see below for nested schema)
    /// Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `tag_name_pattern` as it only applies to rulesets with target `branch`.
    /// </summary>
    [JsonPropertyName("branchNamePattern")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesBranchNamePattern>? BranchNamePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_author_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_author_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations.
    /// </summary>
    [JsonPropertyName("commitAuthorEmailPattern")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesCommitAuthorEmailPattern>? CommitAuthorEmailPattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_message_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_message_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations.
    /// </summary>
    [JsonPropertyName("commitMessagePattern")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesCommitMessagePattern>? CommitMessagePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the committer_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the committer_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations.
    /// </summary>
    [JsonPropertyName("committerEmailPattern")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesCommitterEmailPattern>? CommitterEmailPattern { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permission to create matching refs.
    /// Only allow users with bypass permission to create matching refs.
    /// </summary>
    [JsonPropertyName("creation")]
    public bool? Creation { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permissions to delete matching refs.
    /// Only allow users with bypass permissions to delete matching refs.
    /// </summary>
    [JsonPropertyName("deletion")]
    public bool? Deletion { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Merges must be performed via a merge queue.
    /// Merges must be performed via a merge queue.
    /// </summary>
    [JsonPropertyName("mergeQueue")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesMergeQueue>? MergeQueue { get; set; }

    /// <summary>
    /// (Boolean) Prevent users with push access from force pushing to branches.
    /// Prevent users with push access from force pushing to branches.
    /// </summary>
    [JsonPropertyName("nonFastForward")]
    public bool? NonFastForward { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Require all commits be made to a non-target branch and submitted via a pull request before they can be merged. (see below for nested schema)
    /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
    /// </summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesPullRequest>? PullRequest { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Define which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated. Multiple code scanning tools can be specified. (see below for nested schema)
    /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
    /// </summary>
    [JsonPropertyName("requiredCodeScanning")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredCodeScanning>? RequiredCodeScanning { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Choose which environments must be successfully deployed to before branches can be merged into a branch that matches this rule. (see below for nested schema)
    /// Choose which environments must be successfully deployed to before branches can be merged into a branch that matches this rule.
    /// </summary>
    [JsonPropertyName("requiredDeployments")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredDeployments>? RequiredDeployments { get; set; }

    /// <summary>
    /// (Boolean) Prevent merge commits from being pushed to matching branches.
    /// Prevent merge commits from being pushed to matching branches.
    /// </summary>
    [JsonPropertyName("requiredLinearHistory")]
    public bool? RequiredLinearHistory { get; set; }

    /// <summary>
    /// (Boolean) Commits pushed to matching branches must have verified signatures.
    /// Commits pushed to matching branches must have verified signatures.
    /// </summary>
    [JsonPropertyName("requiredSignatures")]
    public bool? RequiredSignatures { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Choose which status checks must pass before branches can be merged into a branch that matches this rule. When enabled, commits must first be pushed to another branch, then merged or pushed directly to a branch that matches this rule after status checks have passed. (see below for nested schema)
    /// Choose which status checks must pass before branches can be merged into a branch that matches this rule. When enabled, commits must first be pushed to another branch, then merged or pushed directly to a branch that matches this rule after status checks have passed.
    /// </summary>
    [JsonPropertyName("requiredStatusChecks")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with branch_name_pattern as it only applied to rulesets with target tag. (see below for nested schema)
    /// Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `branch_name_pattern` as it only applies to rulesets with target `tag`.
    /// </summary>
    [JsonPropertyName("tagNamePattern")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRulesTagNamePattern>? TagNamePattern { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permission to update matching refs.
    /// Only allow users with bypass permission to update matching refs.
    /// </summary>
    [JsonPropertyName("update")]
    public bool? Update { get; set; }

    /// <summary>
    /// (Boolean) Branch can pull changes from its upstream repository. This is only applicable to forked repositories. Requires update to be set to true. Note: behaviour is affected by a known bug on the GitHub side which may cause issues when using this parameter.
    /// Branch can pull changes from its upstream repository. This is only applicable to forked repositories. Requires `update` to be set to `true`.
    /// </summary>
    [JsonPropertyName("updateAllowsFetchAndMerge")]
    public bool? UpdateAllowsFetchAndMerge { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusAtProvider
{
    /// <summary>
    /// (Block List) The actors that can bypass the rules in this ruleset. (see below for nested schema)
    /// The actors that can bypass the rules in this ruleset.
    /// </summary>
    [JsonPropertyName("bypassActors")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderBypassActors>? BypassActors { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters for a repository ruleset ref name condition. (see below for nested schema)
    /// Parameters for a repository ruleset ref name condition.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderConditions>? Conditions { get; set; }

    /// <summary>
    /// (String) Possible values for Enforcement are disabled, active, evaluate. Note: evaluate is currently only supported for owners of type organization.
    /// Possible values for Enforcement are `disabled`, `active`, `evaluate`. Note: `evaluate` is currently only supported for owners of type `organization`.
    /// </summary>
    [JsonPropertyName("enforcement")]
    public string? Enforcement { get; set; }

    /// <summary>(String)</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// (String) The name of the ruleset.
    /// The name of the ruleset.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// (String) GraphQL global node id for use with v4 API.
    /// GraphQL global node id for use with v4 API.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public string? NodeId { get; set; }

    /// <summary>
    /// (String) Name of the repository to apply rulset to.
    /// Name of the repository to apply rulset to.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>
    /// (Block List, Min: 1, Max: 1) Rules within the ruleset. (see below for nested schema)
    /// Rules within the ruleset.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1RepositoryRulesetStatusAtProviderRules>? Rules { get; set; }

    /// <summary>
    /// (Number) GitHub ID for the ruleset.
    /// GitHub ID for the ruleset.
    /// </summary>
    [JsonPropertyName("rulesetId")]
    public long? RulesetId { get; set; }

    /// <summary>
    /// (String) Possible values are branch and tag.
    /// Possible values are `branch` and `tag`.
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatusConditions
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

/// <summary>RepositoryRulesetStatus defines the observed state of RepositoryRuleset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryRulesetStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1RepositoryRulesetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RepositoryRulesetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RepositoryRuleset is the Schema for the RepositoryRulesets API. Creates a GitHub repository ruleset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RepositoryRuleset : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RepositoryRulesetSpec>, IStatus<V1alpha1RepositoryRulesetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RepositoryRuleset";
    public const string KubeGroup = "repo.github.m.upbound.io";
    public const string KubePluralName = "repositoryrulesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "repo.github.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RepositoryRuleset";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RepositoryRulesetSpec defines the desired state of RepositoryRuleset</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1RepositoryRulesetSpec Spec { get; set; }

    /// <summary>RepositoryRulesetStatus defines the observed state of RepositoryRuleset.</summary>
    [JsonPropertyName("status")]
    public V1alpha1RepositoryRulesetStatus? Status { get; set; }
}