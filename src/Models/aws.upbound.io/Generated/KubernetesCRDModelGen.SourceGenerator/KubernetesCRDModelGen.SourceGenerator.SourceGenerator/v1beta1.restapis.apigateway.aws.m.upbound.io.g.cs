#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigateway.aws.m.upbound.io;
/// <summary>RestAPI is the Schema for the RestAPIs API. Manages an API Gateway REST API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RestAPIList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RestAPI>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RestAPIList";
    public const string KubeGroup = "apigateway.aws.m.upbound.io";
    public const string KubePluralName = "restapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RestAPIList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RestAPI objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RestAPI> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolutionEnum>))]
public enum V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolveEnum>))]
public enum V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolveEnum>))]
public enum V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of VPCEndpoint in ec2 to populate vpcEndpointIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block defining API endpoint configuration including endpoint type. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecForProviderEndpointConfiguration
{
    /// <summary>The IP address types that can invoke an API (RestApi). Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke an API, or use dualstack to allow both IPv4 and IPv6 addresses to invoke an API. For the PRIVATE endpoint type, only dualstack is supported.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>List of endpoint types. This resource currently only supports managing a single value. Valid values: EDGE, REGIONAL or PRIVATE. If unspecified, defaults to EDGE. If set to PRIVATE recommend to set put_rest_api_mode = merge to not cause the endpoints and associated Route53 records to be deleted. Refer to the documentation for more information on the difference between edge-optimized and regional APIs.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    /// <summary>Set of VPC Endpoint identifiers. It is only supported for PRIVATE endpoint type. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-endpoint-configuration extension vpcEndpointIds property. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("vpcEndpointIds")]
    public IList<string>? VpcEndpointIds { get; set; }

    /// <summary>References to VPCEndpoint in ec2 to populate vpcEndpointIds.</summary>
    [JsonPropertyName("vpcEndpointIdsRefs")]
    public IList<V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsRefs>? VpcEndpointIdsRefs { get; set; }

    /// <summary>Selector for a list of VPCEndpoint in ec2 to populate vpcEndpointIds.</summary>
    [JsonPropertyName("vpcEndpointIdsSelector")]
    public V1beta1RestAPISpecForProviderEndpointConfigurationVpcEndpointIdsSelector? VpcEndpointIdsSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecForProvider
{
    /// <summary>Source of the API key for requests. Valid values are HEADER (default) and AUTHORIZER. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-api-key-source extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("apiKeySource")]
    public string? ApiKeySource { get; set; }

    /// <summary>List of binary media types supported by the REST API. By default, the REST API supports only UTF-8-encoded text payloads. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-binary-media-types extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("binaryMediaTypes")]
    public IList<string>? BinaryMediaTypes { get; set; }

    /// <summary>OpenAPI specification that defines the set of routes and integrations to create as part of the REST API. This configuration, and any updates to it, will replace all REST API configuration except values overridden in this resource configuration and other resource updates applied after this resource but before any aws_api_gateway_deployment creation. More information about REST API OpenAPI support can be found in the API Gateway Developer Guide.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Description of the REST API. If importing an OpenAPI specification via the body argument, this corresponds to the info.description field. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether clients can invoke your API by using the default execute-api endpoint. By default, clients can invoke your API with the default https://{api_id}.execute-api.{region}.amazonaws.com endpoint. To require that clients use a custom domain name to invoke your API, disable the default endpoint. Defaults to false. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-endpoint-configuration extension disableExecuteApiEndpoint property. If the argument value is true and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("disableExecuteApiEndpoint")]
    public bool? DisableExecuteApiEndpoint { get; set; }

    /// <summary>Configuration block defining API endpoint configuration including endpoint type. Defined below.</summary>
    [JsonPropertyName("endpointConfiguration")]
    public V1beta1RestAPISpecForProviderEndpointConfiguration? EndpointConfiguration { get; set; }

    /// <summary>Whether warnings while API Gateway is creating or updating the resource should return an error or not. Defaults to false</summary>
    [JsonPropertyName("failOnWarnings")]
    public bool? FailOnWarnings { get; set; }

    /// <summary>Minimum response size to compress for the REST API. String containing an integer value between -1 and 10485760 (10MB). -1 will disable an existing compression configuration, and all other values will enable compression with the configured size. New resources can simply omit this argument to disable compression, rather than setting the value to -1. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-minimum-compression-size extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("minimumCompressionSize")]
    public string? MinimumCompressionSize { get; set; }

    /// <summary>Name of the REST API. If importing an OpenAPI specification via the body argument, this corresponds to the info.title field. If the argument value is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of customizations for importing the specification in the body argument. For example, to exclude DocumentationParts from an imported API, set ignore equal to documentation. Additional documentation, including other parameters such as basepath, can be found in the API Gateway Developer Guide.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Mode of the PutRestApi operation when importing an OpenAPI specification via the body argument (create or update operation). Valid values are merge and overwrite. If unspecificed, defaults to overwrite (for backwards compatibility). This corresponds to the x-amazon-apigateway-put-integration-method extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("putRestApiMode")]
    public string? PutRestApiMode { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolutionEnum>))]
