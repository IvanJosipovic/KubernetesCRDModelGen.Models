#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.actions.github.upbound.io;
/// <summary>OrganizationPermissions is the Schema for the OrganizationPermissionss API. Creates and manages Actions permissions within a GitHub organization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrganizationPermissionsList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1OrganizationPermissions>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrganizationPermissionsList";
    public const string KubeGroup = "actions.github.upbound.io";
    public const string KubePluralName = "organizationpermissions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "actions.github.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrganizationPermissionsList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1OrganizationPermissions objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1OrganizationPermissions> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1OrganizationPermissionsSpecDeletionPolicyEnum>))]
public enum V1alpha1OrganizationPermissionsSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsSpecForProviderAllowedActionsConfig
{
    /// <summary>
    /// Whether GitHub-owned actions are allowed in the organization.
    /// Whether GitHub-owned actions are allowed in the organization.
    /// </summary>
    [JsonPropertyName("githubOwnedAllowed")]
    public bool? GithubOwnedAllowed { get; set; }

    /// <summary>
    /// Specifies a list of string-matching patterns to allow specific action(s). Wildcards, tags, and SHAs are allowed. For example, monalisa/octocat@, monalisa/octocat@v2, monalisa/.&quot;
    /// Specifies a list of string-matching patterns to allow specific action(s). Wildcards, tags, and SHAs are allowed. For example, &apos;monalisa/octocat@&apos;, &apos;monalisa/octocat@v2&apos;, &apos;monalisa/&apos;.
    /// </summary>
    [JsonPropertyName("patternsAllowed")]
    public IList<string>? PatternsAllowed { get; set; }

