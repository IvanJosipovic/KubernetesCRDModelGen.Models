#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimbackends.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501BackendList : IKubernetesObject<V1ListMeta>, IItems<V20240501Backend>
{
    public const string KubeApiVersion = "v20240501";
    public const string KubeKind = "BackendList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackendList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240501Backend objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240501Backend> Items { get; set; }
}

/// <summary>The failure http status code range</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecCircuitBreakerRulesFailureConditionStatusCodeRanges
{
    /// <summary>Max: The maximum http status code.</summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary>Min: The minimum http status code.</summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>FailureCondition: The conditions for tripping the circuit breaker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecCircuitBreakerRulesFailureCondition
{
    /// <summary>Count: The threshold for opening the circuit.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>ErrorReasons: The error reasons which are considered as failure.</summary>
    [JsonPropertyName("errorReasons")]
    public IList<string>? ErrorReasons { get; set; }

    /// <summary>Interval: The interval during which the failures are counted.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Percentage: The threshold for opening the circuit.</summary>
    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }

    /// <summary>StatusCodeRanges: The status code ranges which are considered as failure.</summary>
    [JsonPropertyName("statusCodeRanges")]
    public IList<V20240501BackendSpecCircuitBreakerRulesFailureConditionStatusCodeRanges>? StatusCodeRanges { get; set; }
}

/// <summary>Rule configuration to trip the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecCircuitBreakerRules
{
    /// <summary>AcceptRetryAfter: flag to accept Retry-After header from the backend.</summary>
    [JsonPropertyName("acceptRetryAfter")]
    public bool? AcceptRetryAfter { get; set; }

    /// <summary>FailureCondition: The conditions for tripping the circuit breaker.</summary>
    [JsonPropertyName("failureCondition")]
    public V20240501BackendSpecCircuitBreakerRulesFailureCondition? FailureCondition { get; set; }

    /// <summary>Name: The rule name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>TripDuration: The duration for which the circuit will be tripped.</summary>
    [JsonPropertyName("tripDuration")]
    public string? TripDuration { get; set; }
}

/// <summary>CircuitBreaker: Backend Circuit Breaker Configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecCircuitBreaker
{
    /// <summary>Rules: The rules for tripping the backend.</summary>
    [JsonPropertyName("rules")]
    public IList<V20240501BackendSpecCircuitBreakerRules>? Rules { get; set; }
}

/// <summary>Authorization: Authorization header authentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecCredentialsAuthorization
{
    /// <summary>Parameter: Authentication Parameter value.</summary>
    [JsonPropertyName("parameter")]
    public required string Parameter { get; set; }

    /// <summary>Scheme: Authentication Scheme name.</summary>
    [JsonPropertyName("scheme")]
    public required string Scheme { get; set; }
}

