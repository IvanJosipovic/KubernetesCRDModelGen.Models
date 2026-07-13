#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.groups.azuread.upbound.io;
/// <summary>Group is the Schema for the Groups API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2GroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Group>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "GroupList";
    public const string KubeGroup = "groups.azuread.upbound.io";
    public const string KubePluralName = "groups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "groups.azuread.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Group objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Group> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecDeletionPolicyEnum>))]
public enum V1beta2GroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// A dynamic_membership block as documented below. Required when types contains DynamicMembership. Cannot be used with the members property.
/// An optional block to configure dynamic membership for the group. Cannot be used with `members`
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecForProviderDynamicMembership
{
    /// <summary>Whether rule processing is &quot;On&quot; (true) or &quot;Paused&quot; (false).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The rule that determines membership of this group. For more information, see official documentation on membership rules syntax.
    /// Rule to determine members for a dynamic group. Required when `group_types` contains &apos;DynamicMembership&apos;
    /// </summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecForProviderMembersRefsPolicyResolutionEnum>))]
public enum V1beta2GroupSpecForProviderMembersRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecForProviderMembersRefsPolicyResolveEnum>))]
public enum V1beta2GroupSpecForProviderMembersRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecForProviderMembersRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GroupSpecForProviderMembersRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GroupSpecForProviderMembersRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecForProviderMembersRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GroupSpecForProviderMembersRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecForProviderMembersSelectorPolicyResolutionEnum>))]
public enum V1beta2GroupSpecForProviderMembersSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecForProviderMembersSelectorPolicyResolveEnum>))]
public enum V1beta2GroupSpecForProviderMembersSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecForProviderMembersSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GroupSpecForProviderMembersSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GroupSpecForProviderMembersSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of User in users to populate members.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecForProviderMembersSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GroupSpecForProviderMembersSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecForProvider
{
    /// <summary>
    /// The object IDs of administrative units in which the group is a member. If specified, new groups will be created in the scope of the first administrative unit and added to the others. If empty, new groups will be created at the tenant level.
    /// The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.
    /// </summary>
    [JsonPropertyName("administrativeUnitIds")]
    public IList<string>? AdministrativeUnitIds { get; set; }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. Defaults to false. Can only be set to true for security-enabled groups. Changing this forces a new resource to be created.
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    [JsonPropertyName("assignableToRole")]
    public bool? AssignableToRole { get; set; }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications. Can only be set for Unified groups.
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    [JsonPropertyName("autoSubscribeNewMembers")]
    public bool? AutoSubscribeNewMembers { get; set; }

    /// <summary>
    /// A set of behaviors for a Microsoft 365 group. Possible values are AllowOnlyMembersToPost, HideGroupInOutlook, SkipExchangeInstantOn, SubscribeMembersToCalendarEventsDisabled, SubscribeNewGroupMembers and WelcomeEmailDisabled. See official documentation for more details. Changing this forces a new resource to be created.
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IList<string>? Behaviors { get; set; }

    /// <summary>
    /// The description for the group.
    /// The description for the group
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The display name for the group.
    /// The display name for the group
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// A dynamic_membership block as documented below. Required when types contains DynamicMembership. Cannot be used with the members property.
    /// An optional block to configure dynamic membership for the group. Cannot be used with `members`
    /// </summary>
    [JsonPropertyName("dynamicMembership")]
    public V1beta2GroupSpecForProviderDynamicMembership? DynamicMembership { get; set; }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group. Can only be set for Unified groups.
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    [JsonPropertyName("externalSendersAllowed")]
    public bool? ExternalSendersAllowed { get; set; }

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups. Can only be set for Unified groups.
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    [JsonPropertyName("hideFromAddressLists")]
    public bool? HideFromAddressLists { get; set; }

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web. Can only be set for Unified groups.
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    [JsonPropertyName("hideFromOutlookClients")]
    public bool? HideFromOutlookClients { get; set; }

    /// <summary>
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of mail_enabled or security_enabled must be specified. Only Microsoft 365 groups can be mail enabled (see the types property).
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    [JsonPropertyName("mailEnabled")]
    public bool? MailEnabled { get; set; }

    /// <summary>
    /// The mail alias for the group, unique in the organisation. Required for mail-enabled groups. Changing this forces a new resource to be created.
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    [JsonPropertyName("mailNickname")]
    public string? MailNickname { get; set; }

