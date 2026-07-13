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
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimapis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501ApiDiagnosticList : IKubernetesObject<V1ListMeta>, IItems<V20240501ApiDiagnostic>
{
    public const string KubeApiVersion = "v20240501";
    public const string KubeKind = "ApiDiagnosticList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "apidiagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApiDiagnosticList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240501ApiDiagnostic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240501ApiDiagnostic> Items { get; set; }
}

/// <summary>AlwaysLog: Specifies for what type of messages sampling settings should not apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecAlwaysLogEnum>))]
public enum V20240501ApiDiagnosticSpecAlwaysLogEnum
{
    [EnumMember(Value = "allErrors"), JsonStringEnumMemberName("allErrors")]
    AllErrors
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendRequestBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecBackendRequestDataMaskingHeadersModeEnum>))]
public enum V20240501ApiDiagnosticSpecBackendRequestDataMaskingHeadersModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendRequestDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501ApiDiagnosticSpecBackendRequestDataMaskingHeadersModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecBackendRequestDataMaskingQueryParamsModeEnum>))]
public enum V20240501ApiDiagnosticSpecBackendRequestDataMaskingQueryParamsModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendRequestDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501ApiDiagnosticSpecBackendRequestDataMaskingQueryParamsModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendRequestDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501ApiDiagnosticSpecBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501ApiDiagnosticSpecBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Request: Diagnostic settings for request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendRequest
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501ApiDiagnosticSpecBackendRequestBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501ApiDiagnosticSpecBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendResponseBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecBackendResponseDataMaskingHeadersModeEnum>))]
public enum V20240501ApiDiagnosticSpecBackendResponseDataMaskingHeadersModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendResponseDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501ApiDiagnosticSpecBackendResponseDataMaskingHeadersModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecBackendResponseDataMaskingQueryParamsModeEnum>))]
public enum V20240501ApiDiagnosticSpecBackendResponseDataMaskingQueryParamsModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendResponseDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501ApiDiagnosticSpecBackendResponseDataMaskingQueryParamsModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendResponseDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501ApiDiagnosticSpecBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501ApiDiagnosticSpecBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Response: Diagnostic settings for response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackendResponse
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501ApiDiagnosticSpecBackendResponseBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501ApiDiagnosticSpecBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Backend: Diagnostic settings for incoming/outgoing HTTP messages to the Backend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecBackend
{
    /// <summary>Request: Diagnostic settings for request.</summary>
    [JsonPropertyName("request")]
    public V20240501ApiDiagnosticSpecBackendRequest? Request { get; set; }

    /// <summary>Response: Diagnostic settings for response.</summary>
    [JsonPropertyName("response")]
    public V20240501ApiDiagnosticSpecBackendResponse? Response { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendRequestBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecFrontendRequestDataMaskingHeadersModeEnum>))]
public enum V20240501ApiDiagnosticSpecFrontendRequestDataMaskingHeadersModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendRequestDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501ApiDiagnosticSpecFrontendRequestDataMaskingHeadersModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecFrontendRequestDataMaskingQueryParamsModeEnum>))]
public enum V20240501ApiDiagnosticSpecFrontendRequestDataMaskingQueryParamsModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendRequestDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501ApiDiagnosticSpecFrontendRequestDataMaskingQueryParamsModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendRequestDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501ApiDiagnosticSpecFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501ApiDiagnosticSpecFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Request: Diagnostic settings for request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendRequest
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501ApiDiagnosticSpecFrontendRequestBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501ApiDiagnosticSpecFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendResponseBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecFrontendResponseDataMaskingHeadersModeEnum>))]
public enum V20240501ApiDiagnosticSpecFrontendResponseDataMaskingHeadersModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendResponseDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501ApiDiagnosticSpecFrontendResponseDataMaskingHeadersModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecFrontendResponseDataMaskingQueryParamsModeEnum>))]
public enum V20240501ApiDiagnosticSpecFrontendResponseDataMaskingQueryParamsModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendResponseDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501ApiDiagnosticSpecFrontendResponseDataMaskingQueryParamsModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendResponseDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501ApiDiagnosticSpecFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501ApiDiagnosticSpecFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Response: Diagnostic settings for response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontendResponse
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501ApiDiagnosticSpecFrontendResponseBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501ApiDiagnosticSpecFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Frontend: Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecFrontend
{
    /// <summary>Request: Diagnostic settings for request.</summary>
    [JsonPropertyName("request")]
    public V20240501ApiDiagnosticSpecFrontendRequest? Request { get; set; }

    /// <summary>Response: Diagnostic settings for response.</summary>
    [JsonPropertyName("response")]
    public V20240501ApiDiagnosticSpecFrontendResponse? Response { get; set; }
}

