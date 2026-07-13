#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflowcx.gcp.m.upbound.io;
/// <summary>Webhook is the Schema for the Webhooks API. Webhooks host the developer&apos;s business logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebhookList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Webhook>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebhookList";
    public const string KubeGroup = "dialogflowcx.gcp.m.upbound.io";
    public const string KubePluralName = "webhooks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflowcx.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebhookList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Webhook objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Webhook> Items { get; set; }
}

/// <summary>
/// Represents configuration of OAuth client credential flow for 3rd party
/// API authentication.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderGenericWebServiceOauthConfig
{
    /// <summary>The client ID provided by the 3rd party platform.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The client secret provided by the 3rd party platform.  If the
    /// secret_version_for_client_secret field is set, this field will be
    /// ignored.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The OAuth scopes to grant.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the
    /// client secret. If this field is set, the client_secret field will be
    /// ignored.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForClientSecret")]
    public string? SecretVersionForClientSecret { get; set; }

    /// <summary>
    /// The token endpoint provided by the 3rd party platform to exchange an
    /// access token.
    /// </summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderGenericWebServiceSecretVersionsForRequestHeaders
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the header value.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>
/// Represents configuration for a generic web service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderGenericWebService
{
    /// <summary>
    /// Specifies a list of allowed custom CA certificates (in DER format) for
    /// HTTPS verification. This overrides the default SSL trust store. If this
    /// is empty or unspecified, Dialogflow will use Google&apos;s default trust store
    /// to verify certificates.
    /// N.B. Make sure the HTTPS server certificates are signed with &quot;subject alt
    /// name&quot;. For instance a certificate can be self-signed using the following
    /// command,
    /// openssl x509 -req -days 200 -in example.com.csr
    /// -signkey example.com.key
    /// -out example.com.crt
    /// -extfile &lt;(printf &quot;\nsubjectAltName=&apos;DNS:www.example.com&apos; &quot;)
    /// </summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST.
    /// Possible values are: POST, GET, HEAD, PUT, DELETE, PATCH, OPTIONS.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// Represents configuration of OAuth client credential flow for 3rd party
    /// API authentication.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthConfig")]
    public V1beta1WebhookSpecForProviderGenericWebServiceOauthConfig? OauthConfig { get; set; }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// </summary>
    [JsonPropertyName("parameterMapping")]
    public IDictionary<string, string>? ParameterMapping { get; set; }

    /// <summary>Defines a custom JSON object as request body to send to flexible webhook.</summary>
    [JsonPropertyName("requestBody")]
    public string? RequestBody { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForUsernamePassword")]
    public string? SecretVersionForUsernamePassword { get; set; }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests. Header
    /// values are stored in SecretManager secret versions.
    /// When the same header name is specified in both request_headers and
    /// secret_versions_for_request_headers, the value in
    /// secret_versions_for_request_headers will be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretVersionsForRequestHeaders")]
    public IList<V1beta1WebhookSpecForProviderGenericWebServiceSecretVersionsForRequestHeaders>? SecretVersionsForRequestHeaders { get; set; }

    /// <summary>
    /// Indicate the auth token type generated from the Diglogflow service
    /// agent.
    /// The generated token is sent in the Authorization header.
    /// Possible values are: NONE, ID_TOKEN, ACCESS_TOKEN.
    /// </summary>
    [JsonPropertyName("serviceAgentAuth")]
    public string? ServiceAgentAuth { get; set; }

    /// <summary>The webhook URI for receiving POST requests. It must use https protocol.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>
    /// Type of the webhook.
    /// Possible values are: STANDARD, FLEXIBLE.
    /// </summary>
    [JsonPropertyName("webhookType")]
    public string? WebhookType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecForProviderParentRefPolicyResolutionEnum>))]
public enum V1beta1WebhookSpecForProviderParentRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecForProviderParentRefPolicyResolveEnum>))]
public enum V1beta1WebhookSpecForProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebhookSpecForProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebhookSpecForProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecForProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecForProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta1WebhookSpecForProviderParentSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecForProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta1WebhookSpecForProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebhookSpecForProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebhookSpecForProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderParentSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecForProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Represents configuration of OAuth client credential flow for 3rd party
/// API authentication.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderServiceDirectoryGenericWebServiceOauthConfig
{
    /// <summary>The client ID provided by the 3rd party platform.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The client secret provided by the 3rd party platform.  If the
    /// secret_version_for_client_secret field is set, this field will be
    /// ignored.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The OAuth scopes to grant.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the
    /// client secret. If this field is set, the client_secret field will be
    /// ignored.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForClientSecret")]
    public string? SecretVersionForClientSecret { get; set; }

    /// <summary>
    /// The token endpoint provided by the 3rd party platform to exchange an
    /// access token.
    /// </summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderServiceDirectoryGenericWebServiceSecretVersionsForRequestHeaders
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the header value.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>
/// Represents configuration for a generic web service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderServiceDirectoryGenericWebService
{
    /// <summary>
    /// Specifies a list of allowed custom CA certificates (in DER format) for
    /// HTTPS verification. This overrides the default SSL trust store. If this
    /// is empty or unspecified, Dialogflow will use Google&apos;s default trust store
    /// to verify certificates.
    /// N.B. Make sure the HTTPS server certificates are signed with &quot;subject alt
    /// name&quot;. For instance a certificate can be self-signed using the following
    /// command,
    /// openssl x509 -req -days 200 -in example.com.csr
    /// -signkey example.com.key
    /// -out example.com.crt
    /// -extfile &lt;(printf &quot;\nsubjectAltName=&apos;DNS:www.example.com&apos; &quot;)
    /// </summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST.
    /// Possible values are: POST, GET, HEAD, PUT, DELETE, PATCH, OPTIONS.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// Represents configuration of OAuth client credential flow for 3rd party
    /// API authentication.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthConfig")]
    public V1beta1WebhookSpecForProviderServiceDirectoryGenericWebServiceOauthConfig? OauthConfig { get; set; }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// </summary>
    [JsonPropertyName("parameterMapping")]
    public IDictionary<string, string>? ParameterMapping { get; set; }

    /// <summary>Defines a custom JSON object as request body to send to flexible webhook.</summary>
    [JsonPropertyName("requestBody")]
    public string? RequestBody { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForUsernamePassword")]
    public string? SecretVersionForUsernamePassword { get; set; }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests. Header
    /// values are stored in SecretManager secret versions.
    /// When the same header name is specified in both request_headers and
    /// secret_versions_for_request_headers, the value in
    /// secret_versions_for_request_headers will be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretVersionsForRequestHeaders")]
    public IList<V1beta1WebhookSpecForProviderServiceDirectoryGenericWebServiceSecretVersionsForRequestHeaders>? SecretVersionsForRequestHeaders { get; set; }

    /// <summary>
    /// Indicate the auth token type generated from the Diglogflow service
    /// agent.
    /// The generated token is sent in the Authorization header.
    /// Possible values are: NONE, ID_TOKEN, ACCESS_TOKEN.
    /// </summary>
    [JsonPropertyName("serviceAgentAuth")]
    public string? ServiceAgentAuth { get; set; }

    /// <summary>The webhook URI for receiving POST requests. It must use https protocol.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>
    /// Type of the webhook.
    /// Possible values are: STANDARD, FLEXIBLE.
    /// </summary>
    [JsonPropertyName("webhookType")]
    public string? WebhookType { get; set; }
}

/// <summary>
/// Configuration for a Service Directory service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProviderServiceDirectory
{
    /// <summary>
    /// Represents configuration for a generic web service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("genericWebService")]
    public V1beta1WebhookSpecForProviderServiceDirectoryGenericWebService? GenericWebService { get; set; }

    /// <summary>The name of Service Directory service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecForProvider
{
    /// <summary>Indicates whether the webhook is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The human-readable name of the webhook, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Deprecated. Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Deprecated. Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// Represents configuration for a generic web service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("genericWebService")]
    public V1beta1WebhookSpecForProviderGenericWebService? GenericWebService { get; set; }

    /// <summary>
    /// The agent to create a webhook for.
    /// Format: projects//locations//agents/.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1WebhookSpecForProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1WebhookSpecForProviderParentSelector? ParentSelector { get; set; }

    /// <summary>Deprecated. Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>
    /// Configuration for a Service Directory service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectory")]
    public V1beta1WebhookSpecForProviderServiceDirectory? ServiceDirectory { get; set; }

    /// <summary>Webhook execution timeout.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>
/// Represents configuration of OAuth client credential flow for 3rd party
/// API authentication.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderGenericWebServiceOauthConfig
{
    /// <summary>The client ID provided by the 3rd party platform.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The client secret provided by the 3rd party platform.  If the
    /// secret_version_for_client_secret field is set, this field will be
    /// ignored.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The OAuth scopes to grant.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the
    /// client secret. If this field is set, the client_secret field will be
    /// ignored.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForClientSecret")]
    public string? SecretVersionForClientSecret { get; set; }

    /// <summary>
    /// The token endpoint provided by the 3rd party platform to exchange an
    /// access token.
    /// </summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderGenericWebServiceSecretVersionsForRequestHeaders
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the header value.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>
/// Represents configuration for a generic web service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderGenericWebService
{
    /// <summary>
    /// Specifies a list of allowed custom CA certificates (in DER format) for
    /// HTTPS verification. This overrides the default SSL trust store. If this
    /// is empty or unspecified, Dialogflow will use Google&apos;s default trust store
    /// to verify certificates.
    /// N.B. Make sure the HTTPS server certificates are signed with &quot;subject alt
    /// name&quot;. For instance a certificate can be self-signed using the following
    /// command,
    /// openssl x509 -req -days 200 -in example.com.csr
    /// -signkey example.com.key
    /// -out example.com.crt
    /// -extfile &lt;(printf &quot;\nsubjectAltName=&apos;DNS:www.example.com&apos; &quot;)
    /// </summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST.
    /// Possible values are: POST, GET, HEAD, PUT, DELETE, PATCH, OPTIONS.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// Represents configuration of OAuth client credential flow for 3rd party
    /// API authentication.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthConfig")]
    public V1beta1WebhookSpecInitProviderGenericWebServiceOauthConfig? OauthConfig { get; set; }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// </summary>
    [JsonPropertyName("parameterMapping")]
    public IDictionary<string, string>? ParameterMapping { get; set; }

    /// <summary>Defines a custom JSON object as request body to send to flexible webhook.</summary>
    [JsonPropertyName("requestBody")]
    public string? RequestBody { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForUsernamePassword")]
    public string? SecretVersionForUsernamePassword { get; set; }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests. Header
    /// values are stored in SecretManager secret versions.
    /// When the same header name is specified in both request_headers and
    /// secret_versions_for_request_headers, the value in
    /// secret_versions_for_request_headers will be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretVersionsForRequestHeaders")]
    public IList<V1beta1WebhookSpecInitProviderGenericWebServiceSecretVersionsForRequestHeaders>? SecretVersionsForRequestHeaders { get; set; }

    /// <summary>
    /// Indicate the auth token type generated from the Diglogflow service
    /// agent.
    /// The generated token is sent in the Authorization header.
    /// Possible values are: NONE, ID_TOKEN, ACCESS_TOKEN.
    /// </summary>
    [JsonPropertyName("serviceAgentAuth")]
    public string? ServiceAgentAuth { get; set; }

    /// <summary>The webhook URI for receiving POST requests. It must use https protocol.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>
    /// Type of the webhook.
    /// Possible values are: STANDARD, FLEXIBLE.
    /// </summary>
    [JsonPropertyName("webhookType")]
    public string? WebhookType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecInitProviderParentRefPolicyResolutionEnum>))]
public enum V1beta1WebhookSpecInitProviderParentRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecInitProviderParentRefPolicyResolveEnum>))]
public enum V1beta1WebhookSpecInitProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebhookSpecInitProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebhookSpecInitProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecInitProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecInitProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta1WebhookSpecInitProviderParentSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecInitProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta1WebhookSpecInitProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebhookSpecInitProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebhookSpecInitProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderParentSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebhookSpecInitProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Represents configuration of OAuth client credential flow for 3rd party
/// API authentication.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderServiceDirectoryGenericWebServiceOauthConfig
{
    /// <summary>The client ID provided by the 3rd party platform.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The client secret provided by the 3rd party platform.  If the
    /// secret_version_for_client_secret field is set, this field will be
    /// ignored.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The OAuth scopes to grant.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the
    /// client secret. If this field is set, the client_secret field will be
    /// ignored.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForClientSecret")]
    public string? SecretVersionForClientSecret { get; set; }

    /// <summary>
    /// The token endpoint provided by the 3rd party platform to exchange an
    /// access token.
    /// </summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderServiceDirectoryGenericWebServiceSecretVersionsForRequestHeaders
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the header value.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>
/// Represents configuration for a generic web service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderServiceDirectoryGenericWebService
{
    /// <summary>
    /// Specifies a list of allowed custom CA certificates (in DER format) for
    /// HTTPS verification. This overrides the default SSL trust store. If this
    /// is empty or unspecified, Dialogflow will use Google&apos;s default trust store
    /// to verify certificates.
    /// N.B. Make sure the HTTPS server certificates are signed with &quot;subject alt
    /// name&quot;. For instance a certificate can be self-signed using the following
    /// command,
    /// openssl x509 -req -days 200 -in example.com.csr
    /// -signkey example.com.key
    /// -out example.com.crt
    /// -extfile &lt;(printf &quot;\nsubjectAltName=&apos;DNS:www.example.com&apos; &quot;)
    /// </summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST.
    /// Possible values are: POST, GET, HEAD, PUT, DELETE, PATCH, OPTIONS.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// Represents configuration of OAuth client credential flow for 3rd party
    /// API authentication.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthConfig")]
    public V1beta1WebhookSpecInitProviderServiceDirectoryGenericWebServiceOauthConfig? OauthConfig { get; set; }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// </summary>
    [JsonPropertyName("parameterMapping")]
    public IDictionary<string, string>? ParameterMapping { get; set; }

    /// <summary>Defines a custom JSON object as request body to send to flexible webhook.</summary>
    [JsonPropertyName("requestBody")]
    public string? RequestBody { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForUsernamePassword")]
    public string? SecretVersionForUsernamePassword { get; set; }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests. Header
    /// values are stored in SecretManager secret versions.
    /// When the same header name is specified in both request_headers and
    /// secret_versions_for_request_headers, the value in
    /// secret_versions_for_request_headers will be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretVersionsForRequestHeaders")]
    public IList<V1beta1WebhookSpecInitProviderServiceDirectoryGenericWebServiceSecretVersionsForRequestHeaders>? SecretVersionsForRequestHeaders { get; set; }

    /// <summary>
    /// Indicate the auth token type generated from the Diglogflow service
    /// agent.
    /// The generated token is sent in the Authorization header.
    /// Possible values are: NONE, ID_TOKEN, ACCESS_TOKEN.
    /// </summary>
    [JsonPropertyName("serviceAgentAuth")]
    public string? ServiceAgentAuth { get; set; }

    /// <summary>The webhook URI for receiving POST requests. It must use https protocol.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>
    /// Type of the webhook.
    /// Possible values are: STANDARD, FLEXIBLE.
    /// </summary>
    [JsonPropertyName("webhookType")]
    public string? WebhookType { get; set; }
}

/// <summary>
/// Configuration for a Service Directory service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecInitProviderServiceDirectory
{
    /// <summary>
    /// Represents configuration for a generic web service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("genericWebService")]
    public V1beta1WebhookSpecInitProviderServiceDirectoryGenericWebService? GenericWebService { get; set; }

    /// <summary>The name of Service Directory service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
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
public partial class V1beta1WebhookSpecInitProvider
{
    /// <summary>Indicates whether the webhook is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The human-readable name of the webhook, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Deprecated. Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Deprecated. Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// Represents configuration for a generic web service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("genericWebService")]
    public V1beta1WebhookSpecInitProviderGenericWebService? GenericWebService { get; set; }

    /// <summary>
    /// The agent to create a webhook for.
    /// Format: projects//locations//agents/.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1WebhookSpecInitProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1WebhookSpecInitProviderParentSelector? ParentSelector { get; set; }

    /// <summary>Deprecated. Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>
    /// Configuration for a Service Directory service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectory")]
    public V1beta1WebhookSpecInitProviderServiceDirectory? ServiceDirectory { get; set; }

    /// <summary>Webhook execution timeout.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebhookSpecManagementPoliciesEnum>))]
public enum V1beta1WebhookSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WebhookSpec defines the desired state of Webhook</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1WebhookSpecForProvider ForProvider { get; set; }

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
    public V1beta1WebhookSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WebhookSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebhookSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebhookSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Represents configuration of OAuth client credential flow for 3rd party
/// API authentication.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderGenericWebServiceOauthConfig
{
    /// <summary>The client ID provided by the 3rd party platform.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The client secret provided by the 3rd party platform.  If the
    /// secret_version_for_client_secret field is set, this field will be
    /// ignored.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The OAuth scopes to grant.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the
    /// client secret. If this field is set, the client_secret field will be
    /// ignored.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForClientSecret")]
    public string? SecretVersionForClientSecret { get; set; }

    /// <summary>
    /// The token endpoint provided by the 3rd party platform to exchange an
    /// access token.
    /// </summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderGenericWebServiceSecretVersionsForRequestHeaders
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the header value.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>
/// Represents configuration for a generic web service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderGenericWebService
{
    /// <summary>
    /// Specifies a list of allowed custom CA certificates (in DER format) for
    /// HTTPS verification. This overrides the default SSL trust store. If this
    /// is empty or unspecified, Dialogflow will use Google&apos;s default trust store
    /// to verify certificates.
    /// N.B. Make sure the HTTPS server certificates are signed with &quot;subject alt
    /// name&quot;. For instance a certificate can be self-signed using the following
    /// command,
    /// openssl x509 -req -days 200 -in example.com.csr
    /// -signkey example.com.key
    /// -out example.com.crt
    /// -extfile &lt;(printf &quot;\nsubjectAltName=&apos;DNS:www.example.com&apos; &quot;)
    /// </summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST.
    /// Possible values are: POST, GET, HEAD, PUT, DELETE, PATCH, OPTIONS.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// Represents configuration of OAuth client credential flow for 3rd party
    /// API authentication.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthConfig")]
    public V1beta1WebhookStatusAtProviderGenericWebServiceOauthConfig? OauthConfig { get; set; }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// </summary>
    [JsonPropertyName("parameterMapping")]
    public IDictionary<string, string>? ParameterMapping { get; set; }

    /// <summary>Defines a custom JSON object as request body to send to flexible webhook.</summary>
    [JsonPropertyName("requestBody")]
    public string? RequestBody { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForUsernamePassword")]
    public string? SecretVersionForUsernamePassword { get; set; }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests. Header
    /// values are stored in SecretManager secret versions.
    /// When the same header name is specified in both request_headers and
    /// secret_versions_for_request_headers, the value in
    /// secret_versions_for_request_headers will be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretVersionsForRequestHeaders")]
    public IList<V1beta1WebhookStatusAtProviderGenericWebServiceSecretVersionsForRequestHeaders>? SecretVersionsForRequestHeaders { get; set; }

    /// <summary>
    /// Indicate the auth token type generated from the Diglogflow service
    /// agent.
    /// The generated token is sent in the Authorization header.
    /// Possible values are: NONE, ID_TOKEN, ACCESS_TOKEN.
    /// </summary>
    [JsonPropertyName("serviceAgentAuth")]
    public string? ServiceAgentAuth { get; set; }

    /// <summary>The webhook URI for receiving POST requests. It must use https protocol.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>
    /// Type of the webhook.
    /// Possible values are: STANDARD, FLEXIBLE.
    /// </summary>
    [JsonPropertyName("webhookType")]
    public string? WebhookType { get; set; }
}

/// <summary>
/// Represents configuration of OAuth client credential flow for 3rd party
/// API authentication.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderServiceDirectoryGenericWebServiceOauthConfig
{
    /// <summary>The client ID provided by the 3rd party platform.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>
    /// The client secret provided by the 3rd party platform.  If the
    /// secret_version_for_client_secret field is set, this field will be
    /// ignored.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The OAuth scopes to grant.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>
    /// The name of the SecretManager secret version resource storing the
    /// client secret. If this field is set, the client_secret field will be
    /// ignored.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForClientSecret")]
    public string? SecretVersionForClientSecret { get; set; }

    /// <summary>
    /// The token endpoint provided by the 3rd party platform to exchange an
    /// access token.
    /// </summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderServiceDirectoryGenericWebServiceSecretVersionsForRequestHeaders
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the header value.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }
}

/// <summary>
/// Represents configuration for a generic web service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderServiceDirectoryGenericWebService
{
    /// <summary>
    /// Specifies a list of allowed custom CA certificates (in DER format) for
    /// HTTPS verification. This overrides the default SSL trust store. If this
    /// is empty or unspecified, Dialogflow will use Google&apos;s default trust store
    /// to verify certificates.
    /// N.B. Make sure the HTTPS server certificates are signed with &quot;subject alt
    /// name&quot;. For instance a certificate can be self-signed using the following
    /// command,
    /// openssl x509 -req -days 200 -in example.com.csr
    /// -signkey example.com.key
    /// -out example.com.crt
    /// -extfile &lt;(printf &quot;\nsubjectAltName=&apos;DNS:www.example.com&apos; &quot;)
    /// </summary>
    [JsonPropertyName("allowedCaCerts")]
    public IList<string>? AllowedCaCerts { get; set; }

    /// <summary>
    /// HTTP method for the flexible webhook calls. Standard webhook always uses
    /// POST.
    /// Possible values are: POST, GET, HEAD, PUT, DELETE, PATCH, OPTIONS.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// Represents configuration of OAuth client credential flow for 3rd party
    /// API authentication.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthConfig")]
    public V1beta1WebhookStatusAtProviderServiceDirectoryGenericWebServiceOauthConfig? OauthConfig { get; set; }

    /// <summary>
    /// Maps the values extracted from specific fields of the flexible webhook
    /// response into session parameters.
    /// </summary>
    [JsonPropertyName("parameterMapping")]
    public IDictionary<string, string>? ParameterMapping { get; set; }

    /// <summary>Defines a custom JSON object as request body to send to flexible webhook.</summary>
    [JsonPropertyName("requestBody")]
    public string? RequestBody { get; set; }

    /// <summary>The HTTP request headers to send together with webhook requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>
    /// The SecretManager secret version resource storing the username:password
    /// pair for HTTP Basic authentication.
    /// Format: projects/{project}/secrets/{secret}/versions/{version}
    /// </summary>
    [JsonPropertyName("secretVersionForUsernamePassword")]
    public string? SecretVersionForUsernamePassword { get; set; }

    /// <summary>
    /// The HTTP request headers to send together with webhook requests. Header
    /// values are stored in SecretManager secret versions.
    /// When the same header name is specified in both request_headers and
    /// secret_versions_for_request_headers, the value in
    /// secret_versions_for_request_headers will be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretVersionsForRequestHeaders")]
    public IList<V1beta1WebhookStatusAtProviderServiceDirectoryGenericWebServiceSecretVersionsForRequestHeaders>? SecretVersionsForRequestHeaders { get; set; }

    /// <summary>
    /// Indicate the auth token type generated from the Diglogflow service
    /// agent.
    /// The generated token is sent in the Authorization header.
    /// Possible values are: NONE, ID_TOKEN, ACCESS_TOKEN.
    /// </summary>
    [JsonPropertyName("serviceAgentAuth")]
    public string? ServiceAgentAuth { get; set; }

    /// <summary>The webhook URI for receiving POST requests. It must use https protocol.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>
    /// Type of the webhook.
    /// Possible values are: STANDARD, FLEXIBLE.
    /// </summary>
    [JsonPropertyName("webhookType")]
    public string? WebhookType { get; set; }
}

/// <summary>
/// Configuration for a Service Directory service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProviderServiceDirectory
{
    /// <summary>
    /// Represents configuration for a generic web service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("genericWebService")]
    public V1beta1WebhookStatusAtProviderServiceDirectoryGenericWebService? GenericWebService { get; set; }

    /// <summary>The name of Service Directory service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusAtProvider
{
    /// <summary>Indicates whether the webhook is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The human-readable name of the webhook, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Deprecated. Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Deprecated. Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// Represents configuration for a generic web service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("genericWebService")]
    public V1beta1WebhookStatusAtProviderGenericWebService? GenericWebService { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/webhooks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The unique identifier of the webhook.
    /// Format: projects//locations//agents//webhooks/.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The agent to create a webhook for.
    /// Format: projects//locations//agents/.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Deprecated. Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>
    /// Configuration for a Service Directory service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectory")]
    public V1beta1WebhookStatusAtProviderServiceDirectory? ServiceDirectory { get; set; }

    /// <summary>Deprecated. Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("startFlow")]
    public string? StartFlow { get; set; }

    /// <summary>Webhook execution timeout.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatusConditions
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

/// <summary>WebhookStatus defines the observed state of Webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebhookStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1WebhookStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebhookStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Webhook is the Schema for the Webhooks API. Webhooks host the developer&apos;s business logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Webhook : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebhookSpec>, IStatus<V1beta1WebhookStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Webhook";
    public const string KubeGroup = "dialogflowcx.gcp.m.upbound.io";
    public const string KubePluralName = "webhooks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflowcx.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Webhook";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebhookSpec defines the desired state of Webhook</summary>
    [JsonPropertyName("spec")]
    public required V1beta1WebhookSpec Spec { get; set; }

    /// <summary>WebhookStatus defines the observed state of Webhook.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebhookStatus? Status { get; set; }
}