    /// <summary>
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals. Cannot be used with the dynamic_membership block.
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>References to User in users to populate members.</summary>
    [JsonPropertyName("membersRefs")]
    public IList<V1beta2GroupSpecForProviderMembersRefs>? MembersRefs { get; set; }

    /// <summary>Selector for a list of User in users to populate members.</summary>
    [JsonPropertyName("membersSelector")]
    public V1beta2GroupSpecForProviderMembersSelector? MembersSelector { get; set; }

    /// <summary>
    /// The on-premises group type that the AAD group will be written as, when writeback is enabled. Possible values are UniversalDistributionGroup, UniversalMailEnabledSecurityGroup, or UniversalSecurityGroup.
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    [JsonPropertyName("onpremisesGroupType")]
    public string? OnpremisesGroupType { get; set; }

    /// <summary>
    /// A set of object IDs of principals that will be granted ownership of the group. Supported object types are users or service principals. Groups cannot be created with no owners or have all their owners removed.
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>
    /// If true, will return an error if an existing group is found with the same name. Defaults to false.
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }

    /// <summary>
    /// A set of provisioning options for a Microsoft 365 group. The only supported value is Team. See official documentation for details. Changing this forces a new resource to be created.
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    [JsonPropertyName("provisioningOptions")]
    public IList<string>? ProvisioningOptions { get; set; }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of security_enabled or mail_enabled must be specified. A Microsoft 365 group can be security enabled and mail enabled (see the types property).
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    [JsonPropertyName("securityEnabled")]
    public bool? SecurityEnabled { get; set; }

    /// <summary>
    /// The colour theme for a Microsoft 365 group. Possible values are Blue, Green, Orange, Pink, Purple, Red or Teal. By default, no theme is set.
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    /// <summary>
    /// A set of group types to configure for the group. Supported values are DynamicMembership, which denotes a group with dynamic membership, and Unified, which specifies a Microsoft 365 group. Required when mail_enabled is true. Changing this forces a new resource to be created.
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    /// <summary>
    /// The group join policy and group content visibility. Possible values are Private, Public, or Hiddenmembership. Only Microsoft 365 groups can have Hiddenmembership visibility and this value must be set when the group is created. By default, security groups will receive Private visibility and Microsoft 365 groups will receive Public visibility.
    /// Specifies the group join policy and group content visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>
    /// Whether the group will be written back to the configured on-premises Active Directory when Azure AD Connect is used.
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    [JsonPropertyName("writebackEnabled")]
    public bool? WritebackEnabled { get; set; }
}

/// <summary>
/// A dynamic_membership block as documented below. Required when types contains DynamicMembership. Cannot be used with the members property.
/// An optional block to configure dynamic membership for the group. Cannot be used with `members`
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecInitProviderDynamicMembership
{
    /// <summary>Whether rule processing is &quot;On&quot; (true) or &quot;Paused&quot; (false).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The rule that determines membership of this group. For more information, see official documentation on membership rules syntax.
    /// Rule to determine members for a dynamic group. Required when `group_types` contains &apos;DynamicMembership&apos;
    /// </summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecInitProviderMembersRefsPolicyResolutionEnum>))]
public enum V1beta2GroupSpecInitProviderMembersRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecInitProviderMembersRefsPolicyResolveEnum>))]
public enum V1beta2GroupSpecInitProviderMembersRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecInitProviderMembersRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GroupSpecInitProviderMembersRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GroupSpecInitProviderMembersRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecInitProviderMembersRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GroupSpecInitProviderMembersRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecInitProviderMembersSelectorPolicyResolutionEnum>))]
public enum V1beta2GroupSpecInitProviderMembersSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecInitProviderMembersSelectorPolicyResolveEnum>))]
public enum V1beta2GroupSpecInitProviderMembersSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecInitProviderMembersSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GroupSpecInitProviderMembersSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GroupSpecInitProviderMembersSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of User in users to populate members.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecInitProviderMembersSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GroupSpecInitProviderMembersSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2GroupSpecInitProvider
{
    /// <summary>
    /// The object IDs of administrative units in which the group is a member. If specified, new groups will be created in the scope of the first administrative unit and added to the others. If empty, new groups will be created at the tenant level.
    /// The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.
    /// </summary>
    [JsonPropertyName("administrativeUnitIds")]
    public IList<string>? AdministrativeUnitIds { get; set; }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. Defaults to false. Can only be set to true for security-enabled groups. Changing this forces a new resource to be created.
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    [JsonPropertyName("assignableToRole")]
    public bool? AssignableToRole { get; set; }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications. Can only be set for Unified groups.
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    [JsonPropertyName("autoSubscribeNewMembers")]
    public bool? AutoSubscribeNewMembers { get; set; }

