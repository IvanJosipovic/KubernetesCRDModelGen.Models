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
/// <summary>API is the Schema for the APIS API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1API>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIList";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "apis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1API objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1API> Items { get; set; }
}

/// <summary>
/// A CORS configuration. Supported only for HTTP APIs. See Configuring CORS
/// (https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-cors.html)
/// for more information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpecCorsConfiguration
{
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Represents a collection of allowed headers. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Represents a collection of methods. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>Represents a collection of origins. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>Represents a collection of allowed headers. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>An integer with a value between -1 and 86400. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("maxAge")]
    public long? MaxAge { get; set; }
}

/// <summary>
/// ApiSpec defines the desired state of Api.
/// 
/// Represents an API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APISpec
{
    /// <summary>
    /// An API key selection expression. Supported only for WebSocket APIs. See API
    /// Key Selection Expressions (https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-apikey-selection-expressions).
    /// </summary>
    [JsonPropertyName("apiKeySelectionExpression")]
    public string? ApiKeySelectionExpression { get; set; }

    /// <summary>
    /// Specifies how to interpret the base path of the API during import. Valid
    /// values are ignore, prepend, and split. The default value is ignore. To learn
    /// more, see Set the OpenAPI basePath Property (https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-import-api-basePath.html).
    /// Supported only for HTTP APIs.
    /// </summary>
    [JsonPropertyName("basepath")]
    public string? Basepath { get; set; }

    /// <summary>The OpenAPI definition. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// A CORS configuration. Supported only for HTTP APIs. See Configuring CORS
    /// (https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-cors.html)
    /// for more information.
    /// </summary>
    [JsonPropertyName("corsConfiguration")]
    public V1alpha1APISpecCorsConfiguration? CorsConfiguration { get; set; }

    /// <summary>
    /// This property is part of quick create. It specifies the credentials required
    /// for the integration, if any. For a Lambda integration, three options are
    /// available. To specify an IAM Role for API Gateway to assume, use the role&apos;s
    /// Amazon Resource Name (ARN). To require that the caller&apos;s identity be passed
    /// through from the request, specify arn:aws:iam::*:user/*. To use resource-based
    /// permissions on supported AWS services, specify null. Currently, this property
    /// is not used for HTTP integrations. Supported only for HTTP APIs.
    /// </summary>
    [JsonPropertyName("credentialsARN")]
    public string? CredentialsARN { get; set; }

    /// <summary>The description of the API.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies whether clients can invoke your API by using the default execute-api
    /// endpoint. By default, clients can invoke your API with the default https://{api_id}.execute-api.{region}.amazonaws.com
    /// endpoint. To require that clients use a custom domain name to invoke your
    /// API, disable the default endpoint.
    /// </summary>
    [JsonPropertyName("disableExecuteAPIEndpoint")]
    public bool? DisableExecuteAPIEndpoint { get; set; }

    /// <summary>
    /// Avoid validating models when creating a deployment. Supported only for WebSocket
    /// APIs.
    /// </summary>
    [JsonPropertyName("disableSchemaValidation")]
    public bool? DisableSchemaValidation { get; set; }

    /// <summary>
    /// Specifies whether to rollback the API creation when a warning is encountered.
    /// By default, API creation continues if a warning is encountered.
    /// </summary>
    [JsonPropertyName("failOnWarnings")]
    public bool? FailOnWarnings { get; set; }

    /// <summary>The name of the API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The API protocol.</summary>
    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }

    /// <summary>
    /// This property is part of quick create. If you don&apos;t specify a routeKey, a
    /// default route of $default is created. The $default route acts as a catch-all
    /// for any request made to your API, for a particular stage. The $default route
    /// key can&apos;t be modified. You can add routes after creating the API, and you
    /// can update the route keys of additional routes. Supported only for HTTP APIs.
    /// </summary>
    [JsonPropertyName("routeKey")]
    public string? RouteKey { get; set; }

    /// <summary>
    /// The route selection expression for the API. For HTTP APIs, the routeSelectionExpression
    /// must be ${request.method} ${request.path}. If not provided, this will be
    /// the default for HTTP APIs. This property is required for WebSocket APIs.
    /// </summary>
    [JsonPropertyName("routeSelectionExpression")]
    public string? RouteSelectionExpression { get; set; }

    /// <summary>The collection of tags. Each tag element is associated with a given resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// This property is part of quick create. Quick create produces an API with
    /// an integration, a default catch-all route, and a default stage which is configured
    /// to automatically deploy changes. For HTTP integrations, specify a fully qualified
    /// URL. For Lambda integrations, specify a function ARN. The type of the integration
    /// will be HTTP_PROXY or AWS_PROXY, respectively. Supported only for HTTP APIs.
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>A version identifier for the API.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIStatusAckResourceMetadata
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
public partial class V1alpha1APIStatusConditions
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

/// <summary>APIStatus defines the observed state of API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1APIStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The URI of the API, of the form {api-id}.execute-api.{region}.amazonaws.com.
    /// The stage name is typically appended to this URI to form a complete path
    /// to a deployed API stage.
    /// </summary>
    [JsonPropertyName("apiEndpoint")]
    public string? ApiEndpoint { get; set; }

    /// <summary>
    /// Specifies whether an API is managed by API Gateway. You can&apos;t update or delete
    /// a managed API by using API Gateway. A managed API can be deleted only through
    /// the tooling or service that created it.
    /// </summary>
    [JsonPropertyName("apiGatewayManaged")]
    public bool? ApiGatewayManaged { get; set; }

    /// <summary>The API ID.</summary>
    [JsonPropertyName("apiID")]
    public string? ApiID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIStatusConditions>? Conditions { get; set; }

    /// <summary>The timestamp when the API was created.</summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The validation information during API import. This may include particular
    /// properties of your OpenAPI definition which are ignored during import. Supported
    /// only for HTTP APIs.
    /// </summary>
    [JsonPropertyName("importInfo")]
    public IList<string>? ImportInfo { get; set; }

    /// <summary>
    /// The warning messages reported when failonwarnings is turned on during API
    /// import.
    /// </summary>
    [JsonPropertyName("warnings")]
    public IList<string>? Warnings { get; set; }
}

/// <summary>API is the Schema for the APIS API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1API : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APISpec?>, IStatus<V1alpha1APIStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "API";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "apis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "API";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ApiSpec defines the desired state of Api.
    /// 
    /// Represents an API.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1APISpec? Spec { get; set; }

    /// <summary>APIStatus defines the observed state of API</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIStatus? Status { get; set; }
}