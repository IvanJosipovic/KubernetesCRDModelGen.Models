#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elbv2.aws.upbound.io;
/// <summary>LBListener is the Schema for the LBListeners API. Provides a Load Balancer Listener resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LBListenerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2LBListener>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LBListenerList";
    public const string KubeGroup = "elbv2.aws.upbound.io";
    public const string KubePluralName = "lblisteners";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LBListenerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2LBListener objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2LBListener> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecDeletionPolicyEnum>))]
public enum V1beta2LBListenerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block for using Amazon Cognito to authenticate users. Specify only when type is authenticate-cognito. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionAuthenticateCognito
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10. See below.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values are deny, allow and authenticate.</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }
}

/// <summary>OAuth 2.0 client secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionAuthenticateOidcClientSecretSecretRef
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

/// <summary>Configuration block for an identity provider that is compliant with OpenID Connect (OIDC). Specify only when type is authenticate-oidc. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionAuthenticateOidc
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>OAuth 2.0 client secret.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LBListenerSpecForProviderDefaultActionAuthenticateOidcClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>OIDC issuer identifier of the IdP.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>Token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>User info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionFixedResponse
{
    /// <summary>Content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>HTTP response code. Valid values are 2XX, 4XX, or 5XX.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Configuration block for target group stickiness for the rule. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionForwardStickiness
{
    /// <summary>Time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Whether target group stickiness is enabled. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelector
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
    public V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroup
{
    /// <summary>ARN of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnRef? ArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroupArnSelector? ArnSelector { get; set; }

    /// <summary>Weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionForward
{
    /// <summary>Configuration block for target group stickiness for the rule. See below.</summary>
    [JsonPropertyName("stickiness")]
    public V1beta2LBListenerSpecForProviderDefaultActionForwardStickiness? Stickiness { get; set; }

    /// <summary>Set of 1-5 target group blocks. See below.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta2LBListenerSpecForProviderDefaultActionForwardTargetGroup>? TargetGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionJwtValidationAdditionalClaim
{
    /// <summary>Format of the claim value. Valid values are single-string, string-array and space-separated-values.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Name of the claim to validate. exp, iss, nbf, or iat cannot be specified because they are validated by default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of expected values of the claim.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Configuration block for creating a JWT validation action. Required if type is jwt-validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionJwtValidation
{
    /// <summary>Repeatable configuration block for additional claims to validate.</summary>
    [JsonPropertyName("additionalClaim")]
    public IList<V1beta2LBListenerSpecForProviderDefaultActionJwtValidationAdditionalClaim>? AdditionalClaim { get; set; }

    /// <summary>Issuer of the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>JSON Web Key Set (JWKS) endpoint. This endpoint contains JSON Web Keys (JWK) that are used to validate signatures from the provider. This must be a full URL, including the HTTPS protocol, the domain, and the path.</summary>
    [JsonPropertyName("jwksEndpoint")]
    public string? JwksEndpoint { get; set; }
}

/// <summary>Configuration block for creating a redirect action. Required if type is redirect. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionRedirect
{
    /// <summary>Hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Absolute path, starting with the leading &quot;/&quot;. This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading &quot;?&quot;. Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelector
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
    public V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderDefaultAction
{
    /// <summary>Configuration block for using Amazon Cognito to authenticate users. Specify only when type is authenticate-cognito. See below.</summary>
    [JsonPropertyName("authenticateCognito")]
    public V1beta2LBListenerSpecForProviderDefaultActionAuthenticateCognito? AuthenticateCognito { get; set; }

    /// <summary>Configuration block for an identity provider that is compliant with OpenID Connect (OIDC). Specify only when type is authenticate-oidc. See below.</summary>
    [JsonPropertyName("authenticateOidc")]
    public V1beta2LBListenerSpecForProviderDefaultActionAuthenticateOidc? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public V1beta2LBListenerSpecForProviderDefaultActionFixedResponse? FixedResponse { get; set; }

    /// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. See below.</summary>
    [JsonPropertyName("forward")]
    public V1beta2LBListenerSpecForProviderDefaultActionForward? Forward { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>Configuration block for creating a JWT validation action. Required if type is jwt-validation.</summary>
    [JsonPropertyName("jwtValidation")]
    public V1beta2LBListenerSpecForProviderDefaultActionJwtValidation? JwtValidation { get; set; }

    /// <summary>Order for the action. The action with the lowest value for order is performed first. Valid values are between 1 and 50000. Defaults to the position in the list of actions.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Configuration block for creating a redirect action. Required if type is redirect. See below.</summary>
    [JsonPropertyName("redirect")]
    public V1beta2LBListenerSpecForProviderDefaultActionRedirect? Redirect { get; set; }

    /// <summary>ARN of the Target Group to which to route traffic. Specify only if type is forward and you want to route to a single target group. To route to one or more target groups, use a forward block instead. Can be specified with forward but ARNs must match.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta2LBListenerSpecForProviderDefaultActionTargetGroupArnSelector? TargetGroupArnSelector { get; set; }

    /// <summary>Type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito, authenticate-oidc and jwt-validation.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderLoadBalancerArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecForProviderLoadBalancerArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderLoadBalancerArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecForProviderLoadBalancerArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderLoadBalancerArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecForProviderLoadBalancerArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecForProviderLoadBalancerArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LB in elbv2 to populate loadBalancerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderLoadBalancerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerSpecForProviderLoadBalancerArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderLoadBalancerArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecForProviderLoadBalancerArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecForProviderLoadBalancerArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecForProviderLoadBalancerArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderLoadBalancerArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecForProviderLoadBalancerArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecForProviderLoadBalancerArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LB in elbv2 to populate loadBalancerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderLoadBalancerArnSelector
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
    public V1beta2LBListenerSpecForProviderLoadBalancerArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The mutual authentication configuration information. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProviderMutualAuthentication
{
    /// <summary>Valid values are off and on.</summary>
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public string? AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>
    /// Whether client certificate expiry is ignored.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("ignoreClientCertificateExpiry")]
    public bool? IgnoreClientCertificateExpiry { get; set; }

    /// <summary>Valid values are off, passthrough, and verify.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>ARN of the elbv2 Trust Store.</summary>
    [JsonPropertyName("trustStoreArn")]
    public string? TrustStoreArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecForProvider
{
    /// <summary>Name of the Application-Layer Protocol Negotiation (ALPN) policy. Can be set if protocol is TLS. Valid values are HTTP1Only, HTTP2Only, HTTP2Optional, HTTP2Preferred, and None.</summary>
    [JsonPropertyName("alpnPolicy")]
    public string? AlpnPolicy { get; set; }

    /// <summary>ARN of the default SSL server certificate. Exactly one certificate is required if the protocol is HTTPS. For adding additional SSL certificates, see the aws_lb_listener_certificate resource.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Configuration block for default actions. See below.</summary>
    [JsonPropertyName("defaultAction")]
    public IList<V1beta2LBListenerSpecForProviderDefaultAction>? DefaultAction { get; set; }

    /// <summary>ARN of the load balancer.</summary>
    [JsonPropertyName("loadBalancerArn")]
    public string? LoadBalancerArn { get; set; }

    /// <summary>Reference to a LB in elbv2 to populate loadBalancerArn.</summary>
    [JsonPropertyName("loadBalancerArnRef")]
    public V1beta2LBListenerSpecForProviderLoadBalancerArnRef? LoadBalancerArnRef { get; set; }

    /// <summary>Selector for a LB in elbv2 to populate loadBalancerArn.</summary>
    [JsonPropertyName("loadBalancerArnSelector")]
    public V1beta2LBListenerSpecForProviderLoadBalancerArnSelector? LoadBalancerArnSelector { get; set; }

    /// <summary>The mutual authentication configuration information. See below.</summary>
    [JsonPropertyName("mutualAuthentication")]
    public V1beta2LBListenerSpecForProviderMutualAuthentication? MutualAuthentication { get; set; }

    /// <summary>Port on which the load balancer is listening. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol for connections from clients to the load balancer. For Application Load Balancers, valid values are HTTP and HTTPS, with a default of HTTP. For Network Load Balancers, valid values are TCP, TLS, UDP, TCP_UDP, QUIC, and TCP_QUIC. Not valid to use UDP or TCP_UDP if dual-stack mode is enabled. Not valid to use QUIC or TCP_QUIC if security groups are configured or dual-stack mode is enabled. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Issuer HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertIssuerHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Leaf HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertLeafHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Serial-Number HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Subject HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertSubjectHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Validity HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertValidityHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Tls-Cipher-Suite HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznTlsCipherSuiteHeaderName")]
    public string? RoutingHttpRequestXAmznTlsCipherSuiteHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Tls-Version HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznTlsVersionHeaderName")]
    public string? RoutingHttpRequestXAmznTlsVersionHeaderName { get; set; }

    /// <summary>Specifies which headers the browser can expose to the requesting client. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. The only valid value is true.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowCredentialsHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowCredentialsHeaderValue { get; set; }

    /// <summary>Specifies which headers can be used during the request. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are *, Accept, Accept-Language, Cache-Control, Content-Language, Content-Length, Content-Type, Expires, Last-Modified, Pragma. Dependent on your use-case other headers can be exposed and then set as a value consult the Access-Control-Allow-Headers documentation.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowHeadersHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowHeadersHeaderValue { get; set; }

    /// <summary>Set which HTTP methods are allowed when accessing the server from a different origin. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are GET, HEAD, POST, DELETE, CONNECT, OPTIONS, TRACE or PATCH.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowMethodsHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowMethodsHeaderValue { get; set; }

    /// <summary>Specifies which origins are allowed to access the server. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. A valid value is a URI, eg: https://example.com.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowOriginHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowOriginHeaderValue { get; set; }

    /// <summary>Specifies whether the browser should include credentials such as cookies or authentication when making requests. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are *, Cache-Control, Content-Language, Content-Length, Content-Type, Expires, Last-Modified, or Pragma. Dependent on your use-case other headers can be exposed, consult the Access-Control-Expose-Headers documentation.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlExposeHeadersHeaderValue")]
    public string? RoutingHttpResponseAccessControlExposeHeadersHeaderValue { get; set; }

    /// <summary>Specifies how long the results of a preflight request can be cached, in seconds. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are between 0 and 86400. This value is browser specific, consult the Access-Control-Max-Age documentation.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlMaxAgeHeaderValue")]
    public string? RoutingHttpResponseAccessControlMaxAgeHeaderValue { get; set; }

    /// <summary>Specifies restrictions enforced by the browser to help minimize the risk of certain types of security threats. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Values for this are extensive, and can be impactful when set, consult Content-Security-Policy documentation.</summary>
    [JsonPropertyName("routingHttpResponseContentSecurityPolicyHeaderValue")]
    public string? RoutingHttpResponseContentSecurityPolicyHeaderValue { get; set; }

    /// <summary>Enables you to allow or remove the HTTP response server header. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are true or false.</summary>
    [JsonPropertyName("routingHttpResponseServerEnabled")]
    public bool? RoutingHttpResponseServerEnabled { get; set; }

    /// <summary>Informs browsers that the site should only be accessed using HTTPS, and that any future attempts to access it using HTTP should automatically be converted to HTTPS. Default values are max-age=31536000; includeSubDomains; preload consult the Strict-Transport-Security documentation for further details.</summary>
    [JsonPropertyName("routingHttpResponseStrictTransportSecurityHeaderValue")]
    public string? RoutingHttpResponseStrictTransportSecurityHeaderValue { get; set; }

    /// <summary>Indicates whether the MIME types advertised in the Content-Type headers should be followed and not be changed. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. The only valid value is nosniff.</summary>
    [JsonPropertyName("routingHttpResponseXContentTypeOptionsHeaderValue")]
    public string? RoutingHttpResponseXContentTypeOptionsHeaderValue { get; set; }

    /// <summary>Indicates whether the browser is allowed to render a page in a frame, iframe, embed or object. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. The only valid values are DENY, SAMEORIGIN, or ALLOW-FROM https://example.com.</summary>
    [JsonPropertyName("routingHttpResponseXFrameOptionsHeaderValue")]
    public string? RoutingHttpResponseXFrameOptionsHeaderValue { get; set; }

    /// <summary>Name of the SSL Policy for the listener. Required if protocol is HTTPS or TLS. Default is ELBSecurityPolicy-2016-08.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TCP idle timeout value in seconds. Can only be set if protocol is TCP on Network Load Balancer, or with a Gateway Load Balancer. Not supported for Application Load Balancers. Valid values are between 60 and 6000 inclusive. Default: 350.</summary>
    [JsonPropertyName("tcpIdleTimeoutSeconds")]
    public double? TcpIdleTimeoutSeconds { get; set; }
}

/// <summary>Configuration block for using Amazon Cognito to authenticate users. Specify only when type is authenticate-cognito. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionAuthenticateCognito
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10. See below.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values are deny, allow and authenticate.</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }
}

/// <summary>OAuth 2.0 client secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionAuthenticateOidcClientSecretSecretRef
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

/// <summary>Configuration block for an identity provider that is compliant with OpenID Connect (OIDC). Specify only when type is authenticate-oidc. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionAuthenticateOidc
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>OAuth 2.0 client secret.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public required V1beta2LBListenerSpecInitProviderDefaultActionAuthenticateOidcClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>OIDC issuer identifier of the IdP.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>Token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>User info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionFixedResponse
{
    /// <summary>Content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>HTTP response code. Valid values are 2XX, 4XX, or 5XX.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Configuration block for target group stickiness for the rule. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionForwardStickiness
{
    /// <summary>Time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Whether target group stickiness is enabled. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelector
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
    public V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroup
{
    /// <summary>ARN of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnRef? ArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroupArnSelector? ArnSelector { get; set; }

    /// <summary>Weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionForward
{
    /// <summary>Configuration block for target group stickiness for the rule. See below.</summary>
    [JsonPropertyName("stickiness")]
    public V1beta2LBListenerSpecInitProviderDefaultActionForwardStickiness? Stickiness { get; set; }

    /// <summary>Set of 1-5 target group blocks. See below.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta2LBListenerSpecInitProviderDefaultActionForwardTargetGroup>? TargetGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionJwtValidationAdditionalClaim
{
    /// <summary>Format of the claim value. Valid values are single-string, string-array and space-separated-values.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Name of the claim to validate. exp, iss, nbf, or iat cannot be specified because they are validated by default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of expected values of the claim.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Configuration block for creating a JWT validation action. Required if type is jwt-validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionJwtValidation
{
    /// <summary>Repeatable configuration block for additional claims to validate.</summary>
    [JsonPropertyName("additionalClaim")]
    public IList<V1beta2LBListenerSpecInitProviderDefaultActionJwtValidationAdditionalClaim>? AdditionalClaim { get; set; }

    /// <summary>Issuer of the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>JSON Web Key Set (JWKS) endpoint. This endpoint contains JSON Web Keys (JWK) that are used to validate signatures from the provider. This must be a full URL, including the HTTPS protocol, the domain, and the path.</summary>
    [JsonPropertyName("jwksEndpoint")]
    public string? JwksEndpoint { get; set; }
}

/// <summary>Configuration block for creating a redirect action. Required if type is redirect. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionRedirect
{
    /// <summary>Hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Absolute path, starting with the leading &quot;/&quot;. This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading &quot;?&quot;. Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelector
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
    public V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderDefaultAction
{
    /// <summary>Configuration block for using Amazon Cognito to authenticate users. Specify only when type is authenticate-cognito. See below.</summary>
    [JsonPropertyName("authenticateCognito")]
    public V1beta2LBListenerSpecInitProviderDefaultActionAuthenticateCognito? AuthenticateCognito { get; set; }

    /// <summary>Configuration block for an identity provider that is compliant with OpenID Connect (OIDC). Specify only when type is authenticate-oidc. See below.</summary>
    [JsonPropertyName("authenticateOidc")]
    public V1beta2LBListenerSpecInitProviderDefaultActionAuthenticateOidc? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public V1beta2LBListenerSpecInitProviderDefaultActionFixedResponse? FixedResponse { get; set; }

    /// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. See below.</summary>
    [JsonPropertyName("forward")]
    public V1beta2LBListenerSpecInitProviderDefaultActionForward? Forward { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>Configuration block for creating a JWT validation action. Required if type is jwt-validation.</summary>
    [JsonPropertyName("jwtValidation")]
    public V1beta2LBListenerSpecInitProviderDefaultActionJwtValidation? JwtValidation { get; set; }

    /// <summary>Order for the action. The action with the lowest value for order is performed first. Valid values are between 1 and 50000. Defaults to the position in the list of actions.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Configuration block for creating a redirect action. Required if type is redirect. See below.</summary>
    [JsonPropertyName("redirect")]
    public V1beta2LBListenerSpecInitProviderDefaultActionRedirect? Redirect { get; set; }

    /// <summary>ARN of the Target Group to which to route traffic. Specify only if type is forward and you want to route to a single target group. To route to one or more target groups, use a forward block instead. Can be specified with forward but ARNs must match.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta2LBListenerSpecInitProviderDefaultActionTargetGroupArnSelector? TargetGroupArnSelector { get; set; }

    /// <summary>Type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito, authenticate-oidc and jwt-validation.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderLoadBalancerArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecInitProviderLoadBalancerArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderLoadBalancerArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecInitProviderLoadBalancerArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderLoadBalancerArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecInitProviderLoadBalancerArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecInitProviderLoadBalancerArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LB in elbv2 to populate loadBalancerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderLoadBalancerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerSpecInitProviderLoadBalancerArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderLoadBalancerArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecInitProviderLoadBalancerArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecInitProviderLoadBalancerArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecInitProviderLoadBalancerArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderLoadBalancerArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecInitProviderLoadBalancerArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecInitProviderLoadBalancerArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LB in elbv2 to populate loadBalancerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderLoadBalancerArnSelector
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
    public V1beta2LBListenerSpecInitProviderLoadBalancerArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The mutual authentication configuration information. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecInitProviderMutualAuthentication
{
    /// <summary>Valid values are off and on.</summary>
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public string? AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>
    /// Whether client certificate expiry is ignored.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("ignoreClientCertificateExpiry")]
    public bool? IgnoreClientCertificateExpiry { get; set; }

    /// <summary>Valid values are off, passthrough, and verify.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>ARN of the elbv2 Trust Store.</summary>
    [JsonPropertyName("trustStoreArn")]
    public string? TrustStoreArn { get; set; }
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
public partial class V1beta2LBListenerSpecInitProvider
{
    /// <summary>Name of the Application-Layer Protocol Negotiation (ALPN) policy. Can be set if protocol is TLS. Valid values are HTTP1Only, HTTP2Only, HTTP2Optional, HTTP2Preferred, and None.</summary>
    [JsonPropertyName("alpnPolicy")]
    public string? AlpnPolicy { get; set; }

    /// <summary>ARN of the default SSL server certificate. Exactly one certificate is required if the protocol is HTTPS. For adding additional SSL certificates, see the aws_lb_listener_certificate resource.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Configuration block for default actions. See below.</summary>
    [JsonPropertyName("defaultAction")]
    public IList<V1beta2LBListenerSpecInitProviderDefaultAction>? DefaultAction { get; set; }

    /// <summary>ARN of the load balancer.</summary>
    [JsonPropertyName("loadBalancerArn")]
    public string? LoadBalancerArn { get; set; }

    /// <summary>Reference to a LB in elbv2 to populate loadBalancerArn.</summary>
    [JsonPropertyName("loadBalancerArnRef")]
    public V1beta2LBListenerSpecInitProviderLoadBalancerArnRef? LoadBalancerArnRef { get; set; }

    /// <summary>Selector for a LB in elbv2 to populate loadBalancerArn.</summary>
    [JsonPropertyName("loadBalancerArnSelector")]
    public V1beta2LBListenerSpecInitProviderLoadBalancerArnSelector? LoadBalancerArnSelector { get; set; }

    /// <summary>The mutual authentication configuration information. See below.</summary>
    [JsonPropertyName("mutualAuthentication")]
    public V1beta2LBListenerSpecInitProviderMutualAuthentication? MutualAuthentication { get; set; }

    /// <summary>Port on which the load balancer is listening. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol for connections from clients to the load balancer. For Application Load Balancers, valid values are HTTP and HTTPS, with a default of HTTP. For Network Load Balancers, valid values are TCP, TLS, UDP, TCP_UDP, QUIC, and TCP_QUIC. Not valid to use UDP or TCP_UDP if dual-stack mode is enabled. Not valid to use QUIC or TCP_QUIC if security groups are configured or dual-stack mode is enabled. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Issuer HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertIssuerHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Leaf HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertLeafHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Serial-Number HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Subject HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertSubjectHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Validity HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertValidityHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Tls-Cipher-Suite HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznTlsCipherSuiteHeaderName")]
    public string? RoutingHttpRequestXAmznTlsCipherSuiteHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Tls-Version HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznTlsVersionHeaderName")]
    public string? RoutingHttpRequestXAmznTlsVersionHeaderName { get; set; }

    /// <summary>Specifies which headers the browser can expose to the requesting client. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. The only valid value is true.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowCredentialsHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowCredentialsHeaderValue { get; set; }

    /// <summary>Specifies which headers can be used during the request. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are *, Accept, Accept-Language, Cache-Control, Content-Language, Content-Length, Content-Type, Expires, Last-Modified, Pragma. Dependent on your use-case other headers can be exposed and then set as a value consult the Access-Control-Allow-Headers documentation.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowHeadersHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowHeadersHeaderValue { get; set; }

    /// <summary>Set which HTTP methods are allowed when accessing the server from a different origin. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are GET, HEAD, POST, DELETE, CONNECT, OPTIONS, TRACE or PATCH.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowMethodsHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowMethodsHeaderValue { get; set; }

    /// <summary>Specifies which origins are allowed to access the server. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. A valid value is a URI, eg: https://example.com.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowOriginHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowOriginHeaderValue { get; set; }

    /// <summary>Specifies whether the browser should include credentials such as cookies or authentication when making requests. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are *, Cache-Control, Content-Language, Content-Length, Content-Type, Expires, Last-Modified, or Pragma. Dependent on your use-case other headers can be exposed, consult the Access-Control-Expose-Headers documentation.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlExposeHeadersHeaderValue")]
    public string? RoutingHttpResponseAccessControlExposeHeadersHeaderValue { get; set; }

    /// <summary>Specifies how long the results of a preflight request can be cached, in seconds. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are between 0 and 86400. This value is browser specific, consult the Access-Control-Max-Age documentation.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlMaxAgeHeaderValue")]
    public string? RoutingHttpResponseAccessControlMaxAgeHeaderValue { get; set; }

    /// <summary>Specifies restrictions enforced by the browser to help minimize the risk of certain types of security threats. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Values for this are extensive, and can be impactful when set, consult Content-Security-Policy documentation.</summary>
    [JsonPropertyName("routingHttpResponseContentSecurityPolicyHeaderValue")]
    public string? RoutingHttpResponseContentSecurityPolicyHeaderValue { get; set; }

    /// <summary>Enables you to allow or remove the HTTP response server header. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are true or false.</summary>
    [JsonPropertyName("routingHttpResponseServerEnabled")]
    public bool? RoutingHttpResponseServerEnabled { get; set; }

    /// <summary>Informs browsers that the site should only be accessed using HTTPS, and that any future attempts to access it using HTTP should automatically be converted to HTTPS. Default values are max-age=31536000; includeSubDomains; preload consult the Strict-Transport-Security documentation for further details.</summary>
    [JsonPropertyName("routingHttpResponseStrictTransportSecurityHeaderValue")]
    public string? RoutingHttpResponseStrictTransportSecurityHeaderValue { get; set; }

    /// <summary>Indicates whether the MIME types advertised in the Content-Type headers should be followed and not be changed. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. The only valid value is nosniff.</summary>
    [JsonPropertyName("routingHttpResponseXContentTypeOptionsHeaderValue")]
    public string? RoutingHttpResponseXContentTypeOptionsHeaderValue { get; set; }

    /// <summary>Indicates whether the browser is allowed to render a page in a frame, iframe, embed or object. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. The only valid values are DENY, SAMEORIGIN, or ALLOW-FROM https://example.com.</summary>
    [JsonPropertyName("routingHttpResponseXFrameOptionsHeaderValue")]
    public string? RoutingHttpResponseXFrameOptionsHeaderValue { get; set; }

    /// <summary>Name of the SSL Policy for the listener. Required if protocol is HTTPS or TLS. Default is ELBSecurityPolicy-2016-08.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TCP idle timeout value in seconds. Can only be set if protocol is TCP on Network Load Balancer, or with a Gateway Load Balancer. Not supported for Application Load Balancers. Valid values are between 60 and 6000 inclusive. Default: 350.</summary>
    [JsonPropertyName("tcpIdleTimeoutSeconds")]
    public double? TcpIdleTimeoutSeconds { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecManagementPoliciesEnum>))]
public enum V1beta2LBListenerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2LBListenerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>LBListenerSpec defines the desired state of LBListener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerSpec
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
    public V1beta2LBListenerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2LBListenerSpecForProvider ForProvider { get; set; }

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
    public V1beta2LBListenerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2LBListenerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2LBListenerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2LBListenerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block for using Amazon Cognito to authenticate users. Specify only when type is authenticate-cognito. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultActionAuthenticateCognito
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10. See below.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values are deny, allow and authenticate.</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }
}

/// <summary>Configuration block for an identity provider that is compliant with OpenID Connect (OIDC). Specify only when type is authenticate-oidc. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultActionAuthenticateOidc
{
    /// <summary>Query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>Authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>OIDC issuer identifier of the IdP.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>Set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>Maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>Token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>User info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultActionFixedResponse
{
    /// <summary>Content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>HTTP response code. Valid values are 2XX, 4XX, or 5XX.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Configuration block for target group stickiness for the rule. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultActionForwardStickiness
{
    /// <summary>Time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Whether target group stickiness is enabled. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultActionForwardTargetGroup
{
    /// <summary>ARN of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultActionForward
{
    /// <summary>Configuration block for target group stickiness for the rule. See below.</summary>
    [JsonPropertyName("stickiness")]
    public V1beta2LBListenerStatusAtProviderDefaultActionForwardStickiness? Stickiness { get; set; }

    /// <summary>Set of 1-5 target group blocks. See below.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta2LBListenerStatusAtProviderDefaultActionForwardTargetGroup>? TargetGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultActionJwtValidationAdditionalClaim
{
    /// <summary>Format of the claim value. Valid values are single-string, string-array and space-separated-values.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Name of the claim to validate. exp, iss, nbf, or iat cannot be specified because they are validated by default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of expected values of the claim.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Configuration block for creating a JWT validation action. Required if type is jwt-validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultActionJwtValidation
{
    /// <summary>Repeatable configuration block for additional claims to validate.</summary>
    [JsonPropertyName("additionalClaim")]
    public IList<V1beta2LBListenerStatusAtProviderDefaultActionJwtValidationAdditionalClaim>? AdditionalClaim { get; set; }

    /// <summary>Issuer of the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>JSON Web Key Set (JWKS) endpoint. This endpoint contains JSON Web Keys (JWK) that are used to validate signatures from the provider. This must be a full URL, including the HTTPS protocol, the domain, and the path.</summary>
    [JsonPropertyName("jwksEndpoint")]
    public string? JwksEndpoint { get; set; }
}

/// <summary>Configuration block for creating a redirect action. Required if type is redirect. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultActionRedirect
{
    /// <summary>Hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Absolute path, starting with the leading &quot;/&quot;. This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading &quot;?&quot;. Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderDefaultAction
{
    /// <summary>Configuration block for using Amazon Cognito to authenticate users. Specify only when type is authenticate-cognito. See below.</summary>
    [JsonPropertyName("authenticateCognito")]
    public V1beta2LBListenerStatusAtProviderDefaultActionAuthenticateCognito? AuthenticateCognito { get; set; }

    /// <summary>Configuration block for an identity provider that is compliant with OpenID Connect (OIDC). Specify only when type is authenticate-oidc. See below.</summary>
    [JsonPropertyName("authenticateOidc")]
    public V1beta2LBListenerStatusAtProviderDefaultActionAuthenticateOidc? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public V1beta2LBListenerStatusAtProviderDefaultActionFixedResponse? FixedResponse { get; set; }

    /// <summary>Configuration block for creating an action that distributes requests among one or more target groups. Specify only if type is forward. See below.</summary>
    [JsonPropertyName("forward")]
    public V1beta2LBListenerStatusAtProviderDefaultActionForward? Forward { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>Configuration block for creating a JWT validation action. Required if type is jwt-validation.</summary>
    [JsonPropertyName("jwtValidation")]
    public V1beta2LBListenerStatusAtProviderDefaultActionJwtValidation? JwtValidation { get; set; }

    /// <summary>Order for the action. The action with the lowest value for order is performed first. Valid values are between 1 and 50000. Defaults to the position in the list of actions.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Configuration block for creating a redirect action. Required if type is redirect. See below.</summary>
    [JsonPropertyName("redirect")]
    public V1beta2LBListenerStatusAtProviderDefaultActionRedirect? Redirect { get; set; }

    /// <summary>ARN of the Target Group to which to route traffic. Specify only if type is forward and you want to route to a single target group. To route to one or more target groups, use a forward block instead. Can be specified with forward but ARNs must match.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito, authenticate-oidc and jwt-validation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The mutual authentication configuration information. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProviderMutualAuthentication
{
    /// <summary>Valid values are off and on.</summary>
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public string? AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>
    /// Whether client certificate expiry is ignored.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("ignoreClientCertificateExpiry")]
    public bool? IgnoreClientCertificateExpiry { get; set; }

    /// <summary>Valid values are off, passthrough, and verify.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>ARN of the elbv2 Trust Store.</summary>
    [JsonPropertyName("trustStoreArn")]
    public string? TrustStoreArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusAtProvider
{
    /// <summary>Name of the Application-Layer Protocol Negotiation (ALPN) policy. Can be set if protocol is TLS. Valid values are HTTP1Only, HTTP2Only, HTTP2Optional, HTTP2Preferred, and None.</summary>
    [JsonPropertyName("alpnPolicy")]
    public string? AlpnPolicy { get; set; }

    /// <summary>ARN of the listener.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN of the default SSL server certificate. Exactly one certificate is required if the protocol is HTTPS. For adding additional SSL certificates, see the aws_lb_listener_certificate resource.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Configuration block for default actions. See below.</summary>
    [JsonPropertyName("defaultAction")]
    public IList<V1beta2LBListenerStatusAtProviderDefaultAction>? DefaultAction { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the load balancer.</summary>
    [JsonPropertyName("loadBalancerArn")]
    public string? LoadBalancerArn { get; set; }

    /// <summary>The mutual authentication configuration information. See below.</summary>
    [JsonPropertyName("mutualAuthentication")]
    public V1beta2LBListenerStatusAtProviderMutualAuthentication? MutualAuthentication { get; set; }

    /// <summary>Port on which the load balancer is listening. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol for connections from clients to the load balancer. For Application Load Balancers, valid values are HTTP and HTTPS, with a default of HTTP. For Network Load Balancers, valid values are TCP, TLS, UDP, TCP_UDP, QUIC, and TCP_QUIC. Not valid to use UDP or TCP_UDP if dual-stack mode is enabled. Not valid to use QUIC or TCP_QUIC if security groups are configured or dual-stack mode is enabled. Not valid for Gateway Load Balancers.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Issuer HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertIssuerHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Leaf HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertLeafHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Serial-Number HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Subject HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertSubjectHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Mtls-Clientcert-Validity HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznMtlsClientcertValidityHeaderName")]
    public string? RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Tls-Cipher-Suite HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznTlsCipherSuiteHeaderName")]
    public string? RoutingHttpRequestXAmznTlsCipherSuiteHeaderName { get; set; }

    /// <summary>Enables you to modify the header name of the X-Amzn-Tls-Version HTTP request header. Can only be set if protocol is HTTPS for Application Load Balancers.</summary>
    [JsonPropertyName("routingHttpRequestXAmznTlsVersionHeaderName")]
    public string? RoutingHttpRequestXAmznTlsVersionHeaderName { get; set; }

    /// <summary>Specifies which headers the browser can expose to the requesting client. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. The only valid value is true.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowCredentialsHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowCredentialsHeaderValue { get; set; }

    /// <summary>Specifies which headers can be used during the request. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are *, Accept, Accept-Language, Cache-Control, Content-Language, Content-Length, Content-Type, Expires, Last-Modified, Pragma. Dependent on your use-case other headers can be exposed and then set as a value consult the Access-Control-Allow-Headers documentation.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowHeadersHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowHeadersHeaderValue { get; set; }

    /// <summary>Set which HTTP methods are allowed when accessing the server from a different origin. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are GET, HEAD, POST, DELETE, CONNECT, OPTIONS, TRACE or PATCH.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowMethodsHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowMethodsHeaderValue { get; set; }

    /// <summary>Specifies which origins are allowed to access the server. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. A valid value is a URI, eg: https://example.com.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlAllowOriginHeaderValue")]
    public string? RoutingHttpResponseAccessControlAllowOriginHeaderValue { get; set; }

    /// <summary>Specifies whether the browser should include credentials such as cookies or authentication when making requests. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are *, Cache-Control, Content-Language, Content-Length, Content-Type, Expires, Last-Modified, or Pragma. Dependent on your use-case other headers can be exposed, consult the Access-Control-Expose-Headers documentation.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlExposeHeadersHeaderValue")]
    public string? RoutingHttpResponseAccessControlExposeHeadersHeaderValue { get; set; }

    /// <summary>Specifies how long the results of a preflight request can be cached, in seconds. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are between 0 and 86400. This value is browser specific, consult the Access-Control-Max-Age documentation.</summary>
    [JsonPropertyName("routingHttpResponseAccessControlMaxAgeHeaderValue")]
    public string? RoutingHttpResponseAccessControlMaxAgeHeaderValue { get; set; }

    /// <summary>Specifies restrictions enforced by the browser to help minimize the risk of certain types of security threats. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Values for this are extensive, and can be impactful when set, consult Content-Security-Policy documentation.</summary>
    [JsonPropertyName("routingHttpResponseContentSecurityPolicyHeaderValue")]
    public string? RoutingHttpResponseContentSecurityPolicyHeaderValue { get; set; }

    /// <summary>Enables you to allow or remove the HTTP response server header. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. Valid values are true or false.</summary>
    [JsonPropertyName("routingHttpResponseServerEnabled")]
    public bool? RoutingHttpResponseServerEnabled { get; set; }

    /// <summary>Informs browsers that the site should only be accessed using HTTPS, and that any future attempts to access it using HTTP should automatically be converted to HTTPS. Default values are max-age=31536000; includeSubDomains; preload consult the Strict-Transport-Security documentation for further details.</summary>
    [JsonPropertyName("routingHttpResponseStrictTransportSecurityHeaderValue")]
    public string? RoutingHttpResponseStrictTransportSecurityHeaderValue { get; set; }

    /// <summary>Indicates whether the MIME types advertised in the Content-Type headers should be followed and not be changed. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. The only valid value is nosniff.</summary>
    [JsonPropertyName("routingHttpResponseXContentTypeOptionsHeaderValue")]
    public string? RoutingHttpResponseXContentTypeOptionsHeaderValue { get; set; }

    /// <summary>Indicates whether the browser is allowed to render a page in a frame, iframe, embed or object. Can only be set if protocol is HTTP or HTTPS for Application Load Balancers. Not supported for Network Load Balancer, or with a Gateway Load Balancer. The only valid values are DENY, SAMEORIGIN, or ALLOW-FROM https://example.com.</summary>
    [JsonPropertyName("routingHttpResponseXFrameOptionsHeaderValue")]
    public string? RoutingHttpResponseXFrameOptionsHeaderValue { get; set; }

    /// <summary>Name of the SSL Policy for the listener. Required if protocol is HTTPS or TLS. Default is ELBSecurityPolicy-2016-08.</summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>TCP idle timeout value in seconds. Can only be set if protocol is TCP on Network Load Balancer, or with a Gateway Load Balancer. Not supported for Application Load Balancers. Valid values are between 60 and 6000 inclusive. Default: 350.</summary>
    [JsonPropertyName("tcpIdleTimeoutSeconds")]
    public double? TcpIdleTimeoutSeconds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatusConditions
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

/// <summary>LBListenerStatus defines the observed state of LBListener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2LBListenerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2LBListenerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LBListener is the Schema for the LBListeners API. Provides a Load Balancer Listener resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LBListener : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2LBListenerSpec>, IStatus<V1beta2LBListenerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LBListener";
    public const string KubeGroup = "elbv2.aws.upbound.io";
    public const string KubePluralName = "lblisteners";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LBListener";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LBListenerSpec defines the desired state of LBListener</summary>
    [JsonPropertyName("spec")]
    public required V1beta2LBListenerSpec Spec { get; set; }

    /// <summary>LBListenerStatus defines the observed state of LBListener.</summary>
    [JsonPropertyName("status")]
    public V1beta2LBListenerStatus? Status { get; set; }
}