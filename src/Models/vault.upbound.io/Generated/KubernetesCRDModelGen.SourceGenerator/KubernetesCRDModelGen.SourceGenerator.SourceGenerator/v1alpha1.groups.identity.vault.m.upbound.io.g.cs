#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identity.vault.m.upbound.io;
/// <summary>Group is the Schema for the Groups API. Creates an Identity Group for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Group>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GroupList";
    public const string KubeGroup = "identity.vault.m.upbound.io";
    public const string KubePluralName = "groups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identity.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Group objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Group> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GroupSpecForProvider
{
    /// <summary>
    /// false by default. If set to true, this resource will ignore any Entity IDs
    /// returned from Vault or specified in the resource. You can use
    /// vault_identity_group_member_entity_ids to manage Entity IDs for this group in a
    /// decoupled manner.
    /// Manage member entities externally through `vault_identity_group_member_entity_ids`
    /// </summary>
    [JsonPropertyName("externalMemberEntityIds")]
    public bool? ExternalMemberEntityIds { get; set; }

    /// <summary>
    /// false by default. If set to true, this resource will ignore any Group IDs
    /// returned from Vault or specified in the resource. You can use
    /// vault_identity_group_member_group_ids to manage Group IDs for this group in a
    /// decoupled manner.
    /// Manage member groups externally through `vault_identity_group_member_group_ids`
    /// </summary>
    [JsonPropertyName("externalMemberGroupIds")]
    public bool? ExternalMemberGroupIds { get; set; }

    /// <summary>
    /// false by default. If set to true, this resource will ignore any policies returned from
    /// Vault or specified in the resource. You can use vault_identity_group_policies to manage
    /// policies for this group in a decoupled manner.
    /// Manage policies externally through `vault_identity_group_policies`, allows using group ID in assigned policies.
    /// </summary>
    [JsonPropertyName("externalPolicies")]
    public bool? ExternalPolicies { get; set; }

    /// <summary>
    /// A list of Entity IDs to be assigned as group members. Not allowed on external groups.
    /// Entity IDs to be assigned as group members.
    /// </summary>
    [JsonPropertyName("memberEntityIds")]
    public IList<string>? MemberEntityIds { get; set; }

    /// <summary>
    /// A list of Group IDs to be assigned as group members. Not allowed on external groups.
    /// Group IDs to be assigned as group members.
    /// </summary>
    [JsonPropertyName("memberGroupIds")]
    public IList<string>? MemberGroupIds { get; set; }

    /// <summary>
    /// A Map of additional metadata to associate with the group.
    /// Metadata to be associated with the group.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Name of the identity group to create.
    /// Name of the group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// A list of policies to apply to the group.
    /// Policies to be tied to the group.
    /// </summary>
    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }

    /// <summary>
    /// Type of the group, internal or external. Defaults to internal.
    /// Type of the group, internal or external. Defaults to internal.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
public partial class V1alpha1GroupSpecInitProvider
{
    /// <summary>
    /// false by default. If set to true, this resource will ignore any Entity IDs
    /// returned from Vault or specified in the resource. You can use
    /// vault_identity_group_member_entity_ids to manage Entity IDs for this group in a
    /// decoupled manner.
    /// Manage member entities externally through `vault_identity_group_member_entity_ids`
    /// </summary>
    [JsonPropertyName("externalMemberEntityIds")]
    public bool? ExternalMemberEntityIds { get; set; }

    /// <summary>
    /// false by default. If set to true, this resource will ignore any Group IDs
    /// returned from Vault or specified in the resource. You can use
    /// vault_identity_group_member_group_ids to manage Group IDs for this group in a
    /// decoupled manner.
    /// Manage member groups externally through `vault_identity_group_member_group_ids`
    /// </summary>
    [JsonPropertyName("externalMemberGroupIds")]
    public bool? ExternalMemberGroupIds { get; set; }

    /// <summary>
    /// false by default. If set to true, this resource will ignore any policies returned from
    /// Vault or specified in the resource. You can use vault_identity_group_policies to manage
    /// policies for this group in a decoupled manner.
    /// Manage policies externally through `vault_identity_group_policies`, allows using group ID in assigned policies.
    /// </summary>
    [JsonPropertyName("externalPolicies")]
    public bool? ExternalPolicies { get; set; }

