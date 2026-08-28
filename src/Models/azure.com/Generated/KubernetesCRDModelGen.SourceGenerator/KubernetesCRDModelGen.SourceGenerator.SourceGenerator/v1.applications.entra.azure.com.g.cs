#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.entra.azure.com;
/// <summary>Application is an Entra Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1Application>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "entra.azure.com";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "entra.azure.com/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Application objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Application> Items { get; set; }
}

/// <summary>AppId: The application (client) ID of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationSpecOperatorSpecConfigmapsAppId
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>EntraID: The Entra ID (object ID) of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationSpecOperatorSpecConfigmapsEntraID
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps specifies any config maps that should be created by the operator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationSpecOperatorSpecConfigmaps
{
    /// <summary>AppId: The application (client) ID of the application.</summary>
    [JsonPropertyName("appId")]
    public V1ApplicationSpecOperatorSpecConfigmapsAppId? AppId { get; set; }

    /// <summary>EntraID: The Entra ID (object ID) of the application.</summary>
    [JsonPropertyName("entraID")]
    public V1ApplicationSpecOperatorSpecConfigmapsEntraID? EntraID { get; set; }
}

/// <summary>
/// CreationMode: Specifies how ASO will try to create the resource.
/// Specify &quot;AlwaysCreate&quot; to always create a new application when first reconciled.
/// Or specify &quot;AdoptOrCreate&quot; to first try to adopt an existing application with the same display name.
/// If multiple applications with the same display name are found, the resource ready condition will show an error.
/// If not specified, defaults to &quot;AdoptOrCreate&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ApplicationSpecOperatorSpecCreationModeEnum>))]
public enum V1ApplicationSpecOperatorSpecCreationModeEnum
{
    [EnumMember(Value = "AdoptOrCreate"), JsonStringEnumMemberName("AdoptOrCreate")]
    AdoptOrCreate,
    [EnumMember(Value = "AlwaysCreate"), JsonStringEnumMemberName("AlwaysCreate")]
    AlwaysCreate
}

/// <summary>OperatorSpec: The operator specific configuration for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationSpecOperatorSpec
{
    /// <summary>ConfigMaps specifies any config maps that should be created by the operator.</summary>
    [JsonPropertyName("configmaps")]
    public V1ApplicationSpecOperatorSpecConfigmaps? Configmaps { get; set; }

    /// <summary>
    /// CreationMode: Specifies how ASO will try to create the resource.
    /// Specify &quot;AlwaysCreate&quot; to always create a new application when first reconciled.
    /// Or specify &quot;AdoptOrCreate&quot; to first try to adopt an existing application with the same display name.
    /// If multiple applications with the same display name are found, the resource ready condition will show an error.
    /// If not specified, defaults to &quot;AdoptOrCreate&quot;.
    /// </summary>
    [JsonPropertyName("creationMode")]
    public V1ApplicationSpecOperatorSpecCreationModeEnum? CreationMode { get; set; }
}

