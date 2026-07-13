#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagentcore.aws.upbound.io;
/// <summary>Oauth2CredentialProvider is the Schema for the Oauth2CredentialProviders API. Manages an AWS Bedrock AgentCore OAuth2 Credential Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Oauth2CredentialProviderList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Oauth2CredentialProvider>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Oauth2CredentialProviderList";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "oauth2credentialproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Oauth2CredentialProviderList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Oauth2CredentialProvider objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Oauth2CredentialProvider> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecDeletionPolicyEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery? OauthDiscovery { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>GitHub OAuth provider configuration. See github below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Google OAuth provider configuration. See google below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Microsoft OAuth provider configuration. See microsoft below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Salesforce OAuth provider configuration. See salesforce below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Slack OAuth provider configuration. See slack below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfig
{
    /// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
    [JsonPropertyName("customOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfig? CustomOauth2ProviderConfig { get; set; }

    /// <summary>GitHub OAuth provider configuration. See github below.</summary>
    [JsonPropertyName("githubOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfig? GithubOauth2ProviderConfig { get; set; }

    /// <summary>Google OAuth provider configuration. See google below.</summary>
    [JsonPropertyName("googleOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfig? GoogleOauth2ProviderConfig { get; set; }

    /// <summary>Microsoft OAuth provider configuration. See microsoft below.</summary>
    [JsonPropertyName("microsoftOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig? MicrosoftOauth2ProviderConfig { get; set; }

    /// <summary>Salesforce OAuth provider configuration. See salesforce below.</summary>
    [JsonPropertyName("salesforceOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig? SalesforceOauth2ProviderConfig { get; set; }

    /// <summary>Slack OAuth provider configuration. See slack below.</summary>
    [JsonPropertyName("slackOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfig? SlackOauth2ProviderConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProvider
{
    /// <summary>Vendor of the OAuth2 credential provider. Valid values: CustomOauth2, GithubOauth2, GoogleOauth2, Microsoft, SalesforceOauth2, SlackOauth2.</summary>
    [JsonPropertyName("credentialProviderVendor")]
    public string? CredentialProviderVendor { get; set; }

    /// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
    [JsonPropertyName("oauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfig? Oauth2ProviderConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery? OauthDiscovery { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>GitHub OAuth provider configuration. See github below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Google OAuth provider configuration. See google below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Microsoft OAuth provider configuration. See microsoft below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Salesforce OAuth provider configuration. See salesforce below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdSecretRef
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

/// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdWoSecretRef
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

/// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretSecretRef
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

/// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretWoSecretRef
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

/// <summary>Slack OAuth provider configuration. See slack below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Cannot be used with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Cannot be used with client_id. Must be used together with client_secret_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>OAuth2 client secret. Cannot be used with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client secret. Cannot be used with client_secret. Must be used together with client_id_wo and client_credentials_wo_version.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfig
{
    /// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
    [JsonPropertyName("customOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfig? CustomOauth2ProviderConfig { get; set; }

    /// <summary>GitHub OAuth provider configuration. See github below.</summary>
    [JsonPropertyName("githubOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfig? GithubOauth2ProviderConfig { get; set; }

    /// <summary>Google OAuth provider configuration. See google below.</summary>
    [JsonPropertyName("googleOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfig? GoogleOauth2ProviderConfig { get; set; }

    /// <summary>Microsoft OAuth provider configuration. See microsoft below.</summary>
    [JsonPropertyName("microsoftOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig? MicrosoftOauth2ProviderConfig { get; set; }

    /// <summary>Salesforce OAuth provider configuration. See salesforce below.</summary>
    [JsonPropertyName("salesforceOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig? SalesforceOauth2ProviderConfig { get; set; }

    /// <summary>Slack OAuth provider configuration. See slack below.</summary>
    [JsonPropertyName("slackOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfig? SlackOauth2ProviderConfig { get; set; }
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
public partial class V1beta1Oauth2CredentialProviderSpecInitProvider
{
    /// <summary>Vendor of the OAuth2 credential provider. Valid values: CustomOauth2, GithubOauth2, GoogleOauth2, Microsoft, SalesforceOauth2, SlackOauth2.</summary>
    [JsonPropertyName("credentialProviderVendor")]
    public string? CredentialProviderVendor { get; set; }

    /// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
    [JsonPropertyName("oauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfig? Oauth2ProviderConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecManagementPoliciesEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Oauth2CredentialProviderSpec defines the desired state of Oauth2CredentialProvider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpec
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
    public V1beta1Oauth2CredentialProviderSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1Oauth2CredentialProviderSpecForProvider ForProvider { get; set; }

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
    public V1beta1Oauth2CredentialProviderSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1Oauth2CredentialProviderSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1Oauth2CredentialProviderSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1Oauth2CredentialProviderSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderClientSecretArn
{
    /// <summary>ARN of the secret in AWS Secrets Manager.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery? OauthDiscovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>GitHub OAuth provider configuration. See github below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Google OAuth provider configuration. See google below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Microsoft OAuth provider configuration. See microsoft below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Salesforce OAuth provider configuration. See salesforce below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Slack OAuth provider configuration. See slack below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfig
{
    /// <summary>Used together with write-only credentials to trigger an update. Increment this value when an update to client_id_wo or client_secret_wo is required.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

/// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfig
{
    /// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
    [JsonPropertyName("customOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfig? CustomOauth2ProviderConfig { get; set; }

    /// <summary>GitHub OAuth provider configuration. See github below.</summary>
    [JsonPropertyName("githubOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfig? GithubOauth2ProviderConfig { get; set; }

    /// <summary>Google OAuth provider configuration. See google below.</summary>
    [JsonPropertyName("googleOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfig? GoogleOauth2ProviderConfig { get; set; }

    /// <summary>Microsoft OAuth provider configuration. See microsoft below.</summary>
    [JsonPropertyName("microsoftOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig? MicrosoftOauth2ProviderConfig { get; set; }

    /// <summary>Salesforce OAuth provider configuration. See salesforce below.</summary>
    [JsonPropertyName("salesforceOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig? SalesforceOauth2ProviderConfig { get; set; }

    /// <summary>Slack OAuth provider configuration. See slack below.</summary>
    [JsonPropertyName("slackOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfig? SlackOauth2ProviderConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProvider
{
    /// <summary>ARN of the AWS Secrets Manager secret containing the client secret.</summary>
    [JsonPropertyName("clientSecretArn")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderClientSecretArn>? ClientSecretArn { get; set; }

    /// <summary>ARN of the OAuth2 credential provider.</summary>
    [JsonPropertyName("credentialProviderArn")]
    public string? CredentialProviderArn { get; set; }

    /// <summary>Vendor of the OAuth2 credential provider. Valid values: CustomOauth2, GithubOauth2, GoogleOauth2, Microsoft, SalesforceOauth2, SlackOauth2.</summary>
    [JsonPropertyName("credentialProviderVendor")]
    public string? CredentialProviderVendor { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the OAuth2 credential provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
    [JsonPropertyName("oauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfig? Oauth2ProviderConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusConditions
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

/// <summary>Oauth2CredentialProviderStatus defines the observed state of Oauth2CredentialProvider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1Oauth2CredentialProviderStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1Oauth2CredentialProviderStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Oauth2CredentialProvider is the Schema for the Oauth2CredentialProviders API. Manages an AWS Bedrock AgentCore OAuth2 Credential Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Oauth2CredentialProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1Oauth2CredentialProviderSpec>, IStatus<V1beta1Oauth2CredentialProviderStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Oauth2CredentialProvider";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "oauth2credentialproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Oauth2CredentialProvider";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Oauth2CredentialProviderSpec defines the desired state of Oauth2CredentialProvider</summary>
    [JsonPropertyName("spec")]
    public required V1beta1Oauth2CredentialProviderSpec Spec { get; set; }

    /// <summary>Oauth2CredentialProviderStatus defines the observed state of Oauth2CredentialProvider.</summary>
    [JsonPropertyName("status")]
    public V1beta1Oauth2CredentialProviderStatus? Status { get; set; }
}