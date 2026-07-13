#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudidentity.gcp.m.upbound.io;
/// <summary>Group is the Schema for the Groups API. A Cloud Identity resource representing a Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Group>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GroupList";
    public const string KubeGroup = "cloudidentity.gcp.m.upbound.io";
    public const string KubePluralName = "groups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudidentity.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Group objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Group> Items { get; set; }
}

/// <summary>
/// EntityKey of the Group.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecForProviderGroupKey
{
    /// <summary>
    /// The ID of the entity.
    /// For Google-managed entities, the id must be the email address of an existing
    /// group or user.
    /// For external-identity-mapped entities, the id must be a string conforming
    /// to the Identity Source&apos;s requirements.
    /// Must be unique within a namespace.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The namespace in which the entity exists.
    /// If not specified, the EntityKey represents a Google-managed entity
    /// such as a Google user or a Google Group.
    /// If specified, the EntityKey represents an external-identity-mapped group.
    /// The namespace must correspond to an identity source created in Admin Console
    /// and must be in the form of identitysources/{identity_source_id}.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecForProvider
{
    /// <summary>
    /// An extended description to help users determine the purpose of a Group.
    /// Must not be longer than 4,096 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the Group.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// EntityKey of the Group.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("groupKey")]
    public V1beta1GroupSpecForProviderGroupKey? GroupKey { get; set; }

    /// <summary>
    /// The initial configuration options for creating a Group.
    /// See the
    /// API reference
    /// for possible values.
    /// Default value is EMPTY.
    /// Possible values are: INITIAL_GROUP_CONFIG_UNSPECIFIED, WITH_INITIAL_OWNER, EMPTY.
    /// </summary>
    [JsonPropertyName("initialGroupConfig")]
    public string? InitialGroupConfig { get; set; }

    /// <summary>
    /// One or more label entries that apply to the Group. Currently supported labels contain a key with an empty value.
    /// Google Groups are the default type of group and have a label with a key of cloudidentity.googleapis.com/groups.discussion_forum and an empty value.
    /// Existing Google Groups can have an additional label with a key of cloudidentity.googleapis.com/groups.security and an empty value added to them. This is an immutable change and the security label cannot be removed once added.
    /// Dynamic groups have a label with a key of cloudidentity.googleapis.com/groups.dynamic.
    /// Identity-mapped groups for Cloud Search have a label with a key of system/groups/external and an empty value.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The resource name of the entity under which this Group resides in the
    /// Cloud Identity resource hierarchy.
    /// Must be of the form identitysources/{identity_source_id} for external-identity-mapped
    /// groups or customers/{customer_id} for Google Groups.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }
}

/// <summary>
/// EntityKey of the Group.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpecInitProviderGroupKey
{
    /// <summary>
    /// The ID of the entity.
    /// For Google-managed entities, the id must be the email address of an existing
    /// group or user.
    /// For external-identity-mapped entities, the id must be a string conforming
    /// to the Identity Source&apos;s requirements.
    /// Must be unique within a namespace.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The namespace in which the entity exists.
    /// If not specified, the EntityKey represents a Google-managed entity
    /// such as a Google user or a Google Group.
    /// If specified, the EntityKey represents an external-identity-mapped group.
    /// The namespace must correspond to an identity source created in Admin Console
    /// and must be in the form of identitysources/{identity_source_id}.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
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
public partial class V1beta1GroupSpecInitProvider
{
    /// <summary>
    /// An extended description to help users determine the purpose of a Group.
    /// Must not be longer than 4,096 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the Group.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// EntityKey of the Group.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("groupKey")]
    public V1beta1GroupSpecInitProviderGroupKey? GroupKey { get; set; }

    /// <summary>
    /// The initial configuration options for creating a Group.
    /// See the
    /// API reference
    /// for possible values.
    /// Default value is EMPTY.
    /// Possible values are: INITIAL_GROUP_CONFIG_UNSPECIFIED, WITH_INITIAL_OWNER, EMPTY.
    /// </summary>
    [JsonPropertyName("initialGroupConfig")]
    public string? InitialGroupConfig { get; set; }

    /// <summary>
    /// One or more label entries that apply to the Group. Currently supported labels contain a key with an empty value.
    /// Google Groups are the default type of group and have a label with a key of cloudidentity.googleapis.com/groups.discussion_forum and an empty value.
    /// Existing Google Groups can have an additional label with a key of cloudidentity.googleapis.com/groups.security and an empty value added to them. This is an immutable change and the security label cannot be removed once added.
    /// Dynamic groups have a label with a key of cloudidentity.googleapis.com/groups.dynamic.
    /// Identity-mapped groups for Cloud Search have a label with a key of system/groups/external and an empty value.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The resource name of the entity under which this Group resides in the
    /// Cloud Identity resource hierarchy.
    /// Must be of the form identitysources/{identity_source_id} for external-identity-mapped
    /// groups or customers/{customer_id} for Google Groups.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GroupSpecManagementPoliciesEnum>))]
public enum V1beta1GroupSpecManagementPoliciesEnum
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
public partial class V1beta1GroupSpecProviderConfigRef
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
public partial class V1beta1GroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>GroupSpec defines the desired state of Group</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1GroupSpecForProvider ForProvider { get; set; }

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
    public V1beta1GroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1GroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupStatusAtProviderAdditionalGroupKeys
{
    /// <summary>
    /// (Output)
    /// The ID of the entity.
    /// For Google-managed entities, the id must be the email address of an existing
    /// group or user.
    /// For external-identity-mapped entities, the id must be a string conforming
    /// to the Identity Source&apos;s requirements.
    /// Must be unique within a namespace.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// (Output)
    /// The namespace in which the entity exists.
    /// If not specified, the EntityKey represents a Google-managed entity
    /// such as a Google user or a Google Group.
    /// If specified, the EntityKey represents an external-identity-mapped group.
    /// The namespace must correspond to an identity source created in Admin Console
    /// and must be in the form of identitysources/{identity_source_id}.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// EntityKey of the Group.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupStatusAtProviderGroupKey
{
    /// <summary>
    /// The ID of the entity.
    /// For Google-managed entities, the id must be the email address of an existing
    /// group or user.
    /// For external-identity-mapped entities, the id must be a string conforming
    /// to the Identity Source&apos;s requirements.
    /// Must be unique within a namespace.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The namespace in which the entity exists.
    /// If not specified, the EntityKey represents a Google-managed entity
    /// such as a Google user or a Google Group.
    /// If specified, the EntityKey represents an external-identity-mapped group.
    /// The namespace must correspond to an identity source created in Admin Console
    /// and must be in the form of identitysources/{identity_source_id}.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupStatusAtProvider
{
    /// <summary>
    /// Additional group keys associated with the Group
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalGroupKeys")]
    public IList<V1beta1GroupStatusAtProviderAdditionalGroupKeys>? AdditionalGroupKeys { get; set; }

    /// <summary>The time when the Group was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// An extended description to help users determine the purpose of a Group.
    /// Must not be longer than 4,096 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the Group.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// EntityKey of the Group.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("groupKey")]
    public V1beta1GroupStatusAtProviderGroupKey? GroupKey { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The initial configuration options for creating a Group.
    /// See the
    /// API reference
    /// for possible values.
    /// Default value is EMPTY.
    /// Possible values are: INITIAL_GROUP_CONFIG_UNSPECIFIED, WITH_INITIAL_OWNER, EMPTY.
    /// </summary>
    [JsonPropertyName("initialGroupConfig")]
    public string? InitialGroupConfig { get; set; }

    /// <summary>
    /// One or more label entries that apply to the Group. Currently supported labels contain a key with an empty value.
    /// Google Groups are the default type of group and have a label with a key of cloudidentity.googleapis.com/groups.discussion_forum and an empty value.
    /// Existing Google Groups can have an additional label with a key of cloudidentity.googleapis.com/groups.security and an empty value added to them. This is an immutable change and the security label cannot be removed once added.
    /// Dynamic groups have a label with a key of cloudidentity.googleapis.com/groups.dynamic.
    /// Identity-mapped groups for Cloud Search have a label with a key of system/groups/external and an empty value.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Resource name of the Group in the format: groups/{group_id}, where group_id
    /// is the unique ID assigned to the Group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The resource name of the entity under which this Group resides in the
    /// Cloud Identity resource hierarchy.
    /// Must be of the form identitysources/{identity_source_id} for external-identity-mapped
    /// groups or customers/{customer_id} for Google Groups.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The time when the Group was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GroupStatusConditions
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
public partial class V1beta1GroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1GroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Group is the Schema for the Groups API. A Cloud Identity resource representing a Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Group : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GroupSpec>, IStatus<V1beta1GroupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Group";
    public const string KubeGroup = "cloudidentity.gcp.m.upbound.io";
    public const string KubePluralName = "groups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudidentity.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Group";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GroupSpec defines the desired state of Group</summary>
    [JsonPropertyName("spec")]
    public required V1beta1GroupSpec Spec { get; set; }

    /// <summary>GroupStatus defines the observed state of Group.</summary>
    [JsonPropertyName("status")]
    public V1beta1GroupStatus? Status { get; set; }
}