/// <summary>PublicClient: Public client (desktop/mobile) platform configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationSpecPublicClient
{
    /// <summary>RedirectUris: Redirect URIs for public client applications.</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary>SignInAudience: Specifies the Microsoft accounts that are supported for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ApplicationSpecSignInAudienceEnum>))]
public enum V1ApplicationSpecSignInAudienceEnum
{
    [EnumMember(Value = "AzureADMyOrg"), JsonStringEnumMemberName("AzureADMyOrg")]
    AzureADMyOrg,
    [EnumMember(Value = "AzureADMultipleOrgs"), JsonStringEnumMemberName("AzureADMultipleOrgs")]
    AzureADMultipleOrgs,
    [EnumMember(Value = "AzureADandPersonalMicrosoftAccount"), JsonStringEnumMemberName("AzureADandPersonalMicrosoftAccount")]
    AzureADandPersonalMicrosoftAccount,
    [EnumMember(Value = "PersonalMicrosoftAccount"), JsonStringEnumMemberName("PersonalMicrosoftAccount")]
    PersonalMicrosoftAccount
}

/// <summary>Spa: Single-page application platform configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationSpecSpa
{
    /// <summary>RedirectUris: Redirect URIs for single-page applications.</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary>ImplicitGrantSettings: Settings for implicit grant flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationSpecWebImplicitGrantSettings
{
    /// <summary>EnableAccessTokenIssuance: Whether to enable access token issuance in the implicit flow.</summary>
    [JsonPropertyName("enableAccessTokenIssuance")]
    public bool? EnableAccessTokenIssuance { get; set; }

    /// <summary>EnableIdTokenIssuance: Whether to enable ID token issuance in the implicit flow.</summary>
    [JsonPropertyName("enableIdTokenIssuance")]
    public bool? EnableIdTokenIssuance { get; set; }
}

/// <summary>Web: Web platform configuration for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationSpecWeb
{
    /// <summary>ImplicitGrantSettings: Settings for implicit grant flow.</summary>
    [JsonPropertyName("implicitGrantSettings")]
    public V1ApplicationSpecWebImplicitGrantSettings? ImplicitGrantSettings { get; set; }

    /// <summary>RedirectUris: Redirect URIs for web applications.</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationSpec
{
    /// <summary>Description: The description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: The display name of the application.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>GroupMembershipClaims: Configures the groups claim issued in a user or OAuth 2.0 access token.</summary>
    [JsonPropertyName("groupMembershipClaims")]
    public string? GroupMembershipClaims { get; set; }

    /// <summary>IdentifierUris: The URIs that identify the application within its Azure AD tenant, or within a verified custom domain.</summary>
    [JsonPropertyName("identifierUris")]
    public IList<string>? IdentifierUris { get; set; }

    /// <summary>IsFallbackPublicClient: Specifies the fallback application type as public client.</summary>
    [JsonPropertyName("isFallbackPublicClient")]
    public bool? IsFallbackPublicClient { get; set; }

    /// <summary>OperatorSpec: The operator specific configuration for the resource.</summary>
    [JsonPropertyName("operatorSpec")]
    public V1ApplicationSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>PublicClient: Public client (desktop/mobile) platform configuration.</summary>
    [JsonPropertyName("publicClient")]
    public V1ApplicationSpecPublicClient? PublicClient { get; set; }

    /// <summary>SignInAudience: Specifies the Microsoft accounts that are supported for the application.</summary>
    [JsonPropertyName("signInAudience")]
    public V1ApplicationSpecSignInAudienceEnum? SignInAudience { get; set; }

    /// <summary>Spa: Single-page application platform configuration.</summary>
    [JsonPropertyName("spa")]
    public V1ApplicationSpecSpa? Spa { get; set; }

    /// <summary>Tags: Custom strings for categorizing and identifying the application.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Web: Web platform configuration for the application.</summary>
    [JsonPropertyName("web")]
    public V1ApplicationSpecWeb? Web { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>PublicClient: Public client (desktop/mobile) platform configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationStatusPublicClient
{
    /// <summary>RedirectUris: Redirect URIs for public client applications.</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary>SignInAudience: Specifies the Microsoft accounts that are supported for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ApplicationStatusSignInAudienceEnum>))]
public enum V1ApplicationStatusSignInAudienceEnum
{
    [EnumMember(Value = "AzureADMyOrg"), JsonStringEnumMemberName("AzureADMyOrg")]
    AzureADMyOrg,
    [EnumMember(Value = "AzureADMultipleOrgs"), JsonStringEnumMemberName("AzureADMultipleOrgs")]
    AzureADMultipleOrgs,
    [EnumMember(Value = "AzureADandPersonalMicrosoftAccount"), JsonStringEnumMemberName("AzureADandPersonalMicrosoftAccount")]
    AzureADandPersonalMicrosoftAccount,
    [EnumMember(Value = "PersonalMicrosoftAccount"), JsonStringEnumMemberName("PersonalMicrosoftAccount")]
    PersonalMicrosoftAccount
}

/// <summary>Spa: Single-page application platform configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationStatusSpa
{
    /// <summary>RedirectUris: Redirect URIs for single-page applications.</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

/// <summary>ImplicitGrantSettings: Settings for implicit grant flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationStatusWebImplicitGrantSettings
{
    /// <summary>EnableAccessTokenIssuance: Whether to enable access token issuance in the implicit flow.</summary>
    [JsonPropertyName("enableAccessTokenIssuance")]
    public bool? EnableAccessTokenIssuance { get; set; }

    /// <summary>EnableIdTokenIssuance: Whether to enable ID token issuance in the implicit flow.</summary>
    [JsonPropertyName("enableIdTokenIssuance")]
    public bool? EnableIdTokenIssuance { get; set; }
}

/// <summary>Web: Web platform configuration for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationStatusWeb
{
    /// <summary>ImplicitGrantSettings: Settings for implicit grant flow.</summary>
    [JsonPropertyName("implicitGrantSettings")]
    public V1ApplicationStatusWebImplicitGrantSettings? ImplicitGrantSettings { get; set; }

    /// <summary>RedirectUris: Redirect URIs for web applications.</summary>
    [JsonPropertyName("redirectUris")]
    public IList<string>? RedirectUris { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ApplicationStatus
{
    /// <summary>AppId: The application ID assigned by Entra.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>Description: The description of the application.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: The display name of the application.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>EntraID: The GUID identifying the resource in Entra</summary>
    [JsonPropertyName("entraID")]
    public string? EntraID { get; set; }

    /// <summary>GroupMembershipClaims: Configures the groups claim issued in a user or OAuth 2.0 access token.</summary>
    [JsonPropertyName("groupMembershipClaims")]
    public string? GroupMembershipClaims { get; set; }

    /// <summary>IdentifierUris: The URIs that identify the application within its Azure AD tenant, or within a verified custom domain.</summary>
    [JsonPropertyName("identifierUris")]
    public IList<string>? IdentifierUris { get; set; }

    /// <summary>IsFallbackPublicClient: Specifies the fallback application type as public client.</summary>
    [JsonPropertyName("isFallbackPublicClient")]
    public bool? IsFallbackPublicClient { get; set; }

    /// <summary>PublicClient: Public client (desktop/mobile) platform configuration.</summary>
    [JsonPropertyName("publicClient")]
    public V1ApplicationStatusPublicClient? PublicClient { get; set; }

    /// <summary>SignInAudience: Specifies the Microsoft accounts that are supported for the application.</summary>
    [JsonPropertyName("signInAudience")]
    public V1ApplicationStatusSignInAudienceEnum? SignInAudience { get; set; }

    /// <summary>Spa: Single-page application platform configuration.</summary>
    [JsonPropertyName("spa")]
    public V1ApplicationStatusSpa? Spa { get; set; }

    /// <summary>Tags: Custom strings for categorizing and identifying the application.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Web: Web platform configuration for the application.</summary>
    [JsonPropertyName("web")]
    public V1ApplicationStatusWeb? Web { get; set; }
}

/// <summary>Application is an Entra Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1ApplicationSpec?>, IStatus<V1ApplicationStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Application";
    public const string KubeGroup = "entra.azure.com";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "entra.azure.com/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Application";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1ApplicationSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1ApplicationStatus? Status { get; set; }
}