#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
/// <summary>Diagnostic is the Schema for the Diagnostics API. Manages an API Management Service Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DiagnosticList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Diagnostic>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DiagnosticList";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "diagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiagnosticList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Diagnostic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Diagnostic> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecDeletionPolicyEnum>))]
public enum V1beta2DiagnosticSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolutionEnum>))]
public enum V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolveEnum>))]
public enum V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolveEnum>))]
public enum V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderApiManagementNameRefPolicyResolutionEnum>))]
public enum V1beta2DiagnosticSpecForProviderApiManagementNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderApiManagementNameRefPolicyResolveEnum>))]
public enum V1beta2DiagnosticSpecForProviderApiManagementNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderApiManagementNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DiagnosticSpecForProviderApiManagementNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DiagnosticSpecForProviderApiManagementNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DiagnosticSpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderApiManagementNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DiagnosticSpecForProviderApiManagementNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderApiManagementNameSelectorPolicyResolveEnum>))]
public enum V1beta2DiagnosticSpecForProviderApiManagementNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DiagnosticSpecForProviderApiManagementNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DiagnosticSpecForProviderApiManagementNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderApiManagementNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DiagnosticSpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticSpecForProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticSpecForProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticSpecForProviderBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticSpecForProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticSpecForProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticSpecForProviderBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticSpecForProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticSpecForProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticSpecForProviderFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticSpecForProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticSpecForProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticSpecForProviderFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2DiagnosticSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2DiagnosticSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DiagnosticSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DiagnosticSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DiagnosticSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2DiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DiagnosticSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProviderResourceGroupNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DiagnosticSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecForProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The id of the target API Management Logger where the API Management Diagnostic should be saved.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdRef")]
    public V1beta2DiagnosticSpecForProviderApiManagementLoggerIdRef? ApiManagementLoggerIdRef { get; set; }

    /// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdSelector")]
    public V1beta2DiagnosticSpecForProviderApiManagementLoggerIdSelector? ApiManagementLoggerIdSelector { get; set; }

    /// <summary>The Name of the API Management Service where this Diagnostic should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta2DiagnosticSpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta2DiagnosticSpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public V1beta2DiagnosticSpecForProviderBackendRequest? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public V1beta2DiagnosticSpecForProviderBackendResponse? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public V1beta2DiagnosticSpecForProviderFrontendRequest? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public V1beta2DiagnosticSpecForProviderFrontendResponse? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>The Name of the Resource Group where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2DiagnosticSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2DiagnosticSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolutionEnum>))]
public enum V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolveEnum>))]
public enum V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolveEnum>))]
public enum V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticSpecInitProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticSpecInitProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticSpecInitProviderBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticSpecInitProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticSpecInitProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticSpecInitProviderBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticSpecInitProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticSpecInitProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticSpecInitProviderFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticSpecInitProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticSpecInitProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticSpecInitProviderFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecInitProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The id of the target API Management Logger where the API Management Diagnostic should be saved.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>Reference to a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdRef")]
    public V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdRef? ApiManagementLoggerIdRef { get; set; }

    /// <summary>Selector for a Logger in apimanagement to populate apiManagementLoggerId.</summary>
    [JsonPropertyName("apiManagementLoggerIdSelector")]
    public V1beta2DiagnosticSpecInitProviderApiManagementLoggerIdSelector? ApiManagementLoggerIdSelector { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public V1beta2DiagnosticSpecInitProviderBackendRequest? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public V1beta2DiagnosticSpecInitProviderBackendResponse? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public V1beta2DiagnosticSpecInitProviderFrontendRequest? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public V1beta2DiagnosticSpecInitProviderFrontendResponse? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecManagementPoliciesEnum>))]
