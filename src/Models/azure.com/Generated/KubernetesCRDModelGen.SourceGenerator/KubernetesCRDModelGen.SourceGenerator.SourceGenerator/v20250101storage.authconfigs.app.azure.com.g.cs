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
/// Storage version of v20250101.AuthConfig
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2025-01-01/AuthConfigs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101storageAuthConfigList : IKubernetesObject<V1ListMeta>, IItems<V20250101storageAuthConfig>
{
    public const string KubeApiVersion = "v20250101storage";
    public const string KubeKind = "AuthConfigList";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "authconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20250101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250101storageAuthConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250101storageAuthConfig> Items { get; set; }
}

/// <summary>
/// Storage version of v20250101.EncryptionSettings
/// The configuration settings of the secrets references of encryption key and signing key for ContainerApp Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecEncryptionSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containerAppAuthEncryptionSecretName")]
    public string? ContainerAppAuthEncryptionSecretName { get; set; }

    [JsonPropertyName("containerAppAuthSigningSecretName")]
    public string? ContainerAppAuthSigningSecretName { get; set; }
}

/// <summary>
/// Storage version of v20250101.GlobalValidation
/// The configuration settings that determines the validation flow of users using ContainerApp Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecGlobalValidation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    [JsonPropertyName("redirectToProvider")]
    public string? RedirectToProvider { get; set; }

    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>
/// Storage version of v20250101.ForwardProxy
/// The configuration settings of a forward proxy used to make the requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecHttpSettingsForwardProxy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    [JsonPropertyName("customHostHeaderName")]
    public string? CustomHostHeaderName { get; set; }

    [JsonPropertyName("customProtoHeaderName")]
    public string? CustomProtoHeaderName { get; set; }
}

/// <summary>
/// Storage version of v20250101.HttpSettingsRoutes
/// The configuration settings of the paths HTTP requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecHttpSettingsRoutes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("apiPrefix")]
    public string? ApiPrefix { get; set; }
}

/// <summary>
/// Storage version of v20250101.HttpSettings
/// The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp
/// Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecHttpSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250101.ForwardProxy
    /// The configuration settings of a forward proxy used to make the requests.
    /// </summary>
    [JsonPropertyName("forwardProxy")]
    public V20250101storageAuthConfigSpecHttpSettingsForwardProxy? ForwardProxy { get; set; }

    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>
    /// Storage version of v20250101.HttpSettingsRoutes
    /// The configuration settings of the paths HTTP requests.
    /// </summary>
    [JsonPropertyName("routes")]
    public V20250101storageAuthConfigSpecHttpSettingsRoutes? Routes { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginScopes
/// The configuration settings of the login flow, including the scopes that should be requested.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAppleLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.AppleRegistration
/// The configuration settings of the registration for the Apple provider
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAppleRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.Apple
/// The configuration settings of the Apple provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersApple
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginScopes
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigSpecIdentityProvidersAppleLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.AppleRegistration
    /// The configuration settings of the registration for the Apple provider
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigSpecIdentityProvidersAppleRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureActiveDirectoryLogin
/// The configuration settings of the Azure Active Directory login flow.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disableWWWAuthenticate")]
    public bool? DisableWWWAuthenticate { get; set; }

    [JsonPropertyName("loginParameters")]
    public IList<string>? LoginParameters { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureActiveDirectoryRegistration
/// The configuration settings of the Azure Active Directory app registration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecretCertificateIssuer")]
    public string? ClientSecretCertificateIssuer { get; set; }

    [JsonPropertyName("clientSecretCertificateSubjectAlternativeName")]
    public string? ClientSecretCertificateSubjectAlternativeName { get; set; }

    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    [JsonPropertyName("openIdIssuer")]
    public string? OpenIdIssuer { get; set; }
}

/// <summary>
/// Storage version of v20250101.AllowedPrincipals
/// The configuration settings of the Azure Active Directory allowed principals.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }
}

/// <summary>
/// Storage version of v20250101.DefaultAuthorizationPolicy
/// The configuration settings of the Azure Active Directory default authorization policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>
    /// Storage version of v20250101.AllowedPrincipals
    /// The configuration settings of the Azure Active Directory allowed principals.
    /// </summary>
    [JsonPropertyName("allowedPrincipals")]
    public V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals? AllowedPrincipals { get; set; }
}

