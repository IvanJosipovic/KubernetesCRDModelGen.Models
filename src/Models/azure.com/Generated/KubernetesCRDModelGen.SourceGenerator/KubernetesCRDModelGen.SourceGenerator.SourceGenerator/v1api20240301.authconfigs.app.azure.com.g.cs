#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.app.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2024-03-01/AuthConfigs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301AuthConfigList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301AuthConfig>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "AuthConfigList";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "authconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240301AuthConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240301AuthConfig> Items { get; set; }
}

/// <summary>
/// EncryptionSettings: The configuration settings of the secrets references of encryption key and signing key for
/// ContainerApp Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecEncryptionSettings
{
    /// <summary>ContainerAppAuthEncryptionSecretName: The secret name which is referenced for EncryptionKey.</summary>
    [JsonPropertyName("containerAppAuthEncryptionSecretName")]
    public string? ContainerAppAuthEncryptionSecretName { get; set; }

    /// <summary>ContainerAppAuthSigningSecretName: The secret name which is referenced for SigningKey.</summary>
    [JsonPropertyName("containerAppAuthSigningSecretName")]
    public string? ContainerAppAuthSigningSecretName { get; set; }
}

/// <summary>UnauthenticatedClientAction: The action to take when an unauthenticated client attempts to access the app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301AuthConfigSpecGlobalValidationUnauthenticatedClientActionEnum>))]
public enum V1api20240301AuthConfigSpecGlobalValidationUnauthenticatedClientActionEnum
{
    [EnumMember(Value = "AllowAnonymous"), JsonStringEnumMemberName("AllowAnonymous")]
    AllowAnonymous,
    [EnumMember(Value = "RedirectToLoginPage"), JsonStringEnumMemberName("RedirectToLoginPage")]
    RedirectToLoginPage,
    [EnumMember(Value = "Return401"), JsonStringEnumMemberName("Return401")]
    Return401,
    [EnumMember(Value = "Return403"), JsonStringEnumMemberName("Return403")]
    Return403
}

/// <summary>
/// GlobalValidation: The configuration settings that determines the validation flow of users using  Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecGlobalValidation
{
    /// <summary>ExcludedPaths: The paths for which unauthenticated flow would not be redirected to the login page.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>
    /// RedirectToProvider: The default authentication provider to use when multiple providers are configured.
    /// This setting is only needed if multiple providers are configured and the unauthenticated client
    /// action is set to &quot;RedirectToLoginPage&quot;.
    /// </summary>
    [JsonPropertyName("redirectToProvider")]
    public string? RedirectToProvider { get; set; }

    /// <summary>UnauthenticatedClientAction: The action to take when an unauthenticated client attempts to access the app.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public V1api20240301AuthConfigSpecGlobalValidationUnauthenticatedClientActionEnum? UnauthenticatedClientAction { get; set; }
}