    /// <summary>
    /// A list of Entity IDs to be assigned as group members. Not allowed on external groups.
    /// Entity IDs to be assigned as group members.
    /// </summary>
    [JsonPropertyName("memberEntityIds")]
    public IList<string>? MemberEntityIds { get; set; }

    /// <summary>
    /// A list of Group IDs to be assigned as group members. Not allowed on external groups.
    /// Group IDs to be assigned as group members.
    /// </summary>
    [JsonPropertyName("memberGroupIds")]
    public IList<string>? MemberGroupIds { get; set; }

    /// <summary>
    /// A Map of additional metadata to associate with the group.
    /// Metadata to be associated with the group.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Name of the identity group to create.
    /// Name of the group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// A list of policies to apply to the group.
    /// Policies to be tied to the group.
    /// </summary>
    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }

    /// <summary>
    /// Type of the group, internal or external. Defaults to internal.
    /// Type of the group, internal or external. Defaults to internal.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1GroupSpecManagementPoliciesEnum>))]
public enum V1alpha1GroupSpecManagementPoliciesEnum
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
public partial class V1alpha1GroupSpecProviderConfigRef
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
public partial class V1alpha1GroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>GroupSpec defines the desired state of Group</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GroupSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1GroupSpecForProvider ForProvider { get; set; }

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
    public V1alpha1GroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1GroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1GroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1GroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GroupStatusAtProvider
{
    /// <summary>
    /// false by default. If set to true, this resource will ignore any Entity IDs
    /// returned from Vault or specified in the resource. You can use
    /// vault_identity_group_member_entity_ids to manage Entity IDs for this group in a
    /// decoupled manner.
    /// Manage member entities externally through `vault_identity_group_member_entity_ids`
    /// </summary>
    [JsonPropertyName("externalMemberEntityIds")]
    public bool? ExternalMemberEntityIds { get; set; }

    /// <summary>
    /// false by default. If set to true, this resource will ignore any Group IDs
    /// returned from Vault or specified in the resource. You can use
    /// vault_identity_group_member_group_ids to manage Group IDs for this group in a
    /// decoupled manner.
    /// Manage member groups externally through `vault_identity_group_member_group_ids`
    /// </summary>
    [JsonPropertyName("externalMemberGroupIds")]
    public bool? ExternalMemberGroupIds { get; set; }

    /// <summary>
    /// false by default. If set to true, this resource will ignore any policies returned from
    /// Vault or specified in the resource. You can use vault_identity_group_policies to manage
    /// policies for this group in a decoupled manner.
    /// Manage policies externally through `vault_identity_group_policies`, allows using group ID in assigned policies.
    /// </summary>
    [JsonPropertyName("externalPolicies")]
    public bool? ExternalPolicies { get; set; }

    /// <summary>The id of the created group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A list of Entity IDs to be assigned as group members. Not allowed on external groups.
    /// Entity IDs to be assigned as group members.
    /// </summary>
    [JsonPropertyName("memberEntityIds")]
    public IList<string>? MemberEntityIds { get; set; }

    /// <summary>
    /// A list of Group IDs to be assigned as group members. Not allowed on external groups.
    /// Group IDs to be assigned as group members.
    /// </summary>
    [JsonPropertyName("memberGroupIds")]
    public IList<string>? MemberGroupIds { get; set; }

    /// <summary>
    /// A Map of additional metadata to associate with the group.
    /// Metadata to be associated with the group.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Name of the identity group to create.
    /// Name of the group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// A list of policies to apply to the group.
    /// Policies to be tied to the group.
    /// </summary>
    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }

    /// <summary>
    /// Type of the group, internal or external. Defaults to internal.
    /// Type of the group, internal or external. Defaults to internal.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GroupStatusConditions
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

/// <summary>GroupStatus defines the observed state of Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1GroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Group is the Schema for the Groups API. Creates an Identity Group for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Group : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GroupSpec>, IStatus<V1alpha1GroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Group";
    public const string KubeGroup = "identity.vault.m.upbound.io";
    public const string KubePluralName = "groups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identity.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Group";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GroupSpec defines the desired state of Group</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1GroupSpec Spec { get; set; }

    /// <summary>GroupStatus defines the observed state of Group.</summary>
    [JsonPropertyName("status")]
    public V1alpha1GroupStatus? Status { get; set; }
}