/// <summary>
/// Storage version of v20250101.JwtClaimChecks
/// The configuration settings of the checks that should be made while validating the JWT Claims.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedClientApplications")]
    public IList<string>? AllowedClientApplications { get; set; }

    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureActiveDirectoryValidation
/// The configuration settings of the Azure Active Directory token validation flow.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// Storage version of v20250101.DefaultAuthorizationPolicy
    /// The configuration settings of the Azure Active Directory default authorization policy.
    /// </summary>
    [JsonPropertyName("defaultAuthorizationPolicy")]
    public V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy? DefaultAuthorizationPolicy { get; set; }

    /// <summary>
    /// Storage version of v20250101.JwtClaimChecks
    /// The configuration settings of the checks that should be made while validating the JWT Claims.
    /// </summary>
    [JsonPropertyName("jwtClaimChecks")]
    public V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks? JwtClaimChecks { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureActiveDirectory
/// The configuration settings of the Azure Active directory provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectory
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("isAutoProvisioned")]
    public bool? IsAutoProvisioned { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureActiveDirectoryLogin
    /// The configuration settings of the Azure Active Directory login flow.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureActiveDirectoryRegistration
    /// The configuration settings of the Azure Active Directory app registration.
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryRegistration? Registration { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureActiveDirectoryValidation
    /// The configuration settings of the Azure Active Directory token validation flow.
    /// </summary>
    [JsonPropertyName("validation")]
    public V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectoryValidation? Validation { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureStaticWebAppsRegistration
/// The configuration settings of the registration for the Azure Static Web Apps provider
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAzureStaticWebAppsRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureStaticWebApps
/// The configuration settings of the Azure Static Web Apps provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersAzureStaticWebApps
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureStaticWebAppsRegistration
    /// The configuration settings of the registration for the Azure Static Web Apps provider
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigSpecIdentityProvidersAzureStaticWebAppsRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.OpenIdConnectLogin
/// The configuration settings of the login flow of the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.OpenIdConnectClientCredential
/// The authentication client credentials of the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    [JsonPropertyName("method")]
    public string? Method { get; set; }
}

/// <summary>
/// Storage version of v20250101.OpenIdConnectConfig
/// The configuration settings of the endpoints used for the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    [JsonPropertyName("certificationUri")]
    public string? CertificationUri { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    [JsonPropertyName("wellKnownOpenIdConfiguration")]
    public string? WellKnownOpenIdConfiguration { get; set; }
}

/// <summary>
/// Storage version of v20250101.OpenIdConnectRegistration
/// The configuration settings of the app registration for the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250101.OpenIdConnectClientCredential
    /// The authentication client credentials of the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("clientCredential")]
    public V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential? ClientCredential { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// Storage version of v20250101.OpenIdConnectConfig
    /// The configuration settings of the endpoints used for the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("openIdConnectConfiguration")]
    public V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration? OpenIdConnectConfiguration { get; set; }
}

/// <summary>
/// Storage version of v20250101.CustomOpenIdConnectProvider
/// The configuration settings of the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProviders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.OpenIdConnectLogin
    /// The configuration settings of the login flow of the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.OpenIdConnectRegistration
    /// The configuration settings of the app registration for the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProvidersRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginScopes
/// The configuration settings of the login flow, including the scopes that should be requested.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersFacebookLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.AppRegistration
/// The configuration settings of the app registration for providers that have app ids and app secrets
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersFacebookRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.Facebook
/// The configuration settings of the Facebook provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersFacebook
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginScopes
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigSpecIdentityProvidersFacebookLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.AppRegistration
    /// The configuration settings of the app registration for providers that have app ids and app secrets
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigSpecIdentityProvidersFacebookRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginScopes
/// The configuration settings of the login flow, including the scopes that should be requested.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersGitHubLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.ClientRegistration
/// The configuration settings of the app registration for providers that have client ids and client secrets
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersGitHubRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.GitHub
/// The configuration settings of the GitHub provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersGitHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginScopes
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigSpecIdentityProvidersGitHubLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.ClientRegistration
    /// The configuration settings of the app registration for providers that have client ids and client secrets
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigSpecIdentityProvidersGitHubRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginScopes
/// The configuration settings of the login flow, including the scopes that should be requested.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersGoogleLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.ClientRegistration
/// The configuration settings of the app registration for providers that have client ids and client secrets
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersGoogleRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.AllowedAudiencesValidation
/// The configuration settings of the Allowed Audiences validation flow.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersGoogleValidation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }
}

/// <summary>
/// Storage version of v20250101.Google
/// The configuration settings of the Google provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersGoogle
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginScopes
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigSpecIdentityProvidersGoogleLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.ClientRegistration
    /// The configuration settings of the app registration for providers that have client ids and client secrets
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigSpecIdentityProvidersGoogleRegistration? Registration { get; set; }

    /// <summary>
    /// Storage version of v20250101.AllowedAudiencesValidation
    /// The configuration settings of the Allowed Audiences validation flow.
    /// </summary>
    [JsonPropertyName("validation")]
    public V20250101storageAuthConfigSpecIdentityProvidersGoogleValidation? Validation { get; set; }
}

