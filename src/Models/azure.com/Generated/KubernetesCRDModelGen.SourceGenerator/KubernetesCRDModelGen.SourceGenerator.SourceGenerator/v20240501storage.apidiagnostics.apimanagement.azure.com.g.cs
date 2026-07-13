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
/// Storage version of v20240501.ApiDiagnostic
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimapis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501storageApiDiagnosticList : IKubernetesObject<V1ListMeta>, IItems<V20240501storageApiDiagnostic>
{
    public const string KubeApiVersion = "v20240501storage";
    public const string KubeKind = "ApiDiagnosticList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "apidiagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApiDiagnosticList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240501storageApiDiagnostic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240501storageApiDiagnostic> Items { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendRequestBody
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendRequestDataMaskingHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendRequestDataMaskingQueryParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMasking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendRequestDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageApiDiagnosticSpecBackendRequestDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageApiDiagnosticSpecBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendRequest
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BodyDiagnosticSettings
    /// Body logging settings.
    /// </summary>
    [JsonPropertyName("body")]
    public V20240501storageApiDiagnosticSpecBackendRequestBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageApiDiagnosticSpecBackendRequestDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendResponseBody
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendResponseDataMaskingHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendResponseDataMaskingQueryParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMasking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendResponseDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageApiDiagnosticSpecBackendResponseDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageApiDiagnosticSpecBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackendResponse
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BodyDiagnosticSettings
    /// Body logging settings.
    /// </summary>
    [JsonPropertyName("body")]
    public V20240501storageApiDiagnosticSpecBackendResponseBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageApiDiagnosticSpecBackendResponseDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.PipelineDiagnosticSettings
/// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecBackend
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("request")]
    public V20240501storageApiDiagnosticSpecBackendRequest? Request { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("response")]
    public V20240501storageApiDiagnosticSpecBackendResponse? Response { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendRequestBody
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendRequestDataMaskingHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendRequestDataMaskingQueryParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMasking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendRequestDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageApiDiagnosticSpecFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageApiDiagnosticSpecFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendRequest
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BodyDiagnosticSettings
    /// Body logging settings.
    /// </summary>
    [JsonPropertyName("body")]
    public V20240501storageApiDiagnosticSpecFrontendRequestBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageApiDiagnosticSpecFrontendRequestDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendResponseBody
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendResponseDataMaskingHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendResponseDataMaskingQueryParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMasking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendResponseDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageApiDiagnosticSpecFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageApiDiagnosticSpecFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontendResponse
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BodyDiagnosticSettings
    /// Body logging settings.
    /// </summary>
    [JsonPropertyName("body")]
    public V20240501storageApiDiagnosticSpecFrontendResponseBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageApiDiagnosticSpecFrontendResponseDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.PipelineDiagnosticSettings
/// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecFrontend
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("request")]
    public V20240501storageApiDiagnosticSpecFrontendRequest? Request { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("response")]
    public V20240501storageApiDiagnosticSpecFrontendResponse? Response { get; set; }
}

/// <summary>LoggerReference: Resource Id of a target logger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecLoggerReference
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecOperatorSpecConfigMapExpressions
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
public partial class V20240501storageApiDiagnosticSpecOperatorSpecSecretExpressions
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
/// Storage version of v20240501.ApiDiagnosticOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20240501storageApiDiagnosticSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20240501storageApiDiagnosticSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Api resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20240501.SamplingSettings
/// Sampling settings for Diagnostic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpecSampling
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }

    [JsonPropertyName("samplingType")]
    public string? SamplingType { get; set; }
}