public enum V1beta2DiagnosticSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DiagnosticSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DiagnosticSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DiagnosticSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DiagnosticSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DiagnosticSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DiagnosticSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DiagnosticSpec defines the desired state of Diagnostic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2DiagnosticSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DiagnosticSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta2DiagnosticSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2DiagnosticSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DiagnosticSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DiagnosticSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderBackendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderBackendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderBackendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticStatusAtProviderBackendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticStatusAtProviderBackendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderBackendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticStatusAtProviderBackendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderBackendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderBackendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderBackendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticStatusAtProviderBackendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticStatusAtProviderBackendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A backend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderBackendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticStatusAtProviderBackendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderFrontendRequestDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderFrontendRequestDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderFrontendRequestDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticStatusAtProviderFrontendRequestDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticStatusAtProviderFrontendRequestDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderFrontendRequest
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticStatusAtProviderFrontendRequestDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderFrontendResponseDataMaskingHeaders
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderFrontendResponseDataMaskingQueryParams
{
    /// <summary>The data masking mode. Possible values are Mask and Hide for query_params. The only possible value is Mask for headers.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the header or the query parameter to mask.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A data_masking block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderFrontendResponseDataMasking
{
    /// <summary>A headers block as defined below.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2DiagnosticStatusAtProviderFrontendResponseDataMaskingHeaders>? Headers { get; set; }

    /// <summary>A query_params block as defined below.</summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta2DiagnosticStatusAtProviderFrontendResponseDataMaskingQueryParams>? QueryParams { get; set; }
}

/// <summary>A frontend_response block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProviderFrontendResponse
{
    /// <summary>Number of payload bytes to log (up to 8192).</summary>
    [JsonPropertyName("bodyBytes")]
    public double? BodyBytes { get; set; }

    /// <summary>A data_masking block as defined below.</summary>
    [JsonPropertyName("dataMasking")]
    public V1beta2DiagnosticStatusAtProviderFrontendResponseDataMasking? DataMasking { get; set; }

    /// <summary>Specifies a list of headers to log.</summary>
    [JsonPropertyName("headersToLog")]
    public IList<string>? HeadersToLog { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusAtProvider
{
    /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
    [JsonPropertyName("alwaysLogErrors")]
    public bool? AlwaysLogErrors { get; set; }

    /// <summary>The id of the target API Management Logger where the API Management Diagnostic should be saved.</summary>
    [JsonPropertyName("apiManagementLoggerId")]
    public string? ApiManagementLoggerId { get; set; }

    /// <summary>The Name of the API Management Service where this Diagnostic should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>A backend_request block as defined below.</summary>
    [JsonPropertyName("backendRequest")]
    public V1beta2DiagnosticStatusAtProviderBackendRequest? BackendRequest { get; set; }

    /// <summary>A backend_response block as defined below.</summary>
    [JsonPropertyName("backendResponse")]
    public V1beta2DiagnosticStatusAtProviderBackendResponse? BackendResponse { get; set; }

    /// <summary>A frontend_request block as defined below.</summary>
    [JsonPropertyName("frontendRequest")]
    public V1beta2DiagnosticStatusAtProviderFrontendRequest? FrontendRequest { get; set; }

    /// <summary>A frontend_response block as defined below.</summary>
    [JsonPropertyName("frontendResponse")]
    public V1beta2DiagnosticStatusAtProviderFrontendResponse? FrontendResponse { get; set; }

    /// <summary>The HTTP Correlation Protocol to use. Possible values are None, Legacy or W3C.</summary>
    [JsonPropertyName("httpCorrelationProtocol")]
    public string? HttpCorrelationProtocol { get; set; }

    /// <summary>The ID of the API Management Diagnostic.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Log client IP address.</summary>
    [JsonPropertyName("logClientIp")]
    public bool? LogClientIp { get; set; }

    /// <summary>The format of the Operation Name for Application Insights telemetries. Possible values are Name, and Url.</summary>
    [JsonPropertyName("operationNameFormat")]
    public string? OperationNameFormat { get; set; }

    /// <summary>The Name of the Resource Group where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Sampling (%). For high traffic APIs, please read this documentation to understand performance implications and log sampling. Valid values are between 0.0 and 100.0.</summary>
    [JsonPropertyName("samplingPercentage")]
    public double? SamplingPercentage { get; set; }

    /// <summary>Logging verbosity. Possible values are verbose, information or error.</summary>
    [JsonPropertyName("verbosity")]
    public string? Verbosity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>DiagnosticStatus defines the observed state of Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DiagnosticStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DiagnosticStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DiagnosticStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Diagnostic is the Schema for the Diagnostics API. Manages an API Management Service Diagnostic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Diagnostic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DiagnosticSpec>, IStatus<V1beta2DiagnosticStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Diagnostic";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "diagnostics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Diagnostic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DiagnosticSpec defines the desired state of Diagnostic</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DiagnosticSpec Spec { get; set; }

    /// <summary>DiagnosticStatus defines the observed state of Diagnostic.</summary>
    [JsonPropertyName("status")]
    public V1beta2DiagnosticStatus? Status { get; set; }
}