public enum V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolveEnum>))]
public enum V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolveEnum>))]
public enum V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of VPCEndpoint in ec2 to populate vpcEndpointIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block defining API endpoint configuration including endpoint type. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecInitProviderEndpointConfiguration
{
    /// <summary>The IP address types that can invoke an API (RestApi). Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke an API, or use dualstack to allow both IPv4 and IPv6 addresses to invoke an API. For the PRIVATE endpoint type, only dualstack is supported.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>List of endpoint types. This resource currently only supports managing a single value. Valid values: EDGE, REGIONAL or PRIVATE. If unspecified, defaults to EDGE. If set to PRIVATE recommend to set put_rest_api_mode = merge to not cause the endpoints and associated Route53 records to be deleted. Refer to the documentation for more information on the difference between edge-optimized and regional APIs.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    /// <summary>Set of VPC Endpoint identifiers. It is only supported for PRIVATE endpoint type. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-endpoint-configuration extension vpcEndpointIds property. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("vpcEndpointIds")]
    public IList<string>? VpcEndpointIds { get; set; }

    /// <summary>References to VPCEndpoint in ec2 to populate vpcEndpointIds.</summary>
    [JsonPropertyName("vpcEndpointIdsRefs")]
    public IList<V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsRefs>? VpcEndpointIdsRefs { get; set; }

    /// <summary>Selector for a list of VPCEndpoint in ec2 to populate vpcEndpointIds.</summary>
    [JsonPropertyName("vpcEndpointIdsSelector")]
    public V1beta1RestAPISpecInitProviderEndpointConfigurationVpcEndpointIdsSelector? VpcEndpointIdsSelector { get; set; }
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
public partial class V1beta1RestAPISpecInitProvider
{
    /// <summary>Source of the API key for requests. Valid values are HEADER (default) and AUTHORIZER. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-api-key-source extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("apiKeySource")]
    public string? ApiKeySource { get; set; }

    /// <summary>List of binary media types supported by the REST API. By default, the REST API supports only UTF-8-encoded text payloads. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-binary-media-types extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("binaryMediaTypes")]
    public IList<string>? BinaryMediaTypes { get; set; }

    /// <summary>OpenAPI specification that defines the set of routes and integrations to create as part of the REST API. This configuration, and any updates to it, will replace all REST API configuration except values overridden in this resource configuration and other resource updates applied after this resource but before any aws_api_gateway_deployment creation. More information about REST API OpenAPI support can be found in the API Gateway Developer Guide.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Description of the REST API. If importing an OpenAPI specification via the body argument, this corresponds to the info.description field. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether clients can invoke your API by using the default execute-api endpoint. By default, clients can invoke your API with the default https://{api_id}.execute-api.{region}.amazonaws.com endpoint. To require that clients use a custom domain name to invoke your API, disable the default endpoint. Defaults to false. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-endpoint-configuration extension disableExecuteApiEndpoint property. If the argument value is true and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("disableExecuteApiEndpoint")]
    public bool? DisableExecuteApiEndpoint { get; set; }

