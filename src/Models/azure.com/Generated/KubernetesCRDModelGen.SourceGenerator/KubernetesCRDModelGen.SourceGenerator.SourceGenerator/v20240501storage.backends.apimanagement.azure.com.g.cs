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
/// Storage version of v20240501.Backend
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimbackends.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501storageBackendList : IKubernetesObject<V1ListMeta>, IItems<V20240501storageBackend>
{
    public const string KubeApiVersion = "v20240501storage";
    public const string KubeKind = "BackendList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackendList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240501storageBackend objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240501storageBackend> Items { get; set; }
}

/// <summary>
/// Storage version of v20240501.FailureStatusCodeRange
/// The failure http status code range
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecCircuitBreakerRulesFailureConditionStatusCodeRanges
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>
/// Storage version of v20240501.CircuitBreakerFailureCondition
/// The trip conditions of the circuit breaker
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecCircuitBreakerRulesFailureCondition
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("errorReasons")]
    public IList<string>? ErrorReasons { get; set; }

    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }

    [JsonPropertyName("statusCodeRanges")]
    public IList<V20240501storageBackendSpecCircuitBreakerRulesFailureConditionStatusCodeRanges>? StatusCodeRanges { get; set; }
}

/// <summary>
/// Storage version of v20240501.CircuitBreakerRule
/// Rule configuration to trip the backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecCircuitBreakerRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("acceptRetryAfter")]
    public bool? AcceptRetryAfter { get; set; }

    /// <summary>
    /// Storage version of v20240501.CircuitBreakerFailureCondition
    /// The trip conditions of the circuit breaker
    /// </summary>
    [JsonPropertyName("failureCondition")]
    public V20240501storageBackendSpecCircuitBreakerRulesFailureCondition? FailureCondition { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tripDuration")]
    public string? TripDuration { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendCircuitBreaker
/// The configuration of the backend circuit breaker
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecCircuitBreaker
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<V20240501storageBackendSpecCircuitBreakerRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendAuthorizationHeaderCredentials
/// Authorization header information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecCredentialsAuthorization
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendCredentialsContract
/// Details of the Credentials used to connect to Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecCredentials
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendAuthorizationHeaderCredentials
    /// Authorization header information.
    /// </summary>
    [JsonPropertyName("authorization")]
    public V20240501storageBackendSpecCredentialsAuthorization? Authorization { get; set; }

    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    [JsonPropertyName("header")]
    public IDictionary<string, IList<string>>? Header { get; set; }

    [JsonPropertyName("query")]
    public IDictionary<string, IList<string>>? Query { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecOperatorSpecSecretExpressions
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
/// Storage version of v20240501.BackendOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20240501storageBackendSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20240501storageBackendSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Service resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: The unique ARM id of the backend entity. The ARM id should refer to an already existing backend entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecPoolServicesReference
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

/// <summary>
/// Storage version of v20240501.BackendPoolItem
/// Backend pool service information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecPoolServices
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Reference: The unique ARM id of the backend entity. The ARM id should refer to an already existing backend entity.</summary>
    [JsonPropertyName("reference")]
    public required V20240501storageBackendSpecPoolServicesReference Reference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendPool
/// Backend pool information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecPool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("services")]
    public IList<V20240501storageBackendSpecPoolServices>? Services { get; set; }
}

/// <summary>
/// Storage version of v20240501.X509CertificateName
/// Properties of server X509Names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecPropertiesServiceFabricClusterServerX509Names
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendServiceFabricClusterProperties
/// Properties of the Service Fabric Type Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecPropertiesServiceFabricCluster
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    [JsonPropertyName("clientCertificatethumbprint")]
    public string? ClientCertificatethumbprint { get; set; }

    [JsonPropertyName("managementEndpoints")]
    public IList<string>? ManagementEndpoints { get; set; }

    [JsonPropertyName("maxPartitionResolutionRetries")]
    public int? MaxPartitionResolutionRetries { get; set; }

    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    [JsonPropertyName("serverX509Names")]
    public IList<V20240501storageBackendSpecPropertiesServiceFabricClusterServerX509Names>? ServerX509Names { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendProperties
/// Properties specific to the Backend Type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendServiceFabricClusterProperties
    /// Properties of the Service Fabric Type Backend.
    /// </summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V20240501storageBackendSpecPropertiesServiceFabricCluster? ServiceFabricCluster { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecProxyPassword
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

/// <summary>
/// Storage version of v20240501.BackendProxyContract
/// Details of the Backend WebProxy Server to use in the Request to Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecProxy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("password")]
    public V20240501storageBackendSpecProxyPassword? Password { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// ResourceReference: Management Uri of the Resource in External System. This URL can be the Arm Resource Id of Logic Apps,
/// Function Apps or API Apps.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecResourceReference
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

/// <summary>
/// Storage version of v20240501.BackendTlsProperties
/// Properties controlling TLS Certificate Validation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpecTls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
}

/// <summary>Storage version of v20240501.Backend_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendCircuitBreaker
    /// The configuration of the backend circuit breaker
    /// </summary>
    [JsonPropertyName("circuitBreaker")]
    public V20240501storageBackendSpecCircuitBreaker? CircuitBreaker { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendCredentialsContract
    /// Details of the Credentials used to connect to Backend.
    /// </summary>
    [JsonPropertyName("credentials")]
    public V20240501storageBackendSpecCredentials? Credentials { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240501storageBackendSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Service resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240501storageBackendSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendPool
    /// Backend pool information
    /// </summary>
    [JsonPropertyName("pool")]
    public V20240501storageBackendSpecPool? Pool { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendProperties
    /// Properties specific to the Backend Type.
    /// </summary>
    [JsonPropertyName("properties")]
    public V20240501storageBackendSpecProperties? Properties { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendProxyContract
    /// Details of the Backend WebProxy Server to use in the Request to Backend.
    /// </summary>
    [JsonPropertyName("proxy")]
    public V20240501storageBackendSpecProxy? Proxy { get; set; }

    /// <summary>
    /// ResourceReference: Management Uri of the Resource in External System. This URL can be the Arm Resource Id of Logic Apps,
    /// Function Apps or API Apps.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20240501storageBackendSpecResourceReference? ResourceReference { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendTlsProperties
    /// Properties controlling TLS Certificate Validation.
    /// </summary>
    [JsonPropertyName("tls")]
    public V20240501storageBackendSpecTls? Tls { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v20240501.FailureStatusCodeRange_STATUS
/// The failure http status code range
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusCircuitBreakerRulesFailureConditionStatusCodeRanges
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>
/// Storage version of v20240501.CircuitBreakerFailureCondition_STATUS
/// The trip conditions of the circuit breaker
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusCircuitBreakerRulesFailureCondition
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("errorReasons")]
    public IList<string>? ErrorReasons { get; set; }

    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }

    [JsonPropertyName("statusCodeRanges")]
    public IList<V20240501storageBackendStatusCircuitBreakerRulesFailureConditionStatusCodeRanges>? StatusCodeRanges { get; set; }
}

/// <summary>
/// Storage version of v20240501.CircuitBreakerRule_STATUS
/// Rule configuration to trip the backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusCircuitBreakerRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("acceptRetryAfter")]
    public bool? AcceptRetryAfter { get; set; }

    /// <summary>
    /// Storage version of v20240501.CircuitBreakerFailureCondition_STATUS
    /// The trip conditions of the circuit breaker
    /// </summary>
    [JsonPropertyName("failureCondition")]
    public V20240501storageBackendStatusCircuitBreakerRulesFailureCondition? FailureCondition { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tripDuration")]
    public string? TripDuration { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendCircuitBreaker_STATUS
/// The configuration of the backend circuit breaker
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusCircuitBreaker
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<V20240501storageBackendStatusCircuitBreakerRules>? Rules { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusConditions
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

/// <summary>
/// Storage version of v20240501.BackendAuthorizationHeaderCredentials_STATUS
/// Authorization header information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusCredentialsAuthorization
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendCredentialsContract_STATUS
/// Details of the Credentials used to connect to Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusCredentials
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendAuthorizationHeaderCredentials_STATUS
    /// Authorization header information.
    /// </summary>
    [JsonPropertyName("authorization")]
    public V20240501storageBackendStatusCredentialsAuthorization? Authorization { get; set; }

    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    [JsonPropertyName("header")]
    public IDictionary<string, IList<string>>? Header { get; set; }

    [JsonPropertyName("query")]
    public IDictionary<string, IList<string>>? Query { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendPoolItem_STATUS
/// Backend pool service information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusPoolServices
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendPool_STATUS
/// Backend pool information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusPool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("services")]
    public IList<V20240501storageBackendStatusPoolServices>? Services { get; set; }
}

/// <summary>
/// Storage version of v20240501.X509CertificateName_STATUS
/// Properties of server X509Names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusPropertiesServiceFabricClusterServerX509Names
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendServiceFabricClusterProperties_STATUS
/// Properties of the Service Fabric Type Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusPropertiesServiceFabricCluster
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    [JsonPropertyName("clientCertificatethumbprint")]
    public string? ClientCertificatethumbprint { get; set; }

    [JsonPropertyName("managementEndpoints")]
    public IList<string>? ManagementEndpoints { get; set; }

    [JsonPropertyName("maxPartitionResolutionRetries")]
    public int? MaxPartitionResolutionRetries { get; set; }

    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    [JsonPropertyName("serverX509Names")]
    public IList<V20240501storageBackendStatusPropertiesServiceFabricClusterServerX509Names>? ServerX509Names { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendProperties_STATUS
/// Properties specific to the Backend Type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendServiceFabricClusterProperties_STATUS
    /// Properties of the Service Fabric Type Backend.
    /// </summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V20240501storageBackendStatusPropertiesServiceFabricCluster? ServiceFabricCluster { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendProxyContract_STATUS
/// Details of the Backend WebProxy Server to use in the Request to Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusProxy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Storage version of v20240501.BackendTlsProperties_STATUS
/// Properties controlling TLS Certificate Validation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatusTls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
}

/// <summary>Storage version of v20240501.Backend_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageBackendStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendCircuitBreaker_STATUS
    /// The configuration of the backend circuit breaker
    /// </summary>
    [JsonPropertyName("circuitBreaker")]
    public V20240501storageBackendStatusCircuitBreaker? CircuitBreaker { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20240501storageBackendStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendCredentialsContract_STATUS
    /// Details of the Credentials used to connect to Backend.
    /// </summary>
    [JsonPropertyName("credentials")]
    public V20240501storageBackendStatusCredentials? Credentials { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendPool_STATUS
    /// Backend pool information
    /// </summary>
    [JsonPropertyName("pool")]
    public V20240501storageBackendStatusPool? Pool { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendProperties_STATUS
    /// Properties specific to the Backend Type.
    /// </summary>
    [JsonPropertyName("properties")]
    public V20240501storageBackendStatusProperties? Properties { get; set; }

    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendProxyContract_STATUS
    /// Details of the Backend WebProxy Server to use in the Request to Backend.
    /// </summary>
    [JsonPropertyName("proxy")]
    public V20240501storageBackendStatusProxy? Proxy { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Storage version of v20240501.BackendTlsProperties_STATUS
    /// Properties controlling TLS Certificate Validation.
    /// </summary>
    [JsonPropertyName("tls")]
    public V20240501storageBackendStatusTls? Tls { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v20240501.Backend
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimbackends.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501storageBackend : IKubernetesObject<V1ObjectMeta>, ISpec<V20240501storageBackendSpec?>, IStatus<V20240501storageBackendStatus?>
{
    public const string KubeApiVersion = "v20240501storage";
    public const string KubeKind = "Backend";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Backend";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20240501.Backend_Spec</summary>
    [JsonPropertyName("spec")]
    public V20240501storageBackendSpec? Spec { get; set; }

    /// <summary>Storage version of v20240501.Backend_STATUS</summary>
    [JsonPropertyName("status")]
    public V20240501storageBackendStatus? Status { get; set; }
}