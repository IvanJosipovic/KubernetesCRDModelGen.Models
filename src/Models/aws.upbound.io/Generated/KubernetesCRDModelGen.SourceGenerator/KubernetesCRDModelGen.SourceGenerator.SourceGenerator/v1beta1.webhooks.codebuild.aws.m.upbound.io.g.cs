#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codebuild.aws.m.upbound.io;
/// <summary>Webhook is the Schema for the Webhooks API. Provides a CodeBuild Webhook resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebhookList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Webhook>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebhookList";
    public const string KubeGroup = "codebuild.aws.m.upbound.io";
    public const string KubePluralName = "webhooks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codebuild.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebhookList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Webhook objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Webhook> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderFilterGroupFilter
{
    /// <summary>If set to true, the specified filter does not trigger a build. Defaults to false.</summary>
    [JsonPropertyName("excludeMatchedPattern")]
    public bool? ExcludeMatchedPattern { get; set; }

    /// <summary>For a filter that uses EVENT type, a comma-separated string that specifies one event: PUSH, PULL_REQUEST_CREATED, PULL_REQUEST_UPDATED, PULL_REQUEST_REOPENED. PULL_REQUEST_MERGED, WORKFLOW_JOB_QUEUED works with GitHub &amp; GitHub Enterprise only. For a filter that uses any of the other filter types, a regular expression.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>The webhook filter group&apos;s type. Valid values for this parameter are: EVENT, BASE_REF, HEAD_REF, ACTOR_ACCOUNT_ID, FILE_PATH, COMMIT_MESSAGE, WORKFLOW_NAME, TAG_NAME, RELEASE_NAME, REPOSITORY_NAME. At least one filter group must specify EVENT as its type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderFilterGroup
{
    /// <summary>A webhook filter for the group. See filter for details.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1WebhookSpecForProviderFilterGroupFilter>? Filter { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecForProviderProjectNameRefPolicyResolutionEnum>))]
public enum V1beta1WebhookSpecForProviderProjectNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecForProviderProjectNameRefPolicyResolveEnum>))]
public enum V1beta1WebhookSpecForProviderProjectNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderProjectNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebhookSpecForProviderProjectNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebhookSpecForProviderProjectNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in codebuild to populate projectName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderProjectNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecForProviderProjectNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecForProviderProjectNameSelectorPolicyResolutionEnum>))]
public enum V1beta1WebhookSpecForProviderProjectNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecForProviderProjectNameSelectorPolicyResolveEnum>))]
public enum V1beta1WebhookSpecForProviderProjectNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderProjectNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebhookSpecForProviderProjectNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebhookSpecForProviderProjectNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in codebuild to populate projectName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderProjectNameSelector
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
    public V1beta1WebhookSpecForProviderProjectNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Defines comment-based approval requirements for triggering builds on pull requests. See pull_request_build_policy for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderPullRequestBuildPolicy
{
    /// <summary>List of repository roles that have approval privileges for pull request builds when comment approval is required. This argument must be specified only when requires_comment_approval is not DISABLED. See the AWS documentation for valid values and defaults.</summary>
    [JsonPropertyName("approverRoles")]
    public IList<string>? ApproverRoles { get; set; }

    /// <summary>Specifies when comment-based approval is required before triggering a build on pull requests. Valid values are: DISABLED, ALL_PULL_REQUESTS, and FORK_PULL_REQUESTS.</summary>
    [JsonPropertyName("requiresCommentApproval")]
    public string? RequiresCommentApproval { get; set; }
}

