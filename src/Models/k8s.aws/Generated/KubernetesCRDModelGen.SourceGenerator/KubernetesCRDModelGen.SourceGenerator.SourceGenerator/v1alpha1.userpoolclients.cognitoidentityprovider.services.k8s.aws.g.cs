#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitoidentityprovider.services.k8s.aws;
/// <summary>UserPoolClient is the Schema for the UserPoolClients API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1UserPoolClientList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1UserPoolClient>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "UserPoolClientList";
    public const string KubeGroup = "cognitoidentityprovider.services.k8s.aws";
    public const string KubePluralName = "userpoolclients";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitoidentityprovider.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserPoolClientList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1UserPoolClient objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1UserPoolClient> Items { get; set; }
}

/// <summary>
/// The user pool analytics configuration for collecting metrics and sending
/// them to your Amazon Pinpoint campaign.
/// 
/// In Amazon Web Services Regions where Amazon Pinpoint isn&apos;t available, user
/// pools only support sending events to Amazon Pinpoint projects in Amazon Web
/// Services Region us-east-1. In Regions where Amazon Pinpoint is available,
/// user pools support sending events to Amazon Pinpoint projects within that
/// same Region.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolClientSpecAnalyticsConfiguration
{
    [JsonPropertyName("applicationARN")]
    public string? ApplicationARN { get; set; }

    [JsonPropertyName("applicationID")]
    public string? ApplicationID { get; set; }

    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("userDataShared")]
    public bool? UserDataShared { get; set; }
}

/// <summary>
/// The units in which the validity times are represented. The default unit for
/// RefreshToken is days, and default for ID and access tokens are hours.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolClientSpecTokenValidityUnits
{
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; set; }

    [JsonPropertyName("idToken")]
    public string? IdToken { get; set; }

    [JsonPropertyName("refreshToken")]
    public string? RefreshToken { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolClientSpecUserPoolRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolClientSpecUserPoolRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1UserPoolClientSpecUserPoolRefFrom? From { get; set; }
}