    /// <summary>
    /// A set of behaviors for a Microsoft 365 group. Possible values are AllowOnlyMembersToPost, HideGroupInOutlook, SkipExchangeInstantOn, SubscribeMembersToCalendarEventsDisabled, SubscribeNewGroupMembers and WelcomeEmailDisabled. See official documentation for more details. Changing this forces a new resource to be created.
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IList<string>? Behaviors { get; set; }

    /// <summary>
    /// The description for the group.
    /// The description for the group
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The display name for the group.
    /// The display name for the group
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// A dynamic_membership block as documented below. Required when types contains DynamicMembership. Cannot be used with the members property.
    /// An optional block to configure dynamic membership for the group. Cannot be used with `members`
    /// </summary>
    [JsonPropertyName("dynamicMembership")]
    public V1beta2GroupSpecInitProviderDynamicMembership? DynamicMembership { get; set; }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group. Can only be set for Unified groups.
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    [JsonPropertyName("externalSendersAllowed")]
    public bool? ExternalSendersAllowed { get; set; }

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups. Can only be set for Unified groups.
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    [JsonPropertyName("hideFromAddressLists")]
    public bool? HideFromAddressLists { get; set; }

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web. Can only be set for Unified groups.
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    [JsonPropertyName("hideFromOutlookClients")]
    public bool? HideFromOutlookClients { get; set; }

    /// <summary>
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of mail_enabled or security_enabled must be specified. Only Microsoft 365 groups can be mail enabled (see the types property).
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    [JsonPropertyName("mailEnabled")]
    public bool? MailEnabled { get; set; }

    /// <summary>
    /// The mail alias for the group, unique in the organisation. Required for mail-enabled groups. Changing this forces a new resource to be created.
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    [JsonPropertyName("mailNickname")]
    public string? MailNickname { get; set; }

    /// <summary>
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals. Cannot be used with the dynamic_membership block.
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>References to User in users to populate members.</summary>
    [JsonPropertyName("membersRefs")]
    public IList<V1beta2GroupSpecInitProviderMembersRefs>? MembersRefs { get; set; }

    /// <summary>Selector for a list of User in users to populate members.</summary>
    [JsonPropertyName("membersSelector")]
    public V1beta2GroupSpecInitProviderMembersSelector? MembersSelector { get; set; }

    /// <summary>
    /// The on-premises group type that the AAD group will be written as, when writeback is enabled. Possible values are UniversalDistributionGroup, UniversalMailEnabledSecurityGroup, or UniversalSecurityGroup.
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    [JsonPropertyName("onpremisesGroupType")]
    public string? OnpremisesGroupType { get; set; }

    /// <summary>
    /// A set of object IDs of principals that will be granted ownership of the group. Supported object types are users or service principals. Groups cannot be created with no owners or have all their owners removed.
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>
    /// If true, will return an error if an existing group is found with the same name. Defaults to false.
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }

    /// <summary>
    /// A set of provisioning options for a Microsoft 365 group. The only supported value is Team. See official documentation for details. Changing this forces a new resource to be created.
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    [JsonPropertyName("provisioningOptions")]
    public IList<string>? ProvisioningOptions { get; set; }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of security_enabled or mail_enabled must be specified. A Microsoft 365 group can be security enabled and mail enabled (see the types property).
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    [JsonPropertyName("securityEnabled")]
    public bool? SecurityEnabled { get; set; }

    /// <summary>
    /// The colour theme for a Microsoft 365 group. Possible values are Blue, Green, Orange, Pink, Purple, Red or Teal. By default, no theme is set.
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    /// <summary>
    /// A set of group types to configure for the group. Supported values are DynamicMembership, which denotes a group with dynamic membership, and Unified, which specifies a Microsoft 365 group. Required when mail_enabled is true. Changing this forces a new resource to be created.
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    /// <summary>
    /// The group join policy and group content visibility. Possible values are Private, Public, or Hiddenmembership. Only Microsoft 365 groups can have Hiddenmembership visibility and this value must be set when the group is created. By default, security groups will receive Private visibility and Microsoft 365 groups will receive Public visibility.
    /// Specifies the group join policy and group content visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>
    /// Whether the group will be written back to the configured on-premises Active Directory when Azure AD Connect is used.
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    [JsonPropertyName("writebackEnabled")]
    public bool? WritebackEnabled { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecManagementPoliciesEnum>))]