/// <summary>Scope configuration for global or organization webhooks. See scope_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderScopeConfiguration
{
    /// <summary>The domain of the GitHub Enterprise organization. Required if your project&apos;s source type is GITHUB_ENTERPRISE.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The name of either the enterprise or organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of scope for a GitHub webhook. Valid values for this parameter are: GITHUB_ORGANIZATION, GITHUB_GLOBAL.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProvider
{
    /// <summary>A regular expression used to determine which branches get built. Default is all branches are built. We recommend using filter_group over branch_filter.</summary>
    [JsonPropertyName("branchFilter")]
    public string? BranchFilter { get; set; }

    /// <summary>The type of build this webhook will trigger. Valid values for this parameter are: BUILD, BUILD_BATCH.</summary>
    [JsonPropertyName("buildType")]
    public string? BuildType { get; set; }

    /// <summary>Information about the webhook&apos;s trigger. See filter_group for details.</summary>
    [JsonPropertyName("filterGroup")]
    public IList<V1beta1WebhookSpecForProviderFilterGroup>? FilterGroup { get; set; }

    /// <summary>If true, CodeBuild doesn&apos;t create a webhook in GitHub and instead returns payload_url and secret values for the webhook. The payload_url and secret values in the output can be used to manually create a webhook within GitHub.</summary>
    [JsonPropertyName("manualCreation")]
    public bool? ManualCreation { get; set; }

    /// <summary>The name of the build project.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>Reference to a Project in codebuild to populate projectName.</summary>
    [JsonPropertyName("projectNameRef")]
    public V1beta1WebhookSpecForProviderProjectNameRef? ProjectNameRef { get; set; }

    /// <summary>Selector for a Project in codebuild to populate projectName.</summary>
    [JsonPropertyName("projectNameSelector")]
    public V1beta1WebhookSpecForProviderProjectNameSelector? ProjectNameSelector { get; set; }

    /// <summary>Defines comment-based approval requirements for triggering builds on pull requests. See pull_request_build_policy for details.</summary>
    [JsonPropertyName("pullRequestBuildPolicy")]
    public V1beta1WebhookSpecForProviderPullRequestBuildPolicy? PullRequestBuildPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Scope configuration for global or organization webhooks. See scope_configuration for details.</summary>
    [JsonPropertyName("scopeConfiguration")]
    public V1beta1WebhookSpecForProviderScopeConfiguration? ScopeConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderFilterGroupFilter
{
    /// <summary>If set to true, the specified filter does not trigger a build. Defaults to false.</summary>
    [JsonPropertyName("excludeMatchedPattern")]
    public bool? ExcludeMatchedPattern { get; set; }

    /// <summary>For a filter that uses EVENT type, a comma-separated string that specifies one event: PUSH, PULL_REQUEST_CREATED, PULL_REQUEST_UPDATED, PULL_REQUEST_REOPENED. PULL_REQUEST_MERGED, WORKFLOW_JOB_QUEUED works with GitHub &amp; GitHub Enterprise only. For a filter that uses any of the other filter types, a regular expression.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>The webhook filter group&apos;s type. Valid values for this parameter are: EVENT, BASE_REF, HEAD_REF, ACTOR_ACCOUNT_ID, FILE_PATH, COMMIT_MESSAGE, WORKFLOW_NAME, TAG_NAME, RELEASE_NAME, REPOSITORY_NAME. At least one filter group must specify EVENT as its type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderFilterGroup
{
    /// <summary>A webhook filter for the group. See filter for details.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1WebhookSpecInitProviderFilterGroupFilter>? Filter { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecInitProviderProjectNameRefPolicyResolutionEnum>))]
public enum V1beta1WebhookSpecInitProviderProjectNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecInitProviderProjectNameRefPolicyResolveEnum>))]
public enum V1beta1WebhookSpecInitProviderProjectNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderProjectNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebhookSpecInitProviderProjectNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebhookSpecInitProviderProjectNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in codebuild to populate projectName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderProjectNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecInitProviderProjectNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecInitProviderProjectNameSelectorPolicyResolutionEnum>))]
public enum V1beta1WebhookSpecInitProviderProjectNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecInitProviderProjectNameSelectorPolicyResolveEnum>))]
public enum V1beta1WebhookSpecInitProviderProjectNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderProjectNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebhookSpecInitProviderProjectNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebhookSpecInitProviderProjectNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in codebuild to populate projectName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderProjectNameSelector
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
    public V1beta1WebhookSpecInitProviderProjectNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Defines comment-based approval requirements for triggering builds on pull requests. See pull_request_build_policy for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderPullRequestBuildPolicy
{
    /// <summary>List of repository roles that have approval privileges for pull request builds when comment approval is required. This argument must be specified only when requires_comment_approval is not DISABLED. See the AWS documentation for valid values and defaults.</summary>
    [JsonPropertyName("approverRoles")]
    public IList<string>? ApproverRoles { get; set; }

    /// <summary>Specifies when comment-based approval is required before triggering a build on pull requests. Valid values are: DISABLED, ALL_PULL_REQUESTS, and FORK_PULL_REQUESTS.</summary>
    [JsonPropertyName("requiresCommentApproval")]
    public string? RequiresCommentApproval { get; set; }
}

