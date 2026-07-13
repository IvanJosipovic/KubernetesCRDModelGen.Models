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
/// <summary>Integration is the Schema for the Integrations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IntegrationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Integration>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IntegrationList";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "integrations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IntegrationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Integration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Integration> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSpecApiRefFrom
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
public partial class V1alpha1IntegrationSpecApiRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1IntegrationSpecApiRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSpecConnectionRefFrom
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
public partial class V1alpha1IntegrationSpecConnectionRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1IntegrationSpecConnectionRefFrom? From { get; set; }
}

/// <summary>
/// The TLS configuration for a private integration. If you specify a TLS configuration,
/// private integration traffic uses the HTTPS protocol. Supported only for HTTP
/// APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSpecTlsConfig
{
    /// <summary>A string with a length between [1-512].</summary>
    [JsonPropertyName("serverNameToVerify")]
    public string? ServerNameToVerify { get; set; }
}

/// <summary>
/// IntegrationSpec defines the desired state of Integration.
/// 
/// Represents an integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSpec
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
    public V1alpha1IntegrationSpecApiRef? ApiRef { get; set; }

    /// <summary>
    /// The ID of the VPC link for a private integration. Supported only for HTTP
    /// APIs.
    /// </summary>
    [JsonPropertyName("connectionID")]
    public string? ConnectionID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("connectionRef")]
    public V1alpha1IntegrationSpecConnectionRef? ConnectionRef { get; set; }

    /// <summary>
    /// The type of the network connection to the integration endpoint. Specify INTERNET
    /// for connections through the public routable internet or VPC_LINK for private
    /// connections between API Gateway and resources in a VPC. The default value
    /// is INTERNET.
    /// </summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>
    /// Supported only for WebSocket APIs. Specifies how to handle response payload
    /// content type conversions. Supported values are CONVERT_TO_BINARY and CONVERT_TO_TEXT,
    /// with the following behaviors:
    /// 
    /// CONVERT_TO_BINARY: Converts a response payload from a Base64-encoded string
    /// to the corresponding binary blob.
    /// 
    /// CONVERT_TO_TEXT: Converts a response payload from a binary blob to a Base64-encoded
    /// string.
    /// 
    /// If this property is not defined, the response payload will be passed through
    /// from the integration response to the route response or method response without
    /// modification.
    /// </summary>
    [JsonPropertyName("contentHandlingStrategy")]
    public string? ContentHandlingStrategy { get; set; }

    /// <summary>
    /// Specifies the credentials required for the integration, if any. For AWS integrations,
    /// three options are available. To specify an IAM Role for API Gateway to assume,
    /// use the role&apos;s Amazon Resource Name (ARN). To require that the caller&apos;s identity
    /// be passed through from the request, specify the string arn:aws:iam::*:user/*.
    /// To use resource-based permissions on supported AWS services, specify null.
    /// </summary>
    [JsonPropertyName("credentialsARN")]
    public string? CredentialsARN { get; set; }

    /// <summary>The description of the integration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the integration&apos;s HTTP method type.</summary>
    [JsonPropertyName("integrationMethod")]
    public string? IntegrationMethod { get; set; }

    /// <summary>
    /// Supported only for HTTP API AWS_PROXY integrations. Specifies the AWS service
    /// action to invoke. To learn more, see Integration subtype reference (https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-develop-integrations-aws-services-reference.html).
    /// </summary>
    [JsonPropertyName("integrationSubtype")]
    public string? IntegrationSubtype { get; set; }

    /// <summary>
    /// The integration type of an integration. One of the following:
    /// 
    /// AWS: for integrating the route or method request with an AWS service action,
    /// including the Lambda function-invoking action. With the Lambda function-invoking
    /// action, this is referred to as the Lambda custom integration. With any other
    /// AWS service action, this is known as AWS integration. Supported only for
    /// WebSocket APIs.
    /// 
    /// AWS_PROXY: for integrating the route or method request with a Lambda function
    /// or other AWS service action. This integration is also referred to as a Lambda
    /// proxy integration.
    /// 
    /// HTTP: for integrating the route or method request with an HTTP endpoint.
    /// This integration is also referred to as the HTTP custom integration. Supported
    /// only for WebSocket APIs.
    /// 
    /// HTTP_PROXY: for integrating the route or method request with an HTTP endpoint,
    /// with the client request passed through as-is. This is also referred to as
    /// HTTP proxy integration. For HTTP API private integrations, use an HTTP_PROXY
    /// integration.
    /// 
    /// MOCK: for integrating the route or method request with API Gateway as a &quot;loopback&quot;
    /// endpoint without invoking any backend. Supported only for WebSocket APIs.
    /// </summary>
    [JsonPropertyName("integrationType")]
    public required string IntegrationType { get; set; }

    /// <summary>
    /// For a Lambda integration, specify the URI of a Lambda function.
    /// 
    /// For an HTTP integration, specify a fully-qualified URL.
    /// 
    /// For an HTTP API private integration, specify the ARN of an Application Load
    /// Balancer listener, Network Load Balancer listener, or AWS Cloud Map service.
    /// If you specify the ARN of an AWS Cloud Map service, API Gateway uses DiscoverInstances
    /// to identify resources. You can use query parameters to target specific resources.
    /// To learn more, see DiscoverInstances (https://docs.aws.amazon.com/cloud-map/latest/api/API_DiscoverInstances.html).
    /// For private integrations, all resources must be owned by the same AWS account.
    /// </summary>
    [JsonPropertyName("integrationURI")]
    public string? IntegrationURI { get; set; }

    /// <summary>
    /// Specifies the pass-through behavior for incoming requests based on the Content-Type
    /// header in the request, and the available mapping templates specified as the
    /// requestTemplates property on the Integration resource. There are three valid
    /// values: WHEN_NO_MATCH, WHEN_NO_TEMPLATES, and NEVER. Supported only for WebSocket
    /// APIs.
    /// 
    /// WHEN_NO_MATCH passes the request body for unmapped content types through
    /// to the integration backend without transformation.
    /// 
    /// NEVER rejects unmapped content types with an HTTP 415 Unsupported Media Type
    /// response.
    /// 
    /// WHEN_NO_TEMPLATES allows pass-through when the integration has no content
    /// types mapped to templates. However, if there is at least one content type
    /// defined, unmapped content types will be rejected with the same HTTP 415 Unsupported
    /// Media Type response.
    /// </summary>
    [JsonPropertyName("passthroughBehavior")]
    public string? PassthroughBehavior { get; set; }

    /// <summary>
    /// Specifies the format of the payload sent to an integration. Required for
    /// HTTP APIs.
    /// </summary>
    [JsonPropertyName("payloadFormatVersion")]
    public string? PayloadFormatVersion { get; set; }

    /// <summary>
    /// For WebSocket APIs, a key-value map specifying request parameters that are
    /// passed from the method request to the backend. The key is an integration
    /// request parameter name and the associated value is a method request parameter
    /// value or static value that must be enclosed within single quotes and pre-encoded
    /// as required by the backend. The method request parameter value must match
    /// the pattern of method.request.{location}.{name} , where {location} is querystring,
    /// path, or header; and {name} must be a valid and unique method request parameter
    /// name.
    /// 
    /// For HTTP API integrations with a specified integrationSubtype, request parameters
    /// are a key-value map specifying parameters that are passed to AWS_PROXY integrations.
    /// You can provide static values, or map request data, stage variables, or context
    /// variables that are evaluated at runtime. To learn more, see Working with
    /// AWS service integrations for HTTP APIs (https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-develop-integrations-aws-services.html).
    /// 
    /// For HTTP API integrations without a specified integrationSubtype request
    /// parameters are a key-value map specifying how to transform HTTP requests
    /// before sending them to the backend. The key should follow the pattern &lt;action&gt;:&lt;header|querystring|path&gt;.&lt;location&gt;
    /// where action can be append, overwrite or remove. For values, you can provide
    /// static values, or map request data, stage variables, or context variables
    /// that are evaluated at runtime. To learn more, see Transforming API requests
    /// and responses (https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-parameter-mapping.html).
    /// </summary>
    [JsonPropertyName("requestParameters")]
    public IDictionary<string, string>? RequestParameters { get; set; }

    /// <summary>
    /// Represents a map of Velocity templates that are applied on the request payload
    /// based on the value of the Content-Type header sent by the client. The content
    /// type value is the key in this map, and the template (as a String) is the
    /// value. Supported only for WebSocket APIs.
    /// </summary>
    [JsonPropertyName("requestTemplates")]
    public IDictionary<string, string>? RequestTemplates { get; set; }

    /// <summary>
    /// Supported only for HTTP APIs. You use response parameters to transform the
    /// HTTP response from a backend integration before returning the response to
    /// clients. Specify a key-value map from a selection key to response parameters.
    /// The selection key must be a valid HTTP status code within the range of 200-599.
    /// Response parameters are a key-value map. The key must match pattern &lt;action&gt;:&lt;header&gt;.&lt;location&gt;
    /// or overwrite.statuscode. The action can be append, overwrite or remove. The
    /// value can be a static value, or map to response data, stage variables, or
    /// context variables that are evaluated at runtime. To learn more, see Transforming
    /// API requests and responses (https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-parameter-mapping.html).
    /// </summary>
    [JsonPropertyName("responseParameters")]
    public IDictionary<string, IDictionary<string, string>>? ResponseParameters { get; set; }

    /// <summary>The template selection expression for the integration.</summary>
    [JsonPropertyName("templateSelectionExpression")]
    public string? TemplateSelectionExpression { get; set; }

    /// <summary>
    /// Custom timeout between 50 and 29,000 milliseconds for WebSocket APIs and
    /// between 50 and 30,000 milliseconds for HTTP APIs. The default timeout is
    /// 29 seconds for WebSocket APIs and 30 seconds for HTTP APIs.
    /// </summary>
    [JsonPropertyName("timeoutInMillis")]
    public long? TimeoutInMillis { get; set; }

    /// <summary>
    /// The TLS configuration for a private integration. If you specify a TLS configuration,
    /// private integration traffic uses the HTTPS protocol. Supported only for HTTP
    /// APIs.
    /// </summary>
    [JsonPropertyName("tlsConfig")]
    public V1alpha1IntegrationSpecTlsConfig? TlsConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationStatusAckResourceMetadata
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
public partial class V1alpha1IntegrationStatusConditions
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

