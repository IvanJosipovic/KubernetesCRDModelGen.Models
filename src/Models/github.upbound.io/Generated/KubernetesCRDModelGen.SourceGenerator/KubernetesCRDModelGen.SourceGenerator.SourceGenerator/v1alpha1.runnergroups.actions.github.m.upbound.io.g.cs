#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.actions.github.m.upbound.io;
/// <summary>RunnerGroup is the Schema for the RunnerGroups API. Creates and manages an Actions Runner Group within a GitHub organization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RunnerGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RunnerGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RunnerGroupList";
    public const string KubeGroup = "actions.github.m.upbound.io";
    public const string KubePluralName = "runnergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "actions.github.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RunnerGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RunnerGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RunnerGroup> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunnerGroupSpecForProvider
{
    /// <summary>
    /// Whether public repositories can be added to the runner group. Defaults to false.
    /// Whether public repositories can be added to the runner group.
    /// </summary>
    [JsonPropertyName("allowsPublicRepositories")]
    public bool? AllowsPublicRepositories { get; set; }

    /// <summary>
    /// Name of the runner group
    /// Name of the runner group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// If true, the runner group will be restricted to running only the workflows specified in the selected_workflows array. Defaults to false.
    /// If &apos;true&apos;, the runner group will be restricted to running only the workflows specified in the &apos;selected_workflows&apos; array. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("restrictedToWorkflows")]
    public bool? RestrictedToWorkflows { get; set; }

    /// <summary>
    /// IDs of the repositories which should be added to the runner group
    /// List of repository IDs that can access the runner group.
    /// </summary>
    [JsonPropertyName("selectedRepositoryIds")]
    public IList<long>? SelectedRepositoryIds { get; set; }

    /// <summary>
    /// List of workflows the runner group should be allowed to run. This setting will be ignored unless restricted_to_workflows is set to true.
    /// List of workflows the runner group should be allowed to run. This setting will be ignored unless restricted_to_workflows is set to &apos;true&apos;.
    /// </summary>
    [JsonPropertyName("selectedWorkflows")]
    public IList<string>? SelectedWorkflows { get; set; }

    /// <summary>
    /// Visibility of a runner group. Whether the runner group can include all, selected, or private repositories. A value of private is not currently supported due to limitations in the GitHub API.
    /// The visibility of the runner group.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
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
public partial class V1alpha1RunnerGroupSpecInitProvider
{
    /// <summary>
    /// Whether public repositories can be added to the runner group. Defaults to false.
    /// Whether public repositories can be added to the runner group.
    /// </summary>
    [JsonPropertyName("allowsPublicRepositories")]
    public bool? AllowsPublicRepositories { get; set; }

    /// <summary>
    /// Name of the runner group
    /// Name of the runner group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// If true, the runner group will be restricted to running only the workflows specified in the selected_workflows array. Defaults to false.
    /// If &apos;true&apos;, the runner group will be restricted to running only the workflows specified in the &apos;selected_workflows&apos; array. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("restrictedToWorkflows")]
    public bool? RestrictedToWorkflows { get; set; }

    /// <summary>
    /// IDs of the repositories which should be added to the runner group
    /// List of repository IDs that can access the runner group.
    /// </summary>
    [JsonPropertyName("selectedRepositoryIds")]
    public IList<long>? SelectedRepositoryIds { get; set; }

    /// <summary>
    /// List of workflows the runner group should be allowed to run. This setting will be ignored unless restricted_to_workflows is set to true.
    /// List of workflows the runner group should be allowed to run. This setting will be ignored unless restricted_to_workflows is set to &apos;true&apos;.
    /// </summary>
    [JsonPropertyName("selectedWorkflows")]
    public IList<string>? SelectedWorkflows { get; set; }

    /// <summary>
    /// Visibility of a runner group. Whether the runner group can include all, selected, or private repositories. A value of private is not currently supported due to limitations in the GitHub API.
    /// The visibility of the runner group.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1RunnerGroupSpecManagementPoliciesEnum>))]
public enum V1alpha1RunnerGroupSpecManagementPoliciesEnum
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
public partial class V1alpha1RunnerGroupSpecProviderConfigRef
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
public partial class V1alpha1RunnerGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RunnerGroupSpec defines the desired state of RunnerGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunnerGroupSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1RunnerGroupSpecForProvider ForProvider { get; set; }

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
    public V1alpha1RunnerGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1RunnerGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1RunnerGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1RunnerGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunnerGroupStatusAtProvider
{
    /// <summary>
    /// Whether public repositories can be added to the runner group. Defaults to false.
    /// Whether public repositories can be added to the runner group.
    /// </summary>
    [JsonPropertyName("allowsPublicRepositories")]
    public bool? AllowsPublicRepositories { get; set; }

    /// <summary>
    /// Whether this is the default runner group
    /// Whether this is the default runner group.
    /// </summary>
    [JsonPropertyName("default")]
    public bool? Default { get; set; }

    /// <summary>
    /// An etag representing the runner group object
    /// An etag representing the runner group object
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether the runner group is inherited from the enterprise level
    /// Whether the runner group is inherited from the enterprise level
    /// </summary>
    [JsonPropertyName("inherited")]
    public bool? Inherited { get; set; }

    /// <summary>
    /// Name of the runner group
    /// Name of the runner group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// If true, the runner group will be restricted to running only the workflows specified in the selected_workflows array. Defaults to false.
    /// If &apos;true&apos;, the runner group will be restricted to running only the workflows specified in the &apos;selected_workflows&apos; array. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("restrictedToWorkflows")]
    public bool? RestrictedToWorkflows { get; set; }

    /// <summary>
    /// The GitHub API URL for the runner group&apos;s runners
    /// The GitHub API URL for the runner group&apos;s runners.
    /// </summary>
    [JsonPropertyName("runnersUrl")]
    public string? RunnersUrl { get; set; }

    /// <summary>
    /// GitHub API URL for the runner group&apos;s repositories
    /// GitHub API URL for the runner group&apos;s repositories.
    /// </summary>
    [JsonPropertyName("selectedRepositoriesUrl")]
    public string? SelectedRepositoriesUrl { get; set; }

    /// <summary>
    /// IDs of the repositories which should be added to the runner group
    /// List of repository IDs that can access the runner group.
    /// </summary>
    [JsonPropertyName("selectedRepositoryIds")]
    public IList<long>? SelectedRepositoryIds { get; set; }

    /// <summary>
    /// List of workflows the runner group should be allowed to run. This setting will be ignored unless restricted_to_workflows is set to true.
    /// List of workflows the runner group should be allowed to run. This setting will be ignored unless restricted_to_workflows is set to &apos;true&apos;.
    /// </summary>
    [JsonPropertyName("selectedWorkflows")]
    public IList<string>? SelectedWorkflows { get; set; }

    /// <summary>
    /// Visibility of a runner group. Whether the runner group can include all, selected, or private repositories. A value of private is not currently supported due to limitations in the GitHub API.
    /// The visibility of the runner group.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunnerGroupStatusConditions
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

/// <summary>RunnerGroupStatus defines the observed state of RunnerGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunnerGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1RunnerGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RunnerGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RunnerGroup is the Schema for the RunnerGroups API. Creates and manages an Actions Runner Group within a GitHub organization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RunnerGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RunnerGroupSpec>, IStatus<V1alpha1RunnerGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RunnerGroup";
    public const string KubeGroup = "actions.github.m.upbound.io";
    public const string KubePluralName = "runnergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "actions.github.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RunnerGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RunnerGroupSpec defines the desired state of RunnerGroup</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1RunnerGroupSpec Spec { get; set; }

    /// <summary>RunnerGroupStatus defines the observed state of RunnerGroup.</summary>
    [JsonPropertyName("status")]
    public V1alpha1RunnerGroupStatus? Status { get; set; }
}