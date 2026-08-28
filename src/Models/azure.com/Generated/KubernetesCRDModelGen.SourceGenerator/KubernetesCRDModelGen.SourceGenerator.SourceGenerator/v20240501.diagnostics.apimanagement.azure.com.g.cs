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
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimdiagnostics.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501DiagnosticList : IKubernetesObject<V1ListMeta>, IItems<V20240501Diagnostic>
{
    public const string KubeApiVersion = "v20240501";
    public const string KubeKind = "DiagnosticList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "diagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiagnosticList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240501Diagnostic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240501Diagnostic> Items { get; set; }
}

/// <summary>AlwaysLog: Specifies for what type of messages sampling settings should not apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecAlwaysLogEnum>))]
public enum V20240501DiagnosticSpecAlwaysLogEnum
{
    [EnumMember(Value = "allErrors"), JsonStringEnumMemberName("allErrors")]
    AllErrors
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendRequestBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecBackendRequestDataMaskingHeadersModeEnum>))]
public enum V20240501DiagnosticSpecBackendRequestDataMaskingHeadersModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendRequestDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501DiagnosticSpecBackendRequestDataMaskingHeadersModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecBackendRequestDataMaskingQueryParamsModeEnum>))]
public enum V20240501DiagnosticSpecBackendRequestDataMaskingQueryParamsModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendRequestDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501DiagnosticSpecBackendRequestDataMaskingQueryParamsModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendRequestDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501DiagnosticSpecBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501DiagnosticSpecBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Request: Diagnostic settings for request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendRequest
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501DiagnosticSpecBackendRequestBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501DiagnosticSpecBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendResponseBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecBackendResponseDataMaskingHeadersModeEnum>))]
public enum V20240501DiagnosticSpecBackendResponseDataMaskingHeadersModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendResponseDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501DiagnosticSpecBackendResponseDataMaskingHeadersModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecBackendResponseDataMaskingQueryParamsModeEnum>))]
public enum V20240501DiagnosticSpecBackendResponseDataMaskingQueryParamsModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendResponseDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501DiagnosticSpecBackendResponseDataMaskingQueryParamsModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendResponseDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501DiagnosticSpecBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501DiagnosticSpecBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Response: Diagnostic settings for response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackendResponse
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501DiagnosticSpecBackendResponseBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501DiagnosticSpecBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Backend: Diagnostic settings for incoming/outgoing HTTP messages to the Backend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecBackend
{
    /// <summary>Request: Diagnostic settings for request.</summary>
    [JsonPropertyName("request")]
    public V20240501DiagnosticSpecBackendRequest? Request { get; set; }

    /// <summary>Response: Diagnostic settings for response.</summary>
    [JsonPropertyName("response")]
    public V20240501DiagnosticSpecBackendResponse? Response { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendRequestBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecFrontendRequestDataMaskingHeadersModeEnum>))]
public enum V20240501DiagnosticSpecFrontendRequestDataMaskingHeadersModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendRequestDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501DiagnosticSpecFrontendRequestDataMaskingHeadersModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecFrontendRequestDataMaskingQueryParamsModeEnum>))]
public enum V20240501DiagnosticSpecFrontendRequestDataMaskingQueryParamsModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendRequestDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501DiagnosticSpecFrontendRequestDataMaskingQueryParamsModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendRequestDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501DiagnosticSpecFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501DiagnosticSpecFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Request: Diagnostic settings for request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendRequest
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501DiagnosticSpecFrontendRequestBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501DiagnosticSpecFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendResponseBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecFrontendResponseDataMaskingHeadersModeEnum>))]
public enum V20240501DiagnosticSpecFrontendResponseDataMaskingHeadersModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendResponseDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501DiagnosticSpecFrontendResponseDataMaskingHeadersModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Mode: Data masking mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecFrontendResponseDataMaskingQueryParamsModeEnum>))]
public enum V20240501DiagnosticSpecFrontendResponseDataMaskingQueryParamsModeEnum
{
    [EnumMember(Value = "Hide"), JsonStringEnumMemberName("Hide")]
    Hide,
    [EnumMember(Value = "Mask"), JsonStringEnumMemberName("Mask")]
    Mask
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendResponseDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public V20240501DiagnosticSpecFrontendResponseDataMaskingQueryParamsModeEnum? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendResponseDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501DiagnosticSpecFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501DiagnosticSpecFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Response: Diagnostic settings for response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontendResponse
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501DiagnosticSpecFrontendResponseBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501DiagnosticSpecFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Frontend: Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecFrontend
{
    /// <summary>Request: Diagnostic settings for request.</summary>
    [JsonPropertyName("request")]
    public V20240501DiagnosticSpecFrontendRequest? Request { get; set; }

    /// <summary>Response: Diagnostic settings for response.</summary>
    [JsonPropertyName("response")]
    public V20240501DiagnosticSpecFrontendResponse? Response { get; set; }
}

/// <summary>HttpCorrelationProtocol: Sets correlation protocol to use for Application Insights diagnostics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecHttpCorrelationProtocolEnum>))]
public enum V20240501DiagnosticSpecHttpCorrelationProtocolEnum
{
    [EnumMember(Value = "Legacy"), JsonStringEnumMemberName("Legacy")]
    Legacy,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "W3C"), JsonStringEnumMemberName("W3C")]
    W3C
}