/// <summary>
/// Storage version of v20250101.TwitterRegistration
/// The configuration settings of the app registration for the Twitter provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersTwitterRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.Twitter
/// The configuration settings of the Twitter provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProvidersTwitter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.TwitterRegistration
    /// The configuration settings of the app registration for the Twitter provider.
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigSpecIdentityProvidersTwitterRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.IdentityProviders
/// The configuration settings of each of the identity providers used to configure ContainerApp Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecIdentityProviders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250101.Apple
    /// The configuration settings of the Apple provider.
    /// </summary>
    [JsonPropertyName("apple")]
    public V20250101storageAuthConfigSpecIdentityProvidersApple? Apple { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureActiveDirectory
    /// The configuration settings of the Azure Active directory provider.
    /// </summary>
    [JsonPropertyName("azureActiveDirectory")]
    public V20250101storageAuthConfigSpecIdentityProvidersAzureActiveDirectory? AzureActiveDirectory { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureStaticWebApps
    /// The configuration settings of the Azure Static Web Apps provider.
    /// </summary>
    [JsonPropertyName("azureStaticWebApps")]
    public V20250101storageAuthConfigSpecIdentityProvidersAzureStaticWebApps? AzureStaticWebApps { get; set; }

    [JsonPropertyName("customOpenIdConnectProviders")]
    public IDictionary<string, V20250101storageAuthConfigSpecIdentityProvidersCustomOpenIdConnectProviders>? CustomOpenIdConnectProviders { get; set; }

    /// <summary>
    /// Storage version of v20250101.Facebook
    /// The configuration settings of the Facebook provider.
    /// </summary>
    [JsonPropertyName("facebook")]
    public V20250101storageAuthConfigSpecIdentityProvidersFacebook? Facebook { get; set; }

    /// <summary>
    /// Storage version of v20250101.GitHub
    /// The configuration settings of the GitHub provider.
    /// </summary>
    [JsonPropertyName("gitHub")]
    public V20250101storageAuthConfigSpecIdentityProvidersGitHub? GitHub { get; set; }

    /// <summary>
    /// Storage version of v20250101.Google
    /// The configuration settings of the Google provider.
    /// </summary>
    [JsonPropertyName("google")]
    public V20250101storageAuthConfigSpecIdentityProvidersGoogle? Google { get; set; }

    /// <summary>
    /// Storage version of v20250101.Twitter
    /// The configuration settings of the Twitter provider.
    /// </summary>
    [JsonPropertyName("twitter")]
    public V20250101storageAuthConfigSpecIdentityProvidersTwitter? Twitter { get; set; }
}

/// <summary>
/// Storage version of v20250101.CookieExpiration
/// The configuration settings of the session cookie&apos;s expiration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecLoginCookieExpiration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    [JsonPropertyName("timeToExpiration")]
    public string? TimeToExpiration { get; set; }
}

/// <summary>
/// Storage version of v20250101.Nonce
/// The configuration settings of the nonce used in the login flow.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecLoginNonce
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("nonceExpirationInterval")]
    public string? NonceExpirationInterval { get; set; }

    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginRoutes
/// The routes that specify the endpoints used for login and logout requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecLoginRoutes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }
}

/// <summary>
/// Storage version of v20250101.BlobStorageTokenStore
/// The configuration settings of the storage of the tokens if blob storage is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecLoginTokenStoreAzureBlobStorage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("sasUrlSettingName")]
    public string? SasUrlSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.TokenStore
