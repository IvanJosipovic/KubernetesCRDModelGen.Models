#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudidentity.cnrm.cloud.google.com;
/// <summary>CloudIdentityMembership is the Schema for the CloudIdentityMembership API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudIdentityMembershipList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CloudIdentityMembership>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudIdentityMembershipList";
    public const string KubeGroup = "cloudidentity.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudidentitymemberships";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudidentity.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudIdentityMembershipList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1CloudIdentityMembership objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1CloudIdentityMembership> Items { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipSpecGroupRef
{
    /// <summary>A reference to an externally managed CloudIdentityGroup resource. Should be in the format &quot;groups/{{groupID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudIdentityGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudIdentityGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned. Do not set. This is a legacy OUTPUT-ONLY field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipSpecMemberKey
{
    /// <summary>Immutable. The ID of the entity. For Google-managed entities, the `id` must be the email address of an existing group or user. For external-identity-mapped entities, the `id` must be a string conforming to the Identity Source&apos;s requirements. Must be unique within a `namespace`.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>Immutable. The namespace in which the entity exists. If not specified, the `EntityKey` represents a Google-managed entity such as a Google user or a Google Group. If specified, the `EntityKey` represents an external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console and must be in the form of `identitysources/{identity_source_id}`.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipSpecPreferredMemberKey
{
    /// <summary>Immutable. The ID of the entity. For Google-managed entities, the `id` must be the email address of an existing group or user. For external-identity-mapped entities, the `id` must be a string conforming to the Identity Source&apos;s requirements. Must be unique within a `namespace`.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>Immutable. The namespace in which the entity exists. If not specified, the `EntityKey` represents a Google-managed entity such as a Google user or a Google Group. If specified, the `EntityKey` represents an external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console and must be in the form of `identitysources/{identity_source_id}`.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The expiry details of the `MembershipRole`. Expiry details are only supported for `MEMBER` `MembershipRoles`. May be set if `name` is `MEMBER`. Must not be set if `name` is any other value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipSpecRolesExpiryDetail
{
    /// <summary>The time at which the `MembershipRole` will expire.</summary>
    [JsonPropertyName("expireTime")]
    public DateTime? ExpireTime { get; set; }
}

/// <summary>Evaluation of the member restriction applied to this membership. Empty if the user lacks permission to view the restriction evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipSpecRolesRestrictionEvaluationsMemberRestrictionEvaluation
{
    /// <summary>Output only. The current state of the restriction</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Evaluations of restrictions applied to parent group on this membership.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipSpecRolesRestrictionEvaluations
{
    /// <summary>Evaluation of the member restriction applied to this membership. Empty if the user lacks permission to view the restriction evaluation.</summary>
    [JsonPropertyName("memberRestrictionEvaluation")]
    public V1beta1CloudIdentityMembershipSpecRolesRestrictionEvaluationsMemberRestrictionEvaluation? MemberRestrictionEvaluation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipSpecRoles
{
    /// <summary>The expiry details of the `MembershipRole`. Expiry details are only supported for `MEMBER` `MembershipRoles`. May be set if `name` is `MEMBER`. Must not be set if `name` is any other value.</summary>
    [JsonPropertyName("expiryDetail")]
    public V1beta1CloudIdentityMembershipSpecRolesExpiryDetail? ExpiryDetail { get; set; }

    /// <summary>The name of the `MembershipRole`. Must be one of `OWNER`, `MANAGER`, `MEMBER`.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Evaluations of restrictions applied to parent group on this membership.</summary>
    [JsonPropertyName("restrictionEvaluations")]
    public V1beta1CloudIdentityMembershipSpecRolesRestrictionEvaluations? RestrictionEvaluations { get; set; }
}

/// <summary>CloudIdentityMembershipSpec defines the desired state of CloudIdentityMembership</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipSpec
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("groupRef")]
    public required V1beta1CloudIdentityMembershipSpecGroupRef GroupRef { get; set; }

    /// <summary>Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned. Do not set. This is a legacy OUTPUT-ONLY field.</summary>
    [JsonPropertyName("memberKey")]
    public V1beta1CloudIdentityMembershipSpecMemberKey? MemberKey { get; set; }

    /// <summary>Required. Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.</summary>
    [JsonPropertyName("preferredMemberKey")]
    public required V1beta1CloudIdentityMembershipSpecPreferredMemberKey PreferredMemberKey { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Format: {membershipID}. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The `MembershipRole`s that apply to the `Membership`. If unspecified, defaults to a single `MembershipRole` with `name` `MEMBER`. Must not contain duplicate `MembershipRole`s with the same `name`.</summary>
    [JsonPropertyName("roles")]
    public required IList<V1beta1CloudIdentityMembershipSpecRoles> Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Output only. The display name of this member, if available</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipStatusDisplayName
{
    /// <summary>Output only. Member&apos;s family name</summary>
    [JsonPropertyName("familyName")]
    public string? FamilyName { get; set; }

    /// <summary>Output only. Localized UTF-16 full name for the member. Localization is done based on the language in the request and the language of the stored display name.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Output only. Member&apos;s given name</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }
}

/// <summary>CloudIdentityMembershipStatus defines the config connector machine state of CloudIdentityMembership</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityMembershipStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CloudIdentityMembershipStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time when the `Membership` was created.</summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>Output only. Delivery setting associated with the membership. Possible values: DELIVERY_SETTING_UNSPECIFIED, ALL_MAIL, DIGEST, DAILY, NONE, DISABLED</summary>
    [JsonPropertyName("deliverySetting")]
    public string? DeliverySetting { get; set; }

    /// <summary>Output only. The display name of this member, if available</summary>
    [JsonPropertyName("displayName")]
    public V1beta1CloudIdentityMembershipStatusDisplayName? DisplayName { get; set; }

    /// <summary>A unique Config Connector specifier for the resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Output only. The type of the membership. Possible values: OWNER_TYPE_UNSPECIFIED, OWNER_TYPE_CUSTOMER, OWNER_TYPE_PARTNER</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Output only. The time when the `Membership` was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

/// <summary>CloudIdentityMembership is the Schema for the CloudIdentityMembership API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudIdentityMembership : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CloudIdentityMembershipSpec>, IStatus<V1beta1CloudIdentityMembershipStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudIdentityMembership";
    public const string KubeGroup = "cloudidentity.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudidentitymemberships";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudidentity.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudIdentityMembership";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudIdentityMembershipSpec defines the desired state of CloudIdentityMembership</summary>
    [JsonPropertyName("spec")]
    public required V1beta1CloudIdentityMembershipSpec Spec { get; set; }

    /// <summary>CloudIdentityMembershipStatus defines the config connector machine state of CloudIdentityMembership</summary>
    [JsonPropertyName("status")]
    public V1beta1CloudIdentityMembershipStatus? Status { get; set; }
}