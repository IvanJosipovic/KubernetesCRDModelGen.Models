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
/// <summary>Method is the Schema for the Methods API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MethodList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Method>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MethodList";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "methods";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MethodList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Method objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Method> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodSpecAuthorizerRefFrom
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
public partial class V1alpha1MethodSpecAuthorizerRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1MethodSpecAuthorizerRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodSpecResourceRefFrom
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
public partial class V1alpha1MethodSpecResourceRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1MethodSpecResourceRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodSpecRestAPIRefFrom
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
public partial class V1alpha1MethodSpecRestAPIRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1MethodSpecRestAPIRefFrom? From { get; set; }
}

/// <summary>
/// MethodSpec defines the desired state of Method.
/// 
/// Represents a client-facing interface by which the client calls the API to
/// access back-end resources. A Method resource is integrated with an Integration
/// resource. Both consist of a request and one or more responses. The method
/// request takes the client input that is passed to the back end through the
/// integration request. A method response returns the output from the back end
/// to the client through an integration response. A method request is embodied
/// in a Method resource, whereas an integration request is embodied in an Integration
/// resource. On the other hand, a method response is represented by a MethodResponse
/// resource, whereas an integration response is represented by an IntegrationResponse
/// resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodSpec
{
    /// <summary>Specifies whether the method required a valid ApiKey.</summary>
    [JsonPropertyName("apiKeyRequired")]
    public bool? ApiKeyRequired { get; set; }

    /// <summary>
    /// A list of authorization scopes configured on the method. The scopes are used
    /// with a COGNITO_USER_POOLS authorizer to authorize the method invocation.
    /// The authorization works by matching the method scopes against the scopes
    /// parsed from the access token in the incoming request. The method invocation
    /// is authorized if any method scopes matches a claimed scope in the access
    /// token. Otherwise, the invocation is not authorized. When the method scope
    /// is configured, the client must provide an access token instead of an identity
    /// token for authorization purposes.
    /// </summary>
    [JsonPropertyName("authorizationScopes")]
    public IList<string>? AuthorizationScopes { get; set; }

    /// <summary>
    /// The method&apos;s authorization type. Valid values are NONE for open access, AWS_IAM
    /// for using AWS IAM permissions, CUSTOM for using a custom authorizer, or COGNITO_USER_POOLS
    /// for using a Cognito user pool.
    /// </summary>
    [JsonPropertyName("authorizationType")]
    public required string AuthorizationType { get; set; }

    /// <summary>
    /// Specifies the identifier of an Authorizer to use on this Method, if the type
    /// is CUSTOM or COGNITO_USER_POOLS. The authorizer identifier is generated by
    /// API Gateway when you created the authorizer.
    /// </summary>
    [JsonPropertyName("authorizerID")]
    public string? AuthorizerID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("authorizerRef")]
    public V1alpha1MethodSpecAuthorizerRef? AuthorizerRef { get; set; }

    /// <summary>Specifies the method request&apos;s HTTP method type.</summary>
    [JsonPropertyName("httpMethod")]
    public required string HttpMethod { get; set; }

    /// <summary>
    /// A human-friendly operation identifier for the method. For example, you can
    /// assign the operationName of ListPets for the GET /pets method in the PetStore
    /// example.
    /// </summary>
    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    /// <summary>
    /// Specifies the Model resources used for the request&apos;s content type. Request
    /// models are represented as a key/value map, with a content type as the key
    /// and a Model name as the value.
    /// </summary>
    [JsonPropertyName("requestModels")]
    public IDictionary<string, string>? RequestModels { get; set; }

    /// <summary>
    /// A key-value map defining required or optional method request parameters that
    /// can be accepted by API Gateway. A key defines a method request parameter
    /// name matching the pattern of method.request.{location}.{name}, where location
    /// is querystring, path, or header and name is a valid and unique parameter
    /// name. The value associated with the key is a Boolean flag indicating whether
    /// the parameter is required (true) or optional (false). The method request
    /// parameter names defined here are available in Integration to be mapped to
    /// integration request parameters or body-mapping templates.
    /// </summary>
    [JsonPropertyName("requestParameters")]
    public IDictionary<string, bool>? RequestParameters { get; set; }

    /// <summary>The identifier of a RequestValidator for validating the method request.</summary>
    [JsonPropertyName("requestValidatorID")]
    public string? RequestValidatorID { get; set; }

    /// <summary>The Resource identifier for the new Method resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("resourceRef")]
    public V1alpha1MethodSpecResourceRef? ResourceRef { get; set; }

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
    public V1alpha1MethodSpecRestAPIRef? RestAPIRef { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodStatusAckResourceMetadata
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
public partial class V1alpha1MethodStatusConditions
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

/// <summary>
/// Represents an integration response. The status code must map to an existing
/// MethodResponse, and parameters and templates can be used to transform the
/// back-end response.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodStatusMethodIntegrationIntegrationResponses
{
    [JsonPropertyName("contentHandling")]
    public string? ContentHandling { get; set; }

    [JsonPropertyName("responseParameters")]
    public IDictionary<string, string>? ResponseParameters { get; set; }

    [JsonPropertyName("responseTemplates")]
    public IDictionary<string, string>? ResponseTemplates { get; set; }

    [JsonPropertyName("selectionPattern")]
    public string? SelectionPattern { get; set; }

    /// <summary>The status code.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Specifies the TLS configuration for an integration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodStatusMethodIntegrationTlsConfig
{
    [JsonPropertyName("insecureSkipVerification")]
    public bool? InsecureSkipVerification { get; set; }
}

/// <summary>
/// Gets the method&apos;s integration responsible for passing the client-submitted
/// request to the back end and performing necessary transformations to make
/// the request compliant with the back end.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodStatusMethodIntegration
{
    [JsonPropertyName("cacheKeyParameters")]
    public IList<string>? CacheKeyParameters { get; set; }

    [JsonPropertyName("cacheNamespace")]
    public string? CacheNamespace { get; set; }

    [JsonPropertyName("connectionID")]
    public string? ConnectionID { get; set; }

    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    [JsonPropertyName("contentHandling")]
    public string? ContentHandling { get; set; }

    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    [JsonPropertyName("integrationResponses")]
    public IDictionary<string, V1alpha1MethodStatusMethodIntegrationIntegrationResponses>? IntegrationResponses { get; set; }

    [JsonPropertyName("integrationTarget")]
    public string? IntegrationTarget { get; set; }

    [JsonPropertyName("passthroughBehavior")]
    public string? PassthroughBehavior { get; set; }

    [JsonPropertyName("requestParameters")]
    public IDictionary<string, string>? RequestParameters { get; set; }

    [JsonPropertyName("requestTemplates")]
    public IDictionary<string, string>? RequestTemplates { get; set; }

    [JsonPropertyName("responseTransferMode")]
    public string? ResponseTransferMode { get; set; }

    [JsonPropertyName("timeoutInMillis")]
    public long? TimeoutInMillis { get; set; }

    /// <summary>Specifies the TLS configuration for an integration.</summary>
    [JsonPropertyName("tlsConfig")]
    public V1alpha1MethodStatusMethodIntegrationTlsConfig? TlsConfig { get; set; }

    /// <summary>
    /// The integration type. The valid value is HTTP for integrating an API method
    /// with an HTTP backend; AWS with any Amazon Web Services service endpoints;
    /// MOCK for testing without actually invoking the backend; HTTP_PROXY for integrating
    /// with the HTTP proxy integration; AWS_PROXY for integrating with the Lambda
    /// proxy integration.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Represents a method response of a given HTTP status code returned to the
/// client. The method response is passed from the back end through the associated
/// integration response that can be transformed using a mapping template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodStatusMethodResponses
{
    [JsonPropertyName("responseModels")]
    public IDictionary<string, string>? ResponseModels { get; set; }

    [JsonPropertyName("responseParameters")]
    public IDictionary<string, bool>? ResponseParameters { get; set; }

    /// <summary>The status code.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>MethodStatus defines the observed state of Method</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MethodStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1MethodStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MethodStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Gets the method&apos;s integration responsible for passing the client-submitted
    /// request to the back end and performing necessary transformations to make
    /// the request compliant with the back end.
    /// </summary>
    [JsonPropertyName("methodIntegration")]
    public V1alpha1MethodStatusMethodIntegration? MethodIntegration { get; set; }

    /// <summary>Gets a method response associated with a given HTTP status code.</summary>
    [JsonPropertyName("methodResponses")]
    public IDictionary<string, V1alpha1MethodStatusMethodResponses>? MethodResponses { get; set; }
}

/// <summary>Method is the Schema for the Methods API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Method : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MethodSpec?>, IStatus<V1alpha1MethodStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Method";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "methods";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Method";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// MethodSpec defines the desired state of Method.
    /// 
    /// Represents a client-facing interface by which the client calls the API to
    /// access back-end resources. A Method resource is integrated with an Integration
    /// resource. Both consist of a request and one or more responses. The method
    /// request takes the client input that is passed to the back end through the
    /// integration request. A method response returns the output from the back end
    /// to the client through an integration response. A method request is embodied
    /// in a Method resource, whereas an integration request is embodied in an Integration
    /// resource. On the other hand, a method response is represented by a MethodResponse
    /// resource, whereas an integration response is represented by an IntegrationResponse
    /// resource.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1MethodSpec? Spec { get; set; }

    /// <summary>MethodStatus defines the observed state of Method</summary>
    [JsonPropertyName("status")]
    public V1alpha1MethodStatus? Status { get; set; }
}