/// The configuration settings of the token store.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecLoginTokenStore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250101.BlobStorageTokenStore
    /// The configuration settings of the storage of the tokens if blob storage is used.
    /// </summary>
    [JsonPropertyName("azureBlobStorage")]
    public V20250101storageAuthConfigSpecLoginTokenStoreAzureBlobStorage? AzureBlobStorage { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }
}

/// <summary>
/// Storage version of v20250101.Login
/// The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// Storage version of v20250101.CookieExpiration
    /// The configuration settings of the session cookie&apos;s expiration.
    /// </summary>
    [JsonPropertyName("cookieExpiration")]
    public V20250101storageAuthConfigSpecLoginCookieExpiration? CookieExpiration { get; set; }

    /// <summary>
    /// Storage version of v20250101.Nonce
    /// The configuration settings of the nonce used in the login flow.
    /// </summary>
    [JsonPropertyName("nonce")]
    public V20250101storageAuthConfigSpecLoginNonce? Nonce { get; set; }

    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginRoutes
    /// The routes that specify the endpoints used for login and logout requests.
    /// </summary>
    [JsonPropertyName("routes")]
    public V20250101storageAuthConfigSpecLoginRoutes? Routes { get; set; }

    /// <summary>
    /// Storage version of v20250101.TokenStore
    /// The configuration settings of the token store.
    /// </summary>
    [JsonPropertyName("tokenStore")]
    public V20250101storageAuthConfigSpecLoginTokenStore? TokenStore { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecOperatorSpecConfigMapExpressions
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
public partial class V20250101storageAuthConfigSpecOperatorSpecSecretExpressions
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
/// Storage version of v20250101.AuthConfigOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20250101storageAuthConfigSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20250101storageAuthConfigSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a app.azure.com/ContainerApp resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250101.AuthPlatform
/// The configuration settings of the platform of ContainerApp Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpecPlatform
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>Storage version of v20250101.AuthConfig_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v20250101.EncryptionSettings
    /// The configuration settings of the secrets references of encryption key and signing key for ContainerApp Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public V20250101storageAuthConfigSpecEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// Storage version of v20250101.GlobalValidation
    /// The configuration settings that determines the validation flow of users using ContainerApp Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("globalValidation")]
    public V20250101storageAuthConfigSpecGlobalValidation? GlobalValidation { get; set; }

    /// <summary>
    /// Storage version of v20250101.HttpSettings
    /// The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp
    /// Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("httpSettings")]
    public V20250101storageAuthConfigSpecHttpSettings? HttpSettings { get; set; }

    /// <summary>
    /// Storage version of v20250101.IdentityProviders
    /// The configuration settings of each of the identity providers used to configure ContainerApp Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("identityProviders")]
    public V20250101storageAuthConfigSpecIdentityProviders? IdentityProviders { get; set; }

    /// <summary>
    /// Storage version of v20250101.Login
    /// The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigSpecLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.AuthConfigOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250101storageAuthConfigSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a app.azure.com/ContainerApp resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250101storageAuthConfigSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20250101.AuthPlatform
    /// The configuration settings of the platform of ContainerApp Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("platform")]
    public V20250101storageAuthConfigSpecPlatform? Platform { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusConditions
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
/// Storage version of v20250101.EncryptionSettings_STATUS
/// The configuration settings of the secrets references of encryption key and signing key for ContainerApp Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusEncryptionSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containerAppAuthEncryptionSecretName")]
    public string? ContainerAppAuthEncryptionSecretName { get; set; }

    [JsonPropertyName("containerAppAuthSigningSecretName")]
    public string? ContainerAppAuthSigningSecretName { get; set; }
}

/// <summary>
/// Storage version of v20250101.GlobalValidation_STATUS
/// The configuration settings that determines the validation flow of users using ContainerApp Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusGlobalValidation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    [JsonPropertyName("redirectToProvider")]
    public string? RedirectToProvider { get; set; }

    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>
/// Storage version of v20250101.ForwardProxy_STATUS
/// The configuration settings of a forward proxy used to make the requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusHttpSettingsForwardProxy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    [JsonPropertyName("customHostHeaderName")]
    public string? CustomHostHeaderName { get; set; }

    [JsonPropertyName("customProtoHeaderName")]
    public string? CustomProtoHeaderName { get; set; }
}

/// <summary>
/// Storage version of v20250101.HttpSettingsRoutes_STATUS
/// The configuration settings of the paths HTTP requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusHttpSettingsRoutes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("apiPrefix")]
    public string? ApiPrefix { get; set; }
}