/// <summary>Storage version of v20240501.ApiDiagnostic_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("alwaysLog")]
    public string? AlwaysLog { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v20240501.PipelineDiagnosticSettings
    /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
    /// </summary>
    [JsonPropertyName("backend")]
    public V20240501storageApiDiagnosticSpecBackend? Backend { get; set; }

    /// <summary>
    /// Storage version of v20240501.PipelineDiagnosticSettings
    /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
    /// </summary>
    [JsonPropertyName("frontend")]
    public V20240501storageApiDiagnosticSpecFrontend? Frontend { get; set; }

    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>LoggerReference: Resource Id of a target logger.</summary>
    [JsonPropertyName("loggerReference")]
    public required V20240501storageApiDiagnosticSpecLoggerReference LoggerReference { get; set; }

    [JsonPropertyName("metrics")]
    public bool? Metrics { get; set; }

    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>
    /// Storage version of v20240501.ApiDiagnosticOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240501storageApiDiagnosticSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Api resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240501storageApiDiagnosticSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20240501.SamplingSettings
    /// Sampling settings for Diagnostic.
    /// </summary>
    [JsonPropertyName("sampling")]
    public V20240501storageApiDiagnosticSpecSampling? Sampling { get; set; }

    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings_STATUS
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendRequestBody
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendRequestDataMaskingHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendRequestDataMaskingQueryParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendRequestDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageApiDiagnosticStatusBackendRequestDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageApiDiagnosticStatusBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic_STATUS
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendRequest
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BodyDiagnosticSettings_STATUS
    /// Body logging settings.
    /// </summary>
    [JsonPropertyName("body")]
    public V20240501storageApiDiagnosticStatusBackendRequestBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageApiDiagnosticStatusBackendRequestDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings_STATUS
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendResponseBody
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendResponseDataMaskingHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendResponseDataMaskingQueryParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendResponseDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageApiDiagnosticStatusBackendResponseDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageApiDiagnosticStatusBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic_STATUS
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackendResponse
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BodyDiagnosticSettings_STATUS
    /// Body logging settings.
    /// </summary>
    [JsonPropertyName("body")]
    public V20240501storageApiDiagnosticStatusBackendResponseBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageApiDiagnosticStatusBackendResponseDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.PipelineDiagnosticSettings_STATUS
/// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusBackend
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic_STATUS
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("request")]
    public V20240501storageApiDiagnosticStatusBackendRequest? Request { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic_STATUS
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("response")]
    public V20240501storageApiDiagnosticStatusBackendResponse? Response { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusConditions
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
/// Storage version of v20240501.BodyDiagnosticSettings_STATUS
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendRequestBody
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendRequestDataMaskingHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendRequestDataMaskingQueryParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendRequestDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageApiDiagnosticStatusFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageApiDiagnosticStatusFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic_STATUS
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendRequest
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BodyDiagnosticSettings_STATUS
    /// Body logging settings.
    /// </summary>
    [JsonPropertyName("body")]
    public V20240501storageApiDiagnosticStatusFrontendRequestBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageApiDiagnosticStatusFrontendRequestDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings_STATUS
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendResponseBody
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendResponseDataMaskingHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMaskingEntity_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendResponseDataMaskingQueryParams
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendResponseDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageApiDiagnosticStatusFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageApiDiagnosticStatusFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic_STATUS
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontendResponse
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.BodyDiagnosticSettings_STATUS
    /// Body logging settings.
    /// </summary>
    [JsonPropertyName("body")]
    public V20240501storageApiDiagnosticStatusFrontendResponseBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageApiDiagnosticStatusFrontendResponseDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.PipelineDiagnosticSettings_STATUS
/// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusFrontend
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic_STATUS
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("request")]
    public V20240501storageApiDiagnosticStatusFrontendRequest? Request { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic_STATUS
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("response")]
    public V20240501storageApiDiagnosticStatusFrontendResponse? Response { get; set; }
}

/// <summary>
/// Storage version of v20240501.SamplingSettings_STATUS
/// Sampling settings for Diagnostic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatusSampling
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    [JsonPropertyName("samplingType")]
    public string? SamplingType { get; set; }
}

/// <summary>Storage version of v20240501.ApiDiagnostic_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageApiDiagnosticStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("alwaysLog")]
    public string? AlwaysLog { get; set; }

    /// <summary>
    /// Storage version of v20240501.PipelineDiagnosticSettings_STATUS
    /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
    /// </summary>
    [JsonPropertyName("backend")]
    public V20240501storageApiDiagnosticStatusBackend? Backend { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20240501storageApiDiagnosticStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20240501.PipelineDiagnosticSettings_STATUS
    /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
    /// </summary>
    [JsonPropertyName("frontend")]
    public V20240501storageApiDiagnosticStatusFrontend? Frontend { get; set; }

    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    [JsonPropertyName("loggerId")]
    public string? LoggerId { get; set; }

    [JsonPropertyName("metrics")]
    public bool? Metrics { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>
    /// Storage version of v20240501.SamplingSettings_STATUS
    /// Sampling settings for Diagnostic.
    /// </summary>
    [JsonPropertyName("sampling")]
    public V20240501storageApiDiagnosticStatusSampling? Sampling { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// Storage version of v20240501.ApiDiagnostic
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimapis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501storageApiDiagnostic : IKubernetesObject<V1ObjectMeta>, ISpec<V20240501storageApiDiagnosticSpec?>, IStatus<V20240501storageApiDiagnosticStatus?>
{
    public const string KubeApiVersion = "v20240501storage";
    public const string KubeKind = "ApiDiagnostic";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "apidiagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApiDiagnostic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20240501.ApiDiagnostic_Spec</summary>
    [JsonPropertyName("spec")]
    public V20240501storageApiDiagnosticSpec? Spec { get; set; }

    /// <summary>Storage version of v20240501.ApiDiagnostic_STATUS</summary>
    [JsonPropertyName("status")]
    public V20240501storageApiDiagnosticStatus? Status { get; set; }
}