    /// <summary>Configuration block defining API endpoint configuration including endpoint type. Defined below.</summary>
    [JsonPropertyName("endpointConfiguration")]
    public V1beta1RestAPISpecInitProviderEndpointConfiguration? EndpointConfiguration { get; set; }

    /// <summary>Whether warnings while API Gateway is creating or updating the resource should return an error or not. Defaults to false</summary>
    [JsonPropertyName("failOnWarnings")]
    public bool? FailOnWarnings { get; set; }

    /// <summary>Minimum response size to compress for the REST API. String containing an integer value between -1 and 10485760 (10MB). -1 will disable an existing compression configuration, and all other values will enable compression with the configured size. New resources can simply omit this argument to disable compression, rather than setting the value to -1. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-minimum-compression-size extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("minimumCompressionSize")]
    public string? MinimumCompressionSize { get; set; }

    /// <summary>Name of the REST API. If importing an OpenAPI specification via the body argument, this corresponds to the info.title field. If the argument value is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of customizations for importing the specification in the body argument. For example, to exclude DocumentationParts from an imported API, set ignore equal to documentation. Additional documentation, including other parameters such as basepath, can be found in the API Gateway Developer Guide.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Mode of the PutRestApi operation when importing an OpenAPI specification via the body argument (create or update operation). Valid values are merge and overwrite. If unspecificed, defaults to overwrite (for backwards compatibility). This corresponds to the x-amazon-apigateway-put-integration-method extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("putRestApiMode")]
    public string? PutRestApiMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RestAPISpecManagementPoliciesEnum>))]