/// <summary>
/// Storage version of v20250101.HttpSettings_STATUS
/// The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp
/// Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusHttpSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250101.ForwardProxy_STATUS
    /// The configuration settings of a forward proxy used to make the requests.
    /// </summary>
    [JsonPropertyName("forwardProxy")]
    public V20250101storageAuthConfigStatusHttpSettingsForwardProxy? ForwardProxy { get; set; }

    [JsonPropertyName("requireHttps")]
    public bool? RequireHttps { get; set; }

    /// <summary>
    /// Storage version of v20250101.HttpSettingsRoutes_STATUS
    /// The configuration settings of the paths HTTP requests.
    /// </summary>
    [JsonPropertyName("routes")]
    public V20250101storageAuthConfigStatusHttpSettingsRoutes? Routes { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginScopes_STATUS
/// The configuration settings of the login flow, including the scopes that should be requested.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAppleLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.AppleRegistration_STATUS
/// The configuration settings of the registration for the Apple provider
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAppleRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.Apple_STATUS
/// The configuration settings of the Apple provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersApple
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginScopes_STATUS
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigStatusIdentityProvidersAppleLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.AppleRegistration_STATUS
    /// The configuration settings of the registration for the Apple provider
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigStatusIdentityProvidersAppleRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureActiveDirectoryLogin_STATUS
/// The configuration settings of the Azure Active Directory login flow.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("disableWWWAuthenticate")]
    public bool? DisableWWWAuthenticate { get; set; }

    [JsonPropertyName("loginParameters")]
    public IList<string>? LoginParameters { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureActiveDirectoryRegistration_STATUS
/// The configuration settings of the Azure Active Directory app registration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecretCertificateIssuer")]
    public string? ClientSecretCertificateIssuer { get; set; }

    [JsonPropertyName("clientSecretCertificateSubjectAlternativeName")]
    public string? ClientSecretCertificateSubjectAlternativeName { get; set; }

    [JsonPropertyName("clientSecretCertificateThumbprint")]
    public string? ClientSecretCertificateThumbprint { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    [JsonPropertyName("openIdIssuer")]
    public string? OpenIdIssuer { get; set; }
}

/// <summary>
/// Storage version of v20250101.AllowedPrincipals_STATUS
/// The configuration settings of the Azure Active Directory allowed principals.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }
}

/// <summary>
/// Storage version of v20250101.DefaultAuthorizationPolicy_STATUS
/// The configuration settings of the Azure Active Directory default authorization policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedApplications")]
    public IList<string>? AllowedApplications { get; set; }

    /// <summary>
    /// Storage version of v20250101.AllowedPrincipals_STATUS
    /// The configuration settings of the Azure Active Directory allowed principals.
    /// </summary>
    [JsonPropertyName("allowedPrincipals")]
    public V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicyAllowedPrincipals? AllowedPrincipals { get; set; }
}