/// <summary>Credentials: Backend Credentials Contract Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecCredentials
{
    /// <summary>Authorization: Authorization header authentication</summary>
    [JsonPropertyName("authorization")]
    public V20240501BackendSpecCredentialsAuthorization? Authorization { get; set; }

    /// <summary>Certificate: List of Client Certificate Thumbprints. Will be ignored if certificatesIds are provided.</summary>
    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    /// <summary>CertificateIds: List of Client Certificate Ids.</summary>
    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    /// <summary>Header: Header Parameter description.</summary>
    [JsonPropertyName("header")]
    public IDictionary<string, IList<string>>? Header { get; set; }

    /// <summary>Query: Query Parameter description.</summary>
    [JsonPropertyName("query")]
    public IDictionary<string, IList<string>>? Query { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20240501BackendSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20240501BackendSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Service resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: The unique ARM id of the backend entity. The ARM id should refer to an already existing backend entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecPoolServicesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Backend pool service information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecPoolServices
{
    /// <summary>
    /// Priority: The priority of the backend entity in the backend pool. Must be between 0 and 100. It can be also null if the
    /// value not specified.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Reference: The unique ARM id of the backend entity. The ARM id should refer to an already existing backend entity.</summary>
    [JsonPropertyName("reference")]
    public required V20240501BackendSpecPoolServicesReference Reference { get; set; }

    /// <summary>
    /// Weight: The weight of the backend entity in the backend pool. Must be between 0 and 100. It can be also null if the
    /// value not specified.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Pool: Backend pool information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecPool
{
    /// <summary>Services: The list of backend entities belonging to a pool.</summary>
    [JsonPropertyName("services")]
    public IList<V20240501BackendSpecPoolServices>? Services { get; set; }
}

/// <summary>Properties of server X509Names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecPropertiesServiceFabricClusterServerX509Names
{
    /// <summary>IssuerCertificateThumbprint: Thumbprint for the Issuer of the Certificate.</summary>
    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    /// <summary>Name: Common Name of the Certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ServiceFabricCluster: Backend Service Fabric Cluster Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecPropertiesServiceFabricCluster
{
    /// <summary>ClientCertificateId: The client certificate id for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>
    /// ClientCertificatethumbprint: The client certificate thumbprint for the management endpoint. Will be ignored if
    /// certificatesIds are provided
    /// </summary>
    [JsonPropertyName("clientCertificatethumbprint")]
    public string? ClientCertificatethumbprint { get; set; }

    /// <summary>ManagementEndpoints: The cluster management endpoint.</summary>
    [JsonPropertyName("managementEndpoints")]
    public required IList<string> ManagementEndpoints { get; set; }

    /// <summary>MaxPartitionResolutionRetries: Maximum number of retries while attempting resolve the partition.</summary>
    [JsonPropertyName("maxPartitionResolutionRetries")]
    public int? MaxPartitionResolutionRetries { get; set; }

    /// <summary>ServerCertificateThumbprints: Thumbprints of certificates cluster management service uses for tls communication</summary>
    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    /// <summary>ServerX509Names: Server X509 Certificate Names Collection</summary>
    [JsonPropertyName("serverX509Names")]
    public IList<V20240501BackendSpecPropertiesServiceFabricClusterServerX509Names>? ServerX509Names { get; set; }
}

/// <summary>Properties: Backend Properties contract</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecProperties
{
    /// <summary>ServiceFabricCluster: Backend Service Fabric Cluster Properties</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V20240501BackendSpecPropertiesServiceFabricCluster? ServiceFabricCluster { get; set; }
}

/// <summary>Protocol: Backend communication protocol. Required when backend type is &apos;Single&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501BackendSpecProtocolEnum>))]
public enum V20240501BackendSpecProtocolEnum
{
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "soap"), JsonStringEnumMemberName("soap")]
    Soap
}

/// <summary>Password: Password to connect to the WebProxy Server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecProxyPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Proxy: Backend gateway Contract Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecProxy
{
    /// <summary>Password: Password to connect to the WebProxy Server</summary>
    [JsonPropertyName("password")]
    public V20240501BackendSpecProxyPassword? Password { get; set; }

    /// <summary>
    /// Url: WebProxy Server AbsoluteUri property which includes the entire URI stored in the Uri instance, including all
    /// fragments and query strings.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>Username: Username to connect to the WebProxy server</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// ResourceReference: Management Uri of the Resource in External System. This URL can be the Arm Resource Id of Logic Apps,
/// Function Apps or API Apps.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Tls: Backend TLS Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpecTls
{
    /// <summary>
    /// ValidateCertificateChain: Flag indicating whether SSL certificate chain validation should be done when using self-signed
    /// certificates for this backend host.
    /// </summary>
    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    /// <summary>
    /// ValidateCertificateName: Flag indicating whether SSL certificate name validation should be done when using self-signed
    /// certificates for this backend host.
    /// </summary>
    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
}

/// <summary>Type: Type of the backend. A backend can be either Single or Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501BackendSpecTypeEnum>))]
public enum V20240501BackendSpecTypeEnum
{
    [EnumMember(Value = "Pool"), JsonStringEnumMemberName("Pool")]
    Pool,
    [EnumMember(Value = "Single"), JsonStringEnumMemberName("Single")]
    Single
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CircuitBreaker: Backend Circuit Breaker Configuration</summary>
    [JsonPropertyName("circuitBreaker")]
    public V20240501BackendSpecCircuitBreaker? CircuitBreaker { get; set; }

    /// <summary>Credentials: Backend Credentials Contract Properties</summary>
    [JsonPropertyName("credentials")]
    public V20240501BackendSpecCredentials? Credentials { get; set; }

    /// <summary>Description: Backend Description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240501BackendSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Service resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240501BackendSpecOwner Owner { get; set; }

    /// <summary>Pool: Backend pool information</summary>
    [JsonPropertyName("pool")]
    public V20240501BackendSpecPool? Pool { get; set; }

    /// <summary>Properties: Backend Properties contract</summary>
    [JsonPropertyName("properties")]
    public V20240501BackendSpecProperties? Properties { get; set; }

    /// <summary>Protocol: Backend communication protocol. Required when backend type is &apos;Single&apos;.</summary>
    [JsonPropertyName("protocol")]
    public V20240501BackendSpecProtocolEnum? Protocol { get; set; }

    /// <summary>Proxy: Backend gateway Contract Properties</summary>
    [JsonPropertyName("proxy")]
    public V20240501BackendSpecProxy? Proxy { get; set; }

    /// <summary>
    /// ResourceReference: Management Uri of the Resource in External System. This URL can be the Arm Resource Id of Logic Apps,
    /// Function Apps or API Apps.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20240501BackendSpecResourceReference? ResourceReference { get; set; }

    /// <summary>Title: Backend Title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Tls: Backend TLS Properties</summary>
    [JsonPropertyName("tls")]
    public V20240501BackendSpecTls? Tls { get; set; }

    /// <summary>Type: Type of the backend. A backend can be either Single or Pool.</summary>
    [JsonPropertyName("type")]
    public V20240501BackendSpecTypeEnum? Type { get; set; }

    /// <summary>Url: Runtime Url of the Backend. Required when backend type is &apos;Single&apos;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The failure http status code range</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusCircuitBreakerRulesFailureConditionStatusCodeRanges
{
    /// <summary>Max: The maximum http status code.</summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary>Min: The minimum http status code.</summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>FailureCondition: The conditions for tripping the circuit breaker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusCircuitBreakerRulesFailureCondition
{
    /// <summary>Count: The threshold for opening the circuit.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>ErrorReasons: The error reasons which are considered as failure.</summary>
    [JsonPropertyName("errorReasons")]
    public IList<string>? ErrorReasons { get; set; }

    /// <summary>Interval: The interval during which the failures are counted.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Percentage: The threshold for opening the circuit.</summary>
    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }

    /// <summary>StatusCodeRanges: The status code ranges which are considered as failure.</summary>
    [JsonPropertyName("statusCodeRanges")]
    public IList<V20240501BackendStatusCircuitBreakerRulesFailureConditionStatusCodeRanges>? StatusCodeRanges { get; set; }
}

/// <summary>Rule configuration to trip the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusCircuitBreakerRules
{
    /// <summary>AcceptRetryAfter: flag to accept Retry-After header from the backend.</summary>
    [JsonPropertyName("acceptRetryAfter")]
    public bool? AcceptRetryAfter { get; set; }

    /// <summary>FailureCondition: The conditions for tripping the circuit breaker.</summary>
    [JsonPropertyName("failureCondition")]
    public V20240501BackendStatusCircuitBreakerRulesFailureCondition? FailureCondition { get; set; }

    /// <summary>Name: The rule name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>TripDuration: The duration for which the circuit will be tripped.</summary>
    [JsonPropertyName("tripDuration")]
    public string? TripDuration { get; set; }
}

/// <summary>CircuitBreaker: Backend Circuit Breaker Configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusCircuitBreaker
{
    /// <summary>Rules: The rules for tripping the backend.</summary>
    [JsonPropertyName("rules")]
    public IList<V20240501BackendStatusCircuitBreakerRules>? Rules { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Authorization: Authorization header authentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusCredentialsAuthorization
{
    /// <summary>Parameter: Authentication Parameter value.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>Scheme: Authentication Scheme name.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Credentials: Backend Credentials Contract Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusCredentials
{
    /// <summary>Authorization: Authorization header authentication</summary>
    [JsonPropertyName("authorization")]
    public V20240501BackendStatusCredentialsAuthorization? Authorization { get; set; }

    /// <summary>Certificate: List of Client Certificate Thumbprints. Will be ignored if certificatesIds are provided.</summary>
    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    /// <summary>CertificateIds: List of Client Certificate Ids.</summary>
    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    /// <summary>Header: Header Parameter description.</summary>
    [JsonPropertyName("header")]
    public IDictionary<string, IList<string>>? Header { get; set; }

    /// <summary>Query: Query Parameter description.</summary>
    [JsonPropertyName("query")]
    public IDictionary<string, IList<string>>? Query { get; set; }
}

/// <summary>Backend pool service information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusPoolServices
{
    /// <summary>Id: The unique ARM id of the backend entity. The ARM id should refer to an already existing backend entity.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Priority: The priority of the backend entity in the backend pool. Must be between 0 and 100. It can be also null if the
    /// value not specified.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Weight: The weight of the backend entity in the backend pool. Must be between 0 and 100. It can be also null if the
    /// value not specified.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Pool: Backend pool information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusPool
{
    /// <summary>Services: The list of backend entities belonging to a pool.</summary>
    [JsonPropertyName("services")]
    public IList<V20240501BackendStatusPoolServices>? Services { get; set; }
}

/// <summary>Properties of server X509Names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusPropertiesServiceFabricClusterServerX509Names
{
    /// <summary>IssuerCertificateThumbprint: Thumbprint for the Issuer of the Certificate.</summary>
    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    /// <summary>Name: Common Name of the Certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ServiceFabricCluster: Backend Service Fabric Cluster Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusPropertiesServiceFabricCluster
{
    /// <summary>ClientCertificateId: The client certificate id for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>
    /// ClientCertificatethumbprint: The client certificate thumbprint for the management endpoint. Will be ignored if
    /// certificatesIds are provided
    /// </summary>
    [JsonPropertyName("clientCertificatethumbprint")]
    public string? ClientCertificatethumbprint { get; set; }

    /// <summary>ManagementEndpoints: The cluster management endpoint.</summary>
    [JsonPropertyName("managementEndpoints")]
    public IList<string>? ManagementEndpoints { get; set; }

    /// <summary>MaxPartitionResolutionRetries: Maximum number of retries while attempting resolve the partition.</summary>
    [JsonPropertyName("maxPartitionResolutionRetries")]
    public int? MaxPartitionResolutionRetries { get; set; }

    /// <summary>ServerCertificateThumbprints: Thumbprints of certificates cluster management service uses for tls communication</summary>
    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    /// <summary>ServerX509Names: Server X509 Certificate Names Collection</summary>
    [JsonPropertyName("serverX509Names")]
    public IList<V20240501BackendStatusPropertiesServiceFabricClusterServerX509Names>? ServerX509Names { get; set; }
}

/// <summary>Properties: Backend Properties contract</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusProperties
{
    /// <summary>ServiceFabricCluster: Backend Service Fabric Cluster Properties</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V20240501BackendStatusPropertiesServiceFabricCluster? ServiceFabricCluster { get; set; }
}

/// <summary>Proxy: Backend gateway Contract Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusProxy
{
    /// <summary>
    /// Url: WebProxy Server AbsoluteUri property which includes the entire URI stored in the Uri instance, including all
    /// fragments and query strings.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username: Username to connect to the WebProxy server</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Tls: Backend TLS Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatusTls
{
    /// <summary>
    /// ValidateCertificateChain: Flag indicating whether SSL certificate chain validation should be done when using self-signed
    /// certificates for this backend host.
    /// </summary>
    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    /// <summary>
    /// ValidateCertificateName: Flag indicating whether SSL certificate name validation should be done when using self-signed
    /// certificates for this backend host.
    /// </summary>
    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501BackendStatus
{
    /// <summary>CircuitBreaker: Backend Circuit Breaker Configuration</summary>
    [JsonPropertyName("circuitBreaker")]
    public V20240501BackendStatusCircuitBreaker? CircuitBreaker { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20240501BackendStatusConditions>? Conditions { get; set; }

    /// <summary>Credentials: Backend Credentials Contract Properties</summary>
    [JsonPropertyName("credentials")]
    public V20240501BackendStatusCredentials? Credentials { get; set; }

    /// <summary>Description: Backend Description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Pool: Backend pool information</summary>
    [JsonPropertyName("pool")]
    public V20240501BackendStatusPool? Pool { get; set; }

    /// <summary>Properties: Backend Properties contract</summary>
    [JsonPropertyName("properties")]
    public V20240501BackendStatusProperties? Properties { get; set; }

    /// <summary>PropertiesType: Type of the backend. A backend can be either Single or Pool.</summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>Protocol: Backend communication protocol. Required when backend type is &apos;Single&apos;.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Proxy: Backend gateway Contract Properties</summary>
    [JsonPropertyName("proxy")]
    public V20240501BackendStatusProxy? Proxy { get; set; }

    /// <summary>
    /// ResourceId: Management Uri of the Resource in External System. This URL can be the Arm Resource Id of Logic Apps,
    /// Function Apps or API Apps.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Title: Backend Title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Tls: Backend TLS Properties</summary>
    [JsonPropertyName("tls")]
    public V20240501BackendStatusTls? Tls { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Url: Runtime Url of the Backend. Required when backend type is &apos;Single&apos;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimbackends.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501Backend : IKubernetesObject<V1ObjectMeta>, ISpec<V20240501BackendSpec?>, IStatus<V20240501BackendStatus?>
{
    public const string KubeApiVersion = "v20240501";
    public const string KubeKind = "Backend";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Backend";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20240501BackendSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20240501BackendStatus? Status { get; set; }
}