/// <summary>HttpCorrelationProtocol: Sets correlation protocol to use for Application Insights diagnostics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecHttpCorrelationProtocolEnum>))]
public enum V20240501ApiDiagnosticSpecHttpCorrelationProtocolEnum
{
    [EnumMember(Value = "Legacy"), JsonStringEnumMemberName("Legacy")]
    Legacy,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "W3C"), JsonStringEnumMemberName("W3C")]
    W3C
}

/// <summary>LoggerReference: Resource Id of a target logger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecLoggerReference
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

/// <summary>OperationNameFormat: The format of the Operation Name for Application Insights telemetries. Default is Name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecOperationNameFormatEnum>))]
public enum V20240501ApiDiagnosticSpecOperationNameFormatEnum
{
    [EnumMember(Value = "Name"), JsonStringEnumMemberName("Name")]
    Name,
    [EnumMember(Value = "Url"), JsonStringEnumMemberName("Url")]
    Url
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecOperatorSpecConfigMapExpressions
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
public partial class V20240501ApiDiagnosticSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20240501ApiDiagnosticSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20240501ApiDiagnosticSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Api resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SamplingType: Sampling type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecSamplingSamplingTypeEnum>))]
public enum V20240501ApiDiagnosticSpecSamplingSamplingTypeEnum
{
    [EnumMember(Value = "fixed"), JsonStringEnumMemberName("fixed")]
    Fixed
}

/// <summary>Sampling: Sampling settings for Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpecSampling
{
    /// <summary>Percentage: Rate of sampling for fixed-rate sampling.</summary>
    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }

    /// <summary>SamplingType: Sampling type.</summary>
    [JsonPropertyName("samplingType")]
    public V20240501ApiDiagnosticSpecSamplingSamplingTypeEnum? SamplingType { get; set; }
}