/// <summary>
/// Storage version of v20250101.JwtClaimChecks_STATUS
/// The configuration settings of the checks that should be made while validating the JWT Claims.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedClientApplications")]
    public IList<string>? AllowedClientApplications { get; set; }

    [JsonPropertyName("allowedGroups")]
    public IList<string>? AllowedGroups { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureActiveDirectoryValidation_STATUS
/// The configuration settings of the Azure Active Directory token validation flow.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>
    /// Storage version of v20250101.DefaultAuthorizationPolicy_STATUS
    /// The configuration settings of the Azure Active Directory default authorization policy.
    /// </summary>
    [JsonPropertyName("defaultAuthorizationPolicy")]
    public V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationDefaultAuthorizationPolicy? DefaultAuthorizationPolicy { get; set; }

    /// <summary>
    /// Storage version of v20250101.JwtClaimChecks_STATUS
    /// The configuration settings of the checks that should be made while validating the JWT Claims.
    /// </summary>
    [JsonPropertyName("jwtClaimChecks")]
    public V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidationJwtClaimChecks? JwtClaimChecks { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureActiveDirectory_STATUS
/// The configuration settings of the Azure Active directory provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectory
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("isAutoProvisioned")]
    public bool? IsAutoProvisioned { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureActiveDirectoryLogin_STATUS
    /// The configuration settings of the Azure Active Directory login flow.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureActiveDirectoryRegistration_STATUS
    /// The configuration settings of the Azure Active Directory app registration.
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryRegistration? Registration { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureActiveDirectoryValidation_STATUS
    /// The configuration settings of the Azure Active Directory token validation flow.
    /// </summary>
    [JsonPropertyName("validation")]
    public V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectoryValidation? Validation { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureStaticWebAppsRegistration_STATUS
/// The configuration settings of the registration for the Azure Static Web Apps provider
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAzureStaticWebAppsRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>
/// Storage version of v20250101.AzureStaticWebApps_STATUS
/// The configuration settings of the Azure Static Web Apps provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersAzureStaticWebApps
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureStaticWebAppsRegistration_STATUS
    /// The configuration settings of the registration for the Azure Static Web Apps provider
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigStatusIdentityProvidersAzureStaticWebAppsRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.OpenIdConnectLogin_STATUS
/// The configuration settings of the login flow of the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("nameClaimType")]
    public string? NameClaimType { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.OpenIdConnectClientCredential_STATUS
/// The authentication client credentials of the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }

    [JsonPropertyName("method")]
    public string? Method { get; set; }
}

/// <summary>
/// Storage version of v20250101.OpenIdConnectConfig_STATUS
/// The configuration settings of the endpoints used for the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    [JsonPropertyName("certificationUri")]
    public string? CertificationUri { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    [JsonPropertyName("wellKnownOpenIdConfiguration")]
    public string? WellKnownOpenIdConfiguration { get; set; }
}

/// <summary>
/// Storage version of v20250101.OpenIdConnectRegistration_STATUS
/// The configuration settings of the app registration for the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250101.OpenIdConnectClientCredential_STATUS
    /// The authentication client credentials of the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("clientCredential")]
    public V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationClientCredential? ClientCredential { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// Storage version of v20250101.OpenIdConnectConfig_STATUS
    /// The configuration settings of the endpoints used for the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("openIdConnectConfiguration")]
    public V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistrationOpenIdConnectConfiguration? OpenIdConnectConfiguration { get; set; }
}

/// <summary>
/// Storage version of v20250101.CustomOpenIdConnectProvider_STATUS
/// The configuration settings of the custom Open ID Connect provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProviders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.OpenIdConnectLogin_STATUS
    /// The configuration settings of the login flow of the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.OpenIdConnectRegistration_STATUS
    /// The configuration settings of the app registration for the custom Open ID Connect provider.
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProvidersRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginScopes_STATUS
/// The configuration settings of the login flow, including the scopes that should be requested.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersFacebookLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.AppRegistration_STATUS
/// The configuration settings of the app registration for providers that have app ids and app secrets
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersFacebookRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    [JsonPropertyName("appSecretSettingName")]
    public string? AppSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.Facebook_STATUS
/// The configuration settings of the Facebook provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersFacebook
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginScopes_STATUS
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigStatusIdentityProvidersFacebookLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.AppRegistration_STATUS
    /// The configuration settings of the app registration for providers that have app ids and app secrets
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigStatusIdentityProvidersFacebookRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginScopes_STATUS
/// The configuration settings of the login flow, including the scopes that should be requested.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersGitHubLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.ClientRegistration_STATUS
/// The configuration settings of the app registration for providers that have client ids and client secrets
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersGitHubRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.GitHub_STATUS
/// The configuration settings of the GitHub provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersGitHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginScopes_STATUS
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigStatusIdentityProvidersGitHubLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.ClientRegistration_STATUS
    /// The configuration settings of the app registration for providers that have client ids and client secrets
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigStatusIdentityProvidersGitHubRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginScopes_STATUS
/// The configuration settings of the login flow, including the scopes that should be requested.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersGoogleLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Storage version of v20250101.ClientRegistration_STATUS
/// The configuration settings of the app registration for providers that have client ids and client secrets
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersGoogleRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecretSettingName")]
    public string? ClientSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.AllowedAudiencesValidation_STATUS
/// The configuration settings of the Allowed Audiences validation flow.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersGoogleValidation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }
}

/// <summary>
/// Storage version of v20250101.Google_STATUS
/// The configuration settings of the Google provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersGoogle
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginScopes_STATUS
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigStatusIdentityProvidersGoogleLogin? Login { get; set; }

    /// <summary>
    /// Storage version of v20250101.ClientRegistration_STATUS
    /// The configuration settings of the app registration for providers that have client ids and client secrets
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigStatusIdentityProvidersGoogleRegistration? Registration { get; set; }

    /// <summary>
    /// Storage version of v20250101.AllowedAudiencesValidation_STATUS
    /// The configuration settings of the Allowed Audiences validation flow.
    /// </summary>
    [JsonPropertyName("validation")]
    public V20250101storageAuthConfigStatusIdentityProvidersGoogleValidation? Validation { get; set; }
}

/// <summary>
/// Storage version of v20250101.TwitterRegistration_STATUS
/// The configuration settings of the app registration for the Twitter provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersTwitterRegistration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    [JsonPropertyName("consumerSecretSettingName")]
    public string? ConsumerSecretSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.Twitter_STATUS
/// The configuration settings of the Twitter provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProvidersTwitter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250101.TwitterRegistration_STATUS
    /// The configuration settings of the app registration for the Twitter provider.
    /// </summary>
    [JsonPropertyName("registration")]
    public V20250101storageAuthConfigStatusIdentityProvidersTwitterRegistration? Registration { get; set; }
}

/// <summary>
/// Storage version of v20250101.IdentityProviders_STATUS
/// The configuration settings of each of the identity providers used to configure ContainerApp Service
/// Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusIdentityProviders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250101.Apple_STATUS
    /// The configuration settings of the Apple provider.
    /// </summary>
    [JsonPropertyName("apple")]
    public V20250101storageAuthConfigStatusIdentityProvidersApple? Apple { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureActiveDirectory_STATUS
    /// The configuration settings of the Azure Active directory provider.
    /// </summary>
    [JsonPropertyName("azureActiveDirectory")]
    public V20250101storageAuthConfigStatusIdentityProvidersAzureActiveDirectory? AzureActiveDirectory { get; set; }

    /// <summary>
    /// Storage version of v20250101.AzureStaticWebApps_STATUS
    /// The configuration settings of the Azure Static Web Apps provider.
    /// </summary>
    [JsonPropertyName("azureStaticWebApps")]
    public V20250101storageAuthConfigStatusIdentityProvidersAzureStaticWebApps? AzureStaticWebApps { get; set; }

    [JsonPropertyName("customOpenIdConnectProviders")]
    public IDictionary<string, V20250101storageAuthConfigStatusIdentityProvidersCustomOpenIdConnectProviders>? CustomOpenIdConnectProviders { get; set; }

    /// <summary>
    /// Storage version of v20250101.Facebook_STATUS
    /// The configuration settings of the Facebook provider.
    /// </summary>
    [JsonPropertyName("facebook")]
    public V20250101storageAuthConfigStatusIdentityProvidersFacebook? Facebook { get; set; }

    /// <summary>
    /// Storage version of v20250101.GitHub_STATUS
    /// The configuration settings of the GitHub provider.
    /// </summary>
    [JsonPropertyName("gitHub")]
    public V20250101storageAuthConfigStatusIdentityProvidersGitHub? GitHub { get; set; }

    /// <summary>
    /// Storage version of v20250101.Google_STATUS
    /// The configuration settings of the Google provider.
    /// </summary>
    [JsonPropertyName("google")]
    public V20250101storageAuthConfigStatusIdentityProvidersGoogle? Google { get; set; }

    /// <summary>
    /// Storage version of v20250101.Twitter_STATUS
    /// The configuration settings of the Twitter provider.
    /// </summary>
    [JsonPropertyName("twitter")]
    public V20250101storageAuthConfigStatusIdentityProvidersTwitter? Twitter { get; set; }
}

/// <summary>
/// Storage version of v20250101.CookieExpiration_STATUS
/// The configuration settings of the session cookie&apos;s expiration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusLoginCookieExpiration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("convention")]
    public string? Convention { get; set; }

    [JsonPropertyName("timeToExpiration")]
    public string? TimeToExpiration { get; set; }
}

