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
/// <summary>LinuxFunctionApp is the Schema for the LinuxFunctionApps API. Manages a Linux Function App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LinuxFunctionAppList : IKubernetesObject<V1ListMeta>, IItems<V1beta2LinuxFunctionApp>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LinuxFunctionAppList";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "linuxfunctionapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LinuxFunctionAppList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2LinuxFunctionApp objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2LinuxFunctionApp> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecDeletionPolicyEnum>))]
public enum V1beta2LinuxFunctionAppSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsActiveDirectory
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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsFacebookAppSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsFacebook
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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsFacebookAppSecretSecretRef? AppSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name that contains the app_secret value used for Facebook Login.
    /// The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.
    /// </summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsGithubClientSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsGithub
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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsGithubClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsGoogleClientSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsGoogle
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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsGoogleClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, &quot;openid&quot;, &quot;profile&quot;, and &quot;email&quot; are used as default scopes.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsMicrosoft
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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name.
/// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsTwitter
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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef? ConsumerSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>A auth_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsActiveDirectory? ActiveDirectory { get; set; }

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
    /// The default authentication provider to use when multiple providers are configured. Possible values include: AzureActiveDirectory, Facebook, Google, MicrosoftAccount, Twitter, Github
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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsFacebook? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsGithub? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsGoogle? Google { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this Linux Web App.
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsMicrosoft? Microsoft { get; set; }

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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsTwitter? Twitter { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous.
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>An active_directory_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2ActiveDirectoryV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2AppleV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Static Web App Authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2CustomOidcV2
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
    /// The app setting name that contains the client_secret value used for the Custom OIDC Login.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2FacebookV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2GithubV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2GoogleV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2Login
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2MicrosoftV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2TwitterV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2AppleV2? AppleV2 { get; set; }

    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to false.
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2 { get; set; }

    /// <summary>
    /// The path to the App Auth settings.
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2FacebookV2? FacebookV2 { get; set; }

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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2GithubV2? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2GoogleV2? GoogleV2 { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth.
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2Login? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2MicrosoftV2? MicrosoftV2 { get; set; }

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
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2TwitterV2? TwitterV2 { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage.
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderBackupSchedule
{
    /// <summary>
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day).
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).
    /// </summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>
    /// The unit of time for how often the backup should take place. Possible values include: Day and Hour.
    /// The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.
    /// </summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>
    /// Should the service keep at least one backup, regardless of age of backup. Defaults to false.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderBackupStorageAccountUrlSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderBackup
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
    public V1beta2LinuxFunctionAppSpecForProviderBackupSchedule? Schedule { get; set; }

    /// <summary>
    /// The SAS URL to the container.
    /// The SAS URL to the container.
    /// </summary>
    [JsonPropertyName("storageAccountUrlSecretRef")]
    public V1beta2LinuxFunctionAppSpecForProviderBackupStorageAccountUrlSecretRef? StorageAccountUrlSecretRef { get; set; }
}

/// <summary>
/// The connection string value.
/// The connection string value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderConnectionStringValueSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderConnectionString
{
    /// <summary>
    /// The name which should be used for this Connection.
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
    public V1beta2LinuxFunctionAppSpecForProviderConnectionStringValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>A identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Linux Function App.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Function App. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelector
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
    public V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelector
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
    public V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An app_service_logs block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigAppServiceLogs
{
    /// <summary>
    /// The amount of disk space to use for logs. Valid values are between 25 and 100. Defaults to 35.
    /// The amount of disk space to use for logs. Valid values are between `25` and `100`.
    /// </summary>
    [JsonPropertyName("diskQuotaMb")]
    public double? DiskQuotaMb { get; set; }

    /// <summary>
    /// After how many days backups should be deleted. Defaults to 30.
    /// The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).
    /// </summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }
}

/// <summary>
/// The Connection String for linking the Linux Function App to Application Insights.
/// The Connection String for linking the Linux Function App to Application Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationInsightsConnectionStringSecretRef
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

/// <summary>
/// The Instrumentation Key for connecting the Linux Function App to Application Insights.
/// The Instrumentation Key for connecting the Linux Function App to Application Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationInsightsKeySecretRef
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

/// <summary>
/// The password for the account to use to connect to the registry.
/// The password for the account to use to connect to the registry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef
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

/// <summary>
/// The username to use for connections to the registry.
/// The username to use for connections to the registry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationStackDockerRegistryUsernameSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationStackDocker
{
    /// <summary>
    /// The name of the Docker image to use.
    /// The name of the Docker image to use.
    /// </summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>
    /// The image tag of the image to use.
    /// The image tag of the image to use.
    /// </summary>
    [JsonPropertyName("imageTag")]
    public string? ImageTag { get; set; }

    /// <summary>
    /// The password for the account to use to connect to the registry.
    /// The password for the account to use to connect to the registry.
    /// </summary>
    [JsonPropertyName("registryPasswordSecretRef")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef? RegistryPasswordSecretRef { get; set; }

    /// <summary>
    /// The URL of the docker registry.
    /// The URL of the docker registry.
    /// </summary>
    [JsonPropertyName("registryUrl")]
    public string? RegistryUrl { get; set; }

    /// <summary>
    /// The username to use for connections to the registry.
    /// The username to use for connections to the registry.
    /// </summary>
    [JsonPropertyName("registryUsernameSecretRef")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationStackDockerRegistryUsernameSecretRef? RegistryUsernameSecretRef { get; set; }
}

/// <summary>An application_stack block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationStack
{
    /// <summary>
    /// One or more docker blocks as defined below.
    /// A docker block
    /// </summary>
    [JsonPropertyName("docker")]
    public IList<V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationStackDocker>? Docker { get; set; }

    /// <summary>
    /// The version of .NET to use. Possible values include 3.1, 6.0, 7.0, 8.0, 9.0 and 10.0.
    /// The version of .Net. Possible values are `3.1`, `6.0`, `7.0`, `8.0` and `9.0`
    /// </summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>
    /// The Version of Java to use. Supported versions include 8, 11, 17, 21.
    /// The version of Java to use. Possible values are `8`, `11`, `17`, and `21`
    /// </summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>
    /// The version of Node to run. Possible values include 12, 14, 16, 18 20 and 22.
    /// The version of Node to use. Possible values include `12`, `14`, `16`, `18`, `20` and `22`
    /// </summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>
    /// The version of PowerShell Core to run. Possible values are 7, 7.2, and 7.4.
    /// The version of PowerShell Core to use. Possibles values are `7`, `7.2`, and `7.4`
    /// </summary>
    [JsonPropertyName("powershellCoreVersion")]
    public string? PowershellCoreVersion { get; set; }

    /// <summary>
    /// The version of Python to run. Possible values are 3.13, 3.12, 3.11, 3.10, 3.9, 3.8 and 3.7.
    /// The version of Python to use. Possible values include `3.13`, `3.12`, `3.11`, `3.10`, `3.9`, `3.8`, and `3.7`.
    /// </summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>Should the Linux Function App use a custom runtime?</summary>
    [JsonPropertyName("useCustomRuntime")]
    public bool? UseCustomRuntime { get; set; }

    /// <summary>
    /// Should the DotNet process use an isolated runtime. Defaults to false.
    /// Should the DotNet process use an isolated runtime. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("useDotnetIsolatedRuntime")]
    public bool? UseDotnetIsolatedRuntime { get; set; }
}

/// <summary>A cors block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigCors
{
    /// <summary>
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// Are credentials allowed in CORS requests? Defaults to false.
    /// Are credentials allowed in CORS requests? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionHeaders
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestriction
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
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionHeaders? Headers { get; set; }

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
    /// The subnet id which will be used by this Function App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionHeaders
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestriction
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
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionHeaders? Headers { get; set; }

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
    /// The subnet id which will be used by this Function App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A site_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderSiteConfig
{
    /// <summary>
    /// If this Linux Web App is Always On enabled. Defaults to false.
    /// If this Linux Web App is Always On enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>
    /// The URL of the API definition that describes this Linux Function App.
    /// The URL of the API definition that describes this Linux Function App.
    /// </summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>
    /// The ID of the API Management API for this Linux Function App.
    /// The ID of the API Management API for this Linux Function App.
    /// </summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>
    /// The App command line to launch.
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// </summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>An app_service_logs block as defined above.</summary>
    [JsonPropertyName("appServiceLogs")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigAppServiceLogs? AppServiceLogs { get; set; }

    /// <summary>
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// </summary>
    [JsonPropertyName("applicationInsightsConnectionStringSecretRef")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationInsightsConnectionStringSecretRef? ApplicationInsightsConnectionStringSecretRef { get; set; }

    /// <summary>
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// </summary>
    [JsonPropertyName("applicationInsightsKeySecretRef")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationInsightsKeySecretRef? ApplicationInsightsKeySecretRef { get; set; }

    /// <summary>An application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigApplicationStack? ApplicationStack { get; set; }

    /// <summary>
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// </summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>
    /// Should connections for Azure Container Registry use Managed Identity.
    /// Should connections for Azure Container Registry use Managed Identity.
    /// </summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfigCors? Cors { get; set; }

    /// <summary>
    /// Specifies a list of Default Documents for the Linux Web App.
    /// Specifies a list of Default Documents for the Linux Web App.
    /// </summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>
    /// State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled. Defaults to Disabled.
    /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.
    /// </summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node can be unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Only valid in conjunction with health_check_path.
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>
    /// The path to be checked for this function app health.
    /// The path to be checked for this function app health.
    /// </summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>
    /// Specifies if the HTTP2 protocol should be enabled. Defaults to false.
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>One or more ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta2LinuxFunctionAppSpecForProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// The Site load balancing mode. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>
    /// Managed pipeline mode. Possible values include: Integrated, Classic. Defaults to Integrated.
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.
    /// </summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// </summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to false.
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The Remote Debugging Version. Currently only VS2022 is supported.
    /// The Remote Debugging Version. Currently only `VS2022` is supported.
    /// </summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>
    /// Should Scale Monitoring of the Functions Runtime be enabled?
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta2LinuxFunctionAppSpecForProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, `1.2` and  `1.3`. Defaults to `1.2`.
    /// </summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>
    /// Should the Linux Function App ip_restriction configuration be used for the SCM also.
    /// Should the Linux Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// Should the Linux Web App use a 32-bit worker process. Defaults to false.
    /// Should the Linux Web App use a 32-bit worker.
    /// </summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic to have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false.
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// Should Web Sockets be enabled. Defaults to false.
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>
    /// The number of Workers for this Linux Function App.
    /// The number of Workers for this Linux Function App.
    /// </summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>A sticky_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderStickySettings
{
    /// <summary>A list of app_setting names that the Linux Function App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("appSettingNames")]
    public IList<string>? AppSettingNames { get; set; }

    /// <summary>A list of connection_string names that the Linux Function App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("connectionStringNames")]
    public IList<string>? ConnectionStringNames { get; set; }
}

/// <summary>The Access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderStorageAccountAccessKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderStorageAccount
{
    /// <summary>The Access key for the storage account.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountAccessKeySecretRef? AccessKeySecretRef { get; set; }

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

    /// <summary>The Azure Storage Type. Possible values include AzureFiles and AzureBlob.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// The access key which will be used to access the backend storage account for the Function App. Conflicts with storage_uses_managed_identity.
/// The access key which will be used to access the storage account for the Function App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderStorageAccountAccessKeySecretRef1
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelector
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
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecForProvider
{
    /// <summary>
    /// A map of key-value pairs for App Settings and custom values.
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettings? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public V1beta2LinuxFunctionAppSpecForProviderAuthSettingsV2? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2LinuxFunctionAppSpecForProviderBackup? Backup { get; set; }

    /// <summary>
    /// Should built in logging be enabled. Configures AzureWebJobsDashboard app setting based on the configured storage setting. Defaults to true.
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting
    /// </summary>
    [JsonPropertyName("builtinLoggingEnabled")]
    public bool? BuiltinLoggingEnabled { get; set; }

    /// <summary>
    /// Should the function app use Client Certificates.
    /// Should the function app use Client Certificates
    /// </summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>
    /// The mode of the Function App&apos;s client certificates requirement for incoming requests. Possible values are Required, Optional, and OptionalInteractiveUser. Defaults to Optional.
    /// The mode of the Function App&apos;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`
    /// </summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta2LinuxFunctionAppSpecForProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>
    /// Should the settings for linking the Function App to storage be suppressed.
    /// Force disable the content share settings.
    /// </summary>
    [JsonPropertyName("contentShareForceDisabled")]
    public bool? ContentShareForceDisabled { get; set; }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan. Defaults to 0.
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>
    /// Is the Function App enabled? Defaults to true.
    /// Is the Linux Function App enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The runtime version associated with the Function App. Defaults to ~4.
    /// The runtime version associated with the Function App.
    /// </summary>
    [JsonPropertyName("functionsExtensionVersion")]
    public string? FunctionsExtensionVersion { get; set; }

    /// <summary>
    /// Can the Function App only be accessed via HTTPS? Defaults to false.
    /// Can the Function App only be accessed via HTTPS?
    /// </summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>A identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2LinuxFunctionAppSpecForProviderIdentity? Identity { get; set; }

    /// <summary>
    /// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Azure Region where the Linux Function App should exist. Changing this forces a new Linux Function App to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The name which should be used for this Linux Function App. Changing this forces a new Linux Function App to be created. Limit the function name to 32 characters to avoid naming collisions. For more information about Function App naming rule and Host ID Collisions
    /// Specifies the name of the Function App.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Should public network access be enabled for the Function App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Linux Function App should exist. Changing this forces a new Linux Function App to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2LinuxFunctionAppSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>
    /// The ID of the App Service Plan within which to create this Function App.
    /// The ID of the App Service Plan within which to create this Function App
    /// </summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdRef")]
    public V1beta2LinuxFunctionAppSpecForProviderServicePlanIdRef? ServicePlanIdRef { get; set; }

    /// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdSelector")]
    public V1beta2LinuxFunctionAppSpecForProviderServicePlanIdSelector? ServicePlanIdSelector { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public V1beta2LinuxFunctionAppSpecForProviderSiteConfig? SiteConfig { get; set; }

    /// <summary>A sticky_settings block as defined below.</summary>
    [JsonPropertyName("stickySettings")]
    public V1beta2LinuxFunctionAppSpecForProviderStickySettings? StickySettings { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2LinuxFunctionAppSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>
    /// The access key which will be used to access the backend storage account for the Function App. Conflicts with storage_uses_managed_identity.
    /// The access key which will be used to access the storage account for the Function App.
    /// </summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountAccessKeySecretRef1? StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>
    /// The backend storage account name which will be used by this Function App.
    /// The backend storage account name which will be used by this Function App.
    /// </summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameRef")]
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameRef? StorageAccountNameRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameSelector")]
    public V1beta2LinuxFunctionAppSpecForProviderStorageAccountNameSelector? StorageAccountNameSelector { get; set; }

    /// <summary>
    /// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    [JsonPropertyName("storageKeyVaultSecretId")]
    public string? StorageKeyVaultSecretId { get; set; }

    /// <summary>
    /// Should the Function App use Managed Identity to access the storage account. Conflicts with storage_account_access_key.
    /// Should the Function App use its Managed Identity to access storage?
    /// </summary>
    [JsonPropertyName("storageUsesManagedIdentity")]
    public bool? StorageUsesManagedIdentity { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Linux Function App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether backup and restore operations over the linked virtual network are enabled. Defaults to false.</summary>
    [JsonPropertyName("virtualNetworkBackupRestoreEnabled")]
    public bool? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>The subnet id which will be used by this Function App for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxFunctionAppSpecForProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>
    /// Should the traffic for the image pull be routed over virtual network enabled. Defaults to false.
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Linux Function App.
    /// The local path and filename of the Zip packaged application to deploy to this Linux Function App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsActiveDirectoryClientSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsActiveDirectory
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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsFacebookAppSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsFacebook
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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsFacebookAppSecretSecretRef? AppSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name that contains the app_secret value used for Facebook Login.
    /// The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.
    /// </summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsGithubClientSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsGithub
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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsGithubClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsGoogleClientSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsGoogle
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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsGoogleClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, &quot;openid&quot;, &quot;profile&quot;, and &quot;email&quot; are used as default scopes.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with client_secret_setting_name.
/// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsMicrosoftClientSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsMicrosoft
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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsMicrosoftClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.
    /// </summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>
/// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with consumer_secret_setting_name.
/// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsTwitterConsumerSecretSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsTwitter
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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsTwitterConsumerSecretSecretRef? ConsumerSecretSecretRef { get; set; }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>A auth_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsActiveDirectory? ActiveDirectory { get; set; }

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
    /// The default authentication provider to use when multiple providers are configured. Possible values include: AzureActiveDirectory, Facebook, Google, MicrosoftAccount, Twitter, Github
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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsFacebook? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsGithub? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsGoogle? Google { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this Linux Web App.
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsMicrosoft? Microsoft { get; set; }

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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsTwitter? Twitter { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous.
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>An active_directory_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2ActiveDirectoryV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2AppleV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Static Web App Authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2CustomOidcV2
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
    /// The app setting name that contains the client_secret value used for the Custom OIDC Login.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2FacebookV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2GithubV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2GoogleV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2Login
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2MicrosoftV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2TwitterV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2AppleV2? AppleV2 { get; set; }

    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to false.
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2 { get; set; }

    /// <summary>
    /// The path to the App Auth settings.
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2FacebookV2? FacebookV2 { get; set; }

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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2GithubV2? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2GoogleV2? GoogleV2 { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth.
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2Login? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2MicrosoftV2? MicrosoftV2 { get; set; }

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
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2TwitterV2? TwitterV2 { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage.
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderBackupSchedule
{
    /// <summary>
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day).
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).
    /// </summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>
    /// The unit of time for how often the backup should take place. Possible values include: Day and Hour.
    /// The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.
    /// </summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>
    /// Should the service keep at least one backup, regardless of age of backup. Defaults to false.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderBackupStorageAccountUrlSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderBackup
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
    public V1beta2LinuxFunctionAppSpecInitProviderBackupSchedule? Schedule { get; set; }

    /// <summary>
    /// The SAS URL to the container.
    /// The SAS URL to the container.
    /// </summary>
    [JsonPropertyName("storageAccountUrlSecretRef")]
    public required V1beta2LinuxFunctionAppSpecInitProviderBackupStorageAccountUrlSecretRef StorageAccountUrlSecretRef { get; set; }
}

/// <summary>
/// The connection string value.
/// The connection string value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderConnectionStringValueSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderConnectionString
{
    /// <summary>
    /// The name which should be used for this Connection.
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
    public required V1beta2LinuxFunctionAppSpecInitProviderConnectionStringValueSecretRef ValueSecretRef { get; set; }
}

/// <summary>A identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Linux Function App.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Function App. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelector
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
    public V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelector
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
    public V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An app_service_logs block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigAppServiceLogs
{
    /// <summary>
    /// The amount of disk space to use for logs. Valid values are between 25 and 100. Defaults to 35.
    /// The amount of disk space to use for logs. Valid values are between `25` and `100`.
    /// </summary>
    [JsonPropertyName("diskQuotaMb")]
    public double? DiskQuotaMb { get; set; }

    /// <summary>
    /// After how many days backups should be deleted. Defaults to 30.
    /// The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).
    /// </summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }
}

/// <summary>
/// The Connection String for linking the Linux Function App to Application Insights.
/// The Connection String for linking the Linux Function App to Application Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationInsightsConnectionStringSecretRef
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

/// <summary>
/// The Instrumentation Key for connecting the Linux Function App to Application Insights.
/// The Instrumentation Key for connecting the Linux Function App to Application Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationInsightsKeySecretRef
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

/// <summary>
/// The password for the account to use to connect to the registry.
/// The password for the account to use to connect to the registry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef
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

/// <summary>
/// The username to use for connections to the registry.
/// The username to use for connections to the registry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationStackDockerRegistryUsernameSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationStackDocker
{
    /// <summary>
    /// The name of the Docker image to use.
    /// The name of the Docker image to use.
    /// </summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>
    /// The image tag of the image to use.
    /// The image tag of the image to use.
    /// </summary>
    [JsonPropertyName("imageTag")]
    public string? ImageTag { get; set; }

    /// <summary>
    /// The password for the account to use to connect to the registry.
    /// The password for the account to use to connect to the registry.
    /// </summary>
    [JsonPropertyName("registryPasswordSecretRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationStackDockerRegistryPasswordSecretRef? RegistryPasswordSecretRef { get; set; }

    /// <summary>
    /// The URL of the docker registry.
    /// The URL of the docker registry.
    /// </summary>
    [JsonPropertyName("registryUrl")]
    public string? RegistryUrl { get; set; }

    /// <summary>
    /// The username to use for connections to the registry.
    /// The username to use for connections to the registry.
    /// </summary>
    [JsonPropertyName("registryUsernameSecretRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationStackDockerRegistryUsernameSecretRef? RegistryUsernameSecretRef { get; set; }
}

/// <summary>An application_stack block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationStack
{
    /// <summary>
    /// One or more docker blocks as defined below.
    /// A docker block
    /// </summary>
    [JsonPropertyName("docker")]
    public IList<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationStackDocker>? Docker { get; set; }

    /// <summary>
    /// The version of .NET to use. Possible values include 3.1, 6.0, 7.0, 8.0, 9.0 and 10.0.
    /// The version of .Net. Possible values are `3.1`, `6.0`, `7.0`, `8.0` and `9.0`
    /// </summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>
    /// The Version of Java to use. Supported versions include 8, 11, 17, 21.
    /// The version of Java to use. Possible values are `8`, `11`, `17`, and `21`
    /// </summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>
    /// The version of Node to run. Possible values include 12, 14, 16, 18 20 and 22.
    /// The version of Node to use. Possible values include `12`, `14`, `16`, `18`, `20` and `22`
    /// </summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>
    /// The version of PowerShell Core to run. Possible values are 7, 7.2, and 7.4.
    /// The version of PowerShell Core to use. Possibles values are `7`, `7.2`, and `7.4`
    /// </summary>
    [JsonPropertyName("powershellCoreVersion")]
    public string? PowershellCoreVersion { get; set; }

    /// <summary>
    /// The version of Python to run. Possible values are 3.13, 3.12, 3.11, 3.10, 3.9, 3.8 and 3.7.
    /// The version of Python to use. Possible values include `3.13`, `3.12`, `3.11`, `3.10`, `3.9`, `3.8`, and `3.7`.
    /// </summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>Should the Linux Function App use a custom runtime?</summary>
    [JsonPropertyName("useCustomRuntime")]
    public bool? UseCustomRuntime { get; set; }

    /// <summary>
    /// Should the DotNet process use an isolated runtime. Defaults to false.
    /// Should the DotNet process use an isolated runtime. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("useDotnetIsolatedRuntime")]
    public bool? UseDotnetIsolatedRuntime { get; set; }
}

/// <summary>A cors block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigCors
{
    /// <summary>
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// Are credentials allowed in CORS requests? Defaults to false.
    /// Are credentials allowed in CORS requests? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionHeaders
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestriction
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
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionHeaders? Headers { get; set; }

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
    /// The subnet id which will be used by this Function App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionHeaders
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestriction
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
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionHeaders? Headers { get; set; }

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
    /// The subnet id which will be used by this Function App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A site_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderSiteConfig
{
    /// <summary>
    /// If this Linux Web App is Always On enabled. Defaults to false.
    /// If this Linux Web App is Always On enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>
    /// The URL of the API definition that describes this Linux Function App.
    /// The URL of the API definition that describes this Linux Function App.
    /// </summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>
    /// The ID of the API Management API for this Linux Function App.
    /// The ID of the API Management API for this Linux Function App.
    /// </summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>
    /// The App command line to launch.
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// </summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>An app_service_logs block as defined above.</summary>
    [JsonPropertyName("appServiceLogs")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigAppServiceLogs? AppServiceLogs { get; set; }

    /// <summary>
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// </summary>
    [JsonPropertyName("applicationInsightsConnectionStringSecretRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationInsightsConnectionStringSecretRef? ApplicationInsightsConnectionStringSecretRef { get; set; }

    /// <summary>
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// </summary>
    [JsonPropertyName("applicationInsightsKeySecretRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationInsightsKeySecretRef? ApplicationInsightsKeySecretRef { get; set; }

    /// <summary>An application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigApplicationStack? ApplicationStack { get; set; }

    /// <summary>
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// </summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>
    /// Should connections for Azure Container Registry use Managed Identity.
    /// Should connections for Azure Container Registry use Managed Identity.
    /// </summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfigCors? Cors { get; set; }

    /// <summary>
    /// Specifies a list of Default Documents for the Linux Web App.
    /// Specifies a list of Default Documents for the Linux Web App.
    /// </summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>
    /// State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled. Defaults to Disabled.
    /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.
    /// </summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node can be unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Only valid in conjunction with health_check_path.
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>
    /// The path to be checked for this function app health.
    /// The path to be checked for this function app health.
    /// </summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>
    /// Specifies if the HTTP2 protocol should be enabled. Defaults to false.
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>One or more ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// The Site load balancing mode. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>
    /// Managed pipeline mode. Possible values include: Integrated, Classic. Defaults to Integrated.
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.
    /// </summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// </summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to false.
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The Remote Debugging Version. Currently only VS2022 is supported.
    /// The Remote Debugging Version. Currently only `VS2022` is supported.
    /// </summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>
    /// Should Scale Monitoring of the Functions Runtime be enabled?
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta2LinuxFunctionAppSpecInitProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, `1.2` and  `1.3`. Defaults to `1.2`.
    /// </summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>
    /// Should the Linux Function App ip_restriction configuration be used for the SCM also.
    /// Should the Linux Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// Should the Linux Web App use a 32-bit worker process. Defaults to false.
    /// Should the Linux Web App use a 32-bit worker.
    /// </summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic to have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false.
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// Should Web Sockets be enabled. Defaults to false.
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>
    /// The number of Workers for this Linux Function App.
    /// The number of Workers for this Linux Function App.
    /// </summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>A sticky_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderStickySettings
{
    /// <summary>A list of app_setting names that the Linux Function App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("appSettingNames")]
    public IList<string>? AppSettingNames { get; set; }

    /// <summary>A list of connection_string names that the Linux Function App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("connectionStringNames")]
    public IList<string>? ConnectionStringNames { get; set; }
}

/// <summary>The Access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderStorageAccountAccessKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderStorageAccount
{
    /// <summary>The Access key for the storage account.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public required V1beta2LinuxFunctionAppSpecInitProviderStorageAccountAccessKeySecretRef AccessKeySecretRef { get; set; }

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

    /// <summary>The Azure Storage Type. Possible values include AzureFiles and AzureBlob.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// The access key which will be used to access the backend storage account for the Function App. Conflicts with storage_uses_managed_identity.
/// The access key which will be used to access the storage account for the Function App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderStorageAccountAccessKeySecretRef1
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelector
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
    public V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelector
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
    public V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecInitProvider
{
    /// <summary>
    /// A map of key-value pairs for App Settings and custom values.
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettings? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public V1beta2LinuxFunctionAppSpecInitProviderAuthSettingsV2? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2LinuxFunctionAppSpecInitProviderBackup? Backup { get; set; }

    /// <summary>
    /// Should built in logging be enabled. Configures AzureWebJobsDashboard app setting based on the configured storage setting. Defaults to true.
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting
    /// </summary>
    [JsonPropertyName("builtinLoggingEnabled")]
    public bool? BuiltinLoggingEnabled { get; set; }

    /// <summary>
    /// Should the function app use Client Certificates.
    /// Should the function app use Client Certificates
    /// </summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>
    /// The mode of the Function App&apos;s client certificates requirement for incoming requests. Possible values are Required, Optional, and OptionalInteractiveUser. Defaults to Optional.
    /// The mode of the Function App&apos;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`
    /// </summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta2LinuxFunctionAppSpecInitProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>
    /// Should the settings for linking the Function App to storage be suppressed.
    /// Force disable the content share settings.
    /// </summary>
    [JsonPropertyName("contentShareForceDisabled")]
    public bool? ContentShareForceDisabled { get; set; }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan. Defaults to 0.
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>
    /// Is the Function App enabled? Defaults to true.
    /// Is the Linux Function App enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The runtime version associated with the Function App. Defaults to ~4.
    /// The runtime version associated with the Function App.
    /// </summary>
    [JsonPropertyName("functionsExtensionVersion")]
    public string? FunctionsExtensionVersion { get; set; }

    /// <summary>
    /// Can the Function App only be accessed via HTTPS? Defaults to false.
    /// Can the Function App only be accessed via HTTPS?
    /// </summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>A identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2LinuxFunctionAppSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>
    /// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Azure Region where the Linux Function App should exist. Changing this forces a new Linux Function App to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The name which should be used for this Linux Function App. Changing this forces a new Linux Function App to be created. Limit the function name to 32 characters to avoid naming collisions. For more information about Function App naming rule and Host ID Collisions
    /// Specifies the name of the Function App.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Should public network access be enabled for the Function App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Linux Function App should exist. Changing this forces a new Linux Function App to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2LinuxFunctionAppSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>
    /// The ID of the App Service Plan within which to create this Function App.
    /// The ID of the App Service Plan within which to create this Function App
    /// </summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>Reference to a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdRef? ServicePlanIdRef { get; set; }

    /// <summary>Selector for a ServicePlan in web to populate servicePlanId.</summary>
    [JsonPropertyName("servicePlanIdSelector")]
    public V1beta2LinuxFunctionAppSpecInitProviderServicePlanIdSelector? ServicePlanIdSelector { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public V1beta2LinuxFunctionAppSpecInitProviderSiteConfig? SiteConfig { get; set; }

    /// <summary>A sticky_settings block as defined below.</summary>
    [JsonPropertyName("stickySettings")]
    public V1beta2LinuxFunctionAppSpecInitProviderStickySettings? StickySettings { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2LinuxFunctionAppSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>
    /// The access key which will be used to access the backend storage account for the Function App. Conflicts with storage_uses_managed_identity.
    /// The access key which will be used to access the storage account for the Function App.
    /// </summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderStorageAccountAccessKeySecretRef1? StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>
    /// The backend storage account name which will be used by this Function App.
    /// The backend storage account name which will be used by this Function App.
    /// </summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameRef? StorageAccountNameRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameSelector")]
    public V1beta2LinuxFunctionAppSpecInitProviderStorageAccountNameSelector? StorageAccountNameSelector { get; set; }

    /// <summary>
    /// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    [JsonPropertyName("storageKeyVaultSecretId")]
    public string? StorageKeyVaultSecretId { get; set; }

    /// <summary>
    /// Should the Function App use Managed Identity to access the storage account. Conflicts with storage_account_access_key.
    /// Should the Function App use its Managed Identity to access storage?
    /// </summary>
    [JsonPropertyName("storageUsesManagedIdentity")]
    public bool? StorageUsesManagedIdentity { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Linux Function App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether backup and restore operations over the linked virtual network are enabled. Defaults to false.</summary>
    [JsonPropertyName("virtualNetworkBackupRestoreEnabled")]
    public bool? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>The subnet id which will be used by this Function App for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta2LinuxFunctionAppSpecInitProviderVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }

    /// <summary>
    /// Should the traffic for the image pull be routed over virtual network enabled. Defaults to false.
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Linux Function App.
    /// The local path and filename of the Zip packaged application to deploy to this Linux Function App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecManagementPoliciesEnum>))]
public enum V1beta2LinuxFunctionAppSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2LinuxFunctionAppSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LinuxFunctionAppSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2LinuxFunctionAppSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LinuxFunctionAppSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LinuxFunctionAppSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LinuxFunctionAppSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>LinuxFunctionAppSpec defines the desired state of LinuxFunctionApp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppSpec
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
    public V1beta2LinuxFunctionAppSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2LinuxFunctionAppSpecForProvider ForProvider { get; set; }

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
    public V1beta2LinuxFunctionAppSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2LinuxFunctionAppSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2LinuxFunctionAppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2LinuxFunctionAppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An active_directory block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsActiveDirectory
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsFacebook
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
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A github block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsGithub
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
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A google block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsGoogle
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
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, &quot;openid&quot;, &quot;profile&quot;, and &quot;email&quot; are used as default scopes.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A microsoft block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsMicrosoft
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
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, wl.basic is used as the default scope.
    /// The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A twitter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsTwitter
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettings
{
    /// <summary>An active_directory block as defined above.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsActiveDirectory? ActiveDirectory { get; set; }

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
    /// The default authentication provider to use when multiple providers are configured. Possible values include: AzureActiveDirectory, Facebook, Google, MicrosoftAccount, Twitter, Github
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
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsFacebook? Facebook { get; set; }

    /// <summary>A github block as defined below.</summary>
    [JsonPropertyName("github")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsGithub? Github { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsGoogle? Google { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this Linux Web App.
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsMicrosoft? Microsoft { get; set; }

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
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsTwitter? Twitter { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: RedirectToLoginPage, AllowAnonymous.
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>An active_directory_v2 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2ActiveDirectoryV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2AppleV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2AzureStaticWebAppV2
{
    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// The ID of the Client to use to authenticate with Azure Static Web App Authentication.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2CustomOidcV2
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
    /// The app setting name that contains the client_secret value used for the Custom OIDC Login.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2FacebookV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2GithubV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2GoogleV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2Login
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2MicrosoftV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2TwitterV2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2
{
    /// <summary>An active_directory_v2 block as defined below.</summary>
    [JsonPropertyName("activeDirectoryV2")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2 { get; set; }

    /// <summary>An apple_v2 block as defined below.</summary>
    [JsonPropertyName("appleV2")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2AppleV2? AppleV2 { get; set; }

    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to false.
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>An azure_static_web_app_v2 block as defined below.</summary>
    [JsonPropertyName("azureStaticWebAppV2")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2 { get; set; }

    /// <summary>
    /// The path to the App Auth settings.
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [JsonPropertyName("configFilePath")]
    public string? ConfigFilePath { get; set; }

    /// <summary>Zero or more custom_oidc_v2 blocks as defined below.</summary>
    [JsonPropertyName("customOidcV2")]
    public IList<V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2CustomOidcV2>? CustomOidcV2 { get; set; }

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
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2FacebookV2? FacebookV2 { get; set; }

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
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2GithubV2? GithubV2 { get; set; }

    /// <summary>A google_v2 block as defined below.</summary>
    [JsonPropertyName("googleV2")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2GoogleV2? GoogleV2 { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to /.auth.
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [JsonPropertyName("httpRouteApiPrefix")]
    public string? HttpRouteApiPrefix { get; set; }

    /// <summary>A login block as defined below.</summary>
    [JsonPropertyName("login")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2Login? Login { get; set; }

    /// <summary>A microsoft_v2 block as defined below.</summary>
    [JsonPropertyName("microsoftV2")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2MicrosoftV2? MicrosoftV2 { get; set; }

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
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2TwitterV2? TwitterV2 { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include RedirectToLoginPage, AllowAnonymous, Return401, and Return403. Defaults to RedirectToLoginPage.
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [JsonPropertyName("unauthenticatedAction")]
    public string? UnauthenticatedAction { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderBackupSchedule
{
    /// <summary>
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and frequency_unit should be set to Day).
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).
    /// </summary>
    [JsonPropertyName("frequencyInterval")]
    public double? FrequencyInterval { get; set; }

    /// <summary>
    /// The unit of time for how often the backup should take place. Possible values include: Day and Hour.
    /// The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.
    /// </summary>
    [JsonPropertyName("frequencyUnit")]
    public string? FrequencyUnit { get; set; }

    /// <summary>
    /// Should the service keep at least one backup, regardless of age of backup. Defaults to false.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderBackup
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
    public V1beta2LinuxFunctionAppStatusAtProviderBackupSchedule? Schedule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderConnectionString
{
    /// <summary>
    /// The name which should be used for this Connection.
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

/// <summary>A identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Linux Function App.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Function App. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An app_service_logs block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderSiteConfigAppServiceLogs
{
    /// <summary>
    /// The amount of disk space to use for logs. Valid values are between 25 and 100. Defaults to 35.
    /// The amount of disk space to use for logs. Valid values are between `25` and `100`.
    /// </summary>
    [JsonPropertyName("diskQuotaMb")]
    public double? DiskQuotaMb { get; set; }

    /// <summary>
    /// After how many days backups should be deleted. Defaults to 30.
    /// The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).
    /// </summary>
    [JsonPropertyName("retentionPeriodDays")]
    public double? RetentionPeriodDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderSiteConfigApplicationStackDocker
{
    /// <summary>
    /// The name of the Docker image to use.
    /// The name of the Docker image to use.
    /// </summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>
    /// The image tag of the image to use.
    /// The image tag of the image to use.
    /// </summary>
    [JsonPropertyName("imageTag")]
    public string? ImageTag { get; set; }

    /// <summary>
    /// The URL of the docker registry.
    /// The URL of the docker registry.
    /// </summary>
    [JsonPropertyName("registryUrl")]
    public string? RegistryUrl { get; set; }
}

/// <summary>An application_stack block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderSiteConfigApplicationStack
{
    /// <summary>
    /// One or more docker blocks as defined below.
    /// A docker block
    /// </summary>
    [JsonPropertyName("docker")]
    public IList<V1beta2LinuxFunctionAppStatusAtProviderSiteConfigApplicationStackDocker>? Docker { get; set; }

    /// <summary>
    /// The version of .NET to use. Possible values include 3.1, 6.0, 7.0, 8.0, 9.0 and 10.0.
    /// The version of .Net. Possible values are `3.1`, `6.0`, `7.0`, `8.0` and `9.0`
    /// </summary>
    [JsonPropertyName("dotnetVersion")]
    public string? DotnetVersion { get; set; }

    /// <summary>
    /// The Version of Java to use. Supported versions include 8, 11, 17, 21.
    /// The version of Java to use. Possible values are `8`, `11`, `17`, and `21`
    /// </summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>
    /// The version of Node to run. Possible values include 12, 14, 16, 18 20 and 22.
    /// The version of Node to use. Possible values include `12`, `14`, `16`, `18`, `20` and `22`
    /// </summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>
    /// The version of PowerShell Core to run. Possible values are 7, 7.2, and 7.4.
    /// The version of PowerShell Core to use. Possibles values are `7`, `7.2`, and `7.4`
    /// </summary>
    [JsonPropertyName("powershellCoreVersion")]
    public string? PowershellCoreVersion { get; set; }

    /// <summary>
    /// The version of Python to run. Possible values are 3.13, 3.12, 3.11, 3.10, 3.9, 3.8 and 3.7.
    /// The version of Python to use. Possible values include `3.13`, `3.12`, `3.11`, `3.10`, `3.9`, `3.8`, and `3.7`.
    /// </summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>Should the Linux Function App use a custom runtime?</summary>
    [JsonPropertyName("useCustomRuntime")]
    public bool? UseCustomRuntime { get; set; }

    /// <summary>
    /// Should the DotNet process use an isolated runtime. Defaults to false.
    /// Should the DotNet process use an isolated runtime. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("useDotnetIsolatedRuntime")]
    public bool? UseDotnetIsolatedRuntime { get; set; }
}

/// <summary>A cors block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderSiteConfigCors
{
    /// <summary>
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// Are credentials allowed in CORS requests? Defaults to false.
    /// Are credentials allowed in CORS requests? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderSiteConfigIpRestrictionHeaders
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderSiteConfigIpRestriction
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
    public V1beta2LinuxFunctionAppStatusAtProviderSiteConfigIpRestrictionHeaders? Headers { get; set; }

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
    /// The subnet id which will be used by this Function App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary>A headers block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderSiteConfigScmIpRestrictionHeaders
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderSiteConfigScmIpRestriction
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
    public V1beta2LinuxFunctionAppStatusAtProviderSiteConfigScmIpRestrictionHeaders? Headers { get; set; }

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
    /// The subnet id which will be used by this Function App for regional virtual network integration.
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary>A site_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderSiteConfig
{
    /// <summary>
    /// If this Linux Web App is Always On enabled. Defaults to false.
    /// If this Linux Web App is Always On enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>
    /// The URL of the API definition that describes this Linux Function App.
    /// The URL of the API definition that describes this Linux Function App.
    /// </summary>
    [JsonPropertyName("apiDefinitionUrl")]
    public string? ApiDefinitionUrl { get; set; }

    /// <summary>
    /// The ID of the API Management API for this Linux Function App.
    /// The ID of the API Management API for this Linux Function App.
    /// </summary>
    [JsonPropertyName("apiManagementApiId")]
    public string? ApiManagementApiId { get; set; }

    /// <summary>
    /// The App command line to launch.
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    [JsonPropertyName("appCommandLine")]
    public string? AppCommandLine { get; set; }

    /// <summary>
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// </summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>An app_service_logs block as defined above.</summary>
    [JsonPropertyName("appServiceLogs")]
    public V1beta2LinuxFunctionAppStatusAtProviderSiteConfigAppServiceLogs? AppServiceLogs { get; set; }

    /// <summary>An application_stack block as defined above.</summary>
    [JsonPropertyName("applicationStack")]
    public V1beta2LinuxFunctionAppStatusAtProviderSiteConfigApplicationStack? ApplicationStack { get; set; }

    /// <summary>
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// </summary>
    [JsonPropertyName("containerRegistryManagedIdentityClientId")]
    public string? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>
    /// Should connections for Azure Container Registry use Managed Identity.
    /// Should connections for Azure Container Registry use Managed Identity.
    /// </summary>
    [JsonPropertyName("containerRegistryUseManagedIdentity")]
    public bool? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>A cors block as defined above.</summary>
    [JsonPropertyName("cors")]
    public V1beta2LinuxFunctionAppStatusAtProviderSiteConfigCors? Cors { get; set; }

    /// <summary>
    /// Specifies a list of Default Documents for the Linux Web App.
    /// Specifies a list of Default Documents for the Linux Web App.
    /// </summary>
    [JsonPropertyName("defaultDocuments")]
    public IList<string>? DefaultDocuments { get; set; }

    /// <summary>
    /// Is the Function App enabled? Defaults to true.
    /// Is detailed error logging enabled
    /// </summary>
    [JsonPropertyName("detailedErrorLoggingEnabled")]
    public bool? DetailedErrorLoggingEnabled { get; set; }

    /// <summary>
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>
    /// State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled. Defaults to Disabled.
    /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.
    /// </summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node can be unhealthy before being removed from the load balancer. Possible values are between 2 and 10. Only valid in conjunction with health_check_path.
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [JsonPropertyName("healthCheckEvictionTimeInMin")]
    public double? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>
    /// The path to be checked for this function app health.
    /// The path to be checked for this function app health.
    /// </summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>
    /// Specifies if the HTTP2 protocol should be enabled. Defaults to false.
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>One or more ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta2LinuxFunctionAppStatusAtProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("ipRestrictionDefaultAction")]
    public string? IpRestrictionDefaultAction { get; set; }

    /// <summary>The Linux FX Version</summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>
    /// The Site load balancing mode. Possible values include: WeightedRoundRobin, LeastRequests, LeastResponseTime, WeightedTotalTraffic, RequestHash, PerSiteRoundRobin. Defaults to LeastRequests if omitted.
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    [JsonPropertyName("loadBalancingMode")]
    public string? LoadBalancingMode { get; set; }

    /// <summary>
    /// Managed pipeline mode. Possible values include: Integrated, Classic. Defaults to Integrated.
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    [JsonPropertyName("managedPipelineMode")]
    public string? ManagedPipelineMode { get; set; }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.
    /// </summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// </summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to false.
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("remoteDebuggingEnabled")]
    public bool? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The Remote Debugging Version. Currently only VS2022 is supported.
    /// The Remote Debugging Version. Currently only `VS2022` is supported.
    /// </summary>
    [JsonPropertyName("remoteDebuggingVersion")]
    public string? RemoteDebuggingVersion { get; set; }

    /// <summary>
    /// Should Scale Monitoring of the Functions Runtime be enabled?
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>One or more scm_ip_restriction blocks as defined above.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta2LinuxFunctionAppStatusAtProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The Default action for traffic that does not match any scm_ip_restriction rule. possible values include Allow and Deny. Defaults to Allow.</summary>
    [JsonPropertyName("scmIpRestrictionDefaultAction")]
    public string? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: 1.0, 1.1, 1.2 and 1.3. Defaults to 1.2.
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, `1.2` and  `1.3`. Defaults to `1.2`.
    /// </summary>
    [JsonPropertyName("scmMinimumTlsVersion")]
    public string? ScmMinimumTlsVersion { get; set; }

    /// <summary>The SCM Type in use by the Linux Function App.</summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>
    /// Should the Linux Function App ip_restriction configuration be used for the SCM also.
    /// Should the Linux Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// Should the Linux Web App use a 32-bit worker process. Defaults to false.
    /// Should the Linux Web App use a 32-bit worker.
    /// </summary>
    [JsonPropertyName("use32BitWorker")]
    public bool? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic to have NAT Gateways, Network Security Groups and User Defined Routes applied? Defaults to false.
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// Should Web Sockets be enabled. Defaults to false.
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }

    /// <summary>
    /// The number of Workers for this Linux Function App.
    /// The number of Workers for this Linux Function App.
    /// </summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary>A sticky_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderStickySettings
{
    /// <summary>A list of app_setting names that the Linux Function App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("appSettingNames")]
    public IList<string>? AppSettingNames { get; set; }

    /// <summary>A list of connection_string names that the Linux Function App will not swap between Slots when a swap operation is triggered.</summary>
    [JsonPropertyName("connectionStringNames")]
    public IList<string>? ConnectionStringNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProviderStorageAccount
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

    /// <summary>The Azure Storage Type. Possible values include AzureFiles and AzureBlob.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusAtProvider
{
    /// <summary>
    /// A map of key-value pairs for App Settings and custom values.
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>A auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettings? AuthSettings { get; set; }

    /// <summary>An auth_settings_v2 block as defined below.</summary>
    [JsonPropertyName("authSettingsV2")]
    public V1beta2LinuxFunctionAppStatusAtProviderAuthSettingsV2? AuthSettingsV2 { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public V1beta2LinuxFunctionAppStatusAtProviderBackup? Backup { get; set; }

    /// <summary>
    /// Should built in logging be enabled. Configures AzureWebJobsDashboard app setting based on the configured storage setting. Defaults to true.
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting
    /// </summary>
    [JsonPropertyName("builtinLoggingEnabled")]
    public bool? BuiltinLoggingEnabled { get; set; }

    /// <summary>
    /// Should the function app use Client Certificates.
    /// Should the function app use Client Certificates
    /// </summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [JsonPropertyName("clientCertificateExclusionPaths")]
    public string? ClientCertificateExclusionPaths { get; set; }

    /// <summary>
    /// The mode of the Function App&apos;s client certificates requirement for incoming requests. Possible values are Required, Optional, and OptionalInteractiveUser. Defaults to Optional.
    /// The mode of the Function App&apos;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`
    /// </summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>One or more connection_string blocks as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta2LinuxFunctionAppStatusAtProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>
    /// Should the settings for linking the Function App to storage be suppressed.
    /// Force disable the content share settings.
    /// </summary>
    [JsonPropertyName("contentShareForceDisabled")]
    public bool? ContentShareForceDisabled { get; set; }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan. Defaults to 0.
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>The default hostname of the Linux Function App.</summary>
    [JsonPropertyName("defaultHostname")]
    public string? DefaultHostname { get; set; }

    /// <summary>
    /// Is the Function App enabled? Defaults to true.
    /// Is the Linux Function App enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Should the default FTP Basic Authentication publishing profile be enabled. Defaults to true.</summary>
    [JsonPropertyName("ftpPublishBasicAuthenticationEnabled")]
    public bool? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The runtime version associated with the Function App. Defaults to ~4.
    /// The runtime version associated with the Function App.
    /// </summary>
    [JsonPropertyName("functionsExtensionVersion")]
    public string? FunctionsExtensionVersion { get; set; }

    /// <summary>The ID of the App Service Environment used by Function App.</summary>
    [JsonPropertyName("hostingEnvironmentId")]
    public string? HostingEnvironmentId { get; set; }

    /// <summary>
    /// Can the Function App only be accessed via HTTPS? Defaults to false.
    /// Can the Function App only be accessed via HTTPS?
    /// </summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Linux Function App.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2LinuxFunctionAppStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>
    /// The User Assigned Identity ID used for accessing KeyVault secrets. The identity must be assigned to the application in the identity block. For more information see - Access vaults with a user-assigned identity
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    [JsonPropertyName("keyVaultReferenceIdentityId")]
    public string? KeyVaultReferenceIdentityId { get; set; }

    /// <summary>The Kind value for this Linux Function App.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The Azure Region where the Linux Function App should exist. Changing this forces a new Linux Function App to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The name which should be used for this Linux Function App. Changing this forces a new Linux Function App to be created. Limit the function name to 32 characters to avoid naming collisions. For more information about Function App naming rule and Host ID Collisions
    /// Specifies the name of the Function App.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of outbound IP addresses. For example [&quot;52.23.25.3&quot;, &quot;52.143.43.12&quot;]</summary>
    [JsonPropertyName("outboundIpAddressList")]
    public IList<string>? OutboundIpAddressList { get; set; }

    /// <summary>A comma separated list of outbound IP addresses as a string. For example 52.23.25.3,52.143.43.12.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    /// <summary>A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of outbound_ip_address_list. For example [&quot;52.23.25.3&quot;, &quot;52.143.43.12&quot;].</summary>
    [JsonPropertyName("possibleOutboundIpAddressList")]
    public IList<string>? PossibleOutboundIpAddressList { get; set; }

    /// <summary>A comma separated list of possible outbound IP addresses as a string. For example 52.23.25.3,52.143.43.12,52.143.43.17. This is a superset of outbound_ip_addresses.</summary>
    [JsonPropertyName("possibleOutboundIpAddresses")]
    public string? PossibleOutboundIpAddresses { get; set; }

    /// <summary>Should public network access be enabled for the Function App. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Linux Function App should exist. Changing this forces a new Linux Function App to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>
    /// The ID of the App Service Plan within which to create this Function App.
    /// The ID of the App Service Plan within which to create this Function App
    /// </summary>
    [JsonPropertyName("servicePlanId")]
    public string? ServicePlanId { get; set; }

    /// <summary>A site_config block as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public V1beta2LinuxFunctionAppStatusAtProviderSiteConfig? SiteConfig { get; set; }

    /// <summary>A sticky_settings block as defined below.</summary>
    [JsonPropertyName("stickySettings")]
    public V1beta2LinuxFunctionAppStatusAtProviderStickySettings? StickySettings { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta2LinuxFunctionAppStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>
    /// The backend storage account name which will be used by this Function App.
    /// The backend storage account name which will be used by this Function App.
    /// </summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>
    /// The Key Vault Secret ID, optionally including version, that contains the Connection String to connect to the storage account for this Function App.
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    [JsonPropertyName("storageKeyVaultSecretId")]
    public string? StorageKeyVaultSecretId { get; set; }

    /// <summary>
    /// Should the Function App use Managed Identity to access the storage account. Conflicts with storage_account_access_key.
    /// Should the Function App use its Managed Identity to access storage?
    /// </summary>
    [JsonPropertyName("storageUsesManagedIdentity")]
    public bool? StorageUsesManagedIdentity { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Linux Function App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether backup and restore operations over the linked virtual network are enabled. Defaults to false.</summary>
    [JsonPropertyName("virtualNetworkBackupRestoreEnabled")]
    public bool? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>The subnet id which will be used by this Function App for regional virtual network integration.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>
    /// Should the traffic for the image pull be routed over virtual network enabled. Defaults to false.
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    [JsonPropertyName("vnetImagePullEnabled")]
    public bool? VnetImagePullEnabled { get; set; }

    /// <summary>Should the default WebDeploy Basic Authentication publishing credentials enabled. Defaults to true.</summary>
    [JsonPropertyName("webdeployPublishBasicAuthenticationEnabled")]
    public bool? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Linux Function App.
    /// The local path and filename of the Zip packaged application to deploy to this Linux Function App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [JsonPropertyName("zipDeployFile")]
    public string? ZipDeployFile { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatusConditions
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

/// <summary>LinuxFunctionAppStatus defines the observed state of LinuxFunctionApp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LinuxFunctionAppStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2LinuxFunctionAppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2LinuxFunctionAppStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LinuxFunctionApp is the Schema for the LinuxFunctionApps API. Manages a Linux Function App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LinuxFunctionApp : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2LinuxFunctionAppSpec>, IStatus<V1beta2LinuxFunctionAppStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LinuxFunctionApp";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "linuxfunctionapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LinuxFunctionApp";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinuxFunctionAppSpec defines the desired state of LinuxFunctionApp</summary>
    [JsonPropertyName("spec")]
    public required V1beta2LinuxFunctionAppSpec Spec { get; set; }

    /// <summary>LinuxFunctionAppStatus defines the observed state of LinuxFunctionApp.</summary>
    [JsonPropertyName("status")]
    public V1beta2LinuxFunctionAppStatus? Status { get; set; }
}