/// <summary>IntegrationStatus defines the observed state of Integration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1IntegrationStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// Specifies whether an integration is managed by API Gateway. If you created
    /// an API using using quick create, the resulting integration is managed by
    /// API Gateway. You can update a managed integration, but you can&apos;t delete it.
    /// </summary>
    [JsonPropertyName("apiGatewayManaged")]
    public bool? ApiGatewayManaged { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1IntegrationStatusConditions>? Conditions { get; set; }

    /// <summary>Represents the identifier of an integration.</summary>
    [JsonPropertyName("integrationID")]
    public string? IntegrationID { get; set; }

    /// <summary>
    /// The integration response selection expression for the integration. Supported
    /// only for WebSocket APIs. See Integration Response Selection Expressions (https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-integration-response-selection-expressions).
    /// </summary>
    [JsonPropertyName("integrationResponseSelectionExpression")]
    public string? IntegrationResponseSelectionExpression { get; set; }
}

/// <summary>Integration is the Schema for the Integrations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Integration : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IntegrationSpec?>, IStatus<V1alpha1IntegrationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Integration";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "integrations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Integration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// IntegrationSpec defines the desired state of Integration.
    /// 
    /// Represents an integration.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1IntegrationSpec? Spec { get; set; }

    /// <summary>IntegrationStatus defines the observed state of Integration</summary>
    [JsonPropertyName("status")]
    public V1alpha1IntegrationStatus? Status { get; set; }
}