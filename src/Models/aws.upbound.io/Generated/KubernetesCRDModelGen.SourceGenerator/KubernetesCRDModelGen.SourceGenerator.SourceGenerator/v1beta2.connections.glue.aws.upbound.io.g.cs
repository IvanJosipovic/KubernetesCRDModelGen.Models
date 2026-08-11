#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
/// <summary>Connection is the Schema for the Connections API. Manages an AWS Glue Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Connection>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ConnectionList";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "connections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Connection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Connection> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecDeletionPolicyEnum>))]
public enum V1beta2ConnectionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Map of key-value pairs used as connection properties specific to the Athena compute environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAthenaPropertiesSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Password for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationBasicAuthenticationCredentialsPasswordSecretRef
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

/// <summary>Basic authentication credentials. See basic_authentication_credentials below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationBasicAuthenticationCredentials
{
    /// <summary>Password for authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationBasicAuthenticationCredentialsPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Username for authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Map of custom authentication credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationCustomAuthenticationCredentialsSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Authorization code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodePropertiesAuthorizationCodeSecretRef
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

/// <summary>Authorization code properties. See authorization_code_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties
{
    /// <summary>Authorization code.</summary>
    [JsonPropertyName("authorizationCodeSecretRef")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodePropertiesAuthorizationCodeSecretRef? AuthorizationCodeSecretRef { get; set; }

    /// <summary>Redirect URI for OAuth2 flow.</summary>
    [JsonPropertyName("redirectUri")]
    public string? RedirectUri { get; set; }
}

/// <summary>OAuth2 client application details. See oauth2_client_application below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication
{
    /// <summary>Reference to an AWS-managed client application.</summary>
    [JsonPropertyName("awsManagedClientApplicationReference")]
    public string? AwsManagedClientApplicationReference { get; set; }

    /// <summary>Client ID for a user-managed client application.</summary>
    [JsonPropertyName("userManagedClientApplicationClientId")]
    public string? UserManagedClientApplicationClientId { get; set; }
}

/// <summary>OAuth2 access token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsAccessTokenSecretRef
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

/// <summary>JWT token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsJwtTokenSecretRef
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

/// <summary>OAuth2 refresh token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsRefreshTokenSecretRef
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

/// <summary>Client secret for user-managed client application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsUserManagedClientApplicationClientSecretSecretRef
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

/// <summary>OAuth2 credentials. See oauth2_credentials below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2Credentials
{
    /// <summary>OAuth2 access token.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>JWT token.</summary>
    [JsonPropertyName("jwtTokenSecretRef")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsJwtTokenSecretRef? JwtTokenSecretRef { get; set; }

    /// <summary>OAuth2 refresh token.</summary>
    [JsonPropertyName("refreshTokenSecretRef")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsRefreshTokenSecretRef? RefreshTokenSecretRef { get; set; }

    /// <summary>Client secret for user-managed client application.</summary>
    [JsonPropertyName("userManagedClientApplicationClientSecretSecretRef")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsUserManagedClientApplicationClientSecretSecretRef? UserManagedClientApplicationClientSecretSecretRef { get; set; }
}

/// <summary>Map of additional parameters for the token URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesTokenUrlParametersMapSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>OAuth2 properties. See oauth2_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2Properties
{
    /// <summary>Authorization code properties. See authorization_code_properties below.</summary>
    [JsonPropertyName("authorizationCodeProperties")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties? AuthorizationCodeProperties { get; set; }

    /// <summary>OAuth2 client application details. See oauth2_client_application below.</summary>
    [JsonPropertyName("oauth2ClientApplication")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication? Oauth2ClientApplication { get; set; }

    /// <summary>OAuth2 credentials. See oauth2_credentials below.</summary>
    [JsonPropertyName("oauth2Credentials")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesOauth2Credentials? Oauth2Credentials { get; set; }

    /// <summary>OAuth2 grant type. Valid values: AUTHORIZATION_CODE, CLIENT_CREDENTIALS, JWT_BEARER.</summary>
    [JsonPropertyName("oauth2GrantType")]
    public string? Oauth2GrantType { get; set; }

    /// <summary>Token URL for OAuth2 authentication.</summary>
    [JsonPropertyName("tokenUrl")]
    public string? TokenUrl { get; set; }

    /// <summary>Map of additional parameters for the token URL.</summary>
    [JsonPropertyName("tokenUrlParametersMapSecretRef")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2PropertiesTokenUrlParametersMapSecretRef? TokenUrlParametersMapSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelector
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
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for authentication options. See authentication_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAuthenticationConfiguration
{
    /// <summary>Type of authentication. Valid values: BASIC, CUSTOM, IAM, OAUTH2.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Basic authentication credentials. See basic_authentication_credentials below.</summary>
    [JsonPropertyName("basicAuthenticationCredentials")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationBasicAuthenticationCredentials? BasicAuthenticationCredentials { get; set; }

    /// <summary>Map of custom authentication credentials.</summary>
    [JsonPropertyName("customAuthenticationCredentialsSecretRef")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationCustomAuthenticationCredentialsSecretRef? CustomAuthenticationCredentialsSecretRef { get; set; }

    /// <summary>ARN of the KMS key used for encryption.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>OAuth2 properties. See oauth2_properties below.</summary>
    [JsonPropertyName("oauth2Properties")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationOauth2Properties? Oauth2Properties { get; set; }

    /// <summary>ARN of the Secrets Manager secret containing credentials.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnRef")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnRef? SecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnSelector")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfigurationSecretArnSelector? SecretArnSelector { get; set; }
}

/// <summary>Map of key-value pairs used as parameters for this connection. For more information, see the AWS Documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderConnectionPropertiesSecretRef
{
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate availabilityZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate availabilityZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelector
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
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIdList.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelector
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
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelector
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
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Map of physical connection requirements, such as VPC and SecurityGroup. See physical_connection_requirements below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderPhysicalConnectionRequirements
{
    /// <summary>Availability zone of the connection. This field is redundant and implied by subnet_id, but is currently an API requirement.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate availabilityZone.</summary>
    [JsonPropertyName("availabilityZoneRef")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneRef? AvailabilityZoneRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate availabilityZone.</summary>
    [JsonPropertyName("availabilityZoneSelector")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsAvailabilityZoneSelector? AvailabilityZoneSelector { get; set; }

    /// <summary>Security group ID list used by the connection.</summary>
    [JsonPropertyName("securityGroupIdList")]
    public IList<string>? SecurityGroupIdList { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIdList.</summary>
    [JsonPropertyName("securityGroupIdListRefs")]
    public IList<V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListRefs>? SecurityGroupIdListRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIdList.</summary>
    [JsonPropertyName("securityGroupIdListSelector")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSecurityGroupIdListSelector? SecurityGroupIdListSelector { get; set; }

    /// <summary>Subnet ID used by the connection.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirementsSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProvider
{
    /// <summary>Map of key-value pairs used as connection properties specific to the Athena compute environment.</summary>
    [JsonPropertyName("athenaPropertiesSecretRef")]
    public V1beta2ConnectionSpecForProviderAthenaPropertiesSecretRef? AthenaPropertiesSecretRef { get; set; }

    /// <summary>Configuration block for authentication options. See authentication_configuration below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta2ConnectionSpecForProviderAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>ID of the Data Catalog in which to create the connection. If none is supplied, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public required string CatalogId { get; set; }

    /// <summary>Map of key-value pairs used as parameters for this connection. For more information, see the AWS Documentation.</summary>
    [JsonPropertyName("connectionPropertiesSecretRef")]
    public V1beta2ConnectionSpecForProviderConnectionPropertiesSecretRef? ConnectionPropertiesSecretRef { get; set; }

    /// <summary>Type of the connection. Valid values: AZURECOSMOS, AZURESQL, BIGQUERY, CUSTOM, DYNAMODB, JDBC, KAFKA, MARKETPLACE, MONGODB, NETWORK, OPENSEARCH, SNOWFLAKE. Defaults to JDBC. Some connection types require the SparkProperties property with a JSON document that contains the actual connection properties. For specific examples, refer to Example Usage.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>Description of the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of criteria that can be used in selecting this connection.</summary>
    [JsonPropertyName("matchCriteria")]
    public IList<string>? MatchCriteria { get; set; }

    /// <summary>Map of physical connection requirements, such as VPC and SecurityGroup. See physical_connection_requirements below.</summary>
    [JsonPropertyName("physicalConnectionRequirements")]
    public V1beta2ConnectionSpecForProviderPhysicalConnectionRequirements? PhysicalConnectionRequirements { get; set; }

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

/// <summary>Password for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationBasicAuthenticationCredentialsPasswordSecretRef
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

/// <summary>Basic authentication credentials. See basic_authentication_credentials below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationBasicAuthenticationCredentials
{
    /// <summary>Password for authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2ConnectionSpecInitProviderAuthenticationConfigurationBasicAuthenticationCredentialsPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Username for authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Authorization code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodePropertiesAuthorizationCodeSecretRef
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

/// <summary>Authorization code properties. See authorization_code_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties
{
    /// <summary>Authorization code.</summary>
    [JsonPropertyName("authorizationCodeSecretRef")]
    public required V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodePropertiesAuthorizationCodeSecretRef AuthorizationCodeSecretRef { get; set; }

    /// <summary>Redirect URI for OAuth2 flow.</summary>
    [JsonPropertyName("redirectUri")]
    public string? RedirectUri { get; set; }
}

/// <summary>OAuth2 client application details. See oauth2_client_application below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication
{
    /// <summary>Reference to an AWS-managed client application.</summary>
    [JsonPropertyName("awsManagedClientApplicationReference")]
    public string? AwsManagedClientApplicationReference { get; set; }

    /// <summary>Client ID for a user-managed client application.</summary>
    [JsonPropertyName("userManagedClientApplicationClientId")]
    public string? UserManagedClientApplicationClientId { get; set; }
}

/// <summary>OAuth2 access token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsAccessTokenSecretRef
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

/// <summary>JWT token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsJwtTokenSecretRef
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

/// <summary>OAuth2 refresh token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsRefreshTokenSecretRef
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

/// <summary>Client secret for user-managed client application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsUserManagedClientApplicationClientSecretSecretRef
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

/// <summary>OAuth2 credentials. See oauth2_credentials below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2Credentials
{
    /// <summary>OAuth2 access token.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>JWT token.</summary>
    [JsonPropertyName("jwtTokenSecretRef")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsJwtTokenSecretRef? JwtTokenSecretRef { get; set; }

    /// <summary>OAuth2 refresh token.</summary>
    [JsonPropertyName("refreshTokenSecretRef")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsRefreshTokenSecretRef? RefreshTokenSecretRef { get; set; }

    /// <summary>Client secret for user-managed client application.</summary>
    [JsonPropertyName("userManagedClientApplicationClientSecretSecretRef")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsUserManagedClientApplicationClientSecretSecretRef? UserManagedClientApplicationClientSecretSecretRef { get; set; }
}

/// <summary>OAuth2 properties. See oauth2_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2Properties
{
    /// <summary>Authorization code properties. See authorization_code_properties below.</summary>
    [JsonPropertyName("authorizationCodeProperties")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties? AuthorizationCodeProperties { get; set; }

    /// <summary>OAuth2 client application details. See oauth2_client_application below.</summary>
    [JsonPropertyName("oauth2ClientApplication")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication? Oauth2ClientApplication { get; set; }

    /// <summary>OAuth2 credentials. See oauth2_credentials below.</summary>
    [JsonPropertyName("oauth2Credentials")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2PropertiesOauth2Credentials? Oauth2Credentials { get; set; }

    /// <summary>OAuth2 grant type. Valid values: AUTHORIZATION_CODE, CLIENT_CREDENTIALS, JWT_BEARER.</summary>
    [JsonPropertyName("oauth2GrantType")]
    public string? Oauth2GrantType { get; set; }

    /// <summary>Token URL for OAuth2 authentication.</summary>
    [JsonPropertyName("tokenUrl")]
    public string? TokenUrl { get; set; }

    [JsonPropertyName("tokenUrlParametersMapSecretRef")]
    public IDictionary<string, string>? TokenUrlParametersMapSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelector
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
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for authentication options. See authentication_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAuthenticationConfiguration
{
    /// <summary>Type of authentication. Valid values: BASIC, CUSTOM, IAM, OAUTH2.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Basic authentication credentials. See basic_authentication_credentials below.</summary>
    [JsonPropertyName("basicAuthenticationCredentials")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationBasicAuthenticationCredentials? BasicAuthenticationCredentials { get; set; }

    [JsonPropertyName("customAuthenticationCredentialsSecretRef")]
    public IDictionary<string, string>? CustomAuthenticationCredentialsSecretRef { get; set; }

    /// <summary>ARN of the KMS key used for encryption.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>OAuth2 properties. See oauth2_properties below.</summary>
    [JsonPropertyName("oauth2Properties")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationOauth2Properties? Oauth2Properties { get; set; }

    /// <summary>ARN of the Secrets Manager secret containing credentials.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnRef")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnRef? SecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretArn.</summary>
    [JsonPropertyName("secretArnSelector")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfigurationSecretArnSelector? SecretArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate availabilityZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate availabilityZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelector
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
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIdList.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelector
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
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelector
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
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Map of physical connection requirements, such as VPC and SecurityGroup. See physical_connection_requirements below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirements
{
    /// <summary>Availability zone of the connection. This field is redundant and implied by subnet_id, but is currently an API requirement.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate availabilityZone.</summary>
    [JsonPropertyName("availabilityZoneRef")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneRef? AvailabilityZoneRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate availabilityZone.</summary>
    [JsonPropertyName("availabilityZoneSelector")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsAvailabilityZoneSelector? AvailabilityZoneSelector { get; set; }

    /// <summary>Security group ID list used by the connection.</summary>
    [JsonPropertyName("securityGroupIdList")]
    public IList<string>? SecurityGroupIdList { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIdList.</summary>
    [JsonPropertyName("securityGroupIdListRefs")]
    public IList<V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListRefs>? SecurityGroupIdListRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIdList.</summary>
    [JsonPropertyName("securityGroupIdListSelector")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSecurityGroupIdListSelector? SecurityGroupIdListSelector { get; set; }

    /// <summary>Subnet ID used by the connection.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirementsSubnetIdSelector? SubnetIdSelector { get; set; }
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
public partial class V1beta2ConnectionSpecInitProvider
{
    [JsonPropertyName("athenaPropertiesSecretRef")]
    public IDictionary<string, string>? AthenaPropertiesSecretRef { get; set; }

    /// <summary>Configuration block for authentication options. See authentication_configuration below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta2ConnectionSpecInitProviderAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    [JsonPropertyName("connectionPropertiesSecretRef")]
    public IDictionary<string, string>? ConnectionPropertiesSecretRef { get; set; }

    /// <summary>Type of the connection. Valid values: AZURECOSMOS, AZURESQL, BIGQUERY, CUSTOM, DYNAMODB, JDBC, KAFKA, MARKETPLACE, MONGODB, NETWORK, OPENSEARCH, SNOWFLAKE. Defaults to JDBC. Some connection types require the SparkProperties property with a JSON document that contains the actual connection properties. For specific examples, refer to Example Usage.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>Description of the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of criteria that can be used in selecting this connection.</summary>
    [JsonPropertyName("matchCriteria")]
    public IList<string>? MatchCriteria { get; set; }

    /// <summary>Map of physical connection requirements, such as VPC and SecurityGroup. See physical_connection_requirements below.</summary>
    [JsonPropertyName("physicalConnectionRequirements")]
    public V1beta2ConnectionSpecInitProviderPhysicalConnectionRequirements? PhysicalConnectionRequirements { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecManagementPoliciesEnum>))]
public enum V1beta2ConnectionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ConnectionSpec defines the desired state of Connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpec
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
    public V1beta2ConnectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ConnectionSpecForProvider ForProvider { get; set; }

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
    public V1beta2ConnectionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ConnectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Basic authentication credentials. See basic_authentication_credentials below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfigurationBasicAuthenticationCredentials
{
    /// <summary>Username for authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Authorization code properties. See authorization_code_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties
{
    /// <summary>Redirect URI for OAuth2 flow.</summary>
    [JsonPropertyName("redirectUri")]
    public string? RedirectUri { get; set; }
}

/// <summary>OAuth2 client application details. See oauth2_client_application below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication
{
    /// <summary>Reference to an AWS-managed client application.</summary>
    [JsonPropertyName("awsManagedClientApplicationReference")]
    public string? AwsManagedClientApplicationReference { get; set; }

    /// <summary>Client ID for a user-managed client application.</summary>
    [JsonPropertyName("userManagedClientApplicationClientId")]
    public string? UserManagedClientApplicationClientId { get; set; }
}

/// <summary>OAuth2 access token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsAccessTokenSecretRef
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

/// <summary>JWT token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsJwtTokenSecretRef
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

/// <summary>OAuth2 refresh token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsRefreshTokenSecretRef
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

/// <summary>Client secret for user-managed client application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsUserManagedClientApplicationClientSecretSecretRef
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

/// <summary>OAuth2 credentials. See oauth2_credentials below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2Credentials
{
    /// <summary>OAuth2 access token.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>JWT token.</summary>
    [JsonPropertyName("jwtTokenSecretRef")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsJwtTokenSecretRef? JwtTokenSecretRef { get; set; }

    /// <summary>OAuth2 refresh token.</summary>
    [JsonPropertyName("refreshTokenSecretRef")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsRefreshTokenSecretRef? RefreshTokenSecretRef { get; set; }

    /// <summary>Client secret for user-managed client application.</summary>
    [JsonPropertyName("userManagedClientApplicationClientSecretSecretRef")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2CredentialsUserManagedClientApplicationClientSecretSecretRef? UserManagedClientApplicationClientSecretSecretRef { get; set; }
}

/// <summary>OAuth2 properties. See oauth2_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2Properties
{
    /// <summary>Authorization code properties. See authorization_code_properties below.</summary>
    [JsonPropertyName("authorizationCodeProperties")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties? AuthorizationCodeProperties { get; set; }

    /// <summary>OAuth2 client application details. See oauth2_client_application below.</summary>
    [JsonPropertyName("oauth2ClientApplication")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication? Oauth2ClientApplication { get; set; }

    /// <summary>OAuth2 credentials. See oauth2_credentials below.</summary>
    [JsonPropertyName("oauth2Credentials")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2PropertiesOauth2Credentials? Oauth2Credentials { get; set; }

    /// <summary>OAuth2 grant type. Valid values: AUTHORIZATION_CODE, CLIENT_CREDENTIALS, JWT_BEARER.</summary>
    [JsonPropertyName("oauth2GrantType")]
    public string? Oauth2GrantType { get; set; }

    /// <summary>Token URL for OAuth2 authentication.</summary>
    [JsonPropertyName("tokenUrl")]
    public string? TokenUrl { get; set; }
}

/// <summary>Configuration block for authentication options. See authentication_configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAuthenticationConfiguration
{
    /// <summary>Type of authentication. Valid values: BASIC, CUSTOM, IAM, OAUTH2.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Basic authentication credentials. See basic_authentication_credentials below.</summary>
    [JsonPropertyName("basicAuthenticationCredentials")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfigurationBasicAuthenticationCredentials? BasicAuthenticationCredentials { get; set; }

    /// <summary>ARN of the KMS key used for encryption.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>OAuth2 properties. See oauth2_properties below.</summary>
    [JsonPropertyName("oauth2Properties")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfigurationOauth2Properties? Oauth2Properties { get; set; }

    /// <summary>ARN of the Secrets Manager secret containing credentials.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Map of physical connection requirements, such as VPC and SecurityGroup. See physical_connection_requirements below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderPhysicalConnectionRequirements
{
    /// <summary>Availability zone of the connection. This field is redundant and implied by subnet_id, but is currently an API requirement.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Security group ID list used by the connection.</summary>
    [JsonPropertyName("securityGroupIdList")]
    public IList<string>? SecurityGroupIdList { get; set; }

    /// <summary>Subnet ID used by the connection.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProvider
{
    /// <summary>ARN of the Glue Connection.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block for authentication options. See authentication_configuration below.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta2ConnectionStatusAtProviderAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>ID of the Data Catalog in which to create the connection. If none is supplied, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Type of the connection. Valid values: AZURECOSMOS, AZURESQL, BIGQUERY, CUSTOM, DYNAMODB, JDBC, KAFKA, MARKETPLACE, MONGODB, NETWORK, OPENSEARCH, SNOWFLAKE. Defaults to JDBC. Some connection types require the SparkProperties property with a JSON document that contains the actual connection properties. For specific examples, refer to Example Usage.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>Description of the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Catalog ID and name of the connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of criteria that can be used in selecting this connection.</summary>
    [JsonPropertyName("matchCriteria")]
    public IList<string>? MatchCriteria { get; set; }

    /// <summary>Map of physical connection requirements, such as VPC and SecurityGroup. See physical_connection_requirements below.</summary>
    [JsonPropertyName("physicalConnectionRequirements")]
    public V1beta2ConnectionStatusAtProviderPhysicalConnectionRequirements? PhysicalConnectionRequirements { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusConditions
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

/// <summary>ConnectionStatus defines the observed state of Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Connection is the Schema for the Connections API. Manages an AWS Glue Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Connection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ConnectionSpec>, IStatus<V1beta2ConnectionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Connection";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "connections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Connection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectionSpec defines the desired state of Connection</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ConnectionSpec Spec { get; set; }

    /// <summary>ConnectionStatus defines the observed state of Connection.</summary>
    [JsonPropertyName("status")]
    public V1beta2ConnectionStatus? Status { get; set; }
}