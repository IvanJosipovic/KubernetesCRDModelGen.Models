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
/// <summary>RestAPI is the Schema for the RestAPIS API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RestAPIList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RestAPI>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RestAPIList";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "restapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RestAPIList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RestAPI objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RestAPI> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RestAPISpecCloneFromRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RestAPISpecCloneFromRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RestAPISpecCloneFromRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RestAPISpecEndpointConfigurationVpcEndpointRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RestAPISpecEndpointConfigurationVpcEndpointRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RestAPISpecEndpointConfigurationVpcEndpointRefsFrom? From { get; set; }
}

/// <summary>
/// The endpoint configuration of this RestApi showing the endpoint types and
/// IP address types of the API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RestAPISpecEndpointConfiguration
{
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    [JsonPropertyName("vpcEndpointIDs")]
    public IList<string>? VpcEndpointIDs { get; set; }

    /// <summary>Reference field for VPCEndpointIDs</summary>
    [JsonPropertyName("vpcEndpointRefs")]
    public IList<V1alpha1RestAPISpecEndpointConfigurationVpcEndpointRefs>? VpcEndpointRefs { get; set; }
}

/// <summary>
/// RestApiSpec defines the desired state of RestApi.
/// 
/// Represents a REST API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RestAPISpec
{
    /// <summary>
    /// The source of the API key for metering requests according to a usage plan.
    /// Valid values are: HEADER to read the API key from the X-API-Key header of
    /// a request. AUTHORIZER to read the API key from the UsageIdentifierKey from
    /// a custom authorizer.
    /// </summary>
    [JsonPropertyName("apiKeySource")]
    public string? ApiKeySource { get; set; }

    /// <summary>
    /// The list of binary media types supported by the RestApi. By default, the
    /// RestApi supports only UTF-8-encoded text payloads.
    /// </summary>
    [JsonPropertyName("binaryMediaTypes")]
    public IList<string>? BinaryMediaTypes { get; set; }

    /// <summary>The ID of the RestApi that you want to clone from.</summary>
    [JsonPropertyName("cloneFrom")]
    public string? CloneFrom { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("cloneFromRef")]
    public V1alpha1RestAPISpecCloneFromRef? CloneFromRef { get; set; }

    /// <summary>The description of the RestApi.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies whether clients can invoke your API by using the default execute-api
    /// endpoint. By default, clients can invoke your API with the default https://{api_id}.execute-api.{region}.amazonaws.com
    /// endpoint. To require that clients use a custom domain name to invoke your
    /// API, disable the default endpoint
    /// </summary>
    [JsonPropertyName("disableExecuteAPIEndpoint")]
    public bool? DisableExecuteAPIEndpoint { get; set; }

    /// <summary>
    /// The endpoint access mode of the RestApi. Only available for RestApis that
    /// use security policies that start with SecurityPolicy_.
    /// </summary>
    [JsonPropertyName("endpointAccessMode")]
    public string? EndpointAccessMode { get; set; }

    /// <summary>
    /// The endpoint configuration of this RestApi showing the endpoint types and
    /// IP address types of the API.
    /// </summary>
    [JsonPropertyName("endpointConfiguration")]
    public V1alpha1RestAPISpecEndpointConfiguration? EndpointConfiguration { get; set; }

    /// <summary>
    /// A nullable integer that is used to enable compression (with non-negative
    /// between 0 and 10485760 (10M) bytes, inclusive) or disable compression (with
    /// a null value) on an API. When compression is enabled, compression or decompression
    /// is not applied on the payload if the payload size is smaller than this value.
    /// Setting it to zero allows compression for any payload size.
    /// </summary>
    [JsonPropertyName("minimumCompressionSize")]
    public long? MinimumCompressionSize { get; set; }

    /// <summary>The name of the RestApi.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A stringified JSON policy document that applies to this RestApi regardless
    /// of the caller and Method configuration.
    /// </summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>The Transport Layer Security (TLS) version + cipher suite for this RestApi.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>
    /// The key-value map of strings. The valid character set is [a-zA-Z+-=._:/].
    /// The tag key can be up to 128 characters and must not start with aws:. The
    /// tag value can be up to 256 characters.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A version identifier for the API.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RestAPIStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RestAPIStatusConditions
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

/// <summary>RestAPIStatus defines the observed state of RestAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RestAPIStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RestAPIStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The ApiStatus of the RestApi.</summary>
    [JsonPropertyName("apiStatus")]
    public string? ApiStatus { get; set; }

    /// <summary>
    /// The status message of the RestApi. When the status message is UPDATING you
    /// can still invoke it.
    /// </summary>
    [JsonPropertyName("apiStatusMessage")]
    public string? ApiStatusMessage { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RestAPIStatusConditions>? Conditions { get; set; }

    /// <summary>The timestamp when the API was created.</summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The API&apos;s identifier. This identifier is unique across all of your APIs in
    /// API Gateway.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The API&apos;s root resource ID.</summary>
    [JsonPropertyName("rootResourceID")]
    public string? RootResourceID { get; set; }

    /// <summary>
    /// The warning messages reported when failonwarnings is turned on during API
    /// import.
    /// </summary>
    [JsonPropertyName("warnings")]
    public IList<string>? Warnings { get; set; }
}

/// <summary>RestAPI is the Schema for the RestAPIS API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RestAPI : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RestAPISpec?>, IStatus<V1alpha1RestAPIStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RestAPI";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "restapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RestAPI";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// RestApiSpec defines the desired state of RestApi.
    /// 
    /// Represents a REST API.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1RestAPISpec? Spec { get; set; }

    /// <summary>RestAPIStatus defines the observed state of RestAPI</summary>
    [JsonPropertyName("status")]
    public V1alpha1RestAPIStatus? Status { get; set; }
}