/// <summary>Convention: The convention used to determine the url of the request made.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301AuthConfigSpecHttpSettingsForwardProxyConventionEnum>))]
public enum V1api20240301AuthConfigSpecHttpSettingsForwardProxyConventionEnum
{
    [EnumMember(Value = "Custom"), JsonStringEnumMemberName("Custom")]
    Custom,
    [EnumMember(Value = "NoProxy"), JsonStringEnumMemberName("NoProxy")]
    NoProxy,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>ForwardProxy: The configuration settings of a forward proxy used to make the requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecHttpSettingsForwardProxy
{
    /// <summary>Convention: The convention used to determine the url of the request made.</summary>
    [JsonPropertyName("convention")]
    public V1api20240301AuthConfigSpecHttpSettingsForwardProxyConventionEnum? Convention { get; set; }

    /// <summary>CustomHostHeaderName: The name of the header containing the host of the request.</summary>
    [JsonPropertyName("customHostHeaderName")]
    public string? CustomHostHeaderName { get; set; }

    /// <summary>CustomProtoHeaderName: The name of the header containing the scheme of the request.</summary>
    [JsonPropertyName("customProtoHeaderName")]
    public string? CustomProtoHeaderName { get; set; }
}

/// <summary>Routes: The configuration settings of the paths HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecHttpSettingsRoutes
{
    /// <summary>ApiPrefix: The prefix that should precede all the authentication/authorization paths.</summary>
    [JsonPropertyName("apiPrefix")]
    public string? ApiPrefix { get; set; }
}

/// <summary>
/// HttpSettings: The configuration settings of the HTTP requests for authentication and authorization requests made against
/// ContainerApp Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecHttpSettings
{
    /// <summary>ForwardProxy: The configuration settings of a forward proxy used to make the requests.</summary>
    [JsonPropertyName("forwardProxy")]
    public V1api20240301AuthConfigSpecHttpSettingsForwardProxy? ForwardProxy { get; set; }

    /// <summary>
    /// RequireHttps: &lt;code&gt;false&lt;/code&gt; if the authentication/authorization responses not having the HTTPS scheme are
    /// permissible; otherwise, &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>Routes: The configuration settings of the paths HTTP requests.</summary>
    [JsonPropertyName("routes")]
    public V1api20240301AuthConfigSpecHttpSettingsRoutes? Routes { get; set; }
}

/// <summary>Login: The configuration settings of the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAppleLogin
{
    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Registration: The configuration settings of the Apple registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAppleRegistration
{
    /// <summary>ClientId: The Client ID of the app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientSecretSettingName: The app setting name that contains the client secret.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Apple: The configuration settings of the Apple provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersApple
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Apple provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Login: The configuration settings of the login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigSpecIdentityProvidersAppleLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the Apple registration.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigSpecIdentityProvidersAppleRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the Azure Active Directory login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryLogin
{
    /// <summary>
    /// DisableWWWAuthenticate: &lt;code&gt;true&lt;/code&gt; if the www-authenticate provider should be omitted from the request;
    /// otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("disableWWWAuthenticate")]
    public bool? DisableWWWAuthenticate { get; set; }

    /// <summary>
    /// LoginParameters: Login parameters to send to the OpenID Connect authorization endpoint when
    /// a user logs in. Each parameter must be in the form &quot;key=value&quot;.
    /// </summary>
    [JsonPropertyName("loginParameters")]
    public IList<string>? LoginParameters { get; set; }
}

/// <summary>Registration: The configuration settings of the Azure Active Directory app registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryRegistration
{
    /// <summary>
    /// ClientId: The Client ID of this relying party application, known as the client_id.
    /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
    /// other 3rd party OpenID Connect providers.
    /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// ClientSecretCertificateIssuer: An alternative to the client secret thumbprint, that is the issuer of a certificate used
    /// for signing purposes. This property acts as
    /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
    /// </summary>
    [JsonPropertyName("clientSecretCertificateIssuer")]
    public string? ClientSecretCertificateIssuer { get; set; }

    /// <summary>
    /// ClientSecretCertificateSubjectAlternativeName: An alternative to the client secret thumbprint, that is the subject
    /// alternative name of a certificate used for signing purposes. This property acts as
    /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
    /// </summary>
    [JsonPropertyName("clientSecretCertificateSubjectAlternativeName")]
    public string? ClientSecretCertificateSubjectAlternativeName { get; set; }

    /// <summary>
    /// ClientSecretCertificateThumbprint: An alternative to the client secret, that is the thumbprint of a certificate used for
    /// signing purposes. This property acts as
    /// a replacement for the Client Secret. It is also optional.
    /// </summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary>ClientSecretSettingName: The app setting name that contains the client secret of the relying party application.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// OpenIdIssuer: The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
    /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g.
    /// `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
    /// This URI is a case-sensitive identifier for the token issuer.
    /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
    /// </summary>
    [JsonPropertyName("openIdIssuer")]
    public string? OpenIdIssuer { get; set; }
}

/// <summary>AllowedPrincipals: The configuration settings of the Azure Active Directory allowed principals.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals
{
    /// <summary>Groups: The list of the allowed groups.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>Identities: The list of the allowed identities.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }
}

/// <summary>DefaultAuthorizationPolicy: The configuration settings of the default authorization policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy
{
    /// <summary>AllowedApplications: The configuration settings of the Azure Active Directory allowed applications.</summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>AllowedPrincipals: The configuration settings of the Azure Active Directory allowed principals.</summary>
    [JsonPropertyName("allowedPrincipals")]
    public V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals? AllowedPrincipals { get; set; }
}

/// <summary>JwtClaimChecks: The configuration settings of the checks that should be made while validating the JWT Claims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks
{
    /// <summary>AllowedClientApplications: The list of the allowed client applications.</summary>
    [JsonPropertyName("allowedClientApplications")]
    public IList<string>? AllowedClientApplications { get; set; }

    /// <summary>AllowedGroups: The list of the allowed groups.</summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }
}

/// <summary>Validation: The configuration settings of the Azure Active Directory token validation flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryValidation
{
    /// <summary>AllowedAudiences: The list of audiences that can make successful authentication/authorization requests.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>DefaultAuthorizationPolicy: The configuration settings of the default authorization policy.</summary>
    [JsonPropertyName("defaultAuthorizationPolicy")]
    public V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy? DefaultAuthorizationPolicy { get; set; }

    /// <summary>JwtClaimChecks: The configuration settings of the checks that should be made while validating the JWT Claims.</summary>
    [JsonPropertyName("jwtClaimChecks")]
    public V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks? JwtClaimChecks { get; set; }
}

/// <summary>AzureActiveDirectory: The configuration settings of the Azure Active directory provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectory
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Azure Active Directory provider should not be enabled despite the set registration;
    /// otherwise, &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// IsAutoProvisioned: Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party
    /// tooling.
    /// This is an internal flag primarily intended to support the Azure Management Portal. Users should not
    /// read or write to this property.
    /// </summary>
    [JsonPropertyName("isAutoProvisioned")]
    public bool? IsAutoProvisioned { get; set; }

    /// <summary>Login: The configuration settings of the Azure Active Directory login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the Azure Active Directory app registration.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryRegistration? Registration { get; set; }

    /// <summary>Validation: The configuration settings of the Azure Active Directory token validation flow.</summary>
    [JsonPropertyName("validation")]
    public V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectoryValidation? Validation { get; set; }
}

/// <summary>Registration: The configuration settings of the Azure Static Web Apps registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAzureStaticWebAppsRegistration
{
    /// <summary>ClientId: The Client ID of the app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>AzureStaticWebApps: The configuration settings of the Azure Static Web Apps provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersAzureStaticWebApps
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Azure Static Web Apps provider should not be enabled despite the set registration;
    /// otherwise, &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Registration: The configuration settings of the Azure Static Web Apps registration.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigSpecIdentityProvidersAzureStaticWebAppsRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the login flow of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersLogin
{
    /// <summary>NameClaimType: The name of the claim that contains the users name.</summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Method: The method that should be used to authenticate the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredentialMethodEnum>))]
public enum V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredentialMethodEnum
{
    [EnumMember(Value = "ClientSecretPost"), JsonStringEnumMemberName("ClientSecretPost")]
    ClientSecretPost
}

/// <summary>ClientCredential: The authentication credentials of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential
{
    /// <summary>ClientSecretSettingName: The app setting that contains the client secret for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Method: The method that should be used to authenticate the user.</summary>
    [JsonPropertyName("method")]
    public V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredentialMethodEnum? Method { get; set; }
}

/// <summary>OpenIdConnectConfiguration: The configuration settings of the endpoints used for the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration
{
    /// <summary>AuthorizationEndpoint: The endpoint to be used to make an authorization request.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>CertificationUri: The endpoint that provides the keys necessary to validate the token.</summary>
    [JsonPropertyName("certificationUri")]
    public string? CertificationUri { get; set; }

    /// <summary>Issuer: The endpoint that issues the token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>TokenEndpoint: The endpoint to be used to request a token.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>WellKnownOpenIdConfiguration: The endpoint that contains all the configuration endpoints for the provider.</summary>
    [JsonPropertyName("wellKnownOpenIdConfiguration")]
    public string? WellKnownOpenIdConfiguration { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistration
{
    /// <summary>ClientCredential: The authentication credentials of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("clientCredential")]
    public V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential? ClientCredential { get; set; }

    /// <summary>ClientId: The client id of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>OpenIdConnectConfiguration: The configuration settings of the endpoints used for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("openIdConnectConfiguration")]
    public V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration? OpenIdConnectConfiguration { get; set; }
}

/// <summary>The configuration settings of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProviders
{
    /// <summary>Enabled: &lt;code&gt;false&lt;/code&gt; if the custom Open ID provider provider should not be enabled; otherwise, &lt;code&gt;true&lt;/code&gt;.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Login: The configuration settings of the login flow of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersFacebookLogin
{
    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the Facebook provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersFacebookRegistration
{
    /// <summary>AppId: The App ID of the app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>AppSecretSettingName: The app setting name that contains the app secret.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }
}

/// <summary>Facebook: The configuration settings of the Facebook provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersFacebook
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Facebook provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>GraphApiVersion: The version of the Facebook api to be used while logging in.</summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>Login: The configuration settings of the login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigSpecIdentityProvidersFacebookLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the Facebook provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigSpecIdentityProvidersFacebookRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersGitHubLogin
{
    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the GitHub provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersGitHubRegistration
{
    /// <summary>ClientId: The Client ID of the app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientSecretSettingName: The app setting name that contains the client secret.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>GitHub: The configuration settings of the GitHub provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersGitHub
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the GitHub provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Login: The configuration settings of the login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigSpecIdentityProvidersGitHubLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the GitHub provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigSpecIdentityProvidersGitHubRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersGoogleLogin
{
    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the Google provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersGoogleRegistration
{
    /// <summary>ClientId: The Client ID of the app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientSecretSettingName: The app setting name that contains the client secret.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Validation: The configuration settings of the Azure Active Directory token validation flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersGoogleValidation
{
    /// <summary>AllowedAudiences: The configuration settings of the allowed list of audiences from which to validate the JWT token.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }
}

/// <summary>Google: The configuration settings of the Google provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersGoogle
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Google provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Login: The configuration settings of the login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigSpecIdentityProvidersGoogleLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the Google provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigSpecIdentityProvidersGoogleRegistration? Registration { get; set; }

    /// <summary>Validation: The configuration settings of the Azure Active Directory token validation flow.</summary>
    [JsonPropertyName("validation")]
    public V1api20240301AuthConfigSpecIdentityProvidersGoogleValidation? Validation { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the Twitter provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersTwitterRegistration
{
    /// <summary>
    /// ConsumerKey: The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// This setting is required for enabling Twitter Sign-In.
    /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
    /// </summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>
    /// ConsumerSecretSettingName: The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
    /// application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>Twitter: The configuration settings of the Twitter provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProvidersTwitter
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Twitter provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the Twitter provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigSpecIdentityProvidersTwitterRegistration? Registration { get; set; }
}

/// <summary>
/// IdentityProviders: The configuration settings of each of the identity providers used to configure ContainerApp Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecIdentityProviders
{
    /// <summary>Apple: The configuration settings of the Apple provider.</summary>
    [JsonPropertyName("apple")]
    public V1api20240301AuthConfigSpecIdentityProvidersApple? Apple { get; set; }

    /// <summary>AzureActiveDirectory: The configuration settings of the Azure Active directory provider.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public V1api20240301AuthConfigSpecIdentityProvidersAzureActiveDirectory? AzureActiveDirectory { get; set; }

    /// <summary>AzureStaticWebApps: The configuration settings of the Azure Static Web Apps provider.</summary>
    [JsonPropertyName("azureStaticWebApps")]
    public V1api20240301AuthConfigSpecIdentityProvidersAzureStaticWebApps? AzureStaticWebApps { get; set; }

    /// <summary>
    /// CustomOpenIdConnectProviders: The map of the name of the alias of each custom Open ID Connect provider to the
    /// configuration settings of the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("customOpenIdConnectProviders")]
    public IDictionary<string, V1api20240301AuthConfigSpecIdentityProvidersCustomOpenIdConnectProviders>? CustomOpenIdConnectProviders { get; set; }

    /// <summary>Facebook: The configuration settings of the Facebook provider.</summary>
    [JsonPropertyName("facebook")]
    public V1api20240301AuthConfigSpecIdentityProvidersFacebook? Facebook { get; set; }

    /// <summary>GitHub: The configuration settings of the GitHub provider.</summary>
    [JsonPropertyName("gitHub")]
    public V1api20240301AuthConfigSpecIdentityProvidersGitHub? GitHub { get; set; }

    /// <summary>Google: The configuration settings of the Google provider.</summary>
    [JsonPropertyName("google")]
    public V1api20240301AuthConfigSpecIdentityProvidersGoogle? Google { get; set; }

    /// <summary>Twitter: The configuration settings of the Twitter provider.</summary>
    [JsonPropertyName("twitter")]
    public V1api20240301AuthConfigSpecIdentityProvidersTwitter? Twitter { get; set; }
}

/// <summary>Convention: The convention used when determining the session cookie&apos;s expiration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301AuthConfigSpecLoginCookieExpirationConventionEnum>))]
public enum V1api20240301AuthConfigSpecLoginCookieExpirationConventionEnum
{
    [EnumMember(Value = "FixedTime"), JsonStringEnumMemberName("FixedTime")]
    FixedTime,
    [EnumMember(Value = "IdentityProviderDerived"), JsonStringEnumMemberName("IdentityProviderDerived")]
    IdentityProviderDerived
}

/// <summary>CookieExpiration: The configuration settings of the session cookie&apos;s expiration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecLoginCookieExpiration
{
    /// <summary>Convention: The convention used when determining the session cookie&apos;s expiration.</summary>
    [JsonPropertyName("convention")]
    public V1api20240301AuthConfigSpecLoginCookieExpirationConventionEnum? Convention { get; set; }

    /// <summary>TimeToExpiration: The time after the request is made when the session cookie should expire.</summary>
    [JsonPropertyName("timeToExpiration")]
    public string? TimeToExpiration { get; set; }
}

/// <summary>Nonce: The configuration settings of the nonce used in the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecLoginNonce
{
    /// <summary>NonceExpirationInterval: The time after the request is made when the nonce should expire.</summary>
    [JsonPropertyName("nonceExpirationInterval")]
    public string? NonceExpirationInterval { get; set; }

    /// <summary>
    /// ValidateNonce: &lt;code&gt;false&lt;/code&gt; if the nonce should not be validated while completing the login flow; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary>Routes: The routes that specify the endpoints used for login and logout requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecLoginRoutes
{
    /// <summary>LogoutEndpoint: The endpoint at which a logout request should be made.</summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }
}

/// <summary>AzureBlobStorage: The configuration settings of the storage of the tokens if blob storage is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecLoginTokenStoreAzureBlobStorage
{
    /// <summary>SasUrlSettingName: The name of the app secrets containing the SAS URL of the blob storage containing the tokens.</summary>
    [JsonPropertyName("sasUrlSettingName")]
    public required string SasUrlSettingName { get; set; }
}

/// <summary>TokenStore: The configuration settings of the token store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecLoginTokenStore
{
    /// <summary>AzureBlobStorage: The configuration settings of the storage of the tokens if blob storage is used.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1api20240301AuthConfigSpecLoginTokenStoreAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary>
    /// Enabled: &lt;code&gt;true&lt;/code&gt; to durably store platform-specific security tokens that are obtained during login flows;
    /// otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// The default is &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// TokenRefreshExtensionHours: The number of hours after session token expiration that a session token can be used to
    /// call the token refresh API. The default is 72 hours.
    /// </summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }
}

/// <summary>Login: The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecLogin
{
    /// <summary>
    /// AllowedExternalRedirectUrls: External URLs that can be redirected to as part of logging in or logging out of the app.
    /// Note that the query string part of the URL is ignored.
    /// This is an advanced setting typically only needed by Windows Store application backends.
    /// Note that URLs within the current domain are always implicitly allowed.
    /// </summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>CookieExpiration: The configuration settings of the session cookie&apos;s expiration.</summary>
    [JsonPropertyName("cookieExpiration")]
    public V1api20240301AuthConfigSpecLoginCookieExpiration? CookieExpiration { get; set; }

    /// <summary>Nonce: The configuration settings of the nonce used in the login flow.</summary>
    [JsonPropertyName("nonce")]
    public V1api20240301AuthConfigSpecLoginNonce? Nonce { get; set; }

    /// <summary>
    /// PreserveUrlFragmentsForLogins: &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request
    /// is made; otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>Routes: The routes that specify the endpoints used for login and logout requests.</summary>
    [JsonPropertyName("routes")]
    public V1api20240301AuthConfigSpecLoginRoutes? Routes { get; set; }

    /// <summary>TokenStore: The configuration settings of the token store.</summary>
    [JsonPropertyName("tokenStore")]
    public V1api20240301AuthConfigSpecLoginTokenStore? TokenStore { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301AuthConfigSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301AuthConfigSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a app.azure.com/ContainerApp resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Platform: The configuration settings of the platform of ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpecPlatform
{
    /// <summary>
    /// Enabled: &lt;code&gt;true&lt;/code&gt; if the Authentication / Authorization feature is enabled for the current app; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// RuntimeVersion: The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
    /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
    /// </summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// EncryptionSettings: The configuration settings of the secrets references of encryption key and signing key for
    /// ContainerApp Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20240301AuthConfigSpecEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// GlobalValidation: The configuration settings that determines the validation flow of users using  Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("globalValidation")]
    public V1api20240301AuthConfigSpecGlobalValidation? GlobalValidation { get; set; }

    /// <summary>
    /// HttpSettings: The configuration settings of the HTTP requests for authentication and authorization requests made against
    /// ContainerApp Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("httpSettings")]
    public V1api20240301AuthConfigSpecHttpSettings? HttpSettings { get; set; }

    /// <summary>
    /// IdentityProviders: The configuration settings of each of the identity providers used to configure ContainerApp Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("identityProviders")]
    public V1api20240301AuthConfigSpecIdentityProviders? IdentityProviders { get; set; }

    /// <summary>Login: The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigSpecLogin? Login { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301AuthConfigSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a app.azure.com/ContainerApp resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240301AuthConfigSpecOwner Owner { get; set; }

    /// <summary>Platform: The configuration settings of the platform of ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("platform")]
    public V1api20240301AuthConfigSpecPlatform? Platform { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusConditions
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

/// <summary>
/// EncryptionSettings: The configuration settings of the secrets references of encryption key and signing key for
/// ContainerApp Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusEncryptionSettings
{
    /// <summary>ContainerAppAuthEncryptionSecretName: The secret name which is referenced for EncryptionKey.</summary>
    [JsonPropertyName("containerAppAuthEncryptionSecretName")]
    public string? ContainerAppAuthEncryptionSecretName { get; set; }

    /// <summary>ContainerAppAuthSigningSecretName: The secret name which is referenced for SigningKey.</summary>
    [JsonPropertyName("containerAppAuthSigningSecretName")]
    public string? ContainerAppAuthSigningSecretName { get; set; }
}

/// <summary>
/// GlobalValidation: The configuration settings that determines the validation flow of users using  Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusGlobalValidation
{
    /// <summary>ExcludedPaths: The paths for which unauthenticated flow would not be redirected to the login page.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>
    /// RedirectToProvider: The default authentication provider to use when multiple providers are configured.
    /// This setting is only needed if multiple providers are configured and the unauthenticated client
    /// action is set to &quot;RedirectToLoginPage&quot;.
    /// </summary>
    [JsonPropertyName("redirectToProvider")]
    public string? RedirectToProvider { get; set; }

    /// <summary>UnauthenticatedClientAction: The action to take when an unauthenticated client attempts to access the app.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>ForwardProxy: The configuration settings of a forward proxy used to make the requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusHttpSettingsForwardProxy
{
    /// <summary>Convention: The convention used to determine the url of the request made.</summary>
    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    /// <summary>CustomHostHeaderName: The name of the header containing the host of the request.</summary>
    [JsonPropertyName("customHostHeaderName")]
    public string? CustomHostHeaderName { get; set; }

    /// <summary>CustomProtoHeaderName: The name of the header containing the scheme of the request.</summary>
    [JsonPropertyName("customProtoHeaderName")]
    public string? CustomProtoHeaderName { get; set; }
}

/// <summary>Routes: The configuration settings of the paths HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusHttpSettingsRoutes
{
    /// <summary>ApiPrefix: The prefix that should precede all the authentication/authorization paths.</summary>
    [JsonPropertyName("apiPrefix")]
    public string? ApiPrefix { get; set; }
}

/// <summary>
/// HttpSettings: The configuration settings of the HTTP requests for authentication and authorization requests made against
/// ContainerApp Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusHttpSettings
{
    /// <summary>ForwardProxy: The configuration settings of a forward proxy used to make the requests.</summary>
    [JsonPropertyName("forwardProxy")]
    public V1api20240301AuthConfigStatusHttpSettingsForwardProxy? ForwardProxy { get; set; }

    /// <summary>
    /// RequireHttps: &lt;code&gt;false&lt;/code&gt; if the authentication/authorization responses not having the HTTPS scheme are
    /// permissible; otherwise, &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>Routes: The configuration settings of the paths HTTP requests.</summary>
    [JsonPropertyName("routes")]
    public V1api20240301AuthConfigStatusHttpSettingsRoutes? Routes { get; set; }
}

/// <summary>Login: The configuration settings of the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAppleLogin
{
    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Registration: The configuration settings of the Apple registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAppleRegistration
{
    /// <summary>ClientId: The Client ID of the app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientSecretSettingName: The app setting name that contains the client secret.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Apple: The configuration settings of the Apple provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersApple
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Apple provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Login: The configuration settings of the login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigStatusIdentityProvidersAppleLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the Apple registration.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigStatusIdentityProvidersAppleRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the Azure Active Directory login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryLogin
{
    /// <summary>
    /// DisableWWWAuthenticate: &lt;code&gt;true&lt;/code&gt; if the www-authenticate provider should be omitted from the request;
    /// otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("disableWWWAuthenticate")]
    public bool? DisableWWWAuthenticate { get; set; }

    /// <summary>
    /// LoginParameters: Login parameters to send to the OpenID Connect authorization endpoint when
    /// a user logs in. Each parameter must be in the form &quot;key=value&quot;.
    /// </summary>
    [JsonPropertyName("loginParameters")]
    public IList<string>? LoginParameters { get; set; }
}

/// <summary>Registration: The configuration settings of the Azure Active Directory app registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryRegistration
{
    /// <summary>
    /// ClientId: The Client ID of this relying party application, known as the client_id.
    /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
    /// other 3rd party OpenID Connect providers.
    /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// ClientSecretCertificateIssuer: An alternative to the client secret thumbprint, that is the issuer of a certificate used
    /// for signing purposes. This property acts as
    /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
    /// </summary>
    [JsonPropertyName("clientSecretCertificateIssuer")]
    public string? ClientSecretCertificateIssuer { get; set; }

    /// <summary>
    /// ClientSecretCertificateSubjectAlternativeName: An alternative to the client secret thumbprint, that is the subject
    /// alternative name of a certificate used for signing purposes. This property acts as
    /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
    /// </summary>
    [JsonPropertyName("clientSecretCertificateSubjectAlternativeName")]
    public string? ClientSecretCertificateSubjectAlternativeName { get; set; }

    /// <summary>
    /// ClientSecretCertificateThumbprint: An alternative to the client secret, that is the thumbprint of a certificate used for
    /// signing purposes. This property acts as
    /// a replacement for the Client Secret. It is also optional.
    /// </summary>
    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    /// <summary>ClientSecretSettingName: The app setting name that contains the client secret of the relying party application.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>
    /// OpenIdIssuer: The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
    /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g.
    /// `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
    /// This URI is a case-sensitive identifier for the token issuer.
    /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
    /// </summary>
    [JsonPropertyName("openIdIssuer")]
    public string? OpenIdIssuer { get; set; }
}

/// <summary>AllowedPrincipals: The configuration settings of the Azure Active Directory allowed principals.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals
{
    /// <summary>Groups: The list of the allowed groups.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>Identities: The list of the allowed identities.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }
}

/// <summary>DefaultAuthorizationPolicy: The configuration settings of the default authorization policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy
{
    /// <summary>AllowedApplications: The configuration settings of the Azure Active Directory allowed applications.</summary>
    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>AllowedPrincipals: The configuration settings of the Azure Active Directory allowed principals.</summary>
    [JsonPropertyName("allowedPrincipals")]
    public V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals? AllowedPrincipals { get; set; }
}

/// <summary>JwtClaimChecks: The configuration settings of the checks that should be made while validating the JWT Claims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks
{
    /// <summary>AllowedClientApplications: The list of the allowed client applications.</summary>
    [JsonPropertyName("allowedClientApplications")]
    public IList<string>? AllowedClientApplications { get; set; }

    /// <summary>AllowedGroups: The list of the allowed groups.</summary>
    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }
}

/// <summary>Validation: The configuration settings of the Azure Active Directory token validation flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryValidation
{
    /// <summary>AllowedAudiences: The list of audiences that can make successful authentication/authorization requests.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>DefaultAuthorizationPolicy: The configuration settings of the default authorization policy.</summary>
    [JsonPropertyName("defaultAuthorizationPolicy")]
    public V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy? DefaultAuthorizationPolicy { get; set; }

    /// <summary>JwtClaimChecks: The configuration settings of the checks that should be made while validating the JWT Claims.</summary>
    [JsonPropertyName("jwtClaimChecks")]
    public V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks? JwtClaimChecks { get; set; }
}

/// <summary>AzureActiveDirectory: The configuration settings of the Azure Active directory provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectory
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Azure Active Directory provider should not be enabled despite the set registration;
    /// otherwise, &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// IsAutoProvisioned: Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party
    /// tooling.
    /// This is an internal flag primarily intended to support the Azure Management Portal. Users should not
    /// read or write to this property.
    /// </summary>
    [JsonPropertyName("isAutoProvisioned")]
    public bool? IsAutoProvisioned { get; set; }

    /// <summary>Login: The configuration settings of the Azure Active Directory login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the Azure Active Directory app registration.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryRegistration? Registration { get; set; }

    /// <summary>Validation: The configuration settings of the Azure Active Directory token validation flow.</summary>
    [JsonPropertyName("validation")]
    public V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectoryValidation? Validation { get; set; }
}

/// <summary>Registration: The configuration settings of the Azure Static Web Apps registration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAzureStaticWebAppsRegistration
{
    /// <summary>ClientId: The Client ID of the app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>AzureStaticWebApps: The configuration settings of the Azure Static Web Apps provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersAzureStaticWebApps
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Azure Static Web Apps provider should not be enabled despite the set registration;
    /// otherwise, &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Registration: The configuration settings of the Azure Static Web Apps registration.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigStatusIdentityProvidersAzureStaticWebAppsRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the login flow of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersLogin
{
    /// <summary>NameClaimType: The name of the claim that contains the users name.</summary>
    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>ClientCredential: The authentication credentials of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential
{
    /// <summary>ClientSecretSettingName: The app setting that contains the client secret for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    /// <summary>Method: The method that should be used to authenticate the user.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }
}

/// <summary>OpenIdConnectConfiguration: The configuration settings of the endpoints used for the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration
{
    /// <summary>AuthorizationEndpoint: The endpoint to be used to make an authorization request.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>CertificationUri: The endpoint that provides the keys necessary to validate the token.</summary>
    [JsonPropertyName("certificationUri")]
    public string? CertificationUri { get; set; }

    /// <summary>Issuer: The endpoint that issues the token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>TokenEndpoint: The endpoint to be used to request a token.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>WellKnownOpenIdConfiguration: The endpoint that contains all the configuration endpoints for the provider.</summary>
    [JsonPropertyName("wellKnownOpenIdConfiguration")]
    public string? WellKnownOpenIdConfiguration { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistration
{
    /// <summary>ClientCredential: The authentication credentials of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("clientCredential")]
    public V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential? ClientCredential { get; set; }

    /// <summary>ClientId: The client id of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>OpenIdConnectConfiguration: The configuration settings of the endpoints used for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("openIdConnectConfiguration")]
    public V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration? OpenIdConnectConfiguration { get; set; }
}

/// <summary>The configuration settings of the custom Open ID Connect provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProviders
{
    /// <summary>Enabled: &lt;code&gt;false&lt;/code&gt; if the custom Open ID provider provider should not be enabled; otherwise, &lt;code&gt;true&lt;/code&gt;.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Login: The configuration settings of the login flow of the custom Open ID Connect provider.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the custom Open ID Connect provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersFacebookLogin
{
    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the Facebook provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersFacebookRegistration
{
    /// <summary>AppId: The App ID of the app used for login.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>AppSecretSettingName: The app setting name that contains the app secret.</summary>
    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }
}

/// <summary>Facebook: The configuration settings of the Facebook provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersFacebook
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Facebook provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>GraphApiVersion: The version of the Facebook api to be used while logging in.</summary>
    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>Login: The configuration settings of the login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigStatusIdentityProvidersFacebookLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the Facebook provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigStatusIdentityProvidersFacebookRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersGitHubLogin
{
    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the GitHub provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersGitHubRegistration
{
    /// <summary>ClientId: The Client ID of the app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientSecretSettingName: The app setting name that contains the client secret.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>GitHub: The configuration settings of the GitHub provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersGitHub
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the GitHub provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Login: The configuration settings of the login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigStatusIdentityProvidersGitHubLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the GitHub provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigStatusIdentityProvidersGitHubRegistration? Registration { get; set; }
}

/// <summary>Login: The configuration settings of the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersGoogleLogin
{
    /// <summary>Scopes: A list of the scopes that should be requested while authenticating.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the Google provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersGoogleRegistration
{
    /// <summary>ClientId: The Client ID of the app used for login.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientSecretSettingName: The app setting name that contains the client secret.</summary>
    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>Validation: The configuration settings of the Azure Active Directory token validation flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersGoogleValidation
{
    /// <summary>AllowedAudiences: The configuration settings of the allowed list of audiences from which to validate the JWT token.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }
}

/// <summary>Google: The configuration settings of the Google provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersGoogle
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Google provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Login: The configuration settings of the login flow.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigStatusIdentityProvidersGoogleLogin? Login { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the Google provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigStatusIdentityProvidersGoogleRegistration? Registration { get; set; }

    /// <summary>Validation: The configuration settings of the Azure Active Directory token validation flow.</summary>
    [JsonPropertyName("validation")]
    public V1api20240301AuthConfigStatusIdentityProvidersGoogleValidation? Validation { get; set; }
}

/// <summary>Registration: The configuration settings of the app registration for the Twitter provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersTwitterRegistration
{
    /// <summary>
    /// ConsumerKey: The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// This setting is required for enabling Twitter Sign-In.
    /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
    /// </summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>
    /// ConsumerSecretSettingName: The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
    /// application used for sign-in.
    /// </summary>
    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>Twitter: The configuration settings of the Twitter provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProvidersTwitter
{
    /// <summary>
    /// Enabled: &lt;code&gt;false&lt;/code&gt; if the Twitter provider should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Registration: The configuration settings of the app registration for the Twitter provider.</summary>
    [JsonPropertyName("registration")]
    public V1api20240301AuthConfigStatusIdentityProvidersTwitterRegistration? Registration { get; set; }
}

/// <summary>
/// IdentityProviders: The configuration settings of each of the identity providers used to configure ContainerApp Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusIdentityProviders
{
    /// <summary>Apple: The configuration settings of the Apple provider.</summary>
    [JsonPropertyName("apple")]
    public V1api20240301AuthConfigStatusIdentityProvidersApple? Apple { get; set; }

    /// <summary>AzureActiveDirectory: The configuration settings of the Azure Active directory provider.</summary>
    [JsonPropertyName("azureActiveDirectory")]
    public V1api20240301AuthConfigStatusIdentityProvidersAzureActiveDirectory? AzureActiveDirectory { get; set; }

    /// <summary>AzureStaticWebApps: The configuration settings of the Azure Static Web Apps provider.</summary>
    [JsonPropertyName("azureStaticWebApps")]
    public V1api20240301AuthConfigStatusIdentityProvidersAzureStaticWebApps? AzureStaticWebApps { get; set; }

    /// <summary>
    /// CustomOpenIdConnectProviders: The map of the name of the alias of each custom Open ID Connect provider to the
    /// configuration settings of the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("customOpenIdConnectProviders")]
    public IDictionary<string, V1api20240301AuthConfigStatusIdentityProvidersCustomOpenIdConnectProviders>? CustomOpenIdConnectProviders { get; set; }

    /// <summary>Facebook: The configuration settings of the Facebook provider.</summary>
    [JsonPropertyName("facebook")]
    public V1api20240301AuthConfigStatusIdentityProvidersFacebook? Facebook { get; set; }

    /// <summary>GitHub: The configuration settings of the GitHub provider.</summary>
    [JsonPropertyName("gitHub")]
    public V1api20240301AuthConfigStatusIdentityProvidersGitHub? GitHub { get; set; }

    /// <summary>Google: The configuration settings of the Google provider.</summary>
    [JsonPropertyName("google")]
    public V1api20240301AuthConfigStatusIdentityProvidersGoogle? Google { get; set; }

    /// <summary>Twitter: The configuration settings of the Twitter provider.</summary>
    [JsonPropertyName("twitter")]
    public V1api20240301AuthConfigStatusIdentityProvidersTwitter? Twitter { get; set; }
}

/// <summary>CookieExpiration: The configuration settings of the session cookie&apos;s expiration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusLoginCookieExpiration
{
    /// <summary>Convention: The convention used when determining the session cookie&apos;s expiration.</summary>
    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    /// <summary>TimeToExpiration: The time after the request is made when the session cookie should expire.</summary>
    [JsonPropertyName("timeToExpiration")]
    public string? TimeToExpiration { get; set; }
}

/// <summary>Nonce: The configuration settings of the nonce used in the login flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusLoginNonce
{
    /// <summary>NonceExpirationInterval: The time after the request is made when the nonce should expire.</summary>
    [JsonPropertyName("nonceExpirationInterval")]
    public string? NonceExpirationInterval { get; set; }

    /// <summary>
    /// ValidateNonce: &lt;code&gt;false&lt;/code&gt; if the nonce should not be validated while completing the login flow; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary>Routes: The routes that specify the endpoints used for login and logout requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusLoginRoutes
{
    /// <summary>LogoutEndpoint: The endpoint at which a logout request should be made.</summary>
    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }
}

/// <summary>AzureBlobStorage: The configuration settings of the storage of the tokens if blob storage is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusLoginTokenStoreAzureBlobStorage
{
    /// <summary>SasUrlSettingName: The name of the app secrets containing the SAS URL of the blob storage containing the tokens.</summary>
    [JsonPropertyName("sasUrlSettingName")]
    public string? SasUrlSettingName { get; set; }
}

/// <summary>TokenStore: The configuration settings of the token store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusLoginTokenStore
{
    /// <summary>AzureBlobStorage: The configuration settings of the storage of the tokens if blob storage is used.</summary>
    [JsonPropertyName("azureBlobStorage")]
    public V1api20240301AuthConfigStatusLoginTokenStoreAzureBlobStorage? AzureBlobStorage { get; set; }

    /// <summary>
    /// Enabled: &lt;code&gt;true&lt;/code&gt; to durably store platform-specific security tokens that are obtained during login flows;
    /// otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// The default is &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// TokenRefreshExtensionHours: The number of hours after session token expiration that a session token can be used to
    /// call the token refresh API. The default is 72 hours.
    /// </summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }
}

/// <summary>Login: The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusLogin
{
    /// <summary>
    /// AllowedExternalRedirectUrls: External URLs that can be redirected to as part of logging in or logging out of the app.
    /// Note that the query string part of the URL is ignored.
    /// This is an advanced setting typically only needed by Windows Store application backends.
    /// Note that URLs within the current domain are always implicitly allowed.
    /// </summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>CookieExpiration: The configuration settings of the session cookie&apos;s expiration.</summary>
    [JsonPropertyName("cookieExpiration")]
    public V1api20240301AuthConfigStatusLoginCookieExpiration? CookieExpiration { get; set; }

    /// <summary>Nonce: The configuration settings of the nonce used in the login flow.</summary>
    [JsonPropertyName("nonce")]
    public V1api20240301AuthConfigStatusLoginNonce? Nonce { get; set; }

    /// <summary>
    /// PreserveUrlFragmentsForLogins: &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request
    /// is made; otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>Routes: The routes that specify the endpoints used for login and logout requests.</summary>
    [JsonPropertyName("routes")]
    public V1api20240301AuthConfigStatusLoginRoutes? Routes { get; set; }

    /// <summary>TokenStore: The configuration settings of the token store.</summary>
    [JsonPropertyName("tokenStore")]
    public V1api20240301AuthConfigStatusLoginTokenStore? TokenStore { get; set; }
}

/// <summary>Platform: The configuration settings of the platform of ContainerApp Service Authentication/Authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusPlatform
{
    /// <summary>
    /// Enabled: &lt;code&gt;true&lt;/code&gt; if the Authentication / Authorization feature is enabled for the current app; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// RuntimeVersion: The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
    /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
    /// </summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301AuthConfigStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240301AuthConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// EncryptionSettings: The configuration settings of the secrets references of encryption key and signing key for
    /// ContainerApp Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20240301AuthConfigStatusEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// GlobalValidation: The configuration settings that determines the validation flow of users using  Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("globalValidation")]
    public V1api20240301AuthConfigStatusGlobalValidation? GlobalValidation { get; set; }

    /// <summary>
    /// HttpSettings: The configuration settings of the HTTP requests for authentication and authorization requests made against
    /// ContainerApp Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("httpSettings")]
    public V1api20240301AuthConfigStatusHttpSettings? HttpSettings { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IdentityProviders: The configuration settings of each of the identity providers used to configure ContainerApp Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("identityProviders")]
    public V1api20240301AuthConfigStatusIdentityProviders? IdentityProviders { get; set; }

    /// <summary>Login: The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("login")]
    public V1api20240301AuthConfigStatusLogin? Login { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Platform: The configuration settings of the platform of ContainerApp Service Authentication/Authorization.</summary>
    [JsonPropertyName("platform")]
    public V1api20240301AuthConfigStatusPlatform? Platform { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240301AuthConfigStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2024-03-01/AuthConfigs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301AuthConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301AuthConfigSpec?>, IStatus<V1api20240301AuthConfigStatus?>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "AuthConfig";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "authconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240301AuthConfigSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240301AuthConfigStatus? Status { get; set; }
}