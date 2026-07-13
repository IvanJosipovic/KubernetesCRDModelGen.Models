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
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/preview/2023-05-01-preview/apimbackends.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230501previewBackendList : IKubernetesObject<V1ListMeta>, IItems<V20230501previewBackend>
{
    public const string KubeApiVersion = "v20230501preview";
    public const string KubeKind = "BackendList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20230501preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackendList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20230501previewBackend objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20230501previewBackend> Items { get; set; }
}

/// <summary>The failure http status code range</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendSpecCircuitBreakerRulesFailureConditionStatusCodeRanges
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
public partial class V20230501previewBackendSpecCircuitBreakerRulesFailureCondition
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
    public IList<V20230501previewBackendSpecCircuitBreakerRulesFailureConditionStatusCodeRanges>? StatusCodeRanges { get; set; }
}

/// <summary>Rule configuration to trip the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendSpecCircuitBreakerRules
{
    /// <summary>FailureCondition: The conditions for tripping the circuit breaker.</summary>
    [JsonPropertyName("failureCondition")]
    public V20230501previewBackendSpecCircuitBreakerRulesFailureCondition? FailureCondition { get; set; }

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
public partial class V20230501previewBackendSpecCircuitBreaker
{
    /// <summary>Rules: The rules for tripping the backend.</summary>
    [JsonPropertyName("rules")]
    public IList<V20230501previewBackendSpecCircuitBreakerRules>? Rules { get; set; }
}

/// <summary>Authorization: Authorization header authentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendSpecCredentialsAuthorization
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
public partial class V20230501previewBackendSpecCredentials
{
    /// <summary>Authorization: Authorization header authentication</summary>
    [JsonPropertyName("authorization")]
    public V20230501previewBackendSpecCredentialsAuthorization? Authorization { get; set; }

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
public partial class V20230501previewBackendSpecOperatorSpecConfigMapExpressions
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
public partial class V20230501previewBackendSpecOperatorSpecSecretExpressions
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
public partial class V20230501previewBackendSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20230501previewBackendSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20230501previewBackendSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Service resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendSpecOwner
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
public partial class V20230501previewBackendSpecPoolServicesReference
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
public partial class V20230501previewBackendSpecPoolServices
{
    /// <summary>Reference: The unique ARM id of the backend entity. The ARM id should refer to an already existing backend entity.</summary>
    [JsonPropertyName("reference")]
    public required V20230501previewBackendSpecPoolServicesReference Reference { get; set; }
}

/// <summary>Pool: Backend pool information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendSpecPool
{
    /// <summary>Services: The list of backend entities belonging to a pool.</summary>
    [JsonPropertyName("services")]
    public IList<V20230501previewBackendSpecPoolServices>? Services { get; set; }
}

/// <summary>Properties of server X509Names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendSpecPropertiesServiceFabricClusterServerX509Names
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
public partial class V20230501previewBackendSpecPropertiesServiceFabricCluster
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
    public IList<V20230501previewBackendSpecPropertiesServiceFabricClusterServerX509Names>? ServerX509Names { get; set; }
}

/// <summary>Properties: Backend Properties contract</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendSpecProperties
{
    /// <summary>ServiceFabricCluster: Backend Service Fabric Cluster Properties</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V20230501previewBackendSpecPropertiesServiceFabricCluster? ServiceFabricCluster { get; set; }
}

/// <summary>Protocol: Backend communication protocol. Required when backend type is &apos;Single&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20230501previewBackendSpecProtocolEnum>))]
public enum V20230501previewBackendSpecProtocolEnum
{
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "soap"), JsonStringEnumMemberName("soap")]
    Soap
}

/// <summary>Password: Password to connect to the WebProxy Server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendSpecProxyPassword
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
public partial class V20230501previewBackendSpecProxy
{
    /// <summary>Password: Password to connect to the WebProxy Server</summary>
    [JsonPropertyName("password")]
    public V20230501previewBackendSpecProxyPassword? Password { get; set; }

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
public partial class V20230501previewBackendSpecResourceReference
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
public partial class V20230501previewBackendSpecTls
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
[JsonConverter(typeof(JsonStringEnumConverter<V20230501previewBackendSpecTypeEnum>))]
public enum V20230501previewBackendSpecTypeEnum
{
    [EnumMember(Value = "Pool"), JsonStringEnumMemberName("Pool")]
    Pool,
    [EnumMember(Value = "Single"), JsonStringEnumMemberName("Single")]
    Single
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CircuitBreaker: Backend Circuit Breaker Configuration</summary>
    [JsonPropertyName("circuitBreaker")]
    public V20230501previewBackendSpecCircuitBreaker? CircuitBreaker { get; set; }

    /// <summary>Credentials: Backend Credentials Contract Properties</summary>
    [JsonPropertyName("credentials")]
    public V20230501previewBackendSpecCredentials? Credentials { get; set; }

    /// <summary>Description: Backend Description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20230501previewBackendSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Service resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20230501previewBackendSpecOwner Owner { get; set; }

    /// <summary>Pool: Backend pool information</summary>
    [JsonPropertyName("pool")]
    public V20230501previewBackendSpecPool? Pool { get; set; }

    /// <summary>Properties: Backend Properties contract</summary>
    [JsonPropertyName("properties")]
    public V20230501previewBackendSpecProperties? Properties { get; set; }

