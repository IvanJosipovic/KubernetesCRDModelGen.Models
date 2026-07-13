#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>APIPortal defines a developer portal for accessing the documentation of APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIPortalList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIPortal>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPortalList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiportals";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIPortalList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIPortal objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIPortal> Items { get; set; }
}

/// <summary>Auth references the APIPortalAuth resource for authentication configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalSpecAuth
{
    /// <summary>Name is the name of the APIPortalAuth resource.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>UI holds the UI customization options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalSpecUi
{
    /// <summary>LogoURL is the public URL of the logo.</summary>
    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; set; }
}

/// <summary>The desired behavior of this APIPortal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalSpec
{
    /// <summary>Auth references the APIPortalAuth resource for authentication configuration.</summary>
    [JsonPropertyName("auth")]
    public V1alpha1APIPortalSpecAuth? Auth { get; set; }

    /// <summary>Description of the APIPortal.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Title is the public facing name of the APIPortal.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>TrustedURLs are the urls that are trusted by the OAuth 2.0 authorization server.</summary>
    [JsonPropertyName("trustedUrls")]
    public required IList<string> TrustedUrls { get; set; }

    /// <summary>UI holds the UI customization options.</summary>
    [JsonPropertyName("ui")]
    public V1alpha1APIPortalSpecUi? Ui { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APIPortalStatusConditionsStatusEnum>))]
public enum V1alpha1APIPortalStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1alpha1APIPortalStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>OIDC is the OIDC configuration for accessing the exposed APIPortal WebUI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalStatusOidc
{
    /// <summary>ClientID is the OIDC ClientID for accessing the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>CompanyClaim is the name of the JWT claim containing the user company.</summary>
    [JsonPropertyName("companyClaim")]
    public string? CompanyClaim { get; set; }

    /// <summary>EmailClaim is the name of the JWT claim containing the user email.</summary>
    [JsonPropertyName("emailClaim")]
    public string? EmailClaim { get; set; }

    /// <summary>FirstnameClaim is the name of the JWT claim containing the user firstname.</summary>
    [JsonPropertyName("firstnameClaim")]
    public string? FirstnameClaim { get; set; }

    /// <summary>Generic indicates whether or not the APIPortal authentication relies on Generic OIDC.</summary>
    [JsonPropertyName("generic")]
    public bool? Generic { get; set; }

    /// <summary>GroupsClaim is the name of the JWT claim containing the user groups.</summary>
    [JsonPropertyName("groupsClaim")]
    public string? GroupsClaim { get; set; }

    /// <summary>Issuer is the OIDC issuer for accessing the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>LastnameClaim is the name of the JWT claim containing the user lastname.</summary>
    [JsonPropertyName("lastnameClaim")]
    public string? LastnameClaim { get; set; }

    /// <summary>Scopes is the OIDC scopes for getting user attributes during the authentication to the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("scopes")]
    public string? Scopes { get; set; }

    /// <summary>SecretName is the name of the secret containing the OIDC ClientSecret for accessing the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>SyncedAttributes configure the user attributes to sync.</summary>
    [JsonPropertyName("syncedAttributes")]
    public IList<string>? SyncedAttributes { get; set; }

    /// <summary>UserIDClaim is the name of the JWT claim containing the user ID.</summary>
    [JsonPropertyName("userIdClaim")]
    public string? UserIdClaim { get; set; }
}

/// <summary>The current status of this APIPortal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIPortalStatusConditions>? Conditions { get; set; }

    /// <summary>Hash is a hash representing the APIPortal.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>OIDC is the OIDC configuration for accessing the exposed APIPortal WebUI.</summary>
    [JsonPropertyName("oidc")]
    public V1alpha1APIPortalStatusOidc? Oidc { get; set; }

    [JsonPropertyName("syncedAt")]
    public DateTime? SyncedAt { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIPortal defines a developer portal for accessing the documentation of APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIPortal : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIPortalSpec?>, IStatus<V1alpha1APIPortalStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPortal";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiportals";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIPortal";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIPortal.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIPortalSpec? Spec { get; set; }

    /// <summary>The current status of this APIPortal.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIPortalStatus? Status { get; set; }
}