/// <summary>UserPoolClientSpec defines the desired state of UserPoolClient.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolClientSpec
{
    /// <summary>
    /// The access token time limit. After this limit expires, your user can&apos;t use
    /// their access token. To specify the time unit for AccessTokenValidity as seconds,
    /// minutes, hours, or days, set a TokenValidityUnits value in your API request.
    /// 
    /// For example, when you set AccessTokenValidity to 10 andTokenValidityUnits
    /// to hours, your user can authorize access withtheir access token for 10 hours.
    /// 
    /// The default time unit for AccessTokenValidity in an API request is hours.
    /// Valid range is displayed below in seconds.
    /// 
    /// If you don&apos;t specify otherwise in the configuration of your app client, your
    /// accesstokens are valid for one hour.
    /// </summary>
    [JsonPropertyName("accessTokenValidity")]
    public long? AccessTokenValidity { get; set; }

    /// <summary>
    /// The OAuth grant types that you want your app client to generate. To create
    /// an app client that generates client credentials grants, you must add client_credentials
    /// as the only allowed OAuth flow.
    /// 
    /// code
    /// 
    /// Use a code grant flow, which provides an authorization code as the response.
    /// This code can be exchanged for access tokens with the /oauth2/token endpoint.
    /// 
    /// implicit
    /// 
    /// Issue the access token (and, optionally, ID token, based on scopes) directly
    /// to your user.
    /// 
    /// client_credentials
    /// 
    /// Issue the access token from the /oauth2/token endpoint directly to a non-person
    /// user using a combination of the client ID and client secret.
    /// </summary>
    [JsonPropertyName("allowedOAuthFlows")]
    public IList<string>? AllowedOAuthFlows { get; set; }

    /// <summary>
    /// Set to true to use OAuth 2.0 features in your user pool app client.
    /// 
    /// AllowedOAuthFlowsUserPoolClient must be true before you can configure the
    /// following features in your app client.
    /// 
    ///   - CallBackURLs: Callback URLs.
    /// 
    ///   - LogoutURLs: Sign-out redirect URLs.
    /// 
    ///   - AllowedOAuthScopes: OAuth 2.0 scopes.
    /// 
    ///   - AllowedOAuthFlows: Support for authorization code, implicit, and client
    ///     credentials OAuth 2.0 grants.
    /// 
    /// To use OAuth 2.0 features, configure one of these features in the Amazon
    /// Cognito console or set AllowedOAuthFlowsUserPoolClient to true in a CreateUserPoolClient
    /// or UpdateUserPoolClient API request. If you don&apos;t set a value for AllowedOAuthFlowsUserPoolClient
    /// in a request with the CLI or SDKs, it defaults to false.
    /// </summary>
    [JsonPropertyName("allowedOAuthFlowsUserPoolClient")]
    public bool? AllowedOAuthFlowsUserPoolClient { get; set; }

    /// <summary>
    /// The allowed OAuth scopes. Possible values provided by OAuth are phone, email,
    /// openid, and profile. Possible values provided by Amazon Web Services are
    /// aws.cognito.signin.user.admin. Custom scopes created in Resource Servers
    /// are also supported.
    /// </summary>
    [JsonPropertyName("allowedOAuthScopes")]
    public IList<string>? AllowedOAuthScopes { get; set; }

    /// <summary>
    /// The user pool analytics configuration for collecting metrics and sending
    /// them to your Amazon Pinpoint campaign.
    /// 
    /// In Amazon Web Services Regions where Amazon Pinpoint isn&apos;t available, user
    /// pools only support sending events to Amazon Pinpoint projects in Amazon Web
    /// Services Region us-east-1. In Regions where Amazon Pinpoint is available,
    /// user pools support sending events to Amazon Pinpoint projects within that
    /// same Region.
    /// </summary>
    [JsonPropertyName("analyticsConfiguration")]
    public V1alpha1UserPoolClientSpecAnalyticsConfiguration? AnalyticsConfiguration { get; set; }

    /// <summary>
    /// Amazon Cognito creates a session token for each API request in an authentication
    /// flow. AuthSessionValidity is the duration, in minutes, of that session token.
    /// Your user pool native user must respond to each authentication challenge
    /// before the session expires.
    /// </summary>
    [JsonPropertyName("authSessionValidity")]
    public long? AuthSessionValidity { get; set; }

    /// <summary>
    /// A list of allowed redirect (callback) URLs for the IdPs.
    /// 
    /// A redirect URI must:
    /// 
    ///   - Be an absolute URI.
    /// 
    ///   - Be registered with the authorization server.
    /// 
    ///   - Not include a fragment component.
    /// 
    /// See OAuth 2.0 - Redirection Endpoint (https://tools.ietf.org/html/rfc6749#section-3.1.2).
    /// 
    /// Amazon Cognito requires HTTPS over HTTP except for http://localhost for testing
    /// purposes only.
    /// 
    /// App callback URLs such as myapp://example are also supported.
    /// </summary>
    [JsonPropertyName("callbackURLs")]
    public IList<string>? CallbackURLs { get; set; }

    /// <summary>
    /// The default redirect URI. In app clients with one assigned IdP, replaces
    /// redirect_uri in authentication requests. Must be in the CallbackURLs list.
    /// 
    /// A redirect URI must:
    /// 
    ///   - Be an absolute URI.
    /// 
    ///   - Be registered with the authorization server.
    /// 
    ///   - Not include a fragment component.
    /// 
    /// For more information, see Default redirect URI (https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-client-apps.html#cognito-user-pools-app-idp-settings-about).
    /// 
    /// Amazon Cognito requires HTTPS over HTTP except for http://localhost for testing
    /// purposes only.
    /// 
    /// App callback URLs such as myapp://example are also supported.
    /// 
    /// Regex Pattern: `^[\p{L}\p{M}\p{S}\p{N}\p{P}]+$`
    /// </summary>
    [JsonPropertyName("defaultRedirectURI")]
    public string? DefaultRedirectURI { get; set; }

    /// <summary>
    /// Activates the propagation of additional user context data. For more information
    /// about propagation of user context data, see Adding advanced security to a
    /// user pool (https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-threat-protection.html).
    /// If you don’t include this parameter, you can&apos;t send device fingerprint
    /// information, including source IP address, to Amazon Cognito advanced security.
    /// You can only activate EnablePropagateAdditionalUserContextData in an app
    /// client that has a client secret.
    /// </summary>
    [JsonPropertyName("enablePropagateAdditionalUserContextData")]
    public bool? EnablePropagateAdditionalUserContextData { get; set; }

    /// <summary>
    /// Activates or deactivates token revocation. For more information about revoking
    /// tokens, see RevokeToken (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_RevokeToken.html).
    /// 
    /// If you don&apos;t include this parameter, token revocation is automatically activated
    /// for the new user pool client.
    /// </summary>
    [JsonPropertyName("enableTokenRevocation")]
    public bool? EnableTokenRevocation { get; set; }

    /// <summary>
    /// The authentication flows that you want your user pool client to support.
    /// For each app client in your user pool, you can sign in your users with any
    /// combination of one or more flows, including with a user name and Secure Remote
    /// Password (SRP), a user name and password, or a custom authentication process
    /// that you define with Lambda functions.
    /// 
    /// If you don&apos;t specify a value for ExplicitAuthFlows, your user client supports
    /// ALLOW_REFRESH_TOKEN_AUTH, ALLOW_USER_SRP_AUTH, and ALLOW_CUSTOM_AUTH.
    /// 
    /// Valid values include:
    /// 
    ///   - ALLOW_USER_AUTH: Enable selection-based sign-in with USER_AUTH. This
    ///     setting covers username-password, secure remote password (SRP), passwordless,
    ///     and passkey authentication. This authentiation flow can do username-password
    ///     and SRP authentication without other ExplicitAuthFlows permitting them.
    ///     For example users can complete an SRP challenge through USER_AUTH without
    ///     the flow USER_SRP_AUTH being active for the app client. This flow doesn&apos;t
    ///     include CUSTOM_AUTH.
    /// 
    ///   - ALLOW_ADMIN_USER_PASSWORD_AUTH: Enable admin based user password authentication
    ///     flow ADMIN_USER_PASSWORD_AUTH. This setting replaces the ADMIN_NO_SRP_AUTH
    ///     setting. With this authentication flow, your app passes a user name and
    ///     password to Amazon Cognito in the request, instead of using the Secure
    ///     Remote Password (SRP) protocol to securely transmit the password.
    /// 
    ///   - ALLOW_CUSTOM_AUTH: Enable Lambda trigger based authentication.
    /// 
    ///   - ALLOW_USER_PASSWORD_AUTH: Enable user password-based authentication.
    ///     In this flow, Amazon Cognito receives the password in the request instead
    ///     of using the SRP protocol to verify passwords.
    /// 
    ///   - ALLOW_USER_SRP_AUTH: Enable SRP-based authentication.
    /// 
    ///   - ALLOW_REFRESH_TOKEN_AUTH: Enable authflow to refresh tokens.
    /// 
    /// In some environments, you will see the values ADMIN_NO_SRP_AUTH, CUSTOM_AUTH_FLOW_ONLY,
    /// or USER_PASSWORD_AUTH. You can&apos;t assign these legacy ExplicitAuthFlows values
    /// to user pool clients at the same time as values that begin with ALLOW_,like
    /// ALLOW_USER_SRP_AUTH.
    /// </summary>
    [JsonPropertyName("explicitAuthFlows")]
    public IList<string>? ExplicitAuthFlows { get; set; }

    /// <summary>
    /// Boolean to specify whether you want to generate a secret for the user pool
    /// client being created.
    /// </summary>
    [JsonPropertyName("generateSecret")]
    public bool? GenerateSecret { get; set; }

    /// <summary>
    /// The ID token time limit. After this limit expires, your user can&apos;t use their
    /// ID token. To specify the time unit for IdTokenValidity as seconds, minutes,
    /// hours, or days, set a TokenValidityUnits value in your API request.
    /// 
    /// For example, when you set IdTokenValidity as 10 andTokenValidityUnits as
    /// hours, your user can authenticate their session with their ID token for 10
    /// hours.
    /// 
    /// The default time unit for IdTokenValidity in an API request is hours. Valid
    /// range is displayed below in seconds.
    /// 
    /// If you don&apos;t specify otherwise in the configuration of your app client, your
    /// IDtokens are valid for one hour.
    /// </summary>
    [JsonPropertyName("idTokenValidity")]
    public long? IdTokenValidity { get; set; }

    /// <summary>A list of allowed logout URLs for the IdPs.</summary>
    [JsonPropertyName("logoutURLs")]
    public IList<string>? LogoutURLs { get; set; }

    /// <summary>
    /// The client name for the user pool client you would like to create.
    /// 
    /// Regex Pattern: `^[\w\s+=,.@-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Errors and responses that you want Amazon Cognito APIs to return during authentication,
    /// account confirmation, and password recovery when the user doesn&apos;t exist in
    /// the user pool. When set to ENABLED and the user doesn&apos;t exist, authentication
    /// returns an error indicating either the username or password was incorrect.
    /// Account confirmation and password recovery return a response indicating a
    /// code was sent to a simulated destination. When set to LEGACY, those APIs
    /// return a UserNotFoundException exception if the user doesn&apos;t exist in the
    /// user pool.
    /// 
    /// Valid values include:
    /// 
    ///   - ENABLED - This prevents user existence-related errors.
    /// 
    ///   - LEGACY - This represents the early behavior of Amazon Cognito where
    ///     user existence related errors aren&apos;t prevented.
    /// 
    /// Defaults to LEGACY when you don&apos;t provide a value.
    /// </summary>
    [JsonPropertyName("preventUserExistenceErrors")]
    public string? PreventUserExistenceErrors { get; set; }

    /// <summary>
    /// The list of user attributes that you want your app client to have read access
    /// to. After your user authenticates in your app, their access token authorizes
    /// them to read their own attribute value for any attribute in this list. An
    /// example of this kind of activity is when your user selects a link to view
    /// their profile information. Your app makes a GetUser (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_GetUser.html)
    /// API request to retrieve and display your user&apos;s profile data.
    /// 
    /// When you don&apos;t specify the ReadAttributes for your app client, your app can
    /// read the values of email_verified, phone_number_verified, and the Standard
    /// attributes of your user pool. When your user pool app client has read access
    /// to these default attributes, ReadAttributes doesn&apos;t return any information.
    /// Amazon Cognito only populates ReadAttributes in the API response if you have
    /// specified your own custom set of read attributes.
    /// </summary>
    [JsonPropertyName("readAttributes")]
    public IList<string>? ReadAttributes { get; set; }

    /// <summary>
    /// The refresh token time limit. After this limit expires, your user can&apos;t use
    /// their refresh token. To specify the time unit for RefreshTokenValidity as
    /// seconds, minutes, hours, or days, set a TokenValidityUnits value in your
    /// API request.
    /// 
    /// For example, when you set RefreshTokenValidity as 10 andTokenValidityUnits
    /// as days, your user can refresh their sessionand retrieve new access and ID
    /// tokens for 10 days.
    /// 
    /// The default time unit for RefreshTokenValidity in an API request is days.
    /// You can&apos;t set RefreshTokenValidity to 0. If you do, Amazon Cognito overrides
    /// the value with the default value of 30 days. Valid range is displayed below
    /// in seconds.
    /// 
    /// If you don&apos;t specify otherwise in the configuration of your app client, your
    /// refreshtokens are valid for 30 days.
    /// </summary>
    [JsonPropertyName("refreshTokenValidity")]
    public long? RefreshTokenValidity { get; set; }

    /// <summary>
    /// A list of provider names for the identity providers (IdPs) that are supported
    /// on this client. The following are supported: COGNITO, Facebook, Google, SignInWithApple,
    /// and LoginWithAmazon. You can also specify the names that you configured for
    /// the SAML and OIDC IdPs in your user pool, for example MySAMLIdP or MyOIDCIdP.
    /// 
    /// This setting applies to providers that you can access with the hosted UI
    /// and OAuth 2.0 authorization server (https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-app-integration.html).
    /// The removal of COGNITO from this list doesn&apos;t prevent authentication operations
    /// for local users with the user pools API in an Amazon Web Services SDK. The
    /// only way to prevent API-based authentication is to block access with a WAF
    /// rule (https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-waf.html).
    /// </summary>
    [JsonPropertyName("supportedIdentityProviders")]
    public IList<string>? SupportedIdentityProviders { get; set; }

    /// <summary>
    /// The units in which the validity times are represented. The default unit for
    /// RefreshToken is days, and default for ID and access tokens are hours.
    /// </summary>
    [JsonPropertyName("tokenValidityUnits")]
    public V1alpha1UserPoolClientSpecTokenValidityUnits? TokenValidityUnits { get; set; }

    /// <summary>
    /// The user pool ID for the user pool where you want to create a user pool client.
    /// 
    /// Regex Pattern: `^[\w-]+_[0-9a-zA-Z]+$`
    /// </summary>
    [JsonPropertyName("userPoolID")]
    public string? UserPoolID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("userPoolRef")]
    public V1alpha1UserPoolClientSpecUserPoolRef? UserPoolRef { get; set; }

    /// <summary>
    /// The list of user attributes that you want your app client to have write access
    /// to. After your user authenticates in your app, their access token authorizes
    /// them to set or modify their own attribute value for any attribute in this
    /// list. An example of this kind of activity is when you present your user with
    /// a form to update their profile information and they change their last name.
    /// Your app then makes an UpdateUserAttributes (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserAttributes.html)
    /// API request and sets family_name to the new value.
    /// 
    /// When you don&apos;t specify the WriteAttributes for your app client, your app
    /// can write the values of the Standard attributes of your user pool. When your
    /// user pool has write access to these default attributes, WriteAttributes doesn&apos;t
    /// return any information. Amazon Cognito only populates WriteAttributes in
    /// the API response if you have specified your own custom set of write attributes.
    /// 
    /// If your app client allows users to sign in through an IdP, this array must
    /// include all attributes that you have mapped to IdP attributes. Amazon Cognito
    /// updates mapped attributes when users sign in to your application through
    /// an IdP. If your app client does not have write access to a mapped attribute,
    /// Amazon Cognito throws an error when it tries to update the attribute. For
    /// more information, see Specifying IdP Attribute Mappings for Your user pool
    /// (https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-specifying-attribute-mapping.html).
    /// </summary>
    [JsonPropertyName("writeAttributes")]
    public IList<string>? WriteAttributes { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolClientStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolClientStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>UserPoolClientStatus defines the observed state of UserPoolClient</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolClientStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1UserPoolClientStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1UserPoolClientStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time when the item was created. Amazon Cognito returns this
    /// timestamp in UNIX epoch time format. Your SDK might render the output in
    /// a human-readable format like ISO 8601 or a Java Date object.
    /// </summary>
    [JsonPropertyName("creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// The ID of the app client.
    /// 
    /// Regex Pattern: `^[\w+]+$`
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The date and time when the item was modified. Amazon Cognito returns this
    /// timestamp in UNIX epoch time format. Your SDK might render the output in
    /// a human-readable format like ISO 8601 or a Java Date object.
    /// </summary>
    [JsonPropertyName("lastModifiedDate")]
    public DateTime? LastModifiedDate { get; set; }
}

/// <summary>UserPoolClient is the Schema for the UserPoolClients API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1UserPoolClient : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1UserPoolClientSpec?>, IStatus<V1alpha1UserPoolClientStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "UserPoolClient";
    public const string KubeGroup = "cognitoidentityprovider.services.k8s.aws";
    public const string KubePluralName = "userpoolclients";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitoidentityprovider.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserPoolClient";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserPoolClientSpec defines the desired state of UserPoolClient.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1UserPoolClientSpec? Spec { get; set; }

    /// <summary>UserPoolClientStatus defines the observed state of UserPoolClient</summary>
    [JsonPropertyName("status")]
    public V1alpha1UserPoolClientStatus? Status { get; set; }
}