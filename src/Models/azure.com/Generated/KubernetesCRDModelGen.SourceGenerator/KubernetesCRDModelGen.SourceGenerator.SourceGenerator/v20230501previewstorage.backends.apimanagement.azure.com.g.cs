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
/// Storage version of v20230501preview.Backend
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/preview/2023-05-01-preview/apimbackends.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230501previewstorageBackendList : IKubernetesObject<V1ListMeta>, IItems<V20230501previewstorageBackend>
{
    public const string KubeApiVersion = "v20230501previewstorage";
    public const string KubeKind = "BackendList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20230501previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackendList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20230501previewstorageBackend objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20230501previewstorageBackend> Items { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.FailureStatusCodeRange
/// The failure http status code range
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecCircuitBreakerRulesFailureConditionStatusCodeRanges
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
/// Storage version of v20230501preview.CircuitBreakerFailureCondition
/// The trip conditions of the circuit breaker
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecCircuitBreakerRulesFailureCondition
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
    public IList<V20230501previewstorageBackendSpecCircuitBreakerRulesFailureConditionStatusCodeRanges>? StatusCodeRanges { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.CircuitBreakerRule
/// Rule configuration to trip the backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecCircuitBreakerRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.CircuitBreakerFailureCondition
    /// The trip conditions of the circuit breaker
    /// </summary>
    [JsonPropertyName("failureCondition")]
    public V20230501previewstorageBackendSpecCircuitBreakerRulesFailureCondition? FailureCondition { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tripDuration")]
    public string? TripDuration { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.BackendCircuitBreaker
/// The configuration of the backend circuit breaker
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecCircuitBreaker
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<V20230501previewstorageBackendSpecCircuitBreakerRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.BackendAuthorizationHeaderCredentials
/// Authorization header information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecCredentialsAuthorization
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
/// Storage version of v20230501preview.BackendCredentialsContract
/// Details of the Credentials used to connect to Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecCredentials
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendAuthorizationHeaderCredentials
    /// Authorization header information.
    /// </summary>
    [JsonPropertyName("authorization")]
    public V20230501previewstorageBackendSpecCredentialsAuthorization? Authorization { get; set; }

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
public partial class V20230501previewstorageBackendSpecOperatorSpecConfigMapExpressions
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
public partial class V20230501previewstorageBackendSpecOperatorSpecSecretExpressions
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
/// Storage version of v20230501preview.BackendOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20230501previewstorageBackendSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20230501previewstorageBackendSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Service resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecOwner
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
public partial class V20230501previewstorageBackendSpecPoolServicesReference
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
/// Storage version of v20230501preview.BackendPoolItem
/// Backend pool service information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecPoolServices
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The unique ARM id of the backend entity. The ARM id should refer to an already existing backend entity.</summary>
    [JsonPropertyName("reference")]
    public required V20230501previewstorageBackendSpecPoolServicesReference Reference { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.BackendPool
/// Backend pool information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecPool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("services")]
    public IList<V20230501previewstorageBackendSpecPoolServices>? Services { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.X509CertificateName
/// Properties of server X509Names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecPropertiesServiceFabricClusterServerX509Names
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
/// Storage version of v20230501preview.BackendServiceFabricClusterProperties
/// Properties of the Service Fabric Type Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecPropertiesServiceFabricCluster
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
    public IList<V20230501previewstorageBackendSpecPropertiesServiceFabricClusterServerX509Names>? ServerX509Names { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.BackendProperties
/// Properties specific to the Backend Type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendServiceFabricClusterProperties
    /// Properties of the Service Fabric Type Backend.
    /// </summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V20230501previewstorageBackendSpecPropertiesServiceFabricCluster? ServiceFabricCluster { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecProxyPassword
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
/// Storage version of v20230501preview.BackendProxyContract
/// Details of the Backend WebProxy Server to use in the Request to Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecProxy
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
    public V20230501previewstorageBackendSpecProxyPassword? Password { get; set; }

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
public partial class V20230501previewstorageBackendSpecResourceReference
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
/// Storage version of v20230501preview.BackendTlsProperties
/// Properties controlling TLS Certificate Validation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpecTls
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

/// <summary>Storage version of v20230501preview.Backend_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendSpec
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
    /// Storage version of v20230501preview.BackendCircuitBreaker
    /// The configuration of the backend circuit breaker
    /// </summary>
    [JsonPropertyName("circuitBreaker")]
    public V20230501previewstorageBackendSpecCircuitBreaker? CircuitBreaker { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendCredentialsContract
    /// Details of the Credentials used to connect to Backend.
    /// </summary>
    [JsonPropertyName("credentials")]
    public V20230501previewstorageBackendSpecCredentials? Credentials { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20230501previewstorageBackendSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Service resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20230501previewstorageBackendSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendPool
    /// Backend pool information
    /// </summary>
    [JsonPropertyName("pool")]
    public V20230501previewstorageBackendSpecPool? Pool { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendProperties
    /// Properties specific to the Backend Type.
    /// </summary>
    [JsonPropertyName("properties")]
    public V20230501previewstorageBackendSpecProperties? Properties { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendProxyContract
    /// Details of the Backend WebProxy Server to use in the Request to Backend.
    /// </summary>
    [JsonPropertyName("proxy")]
    public V20230501previewstorageBackendSpecProxy? Proxy { get; set; }

    /// <summary>
    /// ResourceReference: Management Uri of the Resource in External System. This URL can be the Arm Resource Id of Logic Apps,
    /// Function Apps or API Apps.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20230501previewstorageBackendSpecResourceReference? ResourceReference { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendTlsProperties
    /// Properties controlling TLS Certificate Validation.
    /// </summary>
    [JsonPropertyName("tls")]
    public V20230501previewstorageBackendSpecTls? Tls { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.FailureStatusCodeRange_STATUS
/// The failure http status code range
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusCircuitBreakerRulesFailureConditionStatusCodeRanges
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
/// Storage version of v20230501preview.CircuitBreakerFailureCondition_STATUS
/// The trip conditions of the circuit breaker
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusCircuitBreakerRulesFailureCondition
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
    public IList<V20230501previewstorageBackendStatusCircuitBreakerRulesFailureConditionStatusCodeRanges>? StatusCodeRanges { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.CircuitBreakerRule_STATUS
/// Rule configuration to trip the backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusCircuitBreakerRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.CircuitBreakerFailureCondition_STATUS
    /// The trip conditions of the circuit breaker
    /// </summary>
    [JsonPropertyName("failureCondition")]
    public V20230501previewstorageBackendStatusCircuitBreakerRulesFailureCondition? FailureCondition { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tripDuration")]
    public string? TripDuration { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.BackendCircuitBreaker_STATUS
/// The configuration of the backend circuit breaker
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusCircuitBreaker
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<V20230501previewstorageBackendStatusCircuitBreakerRules>? Rules { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusConditions
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
/// Storage version of v20230501preview.BackendAuthorizationHeaderCredentials_STATUS
/// Authorization header information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusCredentialsAuthorization
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
/// Storage version of v20230501preview.BackendCredentialsContract_STATUS
/// Details of the Credentials used to connect to Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusCredentials
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendAuthorizationHeaderCredentials_STATUS
    /// Authorization header information.
    /// </summary>
    [JsonPropertyName("authorization")]
    public V20230501previewstorageBackendStatusCredentialsAuthorization? Authorization { get; set; }

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
/// Storage version of v20230501preview.BackendPoolItem_STATUS
/// Backend pool service information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusPoolServices
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.BackendPool_STATUS
/// Backend pool information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusPool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("services")]
    public IList<V20230501previewstorageBackendStatusPoolServices>? Services { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.X509CertificateName_STATUS
/// Properties of server X509Names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusPropertiesServiceFabricClusterServerX509Names
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
/// Storage version of v20230501preview.BackendServiceFabricClusterProperties_STATUS
/// Properties of the Service Fabric Type Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusPropertiesServiceFabricCluster
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
    public IList<V20230501previewstorageBackendStatusPropertiesServiceFabricClusterServerX509Names>? ServerX509Names { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.BackendProperties_STATUS
/// Properties specific to the Backend Type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendServiceFabricClusterProperties_STATUS
    /// Properties of the Service Fabric Type Backend.
    /// </summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V20230501previewstorageBackendStatusPropertiesServiceFabricCluster? ServiceFabricCluster { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.BackendProxyContract_STATUS
/// Details of the Backend WebProxy Server to use in the Request to Backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusProxy
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
/// Storage version of v20230501preview.BackendTlsProperties_STATUS
/// Properties controlling TLS Certificate Validation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatusTls
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

/// <summary>Storage version of v20230501preview.Backend_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230501previewstorageBackendStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendCircuitBreaker_STATUS
    /// The configuration of the backend circuit breaker
    /// </summary>
    [JsonPropertyName("circuitBreaker")]
    public V20230501previewstorageBackendStatusCircuitBreaker? CircuitBreaker { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20230501previewstorageBackendStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendCredentialsContract_STATUS
    /// Details of the Credentials used to connect to Backend.
    /// </summary>
    [JsonPropertyName("credentials")]
    public V20230501previewstorageBackendStatusCredentials? Credentials { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendPool_STATUS
    /// Backend pool information
    /// </summary>
    [JsonPropertyName("pool")]
    public V20230501previewstorageBackendStatusPool? Pool { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendProperties_STATUS
    /// Properties specific to the Backend Type.
    /// </summary>
    [JsonPropertyName("properties")]
    public V20230501previewstorageBackendStatusProperties? Properties { get; set; }

    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendProxyContract_STATUS
    /// Details of the Backend WebProxy Server to use in the Request to Backend.
    /// </summary>
    [JsonPropertyName("proxy")]
    public V20230501previewstorageBackendStatusProxy? Proxy { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Storage version of v20230501preview.BackendTlsProperties_STATUS
    /// Properties controlling TLS Certificate Validation.
    /// </summary>
    [JsonPropertyName("tls")]
    public V20230501previewstorageBackendStatusTls? Tls { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v20230501preview.Backend
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/preview/2023-05-01-preview/apimbackends.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/backends/{backendId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230501previewstorageBackend : IKubernetesObject<V1ObjectMeta>, ISpec<V20230501previewstorageBackendSpec?>, IStatus<V20230501previewstorageBackendStatus?>
{
    public const string KubeApiVersion = "v20230501previewstorage";
    public const string KubeKind = "Backend";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20230501previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Backend";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20230501preview.Backend_Spec</summary>
    [JsonPropertyName("spec")]
    public V20230501previewstorageBackendSpec? Spec { get; set; }

    /// <summary>Storage version of v20230501preview.Backend_STATUS</summary>
    [JsonPropertyName("status")]
    public V20230501previewstorageBackendStatus? Status { get; set; }
}