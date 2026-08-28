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
/// Storage version of v20240501.Diagnostic
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimdiagnostics.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501storageDiagnosticList : IKubernetesObject<V1ListMeta>, IItems<V20240501storageDiagnostic>
{
    public const string KubeApiVersion = "v20240501storage";
    public const string KubeKind = "DiagnosticList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "diagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiagnosticList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240501storageDiagnostic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240501storageDiagnostic> Items { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecBackendRequestBody
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
public partial class V20240501storageDiagnosticSpecBackendRequestDataMaskingHeaders
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
public partial class V20240501storageDiagnosticSpecBackendRequestDataMaskingQueryParams
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
public partial class V20240501storageDiagnosticSpecBackendRequestDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageDiagnosticSpecBackendRequestDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageDiagnosticSpecBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecBackendRequest
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
    public V20240501storageDiagnosticSpecBackendRequestBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageDiagnosticSpecBackendRequestDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecBackendResponseBody
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
public partial class V20240501storageDiagnosticSpecBackendResponseDataMaskingHeaders
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
public partial class V20240501storageDiagnosticSpecBackendResponseDataMaskingQueryParams
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
public partial class V20240501storageDiagnosticSpecBackendResponseDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageDiagnosticSpecBackendResponseDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageDiagnosticSpecBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecBackendResponse
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
    public V20240501storageDiagnosticSpecBackendResponseBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageDiagnosticSpecBackendResponseDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.PipelineDiagnosticSettings
/// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecBackend
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
    public V20240501storageDiagnosticSpecBackendRequest? Request { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("response")]
    public V20240501storageDiagnosticSpecBackendResponse? Response { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecFrontendRequestBody
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
public partial class V20240501storageDiagnosticSpecFrontendRequestDataMaskingHeaders
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
public partial class V20240501storageDiagnosticSpecFrontendRequestDataMaskingQueryParams
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
public partial class V20240501storageDiagnosticSpecFrontendRequestDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageDiagnosticSpecFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageDiagnosticSpecFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecFrontendRequest
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
    public V20240501storageDiagnosticSpecFrontendRequestBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageDiagnosticSpecFrontendRequestDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecFrontendResponseBody
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
public partial class V20240501storageDiagnosticSpecFrontendResponseDataMaskingHeaders
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
public partial class V20240501storageDiagnosticSpecFrontendResponseDataMaskingQueryParams
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
public partial class V20240501storageDiagnosticSpecFrontendResponseDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageDiagnosticSpecFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageDiagnosticSpecFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecFrontendResponse
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
    public V20240501storageDiagnosticSpecFrontendResponseBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageDiagnosticSpecFrontendResponseDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.PipelineDiagnosticSettings
/// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecFrontend
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
    public V20240501storageDiagnosticSpecFrontendRequest? Request { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("response")]
    public V20240501storageDiagnosticSpecFrontendResponse? Response { get; set; }
}

/// <summary>LoggerReference: Resource Id of a target logger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecLoggerReference
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
public partial class V20240501storageDiagnosticSpecOperatorSpecConfigMapExpressions
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
public partial class V20240501storageDiagnosticSpecOperatorSpecSecretExpressions
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
/// Storage version of v20240501.DiagnosticOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20240501storageDiagnosticSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20240501storageDiagnosticSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Service resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpecOwner
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
public partial class V20240501storageDiagnosticSpecSampling
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

/// <summary>Storage version of v20240501.Diagnostic_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticSpec
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
    public V20240501storageDiagnosticSpecBackend? Backend { get; set; }

    /// <summary>
    /// Storage version of v20240501.PipelineDiagnosticSettings
    /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
    /// </summary>
    [JsonPropertyName("frontend")]
    public V20240501storageDiagnosticSpecFrontend? Frontend { get; set; }

    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>LoggerReference: Resource Id of a target logger.</summary>
    [JsonPropertyName("loggerReference")]
    public required V20240501storageDiagnosticSpecLoggerReference LoggerReference { get; set; }

    [JsonPropertyName("metrics")]
    public bool? Metrics { get; set; }

    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>
    /// Storage version of v20240501.DiagnosticOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240501storageDiagnosticSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Service resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240501storageDiagnosticSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20240501.SamplingSettings
    /// Sampling settings for Diagnostic.
    /// </summary>
    [JsonPropertyName("sampling")]
    public V20240501storageDiagnosticSpecSampling? Sampling { get; set; }

    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings_STATUS
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusBackendRequestBody
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
public partial class V20240501storageDiagnosticStatusBackendRequestDataMaskingHeaders
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
public partial class V20240501storageDiagnosticStatusBackendRequestDataMaskingQueryParams
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
public partial class V20240501storageDiagnosticStatusBackendRequestDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageDiagnosticStatusBackendRequestDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageDiagnosticStatusBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic_STATUS
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusBackendRequest
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
    public V20240501storageDiagnosticStatusBackendRequestBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageDiagnosticStatusBackendRequestDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings_STATUS
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusBackendResponseBody
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
public partial class V20240501storageDiagnosticStatusBackendResponseDataMaskingHeaders
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
public partial class V20240501storageDiagnosticStatusBackendResponseDataMaskingQueryParams
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
public partial class V20240501storageDiagnosticStatusBackendResponseDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageDiagnosticStatusBackendResponseDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageDiagnosticStatusBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic_STATUS
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusBackendResponse
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
    public V20240501storageDiagnosticStatusBackendResponseBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageDiagnosticStatusBackendResponseDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.PipelineDiagnosticSettings_STATUS
/// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusBackend
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
    public V20240501storageDiagnosticStatusBackendRequest? Request { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic_STATUS
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("response")]
    public V20240501storageDiagnosticStatusBackendResponse? Response { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusConditions
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
public partial class V20240501storageDiagnosticStatusFrontendRequestBody
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
public partial class V20240501storageDiagnosticStatusFrontendRequestDataMaskingHeaders
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
public partial class V20240501storageDiagnosticStatusFrontendRequestDataMaskingQueryParams
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
public partial class V20240501storageDiagnosticStatusFrontendRequestDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageDiagnosticStatusFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageDiagnosticStatusFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic_STATUS
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusFrontendRequest
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
    public V20240501storageDiagnosticStatusFrontendRequestBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageDiagnosticStatusFrontendRequestDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.BodyDiagnosticSettings_STATUS
/// Body logging settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusFrontendResponseBody
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
public partial class V20240501storageDiagnosticStatusFrontendResponseDataMaskingHeaders
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
public partial class V20240501storageDiagnosticStatusFrontendResponseDataMaskingQueryParams
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
public partial class V20240501storageDiagnosticStatusFrontendResponseDataMasking
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headers")]
    public IList<V20240501storageDiagnosticStatusFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    [JsonPropertyName("queryParams")]
    public IList<V20240501storageDiagnosticStatusFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Storage version of v20240501.HttpMessageDiagnostic_STATUS
/// Http message diagnostic settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusFrontendResponse
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
    public V20240501storageDiagnosticStatusFrontendResponseBody? Body { get; set; }

    /// <summary>Storage version of v20240501.DataMasking_STATUS</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501storageDiagnosticStatusFrontendResponseDataMasking? DataMasking { get; set; }

    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>
/// Storage version of v20240501.PipelineDiagnosticSettings_STATUS
/// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusFrontend
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
    public V20240501storageDiagnosticStatusFrontendRequest? Request { get; set; }

    /// <summary>
    /// Storage version of v20240501.HttpMessageDiagnostic_STATUS
    /// Http message diagnostic settings.
    /// </summary>
    [JsonPropertyName("response")]
    public V20240501storageDiagnosticStatusFrontendResponse? Response { get; set; }
}

/// <summary>
/// Storage version of v20240501.SamplingSettings_STATUS
/// Sampling settings for Diagnostic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatusSampling
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

/// <summary>Storage version of v20240501.Diagnostic_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501storageDiagnosticStatus
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
    public V20240501storageDiagnosticStatusBackend? Backend { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20240501storageDiagnosticStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20240501.PipelineDiagnosticSettings_STATUS
    /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
    /// </summary>
    [JsonPropertyName("frontend")]
    public V20240501storageDiagnosticStatusFrontend? Frontend { get; set; }

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
    public V20240501storageDiagnosticStatusSampling? Sampling { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// Storage version of v20240501.Diagnostic
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimdiagnostics.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501storageDiagnostic : IKubernetesObject<V1ObjectMeta>, ISpec<V20240501storageDiagnosticSpec?>, IStatus<V20240501storageDiagnosticStatus?>
{
    public const string KubeApiVersion = "v20240501storage";
    public const string KubeKind = "Diagnostic";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "diagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Diagnostic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20240501.Diagnostic_Spec</summary>
    [JsonPropertyName("spec")]
    public V20240501storageDiagnosticSpec? Spec { get; set; }

    /// <summary>Storage version of v20240501.Diagnostic_STATUS</summary>
    [JsonPropertyName("status")]
    public V20240501storageDiagnosticStatus? Status { get; set; }
}