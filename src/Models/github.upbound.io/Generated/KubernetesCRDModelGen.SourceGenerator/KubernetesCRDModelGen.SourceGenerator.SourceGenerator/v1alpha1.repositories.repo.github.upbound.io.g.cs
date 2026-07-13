#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.repo.github.upbound.io;
/// <summary>Repository is the Schema for the Repositorys API. Creates and manages repositories within GitHub organizations or personal accounts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Repository>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RepositoryList";
    public const string KubeGroup = "repo.github.upbound.io";
    public const string KubePluralName = "repositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "repo.github.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RepositoryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Repository objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Repository> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositorySpecDeletionPolicyEnum>))]
public enum V1alpha1RepositorySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecForProviderPagesSource
{
    /// <summary>
    /// The repository branch used to publish the site&apos;s source files. (i.e. main or gh-pages.
    /// The repository branch used to publish the site&apos;s source files. (i.e. &apos;main&apos; or &apos;gh-pages&apos;)
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// The repository directory from which the site publishes (Default: /).
    /// The repository directory from which the site publishes (Default: &apos;/&apos;)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecForProviderPages
{
    /// <summary>
    /// The type of GitHub Pages site to build. Can be legacy or workflow. If you use legacy as build type you need to set the option source.
    /// The type the page should be sourced.
    /// </summary>
    [JsonPropertyName("buildType")]
    public string? BuildType { get; set; }

    /// <summary>
    /// The custom domain for the repository. This can only be set after the repository has been created.
    /// The custom domain for the repository. This can only be set after the repository has been created.
    /// </summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary>
    /// The source branch and directory for the rendered Pages site. See GitHub Pages Source below for details.
    /// The source branch and directory for the rendered Pages site.
    /// </summary>
    [JsonPropertyName("source")]
    public IList<V1alpha1RepositorySpecForProviderPagesSource>? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecForProviderSecurityAndAnalysisAdvancedSecurity
{
    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// Set to &apos;enabled&apos; to enable advanced security features on the repository. Can be &apos;enabled&apos; or &apos;disabled&apos;.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecForProviderSecurityAndAnalysisSecretScanning
{
    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// Set to &apos;enabled&apos; to enable secret scanning on the repository. Can be &apos;enabled&apos; or &apos;disabled&apos;. If set to &apos;enabled&apos;, the repository&apos;s visibility must be &apos;public&apos; or &apos;security_and_analysis[0].advanced_security[0].status&apos; must also be set to &apos;enabled&apos;.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecForProviderSecurityAndAnalysisSecretScanningPushProtection
{
    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// Set to &apos;enabled&apos; to enable secret scanning push protection on the repository. Can be &apos;enabled&apos; or &apos;disabled&apos;. If set to &apos;enabled&apos;, the repository&apos;s visibility must be &apos;public&apos; or &apos;security_and_analysis[0].advanced_security[0].status&apos; must also be set to &apos;enabled&apos;.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecForProviderSecurityAndAnalysis
{
    /// <summary>
    /// The advanced security configuration for the repository. See Advanced Security Configuration below for details. If a repository&apos;s visibility is public, advanced security is always enabled and cannot be changed, so this setting cannot be supplied.
    /// The advanced security configuration for the repository. If a repository&apos;s visibility is &apos;public&apos;, advanced security is always enabled and cannot be changed, so this setting cannot be supplied.
    /// </summary>
    [JsonPropertyName("advancedSecurity")]
    public IList<V1alpha1RepositorySpecForProviderSecurityAndAnalysisAdvancedSecurity>? AdvancedSecurity { get; set; }

    /// <summary>
    /// The secret scanning configuration for the repository. See Secret Scanning Configuration below for details.
    /// The secret scanning configuration for the repository.
    /// </summary>
    [JsonPropertyName("secretScanning")]
    public IList<V1alpha1RepositorySpecForProviderSecurityAndAnalysisSecretScanning>? SecretScanning { get; set; }

    /// <summary>
    /// The secret scanning push protection configuration for the repository. See Secret Scanning Push Protection Configuration below for details.
    /// The secret scanning push protection configuration for the repository.
    /// </summary>
    [JsonPropertyName("secretScanningPushProtection")]
    public IList<V1alpha1RepositorySpecForProviderSecurityAndAnalysisSecretScanningPushProtection>? SecretScanningPushProtection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecForProviderTemplate
{
    /// <summary>
    /// : Whether the new repository should include all the branches from the template repository (defaults to false, which includes only the default branch from the template).
    /// Whether the new repository should include all the branches from the template repository (defaults to &apos;false&apos;, which includes only the default branch from the template).
    /// </summary>
    [JsonPropertyName("includeAllBranches")]
    public bool? IncludeAllBranches { get; set; }

    /// <summary>
    /// : The GitHub organization or user the template repository is owned by.
    /// The GitHub organization or user the template repository is owned by.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// : The name of the template repository.
    /// The name of the template repository.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecForProvider
{
    /// <summary>
    /// Set to true to allow auto-merging pull requests on the repository.
    /// Set to &apos;true&apos; to allow auto-merging pull requests on the repository.
    /// </summary>
    [JsonPropertyName("allowAutoMerge")]
    public bool? AllowAutoMerge { get; set; }

    /// <summary>
    /// Set to false to disable merge commits on the repository.
    /// Set to &apos;false&apos; to disable merge commits on the repository.
    /// </summary>
    [JsonPropertyName("allowMergeCommit")]
    public bool? AllowMergeCommit { get; set; }

    /// <summary>
    /// Set to false to disable rebase merges on the repository.
    /// Set to &apos;false&apos; to disable rebase merges on the repository.
    /// </summary>
    [JsonPropertyName("allowRebaseMerge")]
    public bool? AllowRebaseMerge { get; set; }

    /// <summary>
    /// Set to false to disable squash merges on the repository.
    /// Set to &apos;false&apos; to disable squash merges on the repository.
    /// </summary>
    [JsonPropertyName("allowSquashMerge")]
    public bool? AllowSquashMerge { get; set; }

    /// <summary>
    /// Set to true to always suggest updating pull request branches.
    /// Set to &apos;true&apos; to always suggest updating pull request branches.
    /// </summary>
    [JsonPropertyName("allowUpdateBranch")]
    public bool? AllowUpdateBranch { get; set; }

    /// <summary>
    /// Set to true to archive the repository instead of deleting on destroy.
    /// Set to &apos;true&apos; to archive the repository instead of deleting on destroy.
    /// </summary>
    [JsonPropertyName("archiveOnDestroy")]
    public bool? ArchiveOnDestroy { get; set; }

    /// <summary>
    /// Specifies if the repository should be archived. Defaults to false. NOTE Currently, the API does not support unarchiving.
    /// Specifies if the repository should be archived. Defaults to &apos;false&apos;. NOTE Currently, the API does not support unarchiving.
    /// </summary>
    [JsonPropertyName("archived")]
    public bool? Archived { get; set; }

    /// <summary>
    /// Set to true to produce an initial commit in the repository.
    /// Set to &apos;true&apos; to produce an initial commit in the repository.
    /// </summary>
    [JsonPropertyName("autoInit")]
    public bool? AutoInit { get; set; }

    /// <summary>
    /// (Deprecated: Use github_branch_default resource instead) The name of the default branch of the repository. NOTE: This can only be set after a repository has already been created,
    /// and after a correct reference has been created for the target branch inside the repository. This means a user will have to omit this parameter from the
    /// initial repository creation and create the target branch inside of the repository prior to setting this attribute.
    /// Can only be set after initial repository creation, and only if the target branch exists
    /// </summary>
    [JsonPropertyName("defaultBranch")]
    public string? DefaultBranch { get; set; }

    /// <summary>
    /// Automatically delete head branch after a pull request is merged. Defaults to false.
    /// Automatically delete head branch after a pull request is merged. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("deleteBranchOnMerge")]
    public bool? DeleteBranchOnMerge { get; set; }

    /// <summary>
    /// A description of the repository.
    /// A description of the repository.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Use the name of the template without the extension. For example, &quot;Haskell&quot;.
    /// Use the name of the template without the extension. For example, &apos;Haskell&apos;.
    /// </summary>
    [JsonPropertyName("gitignoreTemplate")]
    public string? GitignoreTemplate { get; set; }

    /// <summary>
    /// Set to true to enable GitHub Discussions on the repository. Defaults to false.
    /// Set to &apos;true&apos; to enable GitHub Discussions on the repository. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("hasDiscussions")]
    public bool? HasDiscussions { get; set; }

    /// <summary>
    /// Set to true to enable the (deprecated) downloads features on the repository.
    /// Set to &apos;true&apos; to enable the (deprecated) downloads features on the repository.
    /// </summary>
    [JsonPropertyName("hasDownloads")]
    public bool? HasDownloads { get; set; }

    /// <summary>
    /// Set to true to enable the GitHub Issues features
    /// on the repository.
    /// Set to &apos;true&apos; to enable the GitHub Issues features on the repository
    /// </summary>
    [JsonPropertyName("hasIssues")]
    public bool? HasIssues { get; set; }

    /// <summary>
    /// Set to true to enable the GitHub Projects features on the repository. Per the GitHub documentation when in an organization that has disabled repository projects it will default to false and will otherwise default to true. If you specify true when it has been disabled it will return an error.
    /// Set to &apos;true&apos; to enable the GitHub Projects features on the repository. Per the GitHub documentation when in an organization that has disabled repository projects it will default to &apos;false&apos; and will otherwise default to &apos;true&apos;. If you specify &apos;true&apos; when it has been disabled it will return an error.
    /// </summary>
    [JsonPropertyName("hasProjects")]
    public bool? HasProjects { get; set; }

    /// <summary>
    /// Set to true to enable the GitHub Wiki features on
    /// the repository.
    /// Set to &apos;true&apos; to enable the GitHub Wiki features on the repository.
    /// </summary>
    [JsonPropertyName("hasWiki")]
    public bool? HasWiki { get; set; }

    /// <summary>
    /// URL of a page describing the project.
    /// URL of a page describing the project.
    /// </summary>
    [JsonPropertyName("homepageUrl")]
    public string? HomepageUrl { get; set; }

    /// <summary>
    /// Set to true to not call the vulnerability alerts endpoint so the resource can also be used without admin permissions during read.
    /// Set to true to not call the vulnerability alerts endpoint so the resource can also be used without admin permissions during read.
    /// </summary>
    [JsonPropertyName("ignoreVulnerabilityAlertsDuringRead")]
    public bool? IgnoreVulnerabilityAlertsDuringRead { get; set; }

    /// <summary>
    /// Set to true to tell GitHub that this is a template repository.
    /// Set to &apos;true&apos; to tell GitHub that this is a template repository.
    /// </summary>
    [JsonPropertyName("isTemplate")]
    public bool? IsTemplate { get; set; }

    /// <summary>
    /// Use the name of the template without the extension. For example, &quot;mit&quot; or &quot;mpl-2.0&quot;.
    /// Use the name of the template without the extension. For example, &apos;mit&apos; or &apos;mpl-2.0&apos;.
    /// </summary>
    [JsonPropertyName("licenseTemplate")]
    public string? LicenseTemplate { get; set; }

    /// <summary>
    /// Can be PR_BODY, PR_TITLE, or BLANK for a default merge commit message. Applicable only if allow_merge_commit is true.
    /// Can be &apos;PR_BODY&apos;, &apos;PR_TITLE&apos;, or &apos;BLANK&apos; for a default merge commit message.
    /// </summary>
    [JsonPropertyName("mergeCommitMessage")]
    public string? MergeCommitMessage { get; set; }

    /// <summary>
    /// Can be PR_TITLE or MERGE_MESSAGE for a default merge commit title. Applicable only if allow_merge_commit is true.
    /// Can be &apos;PR_TITLE&apos; or &apos;MERGE_MESSAGE&apos; for a default merge commit title.
    /// </summary>
    [JsonPropertyName("mergeCommitTitle")]
    public string? MergeCommitTitle { get; set; }

    /// <summary>
    /// The name of the repository.
    /// The name of the repository.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The repository&apos;s GitHub Pages configuration. See GitHub Pages Configuration below for details.
    /// The repository&apos;s GitHub Pages configuration
    /// </summary>
    [JsonPropertyName("pages")]
    public IList<V1alpha1RepositorySpecForProviderPages>? Pages { get; set; }

    /// <summary>
    /// Set to true to create a private repository.
    /// Repositories are created as public (e.g. open source) by default.
    /// </summary>
    [JsonPropertyName("private")]
    public bool? Private { get; set; }

    /// <summary>
    /// The repository&apos;s security and analysis configuration. See Security and Analysis Configuration below for details.
    /// Security and analysis settings for the repository. To use this parameter you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository.
    /// </summary>
    [JsonPropertyName("securityAndAnalysis")]
    public IList<V1alpha1RepositorySpecForProviderSecurityAndAnalysis>? SecurityAndAnalysis { get; set; }

    /// <summary>
    /// Can be PR_BODY, COMMIT_MESSAGES, or BLANK for a default squash merge commit message. Applicable only if allow_squash_merge is true.
    /// Can be &apos;PR_BODY&apos;, &apos;COMMIT_MESSAGES&apos;, or &apos;BLANK&apos; for a default squash merge commit message.
    /// </summary>
    [JsonPropertyName("squashMergeCommitMessage")]
    public string? SquashMergeCommitMessage { get; set; }

    /// <summary>
    /// Can be PR_TITLE or COMMIT_OR_PR_TITLE for a default squash merge commit title. Applicable only if allow_squash_merge is true.
    /// Can be &apos;PR_TITLE&apos; or &apos;COMMIT_OR_PR_TITLE&apos; for a default squash merge commit title.
    /// </summary>
    [JsonPropertyName("squashMergeCommitTitle")]
    public string? SquashMergeCommitTitle { get; set; }

    /// <summary>
    /// Use a template repository to create this resource. See Template Repositories below for details.
    /// Use a template repository to create this resource.
    /// </summary>
    [JsonPropertyName("template")]
    public IList<V1alpha1RepositorySpecForProviderTemplate>? Template { get; set; }

    /// <summary>
    /// The list of topics of the repository.
    /// The list of topics of the repository.
    /// </summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>
    /// Can be public or private. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, visibility can also be internal. The visibility parameter overrides the private parameter.
    /// Can be &apos;public&apos; or &apos;private&apos;. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, visibility can also be &apos;internal&apos;.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>
    /// Set to true to enable security alerts for vulnerable dependencies. Enabling requires alerts to be enabled on the owner level. (Note for importing: GitHub enables the alerts on public repos but disables them on private repos by default.) See GitHub Documentation for details. Note that vulnerability alerts have not been successfully tested on any GitHub Enterprise instance and may be unavailable in those settings.
    /// Set to &apos;true&apos; to enable security alerts for vulnerable dependencies. Enabling requires alerts to be enabled on the owner level. (Note for importing: GitHub enables the alerts on public repos but disables them on private repos by default). Note that vulnerability alerts have not been successfully tested on any GitHub Enterprise instance and may be unavailable in those settings.
    /// </summary>
    [JsonPropertyName("vulnerabilityAlerts")]
    public bool? VulnerabilityAlerts { get; set; }

    /// <summary>
    /// Require contributors to sign off on web-based commits. See more here. Defaults to false.
    /// Require contributors to sign off on web-based commits. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("webCommitSignoffRequired")]
    public bool? WebCommitSignoffRequired { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecInitProviderPagesSource
{
    /// <summary>
    /// The repository branch used to publish the site&apos;s source files. (i.e. main or gh-pages.
    /// The repository branch used to publish the site&apos;s source files. (i.e. &apos;main&apos; or &apos;gh-pages&apos;)
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// The repository directory from which the site publishes (Default: /).
    /// The repository directory from which the site publishes (Default: &apos;/&apos;)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecInitProviderPages
{
    /// <summary>
    /// The type of GitHub Pages site to build. Can be legacy or workflow. If you use legacy as build type you need to set the option source.
    /// The type the page should be sourced.
    /// </summary>
    [JsonPropertyName("buildType")]
    public string? BuildType { get; set; }

    /// <summary>
    /// The custom domain for the repository. This can only be set after the repository has been created.
    /// The custom domain for the repository. This can only be set after the repository has been created.
    /// </summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary>
    /// The source branch and directory for the rendered Pages site. See GitHub Pages Source below for details.
    /// The source branch and directory for the rendered Pages site.
    /// </summary>
    [JsonPropertyName("source")]
    public IList<V1alpha1RepositorySpecInitProviderPagesSource>? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecInitProviderSecurityAndAnalysisAdvancedSecurity
{
    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// Set to &apos;enabled&apos; to enable advanced security features on the repository. Can be &apos;enabled&apos; or &apos;disabled&apos;.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecInitProviderSecurityAndAnalysisSecretScanning
{
    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// Set to &apos;enabled&apos; to enable secret scanning on the repository. Can be &apos;enabled&apos; or &apos;disabled&apos;. If set to &apos;enabled&apos;, the repository&apos;s visibility must be &apos;public&apos; or &apos;security_and_analysis[0].advanced_security[0].status&apos; must also be set to &apos;enabled&apos;.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecInitProviderSecurityAndAnalysisSecretScanningPushProtection
{
    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// Set to &apos;enabled&apos; to enable secret scanning push protection on the repository. Can be &apos;enabled&apos; or &apos;disabled&apos;. If set to &apos;enabled&apos;, the repository&apos;s visibility must be &apos;public&apos; or &apos;security_and_analysis[0].advanced_security[0].status&apos; must also be set to &apos;enabled&apos;.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecInitProviderSecurityAndAnalysis
{
    /// <summary>
    /// The advanced security configuration for the repository. See Advanced Security Configuration below for details. If a repository&apos;s visibility is public, advanced security is always enabled and cannot be changed, so this setting cannot be supplied.
    /// The advanced security configuration for the repository. If a repository&apos;s visibility is &apos;public&apos;, advanced security is always enabled and cannot be changed, so this setting cannot be supplied.
    /// </summary>
    [JsonPropertyName("advancedSecurity")]
    public IList<V1alpha1RepositorySpecInitProviderSecurityAndAnalysisAdvancedSecurity>? AdvancedSecurity { get; set; }

    /// <summary>
    /// The secret scanning configuration for the repository. See Secret Scanning Configuration below for details.
    /// The secret scanning configuration for the repository.
    /// </summary>
    [JsonPropertyName("secretScanning")]
    public IList<V1alpha1RepositorySpecInitProviderSecurityAndAnalysisSecretScanning>? SecretScanning { get; set; }

    /// <summary>
    /// The secret scanning push protection configuration for the repository. See Secret Scanning Push Protection Configuration below for details.
    /// The secret scanning push protection configuration for the repository.
    /// </summary>
    [JsonPropertyName("secretScanningPushProtection")]
    public IList<V1alpha1RepositorySpecInitProviderSecurityAndAnalysisSecretScanningPushProtection>? SecretScanningPushProtection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecInitProviderTemplate
{
    /// <summary>
    /// : Whether the new repository should include all the branches from the template repository (defaults to false, which includes only the default branch from the template).
    /// Whether the new repository should include all the branches from the template repository (defaults to &apos;false&apos;, which includes only the default branch from the template).
    /// </summary>
    [JsonPropertyName("includeAllBranches")]
    public bool? IncludeAllBranches { get; set; }

    /// <summary>
    /// : The GitHub organization or user the template repository is owned by.
    /// The GitHub organization or user the template repository is owned by.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// : The name of the template repository.
    /// The name of the template repository.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
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
public partial class V1alpha1RepositorySpecInitProvider
{
    /// <summary>
    /// Set to true to allow auto-merging pull requests on the repository.
    /// Set to &apos;true&apos; to allow auto-merging pull requests on the repository.
    /// </summary>
    [JsonPropertyName("allowAutoMerge")]
    public bool? AllowAutoMerge { get; set; }

    /// <summary>
    /// Set to false to disable merge commits on the repository.
    /// Set to &apos;false&apos; to disable merge commits on the repository.
    /// </summary>
    [JsonPropertyName("allowMergeCommit")]
    public bool? AllowMergeCommit { get; set; }

    /// <summary>
    /// Set to false to disable rebase merges on the repository.
    /// Set to &apos;false&apos; to disable rebase merges on the repository.
    /// </summary>
    [JsonPropertyName("allowRebaseMerge")]
    public bool? AllowRebaseMerge { get; set; }

    /// <summary>
    /// Set to false to disable squash merges on the repository.
    /// Set to &apos;false&apos; to disable squash merges on the repository.
    /// </summary>
    [JsonPropertyName("allowSquashMerge")]
    public bool? AllowSquashMerge { get; set; }

    /// <summary>
    /// Set to true to always suggest updating pull request branches.
    /// Set to &apos;true&apos; to always suggest updating pull request branches.
    /// </summary>
    [JsonPropertyName("allowUpdateBranch")]
    public bool? AllowUpdateBranch { get; set; }

    /// <summary>
    /// Set to true to archive the repository instead of deleting on destroy.
    /// Set to &apos;true&apos; to archive the repository instead of deleting on destroy.
    /// </summary>
    [JsonPropertyName("archiveOnDestroy")]
    public bool? ArchiveOnDestroy { get; set; }

    /// <summary>
    /// Specifies if the repository should be archived. Defaults to false. NOTE Currently, the API does not support unarchiving.
    /// Specifies if the repository should be archived. Defaults to &apos;false&apos;. NOTE Currently, the API does not support unarchiving.
    /// </summary>
    [JsonPropertyName("archived")]
    public bool? Archived { get; set; }

    /// <summary>
    /// Set to true to produce an initial commit in the repository.
    /// Set to &apos;true&apos; to produce an initial commit in the repository.
    /// </summary>
    [JsonPropertyName("autoInit")]
    public bool? AutoInit { get; set; }

    /// <summary>
    /// (Deprecated: Use github_branch_default resource instead) The name of the default branch of the repository. NOTE: This can only be set after a repository has already been created,
    /// and after a correct reference has been created for the target branch inside the repository. This means a user will have to omit this parameter from the
    /// initial repository creation and create the target branch inside of the repository prior to setting this attribute.
    /// Can only be set after initial repository creation, and only if the target branch exists
    /// </summary>
    [JsonPropertyName("defaultBranch")]
    public string? DefaultBranch { get; set; }

    /// <summary>
    /// Automatically delete head branch after a pull request is merged. Defaults to false.
    /// Automatically delete head branch after a pull request is merged. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("deleteBranchOnMerge")]
    public bool? DeleteBranchOnMerge { get; set; }

    /// <summary>
    /// A description of the repository.
    /// A description of the repository.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Use the name of the template without the extension. For example, &quot;Haskell&quot;.
    /// Use the name of the template without the extension. For example, &apos;Haskell&apos;.
    /// </summary>
    [JsonPropertyName("gitignoreTemplate")]
    public string? GitignoreTemplate { get; set; }

    /// <summary>
    /// Set to true to enable GitHub Discussions on the repository. Defaults to false.
    /// Set to &apos;true&apos; to enable GitHub Discussions on the repository. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("hasDiscussions")]
    public bool? HasDiscussions { get; set; }

    /// <summary>
    /// Set to true to enable the (deprecated) downloads features on the repository.
    /// Set to &apos;true&apos; to enable the (deprecated) downloads features on the repository.
    /// </summary>
    [JsonPropertyName("hasDownloads")]
    public bool? HasDownloads { get; set; }

    /// <summary>
    /// Set to true to enable the GitHub Issues features
    /// on the repository.
    /// Set to &apos;true&apos; to enable the GitHub Issues features on the repository
    /// </summary>
    [JsonPropertyName("hasIssues")]
    public bool? HasIssues { get; set; }

    /// <summary>
    /// Set to true to enable the GitHub Projects features on the repository. Per the GitHub documentation when in an organization that has disabled repository projects it will default to false and will otherwise default to true. If you specify true when it has been disabled it will return an error.
    /// Set to &apos;true&apos; to enable the GitHub Projects features on the repository. Per the GitHub documentation when in an organization that has disabled repository projects it will default to &apos;false&apos; and will otherwise default to &apos;true&apos;. If you specify &apos;true&apos; when it has been disabled it will return an error.
    /// </summary>
    [JsonPropertyName("hasProjects")]
    public bool? HasProjects { get; set; }

    /// <summary>
    /// Set to true to enable the GitHub Wiki features on
    /// the repository.
    /// Set to &apos;true&apos; to enable the GitHub Wiki features on the repository.
    /// </summary>
    [JsonPropertyName("hasWiki")]
    public bool? HasWiki { get; set; }

    /// <summary>
    /// URL of a page describing the project.
    /// URL of a page describing the project.
    /// </summary>
    [JsonPropertyName("homepageUrl")]
    public string? HomepageUrl { get; set; }

    /// <summary>
    /// Set to true to not call the vulnerability alerts endpoint so the resource can also be used without admin permissions during read.
    /// Set to true to not call the vulnerability alerts endpoint so the resource can also be used without admin permissions during read.
    /// </summary>
    [JsonPropertyName("ignoreVulnerabilityAlertsDuringRead")]
    public bool? IgnoreVulnerabilityAlertsDuringRead { get; set; }

    /// <summary>
    /// Set to true to tell GitHub that this is a template repository.
    /// Set to &apos;true&apos; to tell GitHub that this is a template repository.
    /// </summary>
    [JsonPropertyName("isTemplate")]
    public bool? IsTemplate { get; set; }

    /// <summary>
    /// Use the name of the template without the extension. For example, &quot;mit&quot; or &quot;mpl-2.0&quot;.
    /// Use the name of the template without the extension. For example, &apos;mit&apos; or &apos;mpl-2.0&apos;.
    /// </summary>
    [JsonPropertyName("licenseTemplate")]
    public string? LicenseTemplate { get; set; }

    /// <summary>
    /// Can be PR_BODY, PR_TITLE, or BLANK for a default merge commit message. Applicable only if allow_merge_commit is true.
    /// Can be &apos;PR_BODY&apos;, &apos;PR_TITLE&apos;, or &apos;BLANK&apos; for a default merge commit message.
    /// </summary>
    [JsonPropertyName("mergeCommitMessage")]
    public string? MergeCommitMessage { get; set; }

    /// <summary>
    /// Can be PR_TITLE or MERGE_MESSAGE for a default merge commit title. Applicable only if allow_merge_commit is true.
    /// Can be &apos;PR_TITLE&apos; or &apos;MERGE_MESSAGE&apos; for a default merge commit title.
    /// </summary>
    [JsonPropertyName("mergeCommitTitle")]
    public string? MergeCommitTitle { get; set; }

    /// <summary>
    /// The name of the repository.
    /// The name of the repository.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The repository&apos;s GitHub Pages configuration. See GitHub Pages Configuration below for details.
    /// The repository&apos;s GitHub Pages configuration
    /// </summary>
    [JsonPropertyName("pages")]
    public IList<V1alpha1RepositorySpecInitProviderPages>? Pages { get; set; }

    /// <summary>
    /// Set to true to create a private repository.
    /// Repositories are created as public (e.g. open source) by default.
    /// </summary>
    [JsonPropertyName("private")]
    public bool? Private { get; set; }

    /// <summary>
    /// The repository&apos;s security and analysis configuration. See Security and Analysis Configuration below for details.
    /// Security and analysis settings for the repository. To use this parameter you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository.
    /// </summary>
    [JsonPropertyName("securityAndAnalysis")]
    public IList<V1alpha1RepositorySpecInitProviderSecurityAndAnalysis>? SecurityAndAnalysis { get; set; }

    /// <summary>
    /// Can be PR_BODY, COMMIT_MESSAGES, or BLANK for a default squash merge commit message. Applicable only if allow_squash_merge is true.
    /// Can be &apos;PR_BODY&apos;, &apos;COMMIT_MESSAGES&apos;, or &apos;BLANK&apos; for a default squash merge commit message.
    /// </summary>
    [JsonPropertyName("squashMergeCommitMessage")]
    public string? SquashMergeCommitMessage { get; set; }

    /// <summary>
    /// Can be PR_TITLE or COMMIT_OR_PR_TITLE for a default squash merge commit title. Applicable only if allow_squash_merge is true.
    /// Can be &apos;PR_TITLE&apos; or &apos;COMMIT_OR_PR_TITLE&apos; for a default squash merge commit title.
    /// </summary>
    [JsonPropertyName("squashMergeCommitTitle")]
    public string? SquashMergeCommitTitle { get; set; }

    /// <summary>
    /// Use a template repository to create this resource. See Template Repositories below for details.
    /// Use a template repository to create this resource.
    /// </summary>
    [JsonPropertyName("template")]
    public IList<V1alpha1RepositorySpecInitProviderTemplate>? Template { get; set; }

    /// <summary>
    /// The list of topics of the repository.
    /// The list of topics of the repository.
    /// </summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>
    /// Can be public or private. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, visibility can also be internal. The visibility parameter overrides the private parameter.
    /// Can be &apos;public&apos; or &apos;private&apos;. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, visibility can also be &apos;internal&apos;.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>
    /// Set to true to enable security alerts for vulnerable dependencies. Enabling requires alerts to be enabled on the owner level. (Note for importing: GitHub enables the alerts on public repos but disables them on private repos by default.) See GitHub Documentation for details. Note that vulnerability alerts have not been successfully tested on any GitHub Enterprise instance and may be unavailable in those settings.
    /// Set to &apos;true&apos; to enable security alerts for vulnerable dependencies. Enabling requires alerts to be enabled on the owner level. (Note for importing: GitHub enables the alerts on public repos but disables them on private repos by default). Note that vulnerability alerts have not been successfully tested on any GitHub Enterprise instance and may be unavailable in those settings.
    /// </summary>
    [JsonPropertyName("vulnerabilityAlerts")]
    public bool? VulnerabilityAlerts { get; set; }

    /// <summary>
    /// Require contributors to sign off on web-based commits. See more here. Defaults to false.
    /// Require contributors to sign off on web-based commits. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("webCommitSignoffRequired")]
    public bool? WebCommitSignoffRequired { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositorySpecManagementPoliciesEnum>))]
public enum V1alpha1RepositorySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositorySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1RepositorySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RepositorySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1RepositorySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1RepositorySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1RepositorySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1RepositorySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RepositorySpec defines the desired state of Repository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositorySpec
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
    public V1alpha1RepositorySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1RepositorySpecForProvider ForProvider { get; set; }

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
    public V1alpha1RepositorySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1RepositorySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1RepositorySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1RepositorySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusAtProviderPagesSource
{
    /// <summary>
    /// The repository branch used to publish the site&apos;s source files. (i.e. main or gh-pages.
    /// The repository branch used to publish the site&apos;s source files. (i.e. &apos;main&apos; or &apos;gh-pages&apos;)
    /// </summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// The repository directory from which the site publishes (Default: /).
    /// The repository directory from which the site publishes (Default: &apos;/&apos;)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusAtProviderPages
{
    /// <summary>
    /// The type of GitHub Pages site to build. Can be legacy or workflow. If you use legacy as build type you need to set the option source.
    /// The type the page should be sourced.
    /// </summary>
    [JsonPropertyName("buildType")]
    public string? BuildType { get; set; }

    /// <summary>
    /// The custom domain for the repository. This can only be set after the repository has been created.
    /// The custom domain for the repository. This can only be set after the repository has been created.
    /// </summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary>
    /// Whether the rendered GitHub Pages site has a custom 404 page.
    /// Whether the rendered GitHub Pages site has a custom 404 page
    /// </summary>
    [JsonPropertyName("custom404")]
    public bool? Custom404 { get; set; }

    /// <summary>
    /// URL to the repository on the web.
    /// URL to the repository on the web.
    /// </summary>
    [JsonPropertyName("htmlUrl")]
    public string? HtmlUrl { get; set; }

    /// <summary>
    /// The source branch and directory for the rendered Pages site. See GitHub Pages Source below for details.
    /// The source branch and directory for the rendered Pages site.
    /// </summary>
    [JsonPropertyName("source")]
    public IList<V1alpha1RepositoryStatusAtProviderPagesSource>? Source { get; set; }

    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// The GitHub Pages site&apos;s build status e.g. building or built.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusAtProviderSecurityAndAnalysisAdvancedSecurity
{
    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// Set to &apos;enabled&apos; to enable advanced security features on the repository. Can be &apos;enabled&apos; or &apos;disabled&apos;.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusAtProviderSecurityAndAnalysisSecretScanning
{
    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// Set to &apos;enabled&apos; to enable secret scanning on the repository. Can be &apos;enabled&apos; or &apos;disabled&apos;. If set to &apos;enabled&apos;, the repository&apos;s visibility must be &apos;public&apos; or &apos;security_and_analysis[0].advanced_security[0].status&apos; must also be set to &apos;enabled&apos;.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusAtProviderSecurityAndAnalysisSecretScanningPushProtection
{
    /// <summary>
    /// Set to enabled to enable secret scanning on the repository. Can be enabled or disabled. If set to enabled, the repository&apos;s visibility must be public or security_and_analysis[0].advanced_security[0].status must also be set to enabled.
    /// Set to &apos;enabled&apos; to enable secret scanning push protection on the repository. Can be &apos;enabled&apos; or &apos;disabled&apos;. If set to &apos;enabled&apos;, the repository&apos;s visibility must be &apos;public&apos; or &apos;security_and_analysis[0].advanced_security[0].status&apos; must also be set to &apos;enabled&apos;.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusAtProviderSecurityAndAnalysis
{
    /// <summary>
    /// The advanced security configuration for the repository. See Advanced Security Configuration below for details. If a repository&apos;s visibility is public, advanced security is always enabled and cannot be changed, so this setting cannot be supplied.
    /// The advanced security configuration for the repository. If a repository&apos;s visibility is &apos;public&apos;, advanced security is always enabled and cannot be changed, so this setting cannot be supplied.
    /// </summary>
    [JsonPropertyName("advancedSecurity")]
    public IList<V1alpha1RepositoryStatusAtProviderSecurityAndAnalysisAdvancedSecurity>? AdvancedSecurity { get; set; }

    /// <summary>
    /// The secret scanning configuration for the repository. See Secret Scanning Configuration below for details.
    /// The secret scanning configuration for the repository.
    /// </summary>
    [JsonPropertyName("secretScanning")]
    public IList<V1alpha1RepositoryStatusAtProviderSecurityAndAnalysisSecretScanning>? SecretScanning { get; set; }

    /// <summary>
    /// The secret scanning push protection configuration for the repository. See Secret Scanning Push Protection Configuration below for details.
    /// The secret scanning push protection configuration for the repository.
    /// </summary>
    [JsonPropertyName("secretScanningPushProtection")]
    public IList<V1alpha1RepositoryStatusAtProviderSecurityAndAnalysisSecretScanningPushProtection>? SecretScanningPushProtection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusAtProviderTemplate
{
    /// <summary>
    /// : Whether the new repository should include all the branches from the template repository (defaults to false, which includes only the default branch from the template).
    /// Whether the new repository should include all the branches from the template repository (defaults to &apos;false&apos;, which includes only the default branch from the template).
    /// </summary>
    [JsonPropertyName("includeAllBranches")]
    public bool? IncludeAllBranches { get; set; }

    /// <summary>
    /// : The GitHub organization or user the template repository is owned by.
    /// The GitHub organization or user the template repository is owned by.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// : The name of the template repository.
    /// The name of the template repository.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusAtProvider
{
    /// <summary>
    /// Set to true to allow auto-merging pull requests on the repository.
    /// Set to &apos;true&apos; to allow auto-merging pull requests on the repository.
    /// </summary>
    [JsonPropertyName("allowAutoMerge")]
    public bool? AllowAutoMerge { get; set; }

    /// <summary>
    /// Set to false to disable merge commits on the repository.
    /// Set to &apos;false&apos; to disable merge commits on the repository.
    /// </summary>
    [JsonPropertyName("allowMergeCommit")]
    public bool? AllowMergeCommit { get; set; }

    /// <summary>
    /// Set to false to disable rebase merges on the repository.
    /// Set to &apos;false&apos; to disable rebase merges on the repository.
    /// </summary>
    [JsonPropertyName("allowRebaseMerge")]
    public bool? AllowRebaseMerge { get; set; }

    /// <summary>
    /// Set to false to disable squash merges on the repository.
    /// Set to &apos;false&apos; to disable squash merges on the repository.
    /// </summary>
    [JsonPropertyName("allowSquashMerge")]
    public bool? AllowSquashMerge { get; set; }

    /// <summary>
    /// Set to true to always suggest updating pull request branches.
    /// Set to &apos;true&apos; to always suggest updating pull request branches.
    /// </summary>
    [JsonPropertyName("allowUpdateBranch")]
    public bool? AllowUpdateBranch { get; set; }

    /// <summary>
    /// Set to true to archive the repository instead of deleting on destroy.
    /// Set to &apos;true&apos; to archive the repository instead of deleting on destroy.
    /// </summary>
    [JsonPropertyName("archiveOnDestroy")]
    public bool? ArchiveOnDestroy { get; set; }

    /// <summary>
    /// Specifies if the repository should be archived. Defaults to false. NOTE Currently, the API does not support unarchiving.
    /// Specifies if the repository should be archived. Defaults to &apos;false&apos;. NOTE Currently, the API does not support unarchiving.
    /// </summary>
    [JsonPropertyName("archived")]
    public bool? Archived { get; set; }

    /// <summary>
    /// Set to true to produce an initial commit in the repository.
    /// Set to &apos;true&apos; to produce an initial commit in the repository.
    /// </summary>
    [JsonPropertyName("autoInit")]
    public bool? AutoInit { get; set; }

    /// <summary>
    /// (Deprecated: Use github_branch_default resource instead) The name of the default branch of the repository. NOTE: This can only be set after a repository has already been created,
    /// and after a correct reference has been created for the target branch inside the repository. This means a user will have to omit this parameter from the
    /// initial repository creation and create the target branch inside of the repository prior to setting this attribute.
    /// Can only be set after initial repository creation, and only if the target branch exists
    /// </summary>
    [JsonPropertyName("defaultBranch")]
    public string? DefaultBranch { get; set; }

    /// <summary>
    /// Automatically delete head branch after a pull request is merged. Defaults to false.
    /// Automatically delete head branch after a pull request is merged. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("deleteBranchOnMerge")]
    public bool? DeleteBranchOnMerge { get; set; }

    /// <summary>
    /// A description of the repository.
    /// A description of the repository.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// A string of the form &quot;orgname/reponame&quot;.
    /// A string of the form &apos;orgname/reponame&apos;.
    /// </summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>
    /// URL that can be provided to git clone to clone the repository anonymously via the git protocol.
    /// URL that can be provided to &apos;git clone&apos; to clone the repository anonymously via the git protocol.
    /// </summary>
    [JsonPropertyName("gitCloneUrl")]
    public string? GitCloneUrl { get; set; }

    /// <summary>
    /// Use the name of the template without the extension. For example, &quot;Haskell&quot;.
    /// Use the name of the template without the extension. For example, &apos;Haskell&apos;.
    /// </summary>
    [JsonPropertyName("gitignoreTemplate")]
    public string? GitignoreTemplate { get; set; }

    /// <summary>
    /// Set to true to enable GitHub Discussions on the repository. Defaults to false.
    /// Set to &apos;true&apos; to enable GitHub Discussions on the repository. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("hasDiscussions")]
    public bool? HasDiscussions { get; set; }

    /// <summary>
    /// Set to true to enable the (deprecated) downloads features on the repository.
    /// Set to &apos;true&apos; to enable the (deprecated) downloads features on the repository.
    /// </summary>
    [JsonPropertyName("hasDownloads")]
    public bool? HasDownloads { get; set; }

    /// <summary>
    /// Set to true to enable the GitHub Issues features
    /// on the repository.
    /// Set to &apos;true&apos; to enable the GitHub Issues features on the repository
    /// </summary>
    [JsonPropertyName("hasIssues")]
    public bool? HasIssues { get; set; }

    /// <summary>
    /// Set to true to enable the GitHub Projects features on the repository. Per the GitHub documentation when in an organization that has disabled repository projects it will default to false and will otherwise default to true. If you specify true when it has been disabled it will return an error.
    /// Set to &apos;true&apos; to enable the GitHub Projects features on the repository. Per the GitHub documentation when in an organization that has disabled repository projects it will default to &apos;false&apos; and will otherwise default to &apos;true&apos;. If you specify &apos;true&apos; when it has been disabled it will return an error.
    /// </summary>
    [JsonPropertyName("hasProjects")]
    public bool? HasProjects { get; set; }

    /// <summary>
    /// Set to true to enable the GitHub Wiki features on
    /// the repository.
    /// Set to &apos;true&apos; to enable the GitHub Wiki features on the repository.
    /// </summary>
    [JsonPropertyName("hasWiki")]
    public bool? HasWiki { get; set; }

    /// <summary>
    /// URL of a page describing the project.
    /// URL of a page describing the project.
    /// </summary>
    [JsonPropertyName("homepageUrl")]
    public string? HomepageUrl { get; set; }

    /// <summary>
    /// URL to the repository on the web.
    /// URL to the repository on the web.
    /// </summary>
    [JsonPropertyName("htmlUrl")]
    public string? HtmlUrl { get; set; }

    /// <summary>
    /// URL that can be provided to git clone to clone the repository via HTTPS.
    /// URL that can be provided to &apos;git clone&apos; to clone the repository via HTTPS.
    /// </summary>
    [JsonPropertyName("httpCloneUrl")]
    public string? HttpCloneUrl { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Set to true to not call the vulnerability alerts endpoint so the resource can also be used without admin permissions during read.
    /// Set to true to not call the vulnerability alerts endpoint so the resource can also be used without admin permissions during read.
    /// </summary>
    [JsonPropertyName("ignoreVulnerabilityAlertsDuringRead")]
    public bool? IgnoreVulnerabilityAlertsDuringRead { get; set; }

    /// <summary>
    /// Set to true to tell GitHub that this is a template repository.
    /// Set to &apos;true&apos; to tell GitHub that this is a template repository.
    /// </summary>
    [JsonPropertyName("isTemplate")]
    public bool? IsTemplate { get; set; }

    /// <summary>
    /// Use the name of the template without the extension. For example, &quot;mit&quot; or &quot;mpl-2.0&quot;.
    /// Use the name of the template without the extension. For example, &apos;mit&apos; or &apos;mpl-2.0&apos;.
    /// </summary>
    [JsonPropertyName("licenseTemplate")]
    public string? LicenseTemplate { get; set; }

    /// <summary>
    /// Can be PR_BODY, PR_TITLE, or BLANK for a default merge commit message. Applicable only if allow_merge_commit is true.
    /// Can be &apos;PR_BODY&apos;, &apos;PR_TITLE&apos;, or &apos;BLANK&apos; for a default merge commit message.
    /// </summary>
    [JsonPropertyName("mergeCommitMessage")]
    public string? MergeCommitMessage { get; set; }

    /// <summary>
    /// Can be PR_TITLE or MERGE_MESSAGE for a default merge commit title. Applicable only if allow_merge_commit is true.
    /// Can be &apos;PR_TITLE&apos; or &apos;MERGE_MESSAGE&apos; for a default merge commit title.
    /// </summary>
    [JsonPropertyName("mergeCommitTitle")]
    public string? MergeCommitTitle { get; set; }

    /// <summary>
    /// The name of the repository.
    /// The name of the repository.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// GraphQL global node id for use with v4 API
    /// GraphQL global node id for use with v4 API.
    /// </summary>
    [JsonPropertyName("nodeId")]
    public string? NodeId { get; set; }

    /// <summary>
    /// The repository&apos;s GitHub Pages configuration. See GitHub Pages Configuration below for details.
    /// The repository&apos;s GitHub Pages configuration
    /// </summary>
    [JsonPropertyName("pages")]
    public IList<V1alpha1RepositoryStatusAtProviderPages>? Pages { get; set; }

    /// <summary>The primary language used in the repository.</summary>
    [JsonPropertyName("primaryLanguage")]
    public string? PrimaryLanguage { get; set; }

    /// <summary>
    /// Set to true to create a private repository.
    /// Repositories are created as public (e.g. open source) by default.
    /// </summary>
    [JsonPropertyName("private")]
    public bool? Private { get; set; }

    /// <summary>
    /// GitHub ID for the repository
    /// GitHub ID for the repository.
    /// </summary>
    [JsonPropertyName("repoId")]
    public long? RepoId { get; set; }

    /// <summary>
    /// The repository&apos;s security and analysis configuration. See Security and Analysis Configuration below for details.
    /// Security and analysis settings for the repository. To use this parameter you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository.
    /// </summary>
    [JsonPropertyName("securityAndAnalysis")]
    public IList<V1alpha1RepositoryStatusAtProviderSecurityAndAnalysis>? SecurityAndAnalysis { get; set; }

    /// <summary>
    /// Can be PR_BODY, COMMIT_MESSAGES, or BLANK for a default squash merge commit message. Applicable only if allow_squash_merge is true.
    /// Can be &apos;PR_BODY&apos;, &apos;COMMIT_MESSAGES&apos;, or &apos;BLANK&apos; for a default squash merge commit message.
    /// </summary>
    [JsonPropertyName("squashMergeCommitMessage")]
    public string? SquashMergeCommitMessage { get; set; }

    /// <summary>
    /// Can be PR_TITLE or COMMIT_OR_PR_TITLE for a default squash merge commit title. Applicable only if allow_squash_merge is true.
    /// Can be &apos;PR_TITLE&apos; or &apos;COMMIT_OR_PR_TITLE&apos; for a default squash merge commit title.
    /// </summary>
    [JsonPropertyName("squashMergeCommitTitle")]
    public string? SquashMergeCommitTitle { get; set; }

    /// <summary>
    /// URL that can be provided to git clone to clone the repository via SSH.
    /// URL that can be provided to &apos;git clone&apos; to clone the repository via SSH.
    /// </summary>
    [JsonPropertyName("sshCloneUrl")]
    public string? SshCloneUrl { get; set; }

    /// <summary>
    /// URL that can be provided to svn checkout to check out the repository via GitHub&apos;s Subversion protocol emulation.
    /// URL that can be provided to &apos;svn checkout&apos; to check out the repository via GitHub&apos;s Subversion protocol emulation.
    /// </summary>
    [JsonPropertyName("svnUrl")]
    public string? SvnUrl { get; set; }

    /// <summary>
    /// Use a template repository to create this resource. See Template Repositories below for details.
    /// Use a template repository to create this resource.
    /// </summary>
    [JsonPropertyName("template")]
    public IList<V1alpha1RepositoryStatusAtProviderTemplate>? Template { get; set; }

    /// <summary>
    /// The list of topics of the repository.
    /// The list of topics of the repository.
    /// </summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>
    /// Can be public or private. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, visibility can also be internal. The visibility parameter overrides the private parameter.
    /// Can be &apos;public&apos; or &apos;private&apos;. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, visibility can also be &apos;internal&apos;.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>
    /// Set to true to enable security alerts for vulnerable dependencies. Enabling requires alerts to be enabled on the owner level. (Note for importing: GitHub enables the alerts on public repos but disables them on private repos by default.) See GitHub Documentation for details. Note that vulnerability alerts have not been successfully tested on any GitHub Enterprise instance and may be unavailable in those settings.
    /// Set to &apos;true&apos; to enable security alerts for vulnerable dependencies. Enabling requires alerts to be enabled on the owner level. (Note for importing: GitHub enables the alerts on public repos but disables them on private repos by default). Note that vulnerability alerts have not been successfully tested on any GitHub Enterprise instance and may be unavailable in those settings.
    /// </summary>
    [JsonPropertyName("vulnerabilityAlerts")]
    public bool? VulnerabilityAlerts { get; set; }

    /// <summary>
    /// Require contributors to sign off on web-based commits. See more here. Defaults to false.
    /// Require contributors to sign off on web-based commits. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("webCommitSignoffRequired")]
    public bool? WebCommitSignoffRequired { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatusConditions
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

/// <summary>RepositoryStatus defines the observed state of Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RepositoryStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1RepositoryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Repository is the Schema for the Repositorys API. Creates and manages repositories within GitHub organizations or personal accounts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Repository : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RepositorySpec>, IStatus<V1alpha1RepositoryStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Repository";
    public const string KubeGroup = "repo.github.upbound.io";
    public const string KubePluralName = "repositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "repo.github.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Repository";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RepositorySpec defines the desired state of Repository</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1RepositorySpec Spec { get; set; }

    /// <summary>RepositoryStatus defines the observed state of Repository.</summary>
    [JsonPropertyName("status")]
    public V1alpha1RepositoryStatus? Status { get; set; }
}