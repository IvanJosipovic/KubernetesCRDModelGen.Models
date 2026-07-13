#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.upbound.io;
/// <summary>LinuxWebApp is the Schema for the LinuxWebApps API. Manages a Linux Web App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LinuxWebAppList : IKubernetesObject<V1ListMeta>, IItems<V1beta2LinuxWebApp>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LinuxWebAppList";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "linuxwebapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LinuxWebAppList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2LinuxWebApp objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2LinuxWebApp> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecDeletionPolicyEnum>))]
public enum V1beta2LinuxWebAppSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An active_directory block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsActiveDirectory
{
    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
    /// The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>
/// The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name.
/// The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsFacebookAppSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A facebook block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsFacebook
{
    /// <summary>
    /// The App ID of the Facebook app used for login.
    /// The App ID of the Facebook app used for login.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>
    /// The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name.
    /// The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("appSecretSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsFacebookAppSecretSecretRef? AppSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name that contains the app_secret value used for Facebook Login.
    /// The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.
    /// </summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsGithubClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A github block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsGithub
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the GitHub app used for login.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
    /// The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsGithubClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsGoogleClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A google block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsGoogle
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OpenID Connect Client ID for the Google web application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
    /// The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsGoogleClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, &quot;openid&quot;, &quot;profile&quot;, and &quot;email&quot; are used as default scopes.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A microsoft block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsMicrosoft
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name.
/// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A twitter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsTwitter
{
    /// <summary>
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>
    /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name.
    /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("consumerSecretSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef? ConsumerSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>A auth_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsActiveDirectory? ActiveDirectory { get; set; }

    /// <summary>
    /// Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Linux Web App.
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: BuiltInAuthenticationProviderAzureActiveDirectory, BuiltInAuthenticationProviderFacebook, BuiltInAuthenticationProviderGoogle, BuiltInAuthenticationProviderMicrosoftAccount, BuiltInAuthenticationProviderTwitter, BuiltInAuthenticationProviderGithub
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled for the Linux Web App?
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsFacebook? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsGithub? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsGoogle? Google { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity that issues access tokens for this Linux Web App.
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsMicrosoft? Microsoft { get; set; }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use for the Linux Web App.
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours.
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>
    /// Should the Linux Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to false.
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsTwitter? Twitter { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous.
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>An active_directory_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2ActiveDirectoryV2
{
    /// <summary>
    /// The list of allowed Applications for the Default Authorisation Policy.
    /// The list of allowed Applications for the Default Authorisation Policy.
    /// </summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The list of allowed Group Names for the Default Authorisation Policy.
    /// The list of allowed Group Names for the Default Authorisation Policy.
    /// </summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }

    /// <summary>
    /// The list of allowed Identities for the Default Authorisation Policy.
    /// The list of allowed Identities for the Default Authorisation Policy.
    /// </summary>
    [JsonPropertyName("allowedIdentities")]
    public IList<string>? AllowedIdentities { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The thumbprint of the certificate used for signing purposes.
    /// The thumbprint of the certificate used for signing purposes.
    /// </summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The App Setting name that contains the client secret of the Client.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// A list of Allowed Client Applications in the JWT Claim.
    /// A list of Allowed Client Applications in the JWT Claim.
    /// </summary>
    [JsonPropertyName("jwtAllowedClientApplications")]
    public IList<string>? JwtAllowedClientApplications { get; set; }

    /// <summary>
    /// A list of Allowed Groups in the JWT Claim.
    /// A list of Allowed Groups in the JWT Claim.
    /// </summary>
    [JsonPropertyName("jwtAllowedGroups")]
    public IList<string>? JwtAllowedGroups { get; set; }

    /// <summary>
    /// A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.
    /// A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.
    /// </summary>
    [JsonPropertyName("loginParameters")]
    public IDictionary<string, string>? LoginParameters { get; set; }

    /// <summary>
    /// The Azure Tenant Endpoint for the Authenticating Tenant. e.g. https://login.microsoftonline.com/{tenant-guid}/v2.0/
    /// The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
    /// </summary>
    [JsonPropertyName("tenantAuthEndpoint")]
    public string? TenantAuthEndpoint { get; set; }

    /// <summary>
    /// Should the www-authenticate provider should be omitted from the request? Defaults to false.
    /// Should the www-authenticate provider should be omitted from the request? Defaults to `false`
    /// </summary>
    [JsonPropertyName("wwwAuthenticationDisabled")]
    public bool? WwwAuthenticationDisabled { get; set; }
}

/// <summary>An apple_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2AppleV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OpenID Connect Client ID for the Apple web application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Apple Login.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>An azure_static_web_app_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Static Web App Authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2CustomOidcV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with this Custom OIDC.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The name which should be used for this Storage Account.
    /// The name of the Custom OIDC Authentication Provider.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the claim that contains the users name.
    /// The name of the claim that contains the users name.
    /// </summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary>
    /// Specifies the endpoint used for OpenID Connect Discovery. For example https://example.com/.well-known/openid-configuration.
    /// The endpoint that contains all the configuration endpoints for this Custom OIDC provider.
    /// </summary>
    [JsonPropertyName("openidConfigurationEndpoint")]
    public string? OpenidConfigurationEndpoint { get; set; }

    /// <summary>
    /// The list of the scopes that should be requested while authenticating.
    /// The list of the scopes that should be requested while authenticating.
    /// </summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>A facebook_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2FacebookV2
{
    /// <summary>
    /// The App ID of the Facebook app used for login.
    /// The App ID of the Facebook app used for login.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>
    /// The app setting name that contains the app_secret value used for Facebook Login.
    /// The app setting name that contains the `app_secret` value used for Facebook Login.
    /// </summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>
    /// The version of the Facebook API to be used while logging in.
    /// The version of the Facebook API to be used while logging in.
    /// </summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// Specifies a list of scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A github_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2GithubV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the GitHub app used for login.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for GitHub Login.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A google_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2GoogleV2
{
    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed Audiences that will be requested as part of Google Sign-In authentication.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OpenID Connect Client ID for the Google web application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Google Login.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// Specifies a list of Login scopes that will be requested as part of Google Sign-In authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A login block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2Login
{
    /// <summary>
    /// External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends.
    /// External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. **Note:** URLs within the current domain are always implicitly allowed.
    /// </summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The method by which cookies expire. Possible values include: FixedTime, and IdentityProviderDerived. Defaults to FixedTime.
    /// The method by which cookies expire. Possible values include: `FixedTime`, and `IdentityProviderDerived`. Defaults to `FixedTime`.
    /// </summary>
    [JsonPropertyName("cookieExpirationConvention")]
    public string? CookieExpirationConvention { get; set; }

    /// <summary>
    /// The time after the request is made when the session cookie should expire. Defaults to 08:00:00.
    /// The time after the request is made when the session cookie should expire. Defaults to `08:00:00`.
    /// </summary>
    [JsonPropertyName("cookieExpirationTime")]
    public string? CookieExpirationTime { get; set; }

    /// <summary>
    /// The endpoint to which logout requests should be made.
    /// The endpoint to which logout requests should be made.
    /// </summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }

    /// <summary>
    /// The time after the request is made when the nonce should expire. Defaults to 00:05:00.
    /// The time after the request is made when the nonce should expire. Defaults to `00:05:00`.
    /// </summary>
    [JsonPropertyName("nonceExpirationTime")]
    public string? NonceExpirationTime { get; set; }

    /// <summary>
    /// Should the fragments from the request be preserved after the login request is made. Defaults to false.
    /// Should the fragments from the request be preserved after the login request is made. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours.
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [JsonPropertyName("tokenRefreshExtensionTime")]
    public double? TokenRefreshExtensionTime { get; set; }

    /// <summary>
    /// Should the Token Store configuration Enabled. Defaults to false
    /// Should the Token Store configuration Enabled. Defaults to `false`
    /// </summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>
    /// The directory path in the App Filesystem in which the tokens will be stored.
    /// The directory path in the App Filesystem in which the tokens will be stored.
    /// </summary>
    [JsonPropertyName("tokenStorePath")]
    public string? TokenStorePath { get; set; }

    /// <summary>
    /// The name of the app setting which contains the SAS URL of the blob storage containing the tokens.
    /// The name of the app setting which contains the SAS URL of the blob storage containing the tokens.
    /// </summary>
    [JsonPropertyName("tokenStoreSasSettingName")]
    public string? TokenStoreSasSettingName { get; set; }

    /// <summary>
    /// Should the nonce be validated while completing the login flow. Defaults to true.
    /// Should the nonce be validated while completing the login flow. Defaults to `true`.
    /// </summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary>A microsoft_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2MicrosoftV2
{
    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// The list of Login scopes that will be requested as part of Microsoft Account authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A twitter_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2TwitterV2
{
    /// <summary>
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>An auth_settings_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2AppleV2? AppleV2 { get; set; }

    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to false.
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2 { get; set; }

    /// <summary>
    /// The path to the App Auth settings.
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta2LinuxWebAppSpecForProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>
    /// The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider.
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>
    /// The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage.
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2FacebookV2? FacebookV2 { get; set; }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include NoProxy, Standard, Custom. Defaults to NoProxy.
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    [JsonPropertyName("forwardProxyConvention")]
    public string? ForwardProxyConvention { get; set; }

    /// <summary>
    /// The name of the custom header containing the host of the request.
    /// The name of the header containing the host of the request.
    /// </summary>
    [JsonPropertyName("forwardProxyCustomHostHeaderName")]
    public string? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>
    /// The name of the custom header containing the scheme of the request.
    /// The name of the header containing the scheme of the request.
    /// </summary>
    [JsonPropertyName("forwardProxyCustomSchemeHeaderName")]
    public string? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>A github_v2 block as defined below.</summary>
    [JsonPropertyName("githubV2")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2GithubV2? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2GoogleV2? GoogleV2 { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth.
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2Login? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2MicrosoftV2? MicrosoftV2 { get; set; }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// Should the authentication flow be used for all requests.
    /// </summary>
    [JsonPropertyName("requireAuthentication")]
    public bool? RequireAuthentication { get; set; }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to ~1.
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>A twitter_v2 block as defined below.</summary>
    [JsonPropertyName("twitterV2")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2TwitterV2? TwitterV2 { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage.
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderBackupSchedule
{
    /// <summary>
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day).
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).
    /// </summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>
    /// The unit of time for how often the backup should take place. Possible values include: Day, Hour
    /// The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.
    /// </summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>
    /// Should the service keep at least one backup, regardless of the age of backup? Defaults to false.
    /// Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("keepAtLeastOneBackup")]
    public bool? KeepAtLeastOneBackup { get; set; }

    /// <summary>
    /// After how many days backups should be deleted. Defaults to 30.
    /// After how many days backups should be deleted.
    /// </summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }

    /// <summary>
    /// When the schedule should start working in RFC-3339 format.
    /// When the schedule should start working in RFC-3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// The SAS URL to the container.
/// The SAS URL to the container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderBackupStorageAccountUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A backup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderBackup
{
    /// <summary>
    /// Should this backup job be enabled? Defaults to true.
    /// Should this backup job be enabled?
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The name which should be used for this Backup.
    /// The name which should be used for this Backup.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2LinuxWebAppSpecForProviderBackupSchedule? Schedule { get; set; }

    /// <summary>
    /// The SAS URL to the container.
    /// The SAS URL to the container.
    /// </summary>
    [JsonPropertyName("storageAccountUrlSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderBackupStorageAccountUrlSecretRef? StorageAccountUrlSecretRef { get; set; }
}

/// <summary>
/// The connection string value.
/// The connection string value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderConnectionStringValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderConnectionString
{
    /// <summary>
    /// The name of the Connection String.
    /// The name which should be used for this Connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type of database. Possible values include: MySQL, SQLServer, SQLAzure, Custom, NotificationHub, ServiceBus, EventHub, APIHub, DocDb, RedisCache, and PostgreSQL.
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The connection string value.
    /// The connection string value.
    /// </summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderConnectionStringValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Linux Web App.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Web App. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A azure_blob_storage_http block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderLogsApplicationLogsAzureBlobStorage
{
    /// <summary>The level at which to log. Possible values include Error, Warning, Information, Verbose and Off. NOTE: this field is not available for http_logs</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasUrl")]
    public string? SasUrl { get; set; }
}

/// <summary>A application_logs block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderLogsApplicationLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1beta2LinuxWebAppSpecForProviderLogsApplicationLogsAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary>Log level. Possible values include: Off, Verbose, Information, Warning, and Error.</summary>
    [JsonPropertyName("fileSystemLevel")]
    public string? FileSystemLevel { get; set; }
}

/// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderLogsHttpLogsAzureBlobStorageSasurlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A azure_blob_storage_http block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderLogsHttpLogsAzureBlobStorage
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasurlSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderLogsHttpLogsAzureBlobStorageSasurlSecretRef? SasurlSecretRef { get; set; }
}

/// <summary>A file_system block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderLogsHttpLogsFileSystem
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>The maximum size in megabytes that log files can use.</summary>
    [JsonPropertyName("retentionInMb")]
    public double? RetentionInMb { get; set; }
}

/// <summary>An http_logs block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderLogsHttpLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1beta2LinuxWebAppSpecForProviderLogsHttpLogsAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary>A file_system block as defined above.</summary>
    [JsonPropertyName("fileSystem")]
    public V1beta2LinuxWebAppSpecForProviderLogsHttpLogsFileSystem? FileSystem { get; set; }
}

/// <summary>A logs block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderLogs
{
    /// <summary>A application_logs block as defined above.</summary>
    [JsonPropertyName("applicationLogs")]
    public V1beta2LinuxWebAppSpecForProviderLogsApplicationLogs? ApplicationLogs { get; set; }

    /// <summary>Should detailed error messages be enabled?</summary>
    [JsonPropertyName("detailedErrorMessages")]
    public bool? DetailedErrorMessages { get; set; }

    /// <summary>Should the failed request tracing be enabled?</summary>
    [JsonPropertyName("failedRequestTracing")]
    public bool? FailedRequestTracing { get; set; }

    /// <summary>An http_logs block as defined above.</summary>
    [JsonPropertyName("httpLogs")]
    public V1beta2LinuxWebAppSpecForProviderLogsHttpLogs? HttpLogs { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelector
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
    public V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderServicePlanIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderServicePlanIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderServicePlanIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderServicePlanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderServicePlanIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderServicePlanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderServicePlanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecForProviderServicePlanIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderServicePlanIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderServicePlanIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderServicePlanIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderServicePlanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderServicePlanIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderServicePlanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderServicePlanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderServicePlanIdSelector
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
    public V1beta2LinuxWebAppSpecForProviderServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A application_stack block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigApplicationStack
{
    /// <summary>The docker image, including tag, to be used. e.g. appsvc/staticsite:latest.</summary>
    [JsonPropertyName("dockerImageName")]
    public string? DockerImageName { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryPasswordSecretRef")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef? DockerRegistryPasswordSecretRef { get; set; }

    /// <summary>The URL of the container registry where the docker_image_name is located. e.g. https://index.docker.io or https://mcr.microsoft.com. This value is required with docker_image_name.</summary>
    [JsonPropertyName("dockerRegistryUrl")]
    public string? DockerRegistryUrl { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryUsername")]
    public string? DockerRegistryUsername { get; set; }

    /// <summary>The version of .NET to use. Possible values include 3.1, 5.0, 6.0, 7.0, 8.0, 9.0and 10.0.</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>The version of Go to use. Possible values include 1.18, and 1.19.</summary>
    [JsonPropertyName("goVersion")]
    public string? GoVersion { get; set; }

    /// <summary>The Java server type. Possible values include JAVA, TOMCAT, and JBOSSEAP.</summary>
    [JsonPropertyName("javaServer")]
    public string? JavaServer { get; set; }

    /// <summary>The Version of the java_server to use.</summary>
    [JsonPropertyName("javaServerVersion")]
    public string? JavaServerVersion { get; set; }

    /// <summary>The Version of Java to use. Possible values include 8, 11, 17, and 21.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of Node to run. Possible values include 12-lts, 14-lts, 16-lts, 18-lts, 20-lts and 22-lts. This property conflicts with java_version.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The version of PHP to run. Possible values are 7.4, 8.0, 8.1, 8.2, 8.3 and 8.4.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>The version of Python to run. Possible values include 3.13, 3.12, 3.11, 3.10, 3.9, 3.8 and 3.7.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The version of Ruby to run. Possible values include 2.6 and 2.7.</summary>
    [JsonPropertyName("rubyVersion")]
    public string? RubyVersion { get; set; }
}

/// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingAction
{
    /// <summary>Predefined action to be taken to an Auto Heal trigger. Possible values include: Recycle.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The minimum amount of time in hh:mm:ss the Linux Web App must have been running before the defined action will be run in the event of a trigger.</summary>
    [JsonPropertyName("minimumProcessExecutionTime")]
    public string? MinimumProcessExecutionTime { get; set; }
}

/// <summary>A requests block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerRequests
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }
}

/// <summary>A slow_request blocks as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequest
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The threshold of time passed to qualify as a Slow Request in hh:mm:ss.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The threshold of time passed to qualify as a Slow Request in hh:mm:ss.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerStatusCode
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The status code for this rule, accepts single status codes and status code ranges. e.g. 500 or 400-499. Possible values are integers between 101 and 599</summary>
    [JsonPropertyName("statusCodeRange")]
    public string? StatusCodeRange { get; set; }

    /// <summary>The Request Sub Status of the Status Code.</summary>
    [JsonPropertyName("subStatus")]
    public double? SubStatus { get; set; }

    /// <summary>The Win32 Status Code of the Request.</summary>
    [JsonPropertyName("win32StatusCode")]
    public double? Win32StatusCode { get; set; }
}

/// <summary>A trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTrigger
{
    /// <summary>A requests block as defined above.</summary>
    [JsonPropertyName("requests")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerRequests? Requests { get; set; }

    /// <summary>A slow_request blocks as defined above.</summary>
    [JsonPropertyName("slowRequest")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest { get; set; }

    /// <summary>One or more slow_request_with_path blocks as defined above.</summary>
    [JsonPropertyName("slowRequestWithPath")]
    public IList<V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath>? SlowRequestWithPath { get; set; }

    /// <summary>One or more status_code blocks as defined above.</summary>
    [JsonPropertyName("statusCode")]
    public IList<V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTriggerStatusCode>? StatusCode { get; set; }
}

/// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSetting
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingAction? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSettingTrigger? Trigger { get; set; }
}

/// <summary>A cors block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigCors
{
    /// <summary>
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// Whether CORS requests with credentials are allowed. Defaults to false
    /// Are credentials allowed in CORS requests? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestriction
{
    /// <summary>
    /// The action to take. Possible values are Allow or Deny. Defaults to Allow.
    /// The action to take. Possible values are `Allow` or `Deny`.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// The Description of this IP Restriction.
    /// The description of the IP restriction rule.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionHeaders? Headers { get; set; }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// The name which should be used for this Storage Account.
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The priority value of this ip_restriction. Defaults to 65000.
    /// The priority value of this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>
    /// The subnet id which will be used by this Web App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestriction
{
    /// <summary>
    /// The action to take. Possible values are Allow or Deny. Defaults to Allow.
    /// The action to take. Possible values are `Allow` or `Deny`.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// The Description of this IP Restriction.
    /// The description of the IP restriction rule.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionHeaders? Headers { get; set; }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// The name which should be used for this Storage Account.
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The priority value of this ip_restriction. Defaults to 65000.
    /// The priority value of this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>
    /// The subnet id which will be used by this Web App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A site_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderSiteConfig
{
    /// <summary>If this Linux Web App is Always On enabled. Defaults to true.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL to the API Definition for this Linux Web App.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The API Management API ID this Linux Web App is associated with.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>A application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigApplicationStack? ApplicationStack { get; set; }

    /// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
    [JsonPropertyName("autoHealSetting")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigAutoHealSetting? AutoHealSetting { get; set; }

    /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfigCors? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Linux Web App.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>The State of FTP / FTPS service. Possible values include AllAllowed, FtpsOnly, and Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node can be unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Only valid in conjunction with health_check_path.
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>The path to the Health Check.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Should the HTTP2 be enabled?</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>One or more ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta2LinuxWebAppSpecForProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>Use Local MySQL. Defaults to false.</summary>
    [JsonPropertyName("localMysqlEnabled")]
    public bool? LocalMysqlEnabled { get; set; }

    /// <summary>Managed pipeline mode. Possible values include Integrated, and Classic. Defaults to Integrated.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Should Remote Debugging be enabled? Defaults to false.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Currently only VS2022 is supported.</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta2LinuxWebAppSpecForProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests to the SCM site Possible values are 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>Should the Linux Web App ip_restriction configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Linux Web App use a 32-bit worker? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false.
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled? Defaults to false.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Linux App Service.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>A sticky_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderStickySettings
{
    /// <summary>A list of app_setting names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("appSettingNames")]
    public IList<string>? AppSettingNames { get; set; }

    /// <summary>A list of connection_string names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("connectionStringNames")]
    public IList<string>? ConnectionStringNames { get; set; }
}

/// <summary>The Access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderStorageAccountAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderStorageAccount
{
    /// <summary>The Access key for the storage account.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta2LinuxWebAppSpecForProviderStorageAccountAccessKeySecretRef? AccessKeySecretRef { get; set; }

    /// <summary>The Name of the Storage Account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The path at which to mount the storage share.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>The name which should be used for this Storage Account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Name of the File Share or Container Name for Blob storage.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>The Azure Storage Type. Possible values include AzureFiles and AzureBlob</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecForProvider
{
    /// <summary>A map of key-value pairs of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettings? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public V1beta2LinuxWebAppSpecForProviderAuthSettingsV2? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2LinuxWebAppSpecForProviderBackup? Backup { get; set; }

    /// <summary>Should Client Affinity be enabled?</summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>Should Client Certificates be enabled?</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The Client Certificate mode. Possible values are Required, Optional, and OptionalInteractiveUser. This property has no effect when client_certificate_enabled is false. Defaults to Required.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta2LinuxWebAppSpecForProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>Should the Linux Web App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>Should the Linux Web App require HTTPS connections. Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2LinuxWebAppSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Azure Region where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public V1beta2LinuxWebAppSpecForProviderLogs? Logs { get; set; }

    /// <summary>Should public network access be enabled for the Web App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2LinuxWebAppSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2LinuxWebAppSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The ID of the Service Plan that this Linux App Service will be created in.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdRef")]
    public V1beta2LinuxWebAppSpecForProviderServicePlanIdRef? ServicePlanIdRef { get; set; }

    /// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdSelector")]
    public V1beta2LinuxWebAppSpecForProviderServicePlanIdSelector? ServicePlanIdSelector { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public V1beta2LinuxWebAppSpecForProviderSiteConfig? SiteConfig { get; set; }

    /// <summary>A sticky_settings block as defined below.</summary>
    [JsonPropertyName("stickySettings")]
    public V1beta2LinuxWebAppSpecForProviderStickySettings? StickySettings { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2LinuxWebAppSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Linux Web App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether backup and restore operations over the linked virtual network are enabled. Defaults to false.</summary>
    [JsonPropertyName("virtualNetworkBackupRestoreEnabled")]
    public bool? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxWebAppSpecForProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>Should the traffic for the image pull be routed over virtual network enabled. Defaults to false.</summary>
    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Linux Web App.
    /// The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsActiveDirectoryClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>An active_directory block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsActiveDirectory
{
    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
    /// The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>
/// The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name.
/// The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsFacebookAppSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A facebook block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsFacebook
{
    /// <summary>
    /// The App ID of the Facebook app used for login.
    /// The App ID of the Facebook app used for login.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>
    /// The App Secret of the Facebook app used for Facebook login. Cannot be specified with app_secret_setting_name.
    /// The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("appSecretSecretRef")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsFacebookAppSecretSecretRef? AppSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name that contains the app_secret value used for Facebook Login.
    /// The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.
    /// </summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsGithubClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A github block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsGithub
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the GitHub app used for login.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
    /// The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsGithubClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsGoogleClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A google block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsGoogle
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OpenID Connect Client ID for the Google web application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
    /// The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsGoogleClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, &quot;openid&quot;, &quot;profile&quot;, and &quot;email&quot; are used as default scopes.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsMicrosoftClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A microsoft block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsMicrosoft
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsMicrosoftClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name.
/// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsTwitterConsumerSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A twitter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsTwitter
{
    /// <summary>
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>
    /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name.
    /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.
    /// </summary>
    [JsonPropertyName("consumerSecretSecretRef")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsTwitterConsumerSecretSecretRef? ConsumerSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>A auth_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsActiveDirectory? ActiveDirectory { get; set; }

    /// <summary>
    /// Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Linux Web App.
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: BuiltInAuthenticationProviderAzureActiveDirectory, BuiltInAuthenticationProviderFacebook, BuiltInAuthenticationProviderGoogle, BuiltInAuthenticationProviderMicrosoftAccount, BuiltInAuthenticationProviderTwitter, BuiltInAuthenticationProviderGithub
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled for the Linux Web App?
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsFacebook? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsGithub? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsGoogle? Google { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity that issues access tokens for this Linux Web App.
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsMicrosoft? Microsoft { get; set; }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use for the Linux Web App.
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours.
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>
    /// Should the Linux Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to false.
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsTwitter? Twitter { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous.
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>An active_directory_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2ActiveDirectoryV2
{
    /// <summary>
    /// The list of allowed Applications for the Default Authorisation Policy.
    /// The list of allowed Applications for the Default Authorisation Policy.
    /// </summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The list of allowed Group Names for the Default Authorisation Policy.
    /// The list of allowed Group Names for the Default Authorisation Policy.
    /// </summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }

    /// <summary>
    /// The list of allowed Identities for the Default Authorisation Policy.
    /// The list of allowed Identities for the Default Authorisation Policy.
    /// </summary>
    [JsonPropertyName("allowedIdentities")]
    public IList<string>? AllowedIdentities { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The thumbprint of the certificate used for signing purposes.
    /// The thumbprint of the certificate used for signing purposes.
    /// </summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The App Setting name that contains the client secret of the Client.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// A list of Allowed Client Applications in the JWT Claim.
    /// A list of Allowed Client Applications in the JWT Claim.
    /// </summary>
    [JsonPropertyName("jwtAllowedClientApplications")]
    public IList<string>? JwtAllowedClientApplications { get; set; }

    /// <summary>
    /// A list of Allowed Groups in the JWT Claim.
    /// A list of Allowed Groups in the JWT Claim.
    /// </summary>
    [JsonPropertyName("jwtAllowedGroups")]
    public IList<string>? JwtAllowedGroups { get; set; }

    /// <summary>
    /// A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.
    /// A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.
    /// </summary>
    [JsonPropertyName("loginParameters")]
    public IDictionary<string, string>? LoginParameters { get; set; }

    /// <summary>
    /// The Azure Tenant Endpoint for the Authenticating Tenant. e.g. https://login.microsoftonline.com/{tenant-guid}/v2.0/
    /// The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
    /// </summary>
    [JsonPropertyName("tenantAuthEndpoint")]
    public string? TenantAuthEndpoint { get; set; }

    /// <summary>
    /// Should the www-authenticate provider should be omitted from the request? Defaults to false.
    /// Should the www-authenticate provider should be omitted from the request? Defaults to `false`
    /// </summary>
    [JsonPropertyName("wwwAuthenticationDisabled")]
    public bool? WwwAuthenticationDisabled { get; set; }
}

/// <summary>An apple_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2AppleV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OpenID Connect Client ID for the Apple web application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Apple Login.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>An azure_static_web_app_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Static Web App Authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2CustomOidcV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with this Custom OIDC.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The name which should be used for this Storage Account.
    /// The name of the Custom OIDC Authentication Provider.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the claim that contains the users name.
    /// The name of the claim that contains the users name.
    /// </summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary>
    /// Specifies the endpoint used for OpenID Connect Discovery. For example https://example.com/.well-known/openid-configuration.
    /// The endpoint that contains all the configuration endpoints for this Custom OIDC provider.
    /// </summary>
    [JsonPropertyName("openidConfigurationEndpoint")]
    public string? OpenidConfigurationEndpoint { get; set; }

    /// <summary>
    /// The list of the scopes that should be requested while authenticating.
    /// The list of the scopes that should be requested while authenticating.
    /// </summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>A facebook_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2FacebookV2
{
    /// <summary>
    /// The App ID of the Facebook app used for login.
    /// The App ID of the Facebook app used for login.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>
    /// The app setting name that contains the app_secret value used for Facebook Login.
    /// The app setting name that contains the `app_secret` value used for Facebook Login.
    /// </summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>
    /// The version of the Facebook API to be used while logging in.
    /// The version of the Facebook API to be used while logging in.
    /// </summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// Specifies a list of scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A github_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2GithubV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the GitHub app used for login.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for GitHub Login.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A google_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2GoogleV2
{
    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed Audiences that will be requested as part of Google Sign-In authentication.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OpenID Connect Client ID for the Google web application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Google Login.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// Specifies a list of Login scopes that will be requested as part of Google Sign-In authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A login block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2Login
{
    /// <summary>
    /// External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends.
    /// External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. **Note:** URLs within the current domain are always implicitly allowed.
    /// </summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The method by which cookies expire. Possible values include: FixedTime, and IdentityProviderDerived. Defaults to FixedTime.
    /// The method by which cookies expire. Possible values include: `FixedTime`, and `IdentityProviderDerived`. Defaults to `FixedTime`.
    /// </summary>
    [JsonPropertyName("cookieExpirationConvention")]
    public string? CookieExpirationConvention { get; set; }

    /// <summary>
    /// The time after the request is made when the session cookie should expire. Defaults to 08:00:00.
    /// The time after the request is made when the session cookie should expire. Defaults to `08:00:00`.
    /// </summary>
    [JsonPropertyName("cookieExpirationTime")]
    public string? CookieExpirationTime { get; set; }

    /// <summary>
    /// The endpoint to which logout requests should be made.
    /// The endpoint to which logout requests should be made.
    /// </summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }

    /// <summary>
    /// The time after the request is made when the nonce should expire. Defaults to 00:05:00.
    /// The time after the request is made when the nonce should expire. Defaults to `00:05:00`.
    /// </summary>
    [JsonPropertyName("nonceExpirationTime")]
    public string? NonceExpirationTime { get; set; }

    /// <summary>
    /// Should the fragments from the request be preserved after the login request is made. Defaults to false.
    /// Should the fragments from the request be preserved after the login request is made. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours.
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [JsonPropertyName("tokenRefreshExtensionTime")]
    public double? TokenRefreshExtensionTime { get; set; }

    /// <summary>
    /// Should the Token Store configuration Enabled. Defaults to false
    /// Should the Token Store configuration Enabled. Defaults to `false`
    /// </summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>
    /// The directory path in the App Filesystem in which the tokens will be stored.
    /// The directory path in the App Filesystem in which the tokens will be stored.
    /// </summary>
    [JsonPropertyName("tokenStorePath")]
    public string? TokenStorePath { get; set; }

    /// <summary>
    /// The name of the app setting which contains the SAS URL of the blob storage containing the tokens.
    /// The name of the app setting which contains the SAS URL of the blob storage containing the tokens.
    /// </summary>
    [JsonPropertyName("tokenStoreSasSettingName")]
    public string? TokenStoreSasSettingName { get; set; }

    /// <summary>
    /// Should the nonce be validated while completing the login flow. Defaults to true.
    /// Should the nonce be validated while completing the login flow. Defaults to `true`.
    /// </summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary>A microsoft_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2MicrosoftV2
{
    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// The list of Login scopes that will be requested as part of Microsoft Account authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A twitter_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2TwitterV2
{
    /// <summary>
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>An auth_settings_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2AppleV2? AppleV2 { get; set; }

    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to false.
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2 { get; set; }

    /// <summary>
    /// The path to the App Auth settings.
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>
    /// The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider.
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>
    /// The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage.
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2FacebookV2? FacebookV2 { get; set; }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include NoProxy, Standard, Custom. Defaults to NoProxy.
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    [JsonPropertyName("forwardProxyConvention")]
    public string? ForwardProxyConvention { get; set; }

    /// <summary>
    /// The name of the custom header containing the host of the request.
    /// The name of the header containing the host of the request.
    /// </summary>
    [JsonPropertyName("forwardProxyCustomHostHeaderName")]
    public string? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>
    /// The name of the custom header containing the scheme of the request.
    /// The name of the header containing the scheme of the request.
    /// </summary>
    [JsonPropertyName("forwardProxyCustomSchemeHeaderName")]
    public string? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>A github_v2 block as defined below.</summary>
    [JsonPropertyName("githubV2")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2GithubV2? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2GoogleV2? GoogleV2 { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth.
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2Login? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2MicrosoftV2? MicrosoftV2 { get; set; }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// Should the authentication flow be used for all requests.
    /// </summary>
    [JsonPropertyName("requireAuthentication")]
    public bool? RequireAuthentication { get; set; }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to ~1.
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>A twitter_v2 block as defined below.</summary>
    [JsonPropertyName("twitterV2")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2TwitterV2? TwitterV2 { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage.
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderBackupSchedule
{
    /// <summary>
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day).
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).
    /// </summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>
    /// The unit of time for how often the backup should take place. Possible values include: Day, Hour
    /// The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.
    /// </summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>
    /// Should the service keep at least one backup, regardless of the age of backup? Defaults to false.
    /// Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("keepAtLeastOneBackup")]
    public bool? KeepAtLeastOneBackup { get; set; }

    /// <summary>
    /// After how many days backups should be deleted. Defaults to 30.
    /// After how many days backups should be deleted.
    /// </summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }

    /// <summary>
    /// When the schedule should start working in RFC-3339 format.
    /// When the schedule should start working in RFC-3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>
/// The SAS URL to the container.
/// The SAS URL to the container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderBackupStorageAccountUrlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A backup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderBackup
{
    /// <summary>
    /// Should this backup job be enabled? Defaults to true.
    /// Should this backup job be enabled?
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The name which should be used for this Backup.
    /// The name which should be used for this Backup.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2LinuxWebAppSpecInitProviderBackupSchedule? Schedule { get; set; }

    /// <summary>
    /// The SAS URL to the container.
    /// The SAS URL to the container.
    /// </summary>
    [JsonPropertyName("storageAccountUrlSecretRef")]
    public required V1beta2LinuxWebAppSpecInitProviderBackupStorageAccountUrlSecretRef StorageAccountUrlSecretRef { get; set; }
}

/// <summary>
/// The connection string value.
/// The connection string value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderConnectionStringValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderConnectionString
{
    /// <summary>
    /// The name of the Connection String.
    /// The name which should be used for this Connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type of database. Possible values include: MySQL, SQLServer, SQLAzure, Custom, NotificationHub, ServiceBus, EventHub, APIHub, DocDb, RedisCache, and PostgreSQL.
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The connection string value.
    /// The connection string value.
    /// </summary>
    [JsonPropertyName("valueSecretRef")]
    public required V1beta2LinuxWebAppSpecInitProviderConnectionStringValueSecretRef ValueSecretRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Linux Web App.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Web App. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A azure_blob_storage_http block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderLogsApplicationLogsAzureBlobStorage
{
    /// <summary>The level at which to log. Possible values include Error, Warning, Information, Verbose and Off. NOTE: this field is not available for http_logs</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasUrl")]
    public string? SasUrl { get; set; }
}

/// <summary>A application_logs block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderLogsApplicationLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1beta2LinuxWebAppSpecInitProviderLogsApplicationLogsAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary>Log level. Possible values include: Off, Verbose, Information, Warning, and Error.</summary>
    [JsonPropertyName("fileSystemLevel")]
    public string? FileSystemLevel { get; set; }
}

/// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderLogsHttpLogsAzureBlobStorageSasurlSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A azure_blob_storage_http block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderLogsHttpLogsAzureBlobStorage
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasurlSecretRef")]
    public required V1beta2LinuxWebAppSpecInitProviderLogsHttpLogsAzureBlobStorageSasurlSecretRef SasurlSecretRef { get; set; }
}

/// <summary>A file_system block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderLogsHttpLogsFileSystem
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>The maximum size in megabytes that log files can use.</summary>
    [JsonPropertyName("retentionInMb")]
    public double? RetentionInMb { get; set; }
}

/// <summary>An http_logs block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderLogsHttpLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1beta2LinuxWebAppSpecInitProviderLogsHttpLogsAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary>A file_system block as defined above.</summary>
    [JsonPropertyName("fileSystem")]
    public V1beta2LinuxWebAppSpecInitProviderLogsHttpLogsFileSystem? FileSystem { get; set; }
}

/// <summary>A logs block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderLogs
{
    /// <summary>A application_logs block as defined above.</summary>
    [JsonPropertyName("applicationLogs")]
    public V1beta2LinuxWebAppSpecInitProviderLogsApplicationLogs? ApplicationLogs { get; set; }

    /// <summary>Should detailed error messages be enabled?</summary>
    [JsonPropertyName("detailedErrorMessages")]
    public bool? DetailedErrorMessages { get; set; }

    /// <summary>Should the failed request tracing be enabled?</summary>
    [JsonPropertyName("failedRequestTracing")]
    public bool? FailedRequestTracing { get; set; }

    /// <summary>An http_logs block as defined above.</summary>
    [JsonPropertyName("httpLogs")]
    public V1beta2LinuxWebAppSpecInitProviderLogsHttpLogs? HttpLogs { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderServicePlanIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderServicePlanIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderServicePlanIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderServicePlanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderServicePlanIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecInitProviderServicePlanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecInitProviderServicePlanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecInitProviderServicePlanIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelector
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
    public V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A application_stack block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigApplicationStack
{
    /// <summary>The docker image, including tag, to be used. e.g. appsvc/staticsite:latest.</summary>
    [JsonPropertyName("dockerImageName")]
    public string? DockerImageName { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryPasswordSecretRef")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef? DockerRegistryPasswordSecretRef { get; set; }

    /// <summary>The URL of the container registry where the docker_image_name is located. e.g. https://index.docker.io or https://mcr.microsoft.com. This value is required with docker_image_name.</summary>
    [JsonPropertyName("dockerRegistryUrl")]
    public string? DockerRegistryUrl { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryUsername")]
    public string? DockerRegistryUsername { get; set; }

    /// <summary>The version of .NET to use. Possible values include 3.1, 5.0, 6.0, 7.0, 8.0, 9.0and 10.0.</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>The version of Go to use. Possible values include 1.18, and 1.19.</summary>
    [JsonPropertyName("goVersion")]
    public string? GoVersion { get; set; }

    /// <summary>The Java server type. Possible values include JAVA, TOMCAT, and JBOSSEAP.</summary>
    [JsonPropertyName("javaServer")]
    public string? JavaServer { get; set; }

    /// <summary>The Version of the java_server to use.</summary>
    [JsonPropertyName("javaServerVersion")]
    public string? JavaServerVersion { get; set; }

    /// <summary>The Version of Java to use. Possible values include 8, 11, 17, and 21.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of Node to run. Possible values include 12-lts, 14-lts, 16-lts, 18-lts, 20-lts and 22-lts. This property conflicts with java_version.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The version of PHP to run. Possible values are 7.4, 8.0, 8.1, 8.2, 8.3 and 8.4.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>The version of Python to run. Possible values include 3.13, 3.12, 3.11, 3.10, 3.9, 3.8 and 3.7.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The version of Ruby to run. Possible values include 2.6 and 2.7.</summary>
    [JsonPropertyName("rubyVersion")]
    public string? RubyVersion { get; set; }
}

/// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingAction
{
    /// <summary>Predefined action to be taken to an Auto Heal trigger. Possible values include: Recycle.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The minimum amount of time in hh:mm:ss the Linux Web App must have been running before the defined action will be run in the event of a trigger.</summary>
    [JsonPropertyName("minimumProcessExecutionTime")]
    public string? MinimumProcessExecutionTime { get; set; }
}

/// <summary>A requests block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerRequests
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }
}

/// <summary>A slow_request blocks as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequest
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The threshold of time passed to qualify as a Slow Request in hh:mm:ss.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The threshold of time passed to qualify as a Slow Request in hh:mm:ss.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerStatusCode
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The status code for this rule, accepts single status codes and status code ranges. e.g. 500 or 400-499. Possible values are integers between 101 and 599</summary>
    [JsonPropertyName("statusCodeRange")]
    public string? StatusCodeRange { get; set; }

    /// <summary>The Request Sub Status of the Status Code.</summary>
    [JsonPropertyName("subStatus")]
    public double? SubStatus { get; set; }

    /// <summary>The Win32 Status Code of the Request.</summary>
    [JsonPropertyName("win32StatusCode")]
    public double? Win32StatusCode { get; set; }
}

/// <summary>A trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTrigger
{
    /// <summary>A requests block as defined above.</summary>
    [JsonPropertyName("requests")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerRequests? Requests { get; set; }

    /// <summary>A slow_request blocks as defined above.</summary>
    [JsonPropertyName("slowRequest")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest { get; set; }

    /// <summary>One or more slow_request_with_path blocks as defined above.</summary>
    [JsonPropertyName("slowRequestWithPath")]
    public IList<V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath>? SlowRequestWithPath { get; set; }

    /// <summary>One or more status_code blocks as defined above.</summary>
    [JsonPropertyName("statusCode")]
    public IList<V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTriggerStatusCode>? StatusCode { get; set; }
}

/// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSetting
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingAction? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSettingTrigger? Trigger { get; set; }
}

/// <summary>A cors block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigCors
{
    /// <summary>
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// Whether CORS requests with credentials are allowed. Defaults to false
    /// Are credentials allowed in CORS requests? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestriction
{
    /// <summary>
    /// The action to take. Possible values are Allow or Deny. Defaults to Allow.
    /// The action to take. Possible values are `Allow` or `Deny`.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// The Description of this IP Restriction.
    /// The description of the IP restriction rule.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionHeaders? Headers { get; set; }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// The name which should be used for this Storage Account.
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The priority value of this ip_restriction. Defaults to 65000.
    /// The priority value of this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>
    /// The subnet id which will be used by this Web App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestriction
{
    /// <summary>
    /// The action to take. Possible values are Allow or Deny. Defaults to Allow.
    /// The action to take. Possible values are `Allow` or `Deny`.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// The Description of this IP Restriction.
    /// The description of the IP restriction rule.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionHeaders? Headers { get; set; }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// The name which should be used for this Storage Account.
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The priority value of this ip_restriction. Defaults to 65000.
    /// The priority value of this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>
    /// The subnet id which will be used by this Web App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A site_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderSiteConfig
{
    /// <summary>If this Linux Web App is Always On enabled. Defaults to true.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL to the API Definition for this Linux Web App.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The API Management API ID this Linux Web App is associated with.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>A application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigApplicationStack? ApplicationStack { get; set; }

    /// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
    [JsonPropertyName("autoHealSetting")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigAutoHealSetting? AutoHealSetting { get; set; }

    /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfigCors? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Linux Web App.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>The State of FTP / FTPS service. Possible values include AllAllowed, FtpsOnly, and Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node can be unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Only valid in conjunction with health_check_path.
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>The path to the Health Check.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Should the HTTP2 be enabled?</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>One or more ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta2LinuxWebAppSpecInitProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Site load balancing. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>Use Local MySQL. Defaults to false.</summary>
    [JsonPropertyName("localMysqlEnabled")]
    public bool? LocalMysqlEnabled { get; set; }

    /// <summary>Managed pipeline mode. Possible values include Integrated, and Classic. Defaults to Integrated.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Should Remote Debugging be enabled? Defaults to false.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Currently only VS2022 is supported.</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta2LinuxWebAppSpecInitProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests to the SCM site Possible values are 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>Should the Linux Web App ip_restriction configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Linux Web App use a 32-bit worker? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false.
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled? Defaults to false.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Linux App Service.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>A sticky_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderStickySettings
{
    /// <summary>A list of app_setting names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("appSettingNames")]
    public IList<string>? AppSettingNames { get; set; }

    /// <summary>A list of connection_string names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("connectionStringNames")]
    public IList<string>? ConnectionStringNames { get; set; }
}

/// <summary>The Access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderStorageAccountAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderStorageAccount
{
    /// <summary>The Access key for the storage account.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public required V1beta2LinuxWebAppSpecInitProviderStorageAccountAccessKeySecretRef AccessKeySecretRef { get; set; }

    /// <summary>The Name of the Storage Account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The path at which to mount the storage share.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>The name which should be used for this Storage Account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Name of the File Share or Container Name for Blob storage.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>The Azure Storage Type. Possible values include AzureFiles and AzureBlob</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2LinuxWebAppSpecInitProvider
{
    /// <summary>A map of key-value pairs of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettings? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public V1beta2LinuxWebAppSpecInitProviderAuthSettingsV2? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2LinuxWebAppSpecInitProviderBackup? Backup { get; set; }

    /// <summary>Should Client Affinity be enabled?</summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>Should Client Certificates be enabled?</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The Client Certificate mode. Possible values are Required, Optional, and OptionalInteractiveUser. This property has no effect when client_certificate_enabled is false. Defaults to Required.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta2LinuxWebAppSpecInitProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>Should the Linux Web App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>Should the Linux Web App require HTTPS connections. Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2LinuxWebAppSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Azure Region where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public V1beta2LinuxWebAppSpecInitProviderLogs? Logs { get; set; }

    /// <summary>Should public network access be enabled for the Web App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Service Plan that this Linux App Service will be created in.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdRef")]
    public V1beta2LinuxWebAppSpecInitProviderServicePlanIdRef? ServicePlanIdRef { get; set; }

    /// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdSelector")]
    public V1beta2LinuxWebAppSpecInitProviderServicePlanIdSelector? ServicePlanIdSelector { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public V1beta2LinuxWebAppSpecInitProviderSiteConfig? SiteConfig { get; set; }

    /// <summary>A sticky_settings block as defined below.</summary>
    [JsonPropertyName("stickySettings")]
    public V1beta2LinuxWebAppSpecInitProviderStickySettings? StickySettings { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2LinuxWebAppSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Linux Web App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether backup and restore operations over the linked virtual network are enabled. Defaults to false.</summary>
    [JsonPropertyName("virtualNetworkBackupRestoreEnabled")]
    public bool? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxWebAppSpecInitProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>Should the traffic for the image pull be routed over virtual network enabled. Defaults to false.</summary>
    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Linux Web App.
    /// The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecManagementPoliciesEnum>))]
public enum V1beta2LinuxWebAppSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2LinuxWebAppSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxWebAppSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2LinuxWebAppSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxWebAppSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxWebAppSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxWebAppSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>LinuxWebAppSpec defines the desired state of LinuxWebApp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppSpec
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
    public V1beta2LinuxWebAppSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2LinuxWebAppSpecForProvider ForProvider { get; set; }

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
    public V1beta2LinuxWebAppSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2LinuxWebAppSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2LinuxWebAppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2LinuxWebAppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An active_directory block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsActiveDirectory
{
    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>A facebook block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsFacebook
{
    /// <summary>
    /// The App ID of the Facebook app used for login.
    /// The App ID of the Facebook app used for login.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>
    /// The app setting name that contains the app_secret value used for Facebook Login.
    /// The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.
    /// </summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A github block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsGithub
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the GitHub app used for login.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A google block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsGoogle
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OpenID Connect Client ID for the Google web application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, &quot;openid&quot;, &quot;profile&quot;, and &quot;email&quot; are used as default scopes.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A microsoft block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsMicrosoft
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, &quot;wl.basic&quot; is used as the default scope.
    /// The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A twitter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsTwitter
{
    /// <summary>
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>A auth_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsActiveDirectory? ActiveDirectory { get; set; }

    /// <summary>
    /// Specifies a map of login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    [JsonPropertyName("additionalLoginParameters")]
    public IDictionary<string, string>? AdditionalLoginParameters { get; set; }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Linux Web App.
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: BuiltInAuthenticationProviderAzureActiveDirectory, BuiltInAuthenticationProviderFacebook, BuiltInAuthenticationProviderGoogle, BuiltInAuthenticationProviderMicrosoftAccount, BuiltInAuthenticationProviderTwitter, BuiltInAuthenticationProviderGithub
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled for the Linux Web App?
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsFacebook? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsGithub? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsGoogle? Google { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity that issues access tokens for this Linux Web App.
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsMicrosoft? Microsoft { get; set; }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use for the Linux Web App.
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours.
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>
    /// Should the Linux Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to false.
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsTwitter? Twitter { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous.
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>An active_directory_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2ActiveDirectoryV2
{
    /// <summary>
    /// The list of allowed Applications for the Default Authorisation Policy.
    /// The list of allowed Applications for the Default Authorisation Policy.
    /// </summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The list of allowed Group Names for the Default Authorisation Policy.
    /// The list of allowed Group Names for the Default Authorisation Policy.
    /// </summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }

    /// <summary>
    /// The list of allowed Identities for the Default Authorisation Policy.
    /// The list of allowed Identities for the Default Authorisation Policy.
    /// </summary>
    [JsonPropertyName("allowedIdentities")]
    public IList<string>? AllowedIdentities { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The thumbprint of the certificate used for signing purposes.
    /// The thumbprint of the certificate used for signing purposes.
    /// </summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The App Setting name that contains the client secret of the Client.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// A list of Allowed Client Applications in the JWT Claim.
    /// A list of Allowed Client Applications in the JWT Claim.
    /// </summary>
    [JsonPropertyName("jwtAllowedClientApplications")]
    public IList<string>? JwtAllowedClientApplications { get; set; }

    /// <summary>
    /// A list of Allowed Groups in the JWT Claim.
    /// A list of Allowed Groups in the JWT Claim.
    /// </summary>
    [JsonPropertyName("jwtAllowedGroups")]
    public IList<string>? JwtAllowedGroups { get; set; }

    /// <summary>
    /// A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.
    /// A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.
    /// </summary>
    [JsonPropertyName("loginParameters")]
    public IDictionary<string, string>? LoginParameters { get; set; }

    /// <summary>
    /// The Azure Tenant Endpoint for the Authenticating Tenant. e.g. https://login.microsoftonline.com/{tenant-guid}/v2.0/
    /// The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
    /// </summary>
    [JsonPropertyName("tenantAuthEndpoint")]
    public string? TenantAuthEndpoint { get; set; }

    /// <summary>
    /// Should the www-authenticate provider should be omitted from the request? Defaults to false.
    /// Should the www-authenticate provider should be omitted from the request? Defaults to `false`
    /// </summary>
    [JsonPropertyName("wwwAuthenticationDisabled")]
    public bool? WwwAuthenticationDisabled { get; set; }
}

/// <summary>An apple_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2AppleV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OpenID Connect Client ID for the Apple web application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Apple Login.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>The list of Login scopes that should be requested as part of Microsoft Account authentication.</summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>An azure_static_web_app_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Static Web App Authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2CustomOidcV2
{
    /// <summary>
    /// The endpoint to make the Authorisation Request as supplied by openid_configuration_endpoint response.
    /// The endpoint to make the Authorisation Request.
    /// </summary>
    [JsonPropertyName("authorisationEndpoint")]
    public string? AuthorisationEndpoint { get; set; }

    /// <summary>
    /// The endpoint that provides the keys necessary to validate the token as supplied by openid_configuration_endpoint response.
    /// The endpoint that provides the keys necessary to validate the token.
    /// </summary>
    [JsonPropertyName("certificationUri")]
    public string? CertificationUri { get; set; }

    /// <summary>
    /// The Client Credential Method used.
    /// The Client Credential Method used. Currently the only supported value is `ClientSecretPost`.
    /// </summary>
    [JsonPropertyName("clientCredentialMethod")]
    public string? ClientCredentialMethod { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with this Custom OIDC.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The App Setting name that contains the secret for this Custom OIDC Client.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The endpoint that issued the Token as supplied by openid_configuration_endpoint response.
    /// The endpoint that issued the Token.
    /// </summary>
    [JsonPropertyName("issuerEndpoint")]
    public string? IssuerEndpoint { get; set; }

    /// <summary>
    /// The name which should be used for this Storage Account.
    /// The name of the Custom OIDC Authentication Provider.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the claim that contains the users name.
    /// The name of the claim that contains the users name.
    /// </summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary>
    /// Specifies the endpoint used for OpenID Connect Discovery. For example https://example.com/.well-known/openid-configuration.
    /// The endpoint that contains all the configuration endpoints for this Custom OIDC provider.
    /// </summary>
    [JsonPropertyName("openidConfigurationEndpoint")]
    public string? OpenidConfigurationEndpoint { get; set; }

    /// <summary>
    /// The list of the scopes that should be requested while authenticating.
    /// The list of the scopes that should be requested while authenticating.
    /// </summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>
    /// The endpoint used to request a Token as supplied by openid_configuration_endpoint response.
    /// The endpoint used to request a Token.
    /// </summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary>A facebook_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2FacebookV2
{
    /// <summary>
    /// The App ID of the Facebook app used for login.
    /// The App ID of the Facebook app used for login.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>
    /// The app setting name that contains the app_secret value used for Facebook Login.
    /// The app setting name that contains the `app_secret` value used for Facebook Login.
    /// </summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>
    /// The version of the Facebook API to be used while logging in.
    /// The version of the Facebook API to be used while logging in.
    /// </summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// Specifies a list of scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A github_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2GithubV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the GitHub app used for login.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for GitHub Login.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A google_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2GoogleV2
{
    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed Audiences that will be requested as part of Google Sign-In authentication.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OpenID Connect Client ID for the Google web application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Google Login.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// Specifies a list of Login scopes that will be requested as part of Google Sign-In authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A login block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2Login
{
    /// <summary>
    /// External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends.
    /// External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. **Note:** URLs within the current domain are always implicitly allowed.
    /// </summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The method by which cookies expire. Possible values include: FixedTime, and IdentityProviderDerived. Defaults to FixedTime.
    /// The method by which cookies expire. Possible values include: `FixedTime`, and `IdentityProviderDerived`. Defaults to `FixedTime`.
    /// </summary>
    [JsonPropertyName("cookieExpirationConvention")]
    public string? CookieExpirationConvention { get; set; }

    /// <summary>
    /// The time after the request is made when the session cookie should expire. Defaults to 08:00:00.
    /// The time after the request is made when the session cookie should expire. Defaults to `08:00:00`.
    /// </summary>
    [JsonPropertyName("cookieExpirationTime")]
    public string? CookieExpirationTime { get; set; }

    /// <summary>
    /// The endpoint to which logout requests should be made.
    /// The endpoint to which logout requests should be made.
    /// </summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }

    /// <summary>
    /// The time after the request is made when the nonce should expire. Defaults to 00:05:00.
    /// The time after the request is made when the nonce should expire. Defaults to `00:05:00`.
    /// </summary>
    [JsonPropertyName("nonceExpirationTime")]
    public string? NonceExpirationTime { get; set; }

    /// <summary>
    /// Should the fragments from the request be preserved after the login request is made. Defaults to false.
    /// Should the fragments from the request be preserved after the login request is made. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72 hours.
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [JsonPropertyName("tokenRefreshExtensionTime")]
    public double? TokenRefreshExtensionTime { get; set; }

    /// <summary>
    /// Should the Token Store configuration Enabled. Defaults to false
    /// Should the Token Store configuration Enabled. Defaults to `false`
    /// </summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>
    /// The directory path in the App Filesystem in which the tokens will be stored.
    /// The directory path in the App Filesystem in which the tokens will be stored.
    /// </summary>
    [JsonPropertyName("tokenStorePath")]
    public string? TokenStorePath { get; set; }

    /// <summary>
    /// The name of the app setting which contains the SAS URL of the blob storage containing the tokens.
    /// The name of the app setting which contains the SAS URL of the blob storage containing the tokens.
    /// </summary>
    [JsonPropertyName("tokenStoreSasSettingName")]
    public string? TokenStoreSasSettingName { get; set; }

    /// <summary>
    /// Should the nonce be validated while completing the login flow. Defaults to true.
    /// Should the nonce be validated while completing the login flow. Defaults to `true`.
    /// </summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary>A microsoft_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2MicrosoftV2
{
    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// The list of Login scopes that should be requested as part of Microsoft Account authentication.
    /// The list of Login scopes that will be requested as part of Microsoft Account authentication.
    /// </summary>
    [JsonPropertyName("loginScopes")]
    public IList<string>? LoginScopes { get; set; }
}

/// <summary>A twitter_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2TwitterV2
{
    /// <summary>
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>An auth_settings_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2AppleV2? AppleV2 { get; set; }

    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to false.
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2 { get; set; }

    /// <summary>
    /// The path to the App Auth settings.
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

    /// <summary>
    /// The Default Authentication Provider to use when the unauthenticated_action is set to RedirectToLoginPage. Possible values include: apple, azureactivedirectory, facebook, github, google, twitter and the name of your custom_oidc_v2 provider.
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>
    /// The paths which should be excluded from the unauthenticated_action when it is set to RedirectToLoginPage.
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>A facebook_v2 block as defined below.</summary>
    [JsonPropertyName("facebookV2")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2FacebookV2? FacebookV2 { get; set; }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include NoProxy, Standard, Custom. Defaults to NoProxy.
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    [JsonPropertyName("forwardProxyConvention")]
    public string? ForwardProxyConvention { get; set; }

    /// <summary>
    /// The name of the custom header containing the host of the request.
    /// The name of the header containing the host of the request.
    /// </summary>
    [JsonPropertyName("forwardProxyCustomHostHeaderName")]
    public string? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>
    /// The name of the custom header containing the scheme of the request.
    /// The name of the header containing the scheme of the request.
    /// </summary>
    [JsonPropertyName("forwardProxyCustomSchemeHeaderName")]
    public string? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>A github_v2 block as defined below.</summary>
    [JsonPropertyName("githubV2")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2GithubV2? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2GoogleV2? GoogleV2 { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth.
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2Login? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2MicrosoftV2? MicrosoftV2 { get; set; }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// Should the authentication flow be used for all requests.
    /// </summary>
    [JsonPropertyName("requireAuthentication")]
    public bool? RequireAuthentication { get; set; }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to ~1.
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>A twitter_v2 block as defined below.</summary>
    [JsonPropertyName("twitterV2")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2TwitterV2? TwitterV2 { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage.
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderBackupSchedule
{
    /// <summary>
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day).
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).
    /// </summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>
    /// The unit of time for how often the backup should take place. Possible values include: Day, Hour
    /// The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.
    /// </summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>
    /// Should the service keep at least one backup, regardless of the age of backup? Defaults to false.
    /// Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("keepAtLeastOneBackup")]
    public bool? KeepAtLeastOneBackup { get; set; }

    /// <summary>The time the backup was last attempted.</summary>
    [JsonPropertyName("lastExecutionTime")]
    public string? LastExecutionTime { get; set; }

    /// <summary>
    /// After how many days backups should be deleted. Defaults to 30.
    /// After how many days backups should be deleted.
    /// </summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }

    /// <summary>
    /// When the schedule should start working in RFC-3339 format.
    /// When the schedule should start working in RFC-3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>A backup block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderBackup
{
    /// <summary>
    /// Should this backup job be enabled? Defaults to true.
    /// Should this backup job be enabled?
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The name which should be used for this Backup.
    /// The name which should be used for this Backup.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2LinuxWebAppStatusAtProviderBackupSchedule? Schedule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderConnectionString
{
    /// <summary>
    /// The name of the Connection String.
    /// The name which should be used for this Connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type of database. Possible values include: MySQL, SQLServer, SQLAzure, Custom, NotificationHub, ServiceBus, EventHub, APIHub, DocDb, RedisCache, and PostgreSQL.
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Linux Web App.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Web App. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A azure_blob_storage_http block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderLogsApplicationLogsAzureBlobStorage
{
    /// <summary>The level at which to log. Possible values include Error, Warning, Information, Verbose and Off. NOTE: this field is not available for http_logs</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>SAS url to an Azure blob container with read/write/list/delete permissions.</summary>
    [JsonPropertyName("sasUrl")]
    public string? SasUrl { get; set; }
}

/// <summary>A application_logs block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderLogsApplicationLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1beta2LinuxWebAppStatusAtProviderLogsApplicationLogsAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary>Log level. Possible values include: Off, Verbose, Information, Warning, and Error.</summary>
    [JsonPropertyName("fileSystemLevel")]
    public string? FileSystemLevel { get; set; }
}

/// <summary>A azure_blob_storage_http block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderLogsHttpLogsAzureBlobStorage
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }
}

/// <summary>A file_system block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderLogsHttpLogsFileSystem
{
    /// <summary>The retention period in days. A value of 0 means no retention.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }

    /// <summary>The maximum size in megabytes that log files can use.</summary>
    [JsonPropertyName("retentionInMb")]
    public double? RetentionInMb { get; set; }
}

/// <summary>An http_logs block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderLogsHttpLogs
{
    /// <summary>A azure_blob_storage_http block as defined above.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1beta2LinuxWebAppStatusAtProviderLogsHttpLogsAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary>A file_system block as defined above.</summary>
    [JsonPropertyName("fileSystem")]
    public V1beta2LinuxWebAppStatusAtProviderLogsHttpLogsFileSystem? FileSystem { get; set; }
}

/// <summary>A logs block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderLogs
{
    /// <summary>A application_logs block as defined above.</summary>
    [JsonPropertyName("applicationLogs")]
    public V1beta2LinuxWebAppStatusAtProviderLogsApplicationLogs? ApplicationLogs { get; set; }

    /// <summary>Should detailed error messages be enabled?</summary>
    [JsonPropertyName("detailedErrorMessages")]
    public bool? DetailedErrorMessages { get; set; }

    /// <summary>Should the failed request tracing be enabled?</summary>
    [JsonPropertyName("failedRequestTracing")]
    public bool? FailedRequestTracing { get; set; }

    /// <summary>An http_logs block as defined above.</summary>
    [JsonPropertyName("httpLogs")]
    public V1beta2LinuxWebAppStatusAtProviderLogsHttpLogs? HttpLogs { get; set; }
}

/// <summary>A application_stack block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigApplicationStack
{
    /// <summary>The docker image, including tag, to be used. e.g. appsvc/staticsite:latest.</summary>
    [JsonPropertyName("dockerImageName")]
    public string? DockerImageName { get; set; }

    /// <summary>The URL of the container registry where the docker_image_name is located. e.g. https://index.docker.io or https://mcr.microsoft.com. This value is required with docker_image_name.</summary>
    [JsonPropertyName("dockerRegistryUrl")]
    public string? DockerRegistryUrl { get; set; }

    /// <summary>The User Name to use for authentication against the registry to pull the image.</summary>
    [JsonPropertyName("dockerRegistryUsername")]
    public string? DockerRegistryUsername { get; set; }

    /// <summary>The version of .NET to use. Possible values include 3.1, 5.0, 6.0, 7.0, 8.0, 9.0and 10.0.</summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>The version of Go to use. Possible values include 1.18, and 1.19.</summary>
    [JsonPropertyName("goVersion")]
    public string? GoVersion { get; set; }

    /// <summary>The Java server type. Possible values include JAVA, TOMCAT, and JBOSSEAP.</summary>
    [JsonPropertyName("javaServer")]
    public string? JavaServer { get; set; }

    /// <summary>The Version of the java_server to use.</summary>
    [JsonPropertyName("javaServerVersion")]
    public string? JavaServerVersion { get; set; }

    /// <summary>The Version of Java to use. Possible values include 8, 11, 17, and 21.</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>The version of Node to run. Possible values include 12-lts, 14-lts, 16-lts, 18-lts, 20-lts and 22-lts. This property conflicts with java_version.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The version of PHP to run. Possible values are 7.4, 8.0, 8.1, 8.2, 8.3 and 8.4.</summary>
    [JsonPropertyName("phpVersion")]
    public string? PhpVersion { get; set; }

    /// <summary>The version of Python to run. Possible values include 3.13, 3.12, 3.11, 3.10, 3.9, 3.8 and 3.7.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The version of Ruby to run. Possible values include 2.6 and 2.7.</summary>
    [JsonPropertyName("rubyVersion")]
    public string? RubyVersion { get; set; }
}

/// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingAction
{
    /// <summary>Predefined action to be taken to an Auto Heal trigger. Possible values include: Recycle.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The minimum amount of time in hh:mm:ss the Linux Web App must have been running before the defined action will be run in the event of a trigger.</summary>
    [JsonPropertyName("minimumProcessExecutionTime")]
    public string? MinimumProcessExecutionTime { get; set; }
}

/// <summary>A requests block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerRequests
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }
}

/// <summary>A slow_request blocks as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequest
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The threshold of time passed to qualify as a Slow Request in hh:mm:ss.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The threshold of time passed to qualify as a Slow Request in hh:mm:ss.</summary>
    [JsonPropertyName("timeTaken")]
    public string? TimeTaken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerStatusCode
{
    /// <summary>The number of occurrences of the defined status_code in the specified interval on which to trigger this rule.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The time interval in the form hh:mm:ss.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>The path to which this rule status code applies.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The status code for this rule, accepts single status codes and status code ranges. e.g. 500 or 400-499. Possible values are integers between 101 and 599</summary>
    [JsonPropertyName("statusCodeRange")]
    public string? StatusCodeRange { get; set; }

    /// <summary>The Request Sub Status of the Status Code.</summary>
    [JsonPropertyName("subStatus")]
    public double? SubStatus { get; set; }

    /// <summary>The Win32 Status Code of the Request.</summary>
    [JsonPropertyName("win32StatusCode")]
    public double? Win32StatusCode { get; set; }
}

/// <summary>A trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTrigger
{
    /// <summary>A requests block as defined above.</summary>
    [JsonPropertyName("requests")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerRequests? Requests { get; set; }

    /// <summary>A slow_request blocks as defined above.</summary>
    [JsonPropertyName("slowRequest")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest { get; set; }

    /// <summary>One or more slow_request_with_path blocks as defined above.</summary>
    [JsonPropertyName("slowRequestWithPath")]
    public IList<V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerSlowRequestWithPath>? SlowRequestWithPath { get; set; }

    /// <summary>One or more status_code blocks as defined above.</summary>
    [JsonPropertyName("statusCode")]
    public IList<V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTriggerStatusCode>? StatusCode { get; set; }
}

/// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSetting
{
    /// <summary>The action to take. Possible values are Allow or Deny. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingAction? Action { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSettingTrigger? Trigger { get; set; }
}

/// <summary>A cors block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigCors
{
    /// <summary>
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// Whether CORS requests with credentials are allowed. Defaults to false
    /// Are credentials allowed in CORS requests? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigIpRestriction
{
    /// <summary>
    /// The action to take. Possible values are Allow or Deny. Defaults to Allow.
    /// The action to take. Possible values are `Allow` or `Deny`.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// The Description of this IP Restriction.
    /// The description of the IP restriction rule.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfigIpRestrictionHeaders? Headers { get; set; }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// The name which should be used for this Storage Account.
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The priority value of this ip_restriction. Defaults to 65000.
    /// The priority value of this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>
    /// The subnet id which will be used by this Web App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>Specifies a list of Azure Front Door IDs.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>Specifies if a Front Door Health Probe should be expected. The only possible value is 1.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>Specifies a list of addresses for which matching should be applied. Omitting this value means allow any.</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>Specifies a list of Hosts for which matching should be applied.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfigScmIpRestriction
{
    /// <summary>
    /// The action to take. Possible values are Allow or Deny. Defaults to Allow.
    /// The action to take. Possible values are `Allow` or `Deny`.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// The Description of this IP Restriction.
    /// The description of the IP restriction rule.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A headers block as defined above.</summary>
    [JsonPropertyName("headers")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfigScmIpRestrictionHeaders? Headers { get; set; }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: 10.0.0.0/24 or 192.168.10.1/32
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// The name which should be used for this Storage Account.
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The priority value of this ip_restriction. Defaults to 65000.
    /// The priority value of this `ip_restriction`.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>
    /// The subnet id which will be used by this Web App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary>A site_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderSiteConfig
{
    /// <summary>If this Linux Web App is Always On enabled. Defaults to true.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The URL to the API Definition for this Linux Web App.</summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>The API Management API ID this Linux Web App is associated with.</summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>The App command line to launch.</summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>A application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfigApplicationStack? ApplicationStack { get; set; }

    /// <summary>A auto_heal_setting block as defined above. Required with auto_heal.</summary>
    [JsonPropertyName("autoHealSetting")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfigAutoHealSetting? AutoHealSetting { get; set; }

    /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfigCors? Cors { get; set; }

    /// <summary>Specifies a list of Default Documents for the Linux Web App.</summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>Should the Linux Web App be enabled? Defaults to true.</summary>
    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    /// <summary>The State of FTP / FTPS service. Possible values include AllAllowed, FtpsOnly, and Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node can be unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Only valid in conjunction with health_check_path.
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>The path to the Health Check.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Should the HTTP2 be enabled?</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>One or more ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta2LinuxWebAppStatusAtProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>The Site load balancing. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.</summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>Use Local MySQL. Defaults to false.</summary>
    [JsonPropertyName("localMysqlEnabled")]
    public bool? LocalMysqlEnabled { get; set; }

    /// <summary>Managed pipeline mode. Possible values include Integrated, and Classic. Defaults to Integrated.</summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Should Remote Debugging be enabled? Defaults to false.</summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>The Remote Debugging Version. Currently only VS2022 is supported.</summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta2LinuxWebAppStatusAtProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>The configures the minimum version of TLS required for SSL requests to the SCM site Possible values are 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.</summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>Should the Linux Web App ip_restriction configuration be used for the SCM also.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Linux Web App use a 32-bit worker? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false.
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should Web Sockets be enabled? Defaults to false.</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>The number of Workers for this Linux App Service.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>A sticky_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderStickySettings
{
    /// <summary>A list of app_setting names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("appSettingNames")]
    public IList<string>? AppSettingNames { get; set; }

    /// <summary>A list of connection_string names that the Linux Web App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("connectionStringNames")]
    public IList<string>? ConnectionStringNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProviderStorageAccount
{
    /// <summary>The Name of the Storage Account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The path at which to mount the storage share.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>The name which should be used for this Storage Account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Name of the File Share or Container Name for Blob storage.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>The Azure Storage Type. Possible values include AzureFiles and AzureBlob</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusAtProvider
{
    /// <summary>A map of key-value pairs of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettings? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public V1beta2LinuxWebAppStatusAtProviderAuthSettingsV2? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2LinuxWebAppStatusAtProviderBackup? Backup { get; set; }

    /// <summary>Should Client Affinity be enabled?</summary>
    [JsonPropertyName("clientAffinityEnabled")]
    public bool? ClientAffinityEnabled { get; set; }

    /// <summary>Should Client Certificates be enabled?</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>The Client Certificate mode. Possible values are Required, Optional, and OptionalInteractiveUser. This property has no effect when client_certificate_enabled is false. Defaults to Required.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta2LinuxWebAppStatusAtProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>The default hostname of the Linux Web App.</summary>
    [JsonPropertyName("defaultHostname")]
    public string? DefaultHostname { get; set; }

    /// <summary>Should the Linux Web App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>The ID of the App Service Environment used by App Service.</summary>
    [JsonPropertyName("hostingEnvironmentId")]
    public string? HostingEnvironmentId { get; set; }

    /// <summary>Should the Linux Web App require HTTPS connections. Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Linux Web App.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2LinuxWebAppStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity.</summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Kind value for this Linux Web App.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The Azure Region where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public V1beta2LinuxWebAppStatusAtProviderLogs? Logs { get; set; }

    /// <summary>A list of outbound IP addresses - such as [&quot;52.23.25.3&quot;, &quot;52.143.43.12&quot;]</summary>
    [JsonPropertyName("outboundIpAddressList")]
    public IList<string>? OutboundIpAddressList { get; set; }

    /// <summary>A comma separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    /// <summary>A list of possible outbound ip address.</summary>
    [JsonPropertyName("possibleOutboundIpAddressList")]
    public IList<string>? PossibleOutboundIpAddressList { get; set; }

    /// <summary>A comma-separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12,52.143.43.17 - not all of which are necessarily in use. Superset of outbound_ip_addresses.</summary>
    [JsonPropertyName("possibleOutboundIpAddresses")]
    public string? PossibleOutboundIpAddresses { get; set; }

    /// <summary>Should public network access be enabled for the Web App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Linux Web App should exist. Changing this forces a new Linux Web App to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The ID of the Service Plan that this Linux App Service will be created in.</summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public V1beta2LinuxWebAppStatusAtProviderSiteConfig? SiteConfig { get; set; }

    /// <summary>A sticky_settings block as defined below.</summary>
    [JsonPropertyName("stickySettings")]
    public V1beta2LinuxWebAppStatusAtProviderStickySettings? StickySettings { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2LinuxWebAppStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Linux Web App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether backup and restore operations over the linked virtual network are enabled. Defaults to false.</summary>
    [JsonPropertyName("virtualNetworkBackupRestoreEnabled")]
    public bool? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>The subnet id which will be used by this Web App for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Should the traffic for the image pull be routed over virtual network enabled. Defaults to false.</summary>
    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Linux Web App.
    /// The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatusConditions
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

/// <summary>LinuxWebAppStatus defines the observed state of LinuxWebApp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxWebAppStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2LinuxWebAppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2LinuxWebAppStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LinuxWebApp is the Schema for the LinuxWebApps API. Manages a Linux Web App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LinuxWebApp : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2LinuxWebAppSpec>, IStatus<V1beta2LinuxWebAppStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LinuxWebApp";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "linuxwebapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LinuxWebApp";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinuxWebAppSpec defines the desired state of LinuxWebApp</summary>
    [JsonPropertyName("spec")]
    public required V1beta2LinuxWebAppSpec Spec { get; set; }

    /// <summary>LinuxWebAppStatus defines the observed state of LinuxWebApp.</summary>
    [JsonPropertyName("status")]
    public V1beta2LinuxWebAppStatus? Status { get; set; }
}