/// <summary>Verbosity: The verbosity level applied to traces emitted by trace policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501ApiDiagnosticSpecVerbosityEnum>))]
public enum V20240501ApiDiagnosticSpecVerbosityEnum
{
    [EnumMember(Value = "error"), JsonStringEnumMemberName("error")]
    Error,
    [EnumMember(Value = "information"), JsonStringEnumMemberName("information")]
    Information,
    [EnumMember(Value = "verbose"), JsonStringEnumMemberName("verbose")]
    Verbose
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticSpec
{
    /// <summary>AlwaysLog: Specifies for what type of messages sampling settings should not apply.</summary>
    [JsonPropertyName("alwaysLog")]
    public V20240501ApiDiagnosticSpecAlwaysLogEnum? AlwaysLog { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Backend: Diagnostic settings for incoming/outgoing HTTP messages to the Backend</summary>
    [JsonPropertyName("backend")]
    public V20240501ApiDiagnosticSpecBackend? Backend { get; set; }

    /// <summary>Frontend: Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.</summary>
    [JsonPropertyName("frontend")]
    public V20240501ApiDiagnosticSpecFrontend? Frontend { get; set; }

    /// <summary>HttpCorrelationProtocol: Sets correlation protocol to use for Application Insights diagnostics.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public V20240501ApiDiagnosticSpecHttpCorrelationProtocolEnum? HttpCorrelationProtocol { get; set; }

    /// <summary>LogClientIp: Log the ClientIP. Default is false.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>LoggerReference: Resource Id of a target logger.</summary>
    [JsonPropertyName("loggerReference")]
    public required V20240501ApiDiagnosticSpecLoggerReference LoggerReference { get; set; }

    /// <summary>Metrics: Emit custom metrics via emit-metric policy. Applicable only to Application Insights diagnostic settings.</summary>
    [JsonPropertyName("metrics")]
    public bool? Metrics { get; set; }

    /// <summary>OperationNameFormat: The format of the Operation Name for Application Insights telemetries. Default is Name.</summary>
    [JsonPropertyName("operationNameFormat")]
    public V20240501ApiDiagnosticSpecOperationNameFormatEnum? OperationNameFormat { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240501ApiDiagnosticSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Api resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240501ApiDiagnosticSpecOwner Owner { get; set; }

    /// <summary>Sampling: Sampling settings for Diagnostic.</summary>
    [JsonPropertyName("sampling")]
    public V20240501ApiDiagnosticSpecSampling? Sampling { get; set; }

    /// <summary>Verbosity: The verbosity level applied to traces emitted by trace policies.</summary>
    [JsonPropertyName("verbosity")]
    public V20240501ApiDiagnosticSpecVerbosityEnum? Verbosity { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendRequestBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendRequestDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendRequestDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendRequestDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501ApiDiagnosticStatusBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501ApiDiagnosticStatusBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Request: Diagnostic settings for request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendRequest
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501ApiDiagnosticStatusBackendRequestBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501ApiDiagnosticStatusBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendResponseBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendResponseDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendResponseDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendResponseDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501ApiDiagnosticStatusBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501ApiDiagnosticStatusBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Response: Diagnostic settings for response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackendResponse
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501ApiDiagnosticStatusBackendResponseBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501ApiDiagnosticStatusBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Backend: Diagnostic settings for incoming/outgoing HTTP messages to the Backend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusBackend
{
    /// <summary>Request: Diagnostic settings for request.</summary>
    [JsonPropertyName("request")]
    public V20240501ApiDiagnosticStatusBackendRequest? Request { get; set; }

    /// <summary>Response: Diagnostic settings for response.</summary>
    [JsonPropertyName("response")]
    public V20240501ApiDiagnosticStatusBackendResponse? Response { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusConditions
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

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendRequestBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendRequestDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendRequestDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendRequestDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501ApiDiagnosticStatusFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501ApiDiagnosticStatusFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Request: Diagnostic settings for request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendRequest
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501ApiDiagnosticStatusFrontendRequestBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501ApiDiagnosticStatusFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendResponseBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendResponseDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendResponseDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendResponseDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501ApiDiagnosticStatusFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501ApiDiagnosticStatusFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Response: Diagnostic settings for response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontendResponse
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501ApiDiagnosticStatusFrontendResponseBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501ApiDiagnosticStatusFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Frontend: Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusFrontend
{
    /// <summary>Request: Diagnostic settings for request.</summary>
    [JsonPropertyName("request")]
    public V20240501ApiDiagnosticStatusFrontendRequest? Request { get; set; }

    /// <summary>Response: Diagnostic settings for response.</summary>
    [JsonPropertyName("response")]
    public V20240501ApiDiagnosticStatusFrontendResponse? Response { get; set; }
}

/// <summary>Sampling: Sampling settings for Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatusSampling
{
    /// <summary>Percentage: Rate of sampling for fixed-rate sampling.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>SamplingType: Sampling type.</summary>
    [JsonPropertyName("samplingType")]
    public string? SamplingType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501ApiDiagnosticStatus
{
    /// <summary>AlwaysLog: Specifies for what type of messages sampling settings should not apply.</summary>
    [JsonPropertyName("alwaysLog")]
    public string? AlwaysLog { get; set; }

    /// <summary>Backend: Diagnostic settings for incoming/outgoing HTTP messages to the Backend</summary>
    [JsonPropertyName("backend")]
    public V20240501ApiDiagnosticStatusBackend? Backend { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20240501ApiDiagnosticStatusConditions>? Conditions { get; set; }

    /// <summary>Frontend: Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.</summary>
    [JsonPropertyName("frontend")]
    public V20240501ApiDiagnosticStatusFrontend? Frontend { get; set; }

    /// <summary>HttpCorrelationProtocol: Sets correlation protocol to use for Application Insights diagnostics.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>LogClientIp: Log the ClientIP. Default is false.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>LoggerId: Resource Id of a target logger.</summary>
    [JsonPropertyName("loggerId")]
    public string? LoggerId { get; set; }

    /// <summary>Metrics: Emit custom metrics via emit-metric policy. Applicable only to Application Insights diagnostic settings.</summary>
    [JsonPropertyName("metrics")]
    public bool? Metrics { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OperationNameFormat: The format of the Operation Name for Application Insights telemetries. Default is Name.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>Sampling: Sampling settings for Diagnostic.</summary>
    [JsonPropertyName("sampling")]
    public V20240501ApiDiagnosticStatusSampling? Sampling { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Verbosity: The verbosity level applied to traces emitted by trace policies.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimapis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501ApiDiagnostic : IKubernetesObject<V1ObjectMeta>, ISpec<V20240501ApiDiagnosticSpec?>, IStatus<V20240501ApiDiagnosticStatus?>
{
    public const string KubeApiVersion = "v20240501";
    public const string KubeKind = "ApiDiagnostic";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "apidiagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApiDiagnostic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20240501ApiDiagnosticSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20240501ApiDiagnosticStatus? Status { get; set; }
}