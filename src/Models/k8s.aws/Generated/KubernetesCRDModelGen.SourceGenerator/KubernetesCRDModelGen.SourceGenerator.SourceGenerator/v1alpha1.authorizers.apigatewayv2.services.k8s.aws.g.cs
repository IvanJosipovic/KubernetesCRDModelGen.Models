#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigatewayv2.services.k8s.aws;
/// <summary>Authorizer is the Schema for the Authorizers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthorizerList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Authorizer>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthorizerList";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "authorizers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthorizerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Authorizer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Authorizer> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthorizerSpecApiRefFrom
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
public partial class V1alpha1AuthorizerSpecApiRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AuthorizerSpecApiRefFrom? From { get; set; }
}

/// <summary>
/// Represents the configuration of a JWT authorizer. Required for the JWT authorizer
/// type. Supported only for HTTP APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthorizerSpecJwtConfiguration
{
    [JsonPropertyName("audience")]
    public IList<string>? Audience { get; set; }

    /// <summary>A string representation of a URI with a length between [1-2048].</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>
/// AuthorizerSpec defines the desired state of Authorizer.
/// 
/// Represents an authorizer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthorizerSpec
{
    /// <summary>The API identifier.</summary>
    [JsonPropertyName("apiID")]
    public string? ApiID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("apiRef")]
    public V1alpha1AuthorizerSpecApiRef? ApiRef { get; set; }

    /// <summary>
    /// Specifies the required credentials as an IAM role for API Gateway to invoke
    /// the authorizer. To specify an IAM role for API Gateway to assume, use the
    /// role&apos;s Amazon Resource Name (ARN). To use resource-based permissions on the
    /// Lambda function, don&apos;t specify this parameter. Supported only for REQUEST
    /// authorizers.
    /// </summary>
    [JsonPropertyName("authorizerCredentialsARN")]
    public string? AuthorizerCredentialsARN { get; set; }

    /// <summary>
    /// Specifies the format of the payload sent to an HTTP API Lambda authorizer.
    /// Required for HTTP API Lambda authorizers. Supported values are 1.0 and 2.0.
    /// To learn more, see Working with AWS Lambda authorizers for HTTP APIs (https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-lambda-authorizer.html).
    /// </summary>
    [JsonPropertyName("authorizerPayloadFormatVersion")]
    public string? AuthorizerPayloadFormatVersion { get; set; }

    /// <summary>
    /// The time to live (TTL) for cached authorizer results, in seconds. If it equals
    /// 0, authorization caching is disabled. If it is greater than 0, API Gateway
    /// caches authorizer responses. The maximum value is 3600, or 1 hour. Supported
    /// only for HTTP API Lambda authorizers.
    /// </summary>
    [JsonPropertyName("authorizerResultTTLInSeconds")]
    public long? AuthorizerResultTTLInSeconds { get; set; }

    /// <summary>
    /// The authorizer type. Specify REQUEST for a Lambda function using incoming
    /// request parameters. Specify JWT to use JSON Web Tokens (supported only for
    /// HTTP APIs).
    /// </summary>
    [JsonPropertyName("authorizerType")]
    public required string AuthorizerType { get; set; }

    /// <summary>
    /// The authorizer&apos;s Uniform Resource Identifier (URI). For REQUEST authorizers,
    /// this must be a well-formed Lambda function URI, for example, arn:aws:apigateway:us-west-2:lambda:path/2015-03-31/functions/arn:aws:lambda:us-west-2:{account_id}:function:{lambda_function_name}/invocations.
    /// In general, the URI has this form: arn:aws:apigateway:{region}:lambda:path/{service_api}
    /// , where {region} is the same as the region hosting the Lambda function, path
    /// indicates that the remaining substring in the URI should be treated as the
    /// path to the resource, including the initial /. For Lambda functions, this
    /// is usually of the form /2015-03-31/functions/[FunctionARN]/invocations. Supported
    /// only for REQUEST authorizers.
    /// </summary>
    [JsonPropertyName("authorizerURI")]
    public string? AuthorizerURI { get; set; }

    /// <summary>
    /// Specifies whether a Lambda authorizer returns a response in a simple format.
    /// By default, a Lambda authorizer must return an IAM policy. If enabled, the
    /// Lambda authorizer can return a boolean value instead of an IAM policy. Supported
    /// only for HTTP APIs. To learn more, see Working with AWS Lambda authorizers
    /// for HTTP APIs (https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-lambda-authorizer.html)
    /// </summary>
    [JsonPropertyName("enableSimpleResponses")]
    public bool? EnableSimpleResponses { get; set; }

    /// <summary>
    /// The identity source for which authorization is requested.
    /// 
    /// For a REQUEST authorizer, this is optional. The value is a set of one or
    /// more mapping expressions of the specified request parameters. The identity
    /// source can be headers, query string parameters, stage variables, and context
    /// parameters. For example, if an Auth header and a Name query string parameter
    /// are defined as identity sources, this value is route.request.header.Auth,
    /// route.request.querystring.Name for WebSocket APIs. For HTTP APIs, use selection
    /// expressions prefixed with $, for example, $request.header.Auth, $request.querystring.Name.
    /// These parameters are used to perform runtime validation for Lambda-based
    /// authorizers by verifying all of the identity-related request parameters are
    /// present in the request, not null, and non-empty. Only when this is true does
    /// the authorizer invoke the authorizer Lambda function. Otherwise, it returns
    /// a 401 Unauthorized response without calling the Lambda function. For HTTP
    /// APIs, identity sources are also used as the cache key when caching is enabled.
    /// To learn more, see Working with AWS Lambda authorizers for HTTP APIs (https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-lambda-authorizer.html).
    /// 
    /// For JWT, a single entry that specifies where to extract the JSON Web Token
    /// (JWT) from inbound requests. Currently only header-based and query parameter-based
    /// selections are supported, for example $request.header.Authorization.
    /// </summary>
    [JsonPropertyName("identitySource")]
    public required IList<string> IdentitySource { get; set; }

    /// <summary>This parameter is not used.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }

    /// <summary>
    /// Represents the configuration of a JWT authorizer. Required for the JWT authorizer
    /// type. Supported only for HTTP APIs.
    /// </summary>
    [JsonPropertyName("jwtConfiguration")]
    public V1alpha1AuthorizerSpecJwtConfiguration? JwtConfiguration { get; set; }

    /// <summary>The name of the authorizer.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthorizerStatusAckResourceMetadata
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
public partial class V1alpha1AuthorizerStatusConditions
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

/// <summary>AuthorizerStatus defines the observed state of Authorizer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthorizerStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1AuthorizerStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The authorizer identifier.</summary>
    [JsonPropertyName("authorizerID")]
    public string? AuthorizerID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AuthorizerStatusConditions>? Conditions { get; set; }
}

/// <summary>Authorizer is the Schema for the Authorizers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Authorizer : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AuthorizerSpec?>, IStatus<V1alpha1AuthorizerStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Authorizer";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "authorizers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Authorizer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// AuthorizerSpec defines the desired state of Authorizer.
    /// 
    /// Represents an authorizer.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1AuthorizerSpec? Spec { get; set; }

    /// <summary>AuthorizerStatus defines the observed state of Authorizer</summary>
    [JsonPropertyName("status")]
    public V1alpha1AuthorizerStatus? Status { get; set; }
}