/// <summary>LoggerReference: Resource Id of a target logger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecLoggerReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecOperationNameFormatEnum>))]
public enum V20240501DiagnosticSpecOperationNameFormatEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecOperatorSpecConfigMapExpressions
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
public partial class V20240501DiagnosticSpecOperatorSpecSecretExpressions
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
public partial class V20240501DiagnosticSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20240501DiagnosticSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20240501DiagnosticSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Service resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SamplingType: Sampling type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecSamplingSamplingTypeEnum>))]
public enum V20240501DiagnosticSpecSamplingSamplingTypeEnum
{
    [EnumMember(Value = "fixed"), JsonStringEnumMemberName("fixed")]
    Fixed
}

/// <summary>Sampling: Sampling settings for Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpecSampling
{
    /// <summary>Percentage: Rate of sampling for fixed-rate sampling.</summary>
    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }

    /// <summary>SamplingType: Sampling type.</summary>
    [JsonPropertyName("samplingType")]
    public V20240501DiagnosticSpecSamplingSamplingTypeEnum? SamplingType { get; set; }
}

/// <summary>Verbosity: The verbosity level applied to traces emitted by trace policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240501DiagnosticSpecVerbosityEnum>))]
public enum V20240501DiagnosticSpecVerbosityEnum
{
    [EnumMember(Value = "error"), JsonStringEnumMemberName("error")]
    Error,
    [EnumMember(Value = "information"), JsonStringEnumMemberName("information")]
    Information,
    [EnumMember(Value = "verbose"), JsonStringEnumMemberName("verbose")]
    Verbose
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticSpec
{
    /// <summary>AlwaysLog: Specifies for what type of messages sampling settings should not apply.</summary>
    [JsonPropertyName("alwaysLog")]
    public V20240501DiagnosticSpecAlwaysLogEnum? AlwaysLog { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Backend: Diagnostic settings for incoming/outgoing HTTP messages to the Backend</summary>
    [JsonPropertyName("backend")]
    public V20240501DiagnosticSpecBackend? Backend { get; set; }

    /// <summary>Frontend: Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.</summary>
    [JsonPropertyName("frontend")]
    public V20240501DiagnosticSpecFrontend? Frontend { get; set; }

    /// <summary>HttpCorrelationProtocol: Sets correlation protocol to use for Application Insights diagnostics.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public V20240501DiagnosticSpecHttpCorrelationProtocolEnum? HttpCorrelationProtocol { get; set; }

    /// <summary>LogClientIp: Log the ClientIP. Default is false.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>LoggerReference: Resource Id of a target logger.</summary>
    [JsonPropertyName("loggerReference")]
    public required V20240501DiagnosticSpecLoggerReference LoggerReference { get; set; }

    /// <summary>Metrics: Emit custom metrics via emit-metric policy. Applicable only to Application Insights diagnostic settings.</summary>
    [JsonPropertyName("metrics")]
    public bool? Metrics { get; set; }

    /// <summary>OperationNameFormat: The format of the Operation Name for Application Insights telemetries. Default is Name.</summary>
    [JsonPropertyName("operationNameFormat")]
    public V20240501DiagnosticSpecOperationNameFormatEnum? OperationNameFormat { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240501DiagnosticSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Service resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240501DiagnosticSpecOwner Owner { get; set; }

    /// <summary>Sampling: Sampling settings for Diagnostic.</summary>
    [JsonPropertyName("sampling")]
    public V20240501DiagnosticSpecSampling? Sampling { get; set; }

    /// <summary>Verbosity: The verbosity level applied to traces emitted by trace policies.</summary>
    [JsonPropertyName("verbosity")]
    public V20240501DiagnosticSpecVerbosityEnum? Verbosity { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendRequestBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendRequestDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendRequestDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendRequestDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501DiagnosticStatusBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501DiagnosticStatusBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Request: Diagnostic settings for request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendRequest
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501DiagnosticStatusBackendRequestBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501DiagnosticStatusBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendResponseBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendResponseDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendResponseDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendResponseDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501DiagnosticStatusBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501DiagnosticStatusBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Response: Diagnostic settings for response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackendResponse
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501DiagnosticStatusBackendResponseBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501DiagnosticStatusBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Backend: Diagnostic settings for incoming/outgoing HTTP messages to the Backend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusBackend
{
    /// <summary>Request: Diagnostic settings for request.</summary>
    [JsonPropertyName("request")]
    public V20240501DiagnosticStatusBackendRequest? Request { get; set; }

    /// <summary>Response: Diagnostic settings for response.</summary>
    [JsonPropertyName("response")]
    public V20240501DiagnosticStatusBackendResponse? Response { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendRequestBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendRequestDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendRequestDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendRequestDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501DiagnosticStatusFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501DiagnosticStatusFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Request: Diagnostic settings for request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendRequest
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501DiagnosticStatusFrontendRequestBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501DiagnosticStatusFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Body: Body logging settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendResponseBody
{
    /// <summary>Bytes: Number of request body bytes to log.</summary>
    [JsonPropertyName("bytes")]
    public int? Bytes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendResponseDataMaskingHeaders
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendResponseDataMaskingQueryParams
{
    /// <summary>Mode: Data masking mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Value: The name of an entity to mask (e.g. a name of a header or a query parameter).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DataMasking: Data masking settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendResponseDataMasking
{
    /// <summary>Headers: Masking settings for headers</summary>
    [JsonPropertyName("headers")]
    public IList<V20240501DiagnosticStatusFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>QueryParams: Masking settings for Url query parameters</summary>
    [JsonPropertyName("queryParams")]
    public IList<V20240501DiagnosticStatusFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>Response: Diagnostic settings for response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontendResponse
{
    /// <summary>Body: Body logging settings.</summary>
    [JsonPropertyName("body")]
    public V20240501DiagnosticStatusFrontendResponseBody? Body { get; set; }

    /// <summary>DataMasking: Data masking settings.</summary>
    [JsonPropertyName("dataMasking")]
    public V20240501DiagnosticStatusFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Headers: Array of HTTP Headers to log.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }
}

/// <summary>Frontend: Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusFrontend
{
    /// <summary>Request: Diagnostic settings for request.</summary>
    [JsonPropertyName("request")]
    public V20240501DiagnosticStatusFrontendRequest? Request { get; set; }

    /// <summary>Response: Diagnostic settings for response.</summary>
    [JsonPropertyName("response")]
    public V20240501DiagnosticStatusFrontendResponse? Response { get; set; }
}

/// <summary>Sampling: Sampling settings for Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatusSampling
{
    /// <summary>Percentage: Rate of sampling for fixed-rate sampling.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>SamplingType: Sampling type.</summary>
    [JsonPropertyName("samplingType")]
    public string? SamplingType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240501DiagnosticStatus
{
    /// <summary>AlwaysLog: Specifies for what type of messages sampling settings should not apply.</summary>
    [JsonPropertyName("alwaysLog")]
    public string? AlwaysLog { get; set; }

    /// <summary>Backend: Diagnostic settings for incoming/outgoing HTTP messages to the Backend</summary>
    [JsonPropertyName("backend")]
    public V20240501DiagnosticStatusBackend? Backend { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20240501DiagnosticStatusConditions>? Conditions { get; set; }

    /// <summary>Frontend: Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.</summary>
    [JsonPropertyName("frontend")]
    public V20240501DiagnosticStatusFrontend? Frontend { get; set; }

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
    public V20240501DiagnosticStatusSampling? Sampling { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Verbosity: The verbosity level applied to traces emitted by trace policies.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimdiagnostics.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/diagnostics/{diagnosticId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240501Diagnostic : IKubernetesObject<V1ObjectMeta>, ISpec<V20240501DiagnosticSpec?>, IStatus<V20240501DiagnosticStatus?>
{
    public const string KubeApiVersion = "v20240501";
    public const string KubeKind = "Diagnostic";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "diagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20240501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Diagnostic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20240501DiagnosticSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20240501DiagnosticStatus? Status { get; set; }
}