/// <summary>Scope configuration for global or organization webhooks. See scope_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderScopeConfiguration
{
    /// <summary>The domain of the GitHub Enterprise organization. Required if your project&apos;s source type is GITHUB_ENTERPRISE.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The name of either the enterprise or organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of scope for a GitHub webhook. Valid values for this parameter are: GITHUB_ORGANIZATION, GITHUB_GLOBAL.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
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
public partial class V1beta1WebhookSpecInitProvider
{
    /// <summary>A regular expression used to determine which branches get built. Default is all branches are built. We recommend using filter_group over branch_filter.</summary>
    [JsonPropertyName("branchFilter")]
    public string? BranchFilter { get; set; }

    /// <summary>The type of build this webhook will trigger. Valid values for this parameter are: BUILD, BUILD_BATCH.</summary>
    [JsonPropertyName("buildType")]
    public string? BuildType { get; set; }

    /// <summary>Information about the webhook&apos;s trigger. See filter_group for details.</summary>
    [JsonPropertyName("filterGroup")]
    public IList<V1beta1WebhookSpecInitProviderFilterGroup>? FilterGroup { get; set; }

    /// <summary>If true, CodeBuild doesn&apos;t create a webhook in GitHub and instead returns payload_url and secret values for the webhook. The payload_url and secret values in the output can be used to manually create a webhook within GitHub.</summary>
    [JsonPropertyName("manualCreation")]
    public bool? ManualCreation { get; set; }

    /// <summary>The name of the build project.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>Reference to a Project in codebuild to populate projectName.</summary>
    [JsonPropertyName("projectNameRef")]
    public V1beta1WebhookSpecInitProviderProjectNameRef? ProjectNameRef { get; set; }

    /// <summary>Selector for a Project in codebuild to populate projectName.</summary>
    [JsonPropertyName("projectNameSelector")]
    public V1beta1WebhookSpecInitProviderProjectNameSelector? ProjectNameSelector { get; set; }

    /// <summary>Defines comment-based approval requirements for triggering builds on pull requests. See pull_request_build_policy for details.</summary>
    [JsonPropertyName("pullRequestBuildPolicy")]
    public V1beta1WebhookSpecInitProviderPullRequestBuildPolicy? PullRequestBuildPolicy { get; set; }

    /// <summary>Scope configuration for global or organization webhooks. See scope_configuration for details.</summary>
    [JsonPropertyName("scopeConfiguration")]
    public V1beta1WebhookSpecInitProviderScopeConfiguration? ScopeConfiguration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecManagementPoliciesEnum>))]