/// <summary>
/// Storage version of v20250101.Nonce_STATUS
/// The configuration settings of the nonce used in the login flow.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusLoginNonce
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("nonceExpirationInterval")]
    public string? NonceExpirationInterval { get; set; }

    [JsonPropertyName("validateNonce")]
    public bool? ValidateNonce { get; set; }
}

/// <summary>
/// Storage version of v20250101.LoginRoutes_STATUS
/// The routes that specify the endpoints used for login and logout requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusLoginRoutes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("logoutEndpoint")]
    public string? LogoutEndpoint { get; set; }
}

/// <summary>
/// Storage version of v20250101.BlobStorageTokenStore_STATUS
/// The configuration settings of the storage of the tokens if blob storage is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusLoginTokenStoreAzureBlobStorage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("sasUrlSettingName")]
    public string? SasUrlSettingName { get; set; }
}

/// <summary>
/// Storage version of v20250101.TokenStore_STATUS
/// The configuration settings of the token store.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusLoginTokenStore
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250101.BlobStorageTokenStore_STATUS
    /// The configuration settings of the storage of the tokens if blob storage is used.
    /// </summary>
    [JsonPropertyName("azureBlobStorage")]
    public V20250101storageAuthConfigStatusLoginTokenStoreAzureBlobStorage? AzureBlobStorage { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }
}