public enum V1beta1RestAPISpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RestAPISpec defines the desired state of RestAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPISpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1RestAPISpecForProvider ForProvider { get; set; }

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
    public V1beta1RestAPISpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RestAPISpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RestAPISpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RestAPISpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block defining API endpoint configuration including endpoint type. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPIStatusAtProviderEndpointConfiguration
{
    /// <summary>The IP address types that can invoke an API (RestApi). Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke an API, or use dualstack to allow both IPv4 and IPv6 addresses to invoke an API. For the PRIVATE endpoint type, only dualstack is supported.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>List of endpoint types. This resource currently only supports managing a single value. Valid values: EDGE, REGIONAL or PRIVATE. If unspecified, defaults to EDGE. If set to PRIVATE recommend to set put_rest_api_mode = merge to not cause the endpoints and associated Route53 records to be deleted. Refer to the documentation for more information on the difference between edge-optimized and regional APIs.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }

    /// <summary>Set of VPC Endpoint identifiers. It is only supported for PRIVATE endpoint type. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-endpoint-configuration extension vpcEndpointIds property. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("vpcEndpointIds")]
    public IList<string>? VpcEndpointIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPIStatusAtProvider
{
    /// <summary>Source of the API key for requests. Valid values are HEADER (default) and AUTHORIZER. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-api-key-source extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("apiKeySource")]
    public string? ApiKeySource { get; set; }

    /// <summary>ARN</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>List of binary media types supported by the REST API. By default, the REST API supports only UTF-8-encoded text payloads. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-binary-media-types extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("binaryMediaTypes")]
    public IList<string>? BinaryMediaTypes { get; set; }

    /// <summary>OpenAPI specification that defines the set of routes and integrations to create as part of the REST API. This configuration, and any updates to it, will replace all REST API configuration except values overridden in this resource configuration and other resource updates applied after this resource but before any aws_api_gateway_deployment creation. More information about REST API OpenAPI support can be found in the API Gateway Developer Guide.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Creation date of the REST API</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>Description of the REST API. If importing an OpenAPI specification via the body argument, this corresponds to the info.description field. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether clients can invoke your API by using the default execute-api endpoint. By default, clients can invoke your API with the default https://{api_id}.execute-api.{region}.amazonaws.com endpoint. To require that clients use a custom domain name to invoke your API, disable the default endpoint. Defaults to false. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-endpoint-configuration extension disableExecuteApiEndpoint property. If the argument value is true and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("disableExecuteApiEndpoint")]
    public bool? DisableExecuteApiEndpoint { get; set; }

    /// <summary>Configuration block defining API endpoint configuration including endpoint type. Defined below.</summary>
    [JsonPropertyName("endpointConfiguration")]
    public V1beta1RestAPIStatusAtProviderEndpointConfiguration? EndpointConfiguration { get; set; }

    /// <summary>
    /// Execution ARN part to be used in lambda_permission&apos;s source_arn
    /// when allowing API Gateway to invoke a Lambda function,
    /// e.g., arn:aws:execute-api:eu-west-2:123456789012:z4675bid1j, which can be concatenated with allowed stage, method and resource path.
    /// </summary>
    [JsonPropertyName("executionArn")]
    public string? ExecutionArn { get; set; }

    /// <summary>Whether warnings while API Gateway is creating or updating the resource should return an error or not. Defaults to false</summary>
    [JsonPropertyName("failOnWarnings")]
    public bool? FailOnWarnings { get; set; }

    /// <summary>ID of the REST API</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Minimum response size to compress for the REST API. String containing an integer value between -1 and 10485760 (10MB). -1 will disable an existing compression configuration, and all other values will enable compression with the configured size. New resources can simply omit this argument to disable compression, rather than setting the value to -1. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-minimum-compression-size extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("minimumCompressionSize")]
    public string? MinimumCompressionSize { get; set; }

    /// <summary>Name of the REST API. If importing an OpenAPI specification via the body argument, this corresponds to the info.title field. If the argument value is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of customizations for importing the specification in the body argument. For example, to exclude DocumentationParts from an imported API, set ignore equal to documentation. Additional documentation, including other parameters such as basepath, can be found in the API Gateway Developer Guide.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>JSON formatted policy document that controls access to the API Gateway. We recommend using the aws_api_gateway_rest_api_policy resource instead. If importing an OpenAPI specification via the body argument, this corresponds to the x-amazon-apigateway-policy extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>Mode of the PutRestApi operation when importing an OpenAPI specification via the body argument (create or update operation). Valid values are merge and overwrite. If unspecificed, defaults to overwrite (for backwards compatibility). This corresponds to the x-amazon-apigateway-put-integration-method extension. If the argument value is provided and is different than the OpenAPI value, the argument value will override the OpenAPI value.</summary>
    [JsonPropertyName("putRestApiMode")]
    public string? PutRestApiMode { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Resource ID of the REST API&apos;s root</summary>
    [JsonPropertyName("rootResourceId")]
    public string? RootResourceId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPIStatusConditions
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

/// <summary>RestAPIStatus defines the observed state of RestAPI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RestAPIStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RestAPIStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RestAPIStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RestAPI is the Schema for the RestAPIs API. Manages an API Gateway REST API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RestAPI : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RestAPISpec>, IStatus<V1beta1RestAPIStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RestAPI";
    public const string KubeGroup = "apigateway.aws.m.upbound.io";
    public const string KubePluralName = "restapis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RestAPI";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RestAPISpec defines the desired state of RestAPI</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RestAPISpec Spec { get; set; }

    /// <summary>RestAPIStatus defines the observed state of RestAPI.</summary>
    [JsonPropertyName("status")]
    public V1beta1RestAPIStatus? Status { get; set; }
}