    /// <summary>
    /// Whether actions in GitHub Marketplace from verified creators are allowed. Set to true to allow all GitHub Marketplace actions by verified creators.
    /// Whether actions in GitHub Marketplace from verified creators are allowed. Set to &apos;true&apos; to allow all GitHub Marketplace actions by verified creators.
    /// </summary>
    [JsonPropertyName("verifiedAllowed")]
    public bool? VerifiedAllowed { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsSpecForProviderEnabledRepositoriesConfig
{
    /// <summary>
    /// List of repository IDs to enable for GitHub Actions.
    /// List of repository IDs to enable for GitHub Actions.
    /// </summary>
    [JsonPropertyName("repositoryIds")]
    public IList<long>? RepositoryIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsSpecForProvider
{
    /// <summary>
    /// The permissions policy that controls the actions that are allowed to run. Can be one of: all, local_only, or selected.
    /// The permissions policy that controls the actions that are allowed to run. Can be one of: &apos;all&apos;, &apos;local_only&apos;, or &apos;selected&apos;.
    /// </summary>
    [JsonPropertyName("allowedActions")]
    public string? AllowedActions { get; set; }

    /// <summary>
    /// Sets the actions that are allowed in an organization. Only available when allowed_actions = selected. See Allowed Actions Config below for details.
    /// Sets the actions that are allowed in an organization. Only available when &apos;allowed_actions&apos; = &apos;selected&apos;
    /// </summary>
    [JsonPropertyName("allowedActionsConfig")]
    public IList<V1alpha1OrganizationPermissionsSpecForProviderAllowedActionsConfig>? AllowedActionsConfig { get; set; }

    /// <summary>
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions. Can be one of: all, none, or selected.
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions. Can be one of: &apos;all&apos;, &apos;none&apos;, or &apos;selected&apos;.
    /// </summary>
    [JsonPropertyName("enabledRepositories")]
    public string? EnabledRepositories { get; set; }

    /// <summary>
    /// Sets the list of selected repositories that are enabled for GitHub Actions in an organization. Only available when enabled_repositories = selected. See Enabled Repositories Config below for details.
    /// Sets the list of selected repositories that are enabled for GitHub Actions in an organization. Only available when &apos;enabled_repositories&apos; = &apos;selected&apos;.
    /// </summary>
    [JsonPropertyName("enabledRepositoriesConfig")]
    public IList<V1alpha1OrganizationPermissionsSpecForProviderEnabledRepositoriesConfig>? EnabledRepositoriesConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsSpecInitProviderAllowedActionsConfig
{
    /// <summary>
    /// Whether GitHub-owned actions are allowed in the organization.
    /// Whether GitHub-owned actions are allowed in the organization.
    /// </summary>
    [JsonPropertyName("githubOwnedAllowed")]
    public bool? GithubOwnedAllowed { get; set; }

    /// <summary>
    /// Specifies a list of string-matching patterns to allow specific action(s). Wildcards, tags, and SHAs are allowed. For example, monalisa/octocat@, monalisa/octocat@v2, monalisa/.&quot;
    /// Specifies a list of string-matching patterns to allow specific action(s). Wildcards, tags, and SHAs are allowed. For example, &apos;monalisa/octocat@&apos;, &apos;monalisa/octocat@v2&apos;, &apos;monalisa/&apos;.
    /// </summary>
    [JsonPropertyName("patternsAllowed")]
    public IList<string>? PatternsAllowed { get; set; }

    /// <summary>
    /// Whether actions in GitHub Marketplace from verified creators are allowed. Set to true to allow all GitHub Marketplace actions by verified creators.
    /// Whether actions in GitHub Marketplace from verified creators are allowed. Set to &apos;true&apos; to allow all GitHub Marketplace actions by verified creators.
    /// </summary>
    [JsonPropertyName("verifiedAllowed")]
    public bool? VerifiedAllowed { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsSpecInitProviderEnabledRepositoriesConfig
{
    /// <summary>
    /// List of repository IDs to enable for GitHub Actions.
    /// List of repository IDs to enable for GitHub Actions.
    /// </summary>
    [JsonPropertyName("repositoryIds")]
    public IList<long>? RepositoryIds { get; set; }
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
public partial class V1alpha1OrganizationPermissionsSpecInitProvider
{
    /// <summary>
    /// The permissions policy that controls the actions that are allowed to run. Can be one of: all, local_only, or selected.
    /// The permissions policy that controls the actions that are allowed to run. Can be one of: &apos;all&apos;, &apos;local_only&apos;, or &apos;selected&apos;.
    /// </summary>
    [JsonPropertyName("allowedActions")]
    public string? AllowedActions { get; set; }

    /// <summary>
    /// Sets the actions that are allowed in an organization. Only available when allowed_actions = selected. See Allowed Actions Config below for details.
    /// Sets the actions that are allowed in an organization. Only available when &apos;allowed_actions&apos; = &apos;selected&apos;
    /// </summary>
    [JsonPropertyName("allowedActionsConfig")]
    public IList<V1alpha1OrganizationPermissionsSpecInitProviderAllowedActionsConfig>? AllowedActionsConfig { get; set; }

    /// <summary>
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions. Can be one of: all, none, or selected.
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions. Can be one of: &apos;all&apos;, &apos;none&apos;, or &apos;selected&apos;.
    /// </summary>
    [JsonPropertyName("enabledRepositories")]
    public string? EnabledRepositories { get; set; }

    /// <summary>
    /// Sets the list of selected repositories that are enabled for GitHub Actions in an organization. Only available when enabled_repositories = selected. See Enabled Repositories Config below for details.
    /// Sets the list of selected repositories that are enabled for GitHub Actions in an organization. Only available when &apos;enabled_repositories&apos; = &apos;selected&apos;.
    /// </summary>
    [JsonPropertyName("enabledRepositoriesConfig")]
    public IList<V1alpha1OrganizationPermissionsSpecInitProviderEnabledRepositoriesConfig>? EnabledRepositoriesConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1OrganizationPermissionsSpecManagementPoliciesEnum>))]
public enum V1alpha1OrganizationPermissionsSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1OrganizationPermissionsSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1OrganizationPermissionsSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1OrganizationPermissionsSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1OrganizationPermissionsSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1OrganizationPermissionsSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1OrganizationPermissionsSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1OrganizationPermissionsSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>OrganizationPermissionsSpec defines the desired state of OrganizationPermissions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsSpec
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
    public V1alpha1OrganizationPermissionsSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1OrganizationPermissionsSpecForProvider ForProvider { get; set; }

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
    public V1alpha1OrganizationPermissionsSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1OrganizationPermissionsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1OrganizationPermissionsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1OrganizationPermissionsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsStatusAtProviderAllowedActionsConfig
{
    /// <summary>
    /// Whether GitHub-owned actions are allowed in the organization.
    /// Whether GitHub-owned actions are allowed in the organization.
    /// </summary>
    [JsonPropertyName("githubOwnedAllowed")]
    public bool? GithubOwnedAllowed { get; set; }

    /// <summary>
    /// Specifies a list of string-matching patterns to allow specific action(s). Wildcards, tags, and SHAs are allowed. For example, monalisa/octocat@, monalisa/octocat@v2, monalisa/.&quot;
    /// Specifies a list of string-matching patterns to allow specific action(s). Wildcards, tags, and SHAs are allowed. For example, &apos;monalisa/octocat@&apos;, &apos;monalisa/octocat@v2&apos;, &apos;monalisa/&apos;.
    /// </summary>
    [JsonPropertyName("patternsAllowed")]
    public IList<string>? PatternsAllowed { get; set; }

    /// <summary>
    /// Whether actions in GitHub Marketplace from verified creators are allowed. Set to true to allow all GitHub Marketplace actions by verified creators.
    /// Whether actions in GitHub Marketplace from verified creators are allowed. Set to &apos;true&apos; to allow all GitHub Marketplace actions by verified creators.
    /// </summary>
    [JsonPropertyName("verifiedAllowed")]
    public bool? VerifiedAllowed { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsStatusAtProviderEnabledRepositoriesConfig
{
    /// <summary>
    /// List of repository IDs to enable for GitHub Actions.
    /// List of repository IDs to enable for GitHub Actions.
    /// </summary>
    [JsonPropertyName("repositoryIds")]
    public IList<long>? RepositoryIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsStatusAtProvider
{
    /// <summary>
    /// The permissions policy that controls the actions that are allowed to run. Can be one of: all, local_only, or selected.
    /// The permissions policy that controls the actions that are allowed to run. Can be one of: &apos;all&apos;, &apos;local_only&apos;, or &apos;selected&apos;.
    /// </summary>
    [JsonPropertyName("allowedActions")]
    public string? AllowedActions { get; set; }

    /// <summary>
    /// Sets the actions that are allowed in an organization. Only available when allowed_actions = selected. See Allowed Actions Config below for details.
    /// Sets the actions that are allowed in an organization. Only available when &apos;allowed_actions&apos; = &apos;selected&apos;
    /// </summary>
    [JsonPropertyName("allowedActionsConfig")]
    public IList<V1alpha1OrganizationPermissionsStatusAtProviderAllowedActionsConfig>? AllowedActionsConfig { get; set; }

    /// <summary>
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions. Can be one of: all, none, or selected.
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions. Can be one of: &apos;all&apos;, &apos;none&apos;, or &apos;selected&apos;.
    /// </summary>
    [JsonPropertyName("enabledRepositories")]
    public string? EnabledRepositories { get; set; }

    /// <summary>
    /// Sets the list of selected repositories that are enabled for GitHub Actions in an organization. Only available when enabled_repositories = selected. See Enabled Repositories Config below for details.
    /// Sets the list of selected repositories that are enabled for GitHub Actions in an organization. Only available when &apos;enabled_repositories&apos; = &apos;selected&apos;.
    /// </summary>
    [JsonPropertyName("enabledRepositoriesConfig")]
    public IList<V1alpha1OrganizationPermissionsStatusAtProviderEnabledRepositoriesConfig>? EnabledRepositoriesConfig { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsStatusConditions
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

/// <summary>OrganizationPermissionsStatus defines the observed state of OrganizationPermissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrganizationPermissionsStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1OrganizationPermissionsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OrganizationPermissionsStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OrganizationPermissions is the Schema for the OrganizationPermissionss API. Creates and manages Actions permissions within a GitHub organization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrganizationPermissions : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OrganizationPermissionsSpec>, IStatus<V1alpha1OrganizationPermissionsStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrganizationPermissions";
    public const string KubeGroup = "actions.github.upbound.io";
    public const string KubePluralName = "organizationpermissions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "actions.github.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrganizationPermissions";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrganizationPermissionsSpec defines the desired state of OrganizationPermissions</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1OrganizationPermissionsSpec Spec { get; set; }

    /// <summary>OrganizationPermissionsStatus defines the observed state of OrganizationPermissions.</summary>
    [JsonPropertyName("status")]
    public V1alpha1OrganizationPermissionsStatus? Status { get; set; }
}