public enum V1beta2GroupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2GroupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GroupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2GroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>GroupSpec defines the desired state of Group</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupSpec
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
    public V1beta2GroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2GroupSpecForProvider ForProvider { get; set; }

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
    public V1beta2GroupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2GroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2GroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2GroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// A dynamic_membership block as documented below. Required when types contains DynamicMembership. Cannot be used with the members property.
/// An optional block to configure dynamic membership for the group. Cannot be used with `members`
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupStatusAtProviderDynamicMembership
{
    /// <summary>Whether rule processing is &quot;On&quot; (true) or &quot;Paused&quot; (false).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The rule that determines membership of this group. For more information, see official documentation on membership rules syntax.
    /// Rule to determine members for a dynamic group. Required when `group_types` contains &apos;DynamicMembership&apos;
    /// </summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupStatusAtProvider
{
    /// <summary>
    /// The object IDs of administrative units in which the group is a member. If specified, new groups will be created in the scope of the first administrative unit and added to the others. If empty, new groups will be created at the tenant level.
    /// The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.
    /// </summary>
    [JsonPropertyName("administrativeUnitIds")]
    public IList<string>? AdministrativeUnitIds { get; set; }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. Defaults to false. Can only be set to true for security-enabled groups. Changing this forces a new resource to be created.
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    [JsonPropertyName("assignableToRole")]
    public bool? AssignableToRole { get; set; }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications. Can only be set for Unified groups.
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    [JsonPropertyName("autoSubscribeNewMembers")]
    public bool? AutoSubscribeNewMembers { get; set; }

    /// <summary>
    /// A set of behaviors for a Microsoft 365 group. Possible values are AllowOnlyMembersToPost, HideGroupInOutlook, SkipExchangeInstantOn, SubscribeMembersToCalendarEventsDisabled, SubscribeNewGroupMembers and WelcomeEmailDisabled. See official documentation for more details. Changing this forces a new resource to be created.
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IList<string>? Behaviors { get; set; }

    /// <summary>
    /// The description for the group.
    /// The description for the group
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The display name for the group.
    /// The display name for the group
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// A dynamic_membership block as documented below. Required when types contains DynamicMembership. Cannot be used with the members property.
    /// An optional block to configure dynamic membership for the group. Cannot be used with `members`
    /// </summary>
    [JsonPropertyName("dynamicMembership")]
    public V1beta2GroupStatusAtProviderDynamicMembership? DynamicMembership { get; set; }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group. Can only be set for Unified groups.
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    [JsonPropertyName("externalSendersAllowed")]
    public bool? ExternalSendersAllowed { get; set; }

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups. Can only be set for Unified groups.
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    [JsonPropertyName("hideFromAddressLists")]
    public bool? HideFromAddressLists { get; set; }

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web. Can only be set for Unified groups.
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    [JsonPropertyName("hideFromOutlookClients")]
    public bool? HideFromOutlookClients { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The SMTP address for the group.
    /// The SMTP address for the group
    /// </summary>
    [JsonPropertyName("mail")]
    public string? Mail { get; set; }

    /// <summary>
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of mail_enabled or security_enabled must be specified. Only Microsoft 365 groups can be mail enabled (see the types property).
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    [JsonPropertyName("mailEnabled")]
    public bool? MailEnabled { get; set; }

    /// <summary>
    /// The mail alias for the group, unique in the organisation. Required for mail-enabled groups. Changing this forces a new resource to be created.
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    [JsonPropertyName("mailNickname")]
    public string? MailNickname { get; set; }

    /// <summary>
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals. Cannot be used with the dynamic_membership block.
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>
    /// The object ID of the group.
    /// The object ID of the group
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronised from the on-premises directory when Azure AD Connect is used.
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [JsonPropertyName("onpremisesDomainName")]
    public string? OnpremisesDomainName { get; set; }

    /// <summary>
    /// The on-premises group type that the AAD group will be written as, when writeback is enabled. Possible values are UniversalDistributionGroup, UniversalMailEnabledSecurityGroup, or UniversalSecurityGroup.
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    [JsonPropertyName("onpremisesGroupType")]
    public string? OnpremisesGroupType { get; set; }

    /// <summary>
    /// The on-premises NetBIOS name, synchronised from the on-premises directory when Azure AD Connect is used.
    /// The on-premises NetBIOS name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [JsonPropertyName("onpremisesNetbiosName")]
    public string? OnpremisesNetbiosName { get; set; }

    /// <summary>
    /// The on-premises SAM account name, synchronised from the on-premises directory when Azure AD Connect is used.
    /// The on-premises SAM account name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [JsonPropertyName("onpremisesSamAccountName")]
    public string? OnpremisesSamAccountName { get; set; }

    /// <summary>
    /// The on-premises security identifier (SID), synchronised from the on-premises directory when Azure AD Connect is used.
    /// The on-premises security identifier (SID), synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [JsonPropertyName("onpremisesSecurityIdentifier")]
    public string? OnpremisesSecurityIdentifier { get; set; }

    /// <summary>
    /// Whether this group is synchronised from an on-premises directory (true), no longer synchronised (false), or has never been synchronised (null).
    /// Whether this group is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    [JsonPropertyName("onpremisesSyncEnabled")]
    public bool? OnpremisesSyncEnabled { get; set; }

    /// <summary>
    /// A set of object IDs of principals that will be granted ownership of the group. Supported object types are users or service principals. Groups cannot be created with no owners or have all their owners removed.
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    [JsonPropertyName("owners")]
    public IList<string>? Owners { get; set; }

    /// <summary>
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation.
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>
    /// If true, will return an error if an existing group is found with the same name. Defaults to false.
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }

    /// <summary>
    /// A set of provisioning options for a Microsoft 365 group. The only supported value is Team. See official documentation for details. Changing this forces a new resource to be created.
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    [JsonPropertyName("provisioningOptions")]
    public IList<string>? ProvisioningOptions { get; set; }

    /// <summary>
    /// List of email addresses for the group that direct to the same group mailbox.
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    [JsonPropertyName("proxyAddresses")]
    public IList<string>? ProxyAddresses { get; set; }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of security_enabled or mail_enabled must be specified. A Microsoft 365 group can be security enabled and mail enabled (see the types property).
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    [JsonPropertyName("securityEnabled")]
    public bool? SecurityEnabled { get; set; }

    /// <summary>
    /// The colour theme for a Microsoft 365 group. Possible values are Blue, Green, Orange, Pink, Purple, Red or Teal. By default, no theme is set.
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    [JsonPropertyName("theme")]
    public string? Theme { get; set; }

    /// <summary>
    /// A set of group types to configure for the group. Supported values are DynamicMembership, which denotes a group with dynamic membership, and Unified, which specifies a Microsoft 365 group. Required when mail_enabled is true. Changing this forces a new resource to be created.
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    /// <summary>
    /// The group join policy and group content visibility. Possible values are Private, Public, or Hiddenmembership. Only Microsoft 365 groups can have Hiddenmembership visibility and this value must be set when the group is created. By default, security groups will receive Private visibility and Microsoft 365 groups will receive Public visibility.
    /// Specifies the group join policy and group content visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>
    /// Whether the group will be written back to the configured on-premises Active Directory when Azure AD Connect is used.
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    [JsonPropertyName("writebackEnabled")]
    public bool? WritebackEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GroupStatusConditions
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
public partial class V1beta2GroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2GroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2GroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Group is the Schema for the Groups API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Group : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2GroupSpec>, IStatus<V1beta2GroupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Group";
    public const string KubeGroup = "groups.azuread.upbound.io";
    public const string KubePluralName = "groups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "groups.azuread.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Group";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GroupSpec defines the desired state of Group</summary>
    [JsonPropertyName("spec")]
    public required V1beta2GroupSpec Spec { get; set; }

    /// <summary>GroupStatus defines the observed state of Group.</summary>
    [JsonPropertyName("status")]
    public V1beta2GroupStatus? Status { get; set; }
}