#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.workspace.databricks.m.upbound.io;
/// <summary>Repo is the Schema for the Repos API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RepoList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Repo>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RepoList";
    public const string KubeGroup = "workspace.databricks.m.upbound.io";
    public const string KubePluralName = "repoes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "workspace.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RepoList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Repo objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Repo> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepoSpecForProviderSparseCheckout
{
    /// <summary>array of paths (directories) that will be used for sparse checkout.  List of patterns could be updated in-place.</summary>
    [JsonPropertyName("patterns")]
    public IList<string>? Patterns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepoSpecForProvider
{
    /// <summary>name of the branch for initial checkout. If not specified, the default branch of the repository will be used.  Conflicts with tag.  If branch is removed, and tag isn&apos;t specified, then the repository will stay at the previously checked out state.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Hash of the HEAD commit at time of the last executed operation. It won&apos;t change if you manually perform pull operation via UI or API</summary>
    [JsonPropertyName("commitHash")]
    public string? CommitHash { get; set; }

    /// <summary>case insensitive name of the Git provider.  Following values are supported right now (could be a subject for a change, consult Repos API documentation): gitHub, gitHubEnterprise, bitbucketCloud, bitbucketServer, azureDevOpsServices, gitLab, gitLabEnterpriseEdition, awsCodeCommit.</summary>
    [JsonPropertyName("gitProvider")]
    public string? GitProvider { get; set; }

    /// <summary>path to put the checked out Git folder. If not specified, , then the Git folder will be created in the default location.  If the value changes, Git folder is re-created.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("sparseCheckout")]
    public V1beta1RepoSpecForProviderSparseCheckout? SparseCheckout { get; set; }

    /// <summary>name of the tag for initial checkout.  Conflicts with branch.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The URL of the Git Repository to clone from. If the value changes, Git folder is re-created.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepoSpecInitProviderSparseCheckout
{
    /// <summary>array of paths (directories) that will be used for sparse checkout.  List of patterns could be updated in-place.</summary>
    [JsonPropertyName("patterns")]
    public IList<string>? Patterns { get; set; }
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
public partial class V1beta1RepoSpecInitProvider
{
    /// <summary>name of the branch for initial checkout. If not specified, the default branch of the repository will be used.  Conflicts with tag.  If branch is removed, and tag isn&apos;t specified, then the repository will stay at the previously checked out state.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Hash of the HEAD commit at time of the last executed operation. It won&apos;t change if you manually perform pull operation via UI or API</summary>
    [JsonPropertyName("commitHash")]
    public string? CommitHash { get; set; }

    /// <summary>case insensitive name of the Git provider.  Following values are supported right now (could be a subject for a change, consult Repos API documentation): gitHub, gitHubEnterprise, bitbucketCloud, bitbucketServer, azureDevOpsServices, gitLab, gitLabEnterpriseEdition, awsCodeCommit.</summary>
    [JsonPropertyName("gitProvider")]
    public string? GitProvider { get; set; }

    /// <summary>path to put the checked out Git folder. If not specified, , then the Git folder will be created in the default location.  If the value changes, Git folder is re-created.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("sparseCheckout")]
    public V1beta1RepoSpecInitProviderSparseCheckout? SparseCheckout { get; set; }

    /// <summary>name of the tag for initial checkout.  Conflicts with branch.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The URL of the Git Repository to clone from. If the value changes, Git folder is re-created.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RepoSpecManagementPoliciesEnum>))]
public enum V1beta1RepoSpecManagementPoliciesEnum
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
public partial class V1beta1RepoSpecProviderConfigRef
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
public partial class V1beta1RepoSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RepoSpec defines the desired state of Repo</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepoSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1RepoSpecForProvider ForProvider { get; set; }

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
    public V1beta1RepoSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RepoSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RepoSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RepoSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepoStatusAtProviderSparseCheckout
{
    /// <summary>array of paths (directories) that will be used for sparse checkout.  List of patterns could be updated in-place.</summary>
    [JsonPropertyName("patterns")]
    public IList<string>? Patterns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepoStatusAtProvider
{
    /// <summary>name of the branch for initial checkout. If not specified, the default branch of the repository will be used.  Conflicts with tag.  If branch is removed, and tag isn&apos;t specified, then the repository will stay at the previously checked out state.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Hash of the HEAD commit at time of the last executed operation. It won&apos;t change if you manually perform pull operation via UI or API</summary>
    [JsonPropertyName("commitHash")]
    public string? CommitHash { get; set; }

    /// <summary>case insensitive name of the Git provider.  Following values are supported right now (could be a subject for a change, consult Repos API documentation): gitHub, gitHubEnterprise, bitbucketCloud, bitbucketServer, azureDevOpsServices, gitLab, gitLabEnterpriseEdition, awsCodeCommit.</summary>
    [JsonPropertyName("gitProvider")]
    public string? GitProvider { get; set; }

    /// <summary>Git folder identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>path to put the checked out Git folder. If not specified, , then the Git folder will be created in the default location.  If the value changes, Git folder is re-created.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("sparseCheckout")]
    public V1beta1RepoStatusAtProviderSparseCheckout? SparseCheckout { get; set; }

    /// <summary>name of the tag for initial checkout.  Conflicts with branch.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The URL of the Git Repository to clone from. If the value changes, Git folder is re-created.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>path on Workspace File System (WSFS) in form of /Workspace + path</summary>
    [JsonPropertyName("workspacePath")]
    public string? WorkspacePath { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepoStatusConditions
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

/// <summary>RepoStatus defines the observed state of Repo.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RepoStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RepoStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RepoStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Repo is the Schema for the Repos API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Repo : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RepoSpec>, IStatus<V1beta1RepoStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Repo";
    public const string KubeGroup = "workspace.databricks.m.upbound.io";
    public const string KubePluralName = "repoes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "workspace.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Repo";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RepoSpec defines the desired state of Repo</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RepoSpec Spec { get; set; }

    /// <summary>RepoStatus defines the observed state of Repo.</summary>
    [JsonPropertyName("status")]
    public V1beta1RepoStatus? Status { get; set; }
}