#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identitystore.aws.upbound.io;
/// <summary>User is the Schema for the Users API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2UserList : IKubernetesObject<V1ListMeta>, IItems<V1beta2User>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "UserList";
    public const string KubeGroup = "identitystore.aws.upbound.io";
    public const string KubePluralName = "users";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identitystore.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2User objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2User> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserSpecDeletionPolicyEnum>))]
public enum V1beta2UserSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Details about the user&apos;s address. At most 1 address is allowed. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecForProviderAddresses
{
    /// <summary>The country that this address is in.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>The name that is typically displayed when the address is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The address locality.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The postal code of the address.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>When true, this is the primary address associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The region of the address.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The street of the address.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>The type of address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details about the user&apos;s email. At most 1 email is allowed. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecForProviderEmails
{
    /// <summary>When true, this is the primary email associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of email.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The email address. This value must be unique across the identity store.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details about the user&apos;s full name. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecForProviderName
{
    /// <summary>The family name of the user.</summary>
    [JsonPropertyName("familyName")]
    public string? FamilyName { get; set; }

    /// <summary>The name that is typically displayed when the name is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The given name of the user.</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>The honorific prefix of the user.</summary>
    [JsonPropertyName("honorificPrefix")]
    public string? HonorificPrefix { get; set; }

    /// <summary>The honorific suffix of the user.</summary>
    [JsonPropertyName("honorificSuffix")]
    public string? HonorificSuffix { get; set; }

    /// <summary>The middle name of the user.</summary>
    [JsonPropertyName("middleName")]
    public string? MiddleName { get; set; }
}

/// <summary>Details about the user&apos;s phone number. At most 1 phone number is allowed. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecForProviderPhoneNumbers
{
    /// <summary>When true, this is the primary phone number associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of phone number.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user&apos;s phone number.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecForProvider
{
    /// <summary>Details about the user&apos;s address. At most 1 address is allowed. Detailed below.</summary>
    [JsonPropertyName("addresses")]
    public V1beta2UserSpecForProviderAddresses? Addresses { get; set; }

    /// <summary>The name that is typically displayed when the user is referenced.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Details about the user&apos;s email. At most 1 email is allowed. Detailed below.</summary>
    [JsonPropertyName("emails")]
    public V1beta2UserSpecForProviderEmails? Emails { get; set; }

    /// <summary>The globally unique identifier for the identity store that this user is in.</summary>
    [JsonPropertyName("identityStoreId")]
    public required string IdentityStoreId { get; set; }

    /// <summary>The user&apos;s geographical region or location.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Details about the user&apos;s full name. Detailed below.</summary>
    [JsonPropertyName("name")]
    public V1beta2UserSpecForProviderName? Name { get; set; }

    /// <summary>An alternate name for the user.</summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>Details about the user&apos;s phone number. At most 1 phone number is allowed. Detailed below.</summary>
    [JsonPropertyName("phoneNumbers")]
    public V1beta2UserSpecForProviderPhoneNumbers? PhoneNumbers { get; set; }

    /// <summary>The preferred language of the user.</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>An URL that may be associated with the user.</summary>
    [JsonPropertyName("profileUrl")]
    public string? ProfileUrl { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The user&apos;s time zone.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The user&apos;s title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A unique string used to identify the user. This value can consist of letters, accented characters, symbols, numbers, and punctuation. This value is specified at the time the user is created and stored as an attribute of the user object in the identity store. The limit is 128 characters.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>The user type.</summary>
    [JsonPropertyName("userType")]
    public string? UserType { get; set; }
}

/// <summary>Details about the user&apos;s address. At most 1 address is allowed. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecInitProviderAddresses
{
    /// <summary>The country that this address is in.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>The name that is typically displayed when the address is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The address locality.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The postal code of the address.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>When true, this is the primary address associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The street of the address.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>The type of address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details about the user&apos;s email. At most 1 email is allowed. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecInitProviderEmails
{
    /// <summary>When true, this is the primary email associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of email.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The email address. This value must be unique across the identity store.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Details about the user&apos;s full name. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecInitProviderName
{
    /// <summary>The family name of the user.</summary>
    [JsonPropertyName("familyName")]
    public string? FamilyName { get; set; }

    /// <summary>The name that is typically displayed when the name is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The given name of the user.</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>The honorific prefix of the user.</summary>
    [JsonPropertyName("honorificPrefix")]
    public string? HonorificPrefix { get; set; }

    /// <summary>The honorific suffix of the user.</summary>
    [JsonPropertyName("honorificSuffix")]
    public string? HonorificSuffix { get; set; }

    /// <summary>The middle name of the user.</summary>
    [JsonPropertyName("middleName")]
    public string? MiddleName { get; set; }
}

/// <summary>Details about the user&apos;s phone number. At most 1 phone number is allowed. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecInitProviderPhoneNumbers
{
    /// <summary>When true, this is the primary phone number associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of phone number.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user&apos;s phone number.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
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
public partial class V1beta2UserSpecInitProvider
{
    /// <summary>Details about the user&apos;s address. At most 1 address is allowed. Detailed below.</summary>
    [JsonPropertyName("addresses")]
    public V1beta2UserSpecInitProviderAddresses? Addresses { get; set; }

    /// <summary>The name that is typically displayed when the user is referenced.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Details about the user&apos;s email. At most 1 email is allowed. Detailed below.</summary>
    [JsonPropertyName("emails")]
    public V1beta2UserSpecInitProviderEmails? Emails { get; set; }

    /// <summary>The user&apos;s geographical region or location.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Details about the user&apos;s full name. Detailed below.</summary>
    [JsonPropertyName("name")]
    public V1beta2UserSpecInitProviderName? Name { get; set; }

    /// <summary>An alternate name for the user.</summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>Details about the user&apos;s phone number. At most 1 phone number is allowed. Detailed below.</summary>
    [JsonPropertyName("phoneNumbers")]
    public V1beta2UserSpecInitProviderPhoneNumbers? PhoneNumbers { get; set; }

    /// <summary>The preferred language of the user.</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>An URL that may be associated with the user.</summary>
    [JsonPropertyName("profileUrl")]
    public string? ProfileUrl { get; set; }

    /// <summary>The user&apos;s time zone.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The user&apos;s title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A unique string used to identify the user. This value can consist of letters, accented characters, symbols, numbers, and punctuation. This value is specified at the time the user is created and stored as an attribute of the user object in the identity store. The limit is 128 characters.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>The user type.</summary>
    [JsonPropertyName("userType")]
    public string? UserType { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserSpecManagementPoliciesEnum>))]
public enum V1beta2UserSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2UserSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2UserSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>UserSpec defines the desired state of User</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserSpec
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
    public V1beta2UserSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2UserSpecForProvider ForProvider { get; set; }

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
    public V1beta2UserSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2UserSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2UserSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2UserSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Details about the user&apos;s address. At most 1 address is allowed. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserStatusAtProviderAddresses
{
    /// <summary>The country that this address is in.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>The name that is typically displayed when the address is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The address locality.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The postal code of the address.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>When true, this is the primary address associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The region of the address.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The street of the address.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>The type of address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Details about the user&apos;s email. At most 1 email is allowed. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserStatusAtProviderEmails
{
    /// <summary>When true, this is the primary email associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of email.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The email address. This value must be unique across the identity store.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserStatusAtProviderExternalIds
{
    /// <summary>The identifier issued to this resource by an external identity provider.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The issuer for an external identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Details about the user&apos;s full name. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserStatusAtProviderName
{
    /// <summary>The family name of the user.</summary>
    [JsonPropertyName("familyName")]
    public string? FamilyName { get; set; }

    /// <summary>The name that is typically displayed when the name is shown for display.</summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>The given name of the user.</summary>
    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    /// <summary>The honorific prefix of the user.</summary>
    [JsonPropertyName("honorificPrefix")]
    public string? HonorificPrefix { get; set; }

    /// <summary>The honorific suffix of the user.</summary>
    [JsonPropertyName("honorificSuffix")]
    public string? HonorificSuffix { get; set; }

    /// <summary>The middle name of the user.</summary>
    [JsonPropertyName("middleName")]
    public string? MiddleName { get; set; }
}

/// <summary>Details about the user&apos;s phone number. At most 1 phone number is allowed. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserStatusAtProviderPhoneNumbers
{
    /// <summary>When true, this is the primary phone number associated with the user.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The type of phone number.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The user&apos;s phone number.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserStatusAtProvider
{
    /// <summary>Details about the user&apos;s address. At most 1 address is allowed. Detailed below.</summary>
    [JsonPropertyName("addresses")]
    public V1beta2UserStatusAtProviderAddresses? Addresses { get; set; }

    /// <summary>The name that is typically displayed when the user is referenced.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Details about the user&apos;s email. At most 1 email is allowed. Detailed below.</summary>
    [JsonPropertyName("emails")]
    public V1beta2UserStatusAtProviderEmails? Emails { get; set; }

    /// <summary>A list of identifiers issued to this resource by an external identity provider.</summary>
    [JsonPropertyName("externalIds")]
    public IList<V1beta2UserStatusAtProviderExternalIds>? ExternalIds { get; set; }

    /// <summary>The identifier issued to this resource by an external identity provider.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The globally unique identifier for the identity store that this user is in.</summary>
    [JsonPropertyName("identityStoreId")]
    public string? IdentityStoreId { get; set; }

    /// <summary>The user&apos;s geographical region or location.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Details about the user&apos;s full name. Detailed below.</summary>
    [JsonPropertyName("name")]
    public V1beta2UserStatusAtProviderName? Name { get; set; }

    /// <summary>An alternate name for the user.</summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>Details about the user&apos;s phone number. At most 1 phone number is allowed. Detailed below.</summary>
    [JsonPropertyName("phoneNumbers")]
    public V1beta2UserStatusAtProviderPhoneNumbers? PhoneNumbers { get; set; }

    /// <summary>The preferred language of the user.</summary>
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage { get; set; }

    /// <summary>An URL that may be associated with the user.</summary>
    [JsonPropertyName("profileUrl")]
    public string? ProfileUrl { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The user&apos;s time zone.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>The user&apos;s title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>The identifier for this user in the identity store.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>A unique string used to identify the user. This value can consist of letters, accented characters, symbols, numbers, and punctuation. This value is specified at the time the user is created and stored as an attribute of the user object in the identity store. The limit is 128 characters.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>The user type.</summary>
    [JsonPropertyName("userType")]
    public string? UserType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserStatusConditions
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

/// <summary>UserStatus defines the observed state of User.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2UserStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2UserStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>User is the Schema for the Users API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2User : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2UserSpec>, IStatus<V1beta2UserStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "User";
    public const string KubeGroup = "identitystore.aws.upbound.io";
    public const string KubePluralName = "users";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identitystore.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "User";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserSpec defines the desired state of User</summary>
    [JsonPropertyName("spec")]
    public required V1beta2UserSpec Spec { get; set; }

    /// <summary>UserStatus defines the observed state of User.</summary>
    [JsonPropertyName("status")]
    public V1beta2UserStatus? Status { get; set; }
}