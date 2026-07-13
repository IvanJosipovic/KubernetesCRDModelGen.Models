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
/// <summary>Integration is the Schema for the Integrations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IntegrationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Integration>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IntegrationList";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "integrations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

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
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSpecCredentialsRefFrom
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
public partial class V1alpha1IntegrationSpecCredentialsRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1IntegrationSpecCredentialsRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSpecResourceRefFrom
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
public partial class V1alpha1IntegrationSpecResourceRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1IntegrationSpecResourceRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSpecRestAPIRefFrom
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
public partial class V1alpha1IntegrationSpecRestAPIRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1IntegrationSpecRestAPIRefFrom? From { get; set; }
}

/// <summary>Specifies the TLS configuration for an integration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSpecTlsConfig
{
    [JsonPropertyName("insecureSkipVerification")]
    public bool? InsecureSkipVerification { get; set; }
}

/// <summary>
/// IntegrationSpec defines the desired state of Integration.
/// 
/// Represents an HTTP, HTTP_PROXY, AWS, AWS_PROXY, or Mock integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSpec
{
    /// <summary>
    /// A list of request parameters whose values API Gateway caches. To be valid
    /// values for cacheKeyParameters, these parameters must also be specified for
    /// Method requestParameters.
    /// </summary>
    [JsonPropertyName("cacheKeyParameters")]
    public IList<string>? CacheKeyParameters { get; set; }

    /// <summary>
    /// Specifies a group of related cached parameters. By default, API Gateway uses
    /// the resource ID as the cacheNamespace. You can specify the same cacheNamespace
    /// across resources to return the same cached data for requests to different
    /// resources.
    /// </summary>
    [JsonPropertyName("cacheNamespace")]
    public string? CacheNamespace { get; set; }

    /// <summary>
    /// The ID of the VpcLink used for the integration. Specify this value only if
    /// you specify VPC_LINK as the connection type.
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
    /// The type of the network connection to the integration endpoint. The valid
    /// value is INTERNET for connections through the public routable internet or
    /// VPC_LINK for private connections between API Gateway and a network load balancer
    /// in a VPC. The default value is INTERNET.
    /// </summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>
    /// Specifies how to handle request payload content type conversions. Supported
    /// values are CONVERT_TO_BINARY and CONVERT_TO_TEXT, with the following behaviors:
    /// 
    /// If this property is not defined, the request payload will be passed through
    /// from the method request to integration request without modification, provided
    /// that the passthroughBehavior is configured to support payload pass-through.
    /// </summary>
    [JsonPropertyName("contentHandling")]
    public string? ContentHandling { get; set; }

    /// <summary>Specifies whether credentials are required for a put integration.</summary>
    [JsonPropertyName("credentials")]
    public string? Credentials { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("credentialsRef")]
    public V1alpha1IntegrationSpecCredentialsRef? CredentialsRef { get; set; }

    /// <summary>Specifies the HTTP method for the integration.</summary>
    [JsonPropertyName("httpMethod")]
    public required string HttpMethod { get; set; }

    /// <summary>The HTTP method for the integration.</summary>
    [JsonPropertyName("integrationHTTPMethod")]
    public string? IntegrationHTTPMethod { get; set; }

    /// <summary>The ALB or NLB listener to send the request to.</summary>
    [JsonPropertyName("integrationTarget")]
    public string? IntegrationTarget { get; set; }

    /// <summary>
    /// Specifies the pass-through behavior for incoming requests based on the Content-Type
    /// header in the request, and the available mapping templates specified as the
    /// requestTemplates property on the Integration resource. There are three valid
    /// values: WHEN_NO_MATCH, WHEN_NO_TEMPLATES, and NEVER.
    /// </summary>
    [JsonPropertyName("passthroughBehavior")]
    public string? PassthroughBehavior { get; set; }

    /// <summary>
    /// A key-value map specifying request parameters that are passed from the method
    /// request to the back end. The key is an integration request parameter name
    /// and the associated value is a method request parameter value or static value
    /// that must be enclosed within single quotes and pre-encoded as required by
    /// the back end. The method request parameter value must match the pattern of
    /// method.request.{location}.{name}, where location is querystring, path, or
    /// header and name must be a valid and unique method request parameter name.
    /// </summary>
    [JsonPropertyName("requestParameters")]
    public IDictionary<string, string>? RequestParameters { get; set; }

    /// <summary>
    /// Represents a map of Velocity templates that are applied on the request payload
    /// based on the value of the Content-Type header sent by the client. The content
    /// type value is the key in this map, and the template (as a String) is the
    /// value.
    /// </summary>
    [JsonPropertyName("requestTemplates")]
    public IDictionary<string, string>? RequestTemplates { get; set; }

    /// <summary>Specifies a put integration request&apos;s resource ID.</summary>
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
    public V1alpha1IntegrationSpecResourceRef? ResourceRef { get; set; }

    /// <summary>The response transfer mode of the integration.</summary>
    [JsonPropertyName("responseTransferMode")]
    public string? ResponseTransferMode { get; set; }

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
    public V1alpha1IntegrationSpecRestAPIRef? RestAPIRef { get; set; }

    /// <summary>
    /// Custom timeout between 50 and 29,000 milliseconds. The default value is 29,000
    /// milliseconds or 29 seconds. You can increase the default value to longer
    /// than 29 seconds for Regional or private APIs only.
    /// </summary>
    [JsonPropertyName("timeoutInMillis")]
    public long? TimeoutInMillis { get; set; }

    /// <summary>Specifies the TLS configuration for an integration.</summary>
    [JsonPropertyName("tlsConfig")]
    public V1alpha1IntegrationSpecTlsConfig? TlsConfig { get; set; }

    /// <summary>Specifies a put integration input&apos;s type.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// Specifies Uniform Resource Identifier (URI) of the integration endpoint.
    /// For HTTP or HTTP_PROXY integrations, the URI must be a fully formed, encoded
    /// HTTP(S) URL according to the RFC-3986 specification, for either standard
    /// integration, where connectionType is not VPC_LINK, or private integration,
    /// where connectionType is VPC_LINK. For a private HTTP integration, the URI
    /// is not used for routing. For AWS or AWS_PROXY integrations, the URI is of
    /// the form arn:aws:apigateway:{region}:{subdomain.service|service}:path|action/{service_api}.
    /// Here, {Region} is the API Gateway region (e.g., us-east-1); {service} is
    /// the name of the integrated Amazon Web Services service (e.g., s3); and {subdomain}
    /// is a designated subdomain supported by certain Amazon Web Services service
    /// for fast host-name lookup. action can be used for an Amazon Web Services
    /// service action-based API, using an Action={name}&amp;{p1}={v1}&amp;p2={v2}... query
    /// string. The ensuing {service_api} refers to a supported action {name} plus
    /// any required input parameters. Alternatively, path can be used for an Amazon
    /// Web Services service path-based API. The ensuing service_api refers to the
    /// path to an Amazon Web Services service resource, including the region of
    /// the integrated Amazon Web Services service, if applicable. For example, for
    /// integration with the S3 API of GetObject, the uri can be either arn:aws:apigateway:us-west-2:s3:action/GetObject&amp;Bucket={bucket}&amp;Key={key}
    /// or arn:aws:apigateway:us-west-2:s3:path/{bucket}/{key}.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
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

/// <summary>
/// Represents an integration response. The status code must map to an existing
/// MethodResponse, and parameters and templates can be used to transform the
/// back-end response.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationStatusIntegrationResponses
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
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1IntegrationStatusConditions>? Conditions { get; set; }

    /// <summary>Specifies the integration&apos;s responses.</summary>
    [JsonPropertyName("integrationResponses")]
    public IDictionary<string, V1alpha1IntegrationStatusIntegrationResponses>? IntegrationResponses { get; set; }
}

/// <summary>Integration is the Schema for the Integrations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Integration : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IntegrationSpec?>, IStatus<V1alpha1IntegrationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Integration";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "integrations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Integration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// IntegrationSpec defines the desired state of Integration.
    /// 
    /// Represents an HTTP, HTTP_PROXY, AWS, AWS_PROXY, or Mock integration.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1IntegrationSpec? Spec { get; set; }

    /// <summary>IntegrationStatus defines the observed state of Integration</summary>
    [JsonPropertyName("status")]
    public V1alpha1IntegrationStatus? Status { get; set; }
}