public enum V1beta1WebhookSpecManagementPoliciesEnum
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
public partial class V1beta1WebhookSpecProviderConfigRef
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
public partial class V1beta1WebhookSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WebhookSpec defines the desired state of Webhook</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1WebhookSpecForProvider ForProvider { get; set; }

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
    public V1beta1WebhookSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WebhookSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebhookSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebhookSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderFilterGroupFilter
{
    /// <summary>If set to true, the specified filter does not trigger a build. Defaults to false.</summary>
    [JsonPropertyName("excludeMatchedPattern")]
    public bool? ExcludeMatchedPattern { get; set; }

    /// <summary>For a filter that uses EVENT type, a comma-separated string that specifies one event: PUSH, PULL_REQUEST_CREATED, PULL_REQUEST_UPDATED, PULL_REQUEST_REOPENED. PULL_REQUEST_MERGED, WORKFLOW_JOB_QUEUED works with GitHub &amp; GitHub Enterprise only. For a filter that uses any of the other filter types, a regular expression.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>The webhook filter group&apos;s type. Valid values for this parameter are: EVENT, BASE_REF, HEAD_REF, ACTOR_ACCOUNT_ID, FILE_PATH, COMMIT_MESSAGE, WORKFLOW_NAME, TAG_NAME, RELEASE_NAME, REPOSITORY_NAME. At least one filter group must specify EVENT as its type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderFilterGroup
{
    /// <summary>A webhook filter for the group. See filter for details.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1WebhookStatusAtProviderFilterGroupFilter>? Filter { get; set; }
}

/// <summary>Defines comment-based approval requirements for triggering builds on pull requests. See pull_request_build_policy for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderPullRequestBuildPolicy
{
    /// <summary>List of repository roles that have approval privileges for pull request builds when comment approval is required. This argument must be specified only when requires_comment_approval is not DISABLED. See the AWS documentation for valid values and defaults.</summary>
    [JsonPropertyName("approverRoles")]
    public IList<string>? ApproverRoles { get; set; }

    /// <summary>Specifies when comment-based approval is required before triggering a build on pull requests. Valid values are: DISABLED, ALL_PULL_REQUESTS, and FORK_PULL_REQUESTS.</summary>
    [JsonPropertyName("requiresCommentApproval")]
    public string? RequiresCommentApproval { get; set; }
}

/// <summary>Scope configuration for global or organization webhooks. See scope_configuration for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderScopeConfiguration
{
    /// <summary>The domain of the GitHub Enterprise organization. Required if your project&apos;s source type is GITHUB_ENTERPRISE.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The name of either the enterprise or organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of scope for a GitHub webhook. Valid values for this parameter are: GITHUB_ORGANIZATION, GITHUB_GLOBAL.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProvider
{
    /// <summary>A regular expression used to determine which branches get built. Default is all branches are built. We recommend using filter_group over branch_filter.</summary>
    [JsonPropertyName("branchFilter")]
    public string? BranchFilter { get; set; }

    /// <summary>The type of build this webhook will trigger. Valid values for this parameter are: BUILD, BUILD_BATCH.</summary>
    [JsonPropertyName("buildType")]
    public string? BuildType { get; set; }

    /// <summary>Information about the webhook&apos;s trigger. See filter_group for details.</summary>
    [JsonPropertyName("filterGroup")]
    public IList<V1beta1WebhookStatusAtProviderFilterGroup>? FilterGroup { get; set; }

    /// <summary>The name of the build project.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>If true, CodeBuild doesn&apos;t create a webhook in GitHub and instead returns payload_url and secret values for the webhook. The payload_url and secret values in the output can be used to manually create a webhook within GitHub.</summary>
    [JsonPropertyName("manualCreation")]
    public bool? ManualCreation { get; set; }

    /// <summary>The CodeBuild endpoint where webhook events are sent.</summary>
    [JsonPropertyName("payloadUrl")]
    public string? PayloadUrl { get; set; }

    /// <summary>The name of the build project.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>Defines comment-based approval requirements for triggering builds on pull requests. See pull_request_build_policy for details.</summary>
    [JsonPropertyName("pullRequestBuildPolicy")]
    public V1beta1WebhookStatusAtProviderPullRequestBuildPolicy? PullRequestBuildPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Scope configuration for global or organization webhooks. See scope_configuration for details.</summary>
    [JsonPropertyName("scopeConfiguration")]
    public V1beta1WebhookStatusAtProviderScopeConfiguration? ScopeConfiguration { get; set; }

    /// <summary>The URL to the webhook.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusConditions
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

/// <summary>WebhookStatus defines the observed state of Webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1WebhookStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebhookStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Webhook is the Schema for the Webhooks API. Provides a CodeBuild Webhook resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Webhook : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebhookSpec>, IStatus<V1beta1WebhookStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Webhook";
    public const string KubeGroup = "codebuild.aws.m.upbound.io";
    public const string KubePluralName = "webhooks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "codebuild.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Webhook";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebhookSpec defines the desired state of Webhook</summary>
    [JsonPropertyName("spec")]
    public required V1beta1WebhookSpec Spec { get; set; }

    /// <summary>WebhookStatus defines the observed state of Webhook.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebhookStatus? Status { get; set; }
}