    /// <summary>Protocol: Backend communication protocol. Required when backend type is &apos;Single&apos;.</summary>
    [JsonPropertyName("protocol")]
    public V20230501previewBackendSpecProtocolEnum? Protocol { get; set; }

    /// <summary>Proxy: Backend gateway Contract Properties</summary>
    [JsonPropertyName("proxy")]
    public V20230501previewBackendSpecProxy? Proxy { get; set; }

    /// <summary>
    /// ResourceReference: Management Uri of the Resource in External System. This URL can be the Arm Resource Id of Logic Apps,
    /// Function Apps or API Apps.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20230501previewBackendSpecResourceReference? ResourceReference { get; set; }

    /// <summary>Title: Backend Title.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Tls: Backend TLS Properties</summary>
    [JsonPropertyName("tls")]
    public V20230501previewBackendSpecTls? Tls { get; set; }

    /// <summary>Type: Type of the backend. A backend can be either Single or Pool.</summary>
    [JsonPropertyName("type")]
    public V20230501previewBackendSpecTypeEnum? Type { get; set; }

    /// <summary>Url: Runtime Url of the Backend. Required when backend type is &apos;Single&apos;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The failure http status code range</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendStatusCircuitBreakerRulesFailureConditionStatusCodeRanges
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
public partial class V20230501previewBackendStatusCircuitBreakerRulesFailureCondition
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
    public IList<V20230501previewBackendStatusCircuitBreakerRulesFailureConditionStatusCodeRanges>? StatusCodeRanges { get; set; }
}

/// <summary>Rule configuration to trip the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendStatusCircuitBreakerRules
{
    /// <summary>FailureCondition: The conditions for tripping the circuit breaker.</summary>
    [JsonPropertyName("failureCondition")]
    public V20230501previewBackendStatusCircuitBreakerRulesFailureCondition? FailureCondition { get; set; }

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
public partial class V20230501previewBackendStatusCircuitBreaker
{
    /// <summary>Rules: The rules for tripping the backend.</summary>
    [JsonPropertyName("rules")]
    public IList<V20230501previewBackendStatusCircuitBreakerRules>? Rules { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendStatusConditions
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
public partial class V20230501previewBackendStatusCredentialsAuthorization
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
public partial class V20230501previewBackendStatusCredentials
{
    /// <summary>Authorization: Authorization header authentication</summary>
    [JsonPropertyName("authorization")]
    public V20230501previewBackendStatusCredentialsAuthorization? Authorization { get; set; }

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
public partial class V20230501previewBackendStatusPoolServices
{
    /// <summary>Id: The unique ARM id of the backend entity. The ARM id should refer to an already existing backend entity.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

/// <summary>Pool: Backend pool information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendStatusPool
{
    /// <summary>Services: The list of backend entities belonging to a pool.</summary>
    [JsonPropertyName("services")]
    public IList<V20230501previewBackendStatusPoolServices>? Services { get; set; }
}

/// <summary>Properties of server X509Names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendStatusPropertiesServiceFabricClusterServerX509Names
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
public partial class V20230501previewBackendStatusPropertiesServiceFabricCluster
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
    public IList<V20230501previewBackendStatusPropertiesServiceFabricClusterServerX509Names>? ServerX509Names { get; set; }
}

/// <summary>Properties: Backend Properties contract</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendStatusProperties
{
    /// <summary>ServiceFabricCluster: Backend Service Fabric Cluster Properties</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V20230501previewBackendStatusPropertiesServiceFabricCluster? ServiceFabricCluster { get; set; }
}

/// <summary>Proxy: Backend gateway Contract Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewBackendStatusProxy
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
public partial class V20230501previewBackendStatusTls
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
public partial class V20230501previewBackendStatus
{
    /// <summary>CircuitBreaker: Backend Circuit Breaker Configuration</summary>
    [JsonPropertyName("circuitBreaker")]
    public V20230501previewBackendStatusCircuitBreaker? CircuitBreaker { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20230501previewBackendStatusConditions>? Conditions { get; set; }

    /// <summary>Credentials: Backend Credentials Contract Properties</summary>
    [JsonPropertyName("credentials")]
    public V20230501previewBackendStatusCredentials? Credentials { get; set; }

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
    public V20230501previewBackendStatusPool? Pool { get; set; }

    /// <summary>Properties: Backend Properties contract</summary>
    [JsonPropertyName("properties")]
    public V20230501previewBackendStatusProperties? Properties { get; set; }

    /// <summary>PropertiesType: Type of the backend. A backend can be either Single or Pool.</summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>Protocol: Backend communication protocol. Required when backend type is &apos;Single&apos;.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Proxy: Backend gateway Contract Properties</summary>
    [JsonPropertyName("proxy")]
    public V20230501previewBackendStatusProxy? Proxy { get; set; }

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
    public V20230501previewBackendStatusTls? Tls { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Url: Runtime Url of the Backend. Required when backend type is &apos;Single&apos;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/preview/2023-05-01-preview/apimbackends.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230501previewBackend : IKubernetesObject<V1ObjectMeta>, ISpec<V20230501previewBackendSpec?>, IStatus<V20230501previewBackendStatus?>
{
    public const string KubeApiVersion = "v20230501preview";
    public const string KubeKind = "Backend";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20230501preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Backend";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20230501previewBackendSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20230501previewBackendStatus? Status { get; set; }
}