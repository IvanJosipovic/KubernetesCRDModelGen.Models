#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigateway.services.k8s.aws;
/// <summary>Authorizer is the Schema for the Authorizers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthorizerList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Authorizer>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthorizerList";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "authorizers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

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
public partial class V1alpha1AuthorizerSpecAuthorizerCredentialsRefFrom
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
public partial class V1alpha1AuthorizerSpecAuthorizerCredentialsRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AuthorizerSpecAuthorizerCredentialsRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthorizerSpecProviderRefsFrom
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
public partial class V1alpha1AuthorizerSpecProviderRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AuthorizerSpecProviderRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthorizerSpecRestAPIRefFrom
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
public partial class V1alpha1AuthorizerSpecRestAPIRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AuthorizerSpecRestAPIRefFrom? From { get; set; }
}

/// <summary>
/// AuthorizerSpec defines the desired state of Authorizer.
/// 
/// Represents an authorization layer for methods. If enabled on a method, API
/// Gateway will activate the authorizer when a client calls the method.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthorizerSpec
{
    /// <summary>
    /// Optional customer-defined field, used in OpenAPI imports and exports without
    /// functional impact.
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// Specifies the required credentials as an IAM role for API Gateway to invoke
    /// the authorizer. To specify an IAM role for API Gateway to assume, use the
    /// role&apos;s Amazon Resource Name (ARN). To use resource-based permissions on the
    /// Lambda function, specify null.
    /// </summary>
    [JsonPropertyName("authorizerCredentials")]
    public string? AuthorizerCredentials { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("authorizerCredentialsRef")]
    public V1alpha1AuthorizerSpecAuthorizerCredentialsRef? AuthorizerCredentialsRef { get; set; }

    /// <summary>
    /// The TTL in seconds of cached authorizer results. If it equals 0, authorization
    /// caching is disabled. If it is greater than 0, API Gateway will cache authorizer
    /// responses. If this field is not set, the default value is 300. The maximum
    /// value is 3600, or 1 hour.
    /// </summary>
    [JsonPropertyName("authorizerResultTTLInSeconds")]
    public long? AuthorizerResultTTLInSeconds { get; set; }

    /// <summary>
    /// Specifies the authorizer&apos;s Uniform Resource Identifier (URI). For TOKEN or
    /// REQUEST authorizers, this must be a well-formed Lambda function URI, for
    /// example, arn:aws:apigateway:us-west-2:lambda:path/2015-03-31/functions/arn:aws:lambda:us-west-2:{account_id}:function:{lambda_function_name}/invocations.
    /// In general, the URI has this form arn:aws:apigateway:{region}:lambda:path/{service_api},
    /// where {region} is the same as the region hosting the Lambda function, path
    /// indicates that the remaining substring in the URI should be treated as the
    /// path to the resource, including the initial /. For Lambda functions, this
    /// is usually of the form /2015-03-31/functions/[FunctionARN]/invocations.
    /// </summary>
    [JsonPropertyName("authorizerURI")]
    public string? AuthorizerURI { get; set; }

    /// <summary>
    /// The identity source for which authorization is requested. For a TOKEN or
    /// COGNITO_USER_POOLS authorizer, this is required and specifies the request
    /// header mapping expression for the custom header holding the authorization
    /// token submitted by the client. For example, if the token header name is Auth,
    /// the header mapping expression is method.request.header.Auth. For the REQUEST
    /// authorizer, this is required when authorization caching is enabled. The value
    /// is a comma-separated string of one or more mapping expressions of the specified
    /// request parameters. For example, if an Auth header, a Name query string parameter
    /// are defined as identity sources, this value is method.request.header.Auth,
    /// method.request.querystring.Name. These parameters will be used to derive
    /// the authorization caching key and to perform runtime validation of the REQUEST
    /// authorizer by verifying all of the identity-related request parameters are
    /// present, not null and non-empty. Only when this is true does the authorizer
    /// invoke the authorizer Lambda function, otherwise, it returns a 401 Unauthorized
    /// response without calling the Lambda function. The valid value is a string
    /// of comma-separated mapping expressions of the specified request parameters.
    /// When the authorization caching is not enabled, this property is optional.
    /// </summary>
    [JsonPropertyName("identitySource")]
    public string? IdentitySource { get; set; }

    /// <summary>
    /// A validation expression for the incoming identity token. For TOKEN authorizers,
    /// this value is a regular expression. For COGNITO_USER_POOLS authorizers, API
    /// Gateway will match the aud field of the incoming token from the client against
    /// the specified regular expression. It will invoke the authorizer&apos;s Lambda
    /// function when there is a match. Otherwise, it will return a 401 Unauthorized
    /// response without calling the Lambda function. The validation expression does
    /// not apply to the REQUEST authorizer.
    /// </summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }

    /// <summary>The name of the authorizer.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A list of the Amazon Cognito user pool ARNs for the COGNITO_USER_POOLS authorizer.
    /// Each element is of this format: arn:aws:cognito-idp:{region}:{account_id}:userpool/{user_pool_id}.
    /// For a TOKEN or REQUEST authorizer, this is not defined.
    /// </summary>
    [JsonPropertyName("providerARNs")]
    public IList<string>? ProviderARNs { get; set; }

    [JsonPropertyName("providerRefs")]
    public IList<V1alpha1AuthorizerSpecProviderRefs>? ProviderRefs { get; set; }

    /// <summary>The string identifier of the associated RestApi.</summary>
    [JsonPropertyName("restAPIID")]
    public string? RestAPIID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("restAPIRef")]
    public V1alpha1AuthorizerSpecRestAPIRef? RestAPIRef { get; set; }

    /// <summary>
    /// The authorizer type. Valid values are TOKEN for a Lambda function using a
    /// single authorization token submitted in a custom header, REQUEST for a Lambda
    /// function using incoming request parameters, and COGNITO_USER_POOLS for using
    /// an Amazon Cognito user pool.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
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

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AuthorizerStatusConditions>? Conditions { get; set; }

    /// <summary>The identifier for the authorizer resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Authorizer is the Schema for the Authorizers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Authorizer : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AuthorizerSpec?>, IStatus<V1alpha1AuthorizerStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Authorizer";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "authorizers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Authorizer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// AuthorizerSpec defines the desired state of Authorizer.
    /// 
    /// Represents an authorization layer for methods. If enabled on a method, API
    /// Gateway will activate the authorizer when a client calls the method.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1AuthorizerSpec? Spec { get; set; }

    /// <summary>AuthorizerStatus defines the observed state of Authorizer</summary>
    [JsonPropertyName("status")]
    public V1alpha1AuthorizerStatus? Status { get; set; }
}