/// <summary>
/// Storage version of v20250101.Login_STATUS
/// The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusLogin
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// Storage version of v20250101.CookieExpiration_STATUS
    /// The configuration settings of the session cookie&apos;s expiration.
    /// </summary>
    [JsonPropertyName("cookieExpiration")]
    public V20250101storageAuthConfigStatusLoginCookieExpiration? CookieExpiration { get; set; }

    /// <summary>
    /// Storage version of v20250101.Nonce_STATUS
    /// The configuration settings of the nonce used in the login flow.
    /// </summary>
    [JsonPropertyName("nonce")]
    public V20250101storageAuthConfigStatusLoginNonce? Nonce { get; set; }

    [JsonPropertyName("preserveUrlFragmentsForLogins")]
    public bool? PreserveUrlFragmentsForLogins { get; set; }

    /// <summary>
    /// Storage version of v20250101.LoginRoutes_STATUS
    /// The routes that specify the endpoints used for login and logout requests.
    /// </summary>
    [JsonPropertyName("routes")]
    public V20250101storageAuthConfigStatusLoginRoutes? Routes { get; set; }

    /// <summary>
    /// Storage version of v20250101.TokenStore_STATUS
    /// The configuration settings of the token store.
    /// </summary>
    [JsonPropertyName("tokenStore")]
    public V20250101storageAuthConfigStatusLoginTokenStore? TokenStore { get; set; }
}

/// <summary>
/// Storage version of v20250101.AuthPlatform_STATUS
/// The configuration settings of the platform of ContainerApp Service Authentication/Authorization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusPlatform
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>
/// Storage version of v20250101.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v20250101.AuthConfig_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageAuthConfigStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20250101storageAuthConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20250101.EncryptionSettings_STATUS
    /// The configuration settings of the secrets references of encryption key and signing key for ContainerApp Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public V20250101storageAuthConfigStatusEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// Storage version of v20250101.GlobalValidation_STATUS
    /// The configuration settings that determines the validation flow of users using ContainerApp Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("globalValidation")]
    public V20250101storageAuthConfigStatusGlobalValidation? GlobalValidation { get; set; }

    /// <summary>
    /// Storage version of v20250101.HttpSettings_STATUS
    /// The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp
    /// Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("httpSettings")]
    public V20250101storageAuthConfigStatusHttpSettings? HttpSettings { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20250101.IdentityProviders_STATUS
    /// The configuration settings of each of the identity providers used to configure ContainerApp Service
    /// Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("identityProviders")]
    public V20250101storageAuthConfigStatusIdentityProviders? IdentityProviders { get; set; }

    /// <summary>
    /// Storage version of v20250101.Login_STATUS
    /// The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("login")]
    public V20250101storageAuthConfigStatusLogin? Login { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20250101.AuthPlatform_STATUS
    /// The configuration settings of the platform of ContainerApp Service Authentication/Authorization.
    /// </summary>
    [JsonPropertyName("platform")]
    public V20250101storageAuthConfigStatusPlatform? Platform { get; set; }

    /// <summary>
    /// Storage version of v20250101.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20250101storageAuthConfigStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250101.AuthConfig
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2025-01-01/AuthConfigs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101storageAuthConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V20250101storageAuthConfigSpec?>, IStatus<V20250101storageAuthConfigStatus?>
{
    public const string KubeApiVersion = "v20250101storage";
    public const string KubeKind = "AuthConfig";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "authconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20250101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20250101.AuthConfig_Spec</summary>
    [JsonPropertyName("spec")]
    public V20250101storageAuthConfigSpec? Spec { get; set; }

    /// <summary>Storage version of v20250101.AuthConfig_STATUS</summary>
    [JsonPropertyName("status")]
    public V20250101storageAuthConfigStatus? Status { get; set; }
}