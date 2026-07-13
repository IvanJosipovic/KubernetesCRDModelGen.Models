#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.enterprise.github.upbound.io;
/// <summary>OrganizationRuleset is the Schema for the OrganizationRulesets API. Creates a GitHub organization ruleset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrganizationRulesetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1OrganizationRuleset>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrganizationRulesetList";
    public const string KubeGroup = "enterprise.github.upbound.io";
    public const string KubePluralName = "organizationrulesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "enterprise.github.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrganizationRulesetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1OrganizationRuleset objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1OrganizationRuleset> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1OrganizationRulesetSpecDeletionPolicyEnum>))]
public enum V1alpha1OrganizationRulesetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProviderBypassActors
{
    /// <summary>
    /// (Number) The ID of the actor that can bypass a ruleset.
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
public partial class V1alpha1OrganizationRulesetSpecForProviderConditionsRefName
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
public partial class V1alpha1OrganizationRulesetSpecForProviderConditionsRepositoryName
{
    /// <summary>
    /// (List of String) Array of repository names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// Array of repository names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// </summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>
    /// (List of String) Array of repository names or patterns to include. One of these patterns must match for the condition to pass. Also accepts ~ALL to include all repositories.
    /// Array of repository names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~ALL` to include all repositories.
    /// </summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }

    /// <summary>Whether renaming of target repositories is prevented.</summary>
    [JsonPropertyName("protected")]
    public bool? Protected { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProviderConditions
{
    /// <summary>(Block List, Min: 1, Max: 1) (see below for nested schema)</summary>
    [JsonPropertyName("refName")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderConditionsRefName>? RefName { get; set; }

    /// <summary>
    /// (List of Number) The repository IDs that the ruleset applies to. One of these IDs must match for the condition to pass. Conflicts with repository_name.
    /// The repository IDs that the ruleset applies to. One of these IDs must match for the condition to pass.
    /// </summary>
    [JsonPropertyName("repositoryId")]
    public IList<long>? RepositoryId { get; set; }

    /// <summary>(Block List, Max: 1) Conflicts with repository_id. (see below for nested schema)</summary>
    [JsonPropertyName("repositoryName")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderConditionsRepositoryName>? RepositoryName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesBranchNamePattern
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
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesCommitAuthorEmailPattern
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
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesCommitMessagePattern
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
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesCommitterEmailPattern
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
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesPullRequest
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
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesRequiredCodeScanningRequiredCodeScanningTool
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
    /// The name of a code scanning tool.
    /// </summary>
    [JsonPropertyName("tool")]
    public string? Tool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesRequiredCodeScanning
{
    /// <summary>
    /// (Block Set, Min: 1) Actions code scanning tools that are required. Multiple can be defined. (see below for nested schema)
    /// Tools that must provide code scanning results for this rule to pass.
    /// </summary>
    [JsonPropertyName("requiredCodeScanningTool")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesRequiredCodeScanningRequiredCodeScanningTool>? RequiredCodeScanningTool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesRequiredStatusChecksRequiredCheck
{
    /// <summary>
    /// (String) The status check context name that must be present on the commit.
    /// The status check context name that must be present on the commit.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// (Number) The optional integration ID that this status check must originate from.
    /// The optional integration ID that this status check must originate from.
    /// </summary>
    [JsonPropertyName("integrationId")]
    public long? IntegrationId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesRequiredStatusChecks
{
    /// <summary>
    /// (Block Set, Min: 1) Status checks that are required. Several can be defined. (see below for nested schema)
    /// Status checks that are required. Several can be defined.
    /// </summary>
    [JsonPropertyName("requiredCheck")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesRequiredStatusChecksRequiredCheck>? RequiredCheck { get; set; }

    /// <summary>
    /// (Boolean) Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to false.
    /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("strictRequiredStatusChecksPolicy")]
    public bool? StrictRequiredStatusChecksPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesRequiredWorkflowsRequiredWorkflow
{
    /// <summary>
    /// (String) The path to the YAML definition file of the workflow.
    /// The path to the workflow YAML definition file.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// (String) The optional ref from which to fetch the workflow. Defaults to master.
    /// The ref (branch or tag) of the workflow file to use.
    /// </summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>
    /// (Number) The ID of the repository. Names, full names and repository URLs are not supported.
    /// The repository in which the workflow is defined.
    /// </summary>
    [JsonPropertyName("repositoryId")]
    public long? RepositoryId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesRequiredWorkflows
{
    /// <summary>
    /// (Block Set, Min: 1) Actions workflows that are required. Multiple can be defined. (see below for nested schema)
    /// Actions workflows that are required. Several can be defined.
    /// </summary>
    [JsonPropertyName("requiredWorkflow")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesRequiredWorkflowsRequiredWorkflow>? RequiredWorkflow { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProviderRulesTagNamePattern
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
public partial class V1alpha1OrganizationRulesetSpecForProviderRules
{
    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with tag_name_pattern as it only applies to rulesets with target branch. (see below for nested schema)
    /// Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `tag_name_pattern` as it only applies to rulesets with target `branch`.
    /// </summary>
    [JsonPropertyName("branchNamePattern")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesBranchNamePattern>? BranchNamePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_author_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_author_email_pattern rule.
    /// </summary>
    [JsonPropertyName("commitAuthorEmailPattern")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesCommitAuthorEmailPattern>? CommitAuthorEmailPattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_message_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_message_pattern rule.
    /// </summary>
    [JsonPropertyName("commitMessagePattern")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesCommitMessagePattern>? CommitMessagePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the committer_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the committer_email_pattern rule.
    /// </summary>
    [JsonPropertyName("committerEmailPattern")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesCommitterEmailPattern>? CommitterEmailPattern { get; set; }

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
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesPullRequest>? PullRequest { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Define which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated. Multiple code scanning tools can be specified. (see below for nested schema)
    /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
    /// </summary>
    [JsonPropertyName("requiredCodeScanning")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesRequiredCodeScanning>? RequiredCodeScanning { get; set; }

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
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Define which Actions workflows must pass before changes can be merged into a branch matching the rule. Multiple workflows can be specified. (see below for nested schema)
    /// Choose which Actions workflows must pass before branches can be merged into a branch that matches this rule.
    /// </summary>
    [JsonPropertyName("requiredWorkflows")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesRequiredWorkflows>? RequiredWorkflows { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with branch_name_pattern as it only applies to rulesets with target tag. (see below for nested schema)
    /// Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `branch_name_pattern` as it only applies to rulesets with target `tag`.
    /// </summary>
    [JsonPropertyName("tagNamePattern")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRulesTagNamePattern>? TagNamePattern { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permission to update matching refs.
    /// Only allow users with bypass permission to update matching refs.
    /// </summary>
    [JsonPropertyName("update")]
    public bool? Update { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecForProvider
{
    /// <summary>
    /// (Block List) The actors that can bypass the rules in this ruleset. (see below for nested schema)
    /// The actors that can bypass the rules in this ruleset.
    /// </summary>
    [JsonPropertyName("bypassActors")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderBypassActors>? BypassActors { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters for an organization ruleset condition. ref_name is required alongside one of repository_name or repository_id. (see below for nested schema)
    /// Parameters for an organization ruleset condition. `ref_name` is required alongside one of `repository_name` or `repository_id`.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderConditions>? Conditions { get; set; }

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
    /// (Block List, Min: 1, Max: 1) Rules within the ruleset. (see below for nested schema)
    /// Rules within the ruleset.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1OrganizationRulesetSpecForProviderRules>? Rules { get; set; }

    /// <summary>
    /// (String) Possible values are branch and tag.
    /// Possible values are `branch`, `tag` and `push`. Note: The `push` target is in beta and is subject to change.
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecInitProviderBypassActors
{
    /// <summary>
    /// (Number) The ID of the actor that can bypass a ruleset.
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
public partial class V1alpha1OrganizationRulesetSpecInitProviderConditionsRefName
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
public partial class V1alpha1OrganizationRulesetSpecInitProviderConditionsRepositoryName
{
    /// <summary>
    /// (List of String) Array of repository names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// Array of repository names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// </summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>
    /// (List of String) Array of repository names or patterns to include. One of these patterns must match for the condition to pass. Also accepts ~ALL to include all repositories.
    /// Array of repository names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~ALL` to include all repositories.
    /// </summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }

    /// <summary>Whether renaming of target repositories is prevented.</summary>
    [JsonPropertyName("protected")]
    public bool? Protected { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecInitProviderConditions
{
    /// <summary>(Block List, Min: 1, Max: 1) (see below for nested schema)</summary>
    [JsonPropertyName("refName")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderConditionsRefName>? RefName { get; set; }

    /// <summary>
    /// (List of Number) The repository IDs that the ruleset applies to. One of these IDs must match for the condition to pass. Conflicts with repository_name.
    /// The repository IDs that the ruleset applies to. One of these IDs must match for the condition to pass.
    /// </summary>
    [JsonPropertyName("repositoryId")]
    public IList<long>? RepositoryId { get; set; }

    /// <summary>(Block List, Max: 1) Conflicts with repository_id. (see below for nested schema)</summary>
    [JsonPropertyName("repositoryName")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderConditionsRepositoryName>? RepositoryName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesBranchNamePattern
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
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesCommitAuthorEmailPattern
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
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesCommitMessagePattern
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
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesCommitterEmailPattern
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
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesPullRequest
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
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredCodeScanningRequiredCodeScanningTool
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
    /// The name of a code scanning tool.
    /// </summary>
    [JsonPropertyName("tool")]
    public string? Tool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredCodeScanning
{
    /// <summary>
    /// (Block Set, Min: 1) Actions code scanning tools that are required. Multiple can be defined. (see below for nested schema)
    /// Tools that must provide code scanning results for this rule to pass.
    /// </summary>
    [JsonPropertyName("requiredCodeScanningTool")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredCodeScanningRequiredCodeScanningTool>? RequiredCodeScanningTool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredStatusChecksRequiredCheck
{
    /// <summary>
    /// (String) The status check context name that must be present on the commit.
    /// The status check context name that must be present on the commit.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// (Number) The optional integration ID that this status check must originate from.
    /// The optional integration ID that this status check must originate from.
    /// </summary>
    [JsonPropertyName("integrationId")]
    public long? IntegrationId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredStatusChecks
{
    /// <summary>
    /// (Block Set, Min: 1) Status checks that are required. Several can be defined. (see below for nested schema)
    /// Status checks that are required. Several can be defined.
    /// </summary>
    [JsonPropertyName("requiredCheck")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredStatusChecksRequiredCheck>? RequiredCheck { get; set; }

    /// <summary>
    /// (Boolean) Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to false.
    /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("strictRequiredStatusChecksPolicy")]
    public bool? StrictRequiredStatusChecksPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredWorkflowsRequiredWorkflow
{
    /// <summary>
    /// (String) The path to the YAML definition file of the workflow.
    /// The path to the workflow YAML definition file.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// (String) The optional ref from which to fetch the workflow. Defaults to master.
    /// The ref (branch or tag) of the workflow file to use.
    /// </summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>
    /// (Number) The ID of the repository. Names, full names and repository URLs are not supported.
    /// The repository in which the workflow is defined.
    /// </summary>
    [JsonPropertyName("repositoryId")]
    public long? RepositoryId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredWorkflows
{
    /// <summary>
    /// (Block Set, Min: 1) Actions workflows that are required. Multiple can be defined. (see below for nested schema)
    /// Actions workflows that are required. Several can be defined.
    /// </summary>
    [JsonPropertyName("requiredWorkflow")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredWorkflowsRequiredWorkflow>? RequiredWorkflow { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecInitProviderRulesTagNamePattern
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
public partial class V1alpha1OrganizationRulesetSpecInitProviderRules
{
    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with tag_name_pattern as it only applies to rulesets with target branch. (see below for nested schema)
    /// Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `tag_name_pattern` as it only applies to rulesets with target `branch`.
    /// </summary>
    [JsonPropertyName("branchNamePattern")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesBranchNamePattern>? BranchNamePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_author_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_author_email_pattern rule.
    /// </summary>
    [JsonPropertyName("commitAuthorEmailPattern")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesCommitAuthorEmailPattern>? CommitAuthorEmailPattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_message_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_message_pattern rule.
    /// </summary>
    [JsonPropertyName("commitMessagePattern")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesCommitMessagePattern>? CommitMessagePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the committer_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the committer_email_pattern rule.
    /// </summary>
    [JsonPropertyName("committerEmailPattern")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesCommitterEmailPattern>? CommitterEmailPattern { get; set; }

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
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesPullRequest>? PullRequest { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Define which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated. Multiple code scanning tools can be specified. (see below for nested schema)
    /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
    /// </summary>
    [JsonPropertyName("requiredCodeScanning")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredCodeScanning>? RequiredCodeScanning { get; set; }

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
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Define which Actions workflows must pass before changes can be merged into a branch matching the rule. Multiple workflows can be specified. (see below for nested schema)
    /// Choose which Actions workflows must pass before branches can be merged into a branch that matches this rule.
    /// </summary>
    [JsonPropertyName("requiredWorkflows")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesRequiredWorkflows>? RequiredWorkflows { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with branch_name_pattern as it only applies to rulesets with target tag. (see below for nested schema)
    /// Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `branch_name_pattern` as it only applies to rulesets with target `tag`.
    /// </summary>
    [JsonPropertyName("tagNamePattern")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRulesTagNamePattern>? TagNamePattern { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permission to update matching refs.
    /// Only allow users with bypass permission to update matching refs.
    /// </summary>
    [JsonPropertyName("update")]
    public bool? Update { get; set; }
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
public partial class V1alpha1OrganizationRulesetSpecInitProvider
{
    /// <summary>
    /// (Block List) The actors that can bypass the rules in this ruleset. (see below for nested schema)
    /// The actors that can bypass the rules in this ruleset.
    /// </summary>
    [JsonPropertyName("bypassActors")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderBypassActors>? BypassActors { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters for an organization ruleset condition. ref_name is required alongside one of repository_name or repository_id. (see below for nested schema)
    /// Parameters for an organization ruleset condition. `ref_name` is required alongside one of `repository_name` or `repository_id`.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderConditions>? Conditions { get; set; }

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
    /// (Block List, Min: 1, Max: 1) Rules within the ruleset. (see below for nested schema)
    /// Rules within the ruleset.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1OrganizationRulesetSpecInitProviderRules>? Rules { get; set; }

    /// <summary>
    /// (String) Possible values are branch and tag.
    /// Possible values are `branch`, `tag` and `push`. Note: The `push` target is in beta and is subject to change.
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1OrganizationRulesetSpecManagementPoliciesEnum>))]
public enum V1alpha1OrganizationRulesetSpecManagementPoliciesEnum
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1OrganizationRulesetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1OrganizationRulesetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1OrganizationRulesetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1OrganizationRulesetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1OrganizationRulesetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1OrganizationRulesetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1OrganizationRulesetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>OrganizationRulesetSpec defines the desired state of OrganizationRuleset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1alpha1OrganizationRulesetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1OrganizationRulesetSpecForProvider ForProvider { get; set; }

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
    public V1alpha1OrganizationRulesetSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1OrganizationRulesetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1OrganizationRulesetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1OrganizationRulesetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProviderBypassActors
{
    /// <summary>
    /// (Number) The ID of the actor that can bypass a ruleset.
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
public partial class V1alpha1OrganizationRulesetStatusAtProviderConditionsRefName
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
public partial class V1alpha1OrganizationRulesetStatusAtProviderConditionsRepositoryName
{
    /// <summary>
    /// (List of String) Array of repository names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// Array of repository names or patterns to exclude. The condition will not pass if any of these patterns match.
    /// </summary>
    [JsonPropertyName("exclude")]
    public IList<string>? Exclude { get; set; }

    /// <summary>
    /// (List of String) Array of repository names or patterns to include. One of these patterns must match for the condition to pass. Also accepts ~ALL to include all repositories.
    /// Array of repository names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~ALL` to include all repositories.
    /// </summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }

    /// <summary>Whether renaming of target repositories is prevented.</summary>
    [JsonPropertyName("protected")]
    public bool? Protected { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProviderConditions
{
    /// <summary>(Block List, Min: 1, Max: 1) (see below for nested schema)</summary>
    [JsonPropertyName("refName")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderConditionsRefName>? RefName { get; set; }

    /// <summary>
    /// (List of Number) The repository IDs that the ruleset applies to. One of these IDs must match for the condition to pass. Conflicts with repository_name.
    /// The repository IDs that the ruleset applies to. One of these IDs must match for the condition to pass.
    /// </summary>
    [JsonPropertyName("repositoryId")]
    public IList<long>? RepositoryId { get; set; }

    /// <summary>(Block List, Max: 1) Conflicts with repository_id. (see below for nested schema)</summary>
    [JsonPropertyName("repositoryName")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderConditionsRepositoryName>? RepositoryName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesBranchNamePattern
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
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesCommitAuthorEmailPattern
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
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesCommitMessagePattern
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
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesCommitterEmailPattern
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
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesPullRequest
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
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredCodeScanningRequiredCodeScanningTool
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
    /// The name of a code scanning tool.
    /// </summary>
    [JsonPropertyName("tool")]
    public string? Tool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredCodeScanning
{
    /// <summary>
    /// (Block Set, Min: 1) Actions code scanning tools that are required. Multiple can be defined. (see below for nested schema)
    /// Tools that must provide code scanning results for this rule to pass.
    /// </summary>
    [JsonPropertyName("requiredCodeScanningTool")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredCodeScanningRequiredCodeScanningTool>? RequiredCodeScanningTool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredStatusChecksRequiredCheck
{
    /// <summary>
    /// (String) The status check context name that must be present on the commit.
    /// The status check context name that must be present on the commit.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// (Number) The optional integration ID that this status check must originate from.
    /// The optional integration ID that this status check must originate from.
    /// </summary>
    [JsonPropertyName("integrationId")]
    public long? IntegrationId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredStatusChecks
{
    /// <summary>
    /// (Block Set, Min: 1) Status checks that are required. Several can be defined. (see below for nested schema)
    /// Status checks that are required. Several can be defined.
    /// </summary>
    [JsonPropertyName("requiredCheck")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredStatusChecksRequiredCheck>? RequiredCheck { get; set; }

    /// <summary>
    /// (Boolean) Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to false.
    /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("strictRequiredStatusChecksPolicy")]
    public bool? StrictRequiredStatusChecksPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredWorkflowsRequiredWorkflow
{
    /// <summary>
    /// (String) The path to the YAML definition file of the workflow.
    /// The path to the workflow YAML definition file.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// (String) The optional ref from which to fetch the workflow. Defaults to master.
    /// The ref (branch or tag) of the workflow file to use.
    /// </summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>
    /// (Number) The ID of the repository. Names, full names and repository URLs are not supported.
    /// The repository in which the workflow is defined.
    /// </summary>
    [JsonPropertyName("repositoryId")]
    public long? RepositoryId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredWorkflows
{
    /// <summary>
    /// (Block Set, Min: 1) Actions workflows that are required. Multiple can be defined. (see below for nested schema)
    /// Actions workflows that are required. Several can be defined.
    /// </summary>
    [JsonPropertyName("requiredWorkflow")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredWorkflowsRequiredWorkflow>? RequiredWorkflow { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProviderRulesTagNamePattern
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
public partial class V1alpha1OrganizationRulesetStatusAtProviderRules
{
    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with tag_name_pattern as it only applies to rulesets with target branch. (see below for nested schema)
    /// Parameters to be used for the branch_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `tag_name_pattern` as it only applies to rulesets with target `branch`.
    /// </summary>
    [JsonPropertyName("branchNamePattern")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesBranchNamePattern>? BranchNamePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_author_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_author_email_pattern rule.
    /// </summary>
    [JsonPropertyName("commitAuthorEmailPattern")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesCommitAuthorEmailPattern>? CommitAuthorEmailPattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the commit_message_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the commit_message_pattern rule.
    /// </summary>
    [JsonPropertyName("commitMessagePattern")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesCommitMessagePattern>? CommitMessagePattern { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the committer_email_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. (see below for nested schema)
    /// Parameters to be used for the committer_email_pattern rule.
    /// </summary>
    [JsonPropertyName("committerEmailPattern")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesCommitterEmailPattern>? CommitterEmailPattern { get; set; }

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
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesPullRequest>? PullRequest { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Define which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated. Multiple code scanning tools can be specified. (see below for nested schema)
    /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
    /// </summary>
    [JsonPropertyName("requiredCodeScanning")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredCodeScanning>? RequiredCodeScanning { get; set; }

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
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredStatusChecks>? RequiredStatusChecks { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Define which Actions workflows must pass before changes can be merged into a branch matching the rule. Multiple workflows can be specified. (see below for nested schema)
    /// Choose which Actions workflows must pass before branches can be merged into a branch that matches this rule.
    /// </summary>
    [JsonPropertyName("requiredWorkflows")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesRequiredWorkflows>? RequiredWorkflows { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with branch_name_pattern as it only applies to rulesets with target tag. (see below for nested schema)
    /// Parameters to be used for the tag_name_pattern rule. This rule only applies to repositories within an enterprise, it cannot be applied to repositories owned by individuals or regular organizations. Conflicts with `branch_name_pattern` as it only applies to rulesets with target `tag`.
    /// </summary>
    [JsonPropertyName("tagNamePattern")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRulesTagNamePattern>? TagNamePattern { get; set; }

    /// <summary>
    /// (Boolean) Only allow users with bypass permission to update matching refs.
    /// Only allow users with bypass permission to update matching refs.
    /// </summary>
    [JsonPropertyName("update")]
    public bool? Update { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusAtProvider
{
    /// <summary>
    /// (Block List) The actors that can bypass the rules in this ruleset. (see below for nested schema)
    /// The actors that can bypass the rules in this ruleset.
    /// </summary>
    [JsonPropertyName("bypassActors")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderBypassActors>? BypassActors { get; set; }

    /// <summary>
    /// (Block List, Max: 1) Parameters for an organization ruleset condition. ref_name is required alongside one of repository_name or repository_id. (see below for nested schema)
    /// Parameters for an organization ruleset condition. `ref_name` is required alongside one of `repository_name` or `repository_id`.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderConditions>? Conditions { get; set; }

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
    /// (Block List, Min: 1, Max: 1) Rules within the ruleset. (see below for nested schema)
    /// Rules within the ruleset.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1OrganizationRulesetStatusAtProviderRules>? Rules { get; set; }

    /// <summary>
    /// (Number) GitHub ID for the ruleset.
    /// GitHub ID for the ruleset.
    /// </summary>
    [JsonPropertyName("rulesetId")]
    public long? RulesetId { get; set; }

    /// <summary>
    /// (String) Possible values are branch and tag.
    /// Possible values are `branch`, `tag` and `push`. Note: The `push` target is in beta and is subject to change.
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatusConditions
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

/// <summary>OrganizationRulesetStatus defines the observed state of OrganizationRuleset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationRulesetStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1OrganizationRulesetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OrganizationRulesetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OrganizationRuleset is the Schema for the OrganizationRulesets API. Creates a GitHub organization ruleset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrganizationRuleset : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OrganizationRulesetSpec>, IStatus<V1alpha1OrganizationRulesetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrganizationRuleset";
    public const string KubeGroup = "enterprise.github.upbound.io";
    public const string KubePluralName = "organizationrulesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "enterprise.github.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrganizationRuleset";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrganizationRulesetSpec defines the desired state of OrganizationRuleset</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1OrganizationRulesetSpec Spec { get; set; }

    /// <summary>OrganizationRulesetStatus defines the observed state of OrganizationRuleset.</summary>
    [JsonPropertyName("status")]
    public V1alpha1OrganizationRulesetStatus? Status { get; set; }
}